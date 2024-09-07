namespace EntityExample
{
    partial class BankAccountForm
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
            comboBoxCustomer = new ComboBox();
            buttonAccept = new Button();
            label1 = new Label();
            label2 = new Label();
            numericUpDownMoney = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMoney).BeginInit();
            SuspendLayout();
            // 
            // comboBoxCustomer
            // 
            comboBoxCustomer.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCustomer.FormattingEnabled = true;
            comboBoxCustomer.Location = new Point(161, 31);
            comboBoxCustomer.Name = "comboBoxCustomer";
            comboBoxCustomer.Size = new Size(183, 27);
            comboBoxCustomer.TabIndex = 0;
            // 
            // buttonAccept
            // 
            buttonAccept.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAccept.Location = new Point(161, 102);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(183, 36);
            buttonAccept.TabIndex = 10;
            buttonAccept.Text = "Подтвердить";
            buttonAccept.UseVisualStyleBackColor = true;
            buttonAccept.Click += buttonAccept_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(65, 34);
            label1.Name = "label1";
            label1.Size = new Size(90, 19);
            label1.TabIndex = 11;
            label1.Text = "Покупатель:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(43, 70);
            label2.Name = "label2";
            label2.Size = new Size(112, 19);
            label2.TabIndex = 12;
            label2.Text = "Денег на счете:";
            // 
            // numericUpDownMoney
            // 
            numericUpDownMoney.DecimalPlaces = 2;
            numericUpDownMoney.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownMoney.Location = new Point(161, 70);
            numericUpDownMoney.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            numericUpDownMoney.Name = "numericUpDownMoney";
            numericUpDownMoney.Size = new Size(183, 26);
            numericUpDownMoney.TabIndex = 13;
            // 
            // BankAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 165);
            Controls.Add(numericUpDownMoney);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonAccept);
            Controls.Add(comboBoxCustomer);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "BankAccountForm";
            Text = "Банковский аккаунт";
            ((System.ComponentModel.ISupportInitialize)numericUpDownMoney).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxCustomer;
        private Button buttonAccept;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDownMoney;
    }
}