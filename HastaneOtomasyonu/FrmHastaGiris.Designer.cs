namespace HastaneOtomasyonu
{
    partial class FrmHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaGiris));
            fileSystemWatcher1 = new FileSystemWatcher();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lnkUyeOl = new LinkLabel();
            button1 = new Button();
            mskTC = new MaskedTextBox();
            txtSifre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(139, 206);
            label1.Name = "label1";
            label1.Size = new Size(59, 27);
            label1.TabIndex = 0;
            label1.Text = "Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(56, 56);
            label2.Name = "label2";
            label2.Size = new Size(437, 53);
            label2.TabIndex = 0;
            label2.Text = "HASTA GİRİŞ PANELİ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(56, 149);
            label3.Name = "label3";
            label3.Size = new Size(142, 27);
            label3.TabIndex = 0;
            label3.Text = "TC Kimlik No:";
            // 
            // lnkUyeOl
            // 
            lnkUyeOl.AutoSize = true;
            lnkUyeOl.Font = new Font("Palatino Linotype", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lnkUyeOl.Location = new Point(254, 312);
            lnkUyeOl.Name = "lnkUyeOl";
            lnkUyeOl.Size = new Size(67, 24);
            lnkUyeOl.TabIndex = 1;
            lnkUyeOl.TabStop = true;
            lnkUyeOl.Text = "Üye Ol";
            lnkUyeOl.LinkClicked += lnkUyeOl_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(355, 261);
            button1.Name = "button1";
            button1.Size = new Size(121, 75);
            button1.TabIndex = 2;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = false;
            // 
            // mskTC
            // 
            mskTC.Location = new Point(224, 149);
            mskTC.Mask = "00000000000";
            mskTC.Name = "mskTC";
            mskTC.Size = new Size(252, 27);
            mskTC.TabIndex = 3;
            mskTC.ValidatingType = typeof(int);
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(224, 206);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(252, 27);
            txtSifre.TabIndex = 4;
            // 
            // FrmHastaGiris
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(519, 395);
            Controls.Add(txtSifre);
            Controls.Add(mskTC);
            Controls.Add(button1);
            Controls.Add(lnkUyeOl);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmHastaGiris";
            Text = "Hasta Girişi";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private MaskedTextBox mskTC;
        private Button button1;
        private LinkLabel lnkUyeOl;
        private Label label2;
        private Label label3;
        private Label label1;
        private TextBox txtSifre;
    }
}