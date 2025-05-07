using AirplaneGame;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var f = new GameForm();

            f.Controller.Start<MyPlayer>();

            f.Show();

        }
    }
}