namespace HastaneOtomasyonu
{
    partial class FrmGirisler
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            btnDoktor = new Button();
            btnHasta = new Button();
            btnSekreter = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnDoktor
            // 
            btnDoktor.BackColor = Color.White;
            btnDoktor.BackgroundImage = (Image)resources.GetObject("btnDoktor.BackgroundImage");
            btnDoktor.BackgroundImageLayout = ImageLayout.Stretch;
            btnDoktor.Location = new Point(291, 282);
            btnDoktor.Name = "btnDoktor";
            btnDoktor.Size = new Size(171, 161);
            btnDoktor.TabIndex = 0;
            btnDoktor.UseVisualStyleBackColor = false;
            btnDoktor.Click += btnDoktor_Click;
            // 
            // btnHasta
            // 
            btnHasta.BackColor = Color.White;
            btnHasta.BackgroundImage = (Image)resources.GetObject("btnHasta.BackgroundImage");
            btnHasta.BackgroundImageLayout = ImageLayout.Stretch;
            btnHasta.Location = new Point(37, 282);
            btnHasta.Name = "btnHasta";
            btnHasta.Size = new Size(171, 161);
            btnHasta.TabIndex = 0;
            btnHasta.UseVisualStyleBackColor = false;
            btnHasta.Click += btnHasta_Click;
            // 
            // btnSekreter
            // 
            btnSekreter.BackColor = Color.White;
            btnSekreter.BackgroundImage = (Image)resources.GetObject("btnSekreter.BackgroundImage");
            btnSekreter.BackgroundImageLayout = ImageLayout.Stretch;
            btnSekreter.Location = new Point(548, 282);
            btnSekreter.Name = "btnSekreter";
            btnSekreter.Size = new Size(171, 161);
            btnSekreter.TabIndex = 0;
            btnSekreter.UseVisualStyleBackColor = false;
            btnSekreter.Click += btnSekreter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(78, 484);
            label1.Name = "label1";
            label1.Size = new Size(75, 31);
            label1.TabIndex = 1;
            label1.Text = "Hasta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(334, 484);
            label2.Name = "label2";
            label2.Size = new Size(90, 31);
            label2.TabIndex = 1;
            label2.Text = "Doktor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(579, 484);
            label3.Name = "label3";
            label3.Size = new Size(104, 31);
            label3.TabIndex = 1;
            label3.Text = "Sekreter";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(579, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(37, 74);
            label4.Name = "label4";
            label4.Size = new Size(404, 41);
            label4.TabIndex = 3;
            label4.Text = "HOSPITAL AUTOMATION";
            // 
            // FrmGirisler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(826, 577);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnHasta);
            Controls.Add(btnSekreter);
            Controls.Add(btnDoktor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmGirisler";
            Text = "Hospital";
            Load += FrmGirisler_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDoktor;
        private Button btnHasta;
        private Button btnSekreter;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
    }
}