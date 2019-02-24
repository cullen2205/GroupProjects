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
    public partial class BillManageForm : Form
    {
        public BillManageForm()
        {
            InitializeComponent();
            LoadAllBills();
        }

        private void LoadAllBills()
        {
            LazyWorker<BillDisplay>.LoadAllToGridView
            (
                BillGridView,
                new string[] { "Id", "Customer_", "Employee_", "CreatingDay" },
                LessLazyWorker.GetAllBills()
            );

            DataTable table = (DataTable)BillGridView.DataSource;
            table.Columns.Add("Customer");
            table.Columns.Add("Employee");
            LessLazyWorker.SetColumnsOrder(table,
                new string[] { "Customer", "Employee", "CreatingDay", "TotalPrice" });

            foreach(DataRow row in table.Rows)
            {
                BillDisplay bill = LazyWorker<BillDisplay>.DataRowToObject(row);
                row["Customer"] = bill.Customer_ != null ? bill.Customer_.FullName : "";
                row["Employee"] = bill.Employee_ != null ? bill.Employee_.FullName : "";
            }

            BillGridView.DataSource = table;

            BillGridView.Columns["Id"].Visible = false;
            BillGridView.Columns["Filter"].Visible = false;
            BillGridView.Columns["Customer_"].Visible = false;
            BillGridView.Columns["Employee_"].Visible = false;

            BillGridView.Columns["CreatingDay"].HeaderText = "Ngày khởi tạo";
            BillGridView.Columns["Customer"].HeaderText = "Tên khách";
            BillGridView.Columns["Employee"].HeaderText = "Tạo bởi";
            BillGridView.Columns["TotalPrice"].HeaderText = "Tổng tiền";
            BillGridView.Columns["TotalPrice"].DefaultCellStyle.Format = "### ### ### ###";
        }

        private void BillManageForm_Shown(object sender, EventArgs e)
        {
            BillGridView.ClearSelection();
            BillGridView.RowEnter += BillGridView_RowEnter;
        }

        BillDisplay bill;
        private void LoadOneBill(BillDisplay bill)
        {
            IdNumericUpDown.Value = bill.Id;
            this.bill = new BillDisplay()
            {
                Id = bill.Id,
                CreatingDay = bill.CreatingDay,
                Customer_ = bill.Customer_,
                Employee_ = bill.Employee_,
                TotalPrice = bill.TotalPrice
            };
        }

        private void BillGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            LazyWorker<BillDisplay>.LoadOneFromGridView
            (
                BillGridView, 
                LoadOneBill, 
                EditButton, 
                DeleteButton
            );
        }

        private void NewButton_Click(object sender, EventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = Owner as MainForm;
            if(bill != null)
                mainForm.SetCurrentBill(bill);
        }
    }
}
