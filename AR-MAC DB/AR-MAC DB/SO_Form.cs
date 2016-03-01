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
    public partial class soForm : Form
    {
        public soForm(User user)
        {
            InitializeComponent();
            welcomeLabel.Text = "Welcome, " + user.fname + " " + user.lname + "!";
        }

        public void listUsers()
        {
            try
            {
                StreamReader file = new StreamReader("user.db");
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    listUsersListBox.Items.Add(line);
                }
                file.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found!!!");
            }

        }

        public void addUser(User uobject)
        {
            try
            {
                StreamWriter file = new StreamWriter("user.db", true);
                string line = uobject.fname + "\t" + uobject.lname + "\t" + uobject.uid + "\t" + uobject.pwd + "\t" + uobject.perm;
                file.WriteLine(line);
                file.Close();

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File Not Found!!");
            }
        }

        public bool deleteUser(string uid)
        {
            bool found = false;
            try{

                StreamWriter tempFile = new StreamWriter("temp.db", true);
                StreamReader file = new StreamReader("user.db");
                char[] delimiters = new char[] { '\t' };
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    string[] parts = line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < parts.Length; i += 5)
                    {
                        if (parts[i + 2] == uid)
                        {
                            found = true;
                            continue;
                        }
                        else
                        {
                            tempFile.WriteLine(line);
                        }

                    }

                }

                tempFile.Close();
                file.Close();

            }
            catch (FileNotFoundException e1)
            {
                Console.WriteLine("File Not Found!!");
            }
            catch (IOException e2)
            {
                Console.WriteLine("IOException!!");
            }
            File.Delete("user.db");
            File.Move("temp.db", "user.db");
            File.Delete("temp.db");
            return found;
        }

        public bool modifyUser(string uid, string newPerm)
        {
            bool found = false;
            try{

                StreamWriter tempFile = new StreamWriter("temp.db", true);
                StreamReader file = new StreamReader("user.db");
                char[] delimiters = new char[] { '\t' };
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    string[] parts = line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < parts.Length; i += 5)
                    {
                        if (parts[i + 2] == uid)
                        {
                            line = parts[i] + "\t" + parts[i + 1] + "\t" + parts[i + 2] + "\t" + parts[i + 3] + "\t" + newPerm;
                            tempFile.WriteLine(line);
                            found = true;
                        }
                        else
                        {
                            tempFile.WriteLine(line);
                        }

                    }

                }

                tempFile.Close();
                file.Close();

            }
            catch (FileNotFoundException e1)
            {
                Console.WriteLine("File Not Found!!");
            }
            catch (IOException e2)
            {
                Console.WriteLine("IOException!!");
            }
            File.Delete("user.db");
            File.Move("temp.db", "user.db");
            File.Delete("temp.db");
            return found;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm form = new loginForm();
            form.Show();
        }

        private void listUsersButton_Click(object sender, EventArgs e)
        {
            listUsersListBox.Items.Clear();
            listUsers();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            fnameTextBox.Visible = true;
            lnameTextBox.Visible = true;
            uidTextBox.Visible = true;
            pwdTextBox.Visible = true;
            permComboBox.Visible = true;
            submitButton.Visible = true;
            permComboBox.Text = "SO";
            permComboBox.Items.Add("SO");
            permComboBox.Items.Add("P");
            permComboBox.Items.Add("G");
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.fname = fnameTextBox.Text;
            user.lname = lnameTextBox.Text;
            user.uid = uidTextBox.Text;
            user.pwd = pwdTextBox.Text;
            user.perm = permComboBox.Text;
            user.valid = true;
            addUser(user);
        }
    }
}