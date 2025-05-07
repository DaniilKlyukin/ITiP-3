namespace WinFormsAppExample
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
            buttonInput = new Button();
            buttonDraw = new Button();
            buttonExit = new Button();
            pictureBox = new PictureBox();
            buttonClear = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // buttonInput
            // 
            buttonInput.Font = new Font("Brush Script MT", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonInput.Location = new Point(12, 12);
            buttonInput.Name = "buttonInput";
            buttonInput.Size = new Size(195, 39);
            buttonInput.TabIndex = 0;
            buttonInput.Text = "Ввести данные";
            buttonInput.UseVisualStyleBackColor = true;
            buttonInput.Click += buttonInput_Click;
            // 
            // buttonDraw
            // 
            buttonDraw.Font = new Font("Brush Script MT", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonDraw.Location = new Point(12, 57);
            buttonDraw.Name = "buttonDraw";
            buttonDraw.Size = new Size(195, 39);
            buttonDraw.TabIndex = 1;
            buttonDraw.Text = "Нарисовать фигуру";
            buttonDraw.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Brush Script MT", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonExit.Location = new Point(12, 102);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(195, 39);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "Выйти";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.White;
            pictureBox.Location = new Point(12, 147);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(760, 402);
            pictureBox.TabIndex = 3;
            pictureBox.TabStop = false;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Brush Script MT", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonClear.Location = new Point(213, 57);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(195, 39);
            buttonClear.TabIndex = 4;
            buttonClear.Text = "Очистить полотно";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(buttonClear);
            Controls.Add(pictureBox);
            Controls.Add(buttonExit);
            Controls.Add(buttonDraw);
            Controls.Add(buttonInput);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainForm";
            Text = "Главное окно";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonInput;
        private Button buttonDraw;
        private Button buttonExit;
        private PictureBox pictureBox;
        private Button buttonClear;
    }
}
