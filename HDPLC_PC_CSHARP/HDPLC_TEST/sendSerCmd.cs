using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HDPLC_TEST
{
    public partial class sendSerCmd : Form
    {
        HDPLC_Information_Collector in_hic;

        public sendSerCmd()
        {
            InitializeComponent();
        }

        public sendSerCmd(HDPLC_Information_Collector hic)
        {
            InitializeComponent();
            in_hic = hic;
        }

        private void sendSerCmd_Load(object sender, EventArgs e)
        {

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (in_hic.serialPort1.IsOpen)
            {
                in_hic.serialPort1.WriteLine(tb_Cmd.Text);
                
            }
            else
            {
                MessageBox.Show("串口未打开, 请打开串口!");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
