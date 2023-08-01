namespace HastaneOtomasyonu
{
    partial class FrmSekreterGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterGiris));
            pictureBox1 = new PictureBox();
            girisyap = new Button();
            sifre = new TextBox();
            tck = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(442, 137);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 237);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // girisyap
            // 
            girisyap.BackColor = Color.Violet;
            girisyap.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            girisyap.ForeColor = SystemColors.ButtonHighlight;
            girisyap.Location = new Point(72, 267);
            girisyap.Name = "girisyap";
            girisyap.Size = new Size(279, 49);
            girisyap.TabIndex = 22;
            girisyap.Text = "Giriş Yap";
            girisyap.UseVisualStyleBackColor = false;
            // 
            // sifre
            // 
            sifre.Location = new Point(207, 214);
            sifre.Name = "sifre";
            sifre.Size = new Size(144, 27);
            sifre.TabIndex = 21;
            // 
            // tck
            // 
            tck.Location = new Point(207, 172);
            tck.Mask = "00000";
            tck.Name = "tck";
            tck.Size = new Size(144, 27);
            tck.TabIndex = 20;
            tck.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(132, 212);
            label3.Name = "label3";
            label3.Size = new Size(59, 27);
            label3.TabIndex = 19;
            label3.Text = "Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(49, 172);
            label2.Name = "label2";
            label2.Size = new Size(142, 27);
            label2.TabIndex = 18;
            label2.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 25.8000011F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(158, 54);
            label1.Name = "label1";
            label1.Size = new Size(392, 60);
            label1.TabIndex = 17;
            label1.Text = "Sekreter Giriş Paneli";
            // 
            // FrmSekreterGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(girisyap);
            Controls.Add(sifre);
            Controls.Add(tck);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmSekreterGiris";
            Text = "FrmSekreterGiris";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button girisyap;
        private TextBox sifre;
        private MaskedTextBox tck;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}