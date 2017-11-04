using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Globalization;

namespace KD3005P_GUI
{
    public partial class Form1 : Form
    {
        public static Color ColorOffGreen = Color.FromArgb(255, 0, 16, 8);
        public static Color ColorOnGreen = Color.FromArgb(255, 76, 255, 0);
        public static Color ColorOffRed = Color.FromArgb(255, 24, 0, 0);
        public static Color ColorOnRed = Color.FromArgb(255, 255, 0, 33);

        private Display display;
        private bool connected, output, cv, cc;
        private SerialPort port;
        private int cursorPosition;
        private bool blinking;

        private OptionSaver optionSaver;

        private bool Connected
        {
            get { return this.connected; }
            set
            {
                this.connected = value;
                this.labelConn.ForeColor = this.connected ? ColorOnGreen : ColorOffGreen;
                if (this.connected)
                {
                    CursorPosition = 0;
                }
                else
                {
                    OnDisconnect();
                    this.display.VoltageLimit.BlinkingDigit = -1;
                    this.display.CurrentLimit.BlinkingDigit = -1;
                }
                    

            }
        }

        private bool Output
        {
            get { return this.output; }
            set { 
                this.output = value;
                this.labelOn.ForeColor = this.output ? ColorOnGreen : ColorOffGreen;
                CV = false; CC = false;
                timer1.Enabled = value;

                if (!this.output)
                {
                    this.display.VoltageIs.Clear();
                    this.display.CurrentIs.Clear();
                }
            }
        }

        private bool CV
        {
            get { return this.cv; }
            set { this.cv = value; this.labelCV.ForeColor = this.cv ? ColorOnGreen : ColorOffGreen; }
        }

        private bool CC
        {
            get { return this.cc; }
            set { this.cc = value; this.labelCC.ForeColor = this.cc ? ColorOnRed : ColorOffRed; }
        }

        private int VoltageLimit
        {
            get { return this.display.VoltageLimit.Value; }
            set { this.display.VoltageLimit.Value = value; }
        }

        private int CurrentLimit
        {
            get { return this.display.CurrentLimit.Value; }
            set { this.display.CurrentLimit.Value = value; }
        }

        private int VoltageIs
        {
            get { return this.display.VoltageIs.Value; }
            set { this.display.VoltageIs.Value = value; }
        }

        private int CurrentIs
        {
            get { return this.display.CurrentIs.Value; }
            set { this.display.CurrentIs.Value = value; }
        }

        private int CursorPosition
        {
            get { return this.cursorPosition; }
            set
            {
                this.cursorPosition = (value + 8) % 8;

                if (this.cursorPosition < 4)
                {
                    this.display.VoltageLimit.BlinkingDigit = this.cursorPosition;
                    this.display.CurrentLimit.BlinkingDigit = -1;
                }
                else
                {
                    this.display.VoltageLimit.BlinkingDigit = -1;
                    this.display.CurrentLimit.BlinkingDigit = this.cursorPosition - 4;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();

            this.display = new Display(this.sevenSegmentArray1, this.sevenSegmentArray2, this.sevenSegmentArray3, this.sevenSegmentArray4);

            Connected = false;

            this.UpdateComboBoxCom();

            this.optionSaver = new OptionSaver();
            this.optionSaver.Load(this.listBox1.Items);
        }

        private void UpdateComboBoxCom()
        {
            string selected = (string)this.comboBoxCom.SelectedItem;

            if (selected == null)
                selected = "";

            this.comboBoxCom.Items.Clear();
            foreach (string port in SerialPort.GetPortNames())
            {
                this.comboBoxCom.Items.Add(port);
            }

            if (this.comboBoxCom.Items.Contains(selected))
            {
                this.comboBoxCom.SelectedItem = selected;
            }
            else if (this.comboBoxCom.Items.Count > 0)
            {
                this.comboBoxCom.SelectedIndex = 0;
            }

        }

        private void OnDisconnect()
        {
            this.display.VoltageLimit.Clear();
            this.display.CurrentLimit.Clear();
            this.display.VoltageIs.Clear();
            this.display.CurrentIs.Clear();

            Output = false;
        }

        private void buttonComRefresh_Click(object sender, EventArgs e)
        {
            this.UpdateComboBoxCom();
        }

        private void buttonComConnect_Click(object sender, EventArgs e)
        {
            Connected = false;

            if (this.port != null)
                this.port.Close();

            try
            {
                this.port = new SerialPort((string)this.comboBoxCom.SelectedItem, 9600);
                this.port.ReadTimeout = 30;
                this.port.Open();

                Connected = true;

                LoadVoltageLimit();
                LoadCurrentLimit();
                SetOutput(false);

                this.comboBoxCom.Select();
                                
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot connect to serial port!");
                Connected = false;
            }
        }

        private string SerialPortSendString(string str)
        {
            try
            {
                this.port.Write(str);
            }
            catch (Exception)
            {
                Connected = false;
                return null;
            }

            string input = "";

            try
            {
                while (true)
                {
                    char c = (char) this.port.ReadChar();
                    input += c;
                }
            }
            catch (TimeoutException)
            {
                return input;
            }
            catch (Exception)
            {
                Connected = false;
                return null;
            }
        }

        private Decimal OutputToDecimal(string output)
        {
            try
            {
                CultureInfo ci = new CultureInfo("en-US");
                return Decimal.Parse(output, ci);
            }
            catch (Exception)
            {
                return -1;
            }
        }

        private int DecimalToInt(Decimal dec, int multiplier) { return (int)Math.Round(dec * multiplier); }

        private void LoadVoltageLimit()
        {
            string output = SerialPortSendString("VSET1?");
            Decimal number = OutputToDecimal(output);

            if (number > -1)
                VoltageLimit = DecimalToInt(number, 100);
        }

        private void LoadCurrentLimit()
        {
            string output = SerialPortSendString("ISET1?");
            Decimal number = OutputToDecimal(output);

            if (number > -1)
                CurrentLimit = DecimalToInt(number, 1000);
        }

        private void LoadVoltageIs()
        {
            string output = SerialPortSendString("VOUT1?");
            Decimal number = OutputToDecimal(output);

            if (number > -1)
                VoltageIs = DecimalToInt(number, 100);
        }

        private void LoadCurrentIs()
        {
            string output = SerialPortSendString("IOUT1?");
            Decimal number = OutputToDecimal(output);

            if (number > -1)
                CurrentIs = DecimalToInt(number, 1000);
        }

        private void LoadStatus()
        {
            string output = SerialPortSendString("STATUS?");
            if (output == null)
                return;
            int c = output[0];

            if ((c & 1) != 0)
            {
                CC = false;
                CV = true;
            }
            else
            {
                CC = true;
                CV = false;
            }
        }

        private void SetOutput(bool enable)
        {
            if (!Connected)
                return;

            if (enable)
            {
                SerialPortSendString("OUT1");
            }
            else
            {
                SerialPortSendString("OUT0");
            }

            Output = enable;
        }

        private void labelOn_Click(object sender, EventArgs e)
        {
            SetOutput(!Output);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            UpdateDisplay();
            timer1.Enabled = true;
        }

        private void UpdateDisplay()
        {
            LoadVoltageIs();
            LoadCurrentIs();
            LoadStatus();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!Connected)
                return;

            switch (e.KeyCode)
            {
                case Keys.Left:
                    this.CursorPosition--;
                    this.blinking = false;
                    timer2_Tick(null, null);
                    timer2.Interval = 250;
                    break;
                case Keys.Right:
                    this.CursorPosition++;
                    this.blinking = false;
                    timer2_Tick(null, null);
                    timer2.Interval = 250;
                    break;
                case Keys.D0:
                case Keys.NumPad0:
                    digitEntered(0);
                    break;
                case Keys.D1:
                case Keys.NumPad1:
                    digitEntered(1);
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    digitEntered(2);
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    digitEntered(3);
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    digitEntered(4);
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    digitEntered(5);
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    digitEntered(6);
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    digitEntered(7);
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    digitEntered(8);
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                    digitEntered(9);
                    break;
                default:
                    return;
            }
            e.SuppressKeyPress = true;
        }

        private void digitEntered(int digit)
        {
            if (this.CursorPosition < 4)
            {
                this.VoltageLimit = swapDigit(this.VoltageLimit, 3 - this.CursorPosition, digit);

                if (this.VoltageLimit <= 3100)
                {
                    if (Output)
                        SetOutput(false);
                    SetVoltageLimit();
                }
            }
            else
            {
                this.CurrentLimit = swapDigit(this.CurrentLimit, 7 - this.CursorPosition, digit);

                if (this.CurrentLimit <= 5100)
                {
                    if (Output)
                        SetOutput(false);
                    SetCurrentLimit();
                }
            }
            this.CursorPosition++;
        }

        private int swapDigit(int number, int position, int digit)
        {
            int previousDigit = (number / (int)Math.Pow(10, position)) % 10;
            return number - previousDigit * (int)Math.Pow(10, position) + digit * (int)Math.Pow(10, position);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.blinking = !blinking;

            if (Connected)
            {
                this.display.VoltageLimit.Blinking = this.blinking;
                this.display.CurrentLimit.Blinking = this.blinking;
            }
        }

        private void SetVoltageLimit()
        {
            String text = VoltageLimit.ToString("D4");
            text = text.Insert(2, ".");
            SerialPortSendString("VSET1:" + text);
        }

        private void SetCurrentLimit()
        {
            String text = CurrentLimit.ToString("D4");
            text = text.Insert(1, ".");
            SerialPortSendString("ISET1:" + text);
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                listBox1.SelectedIndex = listBox1.IndexFromPoint(e.X, e.Y);
                contextMenuStrip1.Show(Cursor.Position);
                editToolStripMenuItem.Enabled = listBox1.SelectedItem != null;
                applyToolStripMenuItem.Enabled = listBox1.SelectedItem != null;
                deleteToolStripMenuItem.Enabled = listBox1.SelectedItem != null;
            }
        }

        private void applyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            applyCurrentOption();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            applyCurrentOption();
        }

        private void applyCurrentOption() {
            if (!Connected)
                return;

            if (listBox1.SelectedItem != null)
            {
                Option option = (Option)listBox1.SelectedItem;
                this.VoltageLimit = option.Voltage;
                this.CurrentLimit = option.Current;

                if (Output)
                    SetOutput(false);

                SetVoltageLimit();
                SetCurrentLimit();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;

            Option option = (Option)listBox1.SelectedItem;

            Form2 form2 = new Form2();
            form2.Voltage = option.Voltage;
            form2.Current = option.Current;
            form2.ShowDialog();

            if (form2.Accepted)
            {
                option.Voltage = form2.Voltage;
                option.Current = form2.Current;
                listBox1.Items[listBox1.SelectedIndex] = option;

                this.optionSaver.Save(listBox1.Items);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;

            listBox1.Items.Remove(listBox1.SelectedItem);
            this.optionSaver.Save(listBox1.Items);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

            if (form2.Accepted)
            {
                Option option = new Option(form2.Voltage, form2.Current);
                listBox1.Items.Add(option);
                this.optionSaver.Save(listBox1.Items);
            }
        }
    }
}
