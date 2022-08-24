using System;
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
        private string idPesquisado = null;
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
            txtCodigo.Text = null;
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
                MessageBox.Show("Ocorreu uma falha: " + error.Message);
                
                Conexao.fecharConexao();
                
            }
            

            limparTudo();
            btnAdicionarImg.Enabled = true;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            idPesquisado = null;
            frmPesquisar abrir = new frmPesquisar();
            limparTudo();
            this.Hide();
            abrir.Show();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try 
            {
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                idPesquisado = null;
                MySqlCommand comm = new MySqlCommand();
                    comm.CommandText = "UPDATE tbprodutos SET descricao = @descricao,nome = @nome," +
                        " valor = @valor WHERE id = " + txtCodigo.Text;
                    comm.CommandType = CommandType.Text;
                    comm.Connection = Conexao.obterConexao();
                    comm.Parameters.Clear();
                    comm.Parameters.Add("@descricao", MySqlDbType.VarChar, 200).Value =
                    txtDescricao.Text;
                    comm.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value =
                    txtNome.Text;
                    comm.Parameters.Add("@valor", MySqlDbType.Decimal, 18).Value =
                    txtValor.Text;
            
                    int res = comm.ExecuteNonQuery();
                    Conexao.fecharConexao();
                idPesquisado = null;
                limparTudo();
                
            }
            catch(Exception error)
            {
                MessageBox.Show("Ocorreu uma falha: " + error.Message);
                
                Conexao.fecharConexao();
                limparTudo();
                
            }


            
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try 
            {
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                idPesquisado = null;
                lblMsg.Text = null;
                MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "DELETE FROM tbprodutos WHERE id=@codigo";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();
            comm.Parameters.Clear();
            comm.Parameters.Add("@codigo", MySqlDbType.Int32).Value =
            txtCodigo.Text;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            DialogResult vresp;
            vresp = MessageBox.Show("Deseja Realizar a Exclusão?", "Mensagem do " +
                "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
            MessageBoxDefaultButton.Button2);
                
                if (vresp == DialogResult.Yes)
            {
                int res = comm.ExecuteNonQuery();
                MessageBox.Show("Registro Excluido com Sucesso!!! ");
                comm.Parameters.Clear();
                pctImageProd.Image = null;
                btnAdicionarImg.Enabled = true;
                btnAdicionarImg.Focus();
                btnCadastrar.Enabled = true;
                txtCodigo.Text = null;
                
                }
            else if (vresp == DialogResult.No)
            {
                comm.Parameters.Clear();
                Conexao.fecharConexao();
                btnAdicionarImg.Enabled = true;
                txtDescricao.Text = null;
                txtNome.Text = null;
                txtValor.Text = null;
                txtCodigo.Text = null;
                pctImageProd.Image = null;
            }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocorreu uma falha do tipo " + error.Message);

                Conexao.fecharConexao();

            }

        }
        
        private void onValueInsert(object sender, KeyEventArgs e)
        {
if (txtNome.Text != "" && txtDescricao.Text != "" && txtValor.Text != "" && idPesquisado == null)
            {
                btnCadastrar.Enabled = true;
                btnAdicionarImg.Enabled = true;
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
                        dlg.Filter = "All files (*.*)|*.*";

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

        private void frmGerenciarProdutos_Load(object sender, EventArgs e)
        {
            limparTudo();
            txtNome.Focus();
            frmPesquisar frmPesquisar = new frmPesquisar();
            idPesquisado = frmPesquisar.itemPesquisado;
            txtCodigo.Text = idPesquisado;

            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "select * from tbprodutos where id="+txtCodigo.Text;
                comm.CommandType = CommandType.Text;
                comm.Connection = Conexao.obterConexao();
                MySqlDataReader DR;
                DR = comm.ExecuteReader();
               

                while (DR.Read())
                {
                    txtNome.Text = DR.GetString(1);
                    txtDescricao.Text = DR.GetString(2);
                    txtValor.Text = DR.GetString(3);

                    byte[] img = (byte[])DR["imagem"];

                    MemoryStream ms = new MemoryStream(img);
                    
                    ms.Seek(0, SeekOrigin.Begin);
         
                    pctImageProd.Image = Image.FromStream(ms);


                }

            }
            catch (Exception erro)
            {
                
            }

            frmPesquisar.itemPesquisado = null;
            
            
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (idPesquisado == null)
            {
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnAdicionarImg.Enabled = true;
                lblMsg.Text = null;
            }
            else
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnAdicionarImg.Enabled = false;
                lblMsg.Text = "Para Alterar imagem, clique em deletar.";
            }
        }
    }
}
