using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniTool
{
    public partial class Form1 : Form
    {
        private bool statusVtStart = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void GetCurrentBCDStatus()
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.FileName = @"CMD.EXE";
            p.StartInfo.Arguments = @"/C bcdedit";
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            // parse the output
            var lines = output.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).Where(l => l.Length > 24);
            foreach (var line in lines)
            {
                var key = line.Substring(0, 24).Replace(" ", string.Empty);
                var value = line[24..].Replace(" ", string.Empty);
                if (key == "hypervisorlaunchtype")
                    statusVtStart = value != "Off";
            }
        }

        private void UpdateStatus()
        {
            GetCurrentBCDStatus();

            if (statusVtStart)
            {
                labelVtShow.Text = "已开启";
                labelVtShow.ForeColor = Color.Green;
            }
            else
            {
                labelVtShow.Text = "已关闭";
                labelVtShow.ForeColor = Color.Red;
            }
        }

        private void BtnVtSwitcher_Click(object sender, EventArgs e)
        {
            string cmdLine = String.Format("/c bcdedit /set hypervisorlaunchtype {0}",
                statusVtStart ? "off" : "auto");

            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.FileName = @"CMD.EXE";
            p.StartInfo.Arguments = cmdLine;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            // string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();


            UpdateStatus();
        }
    }
}
