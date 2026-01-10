using System.Drawing;

namespace FractalLibrary;

/// <summary>
/// Класс для перевода сеточных значений ячеек в цвета
/// </summary>
public interface IPainter
{
    public Color[,] Paint(FractalRootsField fractal);
}
