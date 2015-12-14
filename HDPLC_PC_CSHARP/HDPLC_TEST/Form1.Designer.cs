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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btn_OpenSer = new System.Windows.Forms.Button();
            this.btn_SerConfiure = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_RefMac = new System.Windows.Forms.TextBox();
            this.btn_getRefMac = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lab_date = new System.Windows.Forms.Label();
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
            this.btn_ClearDevice = new System.Windows.Forms.Button();
            this.btn_getAll = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.btn_judge = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置门限值ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发送串口命令ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btn_OpenSer
            // 
            this.btn_OpenSer.Location = new System.Drawing.Point(8, 14);
            this.btn_OpenSer.Name = "btn_OpenSer";
            this.btn_OpenSer.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenSer.TabIndex = 0;
            this.btn_OpenSer.Text = "打开串口";
            this.btn_OpenSer.UseVisualStyleBackColor = true;
            this.btn_OpenSer.Click += new System.EventHandler(this.btn_OpenSer_Click);
            // 
            // btn_SerConfiure
            // 
            this.btn_SerConfiure.Location = new System.Drawing.Point(94, 14);
            this.btn_SerConfiure.Name = "btn_SerConfiure";
            this.btn_SerConfiure.Size = new System.Drawing.Size(75, 23);
            this.btn_SerConfiure.TabIndex = 1;
            this.btn_SerConfiure.Text = "串口配置";
            this.btn_SerConfiure.UseVisualStyleBackColor = true;
            this.btn_SerConfiure.Click += new System.EventHandler(this.btn_SerConfiure_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(7, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "测试日期:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "测试拼版总数:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "合格品总数:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(6, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "不良品总数:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(6, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 14);
            this.label6.TabIndex = 7;
            this.label6.Text = "不良率:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(9, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "参考板MAC:";
            // 
            // tb_RefMac
            // 
            this.tb_RefMac.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_RefMac.Location = new System.Drawing.Point(80, 37);
            this.tb_RefMac.Name = "tb_RefMac";
            this.tb_RefMac.Size = new System.Drawing.Size(136, 21);
            this.tb_RefMac.TabIndex = 9;
            // 
            // btn_getRefMac
            // 
            this.btn_getRefMac.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_getRefMac.Location = new System.Drawing.Point(225, 37);
            this.btn_getRefMac.Name = "btn_getRefMac";
            this.btn_getRefMac.Size = new System.Drawing.Size(75, 23);
            this.btn_getRefMac.TabIndex = 10;
            this.btn_getRefMac.Text = "发送命令";
            this.btn_getRefMac.UseVisualStyleBackColor = true;
            this.btn_getRefMac.Click += new System.EventHandler(this.btn_getRefMac_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lab_date);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 240);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息统计";
            // 
            // lab_date
            // 
            this.lab_date.AutoSize = true;
            this.lab_date.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_date.Location = new System.Drawing.Point(116, 44);
            this.lab_date.Name = "lab_date";
            this.lab_date.Size = new System.Drawing.Size(98, 16);
            this.lab_date.TabIndex = 30;
            this.lab_date.Text = "2015/10/28";
            // 
            // cb_Port
            // 
            this.cb_Port.FormattingEnabled = true;
            this.cb_Port.Location = new System.Drawing.Point(223, 16);
            this.cb_Port.Name = "cb_Port";
            this.cb_Port.Size = new System.Drawing.Size(97, 20);
            this.cb_Port.TabIndex = 12;
            // 
            // cb_BaudRate
            // 
            this.cb_BaudRate.FormattingEnabled = true;
            this.cb_BaudRate.Location = new System.Drawing.Point(380, 17);
            this.cb_BaudRate.Name = "cb_BaudRate";
            this.cb_BaudRate.Size = new System.Drawing.Size(114, 20);
            this.cb_BaudRate.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "端口";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "波特率";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(12, 348);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(395, 291);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // btn_showprint
            // 
            this.btn_showprint.Location = new System.Drawing.Point(333, 645);
            this.btn_showprint.Name = "btn_showprint";
            this.btn_showprint.Size = new System.Drawing.Size(75, 23);
            this.btn_showprint.TabIndex = 17;
            this.btn_showprint.Text = "刷新";
            this.btn_showprint.UseVisualStyleBackColor = true;
            this.btn_showprint.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 645);
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
            this.label9.Location = new System.Drawing.Point(13, 650);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "接收字节：";
            // 
            // l_RxBytes
            // 
            this.l_RxBytes.AutoSize = true;
            this.l_RxBytes.Location = new System.Drawing.Point(84, 650);
            this.l_RxBytes.Name = "l_RxBytes";
            this.l_RxBytes.Size = new System.Drawing.Size(11, 12);
            this.l_RxBytes.TabIndex = 20;
            this.l_RxBytes.Text = "0";
            this.l_RxBytes.TextChanged += new System.EventHandler(this.l_RxBytes_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(10, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 23;
            this.label11.Text = "待测板MAC:";
            // 
            // tb_DutMac
            // 
            this.tb_DutMac.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_DutMac.Location = new System.Drawing.Point(80, 69);
            this.tb_DutMac.Name = "tb_DutMac";
            this.tb_DutMac.Size = new System.Drawing.Size(136, 21);
            this.tb_DutMac.TabIndex = 25;
            // 
            // btn_getDutMac
            // 
            this.btn_getDutMac.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_getDutMac.Location = new System.Drawing.Point(226, 68);
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
            this.label10.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(10, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 27;
            this.label10.Text = "PHY速度：";
            // 
            // tb_PhyRate
            // 
            this.tb_PhyRate.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_PhyRate.Location = new System.Drawing.Point(80, 101);
            this.tb_PhyRate.Name = "tb_PhyRate";
            this.tb_PhyRate.Size = new System.Drawing.Size(136, 21);
            this.tb_PhyRate.TabIndex = 28;
            // 
            // btn_GetPhyRate
            // 
            this.btn_GetPhyRate.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_GetPhyRate.Location = new System.Drawing.Point(226, 100);
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
            this.groupBox2.Location = new System.Drawing.Point(290, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 240);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设备参数";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.Location = new System.Drawing.Point(233, 203);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 12);
            this.label22.TabIndex = 49;
            this.label22.Text = "单位（mA）";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(232, 173);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 12);
            this.label21.TabIndex = 48;
            this.label21.Text = "单位（mV）";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(232, 141);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 12);
            this.label20.TabIndex = 47;
            this.label20.Text = "单位（mV）";
            // 
            // tb_current
            // 
            this.tb_current.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_current.Location = new System.Drawing.Point(80, 199);
            this.tb_current.Name = "tb_current";
            this.tb_current.Size = new System.Drawing.Size(136, 21);
            this.tb_current.TabIndex = 46;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(10, 203);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 12);
            this.label17.TabIndex = 45;
            this.label17.Text = "整板电流;";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(10, 138);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 39;
            this.label18.Text = "额定电压1:";
            // 
            // tb_voltage1
            // 
            this.tb_voltage1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_voltage1.Location = new System.Drawing.Point(80, 135);
            this.tb_voltage1.Name = "tb_voltage1";
            this.tb_voltage1.Size = new System.Drawing.Size(136, 21);
            this.tb_voltage1.TabIndex = 40;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(10, 171);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 42;
            this.label19.Text = "额定电压2;";
            // 
            // tb_voltage2
            // 
            this.tb_voltage2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_voltage2.Location = new System.Drawing.Point(80, 167);
            this.tb_voltage2.Name = "tb_voltage2";
            this.tb_voltage2.Size = new System.Drawing.Size(136, 21);
            this.tb_voltage2.TabIndex = 43;
            // 
            // btn_SetMac
            // 
            this.btn_SetMac.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SetMac.Location = new System.Drawing.Point(843, 33);
            this.btn_SetMac.Name = "btn_SetMac";
            this.btn_SetMac.Size = new System.Drawing.Size(75, 23);
            this.btn_SetMac.TabIndex = 35;
            this.btn_SetMac.Text = "设置";
            this.btn_SetMac.UseVisualStyleBackColor = true;
            this.btn_SetMac.Click += new System.EventHandler(this.btn_SetMac_Click);
            // 
            // tb_MacToBeSet
            // 
            this.tb_MacToBeSet.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_MacToBeSet.Location = new System.Drawing.Point(695, 34);
            this.tb_MacToBeSet.Name = "tb_MacToBeSet";
            this.tb_MacToBeSet.Size = new System.Drawing.Size(136, 21);
            this.tb_MacToBeSet.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(627, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 12);
            this.label13.TabIndex = 33;
            this.label13.Text = "设置MAC";
            // 
            // btn_ClearDevice
            // 
            this.btn_ClearDevice.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ClearDevice.Location = new System.Drawing.Point(152, 209);
            this.btn_ClearDevice.Name = "btn_ClearDevice";
            this.btn_ClearDevice.Size = new System.Drawing.Size(72, 23);
            this.btn_ClearDevice.TabIndex = 31;
            this.btn_ClearDevice.Text = "清零";
            this.btn_ClearDevice.UseVisualStyleBackColor = true;
            this.btn_ClearDevice.Click += new System.EventHandler(this.btn_ClearDevice_Click);
            // 
            // btn_getAll
            // 
            this.btn_getAll.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_getAll.Location = new System.Drawing.Point(232, 209);
            this.btn_getAll.Name = "btn_getAll";
            this.btn_getAll.Size = new System.Drawing.Size(74, 23);
            this.btn_getAll.TabIndex = 31;
            this.btn_getAll.Text = "开始";
            this.btn_getAll.UseVisualStyleBackColor = true;
            this.btn_getAll.Click += new System.EventHandler(this.btn_getAll_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(423, 348);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(506, 291);
            this.dataGridView1.TabIndex = 31;
            // 
            // btn_AddRecord
            // 
            this.btn_AddRecord.Location = new System.Drawing.Point(672, 645);
            this.btn_AddRecord.Name = "btn_AddRecord";
            this.btn_AddRecord.Size = new System.Drawing.Size(75, 23);
            this.btn_AddRecord.TabIndex = 32;
            this.btn_AddRecord.Text = "增加记录";
            this.btn_AddRecord.UseVisualStyleBackColor = true;
            this.btn_AddRecord.Click += new System.EventHandler(this.btn_AddRecord_Click);
            // 
            // btn_ExportData
            // 
            this.btn_ExportData.Location = new System.Drawing.Point(856, 645);
            this.btn_ExportData.Name = "btn_ExportData";
            this.btn_ExportData.Size = new System.Drawing.Size(75, 23);
            this.btn_ExportData.TabIndex = 33;
            this.btn_ExportData.Text = "导出数据";
            this.btn_ExportData.UseVisualStyleBackColor = true;
            this.btn_ExportData.Click += new System.EventHandler(this.btn_ExportData_Click);
            // 
            // btn_DeleteRecord
            // 
            this.btn_DeleteRecord.Location = new System.Drawing.Point(766, 645);
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
            this.label12.Location = new System.Drawing.Point(14, 321);
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
            this.label14.Location = new System.Drawing.Point(417, 321);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 22);
            this.label14.TabIndex = 36;
            this.label14.Text = "测试记录";
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
            this.groupBox3.Controls.Add(this.btn_ClearDevice);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.btn_getAll);
            this.groupBox3.Controls.Add(this.btn_judge);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(617, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 240);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "测试结果";
            // 
            // lab_cur_res
            // 
            this.lab_cur_res.AutoSize = true;
            this.lab_cur_res.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_cur_res.Location = new System.Drawing.Point(126, 166);
            this.lab_cur_res.Name = "lab_cur_res";
            this.lab_cur_res.Size = new System.Drawing.Size(60, 20);
            this.lab_cur_res.TabIndex = 47;
            this.lab_cur_res.Text = "<  0.6 A";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label28.Location = new System.Drawing.Point(18, 169);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(65, 12);
            this.label28.TabIndex = 46;
            this.label28.Text = "整板电流：";
            // 
            // lab_vol2_res
            // 
            this.lab_vol2_res.AutoSize = true;
            this.lab_vol2_res.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_vol2_res.Location = new System.Drawing.Point(127, 133);
            this.lab_vol2_res.Name = "lab_vol2_res";
            this.lab_vol2_res.Size = new System.Drawing.Size(59, 20);
            this.lab_vol2_res.TabIndex = 45;
            this.lab_vol2_res.Text = ">  1.2 V";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label26.Location = new System.Drawing.Point(17, 137);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(65, 12);
            this.label26.TabIndex = 44;
            this.label26.Text = "额定电压2:";
            // 
            // lab_vol1_res
            // 
            this.lab_vol1_res.AutoSize = true;
            this.lab_vol1_res.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_vol1_res.Location = new System.Drawing.Point(127, 101);
            this.lab_vol1_res.Name = "lab_vol1_res";
            this.lab_vol1_res.Size = new System.Drawing.Size(59, 20);
            this.lab_vol1_res.TabIndex = 43;
            this.lab_vol1_res.Text = ">  3.3 V";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.Location = new System.Drawing.Point(17, 105);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 12);
            this.label24.TabIndex = 42;
            this.label24.Text = "额定电压1：";
            // 
            // lab_result
            // 
            this.lab_result.AutoSize = true;
            this.lab_result.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_result.Location = new System.Drawing.Point(136, 36);
            this.lab_result.Name = "lab_result";
            this.lab_result.Size = new System.Drawing.Size(56, 20);
            this.lab_result.TabIndex = 41;
            this.lab_result.Text = "FAILED";
            // 
            // lab_phyrate_res
            // 
            this.lab_phyrate_res.AutoSize = true;
            this.lab_phyrate_res.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_phyrate_res.Location = new System.Drawing.Point(124, 70);
            this.lab_phyrate_res.Name = "lab_phyrate_res";
            this.lab_phyrate_res.Size = new System.Drawing.Size(92, 20);
            this.lab_phyrate_res.TabIndex = 40;
            this.lab_phyrate_res.Text = "<  180 mbps";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(17, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 12);
            this.label16.TabIndex = 39;
            this.label16.Text = "PHY速度：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(16, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 12);
            this.label15.TabIndex = 38;
            this.label15.Text = "合格/不合格：";
            // 
            // btn_judge
            // 
            this.btn_judge.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_judge.Location = new System.Drawing.Point(70, 209);
            this.btn_judge.Name = "btn_judge";
            this.btn_judge.Size = new System.Drawing.Size(75, 23);
            this.btn_judge.TabIndex = 0;
            this.btn_judge.Text = "判定";
            this.btn_judge.UseVisualStyleBackColor = true;
            this.btn_judge.Click += new System.EventHandler(this.btn_judge_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(940, 28);
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
            this.导出数据ToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.导出数据ToolStripMenuItem.Text = "导出数据";
            this.导出数据ToolStripMenuItem.Click += new System.EventHandler(this.导出数据ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置门限值ToolStripMenuItem,
            this.发送串口命令ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 设置门限值ToolStripMenuItem
            // 
            this.设置门限值ToolStripMenuItem.Name = "设置门限值ToolStripMenuItem";
            this.设置门限值ToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.设置门限值ToolStripMenuItem.Text = "设置门限值";
            this.设置门限值ToolStripMenuItem.Click += new System.EventHandler(this.设置门限值ToolStripMenuItem_Click);
            // 
            // 发送串口命令ToolStripMenuItem
            // 
            this.发送串口命令ToolStripMenuItem.Name = "发送串口命令ToolStripMenuItem";
            this.发送串口命令ToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.发送串口命令ToolStripMenuItem.Text = "串口命令";
            this.发送串口命令ToolStripMenuItem.Click += new System.EventHandler(this.发送串口命令ToolStripMenuItem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_OpenSer);
            this.groupBox4.Controls.Add(this.btn_SerConfiure);
            this.groupBox4.Controls.Add(this.cb_BaudRate);
            this.groupBox4.Controls.Add(this.cb_Port);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(12, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(502, 43);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
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
            // HDPLC_Information_Collector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 675);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_SetMac);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tb_MacToBeSet);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_DeleteRecord);
            this.Controls.Add(this.btn_ExportData);
            this.Controls.Add(this.btn_AddRecord);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.l_RxBytes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_showprint);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HDPLC_Information_Collector";
            this.Text = "HDPLC information collector";
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
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OpenSer;
        private System.Windows.Forms.Button btn_SerConfiure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.Button btn_ClearDevice;
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
        private System.Windows.Forms.Button btn_judge;
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
        private System.Windows.Forms.ToolStripMenuItem 发送串口命令ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
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
    }
}

