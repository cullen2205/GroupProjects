using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextbox.Text,
                hashed_password = HashingUtilities.MD5Hash(PasswordTextbox.Text);

            if(LazyWorker.UserExists(username, hashed_password))
            {
                Hide();
                MainForm form = new MainForm();
                form.FormClosed += (s, args) => Close();
                form.Show();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
