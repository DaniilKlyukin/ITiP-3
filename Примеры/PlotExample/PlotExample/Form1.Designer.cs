namespace PlotExample
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
            components = new System.ComponentModel.Container();
            formsPlot = new ScottPlot.WinForms.FormsPlot();
            buttonStart = new Button();
            buttonStop = new Button();
            timer = new System.Windows.Forms.Timer(components);
            buttonSetColor = new Button();
            SuspendLayout();
            // 
            // formsPlot
            // 
            formsPlot.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            formsPlot.DisplayScale = 1F;
            formsPlot.Location = new Point(0, 53);
            formsPlot.Name = "formsPlot";
            formsPlot.Size = new Size(800, 397);
            formsPlot.TabIndex = 0;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(12, 12);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 23);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Старт";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(93, 12);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(75, 23);
            buttonStop.TabIndex = 2;
            buttonStop.Text = "Стоп";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // buttonSetColor
            // 
            buttonSetColor.Location = new Point(174, 12);
            buttonSetColor.Name = "buttonSetColor";
            buttonSetColor.Size = new Size(110, 23);
            buttonSetColor.TabIndex = 3;
            buttonSetColor.Text = "Выбрать цвет";
            buttonSetColor.UseVisualStyleBackColor = true;
            buttonSetColor.Click += buttonSetColor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSetColor);
            Controls.Add(buttonStop);
            Controls.Add(buttonStart);
            Controls.Add(formsPlot);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot formsPlot;
        private Button buttonStart;
        private Button buttonStop;
        private System.Windows.Forms.Timer timer;
        private Button buttonSetColor;
    }
}
