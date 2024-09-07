namespace EntityExample
{
    partial class BankAccountsForm
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
            dataGridView1 = new DataGridView();
            buttonEditAccount = new Button();
            buttonAddAccount = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, -1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(658, 297);
            dataGridView1.TabIndex = 0;
            dataGridView1.PreviewKeyDown += dataGridView1_PreviewKeyDown;
            // 
            // buttonEditAccount
            // 
            buttonEditAccount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonEditAccount.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditAccount.Location = new Point(198, 304);
            buttonEditAccount.Name = "buttonEditAccount";
            buttonEditAccount.Size = new Size(219, 32);
            buttonEditAccount.TabIndex = 4;
            buttonEditAccount.Text = "Редактировать аккаунт";
            buttonEditAccount.UseVisualStyleBackColor = true;
            buttonEditAccount.Click += buttonEditAccount_Click;
            // 
            // buttonAddAccount
            // 
            buttonAddAccount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAddAccount.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddAccount.Location = new Point(12, 304);
            buttonAddAccount.Name = "buttonAddAccount";
            buttonAddAccount.Size = new Size(180, 32);
            buttonAddAccount.TabIndex = 3;
            buttonAddAccount.Text = "Добавить аккаунт";
            buttonAddAccount.UseVisualStyleBackColor = true;
            buttonAddAccount.Click += buttonAddAccount_Click;
            // 
            // BankAccountsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 348);
            Controls.Add(buttonEditAccount);
            Controls.Add(buttonAddAccount);
            Controls.Add(dataGridView1);
            Name = "BankAccountsForm";
            Text = "Банковские аккаунты";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonEditAccount;
        private Button buttonAddAccount;
    }
}