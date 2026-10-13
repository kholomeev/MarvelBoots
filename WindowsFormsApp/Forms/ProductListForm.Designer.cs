namespace WindowsFormsApp.Forms
{
    partial class ProductListForm
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
            this.panel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cheapFirst = new System.Windows.Forms.RadioButton();
            this.expensiveFirst = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ordersButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel);
            this.splitContainer1.Panel2.Controls.Add(this.panel);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ordersButton);
            this.panel.Controls.Add(this.textBox1);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.categoryComboBox);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.groupBox1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(800, 50);
            this.panel.TabIndex = 0;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 50);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(800, 306);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.expensiveFirst);
            this.groupBox1.Controls.Add(this.cheapFirst);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 41);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Цена";
            // 
            // cheapFirst
            // 
            this.cheapFirst.AutoSize = true;
            this.cheapFirst.Checked = true;
            this.cheapFirst.Location = new System.Drawing.Point(6, 18);
            this.cheapFirst.Name = "cheapFirst";
            this.cheapFirst.Size = new System.Drawing.Size(65, 17);
            this.cheapFirst.TabIndex = 0;
            this.cheapFirst.TabStop = true;
            this.cheapFirst.Text = "Меньше";
            this.cheapFirst.UseVisualStyleBackColor = true;
            // 
            // expensiveFirst
            // 
            this.expensiveFirst.AutoSize = true;
            this.expensiveFirst.Location = new System.Drawing.Point(81, 18);
            this.expensiveFirst.Name = "expensiveFirst";
            this.expensiveFirst.Size = new System.Drawing.Size(62, 17);
            this.expensiveFirst.TabIndex = 1;
            this.expensiveFirst.Text = "Больше";
            this.expensiveFirst.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Категория";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Все категории",
            "Детская обувь",
            "Женская обувь",
            "Мужская обувь"});
            this.categoryComboBox.Location = new System.Drawing.Point(246, 16);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryComboBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Поиск";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(447, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 4;
            // 
            // ordersButton
            // 
            this.ordersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(178)))), ((int)(((byte)(175)))));
            this.ordersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ordersButton.Location = new System.Drawing.Point(705, 14);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(75, 23);
            this.ordersButton.TabIndex = 5;
            this.ordersButton.Text = "Заказы";
            this.ordersButton.UseVisualStyleBackColor = false;
            // 
            // ProductListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "ProductListForm";
            this.Text = "ProductListForm";
            this.Load += new System.EventHandler(this.ProductListForm_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton expensiveFirst;
        private System.Windows.Forms.RadioButton cheapFirst;
        private System.Windows.Forms.Button ordersButton;
    }
}