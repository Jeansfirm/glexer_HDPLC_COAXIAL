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
    public partial class SerialConfig : Form
    {
        HDPLC_Information_Collector in_hic;

        public SerialConfig()
        {
            InitializeComponent();
            
        }

        public SerialConfig(HDPLC_Information_Collector hic)
        {
            InitializeComponent();
            in_hic = hic;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.Ports.Parity myparity;

            in_hic.serialPort1.DataBits = Convert.ToInt32(cb_DataBit.SelectedItem.ToString());
            switch(cb_Parity.SelectedItem.ToString())
            {
                case "None":
                    myparity = System.IO.Ports.Parity.None;
                    break;
                case "Odd":
                    myparity = System.IO.Ports.Parity.Odd;
                    break;
                case "Even":
                    myparity = System.IO.Ports.Parity.Even;
                    break;
                case "Mark":
                    myparity = System.IO.Ports.Parity.Mark;
                    break;
                case "Space":
                    myparity = System.IO.Ports.Parity.Space;
                    break;
                default:
                    myparity = System.IO.Ports.Parity.None;
                    break;
            }

            in_hic.serialPort1.Parity = myparity;

            in_hic.serialPort1.StopBits = (System.IO.Ports.StopBits)Enum.Parse(typeof(System.IO.Ports.StopBits), cb_StopBit.SelectedItem.ToString());

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SerialConfig_Load(object sender, EventArgs e)
        {
            cb_DataBit.SelectedItem = cb_DataBit.Items[3];
            cb_Parity.SelectedItem = cb_Parity.Items[0];
            cb_StopBit.SelectedItem = cb_StopBit.Items[1];
        }

       

 
    }
}
