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
    public partial class soForm : Form
    {
        public soForm(User user)
        {
            InitializeComponent();
            welcomeLabel.Text = "Welcome, " + user.fname + " " + user.lname + "!";
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm form = new loginForm();
            form.Show();
        }
    }
}