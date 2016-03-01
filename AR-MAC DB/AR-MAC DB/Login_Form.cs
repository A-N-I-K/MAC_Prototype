using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AR_MAC_DB
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        public User authUser(string uname, string pass)
        {
            User userObj = new User();
            userObj.valid = false;
            try
            {
                // Read the database                
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
                            userObj.perm = parts[i + 4];
                            userObj.valid = true;
                        }

                    }              
                    
                }
                file.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found!!!");
            }
            return userObj;
        }

        private void login_Click(object sender, EventArgs e)
        {
            string uid = uidTextBox.Text;
            string pwd = pwdTextBox.Text;
            User user = new User();
            user = authUser(uid, pwd);
            if (user.valid && user.perm.Equals("SO"))
            {
                this.Visible = false;
                soForm form = new soForm(user);
                form.Show();
            }
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
}
