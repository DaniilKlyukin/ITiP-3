namespace IntegralCalculatorApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            numLowerLimit = new NumericUpDown();
            label2 = new Label();
            numUpperLimit = new NumericUpDown();
            label3 = new Label();
            numSegments = new NumericUpDown();
            btnCalculate = new Button();
            progressBar = new ProgressBar();
            lblResult = new Label();
            ((System.ComponentModel.ISupportInitialize)numLowerLimit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUpperLimit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSegments).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 15);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Нижний предел:";
            // 
            // numLowerLimit
            // 
            numLowerLimit.DecimalPlaces = 2;
            numLowerLimit.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numLowerLimit.Location = new Point(122, 14);
            numLowerLimit.Margin = new Padding(3, 2, 3, 2);
            numLowerLimit.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numLowerLimit.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numLowerLimit.Name = "numLowerLimit";
            numLowerLimit.Size = new Size(105, 23);
            numLowerLimit.TabIndex = 1;
            numLowerLimit.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 45);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 2;
            label2.Text = "Верхний предел:";
            // 
            // numUpperLimit
            // 
            numUpperLimit.DecimalPlaces = 2;
            numUpperLimit.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numUpperLimit.Location = new Point(122, 44);
            numUpperLimit.Margin = new Padding(3, 2, 3, 2);
            numUpperLimit.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numUpperLimit.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numUpperLimit.Name = "numUpperLimit";
            numUpperLimit.Size = new Size(105, 23);
            numUpperLimit.TabIndex = 3;
            numUpperLimit.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 75);
            label3.Name = "label3";
            label3.Size = new Size(135, 15);
            label3.TabIndex = 4;
            label3.Text = "Количество сегментов:";
            // 
            // numSegments
            // 
            numSegments.Location = new Point(149, 74);
            numSegments.Margin = new Padding(3, 2, 3, 2);
            numSegments.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numSegments.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSegments.Name = "numSegments";
            numSegments.Size = new Size(79, 23);
            numSegments.TabIndex = 5;
            numSegments.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(18, 105);
            btnCalculate.Margin = new Padding(3, 2, 3, 2);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(210, 26);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Вычислить";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(18, 142);
            progressBar.Margin = new Padding(3, 2, 3, 2);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(210, 15);
            progressBar.TabIndex = 7;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(18, 172);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(247, 205);
            Controls.Add(lblResult);
            Controls.Add(progressBar);
            Controls.Add(btnCalculate);
            Controls.Add(numSegments);
            Controls.Add(label3);
            Controls.Add(numUpperLimit);
            Controls.Add(label2);
            Controls.Add(numLowerLimit);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Калькулятор интегралов";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)numLowerLimit).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUpperLimit).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSegments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numLowerLimit;
        private Label label2;
        private NumericUpDown numUpperLimit;
        private Label label3;
        private NumericUpDown numSegments;
        private Button btnCalculate;
        private ProgressBar progressBar;
        private Label lblResult;
    }
}