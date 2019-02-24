using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class MainForm
    {
        BillDisplay currentBill;
        List<BillDetail> currentDetails;

        public void SetCurrentBill(BillDisplay bill)
        {
            currentBill = bill;

            LoadAllServices();
            LoadAllCustomers();
            LoadAllEmployees();

            if (bill.Id != 0)
            {
                LoadBillsServices();
                currentDetails = LessLazyWorker.GetBillDetails(currentBill.Id);

                CustomerComboBox.SelectedValue = bill.Customer_.Id;
                EmployeeComboBox.SelectedValue = bill.Employee_.Id;

                SaveBillButton.Enabled = 
                    DeleteBillButton.Enabled = 
                    ExportBillButton.Enabled = 
                        true;

                AddServiceButton.Enabled =
                    SaveServiceButton.Enabled =
                    RemoveServiceButton.Enabled =
                        true;
            }
            else
            {
                LoadBillsServices(new List<ServiceMapped>());
                currentDetails = new List<BillDetail>();

                CustomerComboBox.SelectedIndex = 0;
                EmployeeComboBox.SelectedIndex = 0;

                SaveBillButton.Enabled =
                    DeleteBillButton.Enabled =
                    ExportBillButton.Enabled =
                        false;

                AddServiceButton.Enabled =
                    SaveServiceButton.Enabled =
                    RemoveServiceButton.Enabled =
                        false;
            }
        }

        private BillDetail FilledDataToBillDetail()
        {
            return new BillDetail()
            {
                Id = selectedService.BillDetailId,
                ServiceId = Convert.ToInt32(ServiceComboBox.SelectedValue),
                Count = Convert.ToInt32(ServiceCountNumericUpDown.Value),
                BillId = currentBill.Id
            };
        }

        private void LoadBillsServices(List<ServiceMapped> services = null)
        {
            LazyWorker<ServiceMapped>.LoadAllToGridView
            (
                ServiceListGridView,
                new string[]
                {
                    "Id", "ServiceName", "Price", "RoomId",
                    "BelongToRoom", "Count", "BillId"
                },
                services ?? LessLazyWorker.GetMappedServiceByBill(currentBill.Id)
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
        }

        private void ResetBillButton_Click(object sender, EventArgs e)
        {
            SetCurrentBill(new BillDisplay());
        }

        private void NewBillButton_Click(object sender, EventArgs e)
        {
            BillModel bill = new BillModel()
            {
                CustomerId = (CustomerComboBox.SelectedIndex == 0 ? null : (int?)CustomerComboBox.SelectedIndex),
                EmployeeId = (EmployeeComboBox.SelectedIndex == 0 ? null : (int?)EmployeeComboBox.SelectedIndex),
                CreatingDay = DateTime.Today.Date
            };
            bill.Id = LazyWorker<BillModel>.Insert(bill);

            SetCurrentBill(LessLazyWorker.BillModelToBillDisplay(bill));
        }

        private void DeleteBillButton_Click(object sender, EventArgs e)
        {
            if (LazyWorker<BillModel>.Delete
            (
                new BillModel()
                {
                    Id = currentBill.Id
                }
            ))
            {
                SetCurrentBill(new BillDisplay());
                FormUtilities.NotifySuccess();
            }
            else
                FormUtilities.NotifyFailure();
        }

        private void SaveBillButton_Click(object sender, EventArgs e)
        {
            if (LazyWorker<BillModel>.Update
            (
                new BillModel()
                {
                    Id = currentBill.Id,
                    CustomerId = (CustomerComboBox.SelectedIndex == 0 ? null : (int?)CustomerComboBox.SelectedIndex),
                    EmployeeId = (EmployeeComboBox.SelectedIndex == 0 ? null : (int?)EmployeeComboBox.SelectedIndex),
                    CreatingDay = currentBill.CreatingDay
                }
            ))
                FormUtilities.NotifySuccess();
            else
                FormUtilities.NotifyFailure();
        }

        private PrintDocument CreateDocumentFromBill()
        {
            PrintDocument document = new PrintDocument();
            document.DocumentName = "Xuất hóa đơn";
            document.PrintPage += Document_PrintPage;
            return document;
        }

        private string CurrentBillToString()
        {
            string NewLine = Environment.NewLine,
                lazyNewLine = Environment.NewLine + Environment.NewLine;
            string result = "Hóa đơn tính tiền" + lazyNewLine;
            result += "Thời gian xuất: " + DateTime.Now + NewLine;
            result += "------------------------------" + NewLine;
            foreach (DataRow row in ((DataTable)ServiceListGridView.DataSource).Rows)
            {
                var service = LazyWorker<ServiceMapped>.DataRowToObject(row);
                result += service.ServiceName + ": " +
                    StringUtilities.LazyFormat(service.Price) + " x " + 
                    service.Count + " = " +
                    StringUtilities.LazyFormat(service.Price*service.Count) +
                    NewLine;
            }
            result += "------------------------------" + NewLine;
            result += "Tổng tiền: " + StringUtilities.LazyFormat(currentBill.TotalPrice) + lazyNewLine;
            result += "Tên khách hàng: " + currentBill.Customer_.FullName + lazyNewLine;
            result += "Nhân viên tạo hóa đơn: " + currentBill.Employee_.FullName + lazyNewLine;

            return result;
        }

        private void Document_PrintPage(object sender, PrintPageEventArgs e)
        {
            PrintDocument document = ((PrintDocument)sender);
            e.Graphics.DrawString
            (
                CurrentBillToString(),
                new Font("Courier New", 14),
                new SolidBrush(Color.Black),
                new RectangleF
                (
                    20, 20,
                    document.DefaultPageSettings.PrintableArea.Width - 20,
                    document.DefaultPageSettings.PrintableArea.Height - 20
                )
            );
        }

        private void ExportBillButton_Click(object sender, EventArgs e)
        {
            BillPrintPreviewDialog.Document = CreateDocumentFromBill();

            BillPrintPreviewDialog.ShowDialog();
        }
    }
}
