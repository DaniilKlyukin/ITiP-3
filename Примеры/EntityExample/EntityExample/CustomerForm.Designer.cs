namespace EntityExample
{
    partial class CustomerForm
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
            label1 = new Label();
            label2 = new Label();
            textBoxName = new TextBox();
            numericUpDownAge = new NumericUpDown();
            buttonAccept = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(46, 26);
            label1.Name = "label1";
            label1.Size = new Size(40, 19);
            label1.TabIndex = 0;
            label1.Text = "Имя:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 57);
            label2.Name = "label2";
            label2.Size = new Size(65, 19);
            label2.TabIndex = 1;
            label2.Text = "Возраст:";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(92, 23);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(183, 26);
            textBoxName.TabIndex = 2;
            // 
            // numericUpDownAge
            // 
            numericUpDownAge.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownAge.Location = new Point(92, 55);
            numericUpDownAge.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownAge.Name = "numericUpDownAge";
            numericUpDownAge.Size = new Size(183, 26);
            numericUpDownAge.TabIndex = 3;
            // 
            // buttonAccept
            // 
            buttonAccept.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAccept.Location = new Point(92, 97);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(183, 36);
            buttonAccept.TabIndex = 4;
            buttonAccept.Text = "Подтвердить";
            buttonAccept.UseVisualStyleBackColor = true;
            buttonAccept.Click += buttonAccept_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 156);
            Controls.Add(buttonAccept);
            Controls.Add(numericUpDownAge);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CustomerForm";
            Text = "Покупатель";
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxName;
        private NumericUpDown numericUpDownAge;
        private Button buttonAccept;
    }
}