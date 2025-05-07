using ScottPlot;
using Color = System.Drawing.Color;

namespace PlotExample
{
    public partial class Form1 : Form
    {
        private Color scatterColor = Color.Blue;
        private double x = 0, speed = 0.1;
        private List<double> xs = new();
        private List<double> ys = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private double getF(double x) => Math.Sin(x);

        private void timer_Tick(object sender, EventArgs e)
        {
            x += speed;
            xs.Add(x);
            ys.Add(getF(x));

            var plot = formsPlot.Plot;
            plot.Clear();

            var scatter = plot.Add.Scatter(xs, ys);

            scatter.Color = new ScottPlot.Color(scatterColor.R, scatterColor.G, scatterColor.B, scatterColor.A);
            scatter.MarkerStyle = MarkerStyle.None;
            // Автоматически приблизить к области графика
            plot.Axes.AutoScale();
            // Вызов метода перерисовки
            formsPlot.Refresh();
        }

        private void buttonSetColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
            {
                scatterColor = cd.Color;
            }
        }
    }
}
