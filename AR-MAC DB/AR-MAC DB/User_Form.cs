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
    public partial class userForm : Form
    {
        public userForm(User user)
        {
            InitializeComponent();
        }

        public bool queryCheckSelect(string query, string uid)
        {
            if (queryType(query) != "select")
                return false;
            else
            {
                query = query.Replace(" ", String.Empty);
                query = query.ToLower();
                int from = query.IndexOf("from");
                int where = query.IndexOf("where");


                string tables = query.Substring(from + 4, where - from - 4);


                char[] delimiters = new char[] { ',' };
                string[] parts = tables.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                int found = 0;
                for (int i = 0; i < parts.Length; i++)
                {
                    if (canRead(uid, parts[i]))    //pass parts[i] i.e one of the table names to a function which checks the database  whether the user has permission to access the table.
                        found++;
                }

                if (found > 0)
                    return true;
                else
                    return false;
            }
        }

        public bool queryCheckInsert(string query, string uid)
        {
            if (queryType(query) != "insert")
                return false;
            else
            {
                query = query.Replace(" ", String.Empty);
                query = query.ToLower();
                int into = query.IndexOf("into");
                int bracket = query.IndexOf("(");


                string table = query.Substring(into + 4, bracket - into - 4);

                if (canWrite(uid, table))                    //pass table to a function which checks the database whether the user has permission to access the table.
                    return true;
                else
                    return false;
            }
        }

        public string queryType(string query)
        {
            query = query.Replace(" ", String.Empty);
            query = query.ToLower();
            string type = query.Substring(0, 6);
            return type;
        }

        public string getAccessCode(string accessLevel)
        {
            if (accessLevel == "G")
                return "G";
            else if (accessLevel == "H")
                return "GH";
            else if (accessLevel == "F")
                return "GF";
            else if (accessLevel == "E")
                return "GE";
            else if (accessLevel == "HF")
                return "GHGF";
            else if (accessLevel == "HE")
                return "GHGE";
            else if (accessLevel == "FE")
                return "GFGE";
            else if (accessLevel == "L")
                return "GHGFGHGEGFGE";
            else
                return "NOACCESS";             
        }       

        public bool canRead(string uid, string table)
        {

            StreamReader users = new StreamReader("user.db");
            StreamReader tables = new StreamReader("tables.db");
            string line, uAccessLevel="NO", tAccessLevel="NO";

            char[] delimiters = new char[] { '\t' };
            while ((line = users.ReadLine()) != null)
            {
                string[] parts = line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                if (parts[2] == uid)                
                    uAccessLevel = parts[4];                

            }

            while ((line = tables.ReadLine()) != null)
            {
                string[] parts = line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                if (parts[0] == table)
                    tAccessLevel = parts[1];
                
            }

            string uaccessCode = getAccessCode(uAccessLevel);            
            string taccessCode = getAccessCode(tAccessLevel);           

            if (uaccessCode.Contains(taccessCode))
                return true;
            else
                return false;
        }

        public bool canWrite(string uid, string table)
        {

            StreamReader users = new StreamReader("user.db");
            StreamReader tables = new StreamReader("tables.db");
            string line, uAccessLevel = "NO", tAccessLevel = "NO";

            char[] delimiters = new char[] { '\t' };
            while ((line = users.ReadLine()) != null)
            {
                string[] parts = line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                if (parts[2] == uid)
                    uAccessLevel = parts[4];               

            }

            while ((line = tables.ReadLine()) != null)
            {
                string[] parts = line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                if (parts[0] == table)
                    tAccessLevel = parts[1];                
            }

            string uaccessCode = getAccessCode(uAccessLevel);            
            string taccessCode = getAccessCode(tAccessLevel);          

            if (taccessCode.Contains(uaccessCode))
                return true;
            else
                return false;
        }



        private void commandTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string type = queryType(commandTextBox.Text);
                consoleListBox.Items.Insert(0, commandTextBox.Text);
                //consoleListBox.Items.Insert(0, type); //For query analysis
                commandTextBox.Text = String.Empty;
            }
        }
    }
}
