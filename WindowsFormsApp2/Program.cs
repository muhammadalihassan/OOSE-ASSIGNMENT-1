using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    static class Program
    {
        public static int total = 0;
        public static string username;
        public static string password;
        public static int[] last;
        public static int Mathematics = 500;
        public static int DSA = 800;
        public static int OOSE = 1000;
        public static int Java = 500;
        public static int English = 450;
        public static int CVT = 400;
        public static int Islamiat = 600;

        public static int qmaths = 0;
        public static int qdsa = 0;
        public static int qoose = 0;
        public static int qjava = 0;
        public static int qenglish= 0;
        public static int qcvt = 0;
        public static int qisl = 0;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
          
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
