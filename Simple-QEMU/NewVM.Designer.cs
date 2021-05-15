namespace SQEMU
{
    partial class NewVM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_QPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_x86 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_CPU = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_core = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_mb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.t_D1 = new System.Windows.Forms.TextBox();
            this.button_d1 = new System.Windows.Forms.Button();
            this.button_d2 = new System.Windows.Forms.Button();
            this.t_D2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button_d3 = new System.Windows.Forms.Button();
            this.t_D3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button_d4 = new System.Windows.Forms.Button();
            this.t_D4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button_cd = new System.Windows.Forms.Button();
            this.t_cd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label_GC = new System.Windows.Forms.Label();
            this.comboBox_vga = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox_sound = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox_network = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_VNC = new System.Windows.Forms.TextBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox_cd = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_sf = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBox_HAXM = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "新建/编辑虚拟机";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(28, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "虚拟机名称:";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(105, 35);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(121, 21);
            this.textBox_name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(28, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Qemu路径:";
            // 
            // textBox_QPath
            // 
            this.textBox_QPath.Location = new System.Drawing.Point(93, 59);
            this.textBox_QPath.Name = "textBox_QPath";
            this.textBox_QPath.Size = new System.Drawing.Size(226, 21);
            this.textBox_QPath.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(28, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "系统架构:";
            // 
            // comboBox_x86
            // 
            this.comboBox_x86.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_x86.FormattingEnabled = true;
            this.comboBox_x86.Items.AddRange(new object[] {
            "qemu-system-i386.exe",
            "qemu-system-x86_64.exe",
            "qemu-system-arm.exe",
            "qemu-system-aarch64.exe"});
            this.comboBox_x86.Location = new System.Drawing.Point(93, 86);
            this.comboBox_x86.Name = "comboBox_x86";
            this.comboBox_x86.Size = new System.Drawing.Size(147, 20);
            this.comboBox_x86.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(246, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "模拟CPU:";
            // 
            // comboBox_CPU
            // 
            this.comboBox_CPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CPU.FormattingEnabled = true;
            this.comboBox_CPU.Items.AddRange(new object[] {
            "默认",
            "qemu32",
            "qemu64",
            "kvm32",
            "kvm64",
            "coreduo",
            "core2duo",
            "486",
            "pentium",
            "pentium2",
            "pentium3",
            "athlon",
            "n270",
            "Penryn",
            "SandyBridge",
            "Opteron_G4",
            "Opteron_G5"});
            this.comboBox_CPU.Location = new System.Drawing.Point(298, 86);
            this.comboBox_CPU.Name = "comboBox_CPU";
            this.comboBox_CPU.Size = new System.Drawing.Size(82, 20);
            this.comboBox_CPU.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(28, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "CPU核心:";
            // 
            // textBox_core
            // 
            this.textBox_core.Location = new System.Drawing.Point(87, 111);
            this.textBox_core.Name = "textBox_core";
            this.textBox_core.Size = new System.Drawing.Size(82, 21);
            this.textBox_core.TabIndex = 11;
            this.textBox_core.Text = "1";
            this.textBox_core.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(185, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "RAM:";
            // 
            // textBox_mb
            // 
            this.textBox_mb.Location = new System.Drawing.Point(220, 112);
            this.textBox_mb.Name = "textBox_mb";
            this.textBox_mb.Size = new System.Drawing.Size(79, 21);
            this.textBox_mb.TabIndex = 13;
            this.textBox_mb.Text = "256";
            this.textBox_mb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(305, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "MB";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(28, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "硬盘1:";
            // 
            // t_D1
            // 
            this.t_D1.Location = new System.Drawing.Point(69, 139);
            this.t_D1.Name = "t_D1";
            this.t_D1.Size = new System.Drawing.Size(250, 21);
            this.t_D1.TabIndex = 16;
            // 
            // button_d1
            // 
            this.button_d1.Location = new System.Drawing.Point(325, 137);
            this.button_d1.Name = "button_d1";
            this.button_d1.Size = new System.Drawing.Size(31, 23);
            this.button_d1.TabIndex = 17;
            this.button_d1.Text = "..";
            this.button_d1.UseVisualStyleBackColor = true;
            this.button_d1.Click += new System.EventHandler(this.button_d1_Click_1);
            // 
            // button_d2
            // 
            this.button_d2.Location = new System.Drawing.Point(325, 164);
            this.button_d2.Name = "button_d2";
            this.button_d2.Size = new System.Drawing.Size(31, 23);
            this.button_d2.TabIndex = 21;
            this.button_d2.Text = "..";
            this.button_d2.UseVisualStyleBackColor = true;
            this.button_d2.Click += new System.EventHandler(this.button_d2_Click);
            // 
            // t_D2
            // 
            this.t_D2.Location = new System.Drawing.Point(69, 166);
            this.t_D2.Name = "t_D2";
            this.t_D2.Size = new System.Drawing.Size(250, 21);
            this.t_D2.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(28, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "硬盘2:";
            // 
            // button_d3
            // 
            this.button_d3.Location = new System.Drawing.Point(325, 191);
            this.button_d3.Name = "button_d3";
            this.button_d3.Size = new System.Drawing.Size(31, 23);
            this.button_d3.TabIndex = 25;
            this.button_d3.Text = "..";
            this.button_d3.UseVisualStyleBackColor = true;
            this.button_d3.Click += new System.EventHandler(this.button_d3_Click);
            // 
            // t_D3
            // 
            this.t_D3.Location = new System.Drawing.Point(69, 193);
            this.t_D3.Name = "t_D3";
            this.t_D3.Size = new System.Drawing.Size(250, 21);
            this.t_D3.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(28, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 23;
            this.label11.Text = "硬盘3:";
            // 
            // button_d4
            // 
            this.button_d4.Location = new System.Drawing.Point(325, 218);
            this.button_d4.Name = "button_d4";
            this.button_d4.Size = new System.Drawing.Size(31, 23);
            this.button_d4.TabIndex = 29;
            this.button_d4.Text = "..";
            this.button_d4.UseVisualStyleBackColor = true;
            this.button_d4.Click += new System.EventHandler(this.button_d4_Click);
            // 
            // t_D4
            // 
            this.t_D4.Location = new System.Drawing.Point(69, 220);
            this.t_D4.Name = "t_D4";
            this.t_D4.Size = new System.Drawing.Size(250, 21);
            this.t_D4.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(28, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 27;
            this.label12.Text = "硬盘4:";
            // 
            // button_cd
            // 
            this.button_cd.Location = new System.Drawing.Point(325, 245);
            this.button_cd.Name = "button_cd";
            this.button_cd.Size = new System.Drawing.Size(31, 23);
            this.button_cd.TabIndex = 33;
            this.button_cd.Text = "..";
            this.button_cd.UseVisualStyleBackColor = true;
            this.button_cd.Click += new System.EventHandler(this.button_cd_Click);
            // 
            // t_cd
            // 
            this.t_cd.Location = new System.Drawing.Point(69, 247);
            this.t_cd.Name = "t_cd";
            this.t_cd.Size = new System.Drawing.Size(250, 21);
            this.t_cd.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(16, 250);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 12);
            this.label13.TabIndex = 31;
            this.label13.Text = "CD-ROM:";
            // 
            // label_GC
            // 
            this.label_GC.AutoSize = true;
            this.label_GC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_GC.Location = new System.Drawing.Point(16, 277);
            this.label_GC.Name = "label_GC";
            this.label_GC.Size = new System.Drawing.Size(53, 12);
            this.label_GC.TabIndex = 34;
            this.label_GC.Text = "vga显卡:";
            // 
            // comboBox_vga
            // 
            this.comboBox_vga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_vga.FormattingEnabled = true;
            this.comboBox_vga.Items.AddRange(new object[] {
            "std",
            "cirrus",
            "vmware",
            "qxl",
            "none"});
            this.comboBox_vga.Location = new System.Drawing.Point(69, 274);
            this.comboBox_vga.Name = "comboBox_vga";
            this.comboBox_vga.Size = new System.Drawing.Size(100, 20);
            this.comboBox_vga.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(185, 277);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 12);
            this.label14.TabIndex = 36;
            this.label14.Text = "声卡:";
            // 
            // comboBox_sound
            // 
            this.comboBox_sound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sound.FormattingEnabled = true;
            this.comboBox_sound.Items.AddRange(new object[] {
            "None",
            "sb16",
            "ac97",
            "es1370",
            "all"});
            this.comboBox_sound.Location = new System.Drawing.Point(220, 274);
            this.comboBox_sound.Name = "comboBox_sound";
            this.comboBox_sound.Size = new System.Drawing.Size(79, 20);
            this.comboBox_sound.TabIndex = 37;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(16, 304);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 12);
            this.label15.TabIndex = 38;
            this.label15.Text = "网络:";
            // 
            // comboBox_network
            // 
            this.comboBox_network.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_network.FormattingEnabled = true;
            this.comboBox_network.Items.AddRange(new object[] {
            "None",
            "User",
            "TAP(暂未支持)"});
            this.comboBox_network.Location = new System.Drawing.Point(57, 300);
            this.comboBox_network.Name = "comboBox_network";
            this.comboBox_network.Size = new System.Drawing.Size(96, 20);
            this.comboBox_network.TabIndex = 39;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox1.Location = new System.Drawing.Point(171, 302);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 16);
            this.checkBox1.TabIndex = 40;
            this.checkBox1.Text = "启用VNC";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(252, 304);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 12);
            this.label16.TabIndex = 41;
            this.label16.Text = "VNC端口";
            // 
            // textBox_VNC
            // 
            this.textBox_VNC.Enabled = false;
            this.textBox_VNC.Location = new System.Drawing.Point(301, 300);
            this.textBox_VNC.Name = "textBox_VNC";
            this.textBox_VNC.Size = new System.Drawing.Size(69, 21);
            this.textBox_VNC.TabIndex = 42;
            this.textBox_VNC.Text = "0";
            this.textBox_VNC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(128, 384);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 43;
            this.button_Save.Text = "完成";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(209, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 44;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox_cd
            // 
            this.checkBox_cd.AutoSize = true;
            this.checkBox_cd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox_cd.Location = new System.Drawing.Point(323, 276);
            this.checkBox_cd.Name = "checkBox_cd";
            this.checkBox_cd.Size = new System.Drawing.Size(84, 16);
            this.checkBox_cd.TabIndex = 45;
            this.checkBox_cd.Text = "从光盘启动";
            this.checkBox_cd.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(22, 332);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 12);
            this.label17.TabIndex = 46;
            this.label17.Text = "网卡:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "none",
            "ne2k_pci",
            "i82551",
            "i82557b",
            "i82559er",
            "rtl8139",
            "e1000",
            "pcnet",
            "virtio"});
            this.comboBox1.Location = new System.Drawing.Point(57, 329);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 47;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "文件|*.*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(190, 332);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 12);
            this.label18.TabIndex = 48;
            this.label18.Text = "共享文件夹:";
            // 
            // textBox_sf
            // 
            this.textBox_sf.Location = new System.Drawing.Point(256, 327);
            this.textBox_sf.Name = "textBox_sf";
            this.textBox_sf.Size = new System.Drawing.Size(100, 21);
            this.textBox_sf.TabIndex = 49;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(362, 325);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 23);
            this.button3.TabIndex = 50;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(328, 112);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 23);
            this.button4.TabIndex = 51;
            this.button4.Text = "创建磁盘镜像";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkBox_HAXM
            // 
            this.checkBox_HAXM.AutoSize = true;
            this.checkBox_HAXM.ForeColor = System.Drawing.Color.White;
            this.checkBox_HAXM.Location = new System.Drawing.Point(142, 355);
            this.checkBox_HAXM.Name = "checkBox_HAXM";
            this.checkBox_HAXM.Size = new System.Drawing.Size(72, 16);
            this.checkBox_HAXM.TabIndex = 52;
            this.checkBox_HAXM.Text = "启用HAXM";
            this.checkBox_HAXM.UseVisualStyleBackColor = true;
            this.checkBox_HAXM.CheckedChanged += new System.EventHandler(this.checkBox_HAXM_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(22, 356);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(119, 12);
            this.label19.TabIndex = 53;
            this.label19.Text = "Intel VT虚拟化技术:";
            // 
            // NewVM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(441, 419);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.checkBox_HAXM);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox_sf);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.checkBox_cd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.textBox_VNC);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox_network);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBox_sound);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBox_vga);
            this.Controls.Add(this.label_GC);
            this.Controls.Add(this.button_cd);
            this.Controls.Add(this.t_cd);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button_d4);
            this.Controls.Add(this.t_D4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button_d3);
            this.Controls.Add(this.t_D3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button_d2);
            this.Controls.Add(this.t_D2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button_d1);
            this.Controls.Add(this.t_D1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_mb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_core);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_CPU);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_x86);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_QPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewVM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewVM";
            this.Load += new System.EventHandler(this.NewVM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_QPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_x86;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_CPU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_core;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_mb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox t_D1;
        private System.Windows.Forms.Button button_d1;
        private System.Windows.Forms.Button button_d2;
        private System.Windows.Forms.TextBox t_D2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_d3;
        private System.Windows.Forms.TextBox t_D3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_d4;
        private System.Windows.Forms.TextBox t_D4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_cd;
        private System.Windows.Forms.TextBox t_cd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_GC;
        private System.Windows.Forms.ComboBox comboBox_vga;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox_sound;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox_network;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_VNC;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox_cd;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox_sf;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBox_HAXM;
        private System.Windows.Forms.Label label19;
    }
}