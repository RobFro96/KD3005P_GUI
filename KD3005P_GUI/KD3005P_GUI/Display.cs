﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DmitryBrant.CustomControls;

namespace KD3005P_GUI
{
    class Display
    {
        public class SegmentDisplay
        {
            private int value, commaPosition;
            private SevenSegmentArray display;
            private bool blinking;

            public SegmentDisplay(SevenSegmentArray display, int commaPosition)
            {
                this.display = display;
                this.commaPosition = commaPosition;
            }

            public int BlinkingDigit;
            public bool Blinking
            {
                get { return this.blinking; }
                set
                {
                    this.blinking = value;
                    this.Redraw();
                }
            }

            public int Value
            {
                get
                {
                    return value;
                }
                set
                {
                    this.value = value;
                    this.Redraw();
                }
            }

            private void Redraw()
            {
                String text = value.ToString("D4");

                if (Blinking && BlinkingDigit != -1)
                {
                    text = text.Substring(0, BlinkingDigit) + " " + text.Substring(BlinkingDigit + 1);
                }

                if (commaPosition > -1)
                    text = text.Insert(commaPosition, ".");

                this.display.Value = text;
            }

            public void Clear()
            {
                String text = "----";

                if (commaPosition > -1)
                    text = text.Insert(commaPosition, ".");

                this.display.Value = text;
            }

        }

        private SegmentDisplay voltageLimit, currentLimit, voltageIs, currentIs;

        public SegmentDisplay VoltageLimit
        {
            get { return voltageLimit; }
        }

        public SegmentDisplay CurrentLimit
        {
            get { return currentLimit; }
        }

        public SegmentDisplay VoltageIs
        {
            get { return voltageIs; }
        }

        public SegmentDisplay CurrentIs
        {
            get { return currentIs; }
        }

        public Display(SevenSegmentArray voltageLimit, SevenSegmentArray currentLimit, SevenSegmentArray voltageIs, SevenSegmentArray currentIs)
        {
            this.voltageLimit = new SegmentDisplay(voltageLimit, 2);
            this.currentLimit = new SegmentDisplay(currentLimit, 1);
            this.voltageIs = new SegmentDisplay(voltageIs, 2);
            this.currentIs = new SegmentDisplay(currentIs, 1);
        }

    }
}
