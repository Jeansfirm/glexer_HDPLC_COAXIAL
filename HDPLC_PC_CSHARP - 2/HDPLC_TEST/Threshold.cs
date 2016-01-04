using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace HDPLC_TEST
{
    public partial class Threshold : Form
    {
        HDPLC_Information_Collector in_hic;

        [DllImport("kernel32")]
        private static extern bool WritePrivateProfileString(string section, string key, string retVal, string filePath);

        public Threshold()
        {
            InitializeComponent();
        }

        public Threshold(HDPLC_Information_Collector hic)
        {
            InitializeComponent();

            in_hic = hic;
        }

        private void Threshold_Load(object sender, EventArgs e)
        {

            tb_RefMac.Text = in_hic.refMac.ToString();
            tb_StdPhyRate.Text = in_hic.stdPhyrate.ToString();
            tb_cur.Text = in_hic.stdCurrent.ToString();
            tb_cur_dev.Text = in_hic.stdCurrent_deviation.ToString();
            tb_vol1_dev.Text = in_hic.stdVoltage1_deviation.ToString();
            tb_vol1.Text = in_hic.stdVoltage1.ToString();
            tb_vol2_dev.Text = in_hic.stdVoltage2_deviation.ToString();
            tb_vol2.Text = in_hic.stdVoltage2.ToString();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            WritePrivateProfileString("ADDRESS", "REFMAC", tb_RefMac.Text, ".\\HDPLC_TEST.ini");
            WritePrivateProfileString("STANDARD", "PHYRATE", tb_StdPhyRate.Text,".\\HDPLC_TEST.ini");
            WritePrivateProfileString("STANDARD", "VOLTAGE1", tb_vol1.Text, ".\\HDPLC_TEST.ini");            
            WritePrivateProfileString("STANDARD", "VOLTAGE2", tb_vol2.Text, ".\\HDPLC_TEST.ini");
            WritePrivateProfileString("STANDARD", "CURRENT", tb_cur.Text, ".\\HDPLC_TEST.ini");
            WritePrivateProfileString("STANDARD", "VOLTAGE1_DEV", tb_vol1_dev.Text, ".\\HDPLC_TEST.ini");
            WritePrivateProfileString("STANDARD", "VOLTAGE2_DEV", tb_vol2_dev.Text, ".\\HDPLC_TEST.ini");
            WritePrivateProfileString("STANDARD", "CURRENT_DEV", tb_cur_dev.Text, ".\\HDPLC_TEST.ini");

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }

        public string getRefMac
        {
            get
            {
                return tb_RefMac.Text;
            }
        }

        public string getStdPhyRate
        {
            get
            {
                return tb_StdPhyRate.Text;
            }
        }

        public string getVol1
        {
            get
            {
                return tb_vol1.Text;
            }
        }

        public string getVol2
        {
            get
            {
                return tb_vol2.Text;
            }
        }

        public string getCur
        {
            get
            {
                return tb_cur.Text;
            }
        }

        public string getVol1_dev
        {
            get
            {
                return tb_vol1_dev.Text;
            }
        }

        public string getVol2_dev
        {
            get
            {
                return tb_vol2_dev.Text;
            }
        }

        public string getCur_dev
        {
            get
            {
                return tb_cur_dev.Text;
            }
        }

    }
}
