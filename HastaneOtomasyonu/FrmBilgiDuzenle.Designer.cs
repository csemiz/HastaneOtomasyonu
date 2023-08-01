namespace HastaneOtomasyonu
{
    partial class FrmBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilgiDuzenle));
            cmbCinsiyet = new ComboBox();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtSifre = new TextBox();
            mskTelefon = new MaskedTextBox();
            mskTC = new MaskedTextBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label6 = new Label();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // cmbCinsiyet
            // 
            cmbCinsiyet.FormattingEnabled = true;
            cmbCinsiyet.Items.AddRange(new object[] { "Kadın", "Erkek" });
            cmbCinsiyet.Location = new Point(175, 278);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Size = new Size(203, 28);
            cmbCinsiyet.TabIndex = 21;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(175, 14);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(203, 27);
            txtAd.TabIndex = 18;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(175, 63);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(203, 27);
            txtSoyad.TabIndex = 19;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(175, 225);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(203, 27);
            txtSifre.TabIndex = 20;
            // 
            // mskTelefon
            // 
            mskTelefon.Location = new Point(175, 172);
            mskTelefon.Mask = "(999) 000-0000";
            mskTelefon.Name = "mskTelefon";
            mskTelefon.Size = new Size(203, 27);
            mskTelefon.TabIndex = 16;
            // 
            // mskTC
            // 
            mskTC.Location = new Point(175, 117);
            mskTC.Mask = "00000000000";
            mskTC.Name = "mskTC";
            mskTC.Size = new Size(203, 27);
            mskTC.TabIndex = 17;
            mskTC.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(101, 12);
            label2.Name = "label2";
            label2.Size = new Size(55, 27);
            label2.TabIndex = 10;
            label2.Text = "Ad : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(81, 61);
            label4.Name = "label4";
            label4.Size = new Size(75, 27);
            label4.TabIndex = 11;
            label4.Text = "Soyad :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(9, 115);
            label5.Name = "label5";
            label5.Size = new Size(147, 27);
            label5.TabIndex = 12;
            label5.Text = "TC Kimlik No :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(34, 170);
            label3.Name = "label3";
            label3.Size = new Size(122, 27);
            label3.TabIndex = 13;
            label3.Text = "Telefon No :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(60, 274);
            label6.Name = "label6";
            label6.Size = new Size(96, 27);
            label6.TabIndex = 14;
            label6.Text = "Cinsiyet :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(92, 223);
            label1.Name = "label1";
            label1.Size = new Size(64, 27);
            label1.TabIndex = 15;
            label1.Text = "Şifre :";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(174, 340);
            button1.Name = "button1";
            button1.Size = new Size(203, 46);
            button1.TabIndex = 22;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = false;
            // 
            // FrmBilgiDuzenle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(431, 413);
            Controls.Add(button1);
            Controls.Add(cmbCinsiyet);
            Controls.Add(txtAd);
            Controls.Add(txtSoyad);
            Controls.Add(txtSifre);
            Controls.Add(mskTelefon);
            Controls.Add(mskTC);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmBilgiDuzenle";
            Text = "FrmBilgiDuzenle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCinsiyet;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtSifre;
        private MaskedTextBox mskTelefon;
        private MaskedTextBox mskTC;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label6;
        private Label label1;
        private Button button1;
    }
}