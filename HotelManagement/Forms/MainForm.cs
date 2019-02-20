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
        BillDisplay selectedBill;

        public void SetCurrentEmployee(Employee e)
        {
            this.e = e;
            if (!e.IsAdmin)
                manageEmployeeToolStripMenuItem.Enabled = false;
        }

        public void SetCurrentBill(BillDisplay bill)
        {
            selectedBill = bill;
            //TotalPriceNumericUpDown.Value = bill.TotalPrice;

            LoadAllServices();
            LoadAllCustomers();
            LoadAllEmployees();

            CustomerComboBox.SelectedValue = bill.Customer_.Id;
            EmployeeComboBox.SelectedValue = bill.Employee_.Id;
        }
    
        private void LoadAllServices()
        {
            LazyWorker<ServiceMapped>.LoadAllToGridView
            (
                ServiceListGridView,
                new string[] 
                {
                    "Id", "ServiceName", "Price", "RoomId",
                    "BelongToRoom", "Count", "BillId"
                },
                LessLazyWorker.GetMappedServiceByBill(selectedBill.Id)
            );

            ServiceListGridView.Columns["Id"].Visible = false;
            ServiceListGridView.Columns["RoomId"].Visible = false;
            ServiceListGridView.Columns["BillId"].Visible = false;
            ServiceListGridView.Columns["Filter"].Visible = false;
            ServiceListGridView.Columns["BillDetailId"].Visible = false;

            ServiceListGridView.Columns["ServiceName"].HeaderText = "Tên dịch vụ";
            ServiceListGridView.Columns["Price"].HeaderText = "Giá";
            ServiceListGridView.Columns["Count"].HeaderText = "Số lượng";
            ServiceListGridView.Columns["BelongToRoom"].HeaderText = "Thuộc về phòng";

            ServiceListGridView.Columns["ServiceName"].Width = 150;
            ServiceListGridView.Columns["Price"].DefaultCellStyle.Format = "### ### ### ###";
            ServiceListGridView.Columns["Price"].AutoSizeMode
                = DataGridViewAutoSizeColumnMode.AllCells;
            ServiceListGridView.Columns["Count"].Width = 100;
            ServiceListGridView.Columns["BelongToRoom"].AutoSizeMode 
                = DataGridViewAutoSizeColumnMode.AllCells;

            //
            ServiceComboBox.DataSource = LessLazyWorker.GetAllServices();
            ServiceComboBox.ValueMember = "Id";
            ServiceComboBox.DisplayMember = "DisplayString";

            TotalPriceNumericUpDown.Value 
                = LessLazyWorker.TotalPriceOfBill(selectedBill.Id);
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
            EmployeeComboBox.DataSource = LazyWorker<Employee>.GetAll();
            EmployeeComboBox.DisplayMember = "Username";
            EmployeeComboBox.ValueMember = "Id";

            //EmployeeComboBox.Items.Insert(0, new Employee());
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
        }

        private BillDetail FilledDataToBillDetail()
        {
            return new BillDetail()
            {
                Id = selectedService.BillDetailId,
                ServiceId = Convert.ToInt32(ServiceComboBox.SelectedValue),
                Count = Convert.ToInt32(ServiceCountNumericUpDown.Value),
                BillId = selectedBill.Id
            };
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
            if(LazyWorker<BillDetail>.Update(FilledDataToBillDetail()))
            {
                LoadAllServices();
                FormUtilities.NotifySuccess();
            }
            else
            {
                FormUtilities.NotifyFailure();
            }
        }

        private void AddServiceButton_Click(object sender, EventArgs e)
        {
            if (LazyWorker<BillDetail>.Insert(FilledDataToBillDetail()) > 0)
            {
                LoadAllServices();
                FormUtilities.NotifySuccess();
            }
            else
            {
                FormUtilities.NotifyFailure();
            }
        }

        private void RemoveServiceButton_Click(object sender, EventArgs e)
        {
            if (LazyWorker<BillDetail>.Delete(FilledDataToBillDetail()))
            {
                LoadAllServices();
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
    }
}
