using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabFramework01
{
    public partial class FormOscilloscope : Form
    {
        public FormOscilloscope()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ControlBox = true;
            //WindowState = FormWindowState.Maximized;
            //BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display1.StartTimer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display1.StopTimer();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            display1.CopyImageToClipboard();
        }
    }
}
