
namespace ProductsWinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            outputTextBox = new TextBox();
            addProductButton = new Button();
            addCustomerButton = new Button();
            addOrderButton = new Button();
            ordersButton = new Button();
            customersButton = new Button();
            productsButton = new Button();
            outputLabel = new Label();
            SuspendLayout();
            // 
            // outputTextBox
            // 
            outputTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            outputTextBox.Location = new Point(12, 27);
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(294, 392);
            outputTextBox.TabIndex = 0;
            // 
            // addProductButton
            // 
            addProductButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addProductButton.Location = new Point(312, 27);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(167, 23);
            addProductButton.TabIndex = 1;
            addProductButton.Text = "Добавить продукт";
            addProductButton.UseVisualStyleBackColor = true;
            addProductButton.Click += addProductButton_Click;
            // 
            // addCustomerButton
            // 
            addCustomerButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addCustomerButton.Location = new Point(312, 56);
            addCustomerButton.Name = "addCustomerButton";
            addCustomerButton.Size = new Size(167, 23);
            addCustomerButton.TabIndex = 2;
            addCustomerButton.Text = "Добавить покупателя";
            addCustomerButton.UseVisualStyleBackColor = true;
            addCustomerButton.Click += addCustomerButton_Click;
            // 
            // addOrderButton
            // 
            addOrderButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addOrderButton.Location = new Point(312, 85);
            addOrderButton.Name = "addOrderButton";
            addOrderButton.Size = new Size(167, 23);
            addOrderButton.TabIndex = 3;
            addOrderButton.Text = "Добавить заказ";
            addOrderButton.UseVisualStyleBackColor = true;
            addOrderButton.Click += addOrderButton_Click;
            // 
            // ordersButton
            // 
            ordersButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ordersButton.Location = new Point(312, 396);
            ordersButton.Name = "ordersButton";
            ordersButton.Size = new Size(167, 23);
            ordersButton.TabIndex = 5;
            ordersButton.Text = "Список заказов";
            ordersButton.UseVisualStyleBackColor = true;
            ordersButton.Click += ordersButton_Click;
            // 
            // customersButton
            // 
            customersButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            customersButton.Location = new Point(312, 367);
            customersButton.Name = "customersButton";
            customersButton.Size = new Size(167, 23);
            customersButton.TabIndex = 6;
            customersButton.Text = "Список покупателей";
            customersButton.UseVisualStyleBackColor = true;
            customersButton.Click += customersButton_Click;
            // 
            // productsButton
            // 
            productsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            productsButton.Location = new Point(312, 338);
            productsButton.Name = "productsButton";
            productsButton.Size = new Size(167, 23);
            productsButton.TabIndex = 7;
            productsButton.Text = "Список продуктов";
            productsButton.UseVisualStyleBackColor = true;
            productsButton.Click += productsButton_Click;
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Location = new Point(12, 9);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(82, 15);
            outputLabel.TabIndex = 8;
            outputLabel.Text = "Окно вывода:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 431);
            Controls.Add(outputLabel);
            Controls.Add(productsButton);
            Controls.Add(customersButton);
            Controls.Add(ordersButton);
            Controls.Add(addOrderButton);
            Controls.Add(addCustomerButton);
            Controls.Add(addProductButton);
            Controls.Add(outputTextBox);
            Name = "MainForm";
            Text = "Иванов И.И. Б24-181-1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox outputTextBox;
        private Button addProductButton;
        private Button addCustomerButton;
        private Button addOrderButton;
        private Button ordersButton;
        private Button customersButton;
        private Button productsButton;
        private Label outputLabel;
    }
}
