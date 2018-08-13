using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Cases_Generator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static string problemset_directory;
        public static string problemset_exe;
        public static string contest_directory;
        public static string contest_exe;
        public static int type;
        public static List<int> contest_pId = new List<int>();
        public static List<int> problemset_pId = new List<int>();
        public static List<int> all_pId = new List<int>();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmTCParser());
        }
    }
}
