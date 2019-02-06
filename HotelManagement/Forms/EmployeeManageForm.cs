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
    public partial class EmployeeManageForm : Form
    {
        public EmployeeManageForm()
        {
            InitializeComponent();
            LoadAllEmployees();
        }

        private void LoadAllEmployees()
        {
            var list = LazyWorker<Employee>.GetAll();
            var table = LazyWorker<Employee>.ListToDataTable(list);
            LazyLoader.SetColumnsOrder
            (
                table, "Id", "Username", "Password", "IsAdmin", 
                "RealLifeIdNumber", "FullName", "DateOfBirth", "Sex",
                "Address", "Phonenumber"
            );
            table.Columns.Add("Filter");
            foreach(DataRow row in table.Rows)
                row["Filter"] = LazyWorker<Employee>
                    .DataRowToObject(row)
                    .ToFilteringString();

            EmployeeGridView.DataSource = table;

            EmployeeGridView.Columns["Id"].Visible = false;

            EmployeeGridView.Columns["Username"].Width = 110;
            EmployeeGridView.Columns["Username"].HeaderText = "Tên đăng nhập";

            EmployeeGridView.Columns["Password"].Width = 100;
            EmployeeGridView.Columns["Password"].HeaderText = "Mật khẩu";
            EmployeeGridView.Columns["Password"].Visible = false;

            EmployeeGridView.Columns["IsAdmin"].HeaderText = "Là quản trị viên?";
            EmployeeGridView.Columns["IsAdmin"].AutoSizeMode 
                = DataGridViewAutoSizeColumnMode.AllCells;

            EmployeeGridView.Columns["RealLifeIdNumber"].HeaderText = "Số CMND";
            EmployeeGridView.Columns["RealLifeIdNumber"].AutoSizeMode
                = DataGridViewAutoSizeColumnMode.AllCells;

            EmployeeGridView.Columns["FullName"].HeaderText = "Họ tên";
            EmployeeGridView.Columns["FullName"].Width = 125;

            EmployeeGridView.Columns["DateOfBirth"].HeaderText = "Ngày sinh";
            EmployeeGridView.Columns["DateOfBirth"].AutoSizeMode
                = DataGridViewAutoSizeColumnMode.AllCells;

            EmployeeGridView.Columns["Sex"].HeaderText = "Giới tính";
            EmployeeGridView.Columns["Sex"].AutoSizeMode
                = DataGridViewAutoSizeColumnMode.AllCells;
            EmployeeGridView.Columns["Sex"].Visible = false;

            EmployeeGridView.Columns["Address"].HeaderText = "Địa chỉ";
            EmployeeGridView.Columns["Address"].Width = 125;

            EmployeeGridView.Columns["Phonenumber"].HeaderText = "Số điện thoại";
            EmployeeGridView.Columns["Phonenumber"].AutoSizeMode
                = DataGridViewAutoSizeColumnMode.AllCells;

            EmployeeGridView.Columns["Filter"].Visible = false;
        }

        private void EmployeeManageForm_Shown(object sender, EventArgs e)
        {
            EmployeeGridView.ClearSelection();
            EmployeeGridView.RowEnter += EmployeeGridView_RowEnter;
        }

        private void LoadOneEmployee(Employee e)
        {
            IdNumericUpdown.Value = e.Id;
            UsernameTextbox.Text = e.Username;
            PasswordTextbox.Text = e.Password;
            IsAdminCheckBox.Checked = e.IsAdmin;
            FullNameTextbox.Text = e.FullName;
            DateOfBirthDatePicker.Value =
                e.DateOfBirth.Date > DateOfBirthDatePicker.MaxDate
                || e.DateOfBirth.Date < DateOfBirthDatePicker.MinDate ?
                new DateTime(1990, 1, 1) : e.DateOfBirth;
            if (e.Sex)
                FemaleRadioButton.Checked = true;
            else
                MaleRadioButton.Checked = true;
            RealLifeIdNumberTextbox.Text = e.RealLifeIdNumber;
            AddressRichTextbox.Text = e.Address;
            PhonenumberTextbox.Text = e.Phonenumber;
        }

        private Employee FilledDataToEmployee()
        {
            Employee e = new Employee()
            {
                Id = Convert.ToInt32(IdNumericUpdown.Value),
                Username = UsernameTextbox.Text,
                Password = PasswordTextbox.Text.Length < 32 
                    ? StringUtilities.MD5Hash(PasswordTextbox.Text)
                    : PasswordTextbox.Text,
                IsAdmin = IsAdminCheckBox.Checked,
                DateOfBirth = DateOfBirthDatePicker.Value,
                Sex = FemaleRadioButton.Checked,
                RealLifeIdNumber = RealLifeIdNumberTextbox.Text,
                FullName = FullNameTextbox.Text,
                Address = AddressRichTextbox.Text,
                Phonenumber = PhonenumberTextbox.Text
            };
            return e;
        }

        private void EmployeeGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if ((EmployeeGridView.SelectedRows.Count > 0 && EmployeeGridView.SelectedRows[0] != null)
                || EmployeeGridView.Rows.Count == 1)
            {
                DataRowView rowView = (EmployeeGridView.Rows.Count == 1) 
                    ? (EmployeeGridView.Rows[0].DataBoundItem as DataRowView) 
                    : (EmployeeGridView.SelectedRows[0].DataBoundItem as DataRowView);

                LoadOneEmployee(LazyWorker<Employee>.DataRowToObject(rowView.Row));

                SaveButton.Enabled = true;
                DeleteButton.Enabled = true;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            LoadOneEmployee(new Employee());
            SaveButton.Enabled = false;
            DeleteButton.Enabled = false;
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            string message = "";
            if (string.IsNullOrEmpty(UsernameTextbox.Text))
                message += "– Tên đăng nhập bị bỏ trống." + Environment.NewLine;
            if (string.IsNullOrEmpty(PasswordTextbox.Text))
                message += "– Mật khẩu bị bỏ trống." + Environment.NewLine;
            if (string.IsNullOrEmpty(FullNameTextbox.Text))
                message += "– Họ tên bị bỏ trống." + Environment.NewLine;

            if (!string.IsNullOrEmpty(message))
            {
                message = "Tạo nhân viên mới thất bại vì (những) lý do sau:" + Environment.NewLine + message;
            }
            else
            {
                IdNumericUpdown.Value 
                    = LazyWorker<Employee>.Insert(FilledDataToEmployee());
                message = "Tạo mới thành công!";
                LoadAllEmployees();
            }
            MessageBox.Show(message);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            LazyWorker<Employee>.Update(FilledDataToEmployee());
            LoadAllEmployees();
            MessageBox.Show("Dữ liệu đã được cập nhật thành công!");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(FormUtilities.ConfirmDeletion())
            {
                LazyWorker<Employee>.Delete(FilledDataToEmployee());
                LoadAllEmployees();
                LoadOneEmployee(new Employee());
            }
        }

        private void FilterTextbox_TextChanged(object sender, EventArgs e)
        {
            FormUtilities.FilterDataGridView(EmployeeGridView, FilterTextbox.Text);
        }

        private void UsernameTextbox_Validating(object sender, CancelEventArgs e)
        {
            FormUtilities.CharacterLengthValidating
            (
                ValidatingErrorProvider, 
                UsernameTextbox, 
                "Tên đăng nhập", 
                5, 20
            );
        }

        private void PasswordTextbox_Validating(object sender, CancelEventArgs e)
        {
            FormUtilities.CharacterLengthValidating
            (
                ValidatingErrorProvider, 
                PasswordTextbox, 
                "Mật khẩu", 
                6, 31
            );
        }

        private void FullNameTextbox_Validating(object sender, CancelEventArgs e)
        {
            FormUtilities.CharacterLengthValidating
            (
                ValidatingErrorProvider, 
                FullNameTextbox, 
                "Họ tên", 
                1, 50
            );
        }

        

        private void RealLifeIdNumberTextbox_Validating(object sender, CancelEventArgs e)
        {
            FormUtilities.NumericCharactersValidating
            (
                ValidatingErrorProvider, 
                RealLifeIdNumberTextbox, 
                "Số CMND (hoặc CCCD)", 9
            );
        }

        private void PhonenumberTextbox_Validating(object sender, CancelEventArgs e)
        {
            FormUtilities.NumericCharactersValidating
            (
                ValidatingErrorProvider, 
                RealLifeIdNumberTextbox, 
                "Số điện thoại", 8
            );
        }
    }
}
