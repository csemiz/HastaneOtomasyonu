namespace HastaneOtomasyonu
{
    partial class FrmUyeKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUyeKayit));
            txtSifre = new TextBox();
            mskTC = new MaskedTextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            mskTelefon = new MaskedTextBox();
            cmbCinsiyet = new ComboBox();
            label6 = new Label();
            btnKayitOl = new Button();
            SuspendLayout();
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(204, 303);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(252, 27);
            txtSifre.TabIndex = 5;
            // 
            // mskTC
            // 
            mskTC.Location = new Point(204, 195);
            mskTC.Mask = "00000000000";
            mskTC.Name = "mskTC";
            mskTC.Size = new Size(252, 27);
            mskTC.TabIndex = 3;
            mskTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(37, 250);
            label3.Name = "label3";
            label3.Size = new Size(122, 27);
            label3.TabIndex = 5;
            label3.Text = "Telefon No :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(95, 303);
            label1.Name = "label1";
            label1.Size = new Size(64, 27);
            label1.TabIndex = 6;
            label1.Text = "Şifre :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(104, 92);
            label2.Name = "label2";
            label2.Size = new Size(55, 27);
            label2.TabIndex = 5;
            label2.Text = "Ad : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(84, 141);
            label4.Name = "label4";
            label4.Size = new Size(75, 27);
            label4.TabIndex = 5;
            label4.Text = "Soyad :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 195);
            label5.Name = "label5";
            label5.Size = new Size(147, 27);
            label5.TabIndex = 5;
            label5.Text = "TC Kimlik No :";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(204, 92);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(252, 27);
            txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(204, 141);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(252, 27);
            txtSoyad.TabIndex = 2;
            // 
            // mskTelefon
            // 
            mskTelefon.Location = new Point(204, 250);
            mskTelefon.Mask = "(999) 000-0000";
            mskTelefon.Name = "mskTelefon";
            mskTelefon.Size = new Size(252, 27);
            mskTelefon.TabIndex = 4;
            // 
            // cmbCinsiyet
            // 
            cmbCinsiyet.FormattingEnabled = true;
            cmbCinsiyet.Items.AddRange(new object[] { "Kadın", "Erkek" });
            cmbCinsiyet.Location = new Point(204, 356);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Size = new Size(252, 28);
            cmbCinsiyet.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(63, 354);
            label6.Name = "label6";
            label6.Size = new Size(96, 27);
            label6.TabIndex = 6;
            label6.Text = "Cinsiyet :";
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.Fuchsia;
            btnKayitOl.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKayitOl.Location = new Point(204, 429);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(252, 55);
            btnKayitOl.TabIndex = 7;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // FrmUyeKayit
            // 
            AcceptButton = btnKayitOl;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(480, 532);
            Controls.Add(btnKayitOl);
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
            MaximizeBox = false;
            Name = "FrmUyeKayit";
            Text = "Hasta Kayıt";
            Load += FrmUyeKayit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSifre;
        private MaskedTextBox mskTC;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private MaskedTextBox mskTelefon;
        private ComboBox cmbCinsiyet;
        private Label label6;
        private Button btnKayitOl;
    }
}