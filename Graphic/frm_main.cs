using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace Graphic
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        HatchBrush hBrush = new HatchBrush(HatchStyle.Wave, Color.White, Color.Gray);
        Brush whiteBrush = Brushes.LightSkyBlue;
        GraphicsPath cat = new GraphicsPath();
        int ClickedX = 0;
        int ClickedY = 0;
        int lastX = 0;
        int lastY = 0;
        int[] xabr = { 5, 10, 20, 30, 35, 55, 60, 70, 75, 205, 210, 220, 230, 235, 505, 510, 520, 530, 535, 805, 810, 820, 830, 835, 1005, 1010, 1020, 1030, 1035 };
        int[] xCat = { 5, 55, 90, 110, 140, 160, 170, 180, 187, 190, 200, 207, 210, 215, 220 };
        int[] yCat = { 470, 510, 520, 523, 550, 560, 580, 595, 630 };
        Pen penb = new Pen(Color.Black, 3);
        Matrix m = new Matrix();
        private void drawcat()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            //g.FillRectangle(Brushes.LightSkyBlue, 0, 0, 1500, 250);
            // g.FillRectangle(Brushes.GreenYellow, 0, 250, 1500, 900);
            // sare gorbe
            cat.AddEllipse(xCat[6], yCat[1], 60, 60);
            //badane gorbe
            cat.AddEllipse(xCat[1], yCat[4], 150, 80);
            // dasto pash
            cat.AddRectangles(new Rectangle[] { new Rectangle(xCat[2], yCat[8], 10, 47), new Rectangle(xCat[3], yCat[8], 10, 47), new Rectangle(xCat[4], yCat[8], 10, 47), new Rectangle(xCat[5], yCat[8], 10, 47) });
            //dome gorbe
            cat.AddPolygon(new Point[] { new Point(xCat[1], yCat[6]), new Point(xCat[1], yCat[7]), new Point(xCat[0], yCat[4]) });
            //gooshaye gorbe
            cat.AddPolygon(new Point[] { new Point(xCat[10], yCat[2]), new Point(xCat[14], yCat[2]), new Point(xCat[12], yCat[0]) });
            cat.AddPolygon(new Point[] { new Point(xCat[7], yCat[2]), new Point(xCat[10], yCat[2]), new Point(xCat[9], yCat[0]) });
            //cheshe gorbe
            cat.AddEllipse(xCat[11], yCat[3], 10, 10);
            cat.AddEllipse(xCat[8], yCat[3], 10, 10);
            //dahane gorbe
            cat.AddPolygon(new Point[] { new Point(xCat[9], yCat[4]), new Point(xCat[13], yCat[4]), new Point(xCat[10], yCat[5]) });
            g.DrawPath(Pens.Black, cat);
            g.FillPath(hBrush, cat);

            pictureBox1.BackgroundImage = bmp;

        }

        public static Cursor CursorFromBitmap(Bitmap bmp)
        {
            var hicon = bmp.GetHicon();
            var cursor = new Cursor(hicon);
            var fi = typeof(Cursor).GetField("ownHandle", BindingFlags.NonPublic | BindingFlags.Instance);
            fi.SetValue(cursor, true);
         
            return cursor;
        }

        private void CatMove(int dx, int dy)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Matrix m4 = new Matrix();

            m4.Translate(dx, dy);
            cat.Transform(m4);
            for (int i = 0; i < xCat.Length; i++)
            {
                xCat[i] += dx;
            }
            for (int i = 0; i < yCat.Length; i++)
            {
                yCat[i] += dy;
            }
            g.DrawPath(Pens.Black, cat);
            g.FillPath(hBrush, cat);
            pictureBox1.BackgroundImage = bmp;
        }

        private void CatMove(int dx, int dy, int delay)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Matrix m4 = new Matrix();

            m4.Translate(dx, dy);
            cat.Transform(m4);
            for (int i = 0; i < xCat.Length; i++)
            {
                xCat[i] += dx;
            }
            for (int i = 0; i < yCat.Length; i++)
            {
                yCat[i] += dy;
            }
            System.Threading.Thread.Sleep(delay);
            g.DrawPath(Pens.Black, cat);
            g.FillPath(hBrush, cat);
            pictureBox1.BackgroundImage = bmp;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                frm_MainMenu mm = new frm_MainMenu();
                mm.ShowDialog();
            }
            if (e.KeyData == Keys.Right)
                CatMove(30, 0);
            if (e.KeyData == Keys.Left)
                CatMove(-30, 0);
            if (e.KeyData == Keys.Up)
                CatMove(0, -30);
            if (e.KeyData == Keys.Down)
                CatMove(0, 30);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Pen penb = new Pen(Color.Black, 3);
            //pare
            GraphicsPath gpare = new GraphicsPath();
            gpare.AddPolygon(new Point[] { new Point(1175, 500), new Point(1250, 485), new Point(1250, 515) });
            gpare.AddPolygon(new Point[] { new Point(1175, 500), new Point(1100, 485), new Point(1100, 515) });
            gpare.AddPolygon(new Point[] { new Point(1175, 500), new Point(1160, 425), new Point(1190, 425) });
            gpare.AddPolygon(new Point[] { new Point(1175, 500), new Point(1160, 575), new Point(1190, 575) });

            m.RotateAt(4, new PointF(1175, 500));
            gpare.Transform(m);

            g.DrawPath(penb, gpare);
            g.FillPath(Brushes.Brown, gpare);
            g.FillEllipse(whiteBrush, xabr[0], 10, 50, 30);
            g.FillEllipse(whiteBrush, xabr[1], 5, 50, 30);
            g.FillEllipse(whiteBrush, xabr[1], 20, 50, 30);
            g.FillEllipse(whiteBrush, xabr[2], 20, 50, 30);
            g.FillEllipse(whiteBrush, xabr[3], 5, 50, 30);
            g.FillEllipse(whiteBrush, xabr[3], 30, 50, 30);
            g.FillEllipse(whiteBrush, xabr[4], 25, 50, 30);
            g.FillEllipse(whiteBrush, xabr[5], 10, 50, 30);
            g.FillEllipse(whiteBrush, xabr[6], 5, 50, 30);
            g.FillEllipse(whiteBrush, xabr[6], 20, 50, 30);
            g.FillEllipse(whiteBrush, xabr[7], 20, 50, 30);
            g.FillEllipse(whiteBrush, xabr[7], 5, 50, 30);
            g.FillEllipse(whiteBrush, xabr[7], 30, 50, 30);
            g.FillEllipse(whiteBrush, xabr[8], 25, 50, 30);
            //abr2
            g.FillEllipse(whiteBrush, xabr[9], 10, 150, 60);
            g.FillEllipse(whiteBrush, xabr[10], 5, 150, 60);
            g.FillEllipse(whiteBrush, xabr[10], 20, 150, 60);
            g.FillEllipse(whiteBrush, xabr[11], 20, 150, 60);
            g.FillEllipse(whiteBrush, xabr[12], 5, 150, 60);
            g.FillEllipse(whiteBrush, xabr[12], 30, 150, 60);
            g.FillEllipse(whiteBrush, xabr[13], 15, 150, 60);
            //abr3

            g.FillEllipse(whiteBrush, xabr[14], 40, 80, 40);
            g.FillEllipse(whiteBrush, xabr[15], 45, 80, 40);
            g.FillEllipse(whiteBrush, xabr[15], 20, 80, 40);
            g.FillEllipse(whiteBrush, xabr[16], 20, 80, 40);
            g.FillEllipse(whiteBrush, xabr[17], 45, 80, 40);
            g.FillEllipse(whiteBrush, xabr[17], 30, 80, 40);
            g.FillEllipse(whiteBrush, xabr[18], 65, 80, 40);

            //abr4
            g.FillEllipse(whiteBrush, xabr[19], 30, 50, 30);
            g.FillEllipse(whiteBrush, xabr[20], 35, 50, 30);
            g.FillEllipse(whiteBrush, xabr[20], 50, 50, 30);
            g.FillEllipse(whiteBrush, xabr[21], 50, 50, 30);
            g.FillEllipse(whiteBrush, xabr[22], 35, 50, 30);
            g.FillEllipse(whiteBrush, xabr[22], 60, 50, 30);
            g.FillEllipse(whiteBrush, xabr[23], 55, 50, 30);
            //abr 5
            g.FillEllipse(whiteBrush, xabr[24], 10, 150, 60);
            g.FillEllipse(whiteBrush, xabr[25], 5, 150, 60);
            g.FillEllipse(whiteBrush, xabr[25], 20, 150, 60);
            g.FillEllipse(whiteBrush, xabr[26], 20, 150, 60);
            g.FillEllipse(whiteBrush, xabr[27], 5, 150, 60);
            g.FillEllipse(whiteBrush, xabr[27], 30, 150, 60);
            g.FillEllipse(whiteBrush, xabr[28], 25, 150, 60);

            g.SmoothingMode = SmoothingMode.AntiAlias;

            //badane aasiab
            GraphicsPath gbody = new GraphicsPath();
            gbody.AddPolygon(new Point[] { new Point(1175, 510), new Point(1145, 705), new Point(1205, 705) });

            HatchBrush bodyBrush = new HatchBrush(HatchStyle.HorizontalBrick, Color.White, Color.Brown);

            g.DrawPath(penb, gbody);
            g.FillPath(bodyBrush, gbody);
            gbody.Dispose();

            //khorshid
            g.FillEllipse(Brushes.Yellow, 1250, 25, 100, 100);

            //Chaman
            g.DrawLine(Pens.SpringGreen, 0, 677, 1368, 677);
            g.FillRectangle(Brushes.GreenYellow, 0, 677, 1368, 677);


            pictureBox1.Image = bmp;

            g.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.IsStarted = true;
            this.Cursor = CursorFromBitmap(Properties.Resources.mouse_hand);
            drawcat();
            timer1.Enabled = true;
        }
        int delay = 0;
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            ClickedX = e.X;
            ClickedY = e.Y;
            lastX = ClickedX - xCat[5];
            lastY = ClickedY - yCat[5];
            CatMove(lastX, lastY, delay);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frm_main_Activated(object sender, EventArgs e)
        {
            if (Program.AsiabSpeed >= 5)
            {
                timer1.Interval = (Program.AsiabSpeed + 1) * 10;
            }
            if (Program.AsiabSpeed < 5)
            {
                timer1.Interval = (Program.AsiabSpeed + 1) * 20;
            }
        }

        private void frm_main_Enter(object sender, EventArgs e)
        {
            if (Program.AsiabSpeed >= 5)
            {
                timer1.Interval = (Program.AsiabSpeed + 1) * 10;
            }
            if (Program.AsiabSpeed < 5)
            {
                timer1.Interval = (Program.AsiabSpeed + 1) * 20;
            }
        }
    }
}
