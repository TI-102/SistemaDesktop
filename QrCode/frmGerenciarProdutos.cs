using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu abrir = new frmMenu();
            abrir.Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbprodutos (NOME,DESCRICAO,VALOR,IMAGEM) VALUES (@NOME, @DESCRICAO, @VALOR, @IMAGEM);";
            comm.CommandType = CommandType.Text;
            comm.Parameters.Clear();
            comm.Parameters.Add("@NOME", MySqlDbType.VarChar, 50).Value = txtNome.Text;
            comm.Parameters.Add("@DESCRICAO", MySqlDbType.VarChar, 200).Value = txtDescricao.Text;
            comm.Parameters.Add("@VALOR", MySqlDbType.Decimal, 18).Value =txtValor.Text;
            comm.Parameters.Add("@IMAGEM", MySqlDbType.LongBlob).Value = null;
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();
            int res = comm.ExecuteNonQuery();
            //res = Quantidade de linhas inseridas
            Conexao.fecharConexao();

            txtDescricao.Text = null;
            txtNome.Text = null;
            txtValor.Text = null;
            btnCadastrar.Enabled = false;
            txtNome.Focus();
        }

        private void frmGerenciarProdutos_MouseMove(object sender, MouseEventArgs e)
        {
            if(txtNome.Text != "" && txtDescricao.Text != "" && txtValor.Text != "")
            {
                btnCadastrar.Enabled = true;
            }
            else
            {
                btnCadastrar.Enabled = false;
            }
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
            comm.Parameters.Add("@imagem", MySqlDbType.LongBlob).Value =
            null;
            int res = comm.ExecuteNonQuery();
            
            Conexao.fecharConexao();
            btnAdicionar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            txtDescricao.Text = null;
            txtNome.Text = null;
            txtValor.Text = null;
            txtCodigo.Text = null;
            //boxImagem = null;
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
                btnAdicionar.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                txtDescricao.Text = null;
                txtNome.Text = null;
                txtValor.Text = null;
                txtCodigo.Text = null;
                //boxImagem = null;
            }

        }
    }
}
