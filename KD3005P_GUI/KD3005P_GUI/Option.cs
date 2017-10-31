using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD3005P_GUI
{
    class Option
    {
        public int Voltage, Current;

        public Option(int voltage, int current) {
            this.Voltage = voltage;
            this.Current = current;
        }

        public override string ToString()
        {
            if (Current >= 1000)
            {
                return (Voltage / 100f) + " V, " + (Current / 1000f) + " A";
            }
            else
            {
                return (Voltage / 100f) + " V, " + Current + " mA";
            }
        }
    }
}
