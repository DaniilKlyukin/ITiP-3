namespace EntityExample
{
    partial class MainForm
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
            buttonCustomers = new Button();
            buttonProducts = new Button();
            buttonBankAccounts = new Button();
            SuspendLayout();
            // 
            // buttonCustomers
            // 
            buttonCustomers.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCustomers.Location = new Point(12, 12);
            buttonCustomers.Name = "buttonCustomers";
            buttonCustomers.Size = new Size(175, 34);
            buttonCustomers.TabIndex = 0;
            buttonCustomers.Text = "Покупатели";
            buttonCustomers.UseVisualStyleBackColor = true;
            buttonCustomers.Click += buttonCustomers_Click;
            // 
            // buttonProducts
            // 
            buttonProducts.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonProducts.Location = new Point(12, 92);
            buttonProducts.Name = "buttonProducts";
            buttonProducts.Size = new Size(175, 34);
            buttonProducts.TabIndex = 1;
            buttonProducts.Text = "Товары";
            buttonProducts.UseVisualStyleBackColor = true;
            buttonProducts.Click += buttonProducts_Click;
            // 
            // buttonBankAccounts
            // 
            buttonBankAccounts.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBankAccounts.Location = new Point(12, 52);
            buttonBankAccounts.Name = "buttonBankAccounts";
            buttonBankAccounts.Size = new Size(175, 34);
            buttonBankAccounts.TabIndex = 2;
            buttonBankAccounts.Text = "Банковские аккаунты";
            buttonBankAccounts.UseVisualStyleBackColor = true;
            buttonBankAccounts.Click += buttonBankAccounts_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 439);
            Controls.Add(buttonBankAccounts);
            Controls.Add(buttonProducts);
            Controls.Add(buttonCustomers);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCustomers;
        private Button buttonProducts;
        private Button buttonBankAccounts;
    }
}