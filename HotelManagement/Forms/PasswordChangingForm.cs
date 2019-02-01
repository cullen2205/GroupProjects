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
    public partial class PasswordChangingForm : Form
    {
        Employee emp;
        public PasswordChangingForm(Employee emp)
        {
            InitializeComponent();
            LoadEmployee(emp);
        }

        private void LoadEmployee(Employee emp)
        {
            this.emp = emp;
            this.emp = LazyLoader<Employee>.Get(emp.Id);
            UsernameTextbox.Text = this.emp.Username;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (StringUtilities.MD5Hash(OldPasswordTextbox.Text) == emp.Password)
            {
                if(NewPasswordTextbox.Text == RepeatNewPasswordTextbox.Text)
                {
                    emp.Password = StringUtilities.MD5Hash(NewPasswordTextbox.Text);
                    LazyLoader<Employee>.Update(emp);
                    MessageBox.Show("Đổi mật khẩu thành công!");
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới không trùng lặp!");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng!");
            }
                
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
