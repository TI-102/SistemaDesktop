
namespace QrCode
{
    partial class frmMenu
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
            System.Windows.Forms.Button btnFunc;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnCard = new System.Windows.Forms.Button();
            this.btnMesa = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            btnFunc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFunc
            // 
            btnFunc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnFunc.Image = ((System.Drawing.Image)(resources.GetObject("btnFunc.Image")));
            btnFunc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnFunc.Location = new System.Drawing.Point(406, 261);
            btnFunc.Name = "btnFunc";
            btnFunc.Size = new System.Drawing.Size(195, 177);
            btnFunc.TabIndex = 2;
            btnFunc.Text = "Funcionários";
            btnFunc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnFunc.UseVisualStyleBackColor = true;
            // 
            // btnCard
            // 
            this.btnCard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCard.Image = ((System.Drawing.Image)(resources.GetObject("btnCard.Image")));
            this.btnCard.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCard.Location = new System.Drawing.Point(167, 65);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(195, 177);
            this.btnCard.TabIndex = 0;
            this.btnCard.Text = "Cardápio";
            this.btnCard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCard.UseVisualStyleBackColor = true;
            // 
            // btnMesa
            // 
            this.btnMesa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMesa.Image = ((System.Drawing.Image)(resources.GetObject("btnMesa.Image")));
            this.btnMesa.Location = new System.Drawing.Point(167, 261);
            this.btnMesa.Name = "btnMesa";
            this.btnMesa.Size = new System.Drawing.Size(195, 177);
            this.btnMesa.TabIndex = 1;
            this.btnMesa.Text = "Mesa";
            this.btnMesa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMesa.UseVisualStyleBackColor = true;
            // 
            // btnVendas
            // 
            this.btnVendas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVendas.Image = ((System.Drawing.Image)(resources.GetObject("btnVendas.Image")));
            this.btnVendas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVendas.Location = new System.Drawing.Point(406, 65);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(195, 177);
            this.btnVendas.TabIndex = 3;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVendas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(287, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menu Principal";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVendas);
            this.Controls.Add(btnFunc);
            this.Controls.Add(this.btnMesa);
            this.Controls.Add(this.btnCard);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Button btnMesa;
        private System.Windows.Forms.Button btnFunc;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Label label1;
    }
}