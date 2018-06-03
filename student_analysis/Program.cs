using System;
using System.Windows.Forms;

namespace student_analysis
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //Application.Run(new uspevaemostModule());
            //there is a change for sync try
        }        
    }

    static class auth
    {
        public static string login { get; set; }
        public static string pass { get; set; }
    }

    static class info
    {
        public const string progname = "Облік студентів";
        public static int[] minSize = new int[2] { 457, 360 };
    }
}
