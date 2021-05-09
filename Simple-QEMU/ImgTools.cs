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
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            if (!File.Exists(Application.StartupPath + "\\config.cfg"))
            {
                MessageBox.Show("你还没设置全局QEMU路径，请现在设置！","Warning!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                GQP gqp = new GQP();
                gqp.Show();
            }
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            if(File.Exists(Application.StartupPath + "\\config.cfg"))
            {
                if (textBoxac.Text != "" && textBox_bc.Text != "")
                {
                    StreamReader sr = new StreamReader(Application.StartupPath + "\\config.cfg", Encoding.Default);
                    String str = "";
                    str = sr.ReadToEnd();
                    sr.Close();
                    String[] str1 = str.Split(new string[] { "\n" }, StringSplitOptions.None);
                    String qemu_img = str1[0] + "\\qemu-img.exe";
                    String canshu = " convert -f " + comboBox2.SelectedItem.ToString() + " -O " + comboBox3.SelectedItem.ToString() + " \"" + textBox_bc.Text + "\" \"" + textBoxac.Text + "\"";

                    FileStream fs = new FileStream(Application.StartupPath + "\\convert.bat",FileMode.Create);
                    StreamWriter sw = new StreamWriter(fs,Encoding.Default);
                    sw.Write(qemu_img + canshu);
                    sw.Close();
                    fs.Close();

                    Process process = new Process();
                    process.StartInfo.FileName = ".\\convert.bat";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardInput = true;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;
                    process.StartInfo.CreateNoWindow = true;
                    process.Start();//启动程序                        
                    process.WaitForExit();//等待程序执行完退出进程                
                    process.Close();
                    MessageBox.Show("转换完成","Outputs",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("请检查配置是否正确！","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_bc.Text = openFileDialog1.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxac.Text = saveFileDialog1.FileName;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                 textBox3.Text = openFileDialog1.FileName;
                 if (File.Exists(Application.StartupPath + "\\config.cfg"))
                 {
                     StreamReader sr = new StreamReader(Application.StartupPath + "\\config.cfg", Encoding.Default);
                     String str = "";
                     str = sr.ReadToEnd();
                     sr.Close();
                     String[] str1 = str.Split(new string[] { "\n" }, StringSplitOptions.None);
                     String canshu = str1[0] + "\\qemu-img.exe" + " info \"" + openFileDialog1.FileName + "\"";

                     Process p1 = new Process();
                     p1.StartInfo.FileName = "cmd.exe";
                     p1.StartInfo.UseShellExecute = false;
                     p1.StartInfo.RedirectStandardInput = true;
                     p1.StartInfo.RedirectStandardOutput = true;
                     p1.StartInfo.RedirectStandardError = true;
                     p1.StartInfo.CreateNoWindow = true;
                     p1.Start();

                     p1.StandardInput.WriteLine(canshu + "&exit");
                     p1.StandardInput.AutoFlush = true;

                     p1.WaitForExit();
                     String outputs = p1.StandardOutput.ReadToEnd();
                     p1.Close();
                     
                     textBox4.Text = outputs;
                 }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox5.Text = openFileDialog1.FileName;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "" && textBox6.Text != "")
            {
                if (File.Exists(Application.StartupPath + "\\config.cfg"))
                {
                    StreamReader sr = new StreamReader(Application.StartupPath + "\\config.cfg", Encoding.Default);
                    String str = "";
                    str = sr.ReadToEnd();
                    sr.Close();
                    String[] str1 = str.Split(new string[] { "\n" }, StringSplitOptions.None);
                    String canshu = str1[0] + "\\qemu-img.exe" + " resize \"" + textBox5.Text + "\"" + " +" + textBox6.Text + "M";

                    Process p1 = new Process();
                    p1.StartInfo.FileName = "cmd.exe";
                    p1.StartInfo.UseShellExecute = false;
                    p1.StartInfo.RedirectStandardInput = true;
                    p1.StartInfo.RedirectStandardOutput = true;
                    p1.StartInfo.RedirectStandardError = true;
                    p1.StartInfo.CreateNoWindow = true;
                    p1.Start();

                    p1.StandardInput.WriteLine(canshu + "&exit");
                    p1.StandardInput.AutoFlush = true;

                    p1.WaitForExit();
                    String outputs = p1.StandardOutput.ReadToEnd();
                    p1.Close();
                    MessageBox.Show(outputs,"已完成!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "\\config.cfg"))
            {
                StreamReader sr = new StreamReader(Application.StartupPath + "\\config.cfg", Encoding.Default);
                String line = "";
                String AllStr = "";
                while ((line = sr.ReadLine()) != null)
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

                FileStream fs = new FileStream(Application.StartupPath + "\\images.bat", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                sw.Write(lastestStr);
                sw.Close();
                fs.Close();

                Process process = new Process();
                process.StartInfo.FileName = ".\\images.bat";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;
                process.Start();//启动程序                        
                process.WaitForExit();//等待程序执行完退出进程                
                process.Close();
                //MessageBox.Show(AllStr + "\\qemu-img.exe -f " + comboBox1.SelectedItem.ToString() + " " + Application.StartupPath +"\\images\\"+textBox1.Text + "."+comboBox1.SelectedItem.ToString() +" " + textBox2.Text + "M&exit","e");
                MessageBox.Show("生成完成！你的镜像在目录下的images文件夹中", "生成完成!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Close();
            }
        }
    }
}
