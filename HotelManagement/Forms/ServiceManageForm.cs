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
            LazyWorker<ServiceDisplay>.LoadAllToGridView
            (
                ServiceGridView, 
                new string[] { "Id", "ServiceName", "Price", "BelongToRoom" },
                LessLazyWorker.GetAllServices()
            );

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

        private void LoadAllRooms(int index = 0)
        {
            var list = LazyWorker<Room>.GetAll();
            list.Insert(0, new Room()
            {
                Id = 0,
                RoomName = ""
            });

            RoomComboBox.DataSource = list;
            RoomComboBox.DisplayMember = "RoomName";
            RoomComboBox.ValueMember = "Id";

            if (index < 0)
                index = 0;
            else if (index >= RoomComboBox.Items.Count)
                index = RoomComboBox.Items.Count - 1;

            RoomComboBox.SelectedIndex = index;
        }

        private void LoadOneService(ServiceDisplay s)
        {
            ServiceIdNumericUpDown.Value = s.Id;
            RoomComboBox.SelectedValue 
                = s.BelongToRoom != null 
                    ? s.BelongToRoom.Id 
                    : 0;
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

                LoadOneService(LazyWorker<ServiceDisplay>.DataRowToObject(rowView.Row));

                SaveServiceButton.Enabled = true;
                DeleteServiceButton.Enabled = true;
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

        private void RoomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Room r = RoomComboBox.SelectedItem as Room;
            RoomIdNumericUpDown.Value = r.Id;
            RoomNameTextbox.Text = r.RoomName;

            SaveRoomButton.Enabled 
                = DeleteRoomButton.Enabled 
                = (r.Id != 0);
        }

        private void ResetRoomButton_Click(object sender, EventArgs e)
        {
            RoomComboBox.SelectedIndex = 0;
            RoomNameTextbox.Text = "";
        }

        private Room FilledDataToRoom()
        {
            return new Room()
            {
                Id = Convert.ToInt32(RoomIdNumericUpDown.Value),
                RoomName = RoomNameTextbox.Text
            };
        }

        private ServiceModel FilledDataToService()
        {
            int? RoomId = Convert.ToInt32(RoomIdNumericUpDown.Value);
            return new ServiceModel()
            {
                Id = Convert.ToInt32(ServiceIdNumericUpDown.Value),
                RoomId = (RoomId == 0) ? null : RoomId,
                ServiceName = ServiceNameTextbox.Text,
                Price = Convert.ToInt32(ServicePriceNumericUpDown.Value)
            };
        }

        private void NewRoomButton_Click(object sender, EventArgs e)
        {
            RoomIdNumericUpDown.Value 
                = LazyWorker<Room>.Insert(FilledDataToRoom());
            LoadAllRooms(Int32.MaxValue);
            FormUtilities.NotifySuccess();
        }

        private void SaveRoomButton_Click(object sender, EventArgs e)
        {
            if (LazyWorker<Room>.Update(FilledDataToRoom()))
            {
                FormUtilities.NotifySuccess();
                LoadAllRooms(RoomComboBox.SelectedIndex);
            }
                
        }

        private void DeleteRoomButton_Click(object sender, EventArgs e)
        {
            if (FormUtilities.ConfirmDeletion())
            {
                LazyWorker<Room>.Delete(FilledDataToRoom());
                LoadAllRooms();
            }
        }

        private void ResetServiceButton_Click(object sender, EventArgs e)
        {
            ResetRoomButton_Click(sender, e);

            ServiceNameTextbox.Text = "";
            ServicePriceNumericUpDown.Value = 50000;
            ServiceFilterTextbox.Text = "";
            ServiceGridView.ClearSelection();

            DeleteServiceButton.Enabled = false;
            SaveServiceButton.Enabled = false;
        }

        private void NewServiceButton_Click(object sender, EventArgs e)
        {
            ServiceIdNumericUpDown.Value = LazyWorker<ServiceModel>.Insert(FilledDataToService());
            LoadAllServices();
            FormUtilities.SetRowIndex(ServiceGridView);
            SaveServiceButton.Enabled = true;
            DeleteServiceButton.Enabled = true;
            FormUtilities.NotifySuccess();
        }

        private void SaveServiceButton_Click(object sender, EventArgs e)
        {
            if(LazyWorker<ServiceModel>.Update(FilledDataToService()))
            {
                int index = ServiceGridView.SelectedRows[0].Index;
                LoadAllServices();
                FormUtilities.SetRowIndex(ServiceGridView, index);

                FormUtilities.NotifySuccess();
            }
        }

        private void DeleteServiceButton_Click(object sender, EventArgs e)
        {
            if (FormUtilities.ConfirmDeletion() &&
                LazyWorker<ServiceModel>.Delete(FilledDataToService()))
            {
                LoadAllRooms();
                ResetServiceButton_Click(sender, e);
                FormUtilities.NotifySuccess();
            }
        }

        private void RoomNameTextbox_Validating(object sender, CancelEventArgs e)
        {
            FormUtilities.CharacterLengthValidating
            (
                ValidatingErrorProvider, 
                RoomNameTextbox,
                "Tên phòng", 1, 30
            );
        }

        private void ServiceNameTextbox_Validating(object sender, CancelEventArgs e)
        {
            FormUtilities.CharacterLengthValidating
            (
                ValidatingErrorProvider,
                RoomNameTextbox,
                "Tên dịch vụ", 1, 50
            );
        }
    }
}
