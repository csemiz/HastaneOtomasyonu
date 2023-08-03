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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBrans));
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
            btnGuncelle.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGuncelle.BackColor = Color.FromArgb(255, 128, 0);
            btnGuncelle.Location = new Point(11, 233);
            btnGuncelle.Margin = new Padding(4);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(368, 43);
            btnGuncelle.TabIndex = 49;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(192, 0, 192);
            btnSil.Location = new Point(13, 296);
            btnSil.Margin = new Padding(4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(368, 43);
            btnSil.TabIndex = 48;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Yellow;
            btnEkle.Location = new Point(13, 162);
            btnEkle.Margin = new Padding(4);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(368, 43);
            btnEkle.TabIndex = 47;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(413, 30);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(678, 310);
            dataGridView1.TabIndex = 46;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtbransadi
            // 
            txtbransadi.Location = new Point(147, 92);
            txtbransadi.Margin = new Padding(4);
            txtbransadi.Name = "txtbransadi";
            txtbransadi.Size = new Size(234, 32);
            txtbransadi.TabIndex = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Palatino Linotype", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(41, 39);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(81, 24);
            label5.TabIndex = 44;
            label5.Text = "Branş Id:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Palatino Linotype", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(25, 100);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 24);
            label4.TabIndex = 43;
            label4.Text = "Branş Adı:";
            // 
            // txtbransid
            // 
            txtbransid.Location = new Point(145, 31);
            txtbransid.Margin = new Padding(4);
            txtbransid.Name = "txtbransid";
            txtbransid.Size = new Size(234, 32);
            txtbransid.TabIndex = 42;
            // 
            // FrmBrans
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1101, 354);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(dataGridView1);
            Controls.Add(txtbransadi);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtbransid);
            Font = new Font("Palatino Linotype", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FrmBrans";
            Text = "Branşlar";
            Load += FrmBrans_Load;
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