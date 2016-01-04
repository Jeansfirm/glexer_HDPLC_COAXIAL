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
    public partial class TestInfo : Form
    {
        HDPLC_Information_Collector in_hic;

        public TestInfo(HDPLC_Information_Collector hic)
        {
            InitializeComponent();
            in_hic = hic;
        }

        public TestInfo()
        {
            InitializeComponent();

        }

        private void tb_cachedir_Load(object sender, EventArgs e)
        {
            tb_tester.Text = in_hic.tester;
            tb_testcom.Text = in_hic.testcom;
            tb_cachedir.Text = in_hic.cachedir;
        }

        public string getTester
        {
            get
            {
                return tb_tester.Text;
            }
        }

        public string getTestcom
        {
            get
            {
                return tb_testcom.Text;
            }
        }

        public string getCachecir
        {
            get
            {
                return tb_cachedir.Text;
            }
        }

        private void btn_browse_Click(object sender, EventArgs e)
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
            tb_cachedir.Text = saveFileDialog.FileName;
        }
    }
}
