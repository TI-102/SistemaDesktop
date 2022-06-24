
namespace QrCode
{
    partial class frmVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendas));
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.rbtFunc = new System.Windows.Forms.RadioButton();
            this.rbtMesa = new System.Windows.Forms.RadioButton();
            this.rbtData = new System.Windows.Forms.RadioButton();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.gpbPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVendas
            // 
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Location = new System.Drawing.Point(19, 126);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.RowTemplate.Height = 25;
            this.dgvVendas.Size = new System.Drawing.Size(763, 319);
            this.dgvVendas.TabIndex = 0;
            // 
            // gpbPesquisa
            // 
            this.gpbPesquisa.Controls.Add(this.rbtData);
            this.gpbPesquisa.Controls.Add(this.rbtMesa);
            this.gpbPesquisa.Controls.Add(this.rbtFunc);
            this.gpbPesquisa.Location = new System.Drawing.Point(19, 12);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(269, 66);
            this.gpbPesquisa.TabIndex = 1;
            this.gpbPesquisa.TabStop = false;
            this.gpbPesquisa.Text = "Pesquisar Por";
            // 
            // rbtFunc
            // 
            this.rbtFunc.AutoSize = true;
            this.rbtFunc.Location = new System.Drawing.Point(6, 32);
            this.rbtFunc.Name = "rbtFunc";
            this.rbtFunc.Size = new System.Drawing.Size(88, 19);
            this.rbtFunc.TabIndex = 0;
            this.rbtFunc.TabStop = true;
            this.rbtFunc.Text = "Funcionário";
            this.rbtFunc.UseVisualStyleBackColor = true;
            // 
            // rbtMesa
            // 
            this.rbtMesa.AutoSize = true;
            this.rbtMesa.Location = new System.Drawing.Point(123, 32);
            this.rbtMesa.Name = "rbtMesa";
            this.rbtMesa.Size = new System.Drawing.Size(53, 19);
            this.rbtMesa.TabIndex = 1;
            this.rbtMesa.TabStop = true;
            this.rbtMesa.Text = "Mesa";
            this.rbtMesa.UseVisualStyleBackColor = true;
            // 
            // rbtData
            // 
            this.rbtData.AutoSize = true;
            this.rbtData.Location = new System.Drawing.Point(208, 32);
            this.rbtData.Name = "rbtData";
            this.rbtData.Size = new System.Drawing.Size(49, 19);
            this.rbtData.TabIndex = 2;
            this.rbtData.TabStop = true;
            this.rbtData.Text = "Data";
            this.rbtData.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(19, 84);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(385, 23);
            this.txtPesquisar.TabIndex = 2;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(620, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(162, 95);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(435, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(179, 95);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.gpbPesquisa);
            this.Controls.Add(this.dgvVendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.gpbPesquisa.ResumeLayout(false);
            this.gpbPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        private System.Windows.Forms.RadioButton rbtData;
        private System.Windows.Forms.RadioButton rbtMesa;
        private System.Windows.Forms.RadioButton rbtFunc;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnPesquisar;
    }
}