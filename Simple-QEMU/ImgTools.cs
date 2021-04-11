using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Simple_QEMU
{
    public partial class ImgTools : Form
    {
        public ImgTools()
        {
            InitializeComponent();
        }

        private void imgTools_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(Application.StartupPath + "\\images"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\images");
            }
            comboBox1.SelectedIndex = 0;
            if (!File.Exists(Application.StartupPath + "\\config.cfg"))
            {
                MessageBox.Show("你还没设置全局QEMU路径，请现在设置！","Warning!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                GQP gqp = new GQP();
                gqp.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (File.Exists(Application.StartupPath + "\\config.cfg"))
            {
                StreamReader sr = new StreamReader(Application.StartupPath + "\\config.cfg",Encoding.Default);
                String line = "";
                String AllStr = "";
                while((line = sr.ReadLine()) != null)
                {
                    AllStr += line + "\n\r";
                }
                sr.Close();
                string[] allstr1 = AllStr.Split(new string[] { "\n\r" }, StringSplitOptions.None);
                String imgexepath = allstr1[0] + "\\qemu-img.exe";
                String imgexep2 = "\"" + imgexepath + "\"" + " create -f ";
                String name = textBox1.Text;
                String type = comboBox1.SelectedItem.ToString();
                String Size = textBox2.Text + "M";
                String lastestStr = imgexep2 + type + " \"" + Application.StartupPath + "\\images\\" + name + "." + type + "\" " + Size;

                FileStream fs = new FileStream(Application.StartupPath + "\\images.bat",FileMode.Create);
                StreamWriter sw = new StreamWriter(fs,Encoding.Default);
                sw.Write(lastestStr);
                sw.Close();
                fs.Close();
                                      
                Process process = new Process();         
                process.StartInfo.FileName = ".\\images.bat";                
                process.StartInfo.UseShellExecute = false;                
                process.StartInfo.RedirectStandardInput = true;                
                process.StartInfo.RedirectStandardOutput = true;                
                process.StartInfo.RedirectStandardError = true;                
                process.StartInfo.CreateNoWindow = false;                
                process.Start();//启动程序                        
                process.WaitForExit();//等待程序执行完退出进程                
                process.Close();
                //MessageBox.Show(AllStr + "\\qemu-img.exe -f " + comboBox1.SelectedItem.ToString() + " " + Application.StartupPath +"\\images\\"+textBox1.Text + "."+comboBox1.SelectedItem.ToString() +" " + textBox2.Text + "M&exit","e");
                MessageBox.Show("生成完成！请不要动目录下的images.bat文件", "生成完成!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}
