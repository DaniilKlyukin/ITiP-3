namespace GuessNumberGame
{
    partial class MainForm
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

        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.guessTextBox = new System.Windows.Forms.TextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.attemptsLabel = new System.Windows.Forms.Label();
            this.rangeLabel = new System.Windows.Forms.Label();
            this.historyLabel = new System.Windows.Forms.Label();
            this.historyListBox = new System.Windows.Forms.ListBox();
            this.newGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // titleLabel
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(70, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(160, 24);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Угадай число!";

            // guessTextBox
            this.guessTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guessTextBox.Location = new System.Drawing.Point(30, 60);
            this.guessTextBox.Name = "guessTextBox";
            this.guessTextBox.Size = new System.Drawing.Size(100, 26);
            this.guessTextBox.TabIndex = 1;
            this.guessTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guessTextBox_KeyPress);

            // guessButton
            this.guessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guessButton.Location = new System.Drawing.Point(150, 60);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(100, 26);
            this.guessButton.TabIndex = 2;
            this.guessButton.Text = "Угадать";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);

            // statusLabel
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.Location = new System.Drawing.Point(30, 100);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(185, 17);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "Введите число и нажмите Угадать";

            // attemptsLabel
            this.attemptsLabel.AutoSize = true;
            this.attemptsLabel.Location = new System.Drawing.Point(30, 130);
            this.attemptsLabel.Name = "attemptsLabel";
            this.attemptsLabel.Size = new System.Drawing.Size(64, 13);
            this.attemptsLabel.TabIndex = 4;
            this.attemptsLabel.Text = "Попыток: 0";

            // rangeLabel
            this.rangeLabel.AutoSize = true;
            this.rangeLabel.Location = new System.Drawing.Point(30, 150);
            this.rangeLabel.Name = "rangeLabel";
            this.rangeLabel.Size = new System.Drawing.Size(95, 13);
            this.rangeLabel.TabIndex = 5;
            this.rangeLabel.Text = "Диапазон: 1-100";

            // historyLabel
            this.historyLabel.AutoSize = true;
            this.historyLabel.Location = new System.Drawing.Point(30, 180);
            this.historyLabel.Name = "historyLabel";
            this.historyLabel.Size = new System.Drawing.Size(93, 13);
            this.historyLabel.TabIndex = 6;
            this.historyLabel.Text = "История попыток";

            // historyListBox
            this.historyListBox.FormattingEnabled = true;
            this.historyListBox.Location = new System.Drawing.Point(30, 200);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.Size = new System.Drawing.Size(220, 95);
            this.historyListBox.TabIndex = 7;

            // newGameButton
            this.newGameButton.Location = new System.Drawing.Point(30, 310);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(220, 30);
            this.newGameButton.TabIndex = 8;
            this.newGameButton.Text = "Новая игра";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.historyListBox);
            this.Controls.Add(this.historyLabel);
            this.Controls.Add(this.rangeLabel);
            this.Controls.Add(this.attemptsLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.guessTextBox);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Угадай число";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox guessTextBox;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label attemptsLabel;
        private System.Windows.Forms.Label rangeLabel;
        private System.Windows.Forms.Label historyLabel;
        private System.Windows.Forms.ListBox historyListBox;
        private System.Windows.Forms.Button newGameButton;
    }
}