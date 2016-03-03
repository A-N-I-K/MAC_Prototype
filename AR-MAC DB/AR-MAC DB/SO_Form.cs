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
        User user = new User();
        Logger log = new Logger();

        public soForm(User u)
        {            
            InitializeComponent();
            this.user = u;
            welcomeLabel.Text = "Welcome, " + user.fname + " " + user.lname + "!";
            permComboBox.Text = "SO";
            permComboBox.Items.Add("SO");
            permComboBox.Items.Add("P");
            permComboBox.Items.Add("G");
            tablePermComboBox.Text = "G";
            tablePermComboBox.Items.Add("G");
            tablePermComboBox.Items.Add("H");
            tablePermComboBox.Items.Add("F");
            tablePermComboBox.Items.Add("E");
            tablePermComboBox.Items.Add("HF");
            tablePermComboBox.Items.Add("HE");
            tablePermComboBox.Items.Add("FE");
            tablePermComboBox.Items.Add("L");
            tablePermComboBox.Items.Add("E");
        }

        public void listUsers()
        {
            listUsersListBox.Items.Clear();
            try
            {
                StreamReader file = new StreamReader("user.db");
                string line;
                string[] tokens;
                while ((line = file.ReadLine()) != null)
                {
                    tokens = line.Split('\t');
                    listUsersListBox.Items.Add(tokens[0] + "\t" + tokens[1] + "\t" + tokens[2] + "\t" + tokens[3] + "\t" + tokens[4]);
                }
                file.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found!!!");
            }
        }

        public bool addUser(User uobject)
        {
            StreamReader fileR = new StreamReader("user.db");
            char[] delimiters = new char[] { '\t' };
            bool unique = true;
            string lineR;
            while ((lineR = fileR.ReadLine()) != null)
            {
                string[] parts = lineR.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < parts.Length; i += 5)
                {
                    if (parts[i + 2] == uobject.uid)
                    {
                        unique = false;
                    }
                }

            }
            fileR.Close();
            if (unique)
            {
                try
                {
                    StreamWriter fileW = new StreamWriter("user.db", true);
                    string lineW = uobject.fname + "\t" + uobject.lname + "\t" + uobject.uid + "\t" + uobject.pwd + "\t" + uobject.perm;
                    fileW.WriteLine(lineW);
                    fileW.Close();

                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine("File Not Found!!");
                }
            }
            listUsers();
            return unique;
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
            listUsers();
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
            listUsers();
            return found;
        }

        public void listTables()
        {
            listTablesListBox.Items.Clear();
            try
            {
                StreamReader file = new StreamReader("tables.db");
                string line;
                string[] tokens;
                while ((line = file.ReadLine()) != null)
                {
                    tokens = line.Split('\t');
                    listTablesListBox.Items.Add(tokens[0] + "\t" + tokens[1]);
                }
                file.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found!!!");
            }
        }

        public bool modifyTable(string table, string newPerm)
        {
            bool found = false;
            try
            {
                StreamWriter tempFile = new StreamWriter("tempT.db", true);
                StreamReader file = new StreamReader("tables.db");
                char[] delimiters = new char[] { '\t' };
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    string[] parts = line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                    
                    if (parts[0] == table)
                    {
                        line = parts[0] + "\t" + newPerm;
                        tempFile.WriteLine(line);
                        found = true;
                    }
                    else
                    {
                        tempFile.WriteLine(line);
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
            File.Delete("tables.db");
            File.Move("tempT.db", "tables.db");
            File.Delete("tempT.db");
            listTables();
            return found;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {            
            this.Hide();
            loginForm form = new loginForm();
            form.Show();
            log.append(this.user.uid + " has successfully logged out", "NOTICE");
        }

        private void listUsersButton_Click(object sender, EventArgs e)
        {
            listUsersListBox.Items.Clear();
            listUsers();
            log.append(this.user.uid + " has viewed the list of users", "NOTICE");
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            if (fnameTextBox.Text!="" && lnameTextBox.Text !="" && uidTextBox.Text !="" && pwdTextBox.Text != "" && permComboBox.Text != "")
            {
                User user = new User();
                user.fname = fnameTextBox.Text;
                user.lname = lnameTextBox.Text;
                user.uid = uidTextBox.Text;
                user.pwd = pwdTextBox.Text;
                user.perm = permComboBox.Text;
                user.valid = true;
                if (addUser(user))
                {
                    log.append(this.user.uid + " has added new user : " + uidTextBox.Text, "NOTICE");
                }
                else
                {
                    MessageBox.Show("The user " + uidTextBox.Text + "already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    log.append(this.user.uid + " attempted to add a duplicate user : " + uidTextBox.Text, "ERROR");
                }
            }
            else
            {
                MessageBox.Show("Please provide all the information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                log.append(this.user.uid + " attempted to add a user with incomplete information.", "ERROR");
            }
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            if (fnameTextBox.Text != "" && lnameTextBox.Text != "" && uidTextBox.Text != "" && pwdTextBox.Text != "" && permComboBox.Text != "")
            {
                string[] tokens;
                tokens = listUsersListBox.Text.Split('\t');
                bool successful = deleteUser(tokens[2]);
                if (successful)
                {
                    log.append(this.user.uid + " has deleted the user : " + uidTextBox.Text, "NOTICE");
                }
                else
                {
                    MessageBox.Show("The user " + user.uid + "does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    log.append(this.user.uid + " has attempted to delete an invalid user : " + uidTextBox.Text, "ERROR");
                }
                    
            }
            else
            {
                MessageBox.Show("Please provide all the information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                log.append(this.user.uid + " attempted to delete a user with incomplete information.", "ERROR");
            }

        }

        private void viewLogButton_Click(object sender, EventArgs e)
        {
            logListBox.Items.Clear();
            string line;
            line = "";
            line = log.readNext(line);            
            while (line!=null)
            {
                if (noticeCheckBox.Checked == true && line.Substring(0, 1).Equals("N"))
                {
                    logListBox.Items.Add(line);
                }
                if (errorCheckBox.Checked == true && line.Substring(0, 1).Equals("E"))
                {
                    logListBox.Items.Add(line);
                }
                if (violationCheckBox.Checked == true && line.Substring(0, 1).Equals("V"))
                {
                    logListBox.Items.Add(line);
                }
                line = log.readNext(line);
            }
            log.append(this.user.uid + " has viewed the log ", "NOTICE");
        }

        private void listUsersListBox_Click(object sender, EventArgs e)
        {
            string[] tokens;
            tokens = listUsersListBox.Text.Split('\t');
            fnameTextBox.Text = tokens[0];
            lnameTextBox.Text = tokens[1];
            uidTextBox.Text = tokens[2];
            pwdTextBox.Text = tokens[3];
            permComboBox.Text = tokens[4];
        }

        private void modifyUserButton_Click(object sender, EventArgs e)
        {
            if (fnameTextBox.Text != "" && lnameTextBox.Text != "" && uidTextBox.Text != "" && pwdTextBox.Text != "" && permComboBox.Text != "")
            {
                bool successful = modifyUser(uidTextBox.Text, permComboBox.Text);
                if (successful)
                {
                    log.append(this.user.uid + " has modified the access level of user : " + uidTextBox.Text + " to : " + permComboBox.Text, "NOTICE");
                }
                else
                {
                    MessageBox.Show("The user " + user.uid + "does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    log.append(this.user.uid + " has attempted to modify an invalid user : " + uidTextBox.Text, "ERROR");
                }
            }
            else
            {
                MessageBox.Show("Please provide all the information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                log.append(this.user.uid + " attempted to modify a user with incomplete information.", "ERROR");
            }
        }

        private void listTablesButton_Click(object sender, EventArgs e)
        {
            listTables();
            log.append(this.user.uid + " has viewed the list of tables", "NOTICE");
        }

        private void modifyTableButton_Click(object sender, EventArgs e)
        {
            if (tableNameTextBox.Text != "" && tablePermComboBox.Text != "")
            {
                bool successful = modifyTable(tableNameTextBox.Text, tablePermComboBox.Text);
                if (successful)
                {
                    log.append(this.user.uid + " has modified the access level of table : " + tableNameTextBox.Text + " to : " + tablePermComboBox.Text, "NOTICE");
                }
                else
                {
                    MessageBox.Show("The table " + tableNameTextBox.Text + "does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    log.append(this.user.uid + " attempted to modify a table with incomplete information.", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("Please provide all the information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                log.append(this.user.uid + " attempted to modify a table with incomplete information.", "ERROR");
            }
        }

        private void listTablesListBox_Click(object sender, EventArgs e)
        {
            string[] tokens;
            tokens = listTablesListBox.Text.Split('\t');
            tableNameTextBox.Text = tokens[0];
            tablePermComboBox.Text = tokens[1];
        }

        private void noticeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            logListBox.Items.Clear();
            string line;
            line = "";
            line = log.readNext(line);
            while (line != null)
            {
                if (noticeCheckBox.Checked == true && line.Substring(0, 1).Equals("N"))
                {
                    logListBox.Items.Add(line);
                }
                if (errorCheckBox.Checked == true && line.Substring(0, 1).Equals("E"))
                {
                    logListBox.Items.Add(line);
                }
                if (violationCheckBox.Checked == true && line.Substring(0, 1).Equals("V"))
                {
                    logListBox.Items.Add(line);
                }
                line = log.readNext(line);
            }
        }

        private void errorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            logListBox.Items.Clear();
            string line;
            line = "";
            line = log.readNext(line);
            while (line != null)
            {
                if (noticeCheckBox.Checked == true && line.Substring(0, 1).Equals("N"))
                {
                    logListBox.Items.Add(line);
                }
                if (errorCheckBox.Checked == true && line.Substring(0, 1).Equals("E"))
                {
                    logListBox.Items.Add(line);
                }
                if (violationCheckBox.Checked == true && line.Substring(0, 1).Equals("V"))
                {
                    logListBox.Items.Add(line);
                }
                line = log.readNext(line);
            }
        }

        private void violationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            logListBox.Items.Clear();
            string line;
            line = "";
            line = log.readNext(line);
            while (line != null)
            {
                if (noticeCheckBox.Checked == true && line.Substring(0, 1).Equals("N"))
                {
                    logListBox.Items.Add(line);
                }
                if (errorCheckBox.Checked == true && line.Substring(0, 1).Equals("E"))
                {
                    logListBox.Items.Add(line);
                }
                if (violationCheckBox.Checked == true && line.Substring(0, 1).Equals("V"))
                {
                    logListBox.Items.Add(line);
                }
                line = log.readNext(line);
            }
        }
    }
}