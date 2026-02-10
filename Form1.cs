using DeviceInfo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace UnisocUNLOCKER
{
    public partial class Form1 : Form
    {
        bool check = false;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            this.KeyPreview = true;
            button1.Visible = false;
            label3.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var device in DeviceRepo.devices)
            {
                if (comboBox1.Text == "All")
                {
                    listBox1.Items.Add($"{device.Model} ({device.Cpu})");
                } else if (comboBox1.Text == device.Cpu)
                {
                    listBox1.Items.Add($"{device.Model} ({device.Cpu})");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (var device in DeviceRepo.devices)
            {
                string str = $"{device.Model} ({device.Cpu})";
                if (str.ToLower().Contains(textBox1.Text.ToLower()))
                {
                    listBox1.Items.Add(str);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
            label3.Visible = true;
            label3.Text = $"{listBox1.Items[listBox1.SelectedIndex]}";
            Log($"Chosen {label3.Text}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to continue?", "FRP UNLOCK", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Follow the instructions on the Debug window.", "FRP UNLOCK");
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
            Log("\n");
            Log("Enter EDL mode. Press Power+VOL_DOWN / Power+VOL_DOWN+VOL_UP when pluging in the usb or use test points. Be sure to have the SPD driver installed.");
            Log("\n");
            Log("Please press Z when ready.");
            check = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
        }

        private void Log(string message)
        {
            textBox2.AppendText(message);
            textBox2.AppendText(Environment.NewLine);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Do you want to open the driver setup?", "SPD DRIVER INSTALLER", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Version v = Environment.OSVersion.Version;
                string path = "Driver\\";
                if (v.Major == 10)
                {
                    path += "Win10\\";
                }
                else if (v.Major == 6 && (v.Minor == 3 || v.Minor == 2))
                {
                    path += "Win8\\";
                }
                else if (v.Major == 6 && v.Minor == 1)
                {
                    path += "Win7\\";
                }
                else {
                    MessageBox.Show("Unknown or unsupported Windows version", "ERROR");
                    return;
                }
                string setupExe = System.IO.Path.Combine(path, "DriverSetup.exe");

                if (!System.IO.File.Exists(setupExe))
                {
                    MessageBox.Show("Driver setup not found:\n" + setupExe, "ERROR");
                    return;
                }

                System.Diagnostics.Process.Start(setupExe);
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z)
            {
                if (check)
                {
                    StartFRPUnlock();
                    check = false;
                }
            }
        }

        private void StartFRPUnlock()
        {
            string text = (string)listBox1.Items[listBox1.SelectedIndex];
            int index = text.IndexOf(" (");
            if (index >= 0)
            {
                text = text.Substring(0, index);
            }
            var devices = DeviceInfo.DeviceRepo.devices
                .Where(d => d.Model.IndexOf(text, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
            var device = devices[0]; // should work ig?
            string workingPath = $"Devices\\{device.Folder}";
            string batFile = Directory.GetFiles(workingPath, "*unlock*.bat").FirstOrDefault();  // the naming scheme is really incosistent
            if (batFile == null)
            {
                MessageBox.Show("No unlock*.bat file found. Message ._ics._ on discord", "shit");
                return;
            }
            string[] lines = File.ReadAllLines(batFile);
            string command = "e";
            foreach (var line in lines)
            {
                string trimmedLine = line.TrimStart();
                if (trimmedLine.StartsWith("spd_dump"))
                {
                    index = trimmedLine.IndexOf("exec ");
                    if (index < 0) continue;
                    command = trimmedLine.Substring(0, index);
                    command += "exec r persist e persist reset";
                    break;
                }
            }
            if (command == "e")
            {
                MessageBox.Show("No command found. Message ._ics._ on discord", "shit");
            }
            Console.WriteLine(command);
            string exe = command.Split(' ')[0]; // "spd_dump"
            string args = command.Substring(exe.Length).Trim(); // everything after the first space
            System.Diagnostics.Process.Start($"{workingPath}\\{exe}", args);
        }
    }
}
