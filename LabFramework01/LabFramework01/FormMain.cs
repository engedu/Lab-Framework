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
                    return;
                }
            }
            Form form = new FormOscilloscope();
            form.MdiParent = this;
            form.Show();
        }

        private void FunctionGeneratorClick(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FormFunctionGen))
                {
                    f.Activate();
                    return;
                }
            }
            Form form = new FormFunctionGen();
            form.MdiParent = this;
            form.Show();

        }

        private void FormMultimeterClick(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FormMultiMeter))
                {
                    f.Activate();
                    return;
                }
            }
            Form form = new FormMultiMeter();
            form.MdiParent = this;
            form.Show();

        }
    }
}
