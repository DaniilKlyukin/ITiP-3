using System.Drawing;
using System.Windows.Forms;
using WinFormsApp2.ColorPatterns;

namespace WinFormsApp2
{

    public partial class MainForm : Form
    {
        public PropertiesForm propertiesForm { get; set; } = new();

        public Properties Properties => propertiesForm.Properties;

        private int mouseClickX;
        private int mouseClickY;

        private Size FormSize;
        private bool IsCalculate = false;

        private ColorPattern colorPattern = new GrayScalePattern();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            FormSize = Size;
            DrawAsync();
        }

        private async void DrawAsync()
        {
            statusLabel.Text = "Считаю...";
            await Task.Run(Draw);
            statusLabel.Text = "Готово!";
        }

        private void Draw()
        {
            if (IsCalculate)
                return;

            IsCalculate = true;
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);

            var bitmap = (Bitmap)pictureBox.Image;

            var iterations = new int[bitmap.Width, bitmap.Height];

            var rowsDone = 0;
            var lastPcnt = 0.0;

            Parallel.For(
                0,
                iterations.GetLength(0),
            x =>
            {
                for (var y = 0; y < iterations.GetLength(1); y++)
                {
                    var XRelative = LineInterpolate(
                        x,
                        0,
                        Properties.Left,
                        iterations.GetLength(0) - 1,
                        Properties.Right);

                    var YRelative = LineInterpolate(
                        y,
                        0,
                        Properties.Top,
                        iterations.GetLength(1) - 1,
                        Properties.Bottom);

                    iterations[x, y] = GetIterationsCount(
                        new Complex(0, 0),
                        new Complex(XRelative, YRelative),
                        propertiesForm.Properties.MaxRadius,
                        propertiesForm.Properties.MaxIterations);
                }

                rowsDone++;

                var pcnt = 100.0 * rowsDone / (iterations.GetLength(0) - 1);

                if (Math.Abs(lastPcnt - pcnt) > 5)
                {
                    lastPcnt = pcnt;

                    Invoke(() =>
                    {
                        progressBar.Value = (int)(lastPcnt);
                    });
                }
            });

            var min = iterations.Min();
            var max = iterations.Max();

            for (var x = 0; x < bitmap.Width; x++)
            {
                for (var y = 0; y < bitmap.Height; y++)
                {
                    bitmap.SetPixel(x, y, colorPattern.GetColor(
                            iterations[x, y], 0, Properties.MaxIterations));
                }
            }

            Invoke(pictureBox.Refresh);
            IsCalculate = false;

            Invoke(() =>
            {
                progressBar.Value = 100;
            });
        }

        private void DrawSimple()
        {
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);

            var bitmap = (Bitmap)pictureBox.Image;

            var iterations = new int[bitmap.Width, bitmap.Height];

            var lastPcnt = 0.0;

            for (var x = 0; x < iterations.GetLength(0); x++)
            {
                for (var y = 0; y < iterations.GetLength(1); y++)
                {
                    var XRelative = LineInterpolate(
                        x,
                        0,
                        Properties.Left,
                        iterations.GetLength(0) - 1,
                        Properties.Right);

                    var YRelative = LineInterpolate(
                        y,
                        0,
                        Properties.Top,
                        iterations.GetLength(1) - 1,
                        Properties.Bottom);

                    iterations[x, y] = GetIterationsCount(
                        new Complex(0, 0),
                        new Complex(XRelative, YRelative),
                        propertiesForm.Properties.MaxRadius,
                        propertiesForm.Properties.MaxIterations);
                }

                var pcnt = 100.0 * x / (iterations.GetLength(0) - 1);

                if (Math.Abs(lastPcnt - pcnt) > 5)
                {
                    lastPcnt = pcnt;

                    Invoke(() =>
                    {
                        progressBar.Value = (int)lastPcnt;
                    });
                }
            }

            var min = iterations.Min();
            var max = iterations.Max();

            for (var x = 0; x < bitmap.Width; x++)
            {
                for (var y = 0; y < bitmap.Height; y++)
                {
                    var colorValue = 255 * (1 - (iterations[x, y] - min) / (max - min));

                    bitmap.SetPixel(x, y, Color.FromArgb(colorValue, colorValue, colorValue));
                }
            }

            pictureBox.Refresh();

            progressBar.Value = 100;
        }

        private int GetIterationsCount(Complex z, Complex c, double rmax, int iterationsMax)
        {
            int iterations = 0;

            while (z.Magnitude <= rmax && iterations < iterationsMax)
            {
                z = GetF(z, c);
                iterations++;
            }

            return iterations;
        }

        private Complex GetF(Complex z, Complex c)
        {
            return z * z + c;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    {
                        mouseClickX = e.X;
                        mouseClickY = e.Y;
                    }
                    break;
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {

            switch (e.Button)
            {
                case MouseButtons.Left:
                    {
                        var left = Math.Max(0, Math.Min(mouseClickX, e.X));
                        var right = Math.Min(pictureBox.Width - 1, Math.Max(mouseClickX, e.X));

                        var bottom = Math.Min(pictureBox.Height - 1, Math.Max(mouseClickY, e.Y));
                        var top = Math.Max(0, Math.Min(mouseClickY, e.Y));

                        UpdateRelativeBorder(left, right, bottom, top);

                        DrawAsync();
                    }
                    break;

                case MouseButtons.Middle:
                    {
                        Properties.Left = -1;
                        Properties.Right = 1;
                        Properties.Bottom = 1;
                        Properties.Top = -1;

                        DrawAsync();
                    }
                    break;
            }
        }

        private void UpdateRelativeBorder(int left, int right, int bottom, int top)
        {
            var leftRelative = LineInterpolate(left, 0, this.Properties.Left, pictureBox.Width - 1, this.Properties.Right);
            var rightRelative = LineInterpolate(right, 0, this.Properties.Left, pictureBox.Width - 1, this.Properties.Right);

            var bottomRelative = LineInterpolate(bottom, 0, this.Properties.Top, pictureBox.Height - 1, this.Properties.Bottom);
            var topRelative = LineInterpolate(top, 0, this.Properties.Top, pictureBox.Height - 1, this.Properties.Bottom);

            var width = rightRelative - leftRelative;
            var height = topRelative - bottomRelative;

            var d0 = (double)(pictureBox.Width - 1) / (pictureBox.Height - 1);
            var d1 = width / height;

            if (d1 > d0)
            {
                this.Properties.Left = leftRelative;
                this.Properties.Right = rightRelative;

                this.Properties.Bottom = (bottomRelative + topRelative) / 2 - width / (2 * d0);
                this.Properties.Top = (bottomRelative + topRelative) / 2 + width / (2 * d0);
            }
            else if (d1 < d0)
            {
                this.Properties.Left = (leftRelative + rightRelative) / 2 - height * d0 / 2;
                this.Properties.Right = (leftRelative + rightRelative) / 2 + height * d0 / 2;

                this.Properties.Bottom = bottomRelative;
                this.Properties.Top = topRelative;
            }
        }

        private double LineInterpolate(double x, double x0, double y0, double x1, double y1)
        {
            return y0 + (x - x0) * (y1 - y0) / (x1 - x0);
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            if (FormSize.Width != Size.Width || FormSize.Height != Height)
                DrawAsync();

            FormSize = Size;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            propertiesForm.ShowDialog();

            switch (propertiesForm.Properties.ColorPatternType)
            {
                case ColorPatternType.GrayScale:
                    {
                        colorPattern = new GrayScalePattern();
                    }
                    break;
                case ColorPatternType.HeatMap:
                    {
                        colorPattern = new HeatMapPattern();
                    }
                    break;
                case ColorPatternType.ReverseHeatMap:
                    {
                        colorPattern = new ReverseHeatMapPattern();
                    }
                    break;
                case ColorPatternType.ColorList:
                    {
                        colorPattern = new ColorListPattern(propertiesForm.Properties.Colors);
                    }
                    break;
                case ColorPatternType.RandomCategory:
                    {
                        colorPattern = new RandomCategoryPattern();
                    }
                    break;
            }

            DrawAsync();

        }
    }
}