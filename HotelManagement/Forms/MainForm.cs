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
            SetCurrentBill(new BillDisplay());
        }

        Employee e;

        public void SetCurrentEmployee(Employee e)
        {
            this.e = e;
            if (!e.IsAdmin)
                manageEmployeeToolStripMenuItem.Enabled = false;
        }
        
        private void LoadAllServices()
        {
            //
            var list = LessLazyWorker.GetAllServices();
            list.Insert(0, new ServiceDisplay());
            ServiceComboBox.DataSource = list;

            ServiceComboBox.ValueMember = "Id";
            ServiceComboBox.DisplayMember = "DisplayString";

            TotalPriceNumericUpDown.Value 
                = LessLazyWorker.TotalPriceOfBill(currentBill.Id);
        }

        private void LoadAllCustomers()
        {
            var list = LazyWorker<Customer>.GetAll();
            list.Insert(0, new Customer());

            CustomerComboBox.DataSource = list;
            CustomerComboBox.DisplayMember = "FullName";
            CustomerComboBox.ValueMember = "Id";
        }

        private void LoadAllEmployees()
        {
            var list = LazyWorker<Employee>.GetAll();
            list.Insert(0, new Employee());

            EmployeeComboBox.DataSource = list;
            EmployeeComboBox.DisplayMember = "Username";
            EmployeeComboBox.ValueMember = "Id";
        }

        private void manageEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EmployeeManageForm().Show();
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

        private void manageBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BillManageForm().Show(this);
        }
        
        private void LoadOneCustomer(Customer customer)
        {
            CustomerFullNameTextBox.Text = customer.FullName;

            if (customer.DateOfBirth.Date < CustomerDateOfBirthPicker.MinDate)
                CustomerDateOfBirthPicker.Value = CustomerDateOfBirthPicker.MinDate;
            else if (customer.DateOfBirth.Date > CustomerDateOfBirthPicker.MaxDate)
                CustomerDateOfBirthPicker.Value = CustomerDateOfBirthPicker.MaxDate;
            else
                CustomerDateOfBirthPicker.Value = customer.DateOfBirth.Date;

            CustomerMaleButton.Checked = 
                !(CustomerFemaleButton.Checked = customer.Sex);

            CustomerRLIDTextBox.Text = customer.RealLifeIdNumber;
        }

        private void LoadOneEmployee(Employee employee)
        {

        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer c = CustomerComboBox.SelectedItem as Customer;
            LoadOneCustomer(c);
            if (c.Id > 0)
                SaveCustomerButton.Enabled 
                    = DeleteCustomerButton.Enabled = true;
            else
                SaveCustomerButton.Enabled 
                    = DeleteCustomerButton.Enabled = false;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            ServiceListGridView.ClearSelection();
            ServiceListGridView.RowEnter += ServiceListGridView_RowEnter;
        }

        ServiceMapped selectedService;
        private void LoadOneService(ServiceMapped service)
        {
            selectedService = new ServiceMapped()
            {
                Id = service.Id,
                ServiceName = service.ServiceName,
                Price = service.Price,
                RoomId = service.RoomId,
                Count = service.Count,
                BillId = service.BillId,
                BillDetailId = service.BillDetailId
            };

            ServiceComboBox.SelectedValue = selectedService.Id;
            ServiceCountNumericUpDown.Value = selectedService.Count;
        }
        
        private void ServiceListGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            LazyWorker<ServiceMapped>.LoadOneFromGridView
            (
                ServiceListGridView,
                LoadOneService,
                SaveServiceButton,
                RemoveServiceButton
            );
        }

        private void SaveServiceButton_Click(object sender, EventArgs e)
        {
            if (currentBill.Id == 0 || ServiceComboBox.SelectedIndex == 0)
            {
                FormUtilities.NotifyFailure();
                return;
            }
            if (LazyWorker<BillDetail>.Update(FilledDataToBillDetail()))
            {
                LoadBillsServices();
                FormUtilities.NotifySuccess();
            }
            else
            {
                FormUtilities.NotifyFailure();
            }
        }

        private void AddServiceButton_Click(object sender, EventArgs e)
        {
            if(currentBill.Id == 0 || ServiceComboBox.SelectedIndex == 0)
            {
                FormUtilities.NotifyFailure();
                return;
            }
            if (LazyWorker<BillDetail>.Insert(FilledDataToBillDetail()) > 0)
            {
                LoadBillsServices();
                FormUtilities.NotifySuccess();
            }
            else
            {
                FormUtilities.NotifyFailure();
            }
        }

        private void RemoveServiceButton_Click(object sender, EventArgs e)
        {
            if(currentBill.Id == 0)
            {
                FormUtilities.NotifyFailure();
                return;
            }
            if (LazyWorker<BillDetail>.Delete(FilledDataToBillDetail()))
            {
                LoadBillsServices();
                FormUtilities.NotifySuccess();
            }
            else
            {
                FormUtilities.NotifyFailure();
            }
        }

        private void ServiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServiceDisplay service = ServiceComboBox.SelectedItem as ServiceDisplay;
            ServicePriceNumericUpDown.Value = service.Price;
        }

        private void ResetCustomerButton_Click(object sender, EventArgs e)
        {
            CustomerComboBox.SelectedIndex = 0;
        }

    }
}
