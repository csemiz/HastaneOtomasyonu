namespace HastaneOtomasyonu
{
    partial class FrmHastaDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaDetay));
            groupBox1 = new GroupBox();
            lblAdSoyad = new Label();
            label3 = new Label();
            lblTC = new Label();
            label1 = new Label();
            groupBo = new GroupBox();
            txtId = new TextBox();
            lnkBilgiDuzenle = new LinkLabel();
            button1 = new Button();
            rchSikayet = new RichTextBox();
            cmbDoktor = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            cmbBrans = new ComboBox();
            lblId = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox4 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBo.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(lblAdSoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblTC);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(472, 229);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kişi Bilgileri";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdSoyad.Location = new Point(186, 100);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(99, 27);
            lblAdSoyad.TabIndex = 3;
            lblAdSoyad.Text = "Null Null";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(17, 100);
            label3.Name = "label3";
            label3.Size = new Size(113, 27);
            label3.TabIndex = 2;
            label3.Text = "Ad  Soyad :";
            // 
            // lblTC
            // 
            lblTC.AutoSize = true;
            lblTC.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTC.Location = new Point(186, 56);
            lblTC.Name = "lblTC";
            lblTC.Size = new Size(122, 25);
            lblTC.TabIndex = 1;
            lblTC.Text = "00000000000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(44, 56);
            label1.Name = "label1";
            label1.Size = new Size(86, 27);
            label1.TabIndex = 0;
            label1.Text = "TC NO :";
            // 
            // groupBo
            // 
            groupBo.BackColor = SystemColors.GradientActiveCaption;
            groupBo.Controls.Add(txtId);
            groupBo.Controls.Add(lnkBilgiDuzenle);
            groupBo.Controls.Add(button1);
            groupBo.Controls.Add(rchSikayet);
            groupBo.Controls.Add(cmbDoktor);
            groupBo.Controls.Add(label8);
            groupBo.Controls.Add(label7);
            groupBo.Controls.Add(cmbBrans);
            groupBo.Controls.Add(lblId);
            groupBo.Controls.Add(label6);
            groupBo.Controls.Add(label5);
            groupBo.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBo.Location = new Point(12, 249);
            groupBo.Name = "groupBo";
            groupBo.Size = new Size(475, 450);
            groupBo.TabIndex = 1;
            groupBo.TabStop = false;
            groupBo.Text = "Randevu Paneli";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(159, 48);
            txtId.Name = "txtId";
            txtId.Size = new Size(262, 34);
            txtId.TabIndex = 8;
            // 
            // lnkBilgiDuzenle
            // 
            lnkBilgiDuzenle.AutoSize = true;
            lnkBilgiDuzenle.Location = new Point(85, 408);
            lnkBilgiDuzenle.Name = "lnkBilgiDuzenle";
            lnkBilgiDuzenle.Size = new Size(186, 27);
            lnkBilgiDuzenle.TabIndex = 7;
            lnkBilgiDuzenle.TabStop = true;
            lnkBilgiDuzenle.Text = "Bilgilerini Güncelle";
            lnkBilgiDuzenle.LinkClicked += lnkBilgiDuzenle_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(288, 365);
            button1.Name = "button1";
            button1.Size = new Size(133, 70);
            button1.TabIndex = 2;
            button1.Text = "Randevu Al";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // rchSikayet
            // 
            rchSikayet.Location = new Point(159, 207);
            rchSikayet.Name = "rchSikayet";
            rchSikayet.Size = new Size(262, 147);
            rchSikayet.TabIndex = 6;
            rchSikayet.Text = "";
            // 
            // cmbDoktor
            // 
            cmbDoktor.FormattingEnabled = true;
            cmbDoktor.Location = new Point(159, 143);
            cmbDoktor.Name = "cmbDoktor";
            cmbDoktor.Size = new Size(262, 35);
            cmbDoktor.TabIndex = 5;
            cmbDoktor.SelectedIndexChanged += cmbDoktor_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(46, 207);
            label8.Name = "label8";
            label8.Size = new Size(87, 27);
            label8.TabIndex = 4;
            label8.Text = "Şikayet :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(46, 148);
            label7.Name = "label7";
            label7.Size = new Size(86, 27);
            label7.TabIndex = 4;
            label7.Text = "Doktor :";
            // 
            // cmbBrans
            // 
            cmbBrans.FormattingEnabled = true;
            cmbBrans.Location = new Point(159, 94);
            cmbBrans.Name = "cmbBrans";
            cmbBrans.Size = new Size(262, 35);
            cmbBrans.TabIndex = 3;
            cmbBrans.SelectedIndexChanged += cmbBrans_SelectedIndexChanged;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblId.Location = new Point(91, 55);
            lblId.Name = "lblId";
            lblId.Size = new Size(42, 27);
            lblId.TabIndex = 2;
            lblId.Text = "Id :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(57, 94);
            label6.Name = "label6";
            label6.Size = new Size(73, 27);
            label6.TabIndex = 2;
            label6.Text = "Branş :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(59, 99);
            label5.Name = "label5";
            label5.Size = new Size(73, 27);
            label5.TabIndex = 2;
            label5.Text = "Branş :";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.GradientActiveCaption;
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(490, 14);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(598, 354);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Randevu Geçmişi";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(592, 321);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.GradientActiveCaption;
            groupBox4.Controls.Add(dataGridView2);
            groupBox4.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(490, 374);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(598, 323);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Aktif Randevular";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 30);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(592, 290);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // FrmHastaDetay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1100, 711);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBo);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmHastaDetay";
            Text = "Hasta Detay";
            Load += FrmHastaDetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBo.ResumeLayout(false);
            groupBo.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblTC;
        private Label label1;
        private Label lblAdSoyad;
        private Label label3;
        private GroupBox groupBo;
        private RichTextBox rchSikayet;
        private ComboBox cmbDoktor;
        private Label label8;
        private Label label7;
        private ComboBox cmbBrans;
        private Label label6;
        private Label label5;
        private Button button1;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private LinkLabel lnkBilgiDuzenle;
        private TextBox txtId;
        private Label lblId;
    }
}