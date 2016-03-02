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
        Logger log = new Logger();

        public loginForm()
        {
            InitializeComponent();
        }

        public User authUser(string uname, string pass)
        {
            User user = new User();
            user.valid = false;
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
                            user.fname = parts[i];
                            user.lname = parts[i + 1];
                            user.uid = parts[i + 2];
                            user.pwd = parts[i + 3];
                            user.perm = parts[i + 4];
                            user.valid = true;
                        }

                    }              
                    
                }
                file.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found!!!");
            }
            return user;
        }

        private void login_Click(object sender, EventArgs e)
        {
            string uid = uidTextBox.Text;
            string pwd = pwdTextBox.Text;
            User user = new User();
            user = authUser(uid, pwd);
            if (user.valid)
            {
                log.append(user.uid + " has successfully logged in with " + user.perm + " privileges.", "NOTICE");
                this.Visible = false;
                if (user.perm.Equals("SO"))
                {
                    soForm form = new soForm(user);
                    form.Show();
                } else
                {
                    userForm form = new userForm(user);
                    form.Show();
                }
            }
            else
            {

            }
        }
    }
}
