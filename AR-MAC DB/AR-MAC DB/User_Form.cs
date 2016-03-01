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

        private void commandTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //consoleListBox.Items.Add(commandTextBox.Text);
                consoleListBox.Items.Insert(0, commandTextBox.Text);
                commandTextBox.Text=String.Empty;
            }
        }
    }
}
