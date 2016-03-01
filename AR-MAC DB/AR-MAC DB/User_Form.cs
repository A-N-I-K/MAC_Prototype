using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AR_MAC_DB
{
    public partial class userForm : Form
    {
        public userForm(User user)
        {
            InitializeComponent();
        }

        public void queryCheckSelect(string query)
        {
            query = query.Replace(" ", String.Empty);
            query = query.ToLower();
            int from = query.IndexOf("from");
            int where = query.IndexOf("where");


            string tables = query.Substring(from + 4, where - from - 4);


            char[] delimiters = new char[] { ',' };
            string[] parts = tables.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < parts.Length; i++)
            {
                //pass parts[i] i.e one of the table names to a function which checks the database  whether the user has permission to access the table.
            }

        }

        public void queryCheckInsert(string query)
        {
            query = query.Replace(" ", String.Empty);
            query = query.ToLower();
            int into = query.IndexOf("into");
            int bracket = query.IndexOf("(");


            string table = query.Substring(into + 4, bracket - into - 4);

            //pass table to a function which checks the database whether the user has permission to access the table.

        }

        public string queryType(string query)
        {
            query = query.Replace(" ", String.Empty);
            query = query.ToLower();
            string type = query.Substring(0, 6);
            return type;
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
