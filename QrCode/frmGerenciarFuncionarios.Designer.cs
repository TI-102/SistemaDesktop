
namespace QrCode
{
    partial class frmGerenciarFuncionarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGerenciarFuncionario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGerenciarFuncionario
            // 
            this.lblGerenciarFuncionario.AutoSize = true;
            this.lblGerenciarFuncionario.Location = new System.Drawing.Point(270, 22);
            this.lblGerenciarFuncionario.Name = "lblGerenciarFuncionario";
            this.lblGerenciarFuncionario.Size = new System.Drawing.Size(123, 15);
            this.lblGerenciarFuncionario.TabIndex = 0;
            this.lblGerenciarFuncionario.Text = "Gerenciar Funcionario";
            // 
            // frmGerenciarFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGerenciarFuncionario);
            this.Name = "frmGerenciarFuncionarios";
            this.Text = "frmGerenciarFuncionarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGerenciarFuncionario;
    }
}