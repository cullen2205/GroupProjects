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
    public partial class CustomerManageForm : Form
    {
        public CustomerManageForm()
        {
            InitializeComponent();
            LoadAllCustomer();
        }

        private void LoadAllCustomer()
        {
            LazyWorker<Customer>.LoadAllToGridView
            (
                CustomerGridView,
                new string[] 
                    {"Id", "FullName", "DateOfBirth", "Sex", "RealLifeIdNumber"}
            );

            CustomerGridView.Columns["Id"].Visible = false;

            CustomerGridView.Columns["FullName"].Width = 100;
            CustomerGridView.Columns["FullName"].HeaderText = "Họ tên";

            CustomerGridView.Columns["DateOfBirth"].AutoSizeMode 
                = DataGridViewAutoSizeColumnMode.AllCells;
            CustomerGridView.Columns["DateOfBirth"].HeaderText = "Ngày sinh";

            CustomerGridView.Columns["Sex"].Visible = false;

            CustomerGridView.Columns["RealLifeIdNumber"].Width = 100;
            CustomerGridView.Columns["RealLifeIdNumber"].HeaderText = "Số CMND";

            CustomerGridView.Columns["Filter"].Visible = false;
        }

        private void CustomerManageForm_Shown(object sender, EventArgs e)
        {
            CustomerGridView.ClearSelection();
            CustomerGridView.RowEnter += CustomerGridView_RowEnter;
        }

        private void LoadOneCustomer(Customer c)
        {
            IdNumericUpdown.Value = c.Id;
            FullNameTextbox.Text = c.FullName;
            DateOfBirthDatePicker.Value = 
                c.DateOfBirth.Date > DateOfBirthDatePicker.MaxDate
                || c.DateOfBirth.Date < DateOfBirthDatePicker.MinDate ?
                new DateTime(1990, 1, 1).Date : c.DateOfBirth.Date;
            if (c.Sex)
                FemaleRadioButton.Checked = true;
            else
                MaleRadioButton.Checked = true;
            RealLifeIdNumberTextbox.Text = c.RealLifeIdNumber;
        }

        private Customer FilledDataToCustomer()
        {
            return new Customer()
            {
                Id = Convert.ToInt32(IdNumericUpdown.Value),
                FullName = FullNameTextbox.Text,
                DateOfBirth = DateOfBirthDatePicker.Value.Date,
                Sex = FemaleRadioButton.Checked,
                RealLifeIdNumber = RealLifeIdNumberTextbox.Text
            };
        }

        private void CustomerGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            LazyWorker<Customer>.LoadOneFromGridView
            (
                CustomerGridView,
                LoadOneCustomer,
                SaveButton,
                DeleteButton
            );
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            LoadOneCustomer(new Customer());
            SaveButton.Enabled = false;
            DeleteButton.Enabled = false;
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            if
            (
                (IdNumericUpdown.Value 
                = LazyWorker<Customer>.Insert(FilledDataToCustomer())) > 0
            )
            {
                LoadAllCustomer();
                FormUtilities.NotifySuccess();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(LazyWorker<Customer>.Update(FilledDataToCustomer()))
            {
                LoadAllCustomer();
                FormUtilities.NotifySuccess();
            }
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(FormUtilities.ConfirmDeletion())
            {
                LazyWorker<Customer>.Delete(FilledDataToCustomer());
                LoadAllCustomer();
                ResetButton_Click(sender, e);
            }
        }
    }
}
