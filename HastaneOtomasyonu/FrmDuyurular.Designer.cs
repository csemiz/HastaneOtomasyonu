namespace HastaneOtomasyonu
{
    partial class FrmDuyurular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDuyurular));
            dataGridDuyurular = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridDuyurular).BeginInit();
            SuspendLayout();
            // 
            // dataGridDuyurular
            // 
            dataGridDuyurular.BackgroundColor = Color.AntiqueWhite;
            dataGridDuyurular.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDuyurular.Dock = DockStyle.Fill;
            dataGridDuyurular.Location = new Point(0, 0);
            dataGridDuyurular.Name = "dataGridDuyurular";
            dataGridDuyurular.RowHeadersWidth = 51;
            dataGridDuyurular.RowTemplate.Height = 29;
            dataGridDuyurular.Size = new Size(822, 491);
            dataGridDuyurular.TabIndex = 1;
            // 
            // FrmDuyurular
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 491);
            Controls.Add(dataGridDuyurular);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmDuyurular";
            Text = "FrmDuyurular";
            ((System.ComponentModel.ISupportInitialize)dataGridDuyurular).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridDuyurular;
    }
}