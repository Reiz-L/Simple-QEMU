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
            if (!File.Exists(".\\VMC\\" + Manager.pathstr + ".sqc"))
           {
               if (File.Exists(Application.StartupPath + "\\config.cfg"))
               {
                   StreamReader sr = new StreamReader(Application.StartupPath + "\\config.cfg", Encoding.Default);
                   String str = sr.ReadToEnd();
                   string[] strs = str.Split(new string[] { "\n" }, StringSplitOptions.None);
                   sr.Close();
                   comboBox_x86.SelectedIndex = 0;
                   comboBox_CPU.SelectedIndex = 0;
                   comboBox_vga.SelectedIndex = 0;
                   comboBox_sound.SelectedIndex = 0;
                   comboBox_network.SelectedIndex = 0;
                   comboBox1.SelectedIndex = 0;
                   textBox_QPath.Text = strs[0];
               }
               else
               {
                   MessageBox.Show("你没有设置全局QEMU路径请前往设置！","Error: Not Found QEMU Path",MessageBoxButtons.OK,MessageBoxIcon.Error);
                   Hide();
                   Simple_QEMU.GQP gqp = new Simple_QEMU.GQP();
                   gqp.Show();
                   Close();
                   
               }
            }
            else
           {
               try
               {
                   StreamReader sr = new StreamReader(".\\VMC\\" + Manager.pathstr + ".sqc", Encoding.Default);
                   String str1 = sr.ReadToEnd();
                   string[] str2 = str1.Split(new string[] { "\n" }, StringSplitOptions.None);
                   sr.Close();
                   textBox_name.Text = Manager.pathstr;
                   textBox_QPath.Text = str2[1];
                   comboBox_x86.SelectedIndex = Convert.ToInt32(str2[2]);
                   comboBox_CPU.SelectedIndex = Convert.ToInt32(str2[3]);
                   textBox_core.Text = str2[4];
                   textBox_mb.Text = str2[5];
                   t_D1.Text = str2[6];
                   t_D2.Text = str2[7];
                   t_D3.Text = str2[8];
                   t_D4.Text = str2[9];
                   t_cd.Text = str2[10];
                   comboBox_vga.SelectedIndex = Convert.ToInt32(str2[11]);
                   comboBox_sound.SelectedIndex = Convert.ToInt32(str2[12]);
                   comboBox_network.SelectedIndex = Convert.ToInt32(str2[13]);
                   checkBox_cd.Checked = Convert.ToBoolean(str2[14]);
                   checkBox1.Checked = Convert.ToBoolean(str2[15]);//vnc
                   textBox_sf.Text = str2[16];
                   checkBox_HAXM.Checked = Convert.ToBoolean(str2[17]);
               }
               catch(Exception e1)
               {
                   MessageBox.Show(e1.ToString(),"Error:1919",MessageBoxButtons.OK,MessageBoxIcon.Error);
               }
                //读取文件
                
            }
            if (!Directory.Exists(".\\VMC"))
            {
                Directory.CreateDirectory(".\\VMC");
            }
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
                    FileStream fs = new FileStream(Application.StartupPath + "\\VMS\\" + textBox_name.Text + ".bat", FileMode.Create);
                    StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                    FileStream fs1 = new FileStream(Application.StartupPath + "\\VMC\\" + textBox_name.Text + ".sqc",FileMode.Create);
                    StreamWriter sw1 = new StreamWriter(fs1,Encoding.Default); 
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
                    String soundhw = "";
                    String network;
                    String bootc;
                    String vnc;
                    String shareFolder = "";
                    String IsHAXM;
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
                        core = " -smp 1,sockets=" + textBox_core.Text + ",threads=" + textBox_core.Text;
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
                        if (Manager.lm == "5.x")
                        {
                            soundhw = " -device " + comboBox_sound.SelectedItem.ToString();
                        }
                        else if(Manager.lm == "4.x")
                        {
                            soundhw = " -soundhw " + comboBox_sound.SelectedItem.ToString();
                        }
                        
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
                    //=============HAXM==========
                    if(checkBox_HAXM.Checked)
                    {
                        IsHAXM = " -machine accel=hax";
                    }
                    else
                    {
                        IsHAXM = "";
                    }
                    //===========================
                    sw.Write("\"" + textBox_QPath.Text +"\\"+ jiagou + "\""+ " -L \"" + textBox_QPath.Text + "\"" + disk1 + disk2 + disk3 + disk4 +CDROM + bootc + Ram + vga + network + soundhw + CPUmodel + core + vnc + shareFolder + IsHAXM);
                    sw.Close();
                    fs.Close();
                    sw1.Write(textBox_name.Text + "\n" +  textBox_QPath.Text + "\n" + comboBox_x86.SelectedIndex.ToString() + "\n" + comboBox_CPU.SelectedIndex.ToString() + "\n" + textBox_core.Text + "\n" + textBox_mb.Text + "\n" + t_D1.Text + "\n" + t_D2.Text + "\n" + t_D3.Text + "\n" + t_D4.Text + "\n" + t_cd.Text + "\n" + comboBox_vga.SelectedIndex.ToString() + "\n" + comboBox_sound.SelectedIndex.ToString() + "\n" + comboBox_network.SelectedIndex.ToString() + "\n" + checkBox_cd.Checked.ToString() +"\n" + checkBox1.Checked.ToString() + "\n" + textBox_sf.Text + "\n" + checkBox_HAXM.Checked.ToString());
                    sw1.Close();
                    fs1.Close();
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

        private void button4_Click(object sender, EventArgs e)
        {
            Simple_QEMU.ImgTools imgtools = new Simple_QEMU.ImgTools();
            imgtools.Show();
        }

        private void checkBox_HAXM_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("请使用x86_64架构，并且确定你开启了Intel VT，如果没有开启请去BIOS里面打开", "必须要用Intel的CPU", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
