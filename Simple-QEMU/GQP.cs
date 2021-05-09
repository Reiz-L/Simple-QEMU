using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Simple_QEMU
{
    public partial class GQP : Form
    {
        public GQP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String LaunchMethod;
            if(radioButton1.Checked)
            {
                LaunchMethod = "4.x";
            }
            else
            {
                LaunchMethod = "5.x";
            }
            FileStream fs = new FileStream(Application.StartupPath + "\\config.cfg",FileMode.Create);
            StreamWriter sw = new StreamWriter(fs,Encoding.Default);
            sw.Write(textBox1.Text + "\n" + LaunchMethod);
            sw.Close();
            fs.Close();
            Close();
        }

        private void GQP_Load(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "\\config.cfg"))
            {
                StreamReader sr = new StreamReader(Application.StartupPath + "\\config.cfg", Encoding.Default);
                String str = sr.ReadToEnd();
                string[] strs = str.Split(new string[] {"\n"},StringSplitOptions.None);
                sr.Close();
                textBox1.Text = strs[0];
                if (strs.Length > 1)
                {
                    if (strs[1] == "4.x")
                    {
                        radioButton1.Checked = true;
                    }
                    else if (strs[1] == "5.x")
                    {
                        radioButton2.Checked = true;
                    }
                    else if (strs[1] == null)
                    {
                        radioButton1.Checked = true;
                    }
                }
                else
                {
                    radioButton1.Checked = true;
                }
                
            }
        }
    }
}
