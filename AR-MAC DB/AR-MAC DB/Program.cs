using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AR_MAC_DB
{
    class UserClass
    {
        public string fname;
        public string lname;
        public string uid;
        public string pwd;
        public string permission;
        public bool valid;

        public void listUser()
        {
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader("user.db");
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found!!!");
            }

        }

    }

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
            Application.Run(new loginForm());
        }
    }
}
