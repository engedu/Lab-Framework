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
    public partial class FormFunctionGen : Form
    {
        public FormFunctionGen()
        {
            InitializeComponent();
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //ControlBox = false;
            //WindowState = FormWindowState.Maximized;
            //BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fgenDisplay1.UpdateValue(textBox1.Text, textBox1.Text, textBox1.Text  );
        }
    }
}
