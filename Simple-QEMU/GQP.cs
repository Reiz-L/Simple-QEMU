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
            FileStream fs = new FileStream(Application.StartupPath + "\\config.cfg",FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs,Encoding.Default);
            sw.Write(textBox1.Text);
            sw.Close();
            fs.Close();
            Close();
        }

        private void GQP_Load(object sender, EventArgs e)
        {

        }
    }
}
