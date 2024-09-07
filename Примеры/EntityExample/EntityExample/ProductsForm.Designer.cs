namespace EntityExample
{
    partial class ProductsForm
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
            buttonEditProduct = new Button();
            buttonAddProduct = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonEditProduct
            // 
            buttonEditProduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonEditProduct.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditProduct.Location = new Point(198, 412);
            buttonEditProduct.Name = "buttonEditProduct";
            buttonEditProduct.Size = new Size(219, 32);
            buttonEditProduct.TabIndex = 7;
            buttonEditProduct.Text = "Редактировать товар";
            buttonEditProduct.UseVisualStyleBackColor = true;
            buttonEditProduct.Click += buttonEditProduct_Click;
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAddProduct.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddProduct.Location = new Point(12, 412);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(180, 32);
            buttonAddProduct.TabIndex = 6;
            buttonAddProduct.Text = "Добавить товар";
            buttonAddProduct.UseVisualStyleBackColor = true;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(523, 406);
            dataGridView1.TabIndex = 5;
            dataGridView1.PreviewKeyDown += dataGridView1_PreviewKeyDown;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 456);
            Controls.Add(buttonEditProduct);
            Controls.Add(buttonAddProduct);
            Controls.Add(dataGridView1);
            Name = "ProductsForm";
            Text = "Товары";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonEditProduct;
        private Button buttonAddProduct;
        private DataGridView dataGridView1;
    }
}