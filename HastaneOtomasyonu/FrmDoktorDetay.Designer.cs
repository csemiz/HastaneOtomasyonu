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
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            richTextBox1 = new RichTextBox();
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(320, 185);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Doktor Bilgi ";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(141, 43);
            label2.Name = "label2";
            label2.Size = new Size(122, 27);
            label2.TabIndex = 0;
            label2.Text = "00000000000";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(141, 98);
            label4.Name = "label4";
            label4.Size = new Size(99, 27);
            label4.TabIndex = 0;
            label4.Text = "Null Null";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientInactiveCaption;
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Location = new Point(12, 215);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(320, 282);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Randevu Detay";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.GradientInactiveCaption;
            groupBox3.Location = new Point(350, 16);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(597, 481);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Randevu Listesi";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 36);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(308, 175);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.GradientInactiveCaption;
            groupBox4.Location = new Point(12, 514);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(320, 204);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // FrmDoktorDetay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1026, 730);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmDoktorDetay";
            Text = "FrmDoktorDetay";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RichTextBox richTextBox1;
        private GroupBox groupBox4;
    }
}