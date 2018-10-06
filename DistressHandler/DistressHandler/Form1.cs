using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using IDroid;


namespace DistressHandler
{

    public partial class Form1 : Form
    {
        Core.IDroidDevice droid = new Core.IDroidDevice();
        Adb.AdbDeviceAdapter adbDeviceAdapter = new Adb.AdbDeviceAdapter();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adb.AdbInitializer adbInitializer=new Adb.AdbInitializer();

            if (!Directory.Exists("ADT"))
            {
                adbInitializer.InstallADT();
            }

            adbInitializer.RunDaemon();
            this.Text = "Distress Handling (Running ADB)";
            loadDevices();
            this.Text = "Distress Handling (ADB Interface)";
        }

        private void loadDevices()
        {
            
            adbDeviceAdapter.LoadDevices();
            
            foreach (Core.IDroidDevice idd in adbDeviceAdapter.DeviceCollection)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = idd.Model;
                listViewItem.Tag = idd.SerialNumber;
                listViewItem.Font = new Font("Segoe UI", 13);
                lvDevices.Items.Add(listViewItem);
            }
            button1.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Adb.AdbCommand command = new Adb.AdbCommand() ;
            Adb.AdbNetworkAdapter adbNetworkAdapter = new Adb.AdbNetworkAdapter(droid);
            if (adbNetworkAdapter.IsNetworkConnected())
            {
                command.ExecuteCommand("adb -s " + droid.SerialNumber + " tcpip 5555");

                string ipaddr = "";
                if (adbNetworkAdapter.GetDeviceIPAddress != null)
                {
                    ipaddr = adbNetworkAdapter.GetDeviceIPAddress.ToString();
                }
                else
                {
                    this.Text = "Connection failed ...";
                    return;
                }
               string comval= command.ExecuteCommand("adb -s " + droid.SerialNumber + " connect " + ipaddr).Data;
                if (comval.Contains("Unable"))
                {
                    this.Text = "Connection failed ...";
                    return;
                }
                this.Text = "Connected to - " + droid.Model;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

        private void lvDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            droid = adbDeviceAdapter.SearchDevice(lvDevices.SelectedItems[0].Tag.ToString(), Core.IDeviceSearchParameters.SerialNumber);

        }
        
        
       

        private void btn_run_Click(object sender, EventArgs e)
        {
            rtbcommand.Text += txtcommand.Text + Environment.NewLine;
            Adb.AdbCommand command = new Adb.AdbCommand();
            string command_string = command.ExecuteCommand(txtcommand.Text).Data;
            rtbcommand.Text += command_string;
            txtcommand.Text = "";
        }

        private void txtcommand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btn_run_Click(sender, e);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName != null)
            {
                File.Create("binPath.dat");
                
                using (StreamWriter sw = new StreamWriter("binPath.dat"))
                {
                    sw.Write(ofd.FileName);
                }
                Process process = new Process();
                process.StartInfo.FileName = ofd.FileName;
                process.StartInfo.Arguments=
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string binpath = "";
            using(StreamReader sr=new StreamReader("binPath.dat"))
            {

            }
        }
    }
}
