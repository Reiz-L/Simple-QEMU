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
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace SQEMU
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void Manager_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Form1().Show();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.File.Delete(@"" + listBox1.SelectedItem.ToString());
                listBox1.Items.Remove(listBox1.SelectedItem);
                textBox1.Text = "";
                textBox1.Enabled = false;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewVM new1 = new NewVM();
            new1.Show();
        }
        public static string filepath_edit;
        private void Manager_Load(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button4.Enabled = false;
            filepath_edit = "";
            if (Directory.Exists(@".\\VMS"))
            {
                string[] Files = Directory.GetFiles(@".\\VMS");
                foreach (string filePath in Files)
                {
                    listBox1.Items.Add(filePath);

                }
            }
            else
            {
                Directory.CreateDirectory(@".\\VMS");
            }
            
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            string[] Files = Directory.GetFiles(@".\\VMS");
            foreach (string filePath in Files)
            {
                listBox1.Items.Add(filePath);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Process process = new Process();
                process.StartInfo.FileName = listBox1.SelectedItem.ToString();
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;
                process.Start();//启动程序                        
                //process.WaitForExit();//等待程序执行完退出进程                
                //process.Close();
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                StreamReader sr = new StreamReader(listBox1.SelectedItem.ToString(), Encoding.Default);
                String textLine = "";
                String str_canshu = "";
                while ((textLine = sr.ReadLine()) != null)
                {
                    str_canshu += textLine + "\n\r";
                }
                sr.Close();
                String str1 = listBox1.SelectedItem.ToString();
                string[] sArr = str_canshu.Split(new string[] { " " }, StringSplitOptions.None);
                //String wzstr = "";
                String xnjstr = "";
                for (int i = 0; i < sArr.Length; i++)
                {
                    //wzstr += sArr[i] + "\n\r";
                    xnjstr += sArr[i] + " ";
                }
                label1.Text = "选中虚拟机:" + str1;
                textBox1.Text = xnjstr;
                label2.Visible = false;
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
                label1.Text = "目前没有虚拟机！！！";
                label2.Visible = true;
            }
            
            
        }

        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* if (listBox1.SelectedIndex > -1)
            {
               // filepath_edit = listBox1.SelectedItem.ToString();
                //NewVM newvm = new NewVM();
                //newvm.Show();
            }
            else
            {
                MessageBox.Show("编辑不能","错误 Not Found",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }*/
            //暂时使用编辑框
            //MessageBox.Show("因为我懒，本来创建虚拟机的窗口是拿来编辑的，代码写了很多，但是没写完算了干脆编辑框自己编辑", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            p.StandardInput.WriteLine("notepad " + listBox1.SelectedItem.ToString() + "&exit");
            p.StandardInput.AutoFlush = true;
            p.WaitForExit();
            p.Close();
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                FileStream fs = new FileStream(listBox1.SelectedItem.ToString(), FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                sw.Write(textBox1.Text);
                sw.Close();
                fs.Close();
            }
            else
            {
                MessageBox.Show("你并没有选中一个列表项！！！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if(GetPidByProcessName("cmd.exe") == 0)
            MessageBox.Show("暂未实现！请手动关闭！","Under Construction",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Simple_QEMU.GQP gpq = new Simple_QEMU.GQP();
            gpq.Show();
        }
    }
}
