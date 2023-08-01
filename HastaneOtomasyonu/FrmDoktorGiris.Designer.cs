namespace HastaneOtomasyonu
{
    partial class FrmDoktorGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorGiris));
            txtSifre = new TextBox();
            mskTC = new MaskedTextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(229, 186);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(252, 27);
            txtSifre.TabIndex = 11;
            // 
            // mskTC
            // 
            mskTC.Location = new Point(229, 129);
            mskTC.Mask = "00000000000";
            mskTC.Name = "mskTC";
            mskTC.Size = new Size(252, 27);
            mskTC.TabIndex = 10;
            mskTC.ValidatingType = typeof(int);
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(360, 241);
            button1.Name = "button1";
            button1.Size = new Size(121, 75);
            button1.TabIndex = 9;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(31, 45);
            label2.Name = "label2";
            label2.Size = new Size(484, 53);
            label2.TabIndex = 5;
            label2.Text = "DOKTOR GİRİŞ PANELİ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(61, 129);
            label3.Name = "label3";
            label3.Size = new Size(142, 27);
            label3.TabIndex = 6;
            label3.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(144, 186);
            label1.Name = "label1";
            label1.Size = new Size(59, 27);
            label1.TabIndex = 7;
            label1.Text = "Şifre:";
            // 
            // FrmDoktorGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(518, 341);
            Controls.Add(txtSifre);
            Controls.Add(mskTC);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmDoktorGiris";
            Text = "FrmDoktorGiris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSifre;
        private MaskedTextBox mskTC;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label1;
    }
}