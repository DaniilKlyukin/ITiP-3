using System.Drawing;

namespace FractalLibrary;

/// <summary>
/// Класс для перевода сеточных значений ячеек в цвета
/// </summary>
public class SimplePainter : IPainter
{
    private static readonly Color[] _colorPalette = new[]
    {
            Color.Red,
            Color.Blue,
            Color.Green,
            Color.Yellow,
            Color.Purple,
            Color.Orange,
            Color.Cyan,
            Color.Magenta,
            Color.Lime,
            Color.Teal,
            Color.Indigo,
            Color.Violet,
            Color.Gold,
            Color.Silver,
            Color.DarkRed,
            Color.DarkBlue,
            Color.DarkGreen,
            Color.DarkOrange
    };

    public Color[,] Paint(FractalRootsField fractal)
    {
        var iterMin = fractal.Field.Cast<RootInField>().Where(r => r.RootId != -1).MinBy(r => r.RootResult.Iterations).RootResult.Iterations;
        var iterMax = fractal.Field.Cast<RootInField>().Where(r => r.RootId != -1).MaxBy(r => r.RootResult.Iterations).RootResult.Iterations;

        var rows = fractal.Field.GetLength(0);
        var columns = fractal.Field.GetLength(1);

        var colors = new Color[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                var pixelColor = fractal.Field[i, j].RootId == -1
                    ? Color.Black
                    : _colorPalette[fractal.Field[i, j].RootId];

                var norm = (double)(fractal.Field[i, j].RootResult.Iterations - iterMin) / (iterMax - iterMin);

                var a = (int)Math.Clamp(Math.Round(255 * norm), 0, 255);

                colors[i, j] = Color.FromArgb(a, pixelColor.R, pixelColor.G, pixelColor.B);
            }
        }

        return colors;
    }
}