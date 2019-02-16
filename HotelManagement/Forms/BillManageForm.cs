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
            table.Columns.Add("TotalMoney");
            LessLazyWorker.SetColumnsOrder(table,
                new string[] { "Customer", "Employee", "CreatingDay", "TotalMoney" });

            foreach(DataRow row in table.Rows)
            {
                BillDisplay bill = LazyWorker<BillDisplay>.DataRowToObject(row);
                row["Customer"] = bill.Customer_.FullName;
                row["Employee"] = bill.Employee_.Username;
                row["TotalMoney"] = LessLazyWorker.TotalMoneyOfBill(bill.Id);
            }

            BillGridView.DataSource = table;

            BillGridView.Columns["Id"].Visible = false;
            BillGridView.Columns["Filter"].Visible = false;
            BillGridView.Columns["Customer_"].Visible = false;
            BillGridView.Columns["Employee_"].Visible = false;

            BillGridView.Columns["CreatingDay"].HeaderText = "Ngày khởi tạo";
            BillGridView.Columns["Customer"].HeaderText = "Tên khách";
            BillGridView.Columns["Employee"].HeaderText = "Tạo bởi";
            BillGridView.Columns["TotalMoney"].HeaderText = "Tổng tiền";
        }

        private void BillManageForm_Shown(object sender, EventArgs e)
        {

        }

        private void NewButton_Click(object sender, EventArgs e)
        {

        }
    }
}
