namespace GuessNumberGame
{
    public partial class MainForm : Form
    {
        private readonly GameLogic _game;
        private readonly Color _defaultBackColor;

        public MainForm()
        {
            InitializeComponent();
            _game = new GameLogic();
            _defaultBackColor = guessTextBox.BackColor;
            UpdateStats();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(guessTextBox.Text, out int guess))
            {
                MessageBox.Show("����������, ������� ����� �����!", "������",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var result = _game.MakeGuess(guess);
                guessTextBox.BackColor = _defaultBackColor;

                switch (result)
                {
                    case GuessResult.Correct:
                        MessageBox.Show($"�����������! �� ������� ����� �� {_game.Attempts} �������!",
                            "������!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _game.ResetGame();
                        break;
                    case GuessResult.TooLow:
                        statusLabel.Text = "���������� ����� ������!";
                        break;
                    case GuessResult.TooHigh:
                        statusLabel.Text = "���������� ����� ������!";
                        break;
                }

                UpdateStats();
                guessTextBox.SelectAll();
                guessTextBox.Focus();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                guessTextBox.BackColor = Color.LightPink;
                statusLabel.Text = ex.Message;
            }
        }

        private void UpdateStats()
        {
            attemptsLabel.Text = $"�������: {_game.Attempts}";
            rangeLabel.Text = $"��������: {_game.MinValue}-{_game.MaxValue}";
            historyListBox.DataSource = null;
            historyListBox.DataSource = _game.GuessHistory;
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            _game.ResetGame();
            statusLabel.Text = "������� ����� � ������� �������";
            UpdateStats();
            guessTextBox.Text = "";
            guessTextBox.Focus();
        }

        private void guessTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                guessButton.PerformClick();
                e.Handled = true;
            }
        }
    }
}