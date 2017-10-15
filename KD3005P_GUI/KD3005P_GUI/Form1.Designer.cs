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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 146);
            this.panel1.TabIndex = 3;
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
            this.sevenSegmentArray3.ItalicFactor = 0F;
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
            this.sevenSegmentArray4.ItalicFactor = 0F;
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
            this.sevenSegmentArray2.ItalicFactor = 0F;
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
            this.sevenSegmentArray1.ItalicFactor = 0F;
            this.sevenSegmentArray1.Location = new System.Drawing.Point(13, 13);
            this.sevenSegmentArray1.Name = "sevenSegmentArray1";
            this.sevenSegmentArray1.Size = new System.Drawing.Size(322, 116);
            this.sevenSegmentArray1.TabIndex = 6;
            this.sevenSegmentArray1.TabStop = false;
            this.sevenSegmentArray1.Value = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 504);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
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


    }
}