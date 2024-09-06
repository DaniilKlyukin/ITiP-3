namespace InfinitySeriesSum
{
    public partial class Form1 : Form
    {
        CancellationTokenSource cts = new();

        public Form1()
        {
            InitializeComponent();
        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            var sum = await GetSeriesSumAsync(cts.Token);

            MessageBox.Show($"Ответ: {sum}");
            cts.Dispose();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }

        private async Task<decimal> GetSeriesSumAsync(CancellationToken cancellationToken)
        {
            return await Task.Run(() => GetSeriesSum(cancellationToken));
        }

        private decimal GetSeriesSum(CancellationToken cancellationToken)
        {
            var sum = 0.0M;
            for (int i = 1; ; i++)
            {
                if (cancellationToken.IsCancellationRequested)
                    break;

                sum += f(i);

                if (i % 100000 == 0)
                    Invoke(() => seriesSumTextBox.Text = sum.ToString());
            }
            return sum;
        }

        private decimal f(decimal x) => 1.0M / (x * x);
    }
}