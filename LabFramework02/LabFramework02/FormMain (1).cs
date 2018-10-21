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
    public partial class FormMain : RibbonForm
    {
        public CommunicationManager CommPort = new CommunicationManager();

        public FormMain()
        {
            InitializeComponent();
        }

        private void OscilloscopeClick(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FormOscilloscope))
                {
                    f.Activate();
                    if (ribbon1.ActiveTab != ribbonTab2)
                        ribbon1.ActiveTab = ribbonTab2;
                    return;
                }
            }
            Form form = new FormOscilloscope();
            form.MdiParent = this;
            form.Show();
            if (ribbon1.ActiveTab != ribbonTab2)
                ribbon1.ActiveTab = ribbonTab2;
        }

        private void FunctionGeneratorClick(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FormFunctionGen))
                {
                    f.Activate();
                    if (ribbon1.ActiveTab != ribbonTab3)
                        ribbon1.ActiveTab = ribbonTab3;
                    return;
                }
            }
            Form form = new FormFunctionGen();
            form.MdiParent = this;
            form.Show();
            if (ribbon1.ActiveTab != ribbonTab3)
                ribbon1.ActiveTab = ribbonTab3;
        }

        private void FormMultimeterClick(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FormMultiMeter))
                {
                    f.Activate();
                    if (ribbon1.ActiveTab != ribbonTab4)
                        ribbon1.ActiveTab = ribbonTab4;
                    return;
                }
            }
            Form form = new FormMultiMeter();
            form.MdiParent = this;
            form.Show();
            if (ribbon1.ActiveTab != ribbonTab4)
                ribbon1.ActiveTab = ribbonTab4;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void FormAllClick(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FormAll))
                {
                    f.Activate();
                    if (ribbon1.ActiveTab != ribbonTab1)
                        ribbon1.ActiveTab  = ribbonTab1;
                    return;
                }
            }
            Form form = new FormAll();
            form.MdiParent = this;
            form.Show();
            if (ribbon1.ActiveTab != ribbonTab1)
                ribbon1.ActiveTab = ribbonTab1;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormAllClick(null, null);
        }

        private void SignalControlClick(object sender, EventArgs e)
        {
            Form signalControl = new SignalControl();
            signalControl.Owner = this;
            //signalControl.TopMost = true;
            signalControl.Show();
        }

        private void ribbon1_Click(object sender, EventArgs e)
        {

        }

        private void AppExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormDebugClick(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FormDebug))
                {
                    f.Activate();
                    if (ribbon1.ActiveTab != ribbonTab5)
                        ribbon1.ActiveTab = ribbonTab5;
                    return;
                }
            }
            Form form = new FormDebug();
            form.MdiParent = this;
            form.Show();
            if (ribbon1.ActiveTab != ribbonTab5)
                ribbon1.ActiveTab = ribbonTab5;
        }
    }
}
