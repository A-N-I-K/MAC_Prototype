using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static void queryCheck(string query)
        {
            query = query.Replace(" ", String.Empty);
            query = query.ToLower();
            int from = query.IndexOf("from");
            int where = query.IndexOf("where");
            //Console.WriteLine(query);
            //Console.WriteLine(where);

            string tables = query.Substring(from + 4, where - from - 4);
            //Console.WriteLine(tables);

            char[] delimiters = new char[] { ',' };
            string[] parts = tables.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < parts.Length; i++)
            {
                //pass parts[i] i.e one of the table names to a function which checks the database to whether the user has permission to access the table.
            }

        }


    }
}
