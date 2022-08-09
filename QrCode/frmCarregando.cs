using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QrCode
{
    public partial class frmCarregando : Form
    {
        public Boolean loaded = false;  
        public frmCarregando()
        {
            InitializeComponent();
        }

        private void tmrCarregar_Tick(object sender, EventArgs e)
        {
            if (prbCarregando.Value < 100)
            {
                prbCarregando.Value = prbCarregando.Value + 5;
                lblCarregando.Text = prbCarregando.Value.ToString() + "%";
            }

            if (prbCarregando.Value == 100)
            {
                tmrCarregar.Enabled = false;
                loaded = true;
                this.Hide();
                frmMenu abrir = new frmMenu();
                abrir.Show();

                
            }
        }

        private void frmCarregando_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void frmCarregando_Load(object sender, EventArgs e)
        {

        }
    }
}
