namespace WindowsFormsApp.Forms
{
    partial class ProductDetailForm
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
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.stockLabel = new System.Windows.Forms.Label();
            this.compositionLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.sizeRangeLabel = new System.Windows.Forms.Label();
            this.subсategoryLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toCartButton = new System.Windows.Forms.Button();
            this.amointNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sizeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amointNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.photoPictureBox);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Location = new System.Drawing.Point(0, 0);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(37, 13);
            this.manufacturerLabel.TabIndex = 1;
            this.manufacturerLabel.Text = "label1";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(0, 52);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(37, 13);
            this.categoryLabel.TabIndex = 2;
            this.categoryLabel.Text = "label2";
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Location = new System.Drawing.Point(0, 65);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(37, 13);
            this.stockLabel.TabIndex = 3;
            this.stockLabel.Text = "label3";
            // 
            // compositionLabel
            // 
            this.compositionLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.compositionLabel.Location = new System.Drawing.Point(0, 176);
            this.compositionLabel.Name = "compositionLabel";
            this.compositionLabel.Size = new System.Drawing.Size(454, 62);
            this.compositionLabel.TabIndex = 4;
            this.compositionLabel.Text = "label4";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.idLabel);
            this.panel1.Controls.Add(this.priceLabel);
            this.panel1.Location = new System.Drawing.Point(635, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 121);
            this.panel1.TabIndex = 9;
            // 
            // idLabel
            // 
            this.idLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.idLabel.Location = new System.Drawing.Point(77, 105);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(41, 16);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "label1";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // priceLabel
            // 
            this.priceLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.priceLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.priceLabel.Location = new System.Drawing.Point(0, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(118, 33);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "label1";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.Location = new System.Drawing.Point(48, 19);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(116, 121);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 8;
            this.photoPictureBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.descriptionLabel);
            this.panel2.Controls.Add(this.sizeRangeLabel);
            this.panel2.Controls.Add(this.subсategoryLabel);
            this.panel2.Controls.Add(this.productNameLabel);
            this.panel2.Controls.Add(this.manufacturerLabel);
            this.panel2.Controls.Add(this.categoryLabel);
            this.panel2.Controls.Add(this.stockLabel);
            this.panel2.Controls.Add(this.compositionLabel);
            this.panel2.Location = new System.Drawing.Point(175, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 238);
            this.panel2.TabIndex = 10;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.descriptionLabel.Location = new System.Drawing.Point(0, 114);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(454, 62);
            this.descriptionLabel.TabIndex = 8;
            this.descriptionLabel.Text = "label4";
            // 
            // sizeRangeLabel
            // 
            this.sizeRangeLabel.AutoSize = true;
            this.sizeRangeLabel.Location = new System.Drawing.Point(0, 26);
            this.sizeRangeLabel.Name = "sizeRangeLabel";
            this.sizeRangeLabel.Size = new System.Drawing.Size(37, 13);
            this.sizeRangeLabel.TabIndex = 7;
            this.sizeRangeLabel.Text = "label3";
            // 
            // subсategoryLabel
            // 
            this.subсategoryLabel.AutoSize = true;
            this.subсategoryLabel.Location = new System.Drawing.Point(219, 52);
            this.subсategoryLabel.Name = "subсategoryLabel";
            this.subсategoryLabel.Size = new System.Drawing.Size(37, 13);
            this.subсategoryLabel.TabIndex = 6;
            this.subсategoryLabel.Text = "label2";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(0, 13);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(37, 13);
            this.productNameLabel.TabIndex = 5;
            this.productNameLabel.Text = "label1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.toCartButton);
            this.panel3.Controls.Add(this.amointNumericUpDown);
            this.panel3.Controls.Add(this.sizeComboBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 299);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 57);
            this.panel3.TabIndex = 11;
            // 
            // toCartButton
            // 
            this.toCartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(178)))), ((int)(((byte)(175)))));
            this.toCartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toCartButton.Location = new System.Drawing.Point(705, 14);
            this.toCartButton.Margin = new System.Windows.Forms.Padding(20);
            this.toCartButton.Name = "toCartButton";
            this.toCartButton.Size = new System.Drawing.Size(75, 23);
            this.toCartButton.TabIndex = 4;
            this.toCartButton.Text = "В корзину";
            this.toCartButton.UseVisualStyleBackColor = false;
            this.toCartButton.Click += new System.EventHandler(this.toCartButton_Click);
            // 
            // amointNumericUpDown
            // 
            this.amointNumericUpDown.Location = new System.Drawing.Point(447, 16);
            this.amointNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amointNumericUpDown.Name = "amointNumericUpDown";
            this.amointNumericUpDown.Size = new System.Drawing.Size(235, 21);
            this.amointNumericUpDown.TabIndex = 3;
            this.amointNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sizeComboBox
            // 
            this.sizeComboBox.FormattingEnabled = true;
            this.sizeComboBox.Location = new System.Drawing.Point(104, 16);
            this.sizeComboBox.Name = "sizeComboBox";
            this.sizeComboBox.Size = new System.Drawing.Size(254, 21);
            this.sizeComboBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Количество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Размер";
            // 
            // ProductDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "ProductDetailForm";
            this.Text = "ProductDetailForm";
            this.Load += new System.EventHandler(this.ProductDetailForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amointNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.Label compositionLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label subсategoryLabel;
        private System.Windows.Forms.Label sizeRangeLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown amointNumericUpDown;
        private System.Windows.Forms.ComboBox sizeComboBox;
        private System.Windows.Forms.Button toCartButton;
    }
}