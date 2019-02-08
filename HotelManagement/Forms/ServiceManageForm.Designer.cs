namespace HotelManagement
{
    partial class ServiceManageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ServiceListGroupBox = new System.Windows.Forms.GroupBox();
            this.ServiceFilterTextbox = new System.Windows.Forms.TextBox();
            this.ServiceFilterLabel = new System.Windows.Forms.Label();
            this.ServiceGridView = new System.Windows.Forms.DataGridView();
            this.RoomInforGroupBox = new System.Windows.Forms.GroupBox();
            this.ResetRoomButton = new System.Windows.Forms.Button();
            this.DeleteRoomButton = new System.Windows.Forms.Button();
            this.SaveRoomButton = new System.Windows.Forms.Button();
            this.NewRoomButton = new System.Windows.Forms.Button();
            this.RoomNameTextbox = new System.Windows.Forms.TextBox();
            this.SeparatorLabel = new System.Windows.Forms.Label();
            this.RoomLabel = new System.Windows.Forms.Label();
            this.RoomComboBox = new System.Windows.Forms.ComboBox();
            this.RoomNameLabel = new System.Windows.Forms.Label();
            this.ServiceInforGroupBox = new System.Windows.Forms.GroupBox();
            this.ServicePriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ResetServiceButton = new System.Windows.Forms.Button();
            this.DeleteServiceButton = new System.Windows.Forms.Button();
            this.ServicePriceLabel = new System.Windows.Forms.Label();
            this.SaveServiceButton = new System.Windows.Forms.Button();
            this.ServiceNameTextbox = new System.Windows.Forms.TextBox();
            this.NewServiceButton = new System.Windows.Forms.Button();
            this.ServiceNameLabel = new System.Windows.Forms.Label();
            this.ServiceIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RoomIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ServiceListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceGridView)).BeginInit();
            this.RoomInforGroupBox.SuspendLayout();
            this.ServiceInforGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServicePriceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomIdNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(99, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(162, 26);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Quản lý dịch vụ";
            // 
            // ServiceListGroupBox
            // 
            this.ServiceListGroupBox.Controls.Add(this.ServiceFilterTextbox);
            this.ServiceListGroupBox.Controls.Add(this.ServiceFilterLabel);
            this.ServiceListGroupBox.Controls.Add(this.ServiceGridView);
            this.ServiceListGroupBox.Location = new System.Drawing.Point(12, 44);
            this.ServiceListGroupBox.Name = "ServiceListGroupBox";
            this.ServiceListGroupBox.Size = new System.Drawing.Size(333, 244);
            this.ServiceListGroupBox.TabIndex = 0;
            this.ServiceListGroupBox.TabStop = false;
            this.ServiceListGroupBox.Text = "Danh sách dịch vụ";
            // 
            // ServiceFilterTextbox
            // 
            this.ServiceFilterTextbox.Location = new System.Drawing.Point(49, 19);
            this.ServiceFilterTextbox.Name = "ServiceFilterTextbox";
            this.ServiceFilterTextbox.Size = new System.Drawing.Size(100, 20);
            this.ServiceFilterTextbox.TabIndex = 1;
            this.ServiceFilterTextbox.TextChanged += new System.EventHandler(this.ServiceFilterTextbox_TextChanged);
            // 
            // ServiceFilterLabel
            // 
            this.ServiceFilterLabel.AutoSize = true;
            this.ServiceFilterLabel.Location = new System.Drawing.Point(6, 22);
            this.ServiceFilterLabel.Name = "ServiceFilterLabel";
            this.ServiceFilterLabel.Size = new System.Drawing.Size(37, 13);
            this.ServiceFilterLabel.TabIndex = 2;
            this.ServiceFilterLabel.Text = "Bộ lọc";
            // 
            // ServiceGridView
            // 
            this.ServiceGridView.AllowUserToAddRows = false;
            this.ServiceGridView.AllowUserToDeleteRows = false;
            this.ServiceGridView.AllowUserToResizeRows = false;
            this.ServiceGridView.Location = new System.Drawing.Point(6, 45);
            this.ServiceGridView.MultiSelect = false;
            this.ServiceGridView.Name = "ServiceGridView";
            this.ServiceGridView.ReadOnly = true;
            this.ServiceGridView.RowHeadersVisible = false;
            this.ServiceGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServiceGridView.Size = new System.Drawing.Size(319, 190);
            this.ServiceGridView.TabIndex = 2;
            // 
            // RoomInforGroupBox
            // 
            this.RoomInforGroupBox.Controls.Add(this.ResetRoomButton);
            this.RoomInforGroupBox.Controls.Add(this.DeleteRoomButton);
            this.RoomInforGroupBox.Controls.Add(this.SaveRoomButton);
            this.RoomInforGroupBox.Controls.Add(this.NewRoomButton);
            this.RoomInforGroupBox.Controls.Add(this.RoomNameTextbox);
            this.RoomInforGroupBox.Controls.Add(this.SeparatorLabel);
            this.RoomInforGroupBox.Controls.Add(this.RoomLabel);
            this.RoomInforGroupBox.Controls.Add(this.RoomComboBox);
            this.RoomInforGroupBox.Controls.Add(this.RoomNameLabel);
            this.RoomInforGroupBox.Location = new System.Drawing.Point(351, 44);
            this.RoomInforGroupBox.Name = "RoomInforGroupBox";
            this.RoomInforGroupBox.Size = new System.Drawing.Size(211, 131);
            this.RoomInforGroupBox.TabIndex = 1;
            this.RoomInforGroupBox.TabStop = false;
            this.RoomInforGroupBox.Text = "Thông tin phòng";
            // 
            // ResetRoomButton
            // 
            this.ResetRoomButton.Location = new System.Drawing.Point(9, 96);
            this.ResetRoomButton.Name = "ResetRoomButton";
            this.ResetRoomButton.Size = new System.Drawing.Size(50, 23);
            this.ResetRoomButton.TabIndex = 6;
            this.ResetRoomButton.Text = "Đặt lại";
            this.ResetRoomButton.UseVisualStyleBackColor = true;
            this.ResetRoomButton.Click += new System.EventHandler(this.ResetRoomButton_Click);
            // 
            // DeleteRoomButton
            // 
            this.DeleteRoomButton.Enabled = false;
            this.DeleteRoomButton.Location = new System.Drawing.Point(166, 96);
            this.DeleteRoomButton.Name = "DeleteRoomButton";
            this.DeleteRoomButton.Size = new System.Drawing.Size(39, 23);
            this.DeleteRoomButton.TabIndex = 9;
            this.DeleteRoomButton.Text = "Xóa";
            this.DeleteRoomButton.UseVisualStyleBackColor = true;
            this.DeleteRoomButton.Click += new System.EventHandler(this.DeleteRoomButton_Click);
            // 
            // SaveRoomButton
            // 
            this.SaveRoomButton.Enabled = false;
            this.SaveRoomButton.Location = new System.Drawing.Point(124, 96);
            this.SaveRoomButton.Name = "SaveRoomButton";
            this.SaveRoomButton.Size = new System.Drawing.Size(38, 23);
            this.SaveRoomButton.TabIndex = 8;
            this.SaveRoomButton.Text = "Lưu";
            this.SaveRoomButton.UseVisualStyleBackColor = true;
            this.SaveRoomButton.Click += new System.EventHandler(this.SaveRoomButton_Click);
            // 
            // NewRoomButton
            // 
            this.NewRoomButton.Location = new System.Drawing.Point(63, 96);
            this.NewRoomButton.Name = "NewRoomButton";
            this.NewRoomButton.Size = new System.Drawing.Size(55, 23);
            this.NewRoomButton.TabIndex = 7;
            this.NewRoomButton.Text = "Tạo mới";
            this.NewRoomButton.UseVisualStyleBackColor = true;
            this.NewRoomButton.Click += new System.EventHandler(this.NewRoomButton_Click);
            // 
            // RoomNameTextbox
            // 
            this.RoomNameTextbox.Location = new System.Drawing.Point(75, 64);
            this.RoomNameTextbox.Name = "RoomNameTextbox";
            this.RoomNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.RoomNameTextbox.TabIndex = 5;
            // 
            // SeparatorLabel
            // 
            this.SeparatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SeparatorLabel.Location = new System.Drawing.Point(30, 51);
            this.SeparatorLabel.Name = "SeparatorLabel";
            this.SeparatorLabel.Size = new System.Drawing.Size(140, 2);
            this.SeparatorLabel.TabIndex = 8;
            // 
            // RoomLabel
            // 
            this.RoomLabel.AutoSize = true;
            this.RoomLabel.Location = new System.Drawing.Point(5, 22);
            this.RoomLabel.Name = "RoomLabel";
            this.RoomLabel.Size = new System.Drawing.Size(38, 13);
            this.RoomLabel.TabIndex = 4;
            this.RoomLabel.Text = "Phòng";
            // 
            // RoomComboBox
            // 
            this.RoomComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.RoomComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.RoomComboBox.FormattingEnabled = true;
            this.RoomComboBox.Location = new System.Drawing.Point(75, 19);
            this.RoomComboBox.Name = "RoomComboBox";
            this.RoomComboBox.Size = new System.Drawing.Size(121, 21);
            this.RoomComboBox.TabIndex = 4;
            this.RoomComboBox.SelectedIndexChanged += new System.EventHandler(this.RoomComboBox_SelectedIndexChanged);
            // 
            // RoomNameLabel
            // 
            this.RoomNameLabel.AutoSize = true;
            this.RoomNameLabel.Location = new System.Drawing.Point(5, 67);
            this.RoomNameLabel.Name = "RoomNameLabel";
            this.RoomNameLabel.Size = new System.Drawing.Size(59, 13);
            this.RoomNameLabel.TabIndex = 0;
            this.RoomNameLabel.Text = "Tên phòng";
            // 
            // ServiceInforGroupBox
            // 
            this.ServiceInforGroupBox.Controls.Add(this.ServicePriceNumericUpDown);
            this.ServiceInforGroupBox.Controls.Add(this.ResetServiceButton);
            this.ServiceInforGroupBox.Controls.Add(this.DeleteServiceButton);
            this.ServiceInforGroupBox.Controls.Add(this.ServicePriceLabel);
            this.ServiceInforGroupBox.Controls.Add(this.SaveServiceButton);
            this.ServiceInforGroupBox.Controls.Add(this.ServiceNameTextbox);
            this.ServiceInforGroupBox.Controls.Add(this.NewServiceButton);
            this.ServiceInforGroupBox.Controls.Add(this.ServiceNameLabel);
            this.ServiceInforGroupBox.Location = new System.Drawing.Point(351, 181);
            this.ServiceInforGroupBox.Name = "ServiceInforGroupBox";
            this.ServiceInforGroupBox.Size = new System.Drawing.Size(211, 107);
            this.ServiceInforGroupBox.TabIndex = 2;
            this.ServiceInforGroupBox.TabStop = false;
            this.ServiceInforGroupBox.Text = "Thông tin dịch vụ";
            // 
            // ServicePriceNumericUpDown
            // 
            this.ServicePriceNumericUpDown.Increment = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.ServicePriceNumericUpDown.Location = new System.Drawing.Point(76, 46);
            this.ServicePriceNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.ServicePriceNumericUpDown.Name = "ServicePriceNumericUpDown";
            this.ServicePriceNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.ServicePriceNumericUpDown.TabIndex = 11;
            this.ServicePriceNumericUpDown.ThousandsSeparator = true;
            this.ServicePriceNumericUpDown.Value = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            // 
            // ResetServiceButton
            // 
            this.ResetServiceButton.Location = new System.Drawing.Point(7, 75);
            this.ResetServiceButton.Name = "ResetServiceButton";
            this.ResetServiceButton.Size = new System.Drawing.Size(50, 23);
            this.ResetServiceButton.TabIndex = 12;
            this.ResetServiceButton.Text = "Đặt lại";
            this.ResetServiceButton.UseVisualStyleBackColor = true;
            this.ResetServiceButton.Click += new System.EventHandler(this.ResetServiceButton_Click);
            // 
            // DeleteServiceButton
            // 
            this.DeleteServiceButton.Enabled = false;
            this.DeleteServiceButton.Location = new System.Drawing.Point(166, 75);
            this.DeleteServiceButton.Name = "DeleteServiceButton";
            this.DeleteServiceButton.Size = new System.Drawing.Size(39, 23);
            this.DeleteServiceButton.TabIndex = 15;
            this.DeleteServiceButton.Text = "Xóa";
            this.DeleteServiceButton.UseVisualStyleBackColor = true;
            this.DeleteServiceButton.Click += new System.EventHandler(this.DeleteServiceButton_Click);
            // 
            // ServicePriceLabel
            // 
            this.ServicePriceLabel.AutoSize = true;
            this.ServicePriceLabel.Location = new System.Drawing.Point(6, 48);
            this.ServicePriceLabel.Name = "ServicePriceLabel";
            this.ServicePriceLabel.Size = new System.Drawing.Size(43, 13);
            this.ServicePriceLabel.TabIndex = 13;
            this.ServicePriceLabel.Text = "Giá tiền";
            // 
            // SaveServiceButton
            // 
            this.SaveServiceButton.Enabled = false;
            this.SaveServiceButton.Location = new System.Drawing.Point(124, 75);
            this.SaveServiceButton.Name = "SaveServiceButton";
            this.SaveServiceButton.Size = new System.Drawing.Size(38, 23);
            this.SaveServiceButton.TabIndex = 14;
            this.SaveServiceButton.Text = "Lưu";
            this.SaveServiceButton.UseVisualStyleBackColor = true;
            this.SaveServiceButton.Click += new System.EventHandler(this.SaveServiceButton_Click);
            // 
            // ServiceNameTextbox
            // 
            this.ServiceNameTextbox.Location = new System.Drawing.Point(76, 19);
            this.ServiceNameTextbox.Name = "ServiceNameTextbox";
            this.ServiceNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.ServiceNameTextbox.TabIndex = 10;
            // 
            // NewServiceButton
            // 
            this.NewServiceButton.Location = new System.Drawing.Point(63, 75);
            this.NewServiceButton.Name = "NewServiceButton";
            this.NewServiceButton.Size = new System.Drawing.Size(55, 23);
            this.NewServiceButton.TabIndex = 13;
            this.NewServiceButton.Text = "Tạo mới";
            this.NewServiceButton.UseVisualStyleBackColor = true;
            this.NewServiceButton.Click += new System.EventHandler(this.NewServiceButton_Click);
            // 
            // ServiceNameLabel
            // 
            this.ServiceNameLabel.AutoSize = true;
            this.ServiceNameLabel.Location = new System.Drawing.Point(6, 22);
            this.ServiceNameLabel.Name = "ServiceNameLabel";
            this.ServiceNameLabel.Size = new System.Drawing.Size(64, 13);
            this.ServiceNameLabel.TabIndex = 0;
            this.ServiceNameLabel.Text = "Tên dịch vụ";
            // 
            // ServiceIdNumericUpDown
            // 
            this.ServiceIdNumericUpDown.Location = new System.Drawing.Point(301, 15);
            this.ServiceIdNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.ServiceIdNumericUpDown.Name = "ServiceIdNumericUpDown";
            this.ServiceIdNumericUpDown.Size = new System.Drawing.Size(0, 20);
            this.ServiceIdNumericUpDown.TabIndex = 3;
            this.ServiceIdNumericUpDown.TabStop = false;
            // 
            // RoomIdNumericUpDown
            // 
            this.RoomIdNumericUpDown.Location = new System.Drawing.Point(351, 16);
            this.RoomIdNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.RoomIdNumericUpDown.Name = "RoomIdNumericUpDown";
            this.RoomIdNumericUpDown.Size = new System.Drawing.Size(0, 20);
            this.RoomIdNumericUpDown.TabIndex = 4;
            this.RoomIdNumericUpDown.TabStop = false;
            // 
            // ServiceManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 298);
            this.Controls.Add(this.RoomIdNumericUpDown);
            this.Controls.Add(this.ServiceIdNumericUpDown);
            this.Controls.Add(this.ServiceInforGroupBox);
            this.Controls.Add(this.RoomInforGroupBox);
            this.Controls.Add(this.ServiceListGroupBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "ServiceManageForm";
            this.Text = "ServiceManageForm";
            this.Shown += new System.EventHandler(this.ServiceManageForm_Shown);
            this.ServiceListGroupBox.ResumeLayout(false);
            this.ServiceListGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceGridView)).EndInit();
            this.RoomInforGroupBox.ResumeLayout(false);
            this.RoomInforGroupBox.PerformLayout();
            this.ServiceInforGroupBox.ResumeLayout(false);
            this.ServiceInforGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServicePriceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomIdNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.GroupBox ServiceListGroupBox;
        private System.Windows.Forms.TextBox ServiceFilterTextbox;
        private System.Windows.Forms.Label ServiceFilterLabel;
        private System.Windows.Forms.DataGridView ServiceGridView;
        private System.Windows.Forms.GroupBox RoomInforGroupBox;
        private System.Windows.Forms.TextBox RoomNameTextbox;
        private System.Windows.Forms.Label SeparatorLabel;
        private System.Windows.Forms.Label RoomLabel;
        private System.Windows.Forms.ComboBox RoomComboBox;
        private System.Windows.Forms.Label RoomNameLabel;
        private System.Windows.Forms.GroupBox ServiceInforGroupBox;
        private System.Windows.Forms.Label ServicePriceLabel;
        private System.Windows.Forms.TextBox ServiceNameTextbox;
        private System.Windows.Forms.Label ServiceNameLabel;
        private System.Windows.Forms.Button DeleteRoomButton;
        private System.Windows.Forms.Button SaveRoomButton;
        private System.Windows.Forms.Button NewRoomButton;
        private System.Windows.Forms.Button ResetServiceButton;
        private System.Windows.Forms.Button DeleteServiceButton;
        private System.Windows.Forms.Button SaveServiceButton;
        private System.Windows.Forms.Button NewServiceButton;
        private System.Windows.Forms.Button ResetRoomButton;
        private System.Windows.Forms.NumericUpDown ServicePriceNumericUpDown;
        private System.Windows.Forms.NumericUpDown ServiceIdNumericUpDown;
        private System.Windows.Forms.NumericUpDown RoomIdNumericUpDown;
    }
}