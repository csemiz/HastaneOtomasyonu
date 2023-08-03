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
            txtSifre = new TextBox();
            mskTC = new MaskedTextBox();
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
            pictureBox1.Location = new Point(380, 127);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 237);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // girisyap
            // 
            girisyap.BackColor = Color.Violet;
            girisyap.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            girisyap.ForeColor = SystemColors.ButtonHighlight;
            girisyap.Location = new Point(69, 279);
            girisyap.Name = "girisyap";
            girisyap.Size = new Size(279, 49);
            girisyap.TabIndex = 22;
            girisyap.Text = "Giriş Yap";
            girisyap.UseVisualStyleBackColor = false;
            girisyap.Click += girisyap_Click;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(204, 226);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(144, 27);
            txtSifre.TabIndex = 21;
            txtSifre.Text = "123456";
            txtSifre.UseSystemPasswordChar = true;
            txtSifre.WordWrap = false;
            // 
            // mskTC
            // 
            mskTC.Location = new Point(204, 184);
            mskTC.Mask = "00000000000";
            mskTC.Name = "mskTC";
            mskTC.Size = new Size(144, 27);
            mskTC.TabIndex = 20;
            mskTC.Text = "55555555555";
            mskTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(129, 224);
            label3.Name = "label3";
            label3.Size = new Size(59, 27);
            label3.TabIndex = 19;
            label3.Text = "Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(46, 184);
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
            label1.Location = new Point(92, 55);
            label1.Name = "label1";
            label1.Size = new Size(392, 60);
            label1.TabIndex = 17;
            label1.Text = "Sekreter Giriş Paneli";
            // 
            // FrmSekreterGiris
            // 
            AcceptButton = girisyap;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(673, 406);
            Controls.Add(pictureBox1);
            Controls.Add(girisyap);
            Controls.Add(txtSifre);
            Controls.Add(mskTC);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmSekreterGiris";
            Text = "Sekreter Girişi";
            Load += FrmSekreterGiris_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button girisyap;
        private MaskedTextBox mskTC;
        private Label label3;
        private Label label2;
        private Label label1;
        internal TextBox txtSifre;
    }
}