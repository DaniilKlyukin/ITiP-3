namespace EntityExample
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
            buttonAccept = new Button();
            numericUpDownPrice = new NumericUpDown();
            textBoxName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            SuspendLayout();
            // 
            // buttonAccept
            // 
            buttonAccept.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAccept.Location = new Point(150, 89);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(183, 36);
            buttonAccept.TabIndex = 9;
            buttonAccept.Text = "Подтвердить";
            buttonAccept.UseVisualStyleBackColor = true;
            buttonAccept.Click += buttonAccept_Click;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.DecimalPlaces = 2;
            numericUpDownPrice.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownPrice.Location = new Point(150, 48);
            numericUpDownPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(183, 26);
            numericUpDownPrice.TabIndex = 8;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(150, 16);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(183, 26);
            textBoxName.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(98, 50);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 6;
            label2.Text = "Цена:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 19);
            label1.Name = "label1";
            label1.Size = new Size(125, 19);
            label1.TabIndex = 5;
            label1.Text = "Название товара:";
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 146);
            Controls.Add(buttonAccept);
            Controls.Add(numericUpDownPrice);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ProductForm";
            Text = "Товар";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAccept;
        private NumericUpDown numericUpDownPrice;
        private TextBox textBoxName;
        private Label label2;
        private Label label1;
    }
}