namespace AsyncIntegralCalculator
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
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            calcButton = new Button();
            progressBar = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(147, 12);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1000000000, 0, 0, int.MinValue });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 0;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(147, 41);
            numericUpDown2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1000000000, 0, 0, int.MinValue });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 1;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(147, 70);
            numericUpDown3.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(120, 23);
            numericUpDown3.TabIndex = 2;
            numericUpDown3.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 14);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 3;
            label1.Text = "Нижняя граница";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 72);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 4;
            label2.Text = "Разбиений";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 43);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 5;
            label3.Text = "Верхняя граница";
            // 
            // calcButton
            // 
            calcButton.Location = new Point(42, 99);
            calcButton.Name = "calcButton";
            calcButton.Size = new Size(225, 23);
            calcButton.TabIndex = 6;
            calcButton.Text = "Начать расчет";
            calcButton.UseVisualStyleBackColor = true;
            calcButton.Click += calcButton_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(42, 128);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(225, 23);
            progressBar.TabIndex = 7;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 163);
            Controls.Add(progressBar);
            Controls.Add(calcButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Name = "MainForm";
            Text = "Расчет интеграла";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button calcButton;
        private ProgressBar progressBar;
    }
}