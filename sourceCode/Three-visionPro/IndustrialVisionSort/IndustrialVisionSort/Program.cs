using IndustrialVisionSort.ui.Forms;
using IndustrialVisionSort.UI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndustrialVisionSort
{
    internal static class Program
    {
        [DllImport("kernel32.dll")]
        public static extern bool AllocConsole();
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            AllocConsole();   //控制台
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            //System.Windows.Forms.Application.Run(new FormMain());
            System.Windows.Forms.Application.Run(new IndustrialVisionSortingSystem());
        }
    }
}
