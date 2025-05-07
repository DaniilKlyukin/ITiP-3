namespace WinFormsAppExample
{
    public partial class MainForm : Form
    {
        // Создаем экземпляр формы для ввода данных для рисования.
        // Можно было пересоздавать данный объект при нажатии на кнопку.
        // Из плюсов создания здесь: объект _figureForm принадлежит классу MainForm (поле класса)
        // и он не уничтожится из памяти пока MainForm не будет уничтожен, следовательно,
        // при повторном вызове ShowDialog в форме сохранятся ранее введенные значения.
        private FigureForm _figureForm = new FigureForm();

        // Создаем специальный объект для рисования
        // Класс Graphics предоставляет методы рисования на устройстве отображения (другие термины — графический контекст, «холст»).
        private Graphics _graphics; 

        public MainForm()
        {
            InitializeComponent();

            // Говорим, что рисовать будем на пикчербоксе
            // Рисование на пикчербоксе самое быстрое, однако рисовать можно на любом объекте типа Control
            _graphics = pictureBox.CreateGraphics();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Закрываем программу
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            // Передаем в _figureForm максимальные возможны параметры для ввода.
            // Это сделано, чтобы пользователь не мог ввести недопустимые параметры
            // Размер фигуры не может быть больше размера полотна для рисования
            // Координата левого верхнего угла не может быть за полотном
            _figureForm.MaxFigureCoordinate = new Point(pictureBox.Size.Width - 1, pictureBox.Size.Height - 1);
            _figureForm.MaxFigureSize = new Size(pictureBox.Size.Width, pictureBox.Size.Height);
            
            _figureForm.ShowDialog(); // Отображаем окно формы, при закрытии окна объект формы НЕ уничтожается, просто закрывается само окно

            var brush = new SolidBrush(_figureForm.FigureColor); // Кисть для рисования

            // На основе данных, введенных в _figureForm рисуем фигуру
            switch (_figureForm.GeometryForm)
            {
                case FigureGeometryForm.Rectangle:
                    _graphics.FillRectangle(brush, new Rectangle(_figureForm.FigurePoint, _figureForm.FigureSize));
                    break;
                case FigureGeometryForm.Ellipse:
                    _graphics.FillEllipse(brush, new Rectangle(_figureForm.FigurePoint, _figureForm.FigureSize));
                    break;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            _graphics.Clear(Color.White); // Очищаем окно
        }
    }
}
