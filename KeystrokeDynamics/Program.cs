using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeystrokeDynamics {
    static class Program {
        public static string currentUser = "";
        public static int currentUserID;
        public const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database\TestDB.mdf;Integrated Security=True";
        public const string wordsFilePath = @"..\..\assets\words.txt";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LaunchScreen());
        }
    }
}
