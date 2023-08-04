namespace HastaneOtomasyonu
{
    partial class FrmDoktorBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorBilgiDuzenle));
            cmbBrans = new ComboBox();
            label5 = new Label();
            btnGuncelle = new Button();
            txtsifre = new TextBox();
            label3 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            mskTC = new MaskedTextBox();
            SuspendLayout();
            // 
            // cmbBrans
            // 
            cmbBrans.FormattingEnabled = true;
            cmbBrans.Location = new Point(178, 191);
            cmbBrans.Name = "cmbBrans";
            cmbBrans.Size = new Size(144, 28);
            cmbBrans.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(100, 187);
            label5.Name = "label5";
            label5.Size = new Size(74, 27);
            label5.TabIndex = 36;
            label5.Text = "Branşı:";
            // 
            // btnGuncelle
            // 
            btnGuncelle.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGuncelle.BackColor = Color.MidnightBlue;
            btnGuncelle.Cursor = Cursors.Hand;
            btnGuncelle.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuncelle.ForeColor = SystemColors.ButtonFace;
            btnGuncelle.Location = new Point(38, 286);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(284, 56);
            btnGuncelle.TabIndex = 35;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtsifre
            // 
            txtsifre.Location = new Point(178, 236);
            txtsifre.Name = "txtsifre";
            txtsifre.Size = new Size(144, 27);
            txtsifre.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(114, 232);
            label3.Name = "label3";
            label3.Size = new Size(59, 27);
            label3.TabIndex = 33;
            label3.Text = "Şifre:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(178, 56);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(144, 27);
            txtAd.TabIndex = 32;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(178, 101);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(144, 27);
            txtSoyad.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(38, 97);
            label4.Name = "label4";
            label4.Size = new Size(133, 27);
            label4.TabIndex = 30;
            label4.Text = "Hasta Soyadı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(68, 52);
            label1.Name = "label1";
            label1.Size = new Size(107, 27);
            label1.TabIndex = 29;
            label1.Text = "Hasta Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(38, 143);
            label2.Name = "label2";
            label2.Size = new Size(142, 27);
            label2.TabIndex = 27;
            label2.Text = "TC Kimlik No:";
            // 
            // mskTC
            // 
            mskTC.Location = new Point(178, 145);
            mskTC.Mask = "00000000000";
            mskTC.Name = "mskTC";
            mskTC.Size = new Size(144, 27);
            mskTC.TabIndex = 38;
            mskTC.ValidatingType = typeof(int);
            // 
            // FrmDoktorBilgiDuzenle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(348, 399);
            Controls.Add(mskTC);
            Controls.Add(cmbBrans);
            Controls.Add(label5);
            Controls.Add(btnGuncelle);
            Controls.Add(txtsifre);
            Controls.Add(label3);
            Controls.Add(txtAd);
            Controls.Add(txtSoyad);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmDoktorBilgiDuzenle";
            Text = "FrmDoktorBilgiDuzenle";
            Load += FrmDoktorBilgiDuzenle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBrans;
        private Label label5;
        private Button btnGuncelle;
        private TextBox txtsifre;
        private Label label3;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Label label4;
        private Label label1;
        private Label label2;
        private MaskedTextBox mskTC;
    }
}