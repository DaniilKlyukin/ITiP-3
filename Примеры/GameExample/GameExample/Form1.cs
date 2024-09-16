namespace GameExample
{
    public partial class Form1 : Form
    {
        private Map Map = new Map(20, 20);
        private MapViewer viewer = new MapViewer(40);

        public Form1()
        {
            InitializeComponent();

            Map[5, 5] = ObjectType.Player;
            Map[7, 8] = ObjectType.Enemy;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var bmp = viewer.Visualize(Map);
            pictureBox1.Image = bmp;
        }
    }
}
