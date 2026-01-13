using Avalonia;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using FractalLibrary;
using ReactiveUI;
using System;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FractalGUI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private int _iterationsLimit = 200;
        private double _tolerance = 0.01;
        private int _resolution = 800;
        private Bitmap? _fractalImage;
        private bool _isCalculating;
        private string _status = "Готов к расчету";

        public int IterationsLimit
        {
            get => _iterationsLimit;
            set => this.RaiseAndSetIfChanged(ref _iterationsLimit, value);
        }

        public double Tolerance
        {
            get => _tolerance;
            set => this.RaiseAndSetIfChanged(ref _tolerance, value);
        }

        public int Resolution
        {
            get => _resolution;
            set => this.RaiseAndSetIfChanged(ref _resolution, Math.Max(100, Math.Min(1000, value)));
        }

        public Bitmap? FractalImage
        {
            get => _fractalImage;
            private set => this.RaiseAndSetIfChanged(ref _fractalImage, value);
        }

        public bool IsCalculating
        {
            get => _isCalculating;
            private set => this.RaiseAndSetIfChanged(ref _isCalculating, value);
        }

        public string Status
        {
            get => _status;
            private set => this.RaiseAndSetIfChanged(ref _status, value);
        }

        public ICommand CalculateCommand { get; }

        public MainWindowViewModel()
        {
            CalculateCommand = ReactiveCommand.Create(
                CalculateFractal,
                this.WhenAnyValue(x => x.IsCalculating).Select(isCalculating => !isCalculating)
            );
        }

        private void CalculateFractal()
        {
            IsCalculating = true;
            Status = "Расчет фрактала...";

            try
            {
                var fractal = new Fractal(0, 0, 4, Resolution, Resolution)
                {
                    IterationsLimit = IterationsLimit,
                    Tolerance = Tolerance
                };

                var fractalData = fractal.Calculate();

                // Создаем изображение
                CreateImageFromAvaloniaColors(fractalData);

                Status = "Готово!";
            }
            catch (Exception ex)
            {
                Status = $"Ошибка: {ex.Message}";
            }
            finally
            {
                IsCalculating = false;
            }
        }

        private void CreateImageFromAvaloniaColors(FractalRootsField fractalData)
        {
            // Используем наш painter
            var painter = new SimplePainter();
            var colors = painter.Paint(fractalData);

            // Создаем WriteableBitmap
            var bitmap = new WriteableBitmap(
                new PixelSize(Resolution, Resolution),
                new Vector(96, 96),
                PixelFormat.Bgra8888,
                AlphaFormat.Premul
            );

            // Подготавливаем массив пикселей
            var pixelArray = new byte[Resolution * Resolution * 4];

            int index = 0;
            for (int y = 0; y < Resolution; y++)
            {
                for (int x = 0; x < Resolution; x++)
                {
                    var color = colors[y, x];

                    // BGRA порядок для PixelFormat.Bgra8888
                    pixelArray[index] = color.B;     // Blue
                    pixelArray[index + 1] = color.G; // Green
                    pixelArray[index + 2] = color.R; // Red
                    pixelArray[index + 3] = color.A; // Alpha

                    index += 4;
                }
            }

            // Копируем в bitmap (безопасно!)
            using (var buffer = bitmap.Lock())
            {
                System.Runtime.InteropServices.Marshal.Copy(
                    pixelArray, 0, buffer.Address, pixelArray.Length);
            }

            FractalImage = bitmap;
        }
    }
}