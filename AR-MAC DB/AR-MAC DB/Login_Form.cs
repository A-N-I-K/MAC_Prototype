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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        public User authUser(string uid, string pwd)
        {
            User user = new User();
            user.fname = "Anik";
            user.lname = "Momtaz";
            user.uid = uid;
            user.pwd = pwd;
            user.perm = "SO";
            user.valid = true;
            return user;
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
