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
            string str = listBox1.SelectedItem.ToString();
            string[] str1 = str.Split(new string[] {"\\VMS\\"},StringSplitOptions.None);
            string[] str2 = str1[1].Split(new string[] {".bat"},StringSplitOptions.None);
            try
            {
                System.IO.File.Delete(@"" + listBox1.SelectedItem.ToString());
                System.IO.File.Delete(@".\\VMC\\" + str2[0] + ".sqc");
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
        public static string lm;//启动方式
        public static string filepath_edit;
        private void Manager_Load(object sender, EventArgs e)
        {
            
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
            
            if (File.Exists(".\\config.cfg"))
            {
                StreamReader sr = new StreamReader(Application.StartupPath + "\\config.cfg", Encoding.Default);
                String text1 = sr.ReadToEnd();
                sr.Close();
                string[] stext = text1.Split(new string[] { "\n" }, StringSplitOptions.None);
                if (stext.Length > 1)
                {
                    lm = stext[1];
                    //MessageBox.Show(lm,"a");
                }
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
            /*else if (lm == "5.x")
            {
                try
                {
                    StreamReader sr = new StreamReader(listBox1.SelectedItem.ToString(), Encoding.Default);
                    String str = sr.ReadToEnd();
                    sr.Close();
                    string[] sstr = str.Split(new string[] {"\n"},StringSplitOptions.None);
                    Process p1 = new Process();
                    p1.StartInfo.FileName = "cmd.exe";
                    p1.StartInfo.UseShellExecute = false;
                    p1.StartInfo.RedirectStandardInput = true;
                    p1.StartInfo.RedirectStandardOutput = true;
                    p1.StartInfo.RedirectStandardError = true;
                    p1.StartInfo.CreateNoWindow = true;
                    p1.Start();
                    
                    p1.StandardInput.WriteLine(sstr[0]+"&exit");
                    p1.StandardInput.AutoFlush = true;

                    p1.WaitForExit();
                    p1.Close();
                    String outputs = p1.StandardOutput.ReadToEnd();
                    textBox2.Text = outputs;

                }
                catch(Exception e1)
                {
                    MessageBox.Show(e1.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                

            }*/
            
        

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
        public static string pathstr;
        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                string[] str1;
                string[] str2;
                filepath_edit = listBox1.SelectedItem.ToString();
                str1 = filepath_edit.Split(new string[] {"\\VMS\\"}, StringSplitOptions.None);
                str2 = str1[1].Split(new string[] {".bat"},StringSplitOptions.None);
                pathstr = str2[0];
                //MessageBox.Show(pathstr,"a");
                NewVM newvm = new NewVM();
                newvm.Show();
            }
            else
            {
                MessageBox.Show("编辑不能","错误 Not Found",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            //暂时使用编辑框
            /*
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
            p.Close();*/
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
                MessageBox.Show("已完成！！！", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("你并没有选中一个列表项！！！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if(GetPidByProcessName("cmd.exe") == 0)

            if (System.Diagnostics.Process.GetProcessesByName("qemu-system-x86_64.exe").ToList().Count > 0)
            {
                String processName = "qemu-system-x86_64.exe";
                Process[] thisproc = Process.GetProcessesByName(processName);
                for (int i = 0; i < thisproc.Length; i++)
                {
                    thisproc[i].Kill();
                }
                    
                MessageBox.Show("已关闭!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (System.Diagnostics.Process.GetProcessesByName("qemu-system-i386.exe").ToList().Count > 0)
            {
                String processName = "qemu-system-i386.exe";
                Process[] thisproc = Process.GetProcessesByName(processName);
                for (int i = 0; i < thisproc.Length; i++)
                {
                    thisproc[i].Kill();
                }
                MessageBox.Show("已关闭!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Simple_QEMU.GQP gpq = new Simple_QEMU.GQP();
            gpq.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "\\HAXM\\silent_install.bat"))
            {
                Process p = new Process();
                p.StartInfo.FileName = Application.StartupPath + "\\HAXM\\silent_install.bat";
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.CreateNoWindow = false;
                p.Start();

               // p.StandardInput.WriteLine(Application.StartupPath + "\\HAXM\\silent_install.bat -log install.log");
               // p.StandardInput.AutoFlush = true;
               // p.WaitForExit();
                //String outputs = p.StandardOutput.ReadToEnd();
               // p.Close();
                
                MessageBox.Show("完成!如果不成功请自行手动安装!","输出信息",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            else
            {
                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.CreateNoWindow = true;
                p.Start();

                p.StandardInput.WriteLine("start https://github.com/intel/haxm/releases &exit");
                p.StandardInput.AutoFlush = true;
                p.WaitForExit();
                p.Close();
                MessageBox.Show("确保你是Win7 x64以上并且开启了Intel VT，请挑选一个windows版本进行下载，然后解压放入目录下的HAXM文件夹,用管理器权限启动并点击这个按钮", "下载", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (!Directory.Exists(Application.StartupPath + "\\HAXM"))
                {
                    Directory.CreateDirectory(Application.StartupPath + "\\HAXM");
                }

                
            }
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HAXM支持的硬件和系统:\n\rWindows 7/8/8.1/10 x64\n\rIntel 支持虚拟化技术的CPU", "HAXM支持的硬件和系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
