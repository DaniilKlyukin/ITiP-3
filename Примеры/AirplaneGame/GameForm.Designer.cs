namespace AirplaneGame
{
    partial class GameForm
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
            gameTimer = new System.Windows.Forms.Timer(components);
            gamePictureBox = new PictureBox();
            backgroundTimer = new System.Windows.Forms.Timer(components);
            ScoreTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gamePictureBox).BeginInit();
            SuspendLayout();
            // 
            // gamePictureBox
            // 
            gamePictureBox.Dock = DockStyle.Left;
            gamePictureBox.Location = new System.Drawing.Point(0, 0);
            gamePictureBox.Name = "gamePictureBox";
            gamePictureBox.Size = new Size(1200, 800);
            gamePictureBox.TabIndex = 0;
            gamePictureBox.TabStop = false;
            // 
            // backgroundTimer
            // 
            backgroundTimer.Enabled = true;
            backgroundTimer.Interval = 50;
            backgroundTimer.Tick += backgroundTimer_Tick;
            // 
            // ScoreTextBox
            // 
            ScoreTextBox.Dock = DockStyle.Fill;
            ScoreTextBox.Font = new Font("Cascadia Mono", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            ScoreTextBox.Location = new System.Drawing.Point(1200, 0);
            ScoreTextBox.Multiline = true;
            ScoreTextBox.Name = "ScoreTextBox";
            ScoreTextBox.ReadOnly = true;
            ScoreTextBox.Size = new Size(384, 800);
            ScoreTextBox.TabIndex = 1;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 800);
            Controls.Add(ScoreTextBox);
            Controls.Add(gamePictureBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "GameForm";
            Text = "Игра управление НЛО";
            ((System.ComponentModel.ISupportInitialize)gamePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox gamePictureBox;
        private System.Windows.Forms.Timer backgroundTimer;
        private TextBox ScoreTextBox;
    }
}