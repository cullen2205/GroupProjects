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
            var list = LazyLoader<Employee>.GetAll();
            var table = LazyLoader<Employee>.ListToDataTable(list);
            LazyWorker.SetColumnsOrder(table, 
                "Id", "Username", "Password", "IsAdmin", 
                "RealLifeIdNumber", "FullName", "DateOfBirth", "Sex",
                "Address", "Phonenumber");
            table.Columns.Add("Filter");
            foreach(DataRow row in table.Rows)
                row["Filter"] = LazyLoader<Employee>.DataRowToObject(row).ToString();

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
            if(EmployeeGridView.SelectedRows.Count > 0 
                && EmployeeGridView.SelectedRows[0] != null)
            {
                LoadOneEmployee(
                    LazyLoader<Employee>.DataRowToObject(
                        ((DataRowView)EmployeeGridView.SelectedRows[0].DataBoundItem).Row
                    )
                );

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
                    = LazyLoader<Employee>.Insert(FilledDataToEmployee());
                message = "Tạo mới thành công!";
                LoadAllEmployees();
            }
            MessageBox.Show(message);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            LazyLoader<Employee>.Update(FilledDataToEmployee());
            LoadAllEmployees();
            MessageBox.Show("Dữ liệu đã được cập nhật thành công!");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                LazyLoader<Employee>.Delete(FilledDataToEmployee());
                LoadAllEmployees();
                LoadOneEmployee(new Employee());
            }
        }

        private void FilterTextbox_TextChanged(object sender, EventArgs e)
        {
            DataTable table = (DataTable)EmployeeGridView.DataSource;
            string filterString = "";
            foreach (string word in 
                FilterTextbox.Text.Split
                (
                    new char[] {' '}, 
                    StringSplitOptions.RemoveEmptyEntries
                )
            )
            {
                filterString += string.Format("Filter like '%{0}%' or", word);
            }
            table.DefaultView.RowFilter = filterString.Length > 3 
                ? filterString.Substring(0, filterString.Length - 3)
                : "";
            EmployeeGridView.DataSource = table;
        }

        private void CharacterLengthValidating(Control control, string controlsName,
            int minLength, int maxLength)
        {
            if (string.IsNullOrEmpty(control.Text))
            {
                ValidatingErrorProvider.SetError(control,
                    string.Format("{0} không được để trống.", 
                    controlsName));
            }
            else if (control.Text.Length < minLength)
            {
                ValidatingErrorProvider.SetError(control,
                    string.Format("{0} phải có ít nhất {1} ký tự " +
                    "và nhỏ hơn hoặc bằng {2} ký tự.", 
                    controlsName, minLength, maxLength));
            }
            else
            {
                ValidatingErrorProvider.SetError(control, "");
            }
        }

        private void UsernameTextbox_Validating(object sender, CancelEventArgs e)
        {
            CharacterLengthValidating(UsernameTextbox, "Tên đăng nhập", 5, 20);
        }

        private void PasswordTextbox_Validating(object sender, CancelEventArgs e)
        {
            CharacterLengthValidating(PasswordTextbox, "Mật khẩu", 6, 31);
        }

        private void FullNameTextbox_Validating(object sender, CancelEventArgs e)
        {
            CharacterLengthValidating(FullNameTextbox, "Họ tên", 1, 50);
        }

        private void NumericCharactersValidating(Control control, string controlsName,
            int minNumberOfCharacters)
        {
            bool emptyString = string.IsNullOrEmpty(control.Text);
            
            if (!emptyString && !StringUtilities.IsNumber(control.Text))
            {
                ValidatingErrorProvider.SetError(control,
                    string.Format("{0} phải là một dãy toàn các chữ số.", 
                    controlsName));
            }
            else if(!emptyString && control.Text.Length < minNumberOfCharacters)
            {
                ValidatingErrorProvider.SetError(control,
                    string.Format("{0} phải có ít nhất {1} chữ số.",
                    controlsName, minNumberOfCharacters));
            }
            else
            {
                ValidatingErrorProvider.SetError(control, "");
            }
        }

        private void RealLifeIdNumberTextbox_Validating(object sender, CancelEventArgs e)
        {
            NumericCharactersValidating(RealLifeIdNumberTextbox, "Số CMND (hoặc CCCD)", 9);
        }

        private void PhonenumberTextbox_Validating(object sender, CancelEventArgs e)
        {
            NumericCharactersValidating(RealLifeIdNumberTextbox, "Số điện thoại", 8);
        }

        //should write some more functions!
    }
}
