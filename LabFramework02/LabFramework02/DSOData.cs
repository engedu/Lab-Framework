using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFramework01
{
    class DSOData
    {
        //public DSOData(int Loc, int CH1, int CH2)
        //{
        //    _CH1 = CH1;
        //    _CH2 = CH2;
        //    _LOC = Loc;
        //}

        public DSOData(string dataLine)
        {
            string[] values = dataLine.Split(new char[] { ':' });
            _LOC = Convert.ToInt32(values[0]);
            _CH1 = Convert.ToInt32(values[1]);
        }

        public int _LOC;

        public int _CH1;

        public int _CH2;

    }
}
