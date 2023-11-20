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
using System.Net.Sockets;
using System.Net;
using RawPrint;
using SuperSimpleTcp;

using System.Runtime.InteropServices;
using System.Windows;
using System.Drawing.Printing;
using RawPrint.NetStd;

namespace LocalPrinterServer
{
    public partial class LocalPrinterServerMain : Form
    {


        public string defaultPrinter="";

        public LocalPrinterServerMain()
        {
            InitializeComponent();
            checkIniSetting();

           


            this.WindowState = FormWindowState.Minimized;
            this.Visible = false;
            this.ShowInTaskbar = false;

            StartTCPServer();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            SettingsPage newform = new SettingsPage();

            newform.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to Exit this Server ??",
                                      "Confirm Exit!!",
                                      MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // If 'Yes', do something here.
                this.Close();
            }
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
                MessageBox.Show("No printer setting found, please set the defualt printer and restart this server at the first!");
            }
            else
            {
                file.Load(path);
                string DefaultPrinterName = file.GetSetting(SoftCircuits.IniFileParser.IniFile.DefaultSectionName, "DefaultPrinter", string.Empty);
                this.defaultPrinter = DefaultPrinterName;
                this.DefaultPrinterNameLabel.Text = defaultPrinter;

                Console.WriteLine(defaultPrinter);

            }
        }

     

        public void StartTCPServer()
        {

            SimpleTcpServer server = new SimpleTcpServer("0.0.0.0:9100");
            // set events
            //server.Events.ClientConnected += ClientConnected;
            
            server.Events.DataReceived += DataReceived;
            //server.Events.ClientDisconnected += ClientDisconnected;

            // let's go!
            server.Start();

            // once a client has connected...
            //server.Send("[ClientIp:Port]", "Hello, world!");
            Console.Read();



        }
       

        public void DataReceived(object sender, DataReceivedEventArgs e)
        {
           
            string printName = defaultPrinter;
          
            IPrinter printer = new Printer();
            MemoryStream printStream = new MemoryStream();
            printStream.Write(e.Data.Array, 0, e.Data.Count);
            printer.PrintRawStream(printName, printStream, "Joblist",false);


        }


        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show(); 
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;

            // Activate the form.
            this.Activate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Visible = false;
            this.ShowInTaskbar = false;
        }
    }
}
