using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QrCode
{
    public partial class frmGerenciarFuncionarios : Form
    {
        public frmGerenciarFuncionarios()
        {
            InitializeComponent();
            txtCodigo.Enabled = false;
            btnCadastrar.Enabled = false;
        }
    }
}
