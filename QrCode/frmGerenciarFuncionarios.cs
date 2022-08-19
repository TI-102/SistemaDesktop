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
    public partial class frmGerenciarFuncionarios : Form
    {
        public frmGerenciarFuncionarios()
        {
            InitializeComponent();
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private string idPesquisado;

        public void limparTudo()
        {
            txtNome.Text = null;
            txtSenha.Text = null;
            txtCodigo.Text = null;
            lblCargo.Text = null;
            txtNome.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu abrir = new frmMenu();
            abrir.Show();
            this.Hide();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisar abrir = new frmPesquisar();
            this.Hide();
            abrir.Show();
        }

        private void frmGerenciarFuncionarios_Load(object sender, EventArgs e)
        {
            limparTudo();
            txtNome.Focus();
            frmPesquisar frmPesquisar = new frmPesquisar();
            idPesquisado = frmPesquisar.itemPesquisado;
            txtCodigo.Text = idPesquisado;



            string cargo = "0";
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "select * from tbfuncionarios where id=" + txtCodigo.Text;
                comm.CommandType = CommandType.Text;
                comm.Connection = Conexao.obterConexao();
                MySqlDataReader DR;
                DR = comm.ExecuteReader();


                while (DR.Read())
                {
                    txtNome.Text = DR.GetString(1);
                    txtSenha.Text = DR.GetString(2);
                    txtCodigo.Text = DR.GetInt32(0).ToString();
                    cargo = DR.GetInt32(3).ToString();
                }
                Conexao.fecharConexao();

                comm.CommandText = "select * from tbfuncoes where id=" + cargo;
                comm.CommandType = CommandType.Text;
                comm.Connection = Conexao.obterConexao();
                
                DR = comm.ExecuteReader();

                while (DR.Read())
                {
                    lblCargo.Text = DR.GetString(1);
                }
                Conexao.fecharConexao();
            }
            catch (MySqlException)
            {

            }

            frmPesquisar.itemPesquisado = null;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

            if(txtCodigo.Text != null)
            {
                txtNome.Enabled = true;
                txtSenha.Enabled = true;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
            }
            else
            {
                txtNome.Enabled = false;
                txtSenha.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "UPDATE tbfuncionarios SET nome = @nome," +
                    " senha = @senha WHERE id = " + txtCodigo.Text;
                comm.CommandType = CommandType.Text;
                comm.Connection = Conexao.obterConexao();
                comm.Parameters.Clear();
                comm.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value =
                txtNome.Text;
                comm.Parameters.Add("@senha", MySqlDbType.VarChar, 50).Value =
                txtSenha.Text;

                int res = comm.ExecuteNonQuery();

            }
            catch (Exception error)
            {
                MessageBox.Show("Ocorreu uma falha: " + error.Message);

                Conexao.fecharConexao();
            }

            Conexao.fecharConexao();
            limparTudo();
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "DELETE FROM tbfuncionarios WHERE id=@codigo";
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
                    btnAlterar.Enabled = false;                 
                }
                else if (vresp == DialogResult.No)
                {
                    comm.Parameters.Clear();
                    Conexao.fecharConexao();                   
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;                   
                    txtNome.Text = null;                   
                    txtCodigo.Text = null;                    
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocorreu uma falha do tipo " + error.Message);

                Conexao.fecharConexao();

            }

            limparTudo();
        }
    }
}
