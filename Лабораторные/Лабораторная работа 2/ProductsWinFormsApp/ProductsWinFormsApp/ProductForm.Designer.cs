namespace ProductsWinFormsApp
{
    partial class ProductForm
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
            nameLabel = new Label();
            nameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            priceNumeric = new NumericUpDown();
            quantityNumeric = new NumericUpDown();
            confirmButton = new Button();
            ((System.ComponentModel.ISupportInitialize)priceNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quantityNumeric).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(62, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Название:";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Location = new Point(12, 27);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(235, 23);
            nameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "Цена:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 4;
            label2.Text = "Количество:";
            // 
            // priceNumeric
            // 
            priceNumeric.Location = new Point(12, 71);
            priceNumeric.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            priceNumeric.Name = "priceNumeric";
            priceNumeric.Size = new Size(235, 23);
            priceNumeric.TabIndex = 5;
            // 
            // quantityNumeric
            // 
            quantityNumeric.Location = new Point(12, 115);
            quantityNumeric.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            quantityNumeric.Name = "quantityNumeric";
            quantityNumeric.Size = new Size(235, 23);
            quantityNumeric.TabIndex = 6;
            // 
            // confirmButton
            // 
            confirmButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            confirmButton.Location = new Point(12, 144);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(235, 23);
            confirmButton.TabIndex = 7;
            confirmButton.Text = "Принять";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 183);
            Controls.Add(confirmButton);
            Controls.Add(quantityNumeric);
            Controls.Add(priceNumeric);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Name = "ProductForm";
            Text = "Параметры товара";
            ((System.ComponentModel.ISupportInitialize)priceNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)quantityNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameTextBox;
        private Label label1;
        private Label label2;
        private NumericUpDown priceNumeric;
        private NumericUpDown quantityNumeric;
        private Button confirmButton;
    }
}