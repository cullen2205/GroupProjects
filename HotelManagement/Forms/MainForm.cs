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

        private void manageEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EmployeeManageForm().Show();
        }

        private void manageRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ConfigUtilities.SetConfig("DatabasePath", openFileDialog1.FileName);
            }
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(HashingUtilities.MD5Hash("admin"));
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
            }
        }
    }
}
