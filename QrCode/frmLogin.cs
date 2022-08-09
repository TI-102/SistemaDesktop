﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace QrCode
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private bool logged = false;

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastro abrir = new frmCadastro();
            abrir.Show();
            this.Hide();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            bool status = acessoSistema();
                logged = status;
            if (status)
            {
                frmCarregando abrir = new frmCarregando();
                abrir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.");
                txtUsuario.Text = null;
                txtSenha.Text = null;
                txtUsuario.Focus();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool acessoSistema()
        {
            bool resultado = false;
            try
            {
                Conexao.obterConexao();
                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "SELECT * FROM tbfuncionarios WHERE username='" + txtUsuario.Text + "'AND senha = '" + txtSenha.Text + "'";
                comm.CommandType = CommandType.Text;
                comm.Connection = Conexao.obterConexao();
                MySqlDataReader DR;
                DR = comm.ExecuteReader();
                resultado = DR.HasRows;
                Conexao.fecharConexao();
                
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ocorreu uma falha: ");
            }
            return resultado;
        }
    }
}