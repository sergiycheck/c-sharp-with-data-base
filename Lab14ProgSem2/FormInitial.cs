using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Lab14ProgSem2
{
    public partial class FormInitial : Form
    {
        public FormInitial()
        {
            InitializeComponent();
        }
        Graphics gr;
        PointF[] points;
        int angle = 45;
        int radius = 50;
        int center;
        private void buttonRotate_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            center = pictureBox.Height / 2;
            Bitmap btmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            gr = Graphics.FromImage(btmp);
            gr.SmoothingMode = SmoothingMode.AntiAlias;
            Point point1 = new Point(LineCoord(angle, radius, center)[0], LineCoord(angle, radius, center)[1]);
            Point point2 = new Point(LineCoord(angle + 360, radius, center)[0], LineCoord(angle + 360, radius, center)[1]);
            Point point3 = new Point(LineCoord(angle + 720, radius, center)[0], LineCoord(angle + 720, radius, center)[1]);
            Point point4 = new Point(LineCoord(angle + 1080, radius, center)[0], LineCoord(angle + 1080, radius, center)[1]);
            points = new PointF[] { point1, point2, point3, point4 };
            gr.DrawClosedCurve(new Pen(Color.Black, 3), points);
            gr.DrawString("Moving Text", new Font(FontFamily.GenericSansSerif, 18), Brushes.Red, new Point(50, 200));
            pictureBox.Image = btmp;
        }
        private int[] LineCoord(int angleIn, int radius, int center)
        {
            int[] coord = new int[2]; // Setting up the int array for return
            angleIn %= 1440;
            angleIn *= 1;

            if (angleIn >= 0 && angleIn <= 720)
            {
                coord[0] = center + (int)(radius * Math.Sin(Math.PI * angleIn / 720));
                coord[1] = center - (int)(radius * Math.Cos(Math.PI * angleIn / 720));
            }
            else
            {
                coord[0] = center - (int)(radius * -Math.Sin(Math.PI * angleIn / 720));
                coord[1] = center - (int)(radius * Math.Cos(Math.PI * angleIn / 720));
            }
            return coord;
        }
        private void RotateTextBtn_Click(object sender, EventArgs e)
        {
            timerText.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            timerText.Enabled = false;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormLog formLogin = new FormLog();
            formLogin.ShowDialog();
            if (formLogin.IsPRESENTCODE())
            {
                buttonStop.Enabled = true;
                buttonRotate.Enabled = true;
                RotateTextBtn.Enabled = true;
            }

        }

        private void buttonGen_Click(object sender, EventArgs e)
        {
            FormGen formGen = new FormGen();
            formGen.ShowDialog();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Points
            Point point1 = new Point(LineCoord(angle, radius, center)[0], LineCoord(angle, radius, center)[1]);
            Point point2 = new Point(LineCoord(angle + 360, radius, center)[0], LineCoord(angle + 360, radius, center)[1]);
            Point point3 = new Point(LineCoord(angle + 720, radius, center)[0], LineCoord(angle + 720, radius, center)[1]);
            Point point4 = new Point(LineCoord(angle + 1080, radius, center)[0], LineCoord(angle + 1080, radius, center)[1]);
            points[0] = point1;
            points[1] = point2;
            points[2] = point3;
            points[3] = point4;
            if (angle == 1440)
            {
                angle = 0;
            }
            else
            {
                angle++;
            }
            string text = " ";
            float x = 0.1F;
            float y = 0.1F;
            for (int i = 0; i < points.Length; i++)
            {
                text = "Y: " + points[i].Y.ToString() + "\n" + "X: " + points[i].X.ToString() + "\n";
            }
            gr.TranslateTransform(x, 0);
            richTextBox.Text = text +
                "Width " + pictureBox.Width.ToString() + "\n" +
                "Height " + pictureBox.Height.ToString() + "\n";

            pictureBox.Refresh();
            pictureBox.BackColor = Color.LightCyan;
            gr.Clear(pictureBox.BackColor);
            gr.DrawClosedCurve(new Pen(Color.Black, 3), points);
            gr.FillClosedCurve(new SolidBrush(Color.Green), points);

        }

        private void timerText_Tick(object sender, EventArgs e)
        {
            pictureBox.Refresh();
            pictureBox.BackColor = Color.LightCyan;
            gr.Clear(pictureBox.BackColor);
            gr.TranslateTransform(0.1F, -0.10F);
            gr.RotateTransform(-0.4F);
            gr.DrawString("Moving Text", new Font(FontFamily.GenericSansSerif, 18), Brushes.Red, new Point(50, 200));
        }
    }
}
