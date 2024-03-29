﻿
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            btnFunc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFunc
            // 
            btnFunc.BackColor = System.Drawing.Color.FloralWhite;
            btnFunc.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnFunc.ForeColor = System.Drawing.Color.Black;
            btnFunc.Image = ((System.Drawing.Image)(resources.GetObject("btnFunc.Image")));
            btnFunc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnFunc.Location = new System.Drawing.Point(545, 150);
            btnFunc.Name = "btnFunc";
            btnFunc.Size = new System.Drawing.Size(195, 177);
            btnFunc.TabIndex = 3;
            btnFunc.Text = "Funcionários";
            btnFunc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnFunc.UseVisualStyleBackColor = false;
            btnFunc.Click += new System.EventHandler(this.btnFunc_Click);
            // 
            // btnCard
            // 
            this.btnCard.BackColor = System.Drawing.Color.FloralWhite;
            this.btnCard.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCard.ForeColor = System.Drawing.Color.Black;
            this.btnCard.Image = ((System.Drawing.Image)(resources.GetObject("btnCard.Image")));
            this.btnCard.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCard.Location = new System.Drawing.Point(55, 150);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(195, 177);
            this.btnCard.TabIndex = 0;
            this.btnCard.Text = "Cardápio";
            this.btnCard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCard.UseVisualStyleBackColor = false;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // btnMesa
            // 
            this.btnMesa.BackColor = System.Drawing.Color.FloralWhite;
            this.btnMesa.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMesa.ForeColor = System.Drawing.Color.Black;
            this.btnMesa.Image = ((System.Drawing.Image)(resources.GetObject("btnMesa.Image")));
            this.btnMesa.Location = new System.Drawing.Point(300, 150);
            this.btnMesa.Name = "btnMesa";
            this.btnMesa.Size = new System.Drawing.Size(195, 177);
            this.btnMesa.TabIndex = 2;
            this.btnMesa.Text = "Mesas";
            this.btnMesa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMesa.UseVisualStyleBackColor = false;
            this.btnMesa.Click += new System.EventHandler(this.btnMesa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 40);
            this.label1.TabIndex = 89;
            this.label1.Text = "Menu Principal";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(700, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(88, 36);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Sair";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.ControlBox = false;
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(btnFunc);
            this.Controls.Add(this.btnMesa);
            this.Controls.Add(this.btnCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Button btnMesa;
        private System.Windows.Forms.Button btnFunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
    }
}