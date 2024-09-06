namespace EntityExample
{
    partial class CustomersForm
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
            dataGridView1 = new DataGridView();
            buttonAddCustomer = new Button();
            buttonEditCustomer = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(635, 485);
            dataGridView1.TabIndex = 0;
            dataGridView1.PreviewKeyDown += dataGridView1_PreviewKeyDown;
            // 
            // buttonAddCustomer
            // 
            buttonAddCustomer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAddCustomer.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddCustomer.Location = new Point(12, 491);
            buttonAddCustomer.Name = "buttonAddCustomer";
            buttonAddCustomer.Size = new Size(180, 32);
            buttonAddCustomer.TabIndex = 1;
            buttonAddCustomer.Text = "Добавить покупателя";
            buttonAddCustomer.UseVisualStyleBackColor = true;
            buttonAddCustomer.Click += buttonAddCustomer_Click;
            // 
            // buttonEditCustomer
            // 
            buttonEditCustomer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonEditCustomer.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditCustomer.Location = new Point(198, 491);
            buttonEditCustomer.Name = "buttonEditCustomer";
            buttonEditCustomer.Size = new Size(219, 32);
            buttonEditCustomer.TabIndex = 2;
            buttonEditCustomer.Text = "Редактировать покупателя";
            buttonEditCustomer.UseVisualStyleBackColor = true;
            buttonEditCustomer.Click += buttonEditCustomer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 535);
            Controls.Add(buttonEditCustomer);
            Controls.Add(buttonAddCustomer);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Покупатели";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonAddCustomer;
        private Button buttonEditCustomer;
    }
}