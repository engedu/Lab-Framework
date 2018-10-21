using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabFramework01
{
    public partial class FgenDisplay : UserControl
    {
        Bitmap DrawArea;


        public FgenDisplay()
        {
            InitializeComponent();
            DrawArea = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            pictureBox1.Image = DrawArea;
        }

        private void FgenDisplay_Load(object sender, EventArgs e)
        {
            Graphics g;
            g = Graphics.FromImage(DrawArea);
            g.Clear(Color.Black);
            Pen mypen = new Pen(Brushes.LightCyan, 2.5f);
            g.DrawRectangle(mypen, 2, 2, DrawArea.Width - 3, DrawArea.Height - 3);
            g.Dispose();


            UpdateValue("300 Hz", "1.0 Vpp", "0.0 V");
        }

        internal void UpdateValue(string Freq, string Amplitude, string Offset )
        {
            Graphics g;
            g = Graphics.FromImage(DrawArea);
            g.Clear(Color.Black);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Far;

            g.DrawString("FREQUENCY", new Font("Arial", 10), new SolidBrush(Color.LightCyan), new PointF(15.0F, 40.0F));
            g.DrawString(Freq, new Font("Arial", 30), new SolidBrush(Color.LightCyan), new RectangleF(0, 15.0F, this.DrawArea.Width -15F, this.DrawArea.Height ), format); 
            g.DrawLine(new Pen(Color.LightCyan, 1.5f), 15.0F, 60.0F, DrawArea.Width - 15, 60.0F);

            g.DrawString("AMPLITUDE", new Font("Arial", 10), new SolidBrush(Color.LightCyan), new PointF(15.0F, 100.0F));
            g.DrawString(Amplitude, new Font("Arial", 30), new SolidBrush(Color.LightCyan), new RectangleF(0, 75.0F, this.DrawArea.Width - 15F, this.DrawArea.Height), format);
            g.DrawLine(new Pen(Color.LightCyan, 1.5f), 15.0F, 120.0F, DrawArea.Width - 15, 120.0F);

            g.DrawString("OFFSET", new Font("Arial", 10), new SolidBrush(Color.LightCyan), new PointF(15.0F, 160.0F));
            g.DrawString(Offset, new Font("Arial", 30), new SolidBrush(Color.LightCyan), new RectangleF(0, 135.0F, this.DrawArea.Width - 15F, this.DrawArea.Height), format);
            g.DrawLine(new Pen(Color.LightCyan, 1.5f), 15.0F, 180.0F, DrawArea.Width - 15, 180.0F);


            g.Dispose();
            pictureBox1.Invalidate();
        }

        private void UpdateValue()
        {
            Graphics g;
            g = Graphics.FromImage(DrawArea);
            g.DrawString("6.000kHz", new Font("Arial", 16), new SolidBrush(Color.LightCyan), new PointF(15.0F, 15.0F));
            g.Dispose();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox1_Validated(object sender, EventArgs e)
        {

        }
    }
}
