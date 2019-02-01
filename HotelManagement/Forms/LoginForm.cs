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
        MainForm form = new MainForm();

        public LoginForm()
        {
            InitializeComponent();
            MaximizeBox = false;
            //form.FormClosed += (s, args) => Close();
        }

        public void ResetInput()
        {
            UsernameTextbox.Text = "";
            PasswordTextbox.Text = "";
            UsernameTextbox.Select();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsernameTextbox.Text)
                || string.IsNullOrEmpty(PasswordTextbox.Text))
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu bị để trống. Xin hãy kiểm tra lại.");
                return;
            }

            string username = UsernameTextbox.Text,
                hashed_password = StringUtilities.MD5Hash(PasswordTextbox.Text);   

            Employee emp = LazyWorker.GetEmployee(username, hashed_password);
            if (emp != null && emp.Id > 0)
            {
                Hide();
                form.SetCurrentEmployee(emp);
                form.Show(this);
            }
            else
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu. Xin hãy kiểm tra lại.");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PasswordTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                LoginButton_Click(sender, new EventArgs());
            }
        }

        private void UsernameTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            PasswordTextbox_KeyDown(sender, e);
        }
    }
}
