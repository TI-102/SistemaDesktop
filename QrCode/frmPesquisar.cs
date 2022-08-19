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
    public partial class frmPesquisar : Form
    {
        public frmPesquisar()
        {

            InitializeComponent();
            txtPesquisa.Enabled = false;
            rbtCodigo.TabStop = true;
            rbtNome.TabStop = false;
            rbtNumero.TabStop = false;

        }
        public string campo;
        public static string itemPesquisado;


        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            string i;

            if (cbxPesquisa.SelectedIndex < 0)
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
                    //frmGerenciarFuncionarios abrirFunc = new frmGerenciarFuncionarios();
                    //abrirFunc.Show();
                    //this.Hide();
                    if (campo.Equals("nome") || campo.Equals("id"))
                    {
                        MySqlCommand comm = new MySqlCommand();
                        comm.CommandText = "select * from tbfuncionarios where " + campo +
            " like '%" + txtPesquisa.Text + "%'; ";
                        comm.CommandType = CommandType.Text;
                        comm.Connection = Conexao.obterConexao();
                        MySqlDataReader DR;
                        DR = comm.ExecuteReader();
                        lstDados.Items.Clear();
                        while (DR.Read())
                        {

                            lstDados.Items.Add(DR.GetInt32(0) + " - " + DR.GetString(1) + " - **********");

                        }
                        Conexao.fecharConexao();
                    }
                    else
                    {
                        rbtNumero.Checked = false;
                        rbtCodigo.Checked = true;
                    }


                    break;
                case "Produtos":

                    if (campo.Equals("nome") || campo.Equals("id"))
                    {
                        MySqlCommand comm = new MySqlCommand();
                        comm.CommandText = "select * from tbprodutos where " + campo +
            " like '%" + txtPesquisa.Text + "%'; ";
                        comm.CommandType = CommandType.Text;
                        comm.Connection = Conexao.obterConexao();
                        MySqlDataReader DR;
                        DR = comm.ExecuteReader();
                        lstDados.Items.Clear();
                        while (DR.Read())
                        {
                            lstDados.Items.Add(DR.GetInt32(0) + " - " + DR.GetString(1) + " - " +
                                DR.GetString(3));

                        }
                        Conexao.fecharConexao();
                    }
                    else
                    {
                        rbtNumero.Checked = false;
                        rbtCodigo.Checked = true;
                    }
                    break;
                case "Mesas":
                    //frmMesas abrirMesas = new frmMesas();
                    //abrirMesas.Show();
                    //this.Hide();
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
                cbxPesquisa.Focus();
            }
            if (rbtCodigo.Checked)
            {
                campo = "id";
            }
            else if (rbtNome.Checked)
            {
                campo = "nome";
            }
            else if (rbtNumero.Checked)
            {
                campo = "numero";
            }
        }

        private void lstDados_DoubleClick(object sender, EventArgs e)
        {
            if (lstDados.SelectedIndex >= 0)
            {
                string[] selectedItem;
                string i;

                if (cbxPesquisa.SelectedIndex < 0)
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
                        selectedItem = lstDados.SelectedItem.ToString().Split(" - ");
                        itemPesquisado = selectedItem[0];
                        frmGerenciarFuncionarios abrirFunc = new frmGerenciarFuncionarios();
                        abrirFunc.Show();
                        this.Hide();

                        break;
                    case "Produtos":

                        selectedItem = lstDados.SelectedItem.ToString().Split(" - ");
                        itemPesquisado = selectedItem[0];
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

                        break;

                }
            }
        }
       
        private void cbxPesquisa_Enter(object sender, EventArgs e)
        {
            if (cbxPesquisa.SelectedIndex <0)
            {
                cbxPesquisa.DroppedDown = true;
            }
            else
            {
                cbxPesquisa.DroppedDown = false;
            }
            
        }

        private void cbxPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPesquisa.Focus();
        }
    }
}
