
namespace QrCode
{
    partial class frmGerenciarMesas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarMesas));
            this.pnlCrud = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblQrcode = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnQrcode = new System.Windows.Forms.Button();
            this.pctQrcode = new System.Windows.Forms.PictureBox();
            this.pnlCrud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctQrcode)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCrud
            // 
            this.pnlCrud.Controls.Add(this.btnExcluir);
            this.pnlCrud.Controls.Add(this.btnCadastrar);
            this.pnlCrud.Controls.Add(this.btnPesquisar);
            this.pnlCrud.Controls.Add(this.btnAlterar);
            this.pnlCrud.Location = new System.Drawing.Point(12, 31);
            this.pnlCrud.Name = "pnlCrud";
            this.pnlCrud.Size = new System.Drawing.Size(177, 415);
            this.pnlCrud.TabIndex = 0;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(12, 323);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExcluir.Size = new System.Drawing.Size(153, 79);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(12, 11);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(153, 79);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(12, 114);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(153, 79);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(12, 219);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(153, 79);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(337, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(114, 53);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(209, 87);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 15);
            this.lblCodigo.TabIndex = 9;
            this.lblCodigo.Text = "Código";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(209, 124);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(51, 15);
            this.lblNumero.TabIndex = 10;
            this.lblNumero.Text = "Número";
            // 
            // lblQrcode
            // 
            this.lblQrcode.AutoSize = true;
            this.lblQrcode.Location = new System.Drawing.Point(209, 162);
            this.lblQrcode.Name = "lblQrcode";
            this.lblQrcode.Size = new System.Drawing.Size(51, 15);
            this.lblQrcode.TabIndex = 11;
            this.lblQrcode.Text = "QRCode";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(277, 84);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(93, 23);
            this.txtCodigo.TabIndex = 12;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(277, 121);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(93, 23);
            this.txtNumero.TabIndex = 13;
            // 
            // btnQrcode
            // 
            this.btnQrcode.Location = new System.Drawing.Point(277, 156);
            this.btnQrcode.Name = "btnQrcode";
            this.btnQrcode.Size = new System.Drawing.Size(93, 27);
            this.btnQrcode.TabIndex = 14;
            this.btnQrcode.Text = "Inserir";
            this.btnQrcode.UseVisualStyleBackColor = true;
            this.btnQrcode.Click += new System.EventHandler(this.button1_Click);
            // 
            // pctQrcode
            // 
            this.pctQrcode.Location = new System.Drawing.Point(209, 208);
            this.pctQrcode.Name = "pctQrcode";
            this.pctQrcode.Size = new System.Drawing.Size(232, 232);
            this.pctQrcode.TabIndex = 15;
            this.pctQrcode.TabStop = false;
            // 
            // frmMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 458);
            this.ControlBox = false;
            this.Controls.Add(this.pctQrcode);
            this.Controls.Add(this.btnQrcode);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblQrcode);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.pnlCrud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmMesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Mesas";
            this.pnlCrud.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctQrcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCrud;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblQrcode;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnQrcode;
        private System.Windows.Forms.PictureBox pctQrcode;
    }
}