using System.Drawing;
using System.Drawing.Configuration;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace AirplaneGame
{
    public partial class GameForm : Form
    {
        private const int cellSize = 80;

        private int backgroundX = 0, backgroundSpeed = 2;
        private Image backgroundImage;

        public GameController Controller { get; }
        private List<PictureBox> gameObjectsPictureBoxes = new();
        private SoundPlayer soundPlayer = new SoundPlayer();

        public GameForm()
        {
            InitializeComponent();

            soundPlayer.Stream = Resource.doom_sound;
            soundPlayer.PlayLooping();

            DoubleBuffered = true;

            using var bmpImage = new Bitmap(Resource.background);
            backgroundImage = bmpImage.Clone(new Rectangle(0, 0, bmpImage.Width, bmpImage.Height), bmpImage.PixelFormat);

            Controller = new GameController(gamePictureBox.Height / cellSize, gamePictureBox.Width / cellSize);
            Controller.GameObjectsAdd += (p, go) =>
            {
                var pb = new PictureBox
                {
                    Size = new Size(cellSize, cellSize),
                    BackColor = Color.Transparent
                };

                gameObjectsPictureBoxes.Add(pb);
                gamePictureBox.Controls.Add(pb);
            };

            Controller.GameObjectsRemove += (p, t) =>
            {
                if (gameObjectsPictureBoxes.Count > 0)
                {
                    var pb = gameObjectsPictureBoxes.First();
                    gameObjectsPictureBoxes.Remove(pb);
                    gamePictureBox.Controls.Remove(pb);
                }
            };

            Controller.Updated += Draw;
            Controller.Updated += PrintScore;
        }

        private void backgroundTimer_Tick(object sender, EventArgs e)
        {
            gamePictureBox.Image?.Dispose();

            if (backgroundX >= backgroundImage.Width / 2)
                backgroundX = 0;

            var rect = new Rectangle(backgroundX, 0, gamePictureBox.Width, gamePictureBox.Height);

            using var bmp = new Bitmap(backgroundImage);
            gamePictureBox.Image = bmp.Clone(rect, bmp.PixelFormat);
            gamePictureBox.Invalidate();

            backgroundX += backgroundSpeed;
        }

        private void Draw()
        {
            foreach (var ((p, go), pb) in Controller.GetGameData().Zip(gameObjectsPictureBoxes))
            {
                switch (go)
                {
                    case GameObjectType.Player:
                        pb.Image = Resource.player;
                        break;
                    case GameObjectType.Enemy:
                        pb.Image = Resource.enemyAirplane;
                        break;
                    default:
                        break;
                }
                pb.Location = new System.Drawing.Point(cellSize * p.X, cellSize * p.Y);
            }
        }

        private void PrintScore()
        {
            var sb = new StringBuilder();

            sb.AppendLine("Таблица очков");

            foreach (var (name, score) in Controller.Scores)
            {
                sb.AppendLine($"{name}: {score}");
            }

            ScoreTextBox.Text = sb.ToString();
        }
    }
}