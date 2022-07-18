using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QrCode
{
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
            rbtData.TabStop = false;
            rbtFuncionario.TabStop = false;
            rbtMesa.TabStop = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu abrir = new frmMenu();
            abrir.Show();
            this.Hide();
        }
    }
}
