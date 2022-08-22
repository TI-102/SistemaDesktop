using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QrCode
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            frmGerenciarProdutos abrir = new frmGerenciarProdutos();
            abrir.Show();
            this.Hide();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            frmGerenciarFuncionarios abrir = new frmGerenciarFuncionarios();
            abrir.Show();
            this.Hide();
        }

        private void btnMesa_Click(object sender, EventArgs e)
        {
            frmMesas abrir = new frmMesas();
            abrir.Show();
            this.Hide();
        }

        

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmLogin abrir = new frmLogin();
            abrir.Show();
            this.Hide();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
