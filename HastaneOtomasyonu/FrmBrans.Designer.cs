namespace HastaneOtomasyonu
{
    partial class FrmBrans
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
            txtbransadi = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtbransid = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(192, 255, 255);
            btnGuncelle.Location = new Point(19, 228);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(268, 36);
            btnGuncelle.TabIndex = 49;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(255, 192, 255);
            btnSil.Location = new Point(19, 286);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(268, 36);
            btnSil.TabIndex = 48;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(192, 255, 192);
            btnEkle.Location = new Point(19, 174);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(268, 36);
            btnEkle.TabIndex = 47;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(310, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(493, 258);
            dataGridView1.TabIndex = 46;
            // 
            // txtbransadi
            // 
            txtbransadi.Location = new Point(116, 116);
            txtbransadi.Name = "txtbransadi";
            txtbransadi.Size = new Size(171, 27);
            txtbransadi.TabIndex = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(19, 64);
            label5.Name = "label5";
            label5.Size = new Size(91, 28);
            label5.TabIndex = 44;
            label5.Text = "Branş Id:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(7, 115);
            label4.Name = "label4";
            label4.Size = new Size(103, 28);
            label4.TabIndex = 43;
            label4.Text = "Branş Adı:";
            // 
            // txtbransid
            // 
            txtbransid.Location = new Point(116, 65);
            txtbransid.Name = "txtbransid";
            txtbransid.Size = new Size(171, 27);
            txtbransid.TabIndex = 42;
            // 
            // FrmBrans
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 365);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(dataGridView1);
            Controls.Add(txtbransadi);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtbransid);
            Name = "FrmBrans";
            Text = "FrmBrans";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private DataGridView dataGridView1;
        private TextBox txtbransadi;
        private Label label5;
        private Label label4;
        private TextBox txtbransid;
    }
}