namespace KD3005P_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonComConnect = new System.Windows.Forms.Button();
            this.buttonComRefresh = new System.Windows.Forms.Button();
            this.comboBoxCom = new System.Windows.Forms.ComboBox();
            this.labelCC = new System.Windows.Forms.Label();
            this.labelCV = new System.Windows.Forms.Label();
            this.labelOn = new System.Windows.Forms.Label();
            this.labelConn = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.sevenSegmentArray3 = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.panel5 = new System.Windows.Forms.Panel();
            this.sevenSegmentArray4 = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sevenSegmentArray2 = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sevenSegmentArray1 = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.applyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.buttonComConnect);
            this.panel1.Controls.Add(this.buttonComRefresh);
            this.panel1.Controls.Add(this.comboBoxCom);
            this.panel1.Controls.Add(this.labelCC);
            this.panel1.Controls.Add(this.labelCV);
            this.panel1.Controls.Add(this.labelOn);
            this.panel1.Controls.Add(this.labelConn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 146);
            this.panel1.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(505, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(191, 134);
            this.listBox1.TabIndex = 3;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // buttonComConnect
            // 
            this.buttonComConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComConnect.Location = new System.Drawing.Point(156, 102);
            this.buttonComConnect.Name = "buttonComConnect";
            this.buttonComConnect.Size = new System.Drawing.Size(32, 32);
            this.buttonComConnect.TabIndex = 2;
            this.buttonComConnect.Text = "↩ ";
            this.buttonComConnect.UseVisualStyleBackColor = true;
            this.buttonComConnect.Click += new System.EventHandler(this.buttonComConnect_Click);
            // 
            // buttonComRefresh
            // 
            this.buttonComRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComRefresh.Location = new System.Drawing.Point(118, 102);
            this.buttonComRefresh.Name = "buttonComRefresh";
            this.buttonComRefresh.Size = new System.Drawing.Size(32, 32);
            this.buttonComRefresh.TabIndex = 2;
            this.buttonComRefresh.Text = "↻";
            this.buttonComRefresh.UseVisualStyleBackColor = true;
            this.buttonComRefresh.Click += new System.EventHandler(this.buttonComRefresh_Click);
            // 
            // comboBoxCom
            // 
            this.comboBoxCom.FormattingEnabled = true;
            this.comboBoxCom.Location = new System.Drawing.Point(12, 111);
            this.comboBoxCom.Name = "comboBoxCom";
            this.comboBoxCom.Size = new System.Drawing.Size(100, 21);
            this.comboBoxCom.TabIndex = 1;
            // 
            // labelCC
            // 
            this.labelCC.AutoSize = true;
            this.labelCC.BackColor = System.Drawing.Color.Black;
            this.labelCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCC.Location = new System.Drawing.Point(297, 3);
            this.labelCC.Name = "labelCC";
            this.labelCC.Padding = new System.Windows.Forms.Padding(5);
            this.labelCC.Size = new System.Drawing.Size(94, 39);
            this.labelCC.TabIndex = 0;
            this.labelCC.Text = " C. C. ";
            // 
            // labelCV
            // 
            this.labelCV.AutoSize = true;
            this.labelCV.BackColor = System.Drawing.Color.Black;
            this.labelCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(8)))));
            this.labelCV.Location = new System.Drawing.Point(199, 3);
            this.labelCV.Name = "labelCV";
            this.labelCV.Padding = new System.Windows.Forms.Padding(5);
            this.labelCV.Size = new System.Drawing.Size(92, 39);
            this.labelCV.TabIndex = 0;
            this.labelCV.Text = " C. V. ";
            // 
            // labelOn
            // 
            this.labelOn.AutoSize = true;
            this.labelOn.BackColor = System.Drawing.Color.Black;
            this.labelOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(8)))));
            this.labelOn.Location = new System.Drawing.Point(117, 3);
            this.labelOn.Name = "labelOn";
            this.labelOn.Padding = new System.Windows.Forms.Padding(5);
            this.labelOn.Size = new System.Drawing.Size(76, 39);
            this.labelOn.TabIndex = 0;
            this.labelOn.Text = " ON ";
            this.labelOn.Click += new System.EventHandler(this.labelOn_Click);
            // 
            // labelConn
            // 
            this.labelConn.AutoSize = true;
            this.labelConn.BackColor = System.Drawing.Color.Black;
            this.labelConn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(8)))));
            this.labelConn.Location = new System.Drawing.Point(12, 3);
            this.labelConn.Name = "labelConn";
            this.labelConn.Padding = new System.Windows.Forms.Padding(5);
            this.labelConn.Size = new System.Drawing.Size(99, 39);
            this.labelConn.TabIndex = 0;
            this.labelConn.Text = "CONN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 358);
            this.panel2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(708, 358);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.sevenSegmentArray3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 206);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(10);
            this.panel6.Size = new System.Drawing.Size(348, 149);
            this.panel6.TabIndex = 6;
            // 
            // sevenSegmentArray3
            // 
            this.sevenSegmentArray3.ArrayCount = 4;
            this.sevenSegmentArray3.ColorBackground = System.Drawing.Color.Black;
            this.sevenSegmentArray3.ColorDark = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(8)))));
            this.sevenSegmentArray3.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.sevenSegmentArray3.DecimalShow = true;
            this.sevenSegmentArray3.ElementPadding = new System.Windows.Forms.Padding(4, 4, 12, 4);
            this.sevenSegmentArray3.ElementWidth = 8;
            this.sevenSegmentArray3.ItalicFactor = -0.05F;
            this.sevenSegmentArray3.Location = new System.Drawing.Point(13, 13);
            this.sevenSegmentArray3.Name = "sevenSegmentArray3";
            this.sevenSegmentArray3.Size = new System.Drawing.Size(322, 116);
            this.sevenSegmentArray3.TabIndex = 6;
            this.sevenSegmentArray3.TabStop = false;
            this.sevenSegmentArray3.Value = "";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.sevenSegmentArray4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(357, 206);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10);
            this.panel5.Size = new System.Drawing.Size(348, 149);
            this.panel5.TabIndex = 5;
            // 
            // sevenSegmentArray4
            // 
            this.sevenSegmentArray4.ArrayCount = 4;
            this.sevenSegmentArray4.ColorBackground = System.Drawing.Color.Black;
            this.sevenSegmentArray4.ColorDark = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(8)))));
            this.sevenSegmentArray4.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.sevenSegmentArray4.DecimalShow = true;
            this.sevenSegmentArray4.ElementPadding = new System.Windows.Forms.Padding(4, 4, 12, 4);
            this.sevenSegmentArray4.ElementWidth = 8;
            this.sevenSegmentArray4.ItalicFactor = -0.05F;
            this.sevenSegmentArray4.Location = new System.Drawing.Point(13, 13);
            this.sevenSegmentArray4.Name = "sevenSegmentArray4";
            this.sevenSegmentArray4.Size = new System.Drawing.Size(322, 116);
            this.sevenSegmentArray4.TabIndex = 6;
            this.sevenSegmentArray4.TabStop = false;
            this.sevenSegmentArray4.Value = "";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.sevenSegmentArray2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(357, 57);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(348, 143);
            this.panel4.TabIndex = 4;
            // 
            // sevenSegmentArray2
            // 
            this.sevenSegmentArray2.ArrayCount = 4;
            this.sevenSegmentArray2.ColorBackground = System.Drawing.Color.Black;
            this.sevenSegmentArray2.ColorDark = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sevenSegmentArray2.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.sevenSegmentArray2.DecimalShow = true;
            this.sevenSegmentArray2.ElementPadding = new System.Windows.Forms.Padding(4, 4, 12, 4);
            this.sevenSegmentArray2.ElementWidth = 8;
            this.sevenSegmentArray2.ItalicFactor = -0.05F;
            this.sevenSegmentArray2.Location = new System.Drawing.Point(13, 13);
            this.sevenSegmentArray2.Name = "sevenSegmentArray2";
            this.sevenSegmentArray2.Size = new System.Drawing.Size(322, 116);
            this.sevenSegmentArray2.TabIndex = 7;
            this.sevenSegmentArray2.TabStop = false;
            this.sevenSegmentArray2.Value = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 54);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amps";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Volts";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.sevenSegmentArray1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 57);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(348, 143);
            this.panel3.TabIndex = 0;
            // 
            // sevenSegmentArray1
            // 
            this.sevenSegmentArray1.ArrayCount = 4;
            this.sevenSegmentArray1.ColorBackground = System.Drawing.Color.Black;
            this.sevenSegmentArray1.ColorDark = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sevenSegmentArray1.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.sevenSegmentArray1.DecimalShow = true;
            this.sevenSegmentArray1.ElementPadding = new System.Windows.Forms.Padding(4, 4, 12, 4);
            this.sevenSegmentArray1.ElementWidth = 8;
            this.sevenSegmentArray1.ItalicFactor = -0.05F;
            this.sevenSegmentArray1.Location = new System.Drawing.Point(13, 13);
            this.sevenSegmentArray1.Name = "sevenSegmentArray1";
            this.sevenSegmentArray1.Size = new System.Drawing.Size(322, 116);
            this.sevenSegmentArray1.TabIndex = 6;
            this.sevenSegmentArray1.TabStop = false;
            this.sevenSegmentArray1.Value = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 250;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applyToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.addToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(124, 92);
            // 
            // applyToolStripMenuItem
            // 
            this.applyToolStripMenuItem.Name = "applyToolStripMenuItem";
            this.applyToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.applyToolStripMenuItem.Text = "Apply";
            this.applyToolStripMenuItem.Click += new System.EventHandler(this.applyToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.addToolStripMenuItem.Text = "Add New";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 504);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(724, 543);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(724, 543);
            this.Name = "Form1";
            this.Text = "KD3005P_GUI";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private DmitryBrant.CustomControls.SevenSegmentArray sevenSegmentArray3;
        private System.Windows.Forms.Panel panel5;
        private DmitryBrant.CustomControls.SevenSegmentArray sevenSegmentArray4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private DmitryBrant.CustomControls.SevenSegmentArray sevenSegmentArray1;
        private DmitryBrant.CustomControls.SevenSegmentArray sevenSegmentArray2;
        private System.Windows.Forms.Label labelCC;
        private System.Windows.Forms.Label labelCV;
        private System.Windows.Forms.Label labelOn;
        private System.Windows.Forms.Label labelConn;
        private System.Windows.Forms.ComboBox comboBoxCom;
        private System.Windows.Forms.Button buttonComConnect;
        private System.Windows.Forms.Button buttonComRefresh;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applyToolStripMenuItem;


    }
}