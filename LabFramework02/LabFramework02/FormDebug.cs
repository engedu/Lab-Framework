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
    public partial class FormDebug : Form
    {
        CommunicationManager comm; 

        
        public FormDebug()
        {
            InitializeComponent();

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ControlBox = false;
            WindowState = FormWindowState.Maximized;
            BringToFront();
            FormMain f = (FormMain)this.MdiParent;
            comm = f.CommPort;
        }
        private void FormDebug_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comm.WriteData("\u001A");
            //rtbDisplay.Clear();
             //FormMain f = (FormMain) this.MdiParent;

             //f.CommPort.WriteData("\u001a");

        }

        private void CommPortOpen(object sender, EventArgs e)
        {

            comm.BaudRate = "115200";
            comm.DataBits = "8";
            comm.Parity = "None";
            comm.StopBits = "1";

            comm.PortName = "COM4";

            comm.DisplayWindow = rtbDisplay;
            foreach (Form f in this.MdiParent.MdiChildren)
            {
                if (f.GetType() == typeof(FormOscilloscope))
                {
                    //((FormOscilloscope)f).CommPort.WriteData("\u001a");
                    comm.DSOWindow = ((FormOscilloscope)f).dsoDisp;
                 //   return;
                }
            }

            comm.OpenPort();

            if (true == comm.isPortOpen)
            {


            }
        }

        private void CommPortClose(object sender, EventArgs e)
        {
            comm.ClosePort();
            if (false == comm.isPortOpen)
            {
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f = this.MdiParent;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1_Click(null, null);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(comm.commString);
            string ss = comm.commString.ToString();
            string [] str = ss.Split(new char[] { '\n', '\r', '[', ']' }).Where<string>(s=>!string.IsNullOrEmpty(s)).ToArray() ;
            comm.commString.Clear();
            foreach (string s in str)
            {

                DSOData dsoData = new DSOData(s);
                Console.WriteLine(dsoData._CH1);

            }
//                .Where (val => val.StartsWith("[") &&  val.EndsWith("]"))
 //               .ToArray();
        }
    }
}
