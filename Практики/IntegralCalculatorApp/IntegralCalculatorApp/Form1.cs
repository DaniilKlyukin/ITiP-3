using System.Threading;

namespace IntegralCalculatorApp
{
    public partial class Form1 : Form
    {
        private Thread? _calculationThread;
        private bool _calculationRunning;
        private readonly object _lockObject = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (_calculationRunning)
            {
                MessageBox.Show("Вычисление уже выполняется", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            double a = (double)numLowerLimit.Value;
            double b = (double)numUpperLimit.Value;
            int segments = (int)numSegments.Value;

            if (b <= a)
            {
                MessageBox.Show("Верхний предел должен быть больше нижнего", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _calculationRunning = true;
            btnCalculate.Enabled = false;
            progressBar.Value = 0;
            lblResult.Text = "Вычисление...";

            _calculationThread = new Thread(() => CalculateIntegral(a, b, segments));
            _calculationThread.Start();
        }

        private void CalculateIntegral(double a, double b, int segments)
        {
            var gic = new GaussIntegralCalculator();

            gic.IterationSolved += (s, a) =>
            {
                int progress = (a.Iteration + 1) * 100 / segments;
                UpdateProgress(progress, a.Sum);
            };

            var result = gic.CalculateIntegral(x => x * x, a, b, segments);

            if (_calculationRunning)
            {
                UpdateResult(result);
                _calculationRunning = false;
            }
        }

        private void UpdateProgress(int progress, double currentValue)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateProgress(progress, currentValue)));
                return;
            }

            progressBar.Value = progress;
            lblResult.Text = $"Текущее значение: {currentValue:F16}";
        }

        private void UpdateResult(double result)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateResult(result)));
                return;
            }

            lblResult.Text = $"Результат: {result:F16}";
            btnCalculate.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _calculationRunning = false;
            _calculationThread?.Join();
        }
    }
}