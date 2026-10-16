namespace WindowsFormsApp.UserControls
{
    partial class ProductControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.stockLabel = new System.Windows.Forms.Label();
            this.compositionLabel = new System.Windows.Forms.Label();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.priceLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.manufacturerLabel.Location = new System.Drawing.Point(0, 0);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(454, 33);
            this.manufacturerLabel.TabIndex = 1;
            this.manufacturerLabel.Text = "label1";
            this.manufacturerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(0, 33);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(35, 13);
            this.categoryLabel.TabIndex = 2;
            this.categoryLabel.Text = "label2";
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Location = new System.Drawing.Point(0, 46);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(35, 13);
            this.stockLabel.TabIndex = 3;
            this.stockLabel.Text = "label3";
            // 
            // compositionLabel
            // 
            this.compositionLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.compositionLabel.Location = new System.Drawing.Point(0, 59);
            this.compositionLabel.Name = "compositionLabel";
            this.compositionLabel.Size = new System.Drawing.Size(454, 62);
            this.compositionLabel.TabIndex = 4;
            this.compositionLabel.Text = "label4";
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.Location = new System.Drawing.Point(20, 20);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(116, 121);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 0;
            this.photoPictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.IdLabel);
            this.panel1.Controls.Add(this.priceLabel);
            this.panel1.Location = new System.Drawing.Point(607, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 121);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.manufacturerLabel);
            this.panel2.Controls.Add(this.categoryLabel);
            this.panel2.Controls.Add(this.stockLabel);
            this.panel2.Controls.Add(this.compositionLabel);
            this.panel2.Location = new System.Drawing.Point(147, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 121);
            this.panel2.TabIndex = 7;
            // 
            // priceLabel
            // 
            this.priceLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.priceLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.priceLabel.Location = new System.Drawing.Point(0, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(118, 33);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "label1";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // IdLabel
            // 
            this.IdLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.IdLabel.Location = new System.Drawing.Point(77, 105);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(41, 16);
            this.IdLabel.TabIndex = 3;
            this.IdLabel.Text = "label1";
            this.IdLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(740, 158);
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.Label compositionLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label priceLabel;
    }
}
