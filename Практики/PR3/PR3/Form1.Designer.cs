namespace PR3
{
    partial class Form1
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
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            buildPlotButton = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(12, 70);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(447, 368);
            formsPlot1.TabIndex = 0;
            // 
            // buildPlotButton
            // 
            buildPlotButton.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buildPlotButton.Location = new Point(91, 10);
            buildPlotButton.Name = "buildPlotButton";
            buildPlotButton.Size = new Size(315, 54);
            buildPlotButton.TabIndex = 1;
            buildPlotButton.Text = "Построить график";
            buildPlotButton.UseVisualStyleBackColor = true;
            buildPlotButton.Click += buildPlotButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(465, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(433, 426);
            dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 450);
            Controls.Add(dataGridView1);
            Controls.Add(buildPlotButton);
            Controls.Add(formsPlot1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private Button buildPlotButton;
        private DataGridView dataGridView1;
    }
}
