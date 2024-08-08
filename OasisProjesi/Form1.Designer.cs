
namespace OasisProjesi
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAd = new System.Windows.Forms.TextBox();
            this.tbSoyad = new System.Windows.Forms.TextBox();
            this.tbVize = new System.Windows.Forms.TextBox();
            this.tbFinal = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lbAd = new System.Windows.Forms.ListBox();
            this.lbSoyad = new System.Windows.Forms.ListBox();
            this.lbVize = new System.Windows.Forms.ListBox();
            this.lbFinal = new System.Windows.Forms.ListBox();
            this.lbDurum = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vize";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(87, 27);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(100, 20);
            this.tbAd.TabIndex = 5;
            // 
            // tbSoyad
            // 
            this.tbSoyad.Location = new System.Drawing.Point(87, 58);
            this.tbSoyad.Name = "tbSoyad";
            this.tbSoyad.Size = new System.Drawing.Size(100, 20);
            this.tbSoyad.TabIndex = 6;
            // 
            // tbVize
            // 
            this.tbVize.Location = new System.Drawing.Point(87, 91);
            this.tbVize.Name = "tbVize";
            this.tbVize.Size = new System.Drawing.Size(100, 20);
            this.tbVize.TabIndex = 7;
            // 
            // tbFinal
            // 
            this.tbFinal.Location = new System.Drawing.Point(87, 124);
            this.tbFinal.Name = "tbFinal";
            this.tbFinal.Size = new System.Drawing.Size(100, 20);
            this.tbFinal.TabIndex = 8;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(208, 19);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(282, 61);
            this.btnHesapla.TabIndex = 9;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(208, 91);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(282, 53);
            this.btnTemizle.TabIndex = 10;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lbAd
            // 
            this.lbAd.FormattingEnabled = true;
            this.lbAd.Location = new System.Drawing.Point(12, 166);
            this.lbAd.Name = "lbAd";
            this.lbAd.Size = new System.Drawing.Size(90, 173);
            this.lbAd.TabIndex = 11;
            // 
            // lbSoyad
            // 
            this.lbSoyad.FormattingEnabled = true;
            this.lbSoyad.Location = new System.Drawing.Point(108, 166);
            this.lbSoyad.Name = "lbSoyad";
            this.lbSoyad.Size = new System.Drawing.Size(90, 173);
            this.lbSoyad.TabIndex = 12;
            // 
            // lbVize
            // 
            this.lbVize.FormattingEnabled = true;
            this.lbVize.Location = new System.Drawing.Point(208, 166);
            this.lbVize.Name = "lbVize";
            this.lbVize.Size = new System.Drawing.Size(90, 173);
            this.lbVize.TabIndex = 13;
            // 
            // lbFinal
            // 
            this.lbFinal.FormattingEnabled = true;
            this.lbFinal.Location = new System.Drawing.Point(304, 166);
            this.lbFinal.Name = "lbFinal";
            this.lbFinal.Size = new System.Drawing.Size(90, 173);
            this.lbFinal.TabIndex = 14;
            // 
            // lbDurum
            // 
            this.lbDurum.FormattingEnabled = true;
            this.lbDurum.Location = new System.Drawing.Point(400, 166);
            this.lbDurum.Name = "lbDurum";
            this.lbDurum.Size = new System.Drawing.Size(90, 173);
            this.lbDurum.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 357);
            this.Controls.Add(this.lbDurum);
            this.Controls.Add(this.lbFinal);
            this.Controls.Add(this.lbVize);
            this.Controls.Add(this.lbSoyad);
            this.Controls.Add(this.lbAd);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.tbFinal);
            this.Controls.Add(this.tbVize);
            this.Controls.Add(this.tbSoyad);
            this.Controls.Add(this.tbAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.TextBox tbSoyad;
        private System.Windows.Forms.TextBox tbVize;
        private System.Windows.Forms.TextBox tbFinal;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ListBox lbAd;
        private System.Windows.Forms.ListBox lbSoyad;
        private System.Windows.Forms.ListBox lbVize;
        private System.Windows.Forms.ListBox lbFinal;
        private System.Windows.Forms.ListBox lbDurum;
    }
}

