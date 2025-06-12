namespace MayinTarlasi
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
            this.cmbZorluk = new System.Windows.Forms.ComboBox();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.panelOyun = new System.Windows.Forms.Panel();
            this.lblPuan = new System.Windows.Forms.Label();
            this.lblBayrak = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelUst = new System.Windows.Forms.Panel();
            this.panelUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbZorluk
            // 
            this.cmbZorluk.FormattingEnabled = true;
            this.cmbZorluk.Items.AddRange(new object[] {
            "Kolay",
            "Orta",
            "Zor"});
            this.cmbZorluk.Location = new System.Drawing.Point(127, 22);
            this.cmbZorluk.Name = "cmbZorluk";
            this.cmbZorluk.Size = new System.Drawing.Size(295, 24);
            this.cmbZorluk.TabIndex = 0;
            // 
            // btnBaslat
            // 
            this.btnBaslat.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaslat.Location = new System.Drawing.Point(428, 9);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(152, 45);
            this.btnBaslat.TabIndex = 1;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // panelOyun
            // 
            this.panelOyun.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOyun.Location = new System.Drawing.Point(0, 66);
            this.panelOyun.Name = "panelOyun";
            this.panelOyun.Size = new System.Drawing.Size(1429, 637);
            this.panelOyun.TabIndex = 2;
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.Location = new System.Drawing.Point(1089, 15);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(141, 39);
            this.lblPuan.TabIndex = 3;
            this.lblPuan.Text = "Puan: 0";
            this.lblPuan.Click += new System.EventHandler(this.lblPuan_Click);
            // 
            // lblBayrak
            // 
            this.lblBayrak.AutoSize = true;
            this.lblBayrak.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBayrak.Location = new System.Drawing.Point(870, 12);
            this.lblBayrak.Name = "lblBayrak";
            this.lblBayrak.Size = new System.Drawing.Size(201, 32);
            this.lblBayrak.TabIndex = 4;
            this.lblBayrak.Text = "Bayrak: 0 / 10";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.Location = new System.Drawing.Point(603, 10);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(133, 39);
            this.lblSure.TabIndex = 5;
            this.lblSure.Text = "Süre: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Zorluk Seç>";
            // 
            // panelUst
            // 
            this.panelUst.BackColor = System.Drawing.Color.LightGray;
            this.panelUst.Controls.Add(this.label1);
            this.panelUst.Controls.Add(this.lblBayrak);
            this.panelUst.Controls.Add(this.lblSure);
            this.panelUst.Controls.Add(this.cmbZorluk);
            this.panelUst.Controls.Add(this.btnBaslat);
            this.panelUst.Controls.Add(this.lblPuan);
            this.panelUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUst.Location = new System.Drawing.Point(0, 0);
            this.panelUst.Name = "panelUst";
            this.panelUst.Size = new System.Drawing.Size(1429, 60);
            this.panelUst.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 703);
            this.Controls.Add(this.panelUst);
            this.Controls.Add(this.panelOyun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelUst.ResumeLayout(false);
            this.panelUst.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbZorluk;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Panel panelOyun;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label lblBayrak;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelUst;
    }
}

