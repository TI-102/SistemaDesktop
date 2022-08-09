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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "insert into produtos (USUARIO,SENHA,FUNCAO)VALUES" +
                    "(@USUARIO, @SENHA, @FUNCAO); ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.Clear();
                comm.Parameters.Add("@USUARIO", MySqlDbType.VarChar, 50).Value = txtUsuario.Text;
                comm.Parameters.Add("@SENHA", MySqlDbType.VarChar, 50).Value = txtSenha.Text;
                comm.Parameters.Add("@FUNCAO", MySqlDbType.VarChar, 40).Value = cbbCargo.Text;
                comm.CommandType = CommandType.Text;
                comm.Connection = Conexao.obterConexao();
                int res = comm.ExecuteNonQuery();
                Conexao.fecharConexao();

                frmLogin abrir = new frmLogin();
                cbbCargo.Text = null;
                txtSenha.Text = null;
                txtUsuario.Text = null;
                abrir.Show();
                this.Hide();
            }
            catch(MySqlException)
            {
                MessageBox.Show("Ocorreu um problema.");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmLogin abrir = new frmLogin();
            abrir.Show();
            this.Hide();
        }
    }
}
