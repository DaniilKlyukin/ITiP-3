using MathNet.Numerics.Interpolation;
using System.ComponentModel;

namespace PR3;

public partial class Form1 : Form
{
    private readonly BindingList<MeteoData> _meteoBinding = new();

    public Form1()
    {
        InitializeComponent();

        dataGridView1.DataSource = _meteoBinding;

        AddSampleDataToBinding();
    }

    private void AddSampleDataToBinding()
    {
        var data = new List<MeteoData>
        {
            new MeteoData
            {
                Height = 0,
                Pressure = 101330
            },
            new MeteoData
            {
                Height = 500,
                Pressure = 95464
            },
            new MeteoData
            {
                Height = 1000,
                Pressure = 89877
            },
            new MeteoData
            {
                Height = 1500,
                Pressure = 84559
            },
        };

        foreach (var item in data)
        {
            _meteoBinding.Add(item);
        }
    }

    private void buildPlotButton_Click(object sender, EventArgs e)
    {
        formsPlot1.Plot.Clear();

        var data = _meteoBinding.ToList();

        var interpolated = InterpolateMeteo(data, 5);

        var xs = interpolated.Select(x => x.Height).ToList();
        var ys = interpolated.Select(x => x.Pressure).ToList();

        var scatter = formsPlot1.Plot.Add.Scatter(xs, ys);

        formsPlot1.Plot.XLabel("Высота, м");
        formsPlot1.Plot.YLabel("Давление, Па");
        formsPlot1.Plot.Title("Метеоданные");

        // Убираем маркеры (точки) и оставляем линию
        scatter.MarkerStyle = ScottPlot.MarkerStyle.None;
        scatter.LegendText = "Давление"; // Подписии линии графика
        formsPlot1.Plot.ShowLegend();
        formsPlot1.Plot.Axes.AutoScale(); // Автоматически приближать к области графика
        formsPlot1.Refresh(); // Вызов метода перерисовки
    }

    private List<MeteoData> InterpolateMeteo(IList<MeteoData> meteo, int scale)
    {
        var xs = meteo.Select(x => x.Height).ToList();
        var ys = meteo.Select(x => x.Pressure).ToList();
        // Нужно скачать библиотеку MathNet.Numerics
        var spline = CubicSpline.InterpolateNatural(xs, ys);

        var interpolatedCount = scale * meteo.Count;

        var interpolatedStep = (xs.Last() - xs.First()) / (interpolatedCount - 1);

        var interpolated = new List<MeteoData>();

        var height0 = xs.First();

        for (int i = 0; i < interpolatedCount; i++)
        {
            var height = height0 + i * interpolatedStep;

            var pressure = spline.Interpolate(height);

            interpolated.Add(new MeteoData { Height = height, Pressure = pressure });
        }

        return interpolated;
    }
}
