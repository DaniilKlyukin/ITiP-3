namespace WinFormsAppExample
{
    public partial class MainForm : Form
    {
        // ������� ��������� ����� ��� ����� ������ ��� ���������.
        // ����� ���� ������������� ������ ������ ��� ������� �� ������.
        // �� ������ �������� �����: ������ _figureForm ����������� ������ MainForm (���� ������)
        // � �� �� ����������� �� ������ ���� MainForm �� ����� ���������, �������������,
        // ��� ��������� ������ ShowDialog � ����� ���������� ����� ��������� ��������.
        private FigureForm _figureForm = new FigureForm();

        // ������� ����������� ������ ��� ���������
        // ����� Graphics ������������� ������ ��������� �� ���������� ����������� (������ ������� � ����������� ��������, ������).
        private Graphics _graphics; 

        public MainForm()
        {
            InitializeComponent();

            // �������, ��� �������� ����� �� �����������
            // ��������� �� ����������� ����� �������, ������ �������� ����� �� ����� ������� ���� Control
            _graphics = pictureBox.CreateGraphics();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // ��������� ���������
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            // �������� � _figureForm ������������ �������� ��������� ��� �����.
            // ��� �������, ����� ������������ �� ��� ������ ������������ ���������
            // ������ ������ �� ����� ���� ������ ������� ������� ��� ���������
            // ���������� ������ �������� ���� �� ����� ���� �� ��������
            _figureForm.MaxFigureCoordinate = new Point(pictureBox.Size.Width - 1, pictureBox.Size.Height - 1);
            _figureForm.MaxFigureSize = new Size(pictureBox.Size.Width, pictureBox.Size.Height);
            
            _figureForm.ShowDialog(); // ���������� ���� �����, ��� �������� ���� ������ ����� �� ������������, ������ ����������� ���� ����

            var brush = new SolidBrush(_figureForm.FigureColor); // ����� ��� ���������

            // �� ������ ������, ��������� � _figureForm ������ ������
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
            _graphics.Clear(Color.White); // ������� ����
        }
    }
}
