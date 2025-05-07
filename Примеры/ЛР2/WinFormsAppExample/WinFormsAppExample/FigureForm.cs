namespace WinFormsAppExample
{
    // Класс для создания диалогового окна с параметрами фигу-ры
    public partial class FigureForm : Form
    {
        // Цвет фигуры
        private Color figureColor;

        // Свойство для доступа к цвету фигуры с обновлением цве-та на панели
        public Color FigureColor
        {
            get => figureColor;
            set
            {
                // Обновляем цвет на панели
                panelColor.BackColor = value;
                figureColor = value;
            }
        }

        // Свойства для формы, размеров и координат фигуры
        public FigureGeometryForm GeometryForm { get; private set; }
        public Size FigureSize { get; private set; }
        public Point FigurePoint { get; private set; }

        // Максимальные размеры фигуры
        private Size maxFigureSize;
        public Size MaxFigureSize
        {
            get => maxFigureSize;
            set
            {
                // Устанавливаем максимальные значения для размеров фигуры
                numericUpDownWidth.Maximum = value.Width;
                numericUpDownHeight.Maximum = value.Height;

                maxFigureSize = value;
            }
        }

        // Максимальные координаты фигуры
        private Point maxFigureCoordinate;
        public Point MaxFigureCoordinate
        {
            get => maxFigureCoordinate;
            set
            {
                // Устанавливаем максимальные значения для координат фигуры
                numericUpDownX.Maximum = value.X;
                numericUpDownY.Maximum = value.Y;

                maxFigureCoordinate = value;
            }
        }

        // Конструктор класса
        public FigureForm()
        {
            InitializeComponent();

            // Инициализация значений по умолчанию
            FigureColor = Color.Black;
            MaxFigureCoordinate = new Point(10_000, 10_000);
            MaxFigureSize = new Size(10_000, 10_000);
        }

        // Обработчик события нажатия кнопки выбора цвета
        private void buttonColor_Click(object sender, EventArgs e)
        {
            // Создаем диалог выбора цвета
            var cd = new ColorDialog();
            cd.Color = FigureColor;

            // Если цвет выбран, обновляем цвет фигуры и на панели
            if (cd.ShowDialog() == DialogResult.OK)
            {
                FigureColor = cd.Color;
                panelColor.BackColor = FigureColor;
            }
        }

        // Обработчик события нажатия кнопки "Принять"
        private void buttonAccept_Click(object sender, EventArgs e)
        {
            // Определяем выбранную форму фигуры
            GeometryForm = getFigureGeometryForm();

            // Получаем значения размеров и координат фигуры
            var width = (int)numericUpDownWidth.Value;
            var height = (int)numericUpDownHeight.Value;
            var x = (int)numericUpDownX.Value;
            var y = (int)numericUpDownY.Value;

            // Устанавливаем размеры и координаты фигуры
            FigureSize = new Size(width, height);
            FigurePoint = new Point(x, y);

            // Устанавливаем результат DialogResult.OK и закрываем окно
            DialogResult = DialogResult.OK;
            Close();
        }

        // Метод для определения выбранной формы фигуры
        private FigureGeometryForm getFigureGeometryForm()
        {
            // Проверяем, какая форма фигуры выбрана
            if (radioButtonRectangle.Checked)
                return FigureGeometryForm.Rectangle;
            else if (radioButtonEllipse.Checked)
                return FigureGeometryForm.Ellipse;

            // Если ни одна форма не выбрана, выбрасываем исключение
            throw new ArgumentException("Не выбрана форма фигуры");
        }
    }
}
