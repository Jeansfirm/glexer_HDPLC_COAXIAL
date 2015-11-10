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
            this.btn_SetMac = new System.Windows.Forms.Button();
            this.tb_MacToBeSet = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_ClearDevice = new System.Windows.Forms.Button();
            this.btn_getAll = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dutmac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_refmac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_phyrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_AddRecord = new System.Windows.Forms.Button();
            this.btn_ExportData = new System.Windows.Forms.Button();
            this.btn_DeleteRecord = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lab_result = new System.Windows.Forms.Label();
            this.lab_phyrate_res = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_judge = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btn_OpenSer
            // 
            this.btn_OpenSer.Location = new System.Drawing.Point(27, 12);
            this.btn_OpenSer.Name = "btn_OpenSer";
            this.btn_OpenSer.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenSer.TabIndex = 0;
            this.btn_OpenSer.Text = "打开串口";
            this.btn_OpenSer.UseVisualStyleBackColor = true;
            this.btn_OpenSer.Click += new System.EventHandler(this.btn_OpenSer_Click);
            // 
            // btn_SerConfiure
            // 
            this.btn_SerConfiure.Location = new System.Drawing.Point(123, 12);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
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
            this.cb_Port.Location = new System.Drawing.Point(278, 14);
            this.cb_Port.Name = "cb_Port";
            this.cb_Port.Size = new System.Drawing.Size(97, 20);
            this.cb_Port.TabIndex = 12;
            // 
            // cb_BaudRate
            // 
            this.cb_BaudRate.FormattingEnabled = true;
            this.cb_BaudRate.Location = new System.Drawing.Point(449, 15);
            this.cb_BaudRate.Name = "cb_BaudRate";
            this.cb_BaudRate.Size = new System.Drawing.Size(114, 20);
            this.cb_BaudRate.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "端口";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(393, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "波特率";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(12, 324);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(395, 291);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // btn_showprint
            // 
            this.btn_showprint.Location = new System.Drawing.Point(333, 621);
            this.btn_showprint.Name = "btn_showprint";
            this.btn_showprint.Size = new System.Drawing.Size(75, 23);
            this.btn_showprint.TabIndex = 17;
            this.btn_showprint.Text = "刷新";
            this.btn_showprint.UseVisualStyleBackColor = true;
            this.btn_showprint.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 621);
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
            this.label9.Location = new System.Drawing.Point(13, 626);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "接收字节：";
            // 
            // l_RxBytes
            // 
            this.l_RxBytes.AutoSize = true;
            this.l_RxBytes.Location = new System.Drawing.Point(84, 626);
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
            this.groupBox2.Controls.Add(this.btn_SetMac);
            this.groupBox2.Controls.Add(this.tb_MacToBeSet);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tb_PhyRate);
            this.groupBox2.Controls.Add(this.btn_getRefMac);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tb_RefMac);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btn_getDutMac);
            this.groupBox2.Controls.Add(this.btn_GetPhyRate);
            this.groupBox2.Controls.Add(this.tb_DutMac);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(290, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 240);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设备参数";
            // 
            // btn_SetMac
            // 
            this.btn_SetMac.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SetMac.Location = new System.Drawing.Point(226, 209);
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
            this.tb_MacToBeSet.Location = new System.Drawing.Point(78, 210);
            this.tb_MacToBeSet.Name = "tb_MacToBeSet";
            this.tb_MacToBeSet.Size = new System.Drawing.Size(136, 21);
            this.tb_MacToBeSet.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(10, 215);
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
            this.col_result,
            this.col_time});
            this.dataGridView1.Location = new System.Drawing.Point(423, 324);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(506, 291);
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
            // col_result
            // 
            this.col_result.HeaderText = "测试结果";
            this.col_result.Name = "col_result";
            this.col_result.Width = 88;
            // 
            // col_time
            // 
            this.col_time.HeaderText = "测试时间";
            this.col_time.Name = "col_time";
            this.col_time.Width = 150;
            // 
            // btn_AddRecord
            // 
            this.btn_AddRecord.Location = new System.Drawing.Point(672, 621);
            this.btn_AddRecord.Name = "btn_AddRecord";
            this.btn_AddRecord.Size = new System.Drawing.Size(75, 23);
            this.btn_AddRecord.TabIndex = 32;
            this.btn_AddRecord.Text = "增加记录";
            this.btn_AddRecord.UseVisualStyleBackColor = true;
            this.btn_AddRecord.Click += new System.EventHandler(this.btn_AddRecord_Click);
            // 
            // btn_ExportData
            // 
            this.btn_ExportData.Location = new System.Drawing.Point(856, 621);
            this.btn_ExportData.Name = "btn_ExportData";
            this.btn_ExportData.Size = new System.Drawing.Size(75, 23);
            this.btn_ExportData.TabIndex = 33;
            this.btn_ExportData.Text = "导出数据";
            this.btn_ExportData.UseVisualStyleBackColor = true;
            this.btn_ExportData.Click += new System.EventHandler(this.btn_ExportData_Click);
            // 
            // btn_DeleteRecord
            // 
            this.btn_DeleteRecord.Location = new System.Drawing.Point(766, 621);
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
            this.label12.Location = new System.Drawing.Point(14, 297);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 22);
            this.label12.TabIndex = 35;
            this.label12.Text = "打印信息";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(417, 297);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 22);
            this.label14.TabIndex = 36;
            this.label14.Text = "测试记录";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lab_result);
            this.groupBox3.Controls.Add(this.lab_phyrate_res);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.btn_ClearDevice);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.btn_getAll);
            this.groupBox3.Controls.Add(this.btn_judge);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(617, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 240);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "测试结果";
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
            this.lab_phyrate_res.Location = new System.Drawing.Point(115, 68);
            this.lab_phyrate_res.Name = "lab_phyrate_res";
            this.lab_phyrate_res.Size = new System.Drawing.Size(88, 20);
            this.lab_phyrate_res.TabIndex = 40;
            this.lab_phyrate_res.Text = "< 180 mbps";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(16, 72);
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
            // HDPLC_Information_Collector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 650);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
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
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_BaudRate);
            this.Controls.Add(this.cb_Port);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_SerConfiure);
            this.Controls.Add(this.btn_OpenSer);
            this.Name = "HDPLC_Information_Collector";
            this.Text = "HDPLC information collector";
            this.Load += new System.EventHandler(this.HDPLC_Information_Collector_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn col_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dutmac;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_refmac;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_phyrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_result;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_time;
        public System.IO.Ports.SerialPort serialPort1;
    }
}

