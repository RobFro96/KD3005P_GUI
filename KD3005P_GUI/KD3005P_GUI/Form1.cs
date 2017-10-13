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
        int x = 0;

        public Form1()
        {
            InitializeComponent();
            this.sevenSegmentArray1.Value = x + " .";
        }
    }
}
