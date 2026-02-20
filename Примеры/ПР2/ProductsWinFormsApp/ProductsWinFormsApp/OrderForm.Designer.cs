namespace ProductsWinFormsApp
{
    partial class OrderForm
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
            confirmButton = new Button();
            customersComboBox = new ComboBox();
            label2 = new Label();
            addedProductsListBox = new ListBox();
            addProductButton = new Button();
            productsComboBox = new ComboBox();
            label3 = new Label();
            removeProductButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 2;
            label1.Text = "Покупатель:";
            // 
            // confirmButton
            // 
            confirmButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            confirmButton.Location = new Point(12, 393);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(235, 23);
            confirmButton.TabIndex = 7;
            confirmButton.Text = "Принять";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // customersComboBox
            // 
            customersComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customersComboBox.FormattingEnabled = true;
            customersComboBox.Location = new Point(12, 27);
            customersComboBox.Name = "customersComboBox";
            customersComboBox.Size = new Size(235, 23);
            customersComboBox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 10;
            label2.Text = "Товары:";
            // 
            // addedProductsListBox
            // 
            addedProductsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addedProductsListBox.FormattingEnabled = true;
            addedProductsListBox.ItemHeight = 15;
            addedProductsListBox.Location = new Point(12, 71);
            addedProductsListBox.Name = "addedProductsListBox";
            addedProductsListBox.Size = new Size(235, 214);
            addedProductsListBox.TabIndex = 11;
            // 
            // addProductButton
            // 
            addProductButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addProductButton.Location = new Point(12, 335);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(235, 23);
            addProductButton.TabIndex = 12;
            addProductButton.Text = "Добавить товар";
            addProductButton.UseVisualStyleBackColor = true;
            addProductButton.Click += addProductButton_Click;
            // 
            // productsComboBox
            // 
            productsComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            productsComboBox.FormattingEnabled = true;
            productsComboBox.Location = new Point(12, 306);
            productsComboBox.Name = "productsComboBox";
            productsComboBox.Size = new Size(235, 23);
            productsComboBox.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 288);
            label3.Name = "label3";
            label3.Size = new Size(192, 15);
            label3.TabIndex = 14;
            label3.Text = "Выберите товар, чтобы добавить:";
            // 
            // removeProductButton
            // 
            removeProductButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            removeProductButton.Location = new Point(12, 364);
            removeProductButton.Name = "removeProductButton";
            removeProductButton.Size = new Size(235, 23);
            removeProductButton.TabIndex = 15;
            removeProductButton.Text = "Убрать товар";
            removeProductButton.UseVisualStyleBackColor = true;
            removeProductButton.Click += removeProductButton_Click;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 431);
            Controls.Add(removeProductButton);
            Controls.Add(label3);
            Controls.Add(productsComboBox);
            Controls.Add(addProductButton);
            Controls.Add(addedProductsListBox);
            Controls.Add(label2);
            Controls.Add(customersComboBox);
            Controls.Add(confirmButton);
            Controls.Add(label1);
            Name = "OrderForm";
            Text = "Параметры заказа";
            Load += OrderForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button confirmButton;
        private ComboBox customersComboBox;
        private Label label2;
        private ListBox addedProductsListBox;
        private Button addProductButton;
        private ComboBox productsComboBox;
        private Label label3;
        private Button removeProductButton;
    }
}