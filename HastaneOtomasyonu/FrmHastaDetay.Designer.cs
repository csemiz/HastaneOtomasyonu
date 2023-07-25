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
            groupBox1 = new GroupBox();
            lblAdSoyad = new Label();
            label3 = new Label();
            lblTC = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            rchSikayet = new RichTextBox();
            cmbDoktor = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            cmbBrans = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox4 = new GroupBox();
            dataGridView2 = new DataGridView();
            lnkBilgiDuzenle = new LinkLabel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientActiveCaption;
            groupBox2.Controls.Add(lnkBilgiDuzenle);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(rchSikayet);
            groupBox2.Controls.Add(cmbDoktor);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cmbBrans);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 247);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(472, 400);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Randevu Paneli";
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(286, 324);
            button1.Name = "button1";
            button1.Size = new Size(133, 70);
            button1.TabIndex = 2;
            button1.Text = "Randevu Al";
            button1.UseVisualStyleBackColor = false;
            // 
            // rchSikayet
            // 
            rchSikayet.Location = new Point(157, 166);
            rchSikayet.Name = "rchSikayet";
            rchSikayet.Size = new Size(262, 147);
            rchSikayet.TabIndex = 6;
            rchSikayet.Text = "";
            // 
            // cmbDoktor
            // 
            cmbDoktor.FormattingEnabled = true;
            cmbDoktor.Location = new Point(157, 102);
            cmbDoktor.Name = "cmbDoktor";
            cmbDoktor.Size = new Size(262, 35);
            cmbDoktor.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(44, 166);
            label8.Name = "label8";
            label8.Size = new Size(87, 27);
            label8.TabIndex = 4;
            label8.Text = "Şikayet :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(44, 107);
            label7.Name = "label7";
            label7.Size = new Size(86, 27);
            label7.TabIndex = 4;
            label7.Text = "Doktor :";
            // 
            // cmbBrans
            // 
            cmbBrans.FormattingEnabled = true;
            cmbBrans.Location = new Point(157, 53);
            cmbBrans.Name = "cmbBrans";
            cmbBrans.Size = new Size(262, 35);
            cmbBrans.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(57, 58);
            label6.Name = "label6";
            label6.Size = new Size(73, 27);
            label6.TabIndex = 2;
            label6.Text = "Branş :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(57, 58);
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
            groupBox4.Size = new Size(598, 273);
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
            dataGridView2.Size = new Size(592, 240);
            dataGridView2.TabIndex = 0;
            // 
            // lnkBilgiDuzenle
            // 
            lnkBilgiDuzenle.AutoSize = true;
            lnkBilgiDuzenle.Location = new Point(83, 367);
            lnkBilgiDuzenle.Name = "lnkBilgiDuzenle";
            lnkBilgiDuzenle.Size = new Size(186, 27);
            lnkBilgiDuzenle.TabIndex = 7;
            lnkBilgiDuzenle.TabStop = true;
            lnkBilgiDuzenle.Text = "Bilgilerini Güncelle";
            // 
            // FrmHastaDetay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1103, 658);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmHastaDetay";
            Text = "Hasta Detay";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private GroupBox groupBox2;
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
    }
}