namespace AsyncIntegralCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private decimal f(decimal x) => x * x;

        private async void calcButton_Click(object sender, EventArgs e)
        {
            var a = numericUpDown1.Value;
            var b = numericUpDown2.Value;
            var N = (long)numericUpDown3.Value;

            var task = IntegrateAsync(a, b, N, UpdateProgress);

            var integral = await task;

            MessageBox.Show($"Интеграл равен {integral:0.000}", "Ответ");
        }

        private void UpdateProgress(decimal pcnt)
        {
            if (Math.Abs(pcnt - progressBar.Value) >= 1)
                Invoke(() => progressBar.Value = (int)pcnt);
        }

        private Task<decimal> IntegrateAsync(decimal a, decimal b,
            long N, Observer? observer = null)
        {
            var tcs = new TaskCompletionSource<decimal>();

            var integralTask = Task.Run(() =>
            {
                var integral = Integrate(a, b, N, observer);
                tcs.SetResult(integral);
            });

            return tcs.Task;
        }

        private decimal Integrate(
            decimal a, decimal b,
            long N, Observer? observer = null)
        {
            var h = (b - a) / N;
            var sum = 0.0M;

            for (long i = 0; i < N; i++)
            {
                var x = a + i * h;
                sum += (f(x) + f(x + h)) * h / 2;
                observer?.Invoke((decimal)i * 100 / (N - 1));
            }

            return sum;
        }
    }

    public delegate void Observer(decimal pcnt);
}