namespace HDPLC_TEST
{
    partial class HDPLC_Information_Collector
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HDPLC_Information_Collector));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btn_OpenSer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_RefMac = new System.Windows.Forms.TextBox();
            this.btn_getRefMac = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cleardev = new System.Windows.Forms.Button();
            this.lab_date = new System.Windows.Forms.Label();
            this.btn_getAll = new System.Windows.Forms.Button();
            this.cb_Port = new System.Windows.Forms.ComboBox();
            this.cb_BaudRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_showprint = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.l_RxBytes = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_DutMac = new System.Windows.Forms.TextBox();
            this.btn_getDutMac = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_PhyRate = new System.Windows.Forms.TextBox();
            this.btn_GetPhyRate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tb_current = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_voltage1 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tb_voltage2 = new System.Windows.Forms.TextBox();
            this.btn_SetMac = new System.Windows.Forms.Button();
            this.tb_MacToBeSet = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dutmac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_refmac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_phyrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_vol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_vol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_AddRecord = new System.Windows.Forms.Button();
            this.btn_ExportData = new System.Windows.Forms.Button();
            this.btn_DeleteRecord = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lab_cur_res = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lab_vol2_res = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lab_vol1_res = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lab_result = new System.Windows.Forms.Label();
            this.lab_phyrate_res = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置门限值ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.测试模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自动测试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.手动测试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.串口配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_ser = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lab_preset_cur = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.lab_preset_vol2 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lab_preset_vol1 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lab_preset_phyrate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lab_testmodel = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lab_FailureCount = new System.Windows.Forms.Label();
            this.lab_FailureRate = new System.Windows.Forms.Label();
            this.串口信息ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.显示串口信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.隐藏串口信息ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.串口命令ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel_ser.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btn_OpenSer
            // 
            this.btn_OpenSer.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenSer.Location = new System.Drawing.Point(381, 44);
            this.btn_OpenSer.Name = "btn_OpenSer";
            this.btn_OpenSer.Size = new System.Drawing.Size(86, 33);
            this.btn_OpenSer.TabIndex = 0;
            this.btn_OpenSer.Text = "打开串口";
            this.btn_OpenSer.UseVisualStyleBackColor = true;
            this.btn_OpenSer.Click += new System.EventHandler(this.btn_OpenSer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("NSimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "测试日期:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NSimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "不良品数:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("NSimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(13, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "不良率:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("NSimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(5, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 14);
            this.label7.TabIndex = 8;
            this.label7.Text = "参考板MAC:";
            // 
            // tb_RefMac
            // 
            this.tb_RefMac.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_RefMac.Location = new System.Drawing.Point(86, 33);
            this.tb_RefMac.Name = "tb_RefMac";
            this.tb_RefMac.Size = new System.Drawing.Size(136, 21);
            this.tb_RefMac.TabIndex = 9;
            // 
            // btn_getRefMac
            // 
            this.btn_getRefMac.Font = new System.Drawing.Font("NSimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_getRefMac.Location = new System.Drawing.Point(237, 31);
            this.btn_getRefMac.Name = "btn_getRefMac";
            this.btn_getRefMac.Size = new System.Drawing.Size(75, 23);
            this.btn_getRefMac.TabIndex = 10;
            this.btn_getRefMac.Text = "发送命令";
            this.btn_getRefMac.UseVisualStyleBackColor = true;
            this.btn_getRefMac.Click += new System.EventHandler(this.btn_getRefMac_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lab_FailureRate);
            this.groupBox1.Controls.Add(this.lab_FailureCount);
            this.groupBox1.Controls.Add(this.lab_testmodel);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.btn_cleardev);
            this.groupBox1.Controls.Add(this.lab_date);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_getAll);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(643, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 260);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息统计";
            // 
            // btn_cleardev
            // 
            this.btn_cleardev.Font = new System.Drawing.Font("NSimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_cleardev.Location = new System.Drawing.Point(100, 219);
            this.btn_cleardev.Name = "btn_cleardev";
            this.btn_cleardev.Size = new System.Drawing.Size(86, 33);
            this.btn_cleardev.TabIndex = 32;
            this.btn_cleardev.Text = "清空";
            this.btn_cleardev.UseVisualStyleBackColor = true;
            this.btn_cleardev.Click += new System.EventHandler(this.btn_ClearDevice_Click);
            // 
            // lab_date
            // 
            this.lab_date.AutoSize = true;
            this.lab_date.Font = new System.Drawing.Font("NSimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_date.Location = new System.Drawing.Point(122, 39);
            this.lab_date.Name = "lab_date";
            this.lab_date.Size = new System.Drawing.Size(77, 14);
            this.lab_date.TabIndex = 30;
            this.lab_date.Text = "2015/10/28";
            // 
            // btn_getAll
            // 
            this.btn_getAll.Font = new System.Drawing.Font("NSimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_getAll.Location = new System.Drawing.Point(217, 219);
            this.btn_getAll.Name = "btn_getAll";
            this.btn_getAll.Size = new System.Drawing.Size(86, 33);
            this.btn_getAll.TabIndex = 31;
            this.btn_getAll.Text = "开始";
            this.btn_getAll.UseVisualStyleBackColor = true;
            this.btn_getAll.Click += new System.EventHandler(this.btn_getAll_Click);
            // 
            // cb_Port
            // 
            this.cb_Port.FormattingEnabled = true;
            this.cb_Port.Location = new System.Drawing.Point(64, 51);
            this.cb_Port.Name = "cb_Port";
            this.cb_Port.Size = new System.Drawing.Size(101, 20);
            this.cb_Port.TabIndex = 12;
            // 
            // cb_BaudRate
            // 
            this.cb_BaudRate.FormattingEnabled = true;
            this.cb_BaudRate.Location = new System.Drawing.Point(243, 50);
            this.cb_BaudRate.Name = "cb_BaudRate";
            this.cb_BaudRate.Size = new System.Drawing.Size(114, 20);
            this.cb_BaudRate.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(21, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "端口";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(183, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "波特率";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(7, 33);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(392, 238);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // btn_showprint
            // 
            this.btn_showprint.Location = new System.Drawing.Point(322, 277);
            this.btn_showprint.Name = "btn_showprint";
            this.btn_showprint.Size = new System.Drawing.Size(75, 23);
            this.btn_showprint.TabIndex = 17;
            this.btn_showprint.Text = "刷新";
            this.btn_showprint.UseVisualStyleBackColor = true;
            this.btn_showprint.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "清空";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "接收字节：";
            // 
            // l_RxBytes
            // 
            this.l_RxBytes.AutoSize = true;
            this.l_RxBytes.Location = new System.Drawing.Point(99, 282);
            this.l_RxBytes.Name = "l_RxBytes";
            this.l_RxBytes.Size = new System.Drawing.Size(11, 12);
            this.l_RxBytes.TabIndex = 20;
            this.l_RxBytes.Text = "0";
            this.l_RxBytes.TextChanged += new System.EventHandler(this.l_RxBytes_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("NSimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(6, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 14);
            this.label11.TabIndex = 23;
            this.label11.Text = "待测板MAC:";
            // 
            // tb_DutMac
            // 
            this.tb_DutMac.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_DutMac.Location = new System.Drawing.Point(86, 72);
            this.tb_DutMac.Name = "tb_DutMac";
            this.tb_DutMac.Size = new System.Drawing.Size(136, 21);
            this.tb_DutMac.TabIndex = 25;
            // 
            // btn_getDutMac
            // 
            this.btn_getDutMac.Font = new System.Drawing.Font("NSimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_getDutMac.Location = new System.Drawing.Point(237, 70);
            this.btn_getDutMac.Name = "btn_getDutMac";
            this.btn_getDutMac.Size = new System.Drawing.Size(75, 23);
            this.btn_getDutMac.TabIndex = 26;
            this.btn_getDutMac.Text = "发送命令";
            this.btn_getDutMac.UseVisualStyleBackColor = true;
            this.btn_getDutMac.Click += new System.EventHandler(this.btn_getDutMac_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("NSimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(6, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 14);
            this.label10.TabIndex = 27;
            this.label10.Text = "PHY速度：";
            // 
            // tb_PhyRate
            // 
            this.tb_PhyRate.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_PhyRate.Location = new System.Drawing.Point(87, 111);
            this.tb_PhyRate.Name = "tb_PhyRate";
            this.tb_PhyRate.Size = new System.Drawing.Size(136, 21);
            this.tb_PhyRate.TabIndex = 28;
            // 
            // btn_GetPhyRate
            // 
            this.btn_GetPhyRate.Font = new System.Drawing.Font("NSimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_GetPhyRate.Location = new System.Drawing.Point(237, 108);
            this.btn_GetPhyRate.Name = "btn_GetPhyRate";
            this.btn_GetPhyRate.Size = new System.Drawing.Size(75, 23);
            this.btn_GetPhyRate.TabIndex = 29;
            this.btn_GetPhyRate.Text = "发送命令";
            this.btn_GetPhyRate.UseVisualStyleBackColor = true;
            this.btn_GetPhyRate.Click += new System.EventHandler(this.btn_GetPhyRate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.tb_current);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.tb_PhyRate);
            this.groupBox2.Controls.Add(this.tb_voltage1);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.btn_getRefMac);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tb_voltage2);
            this.groupBox2.Controls.Add(this.tb_RefMac);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btn_getDutMac);
            this.groupBox2.Controls.Add(this.btn_GetPhyRate);
            this.groupBox2.Controls.Add(this.tb_DutMac);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(14, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 263);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设备参数";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("NSimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.Location = new System.Drawing.Point(238, 233);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 14);
            this.label22.TabIndex = 49;
            this.label22.Text = "单位（mA）";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("NSimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(237, 195);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 14);
            this.label21.TabIndex = 48;
            this.label21.Text = "单位（mV）";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("NSimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(237, 151);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 14);
            this.label20.TabIndex = 47;
            this.label20.Text = "单位（mV）";
            // 
            // tb_current
            // 
            this.tb_current.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_current.Location = new System.Drawing.Point(87, 230);
            this.tb_current.Name = "tb_current";
            this.tb_current.Size = new System.Drawing.Size(136, 21);
            this.tb_current.TabIndex = 46;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("NSimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(6, 233);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 14);
            this.label17.TabIndex = 45;
            this.label17.Text = "整板电流:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("NSimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(6, 152);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 14);
            this.label18.TabIndex = 39;
            this.label18.Text = "额定电压1:";
            // 
            // tb_voltage1
            // 
            this.tb_voltage1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_voltage1.Location = new System.Drawing.Point(87, 148);
            this.tb_voltage1.Name = "tb_voltage1";
            this.tb_voltage1.Size = new System.Drawing.Size(136, 21);
            this.tb_voltage1.TabIndex = 40;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("NSimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(6, 194);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 14);
            this.label19.TabIndex = 42;
            this.label19.Text = "额定电压2:";
            // 
            // tb_voltage2
            // 
            this.tb_voltage2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_voltage2.Location = new System.Drawing.Point(86, 190);
            this.tb_voltage2.Name = "tb_voltage2";
            this.tb_voltage2.Size = new System.Drawing.Size(136, 21);
            this.tb_voltage2.TabIndex = 43;
            // 
            // btn_SetMac
            // 
            this.btn_SetMac.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SetMac.Location = new System.Drawing.Point(382, 91);
            this.btn_SetMac.Name = "btn_SetMac";
            this.btn_SetMac.Size = new System.Drawing.Size(86, 33);
            this.btn_SetMac.TabIndex = 35;
            this.btn_SetMac.Text = "设置";
            this.btn_SetMac.UseVisualStyleBackColor = true;
            this.btn_SetMac.Click += new System.EventHandler(this.btn_SetMac_Click);
            // 
            // tb_MacToBeSet
            // 
            this.tb_MacToBeSet.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_MacToBeSet.Location = new System.Drawing.Point(139, 97);
            this.tb_MacToBeSet.Name = "tb_MacToBeSet";
            this.tb_MacToBeSet.Size = new System.Drawing.Size(218, 23);
            this.tb_MacToBeSet.TabIndex = 34;
            this.tb_MacToBeSet.TextChanged += new System.EventHandler(this.tb_MacToBeSet_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(21, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 20);
            this.label13.TabIndex = 33;
            this.label13.Text = "修改MAC地址";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_num,
            this.col_dutmac,
            this.col_refmac,
            this.col_phyrate,
            this.col_vol1,
            this.col_vol2,
            this.col_cur,
            this.col_result,
            this.col_info,
            this.col_time});
            this.dataGridView1.Location = new System.Drawing.Point(15, 440);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(944, 236);
            this.dataGridView1.TabIndex = 31;
            // 
            // col_num
            // 
            this.col_num.HeaderText = "序号";
            this.col_num.Name = "col_num";
            this.col_num.Width = 55;
            // 
            // col_dutmac
            // 
            this.col_dutmac.HeaderText = "MAC地址";
            this.col_dutmac.Name = "col_dutmac";
            // 
            // col_refmac
            // 
            this.col_refmac.HeaderText = "参考版MAC";
            this.col_refmac.Name = "col_refmac";
            // 
            // col_phyrate
            // 
            this.col_phyrate.HeaderText = "PHY速度";
            this.col_phyrate.Name = "col_phyrate";
            // 
            // col_vol1
            // 
            this.col_vol1.HeaderText = "额定电压1(mV)";
            this.col_vol1.Name = "col_vol1";
            this.col_vol1.Width = 110;
            // 
            // col_vol2
            // 
            this.col_vol2.HeaderText = "额定电压2(mV)";
            this.col_vol2.Name = "col_vol2";
            this.col_vol2.Width = 110;
            // 
            // col_cur
            // 
            this.col_cur.HeaderText = "整板电流(mA)";
            this.col_cur.Name = "col_cur";
            this.col_cur.Width = 110;
            // 
            // col_result
            // 
            this.col_result.HeaderText = "测试结果";
            this.col_result.Name = "col_result";
            this.col_result.Width = 88;
            // 
            // col_info
            // 
            this.col_info.HeaderText = "详细信息";
            this.col_info.Name = "col_info";
            this.col_info.Width = 120;
            // 
            // col_time
            // 
            this.col_time.HeaderText = "测试时间";
            this.col_time.Name = "col_time";
            this.col_time.Width = 150;
            // 
            // btn_AddRecord
            // 
            this.btn_AddRecord.Location = new System.Drawing.Point(12, 682);
            this.btn_AddRecord.Name = "btn_AddRecord";
            this.btn_AddRecord.Size = new System.Drawing.Size(75, 23);
            this.btn_AddRecord.TabIndex = 32;
            this.btn_AddRecord.Text = "增加记录";
            this.btn_AddRecord.UseVisualStyleBackColor = true;
            this.btn_AddRecord.Click += new System.EventHandler(this.btn_AddRecord_Click);
            // 
            // btn_ExportData
            // 
            this.btn_ExportData.Location = new System.Drawing.Point(206, 682);
            this.btn_ExportData.Name = "btn_ExportData";
            this.btn_ExportData.Size = new System.Drawing.Size(75, 23);
            this.btn_ExportData.TabIndex = 33;
            this.btn_ExportData.Text = "导出数据";
            this.btn_ExportData.UseVisualStyleBackColor = true;
            this.btn_ExportData.Click += new System.EventHandler(this.btn_ExportData_Click);
            // 
            // btn_DeleteRecord
            // 
            this.btn_DeleteRecord.Location = new System.Drawing.Point(109, 682);
            this.btn_DeleteRecord.Name = "btn_DeleteRecord";
            this.btn_DeleteRecord.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteRecord.TabIndex = 34;
            this.btn_DeleteRecord.Text = "删除记录";
            this.btn_DeleteRecord.UseVisualStyleBackColor = true;
            this.btn_DeleteRecord.Click += new System.EventHandler(this.btn_DeleteRecord_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(8, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 22);
            this.label12.TabIndex = 35;
            this.label12.Text = "串口信息";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(17, 412);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 22);
            this.label14.TabIndex = 36;
            this.label14.Text = "测试记录";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lab_cur_res);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.lab_vol2_res);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.lab_vol1_res);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.lab_result);
            this.groupBox3.Controls.Add(this.lab_phyrate_res);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(347, 143);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 260);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "测试结果";
            // 
            // lab_cur_res
            // 
            this.lab_cur_res.AutoSize = true;
            this.lab_cur_res.Font = new System.Drawing.Font("NSimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_cur_res.Location = new System.Drawing.Point(130, 206);
            this.lab_cur_res.Name = "lab_cur_res";
            this.lab_cur_res.Size = new System.Drawing.Size(63, 14);
            this.lab_cur_res.TabIndex = 47;
            this.lab_cur_res.Text = "<  0.6 A";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("NSimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label28.Location = new System.Drawing.Point(13, 205);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(77, 14);
            this.label28.TabIndex = 46;
            this.label28.Text = "整板电流：";
            // 
            // lab_vol2_res
            // 
            this.lab_vol2_res.AutoSize = true;
            this.lab_vol2_res.Font = new System.Drawing.Font("NSimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_vol2_res.Location = new System.Drawing.Point(131, 162);
            this.lab_vol2_res.Name = "lab_vol2_res";
            this.lab_vol2_res.Size = new System.Drawing.Size(63, 14);
            this.lab_vol2_res.TabIndex = 45;
            this.lab_vol2_res.Text = ">  1.2 V";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("NSimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label26.Location = new System.Drawing.Point(12, 162);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(77, 14);
            this.label26.TabIndex = 44;
            this.label26.Text = "额定电压2:";
            // 
            // lab_vol1_res
            // 
            this.lab_vol1_res.AutoSize = true;
            this.lab_vol1_res.Font = new System.Drawing.Font("NSimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_vol1_res.Location = new System.Drawing.Point(131, 117);
            this.lab_vol1_res.Name = "lab_vol1_res";
            this.lab_vol1_res.Size = new System.Drawing.Size(63, 14);
            this.lab_vol1_res.TabIndex = 43;
            this.lab_vol1_res.Text = ">  3.3 V";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("NSimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.Location = new System.Drawing.Point(12, 117);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(84, 14);
            this.label24.TabIndex = 42;
            this.label24.Text = "额定电压1：";
            // 
            // lab_result
            // 
            this.lab_result.AutoSize = true;
            this.lab_result.Font = new System.Drawing.Font("NSimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_result.Location = new System.Drawing.Point(131, 41);
            this.lab_result.Name = "lab_result";
            this.lab_result.Size = new System.Drawing.Size(55, 14);
            this.lab_result.TabIndex = 41;
            this.lab_result.Text = "FAILED";
            // 
            // lab_phyrate_res
            // 
            this.lab_phyrate_res.AutoSize = true;
            this.lab_phyrate_res.Font = new System.Drawing.Font("NSimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_phyrate_res.Location = new System.Drawing.Point(131, 77);
            this.lab_phyrate_res.Name = "lab_phyrate_res";
            this.lab_phyrate_res.Size = new System.Drawing.Size(84, 14);
            this.lab_phyrate_res.TabIndex = 40;
            this.lab_phyrate_res.Text = "<  180 mbps";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("NSimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(12, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 14);
            this.label16.TabIndex = 39;
            this.label16.Text = "PHY速度：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("NSimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(11, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 14);
            this.label15.TabIndex = 38;
            this.label15.Text = "合格/不合格：";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.窗口ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(964, 28);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导出数据ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 导出数据ToolStripMenuItem
            // 
            this.导出数据ToolStripMenuItem.Name = "导出数据ToolStripMenuItem";
            this.导出数据ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.导出数据ToolStripMenuItem.Text = "导出数据";
            this.导出数据ToolStripMenuItem.Click += new System.EventHandler(this.导出数据ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置门限值ToolStripMenuItem,
            this.测试模式ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.编辑ToolStripMenuItem.Text = "设置";
            // 
            // 设置门限值ToolStripMenuItem
            // 
            this.设置门限值ToolStripMenuItem.Name = "设置门限值ToolStripMenuItem";
            this.设置门限值ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.设置门限值ToolStripMenuItem.Text = "设置门限值";
            this.设置门限值ToolStripMenuItem.Click += new System.EventHandler(this.设置门限值ToolStripMenuItem_Click);
            // 
            // 测试模式ToolStripMenuItem
            // 
            this.测试模式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自动测试ToolStripMenuItem,
            this.手动测试ToolStripMenuItem});
            this.测试模式ToolStripMenuItem.Name = "测试模式ToolStripMenuItem";
            this.测试模式ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.测试模式ToolStripMenuItem.Text = "测试模式";
            // 
            // 自动测试ToolStripMenuItem
            // 
            this.自动测试ToolStripMenuItem.Name = "自动测试ToolStripMenuItem";
            this.自动测试ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.自动测试ToolStripMenuItem.Text = "自动测试";
            this.自动测试ToolStripMenuItem.Click += new System.EventHandler(this.自动测试ToolStripMenuItem_Click);
            // 
            // 手动测试ToolStripMenuItem
            // 
            this.手动测试ToolStripMenuItem.Name = "手动测试ToolStripMenuItem";
            this.手动测试ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.手动测试ToolStripMenuItem.Text = "手动测试";
            this.手动测试ToolStripMenuItem.Click += new System.EventHandler(this.手动测试ToolStripMenuItem_Click);
            // 
            // 窗口ToolStripMenuItem
            // 
            this.窗口ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.串口配置ToolStripMenuItem,
            this.串口信息ToolStripMenuItem1,
            this.串口命令ToolStripMenuItem});
            this.窗口ToolStripMenuItem.Name = "窗口ToolStripMenuItem";
            this.窗口ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.窗口ToolStripMenuItem.Text = "调试";
            // 
            // 串口配置ToolStripMenuItem
            // 
            this.串口配置ToolStripMenuItem.Name = "串口配置ToolStripMenuItem";
            this.串口配置ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.串口配置ToolStripMenuItem.Text = "串口配置";
            this.串口配置ToolStripMenuItem.Click += new System.EventHandler(this.串口配置ToolStripMenuItem_Click);
            // 
            // panel_ser
            // 
            this.panel_ser.Controls.Add(this.label12);
            this.panel_ser.Controls.Add(this.richTextBox1);
            this.panel_ser.Controls.Add(this.label9);
            this.panel_ser.Controls.Add(this.l_RxBytes);
            this.panel_ser.Controls.Add(this.button1);
            this.panel_ser.Controls.Add(this.btn_showprint);
            this.panel_ser.Location = new System.Drawing.Point(558, 405);
            this.panel_ser.Name = "panel_ser";
            this.panel_ser.Size = new System.Drawing.Size(406, 308);
            this.panel_ser.TabIndex = 39;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lab_preset_cur);
            this.groupBox5.Controls.Add(this.label32);
            this.groupBox5.Controls.Add(this.lab_preset_vol2);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.lab_preset_vol1);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.lab_preset_phyrate);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.Location = new System.Drawing.Point(564, 28);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(385, 104);
            this.groupBox5.TabIndex = 42;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "预设值";
            // 
            // lab_preset_cur
            // 
            this.lab_preset_cur.AutoSize = true;
            this.lab_preset_cur.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_preset_cur.Location = new System.Drawing.Point(312, 70);
            this.lab_preset_cur.Name = "lab_preset_cur";
            this.lab_preset_cur.Size = new System.Drawing.Size(58, 20);
            this.lab_preset_cur.TabIndex = 7;
            this.lab_preset_cur.Text = "label31";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label32.Location = new System.Drawing.Point(212, 70);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(79, 20);
            this.label32.TabIndex = 6;
            this.label32.Text = "整板电流：";
            // 
            // lab_preset_vol2
            // 
            this.lab_preset_vol2.AutoSize = true;
            this.lab_preset_vol2.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_preset_vol2.Location = new System.Drawing.Point(114, 71);
            this.lab_preset_vol2.Name = "lab_preset_vol2";
            this.lab_preset_vol2.Size = new System.Drawing.Size(58, 20);
            this.lab_preset_vol2.TabIndex = 5;
            this.lab_preset_vol2.Text = "label29";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label30.Location = new System.Drawing.Point(17, 70);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(87, 20);
            this.label30.TabIndex = 4;
            this.label30.Text = "额定电压2：";
            // 
            // lab_preset_vol1
            // 
            this.lab_preset_vol1.AutoSize = true;
            this.lab_preset_vol1.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_preset_vol1.Location = new System.Drawing.Point(311, 33);
            this.lab_preset_vol1.Name = "lab_preset_vol1";
            this.lab_preset_vol1.Size = new System.Drawing.Size(58, 20);
            this.lab_preset_vol1.TabIndex = 3;
            this.lab_preset_vol1.Text = "label25";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label27.Location = new System.Drawing.Point(211, 33);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(87, 20);
            this.label27.TabIndex = 2;
            this.label27.Text = "额定电压1：";
            // 
            // lab_preset_phyrate
            // 
            this.lab_preset_phyrate.AutoSize = true;
            this.lab_preset_phyrate.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_preset_phyrate.Location = new System.Drawing.Point(114, 31);
            this.lab_preset_phyrate.Name = "lab_preset_phyrate";
            this.lab_preset_phyrate.Size = new System.Drawing.Size(58, 20);
            this.lab_preset_phyrate.TabIndex = 1;
            this.lab_preset_phyrate.Text = "label23";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(18, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "PHY速度：";
            // 
            // lab_testmodel
            // 
            this.lab_testmodel.AutoSize = true;
            this.lab_testmodel.Font = new System.Drawing.Font("NSimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_testmodel.Location = new System.Drawing.Point(122, 76);
            this.lab_testmodel.Name = "lab_testmodel";
            this.lab_testmodel.Size = new System.Drawing.Size(63, 14);
            this.lab_testmodel.TabIndex = 34;
            this.lab_testmodel.Text = "手动测试";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("NSimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(13, 77);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(70, 14);
            this.label23.TabIndex = 33;
            this.label23.Text = "测试模式:";
            // 
            // lab_FailureCount
            // 
            this.lab_FailureCount.AutoSize = true;
            this.lab_FailureCount.Font = new System.Drawing.Font("NSimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_FailureCount.Location = new System.Drawing.Point(122, 117);
            this.lab_FailureCount.Name = "lab_FailureCount";
            this.lab_FailureCount.Size = new System.Drawing.Size(14, 14);
            this.lab_FailureCount.TabIndex = 35;
            this.lab_FailureCount.Text = "0";
            // 
            // lab_FailureRate
            // 
            this.lab_FailureRate.AutoSize = true;
            this.lab_FailureRate.Font = new System.Drawing.Font("NSimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_FailureRate.Location = new System.Drawing.Point(122, 153);
            this.lab_FailureRate.Name = "lab_FailureRate";
            this.lab_FailureRate.Size = new System.Drawing.Size(14, 14);
            this.lab_FailureRate.TabIndex = 36;
            this.lab_FailureRate.Text = "0";
            // 
            // 串口信息ToolStripMenuItem1
            // 
            this.串口信息ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示串口信息ToolStripMenuItem,
            this.隐藏串口信息ToolStripMenuItem1});
            this.串口信息ToolStripMenuItem1.Name = "串口信息ToolStripMenuItem1";
            this.串口信息ToolStripMenuItem1.Size = new System.Drawing.Size(152, 24);
            this.串口信息ToolStripMenuItem1.Text = "串口信息";
            // 
            // 显示串口信息ToolStripMenuItem
            // 
            this.显示串口信息ToolStripMenuItem.Name = "显示串口信息ToolStripMenuItem";
            this.显示串口信息ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.显示串口信息ToolStripMenuItem.Text = "显示串口信息";
            this.显示串口信息ToolStripMenuItem.Click += new System.EventHandler(this.串口信息ToolStripMenuItem_Click);
            // 
            // 隐藏串口信息ToolStripMenuItem1
            // 
            this.隐藏串口信息ToolStripMenuItem1.Name = "隐藏串口信息ToolStripMenuItem1";
            this.隐藏串口信息ToolStripMenuItem1.Size = new System.Drawing.Size(162, 24);
            this.隐藏串口信息ToolStripMenuItem1.Text = "隐藏串口信息";
            this.隐藏串口信息ToolStripMenuItem1.Click += new System.EventHandler(this.隐藏串口信息ToolStripMenuItem_Click);
            // 
            // 串口命令ToolStripMenuItem
            // 
            this.串口命令ToolStripMenuItem.Name = "串口命令ToolStripMenuItem";
            this.串口命令ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.串口命令ToolStripMenuItem.Text = "串口命令";
            this.串口命令ToolStripMenuItem.Click += new System.EventHandler(this.发送串口命令ToolStripMenuItem_Click);
            // 
            // HDPLC_Information_Collector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 710);
            this.Controls.Add(this.btn_OpenSer);
            this.Controls.Add(this.cb_BaudRate);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Port);
            this.Controls.Add(this.panel_ser);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_AddRecord);
            this.Controls.Add(this.btn_ExportData);
            this.Controls.Add(this.btn_DeleteRecord);
            this.Controls.Add(this.btn_SetMac);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tb_MacToBeSet);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HDPLC_Information_Collector";
            this.Text = "广联同轴适配器自动测试系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HDPLC_Information_Collector_FormClosing);
            this.Load += new System.EventHandler(this.HDPLC_Information_Collector_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_ser.ResumeLayout(false);
            this.panel_ser.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OpenSer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_RefMac;
        private System.Windows.Forms.Button btn_getRefMac;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_Port;
        private System.Windows.Forms.ComboBox cb_BaudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_showprint;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label l_RxBytes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_DutMac;
        private System.Windows.Forms.Button btn_getDutMac;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_PhyRate;
        private System.Windows.Forms.Button btn_GetPhyRate;
        private System.Windows.Forms.Label lab_date;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_getAll;
        private System.Windows.Forms.Button btn_SetMac;
        private System.Windows.Forms.TextBox tb_MacToBeSet;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_AddRecord;
        private System.Windows.Forms.Button btn_ExportData;
        private System.Windows.Forms.Button btn_DeleteRecord;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lab_result;
        private System.Windows.Forms.Label lab_phyrate_res;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置门限值ToolStripMenuItem;
        private System.Windows.Forms.TextBox tb_current;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_voltage1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tb_voltage2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lab_cur_res;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lab_vol2_res;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lab_vol1_res;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dutmac;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_refmac;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_phyrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_vol1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_vol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cur;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_result;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_info;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_time;
        private System.Windows.Forms.Panel panel_ser;
        private System.Windows.Forms.ToolStripMenuItem 窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 串口配置ToolStripMenuItem;
        private System.Windows.Forms.Button btn_cleardev;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lab_preset_cur;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lab_preset_vol2;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lab_preset_vol1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lab_preset_phyrate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem 测试模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自动测试ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 手动测试ToolStripMenuItem;
        private System.Windows.Forms.Label lab_testmodel;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lab_FailureRate;
        private System.Windows.Forms.Label lab_FailureCount;
        private System.Windows.Forms.ToolStripMenuItem 串口信息ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 显示串口信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 隐藏串口信息ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 串口命令ToolStripMenuItem;
    }
}

