namespace HastaneOtomasyonu
{
    partial class FrmDoktorPaneli
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
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            dataGridView1 = new DataGridView();
            txtSifre = new TextBox();
            mskTc = new MaskedTextBox();
            txtSoyad = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cmbBrans = new ComboBox();
            txtAd = new TextBox();
            lblsekretertc = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(192, 255, 255);
            btnGuncelle.Location = new Point(579, 270);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(226, 36);
            btnGuncelle.TabIndex = 41;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(255, 192, 192);
            btnSil.Location = new Point(312, 271);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(226, 36);
            btnSil.TabIndex = 40;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(192, 255, 192);
            btnEkle.Location = new Point(49, 270);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(226, 36);
            btnEkle.TabIndex = 39;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(312, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(493, 221);
            dataGridView1.TabIndex = 38;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(104, 222);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(171, 27);
            txtSifre.TabIndex = 37;
            txtSifre.TextChanged += txtSifre_TextChanged;
            // 
            // mskTc
            // 
            mskTc.Location = new Point(104, 170);
            mskTc.Mask = "00000000000";
            mskTc.Name = "mskTc";
            mskTc.Size = new Size(171, 27);
            mskTc.TabIndex = 36;
            mskTc.ValidatingType = typeof(int);
            mskTc.MaskInputRejected += mskTc_MaskInputRejected;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(104, 79);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(171, 27);
            txtSoyad.TabIndex = 35;
            txtSoyad.TextChanged += txtSoyad_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(49, 28);
            label5.Name = "label5";
            label5.Size = new Size(42, 28);
            label5.TabIndex = 34;
            label5.Text = "Ad:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(19, 74);
            label4.Name = "label4";
            label4.Size = new Size(72, 28);
            label4.TabIndex = 33;
            label4.Text = "Soyad:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(19, 165);
            label3.Name = "label3";
            label3.Size = new Size(72, 28);
            label3.TabIndex = 32;
            label3.Text = "TC No:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 221);
            label2.Name = "label2";
            label2.Size = new Size(58, 28);
            label2.TabIndex = 31;
            label2.Text = "Şifre:";
            label2.Click += label2_Click;
            // 
            // cmbBrans
            // 
            cmbBrans.FormattingEnabled = true;
            cmbBrans.Location = new Point(104, 125);
            cmbBrans.Name = "cmbBrans";
            cmbBrans.Size = new Size(170, 28);
            cmbBrans.TabIndex = 30;
            cmbBrans.SelectedIndexChanged += cmbBrans_SelectedIndexChanged;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(104, 28);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(171, 27);
            txtAd.TabIndex = 29;
            txtAd.TextChanged += txtAd_TextChanged;
            // 
            // lblsekretertc
            // 
            lblsekretertc.AutoSize = true;
            lblsekretertc.BackColor = Color.Transparent;
            lblsekretertc.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblsekretertc.Location = new Point(24, 119);
            lblsekretertc.Name = "lblsekretertc";
            lblsekretertc.Size = new Size(67, 28);
            lblsekretertc.TabIndex = 28;
            lblsekretertc.Text = "Branş:";
            lblsekretertc.Click += lblsekretertc_Click;
            // 
            // FrmDoktorPaneli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 381);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(dataGridView1);
            Controls.Add(txtSifre);
            Controls.Add(mskTc);
            Controls.Add(txtSoyad);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbBrans);
            Controls.Add(txtAd);
            Controls.Add(lblsekretertc);
            Name = "FrmDoktorPaneli";
            Text = "FrmDoktorPaneli";
            Load += FrmDoktorPaneli_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private DataGridView dataGridView1;
        private TextBox txtSifre;
        private MaskedTextBox mskTc;
        private TextBox txtSoyad;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbBrans;
        private TextBox txtAd;
        private Label lblsekretertc;
    }
}