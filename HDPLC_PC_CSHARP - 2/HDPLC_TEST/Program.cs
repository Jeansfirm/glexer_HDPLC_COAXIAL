using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HDPLC_TEST
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new HDPLC_Information_Collector());
            HDPLC_Information_Collector hdplcForm = new HDPLC_Information_Collector();
            Application.Run(hdplcForm);
            
        }
    }
}
