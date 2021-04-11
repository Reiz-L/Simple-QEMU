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

namespace SQEMU
{
    public partial class NewVM : Form
    {
        public NewVM()
        {
            InitializeComponent();
        }

        private void NewVM_Load(object sender, EventArgs e)
        {
            if (Manager.filepath_edit == "")
            {
                comboBox_x86.SelectedIndex = 0;
                comboBox_CPU.SelectedIndex = 0;
                comboBox_vga.SelectedIndex = 0;
                comboBox_sound.SelectedIndex = 0;
                comboBox_network.SelectedIndex = 0;
                comboBox1.SelectedIndex = 0;
                textBox_QPath.Text = Application.StartupPath + "\\qemu\\";
            }
            /*else
            {
                StreamReader sr = new StreamReader(Manager.filepath_edit,Encoding.Default);
                String lines = "";
                String allline = "";
                while((lines = sr.ReadLine()) != null)
                {
                    allline += lines + "\n\r";
                }
                sr.Close();
                //读取文件
                string[] filepath1 = Manager.filepath_edit.Split(new string[] {".\\VMS\\"},StringSplitOptions.None);
                textBox_name.Text = filepath1[1];
                string[] Qp = Manager.filepath_edit.Split(new string[]{"\\qemu-system"},StringSplitOptions.None);
                textBox_QPath.Text = Qp[0];
                string[] QV1 = allline.Split(new string []{"qemu\\"},StringSplitOptions.None);
                string[] Qv = QV1[1].Split(new string[] {" -hda"},StringSplitOptions.None);
                if (Qv[0] == "qemu-system-i386.exe")//qemu-system-i386.exe;qemu-system-x86_64.exe;qemu-system-arm.exe;qemu-system-aarch64.exe
                {
                    comboBox_x86.SelectedIndex = 0;
                }
                else if (Qv[0] == "qemu-system-x86_64.exe")
                {
                    comboBox_x86.SelectedIndex = 1;
                }
                else if (Qv[0] == "qemu-system-arm.exe")
                {
                    comboBox_x86.SelectedIndex = 2;
                }
                else if (Qv[0] == "qemu-system-aarch64.exe")
                {
                    comboBox_x86.SelectedIndex = 3;
                }
                string[] mb = allline.Split(new string[] {"-m "},StringSplitOptions.None);
                string[] mb1 = mb[1].Split(new string[] {" -vga"},StringSplitOptions.None);
                textBox_mb.Text = mb1[0];

                string[] cpucore = allline.Split(new string[] {" -smp "},StringSplitOptions.None);
                string[] cpuc2 = cpucore[1].Split(new string[] {" -vnc"},StringSplitOptions.None);
                textBox_core.Text = cpuc2[0];

                string[] hda = allline.Split(new string[]{"-hda "},StringSplitOptions.None);
                string[] hda1 = hda[1].Split(new string[] { " -hdb" }, StringSplitOptions.None);
                t_D1.Text = hda1[0];

                string[] hdb = allline.Split(new string[] { "-hdb " }, StringSplitOptions.None);
                string[] hdb1 = hdb[1].Split(new string[] { " -hdc" }, StringSplitOptions.None);
                t_D1.Text = hdb1[0];

                string[] hdc = allline.Split(new string[] { "-hdc " }, StringSplitOptions.None);
                string[] hdc1 = hda[1].Split(new string[] { " -hdd" }, StringSplitOptions.None);
                t_D1.Text = hdc1[0];

                string[] hdd = allline.Split(new string[] { "-hdd " }, StringSplitOptions.None);
                string[] hdd1 = hda[1].Split(new string[] { " -cdrom" }, StringSplitOptions.None);
                t_D1.Text = hdd1[0];
            }*/
            
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox_VNC.Enabled = true;
            }
            else
            {
                textBox_VNC.Enabled = false;
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Application.StartupPath + "\\VMS"))
            {
                if (textBox_name.Text != "")
                {
                    FileStream fs = new FileStream(Application.StartupPath + "\\VMS\\" + textBox_name.Text + ".bat", FileMode.OpenOrCreate);
                    StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                    String vmname = textBox_name.Text;
                    String Qemu = textBox_QPath.Text;
                    String jiagou;//架构
                    String CPUmodel;
                    String core = textBox_core.Text;
                    String Ram = " -m " + textBox_mb.Text;
                    String disk1 = t_D1.Text;
                    String disk2 = t_D2.Text;
                    String disk3 = t_D3.Text;
                    String disk4 = t_D4.Text;
                    String CDROM = t_cd.Text;
                    String vga;
                    String soundhw;
                    String network;
                    String bootc;
                    String vnc;
                    String shareFolder = "";
                    //===================磁盘
                    if(t_D1.Text != "")
                    {
                        disk1 = " -hda \"" + t_D1.Text+"\"";
                    }
                    if(t_D2.Text != "")
                    {
                        disk2 = " -hdb \"" + t_D2.Text + "\"";
                    }
                    if(t_D3.Text != "")
                    {
                        disk3 =  " -hdc \"" + t_D3.Text + "\"";
                    }
                    if(t_D4.Text != "")
                    {
                        disk4 = " -hdd \"" + t_D4.Text + "\"";
                    }
                    if (checkBox_cd.Checked)
                    {
                        bootc = " -boot d";
                    }
                    else{
                        bootc = "";
                    }
                    //==================架构
                    jiagou = comboBox_x86.SelectedItem.ToString();
                    //===========cores
                    if (textBox_core.Text != "1")
                    {
                        core = " -smp " + textBox_core.Text;
                    }
                    else
                    {
                        core = "";
                    }
                    //===================cpu
                    if(comboBox_CPU.SelectedIndex == 0)
                    {
                        CPUmodel = "";
                    }
                    else
                    {
                        CPUmodel = " -cpu " + comboBox_CPU.SelectedItem.ToString();
                    }
                    //============================vga=========
                    if (comboBox_vga.SelectedIndex == 3)
                    {
                        vga = "";
                    }
                    else
                    {
                        vga = " -vga " + comboBox_vga.SelectedItem.ToString();
                    }

                    //=========================sound===========
                    if (comboBox_sound.SelectedIndex == 0)
                    {
                        soundhw = "";
                    }
                    else
                    {
                        soundhw = " -device " + comboBox_sound.SelectedItem.ToString();
                    }
                    network = " -net user" + " -net nic,model=" + comboBox1.SelectedItem.ToString();
                    //===============vnc==================
                    if (checkBox1.Checked)
                    {
                        vnc = " -vnc :" + textBox_VNC.Text + " ";
                    }
                    else
                    {
                        vnc = "";
                    }
                    //===========共享文件夹=============
                    if(textBox_sf.Text != "")
                    {
                        shareFolder = " " + textBox_sf.Text;
                    }
                    //===========CDROM===============
                    if(t_cd.Text != "")
                    {
                        CDROM = " -cdrom " + t_cd.Text;

                    }
                    else
                    {
                        CDROM = "";
                    }
                    //=========================
                    sw.Write("\"" + textBox_QPath.Text +"\\"+ jiagou + "\""+ " -L \"" + textBox_QPath.Text + "\"" + disk1 + disk2 + disk3 + disk4 +CDROM + bootc + Ram + vga + network + soundhw + CPUmodel +core + vnc + shareFolder);
                    sw.Close();
                    fs.Close();
                    Close();
                }
                
            }
            else
            {
                MessageBox.Show("目录VMS不存在，已经自动创建","message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Directory.CreateDirectory(Application.StartupPath + "\\VMS");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void NewVM_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button_d2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                t_D2.Text = openFileDialog1.FileName;

            }
        }

        private void button_d3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                t_D3.Text = openFileDialog1.FileName;

            }
        }

        private void button_d4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                t_D4.Text = openFileDialog1.FileName;

            }
        }

        private void button_cd_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                t_cd.Text = openFileDialog1.FileName;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_QPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button_d1_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                t_D1.Text = openFileDialog1.FileName;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("一定要写没有特殊符号以及空格的路径\n不能和硬盘4共同使用！","Warning",MessageBoxButtons.OK,MessageBoxIcon.Information);
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_sf.Text = "-hdd fat:rw:" + folderBrowserDialog1.SelectedPath;
            }
        }

        
    }
}
