﻿namespace WindowsFormlaraGiris
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_birinciNot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ikinciNot = new System.Windows.Forms.TextBox();
            this.btn_OrtalamaHesapla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_OrtalamaSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.Notunuzu Giriniz:";
            // 
            // txt_birinciNot
            // 
            this.txt_birinciNot.Location = new System.Drawing.Point(204, 36);
            this.txt_birinciNot.Name = "txt_birinciNot";
            this.txt_birinciNot.Size = new System.Drawing.Size(153, 20);
            this.txt_birinciNot.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(36, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "2.Notunuzu Giriniz:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_ikinciNot
            // 
            this.txt_ikinciNot.Location = new System.Drawing.Point(204, 79);
            this.txt_ikinciNot.Name = "txt_ikinciNot";
            this.txt_ikinciNot.Size = new System.Drawing.Size(153, 20);
            this.txt_ikinciNot.TabIndex = 1;
            this.txt_ikinciNot.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_OrtalamaHesapla
            // 
            this.btn_OrtalamaHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_OrtalamaHesapla.Location = new System.Drawing.Point(39, 127);
            this.btn_OrtalamaHesapla.Name = "btn_OrtalamaHesapla";
            this.btn_OrtalamaHesapla.Size = new System.Drawing.Size(131, 23);
            this.btn_OrtalamaHesapla.TabIndex = 2;
            this.btn_OrtalamaHesapla.Text = "Ortalamayı Bul";
            this.btn_OrtalamaHesapla.UseVisualStyleBackColor = true;
            this.btn_OrtalamaHesapla.Click += new System.EventHandler(this.btn_OrtalamaHesapla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(261, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ortalama:";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_OrtalamaSonuc
            // 
            this.lbl_OrtalamaSonuc.AutoSize = true;
            this.lbl_OrtalamaSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_OrtalamaSonuc.Location = new System.Drawing.Point(340, 132);
            this.lbl_OrtalamaSonuc.Name = "lbl_OrtalamaSonuc";
            this.lbl_OrtalamaSonuc.Size = new System.Drawing.Size(17, 18);
            this.lbl_OrtalamaSonuc.TabIndex = 0;
            this.lbl_OrtalamaSonuc.Text = "0";
            this.lbl_OrtalamaSonuc.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 237);
            this.Controls.Add(this.btn_OrtalamaHesapla);
            this.Controls.Add(this.txt_ikinciNot);
            this.Controls.Add(this.txt_birinciNot);
            this.Controls.Add(this.lbl_OrtalamaSonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_birinciNot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ikinciNot;
        private System.Windows.Forms.Button btn_OrtalamaHesapla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_OrtalamaSonuc;
    }
}

