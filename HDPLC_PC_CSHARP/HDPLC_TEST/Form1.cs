using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

//using MyExcel = Microsoft.Office.Interop.Excel;
//using System.Reflection;


namespace HDPLC_TEST
{
    public partial class HDPLC_Information_Collector : Form
    {
        String MacAddr;
        StringBuilder refMac = new StringBuilder(25);
        StringBuilder stdPhyrate = new StringBuilder(15); 
        string phyrate;
        int getRef = -1;
        int getPhy = 0;
        static int last_lab_RxBytes = 0;
        static int new_lab_RxBytes = 0;
        Byte[] buff=new Byte[20000];    //buffer to read bytes from serialport
        Thread autoRF;              //auto refresh thread

        [DllImport("kernel32")] 
        private static extern long GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public HDPLC_Information_Collector()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            
        }


        private void HDPLC_Information_Collector_Load(object sender, EventArgs e)
        {
            btn_OpenSer.Text = "打开串口";
            lab_date.Text = DateTime.Now.ToShortDateString().ToString();
            //lab_date.Text = DateTime.Now.ToString();
            btn_showprint.Enabled = false;
            tb_RefMac.ReadOnly = true;
            tb_DutMac.ReadOnly = true;
            tb_PhyRate.ReadOnly = true;
            richTextBox1.ReadOnly = true;
            dataGridView1.ReadOnly = true;
            btn_judge.Visible = false;

            lab_phyrate_res.Text = "";
            lab_result.Text = "";

            serialPort1.ReadBufferSize = 20000;     //set serialport read buffer size to 10000 bytes

            try
            {
                GetPrivateProfileString("ADDRESS", "REFMAC", "No preset address", refMac, 25, ".\\HDPLC_TEST.ini");
                GetPrivateProfileString("STANDARD", "PHYRATE", "100", stdPhyrate, 25, ".\\HDPLC_TEST.ini");
                tb_RefMac.Text = refMac.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

            int[] baud_item = {4800,9600,14400,38400,115200,230400};
            foreach(int a in baud_item)
            {
                cb_BaudRate.Items.Add(a.ToString());
            }
            cb_BaudRate.SelectedItem = cb_BaudRate.Items[4];

            string[] PortNames = SerialPort.GetPortNames();
            cb_Port.Items.AddRange(PortNames);
            cb_Port.SelectedItem = cb_Port.Items[0];        
            
       }


        /*按键单击事件，打开串口或者关闭串口*/

        private void btn_OpenSer_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (btn_OpenSer.Text == "打开串口")
                {
                    serialPort1.BaudRate = Convert.ToInt32(cb_BaudRate.SelectedItem.ToString());
                    serialPort1.PortName = cb_Port.SelectedItem.ToString();
                    serialPort1.Open();
                    btn_OpenSer.Text = "关闭串口";
                    //MessageBox.Show("串口已打开");
                    cb_Port.Enabled = false;
                    cb_BaudRate.Enabled = false;
                    btn_SerConfiure.Enabled = false;

                    autoRF = new Thread(autoRefresh);
                    autoRF.IsBackground = true;
                    autoRF.Start();
                }
                else
                {
                    serialPort1.Close();
                    btn_OpenSer.Text = "打开串口";
                    cb_Port.Enabled = true;
                    cb_BaudRate.Enabled = true;
                    btn_SerConfiure.Enabled = true;

                    autoRF.Abort();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        /*按键单击事件，弹出串口配置对话框*/

        private void btn_SerConfiure_Click(object sender, EventArgs e)
        {
            SerialConfig sc = new SerialConfig(this);

            sc.StartPosition = FormStartPosition.Manual;
            sc.Location = new Point(this.Location.X + 250, this.Location.Y + 150);

            sc.ShowDialog();
        }


        /*按键单击事件，获取 Ref 板 MAC 地址*/

        private void btn_getRefMac_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                
                serialPort1.WriteLine("1");
                getRef = 1;

            }
            else
            {
                MessageBox.Show("串口未打开, 请打开串口!");
            }
        }


        /*串口新数据到达事件，更新接收字符数标签数值*/

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int count = serialPort1.BytesToRead;
                new_lab_RxBytes = count;
                l_RxBytes.Text = count.ToString();
                btn_showprint.Enabled = true;            

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //刷新键  单击事件
        //通信协议：串口打印，$开头为设备参数，检测到$，置flag=1
        //$1 flag=2     MAC Address
        //$2 flag=3     PhyRate

        private void button1_Click(object sender, EventArgs e)
        {
            int flag = 0;
            int i = 0;

            last_lab_RxBytes = 0;

            int count = Convert.ToInt32(l_RxBytes.Text);
            string str = "";
            Array.Clear(buff,0,buff.Length);
            serialPort1.Read(buff, 0, count);

            l_RxBytes.Text = "0";
            btn_showprint.Enabled = false;
                    
            foreach (Byte b in buff)
            {
                str = str + Convert.ToChar(b);

                if (b == '$') flag = 1;
                if (flag == 1 && b == '1')
                {
                    flag = 2;
                    MacAddr = "";
                    continue;
                }
                if (flag == 1 && b == '2')
                {
                    flag = 3;
                    phyrate = "";
                    continue;
                }
                if (flag == 2)
                {

                    if (i < 12)
                    {
                        MacAddr = MacAddr + Convert.ToChar(b);
                        i++;
                    }
                    else
                    {
                        flag = 0;
                    }
                }
                if (flag == 3)
                {
                    if (b != 's')
                    {
                        phyrate = phyrate + Convert.ToChar(b);
                    }
                    else
                    {
                        phyrate = phyrate + Convert.ToChar(b);
                        flag = 0;
                    }
                }
            }

            richTextBox1.Text = richTextBox1.Text+str;

            if (getRef == 1)
            {
                tb_RefMac.Text = MacAddr;
            }
            else if (getRef == 0)
            {
                tb_DutMac.Text = MacAddr;
            }

            if(getPhy==1)
            {
                tb_PhyRate.Text = phyrate;
            }


            btn_judge_Click(sender, e);
     
        }


        /*按键单击事件，清空串口打印信息*/

        private void button1_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }


        /*按键单击事件，获取 DUT 板 MAC 地址*/

        private void btn_getDutMac_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {

                serialPort1.WriteLine("1");
                getRef = 0;

            }
            else
            {
                MessageBox.Show("串口未打开, 请打开串口!");
            }
        }


        /*按键单击事件，获取 PHY 速度*/

        private void btn_GetPhyRate_Click(object sender, EventArgs e)
        {
            string str_cmd="";
            getPhy = 1;
            

            if (serialPort1.IsOpen)
            {

                serialPort1.WriteLine("6"+tb_RefMac.Text);

            }
            else
            {
                MessageBox.Show("串口未打开, 请打开串口!");
            }
        }


        /*按键单击事件，获取设备所有信息*/

        private void btn_getAll_Click(object sender, EventArgs e)
        {
            getRef = 0;
            getPhy = 1;

            if (serialPort1.IsOpen)
            {

                serialPort1.WriteLine("7"+tb_RefMac.Text);
                
            }
            else
            {
                MessageBox.Show("串口未打开, 请打开串口!");
            }
        }


        /*按键单击事件，清除所有设备信息及清空测试结果判定*/

        private void btn_ClearDevice_Click(object sender, EventArgs e)
        {
            tb_DutMac.Text = "";
            tb_PhyRate.Text = "";
            lab_result.Text = "";
            lab_phyrate_res.Text = "";
            MacAddr = "";
            phyrate = "";
        }



        /*按键单击事件：设置MAC地址*/

        private void btn_SetMac_Click(object sender, EventArgs e)
        {
            getPhy = 0;

            if (serialPort1.IsOpen)
            {
                if (tb_MacToBeSet.Text.Length != 12)
                {
                    MessageBox.Show("  MAC地址形式必须为12个字符\n（由小写字母a-z和数字0-9组成）\n");
                    return;
                }

                serialPort1.WriteLine("8" + tb_MacToBeSet.Text);

            }
            else
            {
                MessageBox.Show("串口未打开, 请打开串口!");
            }
        }


        /*接收字符数标签，数值超过18000，自动刷新*/

        private void l_RxBytes_TextChanged(object sender, EventArgs e)
        {
            if(Convert.ToInt32(l_RxBytes.Text)>18000)
            {
                button1_Click(sender, e);
            }
        }


        /*按键单击事件，增加测试记录到 DataGridView 控件*/

        private void btn_AddRecord_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.Rows.Add();
            dataGridView1.Rows[index].Cells[0].Value = (dataGridView1.RowCount-1).ToString();
            dataGridView1.Rows[index].Cells[2].Value = tb_RefMac.Text;
            dataGridView1.Rows[index].Cells[1].Value = tb_DutMac.Text;
            dataGridView1.Rows[index].Cells[3].Value = tb_PhyRate.Text;
            dataGridView1.Rows[index].Cells[4].Value = lab_result.Text;
            dataGridView1.Rows[index].Cells[5].Value = DateTime.Now.ToString();
        }


        /*按键单击事件，从 DataGridView 控件删除一条测试记录*/

        private void btn_DeleteRecord_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count != 0)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count;i++)
                {
                    if(dataGridView1.SelectedRows[i].Index!=dataGridView1.Rows.Count-1)
                    dataGridView1.Rows.Remove(dataGridView1.SelectedRows[i]);
                }     
                for(int i=1;i<dataGridView1.RowCount;i++)
                {
                    dataGridView1.Rows[i-1].Cells[0].Value = Convert.ToString(i);
                }
            }
            
                
        }


        /*按键单击事件，将 DataGridView 控件数据导出到 Excel 文件*/

        private void btn_ExportData_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Execl files (*.xls)|*.xls|所有文件|*.*";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.Title = "Export Excel File";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName == "")
                return;
            Stream myStream;
            myStream = saveFileDialog.OpenFile();
            StreamWriter sw = new StreamWriter(myStream, System.Text.Encoding.GetEncoding(-0));

            string str = "";
            try
            {
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    if (i > 0)
                    {
                        str += "\t";
                    }
                    str += dataGridView1.Columns[i].HeaderText;
                } 
                sw.WriteLine(str);
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    string tempStr = "";
                    for (int k = 0; k < dataGridView1.Columns.Count; k++)
                    {
                        if (k > 0)
                        {
                            tempStr += "\t";
                        }
                        tempStr += @"=""";
                        tempStr += dataGridView1.Rows[j].Cells[k].Value.ToString();
                        tempStr += @""""; 
                    }
                    sw.WriteLine(tempStr);
                }
                sw.Close();
                myStream.Close();
            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            finally
            {
                sw.Close();
                myStream.Close();
            }

        }


        /*按键单击事件，判定设备合格与否*/

        private void btn_judge_Click(object sender, EventArgs e)
        {
            lab_phyrate_res.Text = "";
            lab_result.Text = "";
            string result = "";
            string str_phy="";

            Byte[] ba_phy=System.Text.Encoding.Default.GetBytes(tb_PhyRate.Text);
            foreach(Byte b in ba_phy)
            {
                if(b>='0'&&b<='9')
                {
                    str_phy=str_phy+Convert.ToChar(b);
                }
            }

            if (str_phy != "")
            {
                if (Convert.ToInt32(str_phy) < Convert.ToInt32(stdPhyrate.ToString()))
                {

                    result = "FAILED";
                    lab_phyrate_res.Text = "小于基准  " + stdPhyrate.ToString() + " -mbps";
                }
                else
                {
                    result = "PASS";
                    lab_phyrate_res.Text = "大于基准  " + stdPhyrate.ToString() + " -mbps";
                }
            }

            lab_result.Text = result;

            
        }


        /*主窗体打开串口后自动新开线程，每隔 650ms 检测一次串口接受字符标签的数值，若没有变化，则执行自动刷新函数*/

        public void autoRefresh()
        {
            while(true)
            {
                if(last_lab_RxBytes==new_lab_RxBytes)
                {
                    if(new_lab_RxBytes!=0)
                    {
                        button1_Click(null, null);
                    }                    
                } 
                
                last_lab_RxBytes = new_lab_RxBytes;                

                System.Threading.Thread.Sleep(650);
              
            }            
        }
       


    }
}
