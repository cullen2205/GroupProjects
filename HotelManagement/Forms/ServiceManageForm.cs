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
    public partial class ServiceManageForm : Form
    {
        public ServiceManageForm()
        {
            InitializeComponent();
            LoadAllServices();
            LoadAllRooms();
        }

        private void LoadAllServices()
        {
            var list = LazyLoader.GetAllServices();
            var table = LazyWorker<Service>.ListToDataTable(list);
            
            LazyLoader.SetColumnsOrder(table, "Id", "ServiceName", "Price", "BelongToRoom");

            table.Columns.Add("Filter");
            foreach(DataRow row in table.Rows)
                row["Filter"] = LazyWorker<Service>
                    .DataRowToObject(row)
                    .ToFilteringString();
            

            ServiceGridView.DataSource = table;
            ServiceGridView.Columns["Id"].Visible = false;

            ServiceGridView.Columns["ServiceName"].HeaderText = "Tên dịch vụ";
            ServiceGridView.Columns["ServiceName"].Width = 150;

            ServiceGridView.Columns["Price"].HeaderText = "Giá dịch vụ";
            ServiceGridView.Columns["Price"].AutoSizeMode 
                = DataGridViewAutoSizeColumnMode.AllCells;
            ServiceGridView.Columns["Price"].DefaultCellStyle.Format = "### ### ### ###";

            ServiceGridView.Columns["BelongToRoom"].HeaderText = "Thuộc về phòng";
            ServiceGridView.Columns["BelongToRoom"].Width = 150;

            ServiceGridView.Columns["Filter"].Visible = false;
        }

        private void LoadAllRooms()
        {
            var list = LazyWorker<Room>.GetAll();
            RoomComboBox.DataSource = list;
            list.Insert(0, new Room()
            {
                Id = 0,
                RoomName = ""
            });
            RoomComboBox.DisplayMember = "RoomName";
            RoomComboBox.ValueMember = "Id";
        }

        private void LoadOneService(Service s)
        {
            ServiceIdNumericUpDown.Value = s.Id;
            RoomComboBox.SelectedValue = s.BelongToRoom.Id;
            RoomNameTextbox.Text = s.BelongToRoom.RoomName;
            ServiceNameTextbox.Text = s.ServiceName;
            ServicePriceNumericUpDown.Value = s.Price;
        }

        private void ServicesGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if ((ServiceGridView.SelectedRows.Count > 0 && ServiceGridView.SelectedRows[0] != null)
                || ServiceGridView.Rows.Count == 1)
            {
                DataRowView rowView = (ServiceGridView.Rows.Count == 1)
                    ? (ServiceGridView.Rows[0].DataBoundItem as DataRowView)
                    : (ServiceGridView.SelectedRows[0].DataBoundItem as DataRowView);

                LoadOneService(LazyWorker<Service>.DataRowToObject(rowView.Row));
                RoomFilterTextbox.Text = "";
            }
        }

        private void ServiceManageForm_Shown(object sender, EventArgs e)
        {
            ServiceGridView.RowEnter += ServicesGridView_RowEnter;
        }

        private void ServiceFilterTextbox_TextChanged(object sender, EventArgs e)
        {
            FormUtilities.FilterDataGridView(ServiceGridView, ServiceFilterTextbox.Text);
        }
    }
}
