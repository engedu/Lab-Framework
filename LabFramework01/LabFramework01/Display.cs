using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace LabFramework01
{
    public partial class Display : UserControl
    {
        private int xAxisPartNum;
        private int yAxisPartNum;
        private int xLongDashInterval;
        private int yLongDashInterval;
        private int xDivSeparatorLength;
        private int xDivLargeSeparatorLength;
        private int yDivSeparatorLength;
        private int yDivLargeSeparatorLength;

        internal void StopTimer()
        {
            timer1.Enabled = false;
        }

        internal void StartTimer()
        {
            timer1.Enabled = true;
        }

        //private double[] drawData = new double[Channel.NumSample];
        //private int current_number;
        Graphics g;

        public Image OriginalImage = null;

        public Display()
        {
            InitializeComponent();

            xAxisPartNum = 5;
            yAxisPartNum = 4;
            xLongDashInterval = 5;
            yLongDashInterval = 5;
            xDivSeparatorLength = 4;
            xDivLargeSeparatorLength = 8;
            yDivSeparatorLength = 4;
            yDivLargeSeparatorLength = 8;
            //channel1.DataSet += channel1DataSet;
            //channel1.DataDrawAllow += channel1DrawDataAllow;
            //current_number = 0;

        }

        internal void CopyImageToClipboard()
        {
            // create a memory image with the size taken from the picturebox dimensions
            RectangleF client = new RectangleF(
                0, 0, pictureBox1.Width, pictureBox1.Height);
            Image img = new Bitmap((int)client.Width, (int)client.Height);
            // create a graphics target from image and draw on the image
            Graphics g = Graphics.FromImage(img);
            RenderGraphics(g, client);
            // copy image to clipboard.
            Clipboard.SetImage(img);

        }
        private void RenderGraphics(Graphics g, RectangleF client)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.White);
            drawSolidXAxis(g, Color.Gray);
            drawDotXAxis(g, Color.Gray);
            drawSolidYAxis(g, Color.Gray);
            drawDotYAxis(g, Color.Gray);
            drawBorder(g, Color.Black);
            updateGraph(g);
        }

        private void drawBorder(Graphics g, Color penColor)
        {
            var pen = new Pen(penColor, 2.0f);
            g.DrawRectangle(pen, 0, 0, Width, Height);
        }

        private void DisplayPaint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            DrawAxis(e.Graphics);
            updateGraph(e.Graphics);
        }

        private void updateGraph(Graphics graphics)
        {
            const int numPoints = 360 * 3;
            var pen1 = new Pen(Color.Blue, 2.0f);
            var pen2 = new Pen(Color.Red, 2.0f);
            var points1 = new Point[numPoints];
            var points2 = new Point[numPoints];

            Random rnd = new Random();
            for (int i = 0; i < numPoints; i++)
            {
                int noise = rnd.Next(-2, 2);
                points1[i].X = i;  //時間軸との関連付け
                points1[i].Y = Convert.ToInt32(Math.Sin(2.5 * Math.PI / 180f * i) * 100) + Height / 2 + noise;

                points2[i].X = i;  //時間軸との関連付け
                points2[i].Y = Convert.ToInt32(-Math.Sin(2 * Math.PI / 180f * i) * 100) + Height / 2 + noise;
                points2[i].Y = points1[i].Y > Height / 2 ? Height / 2 + 100 : Height / 2-100;

            }

            graphics.DrawLines(pen1, points1);
            graphics.DrawLines(pen2, points2);

        }

        private void DrawAxis(Graphics graphics)
        {
            drawSolidXAxis(graphics, Color.Wheat);
            drawDotXAxis(graphics, Color.Wheat);
            drawSolidYAxis(graphics, Color.Wheat);
            drawDotYAxis(graphics, Color.Wheat);
        }


        private void drawSolidXAxis(Graphics g)
        {
        }

        private void drawDotYAxis(Graphics graphics, Color penColor)
        {
            int x1, y1, x2, y2;
            y1 = 0;
            y2 = Height;
            var pen = new Pen(penColor);
            pen.DashPattern = new float[] { 1.0f, 7.0f };
            for (int i = 1; i < 2 * xAxisPartNum; ++i)
            {
                x1 = x2 = i * Width / (2 * xAxisPartNum);
                graphics.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));
            }
        }

        private void drawSolidYAxis(Graphics graphics, Color penColor)
        {
            int x1, y1, x2, y2;
            y1 = 0;
            y2 = Height;
            x1 = x2 = Width / 2;
            var pen = new Pen(penColor);
            graphics.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));

            for (int j = 0; j < 3; ++j)
            {
                for (int i = 0; i < 2 * yLongDashInterval * yAxisPartNum + 1; ++i)
                {
                    if (i % 5 == 0)
                    {
                        x1 = -yDivLargeSeparatorLength / 2 + j * Width / 2;
                        x2 = +yDivLargeSeparatorLength / 2 + j * Width / 2;
                    }
                    else
                    {
                        x1 = -yDivSeparatorLength / 2 + j * Width / 2;
                        x2 = +yDivSeparatorLength / 2 + j * Width / 2;
                    }
                    y1 = y2 = i * Height / (2 * yLongDashInterval * yAxisPartNum);
                    graphics.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));
                }
            }
        }

        private void drawDotXAxis(Graphics graphics, Color penColor)
        {
            int x1, y1, x2, y2;
            x1 = 0;
            x2 = Width;
            var pen = new Pen(penColor);
            pen.DashPattern = new float[] { 1.0f, 7.0f };
            for (int i = 1; i < 2 * yAxisPartNum; ++i)
            {
                y1 = y2 = i * Height / (2 * yAxisPartNum);
                graphics.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));
            }
        }

        private void drawSolidXAxis(Graphics graphics, Color penColor)
        {
            int x1, y1, x2, y2;
            x1 = 0;
            x2 = Width;
            y1 = y2 = Height / 2;
            var pen = new Pen(penColor);
            graphics.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));
            for (int j = 0; j < 3; ++j)
            {
                for (int i = 0; i < 2 * xLongDashInterval * xAxisPartNum + 1; ++i)
                {
                    if (i % xLongDashInterval == 0)
                    {
                        y1 = -xDivLargeSeparatorLength / 2 + j * Height / 2;
                        y2 = +xDivLargeSeparatorLength / 2 + j * Height / 2;
                    }
                    else
                    {
                        y1 = -xDivSeparatorLength / 2 + j * Height / 2;
                        y2 = +xDivSeparatorLength / 2 + j * Height / 2;
                    }
                    x1 = x2 = i * Width / (2 * xLongDashInterval * xAxisPartNum);
                    graphics.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));
                }
            }
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

    }
}
