namespace WinFormsAppExample
{
    partial class FigureForm
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
            buttonColor = new Button();
            panelColor = new Panel();
            numericUpDownX = new NumericUpDown();
            numericUpDownY = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            numericUpDownHeight = new NumericUpDown();
            numericUpDownWidth = new NumericUpDown();
            radioButtonRectangle = new RadioButton();
            label7 = new Label();
            radioButtonEllipse = new RadioButton();
            buttonAccept = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWidth).BeginInit();
            SuspendLayout();
            // 
            // buttonColor
            // 
            buttonColor.Font = new Font("Brush Script MT", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonColor.Location = new Point(12, 12);
            buttonColor.Name = "buttonColor";
            buttonColor.Size = new Size(195, 39);
            buttonColor.TabIndex = 1;
            buttonColor.Text = "Выбрать цвет";
            buttonColor.UseVisualStyleBackColor = true;
            buttonColor.Click += buttonColor_Click;
            // 
            // panelColor
            // 
            panelColor.Location = new Point(213, 12);
            panelColor.Name = "panelColor";
            panelColor.Size = new Size(39, 39);
            panelColor.TabIndex = 2;
            // 
            // numericUpDownX
            // 
            numericUpDownX.Font = new Font("Brush Script MT", 12F, FontStyle.Italic);
            numericUpDownX.Location = new Point(177, 85);
            numericUpDownX.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownX.Name = "numericUpDownX";
            numericUpDownX.Size = new Size(75, 27);
            numericUpDownX.TabIndex = 3;
            // 
            // numericUpDownY
            // 
            numericUpDownY.Font = new Font("Brush Script MT", 12F, FontStyle.Italic);
            numericUpDownY.Location = new Point(177, 118);
            numericUpDownY.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownY.Name = "numericUpDownY";
            numericUpDownY.Size = new Size(75, 27);
            numericUpDownY.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Brush Script MT", 12F, FontStyle.Italic);
            label1.Location = new Point(3, 63);
            label1.Name = "label1";
            label1.Size = new Size(249, 19);
            label1.TabIndex = 5;
            label1.Text = "Координаты левого верхнего угла";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Calligraphy", 12F);
            label2.Location = new Point(145, 85);
            label2.Name = "label2";
            label2.Size = new Size(26, 21);
            label2.TabIndex = 6;
            label2.Text = "X:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Calligraphy", 12F);
            label3.Location = new Point(144, 118);
            label3.Name = "label3";
            label3.Size = new Size(27, 21);
            label3.TabIndex = 7;
            label3.Text = "Y:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Brush Script MT", 12F, FontStyle.Italic);
            label4.Location = new Point(3, 148);
            label4.Name = "label4";
            label4.Size = new Size(73, 19);
            label4.TabIndex = 8;
            label4.Text = "Размеры";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Brush Script MT", 12F, FontStyle.Italic);
            label5.Location = new Point(104, 214);
            label5.Name = "label5";
            label5.Size = new Size(67, 19);
            label5.TabIndex = 12;
            label5.Text = "Высота:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Brush Script MT", 12F, FontStyle.Italic);
            label6.Location = new Point(104, 181);
            label6.Name = "label6";
            label6.Size = new Size(67, 19);
            label6.TabIndex = 11;
            label6.Text = "Ширина:";
            // 
            // numericUpDownHeight
            // 
            numericUpDownHeight.Font = new Font("Brush Script MT", 12F, FontStyle.Italic);
            numericUpDownHeight.Location = new Point(177, 212);
            numericUpDownHeight.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownHeight.Name = "numericUpDownHeight";
            numericUpDownHeight.Size = new Size(75, 27);
            numericUpDownHeight.TabIndex = 10;
            numericUpDownHeight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownWidth
            // 
            numericUpDownWidth.Font = new Font("Brush Script MT", 12F, FontStyle.Italic);
            numericUpDownWidth.Location = new Point(177, 179);
            numericUpDownWidth.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownWidth.Name = "numericUpDownWidth";
            numericUpDownWidth.Size = new Size(75, 27);
            numericUpDownWidth.TabIndex = 9;
            numericUpDownWidth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // radioButtonRectangle
            // 
            radioButtonRectangle.AutoSize = true;
            radioButtonRectangle.Checked = true;
            radioButtonRectangle.Font = new Font("Brush Script MT", 12F, FontStyle.Italic);
            radioButtonRectangle.Location = new Point(115, 292);
            radioButtonRectangle.Name = "radioButtonRectangle";
            radioButtonRectangle.Size = new Size(137, 23);
            radioButtonRectangle.TabIndex = 13;
            radioButtonRectangle.TabStop = true;
            radioButtonRectangle.Text = "Прямоугольник";
            radioButtonRectangle.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Brush Script MT", 12F, FontStyle.Italic);
            label7.Location = new Point(12, 257);
            label7.Name = "label7";
            label7.Size = new Size(58, 19);
            label7.TabIndex = 14;
            label7.Text = "Форма";
            // 
            // radioButtonEllipse
            // 
            radioButtonEllipse.AutoSize = true;
            radioButtonEllipse.Font = new Font("Brush Script MT", 12F, FontStyle.Italic);
            radioButtonEllipse.Location = new Point(115, 321);
            radioButtonEllipse.Name = "radioButtonEllipse";
            radioButtonEllipse.Size = new Size(80, 23);
            radioButtonEllipse.TabIndex = 15;
            radioButtonEllipse.TabStop = true;
            radioButtonEllipse.Text = "Эллипс";
            radioButtonEllipse.UseVisualStyleBackColor = true;
            // 
            // buttonAccept
            // 
            buttonAccept.Font = new Font("Brush Script MT", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonAccept.Location = new Point(12, 350);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(240, 39);
            buttonAccept.TabIndex = 16;
            buttonAccept.Text = "Подтвердить";
            buttonAccept.UseVisualStyleBackColor = true;
            buttonAccept.Click += buttonAccept_Click;
            // 
            // FigureForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 400);
            Controls.Add(buttonAccept);
            Controls.Add(radioButtonEllipse);
            Controls.Add(label7);
            Controls.Add(radioButtonRectangle);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(numericUpDownHeight);
            Controls.Add(numericUpDownWidth);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDownY);
            Controls.Add(numericUpDownX);
            Controls.Add(panelColor);
            Controls.Add(buttonColor);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FigureForm";
            Text = "Данные фигуры";
            ((System.ComponentModel.ISupportInitialize)numericUpDownX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWidth).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonColor;
        private Panel panelColor;
        private NumericUpDown numericUpDownX;
        private NumericUpDown numericUpDownY;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown numericUpDownHeight;
        private NumericUpDown numericUpDownWidth;
        private RadioButton radioButtonRectangle;
        private Label label7;
        private RadioButton radioButtonEllipse;
        private Button buttonAccept;
    }
}