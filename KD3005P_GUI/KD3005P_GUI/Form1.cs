using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KD3005P_GUI
{
    public partial class Form1 : Form
    {
        private Display display;

        public Form1()
        {
            InitializeComponent();

            this.display = new Display(this.sevenSegmentArray1, this.sevenSegmentArray2, this.sevenSegmentArray3, this.sevenSegmentArray4);
            this.display.VoltageLimit.Clear();
            this.display.CurrentLimit.Clear();
            this.display.VoltageIs.Clear();
            this.display.CurrentIs.Clear();
        }
    }
}
