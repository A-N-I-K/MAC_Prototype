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


        public UserClass authUser(string uname, string pass)
        {
            UserClass userObj = new UserClass();
            userObj.valid = false;

            try
            {
                // Read the database
                int counter = 0;
                string line;
                char[] delimiters = new char[] { '\t' };
                System.IO.StreamReader file = new System.IO.StreamReader("user.db");
                while ((line = file.ReadLine()) != null)
                {
                    string[] parts = line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < parts.Length; i += 5)
                    {
                        if (parts[i + 2] == uname && parts[i + 3] == pass)  //validating user name and password
                        {
                            userObj.fname = parts[i];
                            userObj.lname = parts[i + 1];
                            userObj.uid = parts[i + 2];
                            userObj.pwd = parts[i + 3];
                            userObj.permission = parts[i + 4];
                            userObj.valid = true;
                        }

                    }
                    Console.WriteLine(userObj.fname);
                    counter++;
                }

                file.Close();
            }

            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found!!!");
            }
            return userObj;

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
