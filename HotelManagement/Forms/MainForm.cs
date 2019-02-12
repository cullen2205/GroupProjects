using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace HotelManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Employee e;
        public void SetCurrentEmployee(Employee e)
        {
            this.e = e;
            if (!e.IsAdmin)
                manageEmployeeToolStripMenuItem.Enabled = false;
        }

        private void manageEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EmployeeManageForm().Show();
        }

        private void manageRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PasswordChangingForm(this.e).Show();
        }

        private void manageServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ServiceManageForm().Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            (Owner as LoginForm).ResetInput();
            Owner.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Owner.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        

        private void manageCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CustomerManageForm().Show();
        }
    }
}
