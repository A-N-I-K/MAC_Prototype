using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AR_MAC_DB
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
            Application.Run(new loginForm());
        }
    }

    public class User
    {
        public string fname;
        public string lname;
        public string uid;
        public string pwd;
        public string perm;
        public bool valid;
    }

    public class Logger
    {
        public void append(String info, String status)
        {
            StreamWriter file = new StreamWriter("log.db", true);
            string time = DateTime.Now.ToString("hh:mm:ss tt");
            file.WriteLine(status + "\t|\t" + time + "\t|\t" + info);
            file.Close();
        }

        public string readNext(String info)
        {
            StreamReader file = new StreamReader("user.db");
            string line;
            if (info.Equals(""))
            {
                if ((line = file.ReadLine()) != null)
                {
                    return line;
                }
            }
            while ((line = file.ReadLine()) != null)
            {
                if (line.Equals(info))
                {
                    return file.ReadLine();
                }
            }
            return "";
        }
    }
}