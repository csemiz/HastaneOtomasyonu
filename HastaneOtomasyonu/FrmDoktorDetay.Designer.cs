namespace HastaneOtomasyonu
{
    partial class FrmDoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorDetay));
            groupBox1 = new GroupBox();
            lblTCNo = new Label();
            lblAdSoyad = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            rchSikayet = new RichTextBox();
            groupBox3 = new GroupBox();
            dataGridRandevuList = new DataGridView();
            groupBox4 = new GroupBox();
            btnGuncelle = new Button();
            btnDuyurular = new Button();
            btnCikis = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridRandevuList).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(lblTCNo);
            groupBox1.Controls.Add(lblAdSoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(320, 185);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Doktor Bilgi ";
            // 
            // lblTCNo
            // 
            lblTCNo.AutoSize = true;
            lblTCNo.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTCNo.Location = new Point(141, 43);
            lblTCNo.Name = "lblTCNo";
            lblTCNo.Size = new Size(122, 27);
            lblTCNo.TabIndex = 0;
            lblTCNo.Text = "00000000000";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdSoyad.Location = new Point(141, 98);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(99, 27);
            lblAdSoyad.TabIndex = 0;
            lblAdSoyad.Text = "Null Null";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 98);
            label3.Name = "label3";
            label3.Size = new Size(108, 27);
            label3.TabIndex = 0;
            label3.Text = "Ad Soyad :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(46, 43);
            label1.Name = "label1";
            label1.Size = new Size(86, 27);
            label1.TabIndex = 0;
            label1.Text = "TC NO :";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientInactiveCaption;
            groupBox2.Controls.Add(rchSikayet);
            groupBox2.Location = new Point(12, 215);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(320, 282);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Randevu Detay";
            // 
            // rchSikayet
            // 
            rchSikayet.Location = new Point(6, 36);
            rchSikayet.Name = "rchSikayet";
            rchSikayet.Size = new Size(308, 175);
            rchSikayet.TabIndex = 0;
            rchSikayet.Text = "";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.GradientInactiveCaption;
            groupBox3.Controls.Add(dataGridRandevuList);
            groupBox3.Location = new Point(350, 16);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(617, 702);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridRandevuList
            // 
            dataGridRandevuList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridRandevuList.Dock = DockStyle.Fill;
            dataGridRandevuList.Location = new Point(3, 23);
            dataGridRandevuList.Name = "dataGridRandevuList";
            dataGridRandevuList.RowHeadersWidth = 51;
            dataGridRandevuList.RowTemplate.Height = 29;
            dataGridRandevuList.Size = new Size(611, 676);
            dataGridRandevuList.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.GradientInactiveCaption;
            groupBox4.Controls.Add(btnGuncelle);
            groupBox4.Controls.Add(btnDuyurular);
            groupBox4.Controls.Add(btnCikis);
            groupBox4.Location = new Point(12, 514);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(320, 204);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Palatino Linotype", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuncelle.Location = new Point(6, 55);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(149, 49);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "Bilgi Düzenle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnDuyurular
            // 
            btnDuyurular.Font = new Font("Palatino Linotype", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDuyurular.Location = new Point(166, 55);
            btnDuyurular.Name = "btnDuyurular";
            btnDuyurular.Size = new Size(149, 49);
            btnDuyurular.TabIndex = 4;
            btnDuyurular.Text = "Duyurular";
            btnDuyurular.UseVisualStyleBackColor = true;
            // 
            // btnCikis
            // 
            btnCikis.Font = new Font("Palatino Linotype", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCikis.Location = new Point(6, 132);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(303, 49);
            btnCikis.TabIndex = 4;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            // 
            // FrmDoktorDetay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(975, 724);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmDoktorDetay";
            Text = "FrmDoktorDetay";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridRandevuList).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblTCNo;
        private Label label1;
        private Label lblAdSoyad;
        private Label label3;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RichTextBox rchSikayet;
        private GroupBox groupBox4;
        private Button btnGuncelle;
        private Button btnDuyurular;
        private Button btnCikis;
        private DataGridView dataGridRandevuList;
    }
}