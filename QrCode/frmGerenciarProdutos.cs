﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace QrCode
{
    public partial class frmGerenciarProdutos : Form
    {
        
        public frmGerenciarProdutos()
        {
            InitializeComponent();
            txtCodigo.Enabled = false;
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            
        }
        private static string _fname;
        private static byte[] photo;

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu abrir = new frmMenu();
            abrir.Show();
            this.Hide();
        }
        private void limparTudo()
        {
            txtDescricao.Text = null;
            txtNome.Text = null;
            txtValor.Text = null;
            btnCadastrar.Enabled = false;
            pctImageProd.Image = null;
            _fname = null;
            txtNome.Focus();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
           
            MySqlCommand comm = new MySqlCommand();
            photo = GetPhoto(_fname);
            try
            {
                comm.CommandText = "insert into tbprodutos (NOME,DESCRICAO,VALOR,IMAGEM) VALUES (@NOME, @DESCRICAO, @VALOR, @IMAGEM);";
                comm.CommandType = CommandType.Text;
                comm.Parameters.Clear();
                comm.Parameters.Add("@NOME", MySqlDbType.VarChar, 50).Value = txtNome.Text;
                comm.Parameters.Add("@DESCRICAO", MySqlDbType.VarChar, 200).Value = txtDescricao.Text;
                comm.Parameters.Add("@VALOR", MySqlDbType.Decimal, 18).Value = txtValor.Text;
                if(photo != null)
                {
                    comm.Parameters.Add("@IMAGEM", MySqlDbType.LongBlob, photo.Length).Value = photo;
                }    
                comm.CommandType = CommandType.Text;
                comm.Connection = Conexao.obterConexao();
                int res = comm.ExecuteNonQuery();
                //res = Quantidade de linhas inseridas
                Conexao.fecharConexao();
            }
            catch(Exception error)
            {
                MessageBox.Show("Ocorreu uma falha do tipo " + error.InnerException.Message);
                
                Conexao.fecharConexao();
                
            }
            

            limparTudo();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisar abrir = new frmPesquisar();
            this.Hide();
            abrir.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "UPDATE tbprodutos SET descricao = @descricao,nome = @nome," +
                " valor = @valor,imagem = @imagem WHERE codigo = " + txtCodigo.Text;
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();
            comm.Parameters.Clear();
            comm.Parameters.Add("@descricao", MySqlDbType.VarChar, 200).Value =
            txtDescricao.Text;
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value =
            txtNome.Text;
            comm.Parameters.Add("@valor", MySqlDbType.Decimal, 18).Value =
            txtValor.Text;
            comm.Parameters.Add("@imagem", MySqlDbType.LongBlob, photo.Length).Value =
            photo;
            int res = comm.ExecuteNonQuery();
            
            Conexao.fecharConexao();
            btnAdicionarImg.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            txtDescricao.Text = null;
            txtNome.Text = null;
            txtValor.Text = null;
            txtCodigo.Text = null;
            pctImageProd.Image = null;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "DELETE FROM tbprodutos WHERE codigo=@codigo";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();
            comm.Parameters.Clear();
            comm.Parameters.Add("@codigo", MySqlDbType.Int32).Value =
            txtCodigo.Text;
            DialogResult vresp;
            vresp = MessageBox.Show("Deseja Realizar a Exclusão?", "Mensagem do " +
                "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
            MessageBoxDefaultButton.Button2);
            if (vresp == DialogResult.Yes)
            {
                int res = comm.ExecuteNonQuery();
                MessageBox.Show("Registro Excluido com Sucesso!!! ");
                comm.Parameters.Clear();
            }
            else if (vresp == DialogResult.No)
            {
                comm.Parameters.Clear();
                Conexao.fecharConexao();
                btnAdicionarImg.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                txtDescricao.Text = null;
                txtNome.Text = null;
                txtValor.Text = null;
                txtCodigo.Text = null;
                pctImageProd.Image = null;
            }
            
        }

        private void onValueInsert(object sender, KeyEventArgs e)
        {
if (txtNome.Text != "" && txtDescricao.Text != "" && txtValor.Text != "")
            {
                btnCadastrar.Enabled = true;
            }
            else
            {
                btnCadastrar.Enabled = false;
            }
        }

        private void btnAdicionarImg_Click(object sender, EventArgs e)
        {
            
        OpenFileDialog dlg = new OpenFileDialog();
            
                        dlg.Title = "Open Photo";
                        dlg.Filter = "PNG (*.png)|*.png"
                            + "|All files (*.*)|*.*";

                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                pctImageProd.Image = new Bitmap(dlg.OpenFile());
                                _fname = dlg.FileName;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Unable to load file: " + ex.Message);
                            }
                        }
            dlg.Dispose();

        }
        public static byte[] GetPhoto(string filePath)
        {
            try
            {
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);

                photo = br.ReadBytes((int)fs.Length);

                br.Close();
                fs.Close();
            
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Por favor, insira uma imagem.");
            }
                return photo;
        }
        
    }
}
