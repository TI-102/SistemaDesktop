using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QrCode
{
    public partial class frmPesquisar : Form
    {
        public frmPesquisar()
        {
            InitializeComponent();
            rbtCodigo.TabStop = false;
            rbtNome.TabStop = false;
            rbtNumero.TabStop = false;

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string i;
            if(cbxPesquisa.SelectedIndex < 0)
            {
            i = "a";
            }
            else
            {
            i = cbxPesquisa.SelectedItem.ToString();
            }
            switch (i)
            {
                case "Funcionários":
                    frmGerenciarFuncionarios abrirFunc = new frmGerenciarFuncionarios();
                    abrirFunc.Show();
                    this.Hide();
                    break;
                case "Produtos":
                    frmGerenciarProdutos abrirProd = new frmGerenciarProdutos();
                    abrirProd.Show();
                    this.Hide();
                    break;
                case "Mesas":
                    frmMesas abrirMesas = new frmMesas();
                    abrirMesas.Show();
                    this.Hide();
                    break;
                default:
                    MessageBox.Show("Selecione uma opção para onde pesquisar:");
                    cbxPesquisa.Focus();
                    break;

            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu abrir = new frmMenu();
            this.Hide();
            abrir.Show();
        }

        private void Radiobuttons_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtCodigo.Checked || rbtNome.Checked || rbtNumero.Checked)
            {
                txtPesquisa.Enabled = true;
            }
            if (rbtCodigo.Checked)
            {

            }
            else if (rbtNome.Checked)
            {

            }
            else if (rbtNumero.Checked)
            {

            }
        }
    }
}
