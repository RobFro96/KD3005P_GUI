using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace KD3005P_GUI
{
    class OptionSaver
    {
        public void Load(ListBox.ObjectCollection items)
        {
            items.Clear();

            try
            {
                StreamReader file = new StreamReader(".options");

                string line;
                while ((line = file.ReadLine()) != null)
                {
                    String[] splitted = line.Split(',');
                    Option option = new Option(int.Parse(splitted[0]), int.Parse(splitted[1]));
                    items.Add(option);
                }

                file.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot read .options file.");
            }
        }

        public void Save(ListBox.ObjectCollection items)
        {
            try
            {
                StreamWriter file = new StreamWriter(".options", false);

                foreach (Option option in items)
                {
                    file.WriteLine(option.Voltage + "," + option.Current);
                }
                
                file.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot read .options file.");
            }
        }
    }
}
