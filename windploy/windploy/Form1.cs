using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace windploy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                if(textBox1.Text == "sudo recovery")
                {
                    Application.Exit();
                }
                else
                {
                    textBox1.Text = "";
                }
            }
        }

        private async void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (textBox1.Text == "sudo recovery")
                {
                    Microsoft.Win32.RegistryKey regkey = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\Setup");
                    regkey.SetValue("CmdLine", "");
                    regkey.Close();
                    {
                        System.Diagnostics.ProcessStartInfo reboot = new System.Diagnostics.ProcessStartInfo();
                        reboot.FileName = "shutdown.exe";
                        reboot.Arguments = "/r /t 00";
                        System.Diagnostics.Process.Start(reboot);
                    }
                }
                else
                {
                    textBox1.Text = "not found command";
                    await Task.Delay(1000);
                    textBox1.Text = "";
                }
            }
        }
    }
}
