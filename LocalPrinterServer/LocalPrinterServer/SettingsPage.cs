using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LocalPrinterServer
{
    public partial class SettingsPage : Form
    {
       

        public SettingsPage()
        {
            InitializeComponent();
            GetPrinterList();
            checkIniSetting();


        }
        public string GetPrinterList()
        {
            string PrintersList = "";

            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                //PrintersList = PrintersList + printer + " ";
                this.comboBox1.Items.Add(printer);
            }

            //MessageBox.Show(PrintersList);

            return PrintersList;

        }

       

        public void checkIniSetting()
        {
            string path = @"setting.ini";
     
            SoftCircuits.IniFileParser.IniFile file = new SoftCircuits.IniFileParser.IniFile();
            if (!File.Exists(path))
            {
                // Create a file to write to
            
                file.SetSetting(SoftCircuits.IniFileParser.IniFile.DefaultSectionName, "DefaultPrinter", "");
                file.Save(path);
            }
            else
            {
                file.Load(path);
                string DefaultPrinterName = file.GetSetting(SoftCircuits.IniFileParser.IniFile.DefaultSectionName, "DefaultPrinter", string.Empty);
                this.comboBox1.SelectedItem = DefaultPrinterName;



            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"setting.ini";


            var selectdPrinter = this.comboBox1.SelectedItem;
            Console.WriteLine(selectdPrinter);
            SoftCircuits.IniFileParser.IniFile file = new SoftCircuits.IniFileParser.IniFile();
           
            file.SetSetting(SoftCircuits.IniFileParser.IniFile.DefaultSectionName, "DefaultPrinter", (string)selectdPrinter);
            file.Save(path);
        
            MessageBox.Show("Saved, please restart Printer Server");


           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
