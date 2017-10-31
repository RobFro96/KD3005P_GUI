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
    public partial class Form2 : Form
    {
        public bool Accepted = false;

        public int Voltage
        {
            get { return (int)(numericUpDown1.Value * 100); }
            set { numericUpDown1.Value = value / 100M; }
        }

        public int Current
        {
            get { return (int)(numericUpDown2.Value * 1000); }
            set { numericUpDown2.Value = value / 1000M; }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Accepted = true;
            this.Close();
        }
    }
}
