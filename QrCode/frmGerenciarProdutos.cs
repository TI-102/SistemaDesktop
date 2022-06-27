using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
    }
}
