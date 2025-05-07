namespace ProductsWinFormsApp
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
            nameLabel = new Label();
            nameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            confirmButton = new Button();
            emailTextBox = new TextBox();
            addressTextBox = new TextBox();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(37, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "ФИО:";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Location = new Point(12, 27);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(244, 23);
            nameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Адрес:";
            // 
            // confirmButton
            // 
            confirmButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            confirmButton.Location = new Point(12, 144);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(244, 23);
            confirmButton.TabIndex = 7;
            confirmButton.Text = "Принять";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            emailTextBox.Location = new Point(12, 71);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(244, 23);
            emailTextBox.TabIndex = 8;
            // 
            // addressTextBox
            // 
            addressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addressTextBox.Location = new Point(12, 115);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(244, 23);
            addressTextBox.TabIndex = 9;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 183);
            Controls.Add(addressTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(confirmButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Name = "CustomerForm";
            Text = "Параметры покупателя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameTextBox;
        private Label label1;
        private Label label2;
        private Button confirmButton;
        private TextBox emailTextBox;
        private TextBox addressTextBox;
    }
}