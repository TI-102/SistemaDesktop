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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }
        private void carregarCargos()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select cargo from tbfuncoes; ";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            cbbCargo.Items.Clear();
            while (DR.Read())
            {

                cbbCargo.Items.Add(DR.GetString(0));

            }
            Conexao.fecharConexao();
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "insert into tbfuncionarios (nome,SENHA,FUNCAO)VALUES"+
                "(@nome, @SENHA, @FUNCAO); ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.Clear();
                comm.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = txtUsuario.Text;
                comm.Parameters.Add("@SENHA", MySqlDbType.VarChar, 50).Value = txtSenha.Text;
                comm.Parameters.Add("@FUNCAO", MySqlDbType.Int32).Value = cbbCargo.SelectedIndex+1;
                comm.CommandType = CommandType.Text;
                comm.Connection = Conexao.obterConexao();
                int res = comm.ExecuteNonQuery();
                Conexao.fecharConexao();

                frmLogin abrir = new frmLogin();
                cbbCargo.Text = null;
                txtSenha.Text = null;
                txtConfirmar.Text = null;
                txtUsuario.Text = null;
                abrir.Show();
                this.Hide();
            }
            catch(MySqlException erro)
            {
                MessageBox.Show("Ocorreu um problema: "+erro.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmLogin abrir = new frmLogin();
            abrir.Show();
            this.Hide();
        }

        private void cbbCargo_Enter(object sender, EventArgs e)
        {
            carregarCargos();
            
        }


        private void senhaConfirma(object sender, EventArgs e)
        {
            if (txtConfirmar.Text.Equals(txtSenha.Text))
            {
                lblAviso.Text = null;
            }
            else
            {
                lblAviso.Text = "As senhas não são iguais. Tente novamente.";
            }
        }
    }
}
