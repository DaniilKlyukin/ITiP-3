using Microsoft.VisualBasic.Devices;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace PictureBoxExample
{
    public partial class Form1 : Form
    {
        private Color color = Color.Red;
        private Point rectPoint = new Point(100, 100);
        private int width = 100, height = 50;
        private int speedX = 5, speedY = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            var brush = new SolidBrush(color);
            var cx = rectPoint.X - width / 2;
            var cy = rectPoint.Y - height / 2;
            e.Graphics.FillRectangle(
               brush, cx, cy, width, height);
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void buttonColorDialog_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
                color = cd.Color;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            rectPoint.X += speedX;
            rectPoint.Y += speedY;

            if (rectPoint.X <= 0 || rectPoint.X >= pictureBox.Width)
                speedX *= -1;

            if (rectPoint.Y <= 0 || rectPoint.Y >= pictureBox.Height)
                speedY *= -1;

            // Для вызова отрисовки
            pictureBox.Refresh();
        }


        /*
         
                     // Для рисования необходимо создать кисть Pen.
            var pen = new Pen(Color.Red, 2);
            int width = 100, height = 100;
            var cx = (pictureBox.Width - width) / 2;
            var cy = (pictureBox.Height - height) / 2;
            e.Graphics.DrawEllipse(pen, cx, cy, width, height);
         
         */
    }
}
