namespace HotelManagement
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incomeStatisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServiceListGridView = new System.Windows.Forms.DataGridView();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ServiceListGroupBox = new System.Windows.Forms.GroupBox();
            this.ServicePriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveServiceButton = new System.Windows.Forms.Button();
            this.RemoveServiceButton = new System.Windows.Forms.Button();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.TotalPriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.AddServiceButton = new System.Windows.Forms.Button();
            this.ServiceCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ServiceCountLabel = new System.Windows.Forms.Label();
            this.ServiceComboBox = new System.Windows.Forms.ComboBox();
            this.ServiceFilterTextbox = new System.Windows.Forms.TextBox();
            this.ServiceLabel = new System.Windows.Forms.Label();
            this.EmployeeGroupBox = new System.Windows.Forms.GroupBox();
            this.EmployeeFilterTextbox = new System.Windows.Forms.TextBox();
            this.EmployeeLabel = new System.Windows.Forms.Label();
            this.EmployeeComboBox = new System.Windows.Forms.ComboBox();
            this.EmployeeFilterLabel = new System.Windows.Forms.Label();
            this.CustomerGroupBox = new System.Windows.Forms.GroupBox();
            this.ResetCustomerButton = new System.Windows.Forms.Button();
            this.DeleteCustomerButton = new System.Windows.Forms.Button();
            this.SaveCustomerButton = new System.Windows.Forms.Button();
            this.CreateCustomerButton = new System.Windows.Forms.Button();
            this.CustomerFemaleButton = new System.Windows.Forms.RadioButton();
            this.CustomerMaleButton = new System.Windows.Forms.RadioButton();
            this.CustomerSexLabel = new System.Windows.Forms.Label();
            this.CustomerDateOfBirthLabel = new System.Windows.Forms.Label();
            this.CustomerRLIDTextBox = new System.Windows.Forms.TextBox();
            this.CustomerDateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.CustomerFullNameTextBox = new System.Windows.Forms.TextBox();
            this.HorizontalLineLabel = new System.Windows.Forms.Label();
            this.CustomerFilterTextBox = new System.Windows.Forms.TextBox();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.CustomerFilterLabel = new System.Windows.Forms.Label();
            this.CustomerRLIDLabel = new System.Windows.Forms.Label();
            this.CustomerFullNameLabel = new System.Windows.Forms.Label();
            this.BillManipulatingGroupBox = new System.Windows.Forms.GroupBox();
            this.ResetBillButton = new System.Windows.Forms.Button();
            this.DeleteBillButton = new System.Windows.Forms.Button();
            this.SaveBillButton = new System.Windows.Forms.Button();
            this.NewBillButton = new System.Windows.Forms.Button();
            this.ExportBillButton = new System.Windows.Forms.Button();
            this.BillPrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.MainFormMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceListGridView)).BeginInit();
            this.ServiceListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServicePriceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalPriceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceCountNumericUpDown)).BeginInit();
            this.EmployeeGroupBox.SuspendLayout();
            this.CustomerGroupBox.SuspendLayout();
            this.BillManipulatingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormMenuStrip
            // 
            this.MainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.functionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainFormMenuStrip.Name = "MainFormMenuStrip";
            this.MainFormMenuStrip.Size = new System.Drawing.Size(809, 24);
            this.MainFormMenuStrip.TabIndex = 0;
            this.MainFormMenuStrip.Text = "MainFormMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.fileToolStripMenuItem.Text = "Dữ liệu";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.createToolStripMenuItem.Text = "Tạo mới";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.logoutToolStripMenuItem.Text = "Đăng xuất";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.exitToolStripMenuItem.Text = "Thoát";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // functionToolStripMenuItem
            // 
            this.functionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.manageEmployeeToolStripMenuItem,
            this.manageServiceToolStripMenuItem,
            this.manageCustomerToolStripMenuItem,
            this.manageBillToolStripMenuItem,
            this.incomeStatisticToolStripMenuItem});
            this.functionToolStripMenuItem.Name = "functionToolStripMenuItem";
            this.functionToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.functionToolStripMenuItem.Text = "Chức năng";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.changePasswordToolStripMenuItem.Text = "Đổi mật khẩu";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // manageEmployeeToolStripMenuItem
            // 
            this.manageEmployeeToolStripMenuItem.Name = "manageEmployeeToolStripMenuItem";
            this.manageEmployeeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.manageEmployeeToolStripMenuItem.Text = "Quản lý nhân viên";
            this.manageEmployeeToolStripMenuItem.Click += new System.EventHandler(this.manageEmployeeToolStripMenuItem_Click);
            // 
            // manageServiceToolStripMenuItem
            // 
            this.manageServiceToolStripMenuItem.Name = "manageServiceToolStripMenuItem";
            this.manageServiceToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.manageServiceToolStripMenuItem.Text = "Quản lý dịch vụ";
            this.manageServiceToolStripMenuItem.Click += new System.EventHandler(this.manageServiceToolStripMenuItem_Click);
            // 
            // manageCustomerToolStripMenuItem
            // 
            this.manageCustomerToolStripMenuItem.Name = "manageCustomerToolStripMenuItem";
            this.manageCustomerToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.manageCustomerToolStripMenuItem.Text = "Quản lý khách";
            this.manageCustomerToolStripMenuItem.Click += new System.EventHandler(this.manageCustomerToolStripMenuItem_Click);
            // 
            // manageBillToolStripMenuItem
            // 
            this.manageBillToolStripMenuItem.Name = "manageBillToolStripMenuItem";
            this.manageBillToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.manageBillToolStripMenuItem.Text = "Quản lý hóa đơn";
            this.manageBillToolStripMenuItem.Click += new System.EventHandler(this.manageBillToolStripMenuItem_Click);
            // 
            // incomeStatisticToolStripMenuItem
            // 
            this.incomeStatisticToolStripMenuItem.Name = "incomeStatisticToolStripMenuItem";
            this.incomeStatisticToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.incomeStatisticToolStripMenuItem.Text = "Thống kê thu nhập";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.hướngDẫnSửDụngToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.helpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "Thông tin";
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            this.hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            this.hướngDẫnSửDụngToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hướngDẫnSửDụngToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            // 
            // ServiceListGridView
            // 
            this.ServiceListGridView.AllowUserToAddRows = false;
            this.ServiceListGridView.AllowUserToDeleteRows = false;
            this.ServiceListGridView.Location = new System.Drawing.Point(6, 19);
            this.ServiceListGridView.MultiSelect = false;
            this.ServiceListGridView.Name = "ServiceListGridView";
            this.ServiceListGridView.ReadOnly = true;
            this.ServiceListGridView.RowHeadersVisible = false;
            this.ServiceListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServiceListGridView.Size = new System.Drawing.Size(483, 260);
            this.ServiceListGridView.TabIndex = 1;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(142, 34);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(245, 26);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Thêm hoặc sửa hóa đơn";
            // 
            // ServiceListGroupBox
            // 
            this.ServiceListGroupBox.Controls.Add(this.ServicePriceNumericUpDown);
            this.ServiceListGroupBox.Controls.Add(this.label1);
            this.ServiceListGroupBox.Controls.Add(this.SaveServiceButton);
            this.ServiceListGroupBox.Controls.Add(this.RemoveServiceButton);
            this.ServiceListGroupBox.Controls.Add(this.TotalPriceLabel);
            this.ServiceListGroupBox.Controls.Add(this.TotalPriceNumericUpDown);
            this.ServiceListGroupBox.Controls.Add(this.FilterLabel);
            this.ServiceListGroupBox.Controls.Add(this.AddServiceButton);
            this.ServiceListGroupBox.Controls.Add(this.ServiceCountNumericUpDown);
            this.ServiceListGroupBox.Controls.Add(this.ServiceCountLabel);
            this.ServiceListGroupBox.Controls.Add(this.ServiceComboBox);
            this.ServiceListGroupBox.Controls.Add(this.ServiceFilterTextbox);
            this.ServiceListGroupBox.Controls.Add(this.ServiceLabel);
            this.ServiceListGroupBox.Controls.Add(this.ServiceListGridView);
            this.ServiceListGroupBox.Location = new System.Drawing.Point(26, 77);
            this.ServiceListGroupBox.Name = "ServiceListGroupBox";
            this.ServiceListGroupBox.Size = new System.Drawing.Size(495, 368);
            this.ServiceListGroupBox.TabIndex = 0;
            this.ServiceListGroupBox.TabStop = false;
            this.ServiceListGroupBox.Text = "Các dịch vụ đã sử dụng";
            // 
            // ServicePriceNumericUpDown
            // 
            this.ServicePriceNumericUpDown.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ServicePriceNumericUpDown.Location = new System.Drawing.Point(369, 286);
            this.ServicePriceNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.ServicePriceNumericUpDown.Name = "ServicePriceNumericUpDown";
            this.ServicePriceNumericUpDown.ReadOnly = true;
            this.ServicePriceNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.ServicePriceNumericUpDown.TabIndex = 16;
            this.ServicePriceNumericUpDown.TabStop = false;
            this.ServicePriceNumericUpDown.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Giá dịch vụ";
            // 
            // SaveServiceButton
            // 
            this.SaveServiceButton.Location = new System.Drawing.Point(319, 335);
            this.SaveServiceButton.Name = "SaveServiceButton";
            this.SaveServiceButton.Size = new System.Drawing.Size(75, 23);
            this.SaveServiceButton.TabIndex = 14;
            this.SaveServiceButton.Text = "Lưu thay đổi";
            this.SaveServiceButton.UseVisualStyleBackColor = true;
            this.SaveServiceButton.Click += new System.EventHandler(this.SaveServiceButton_Click);
            // 
            // RemoveServiceButton
            // 
            this.RemoveServiceButton.Location = new System.Drawing.Point(235, 335);
            this.RemoveServiceButton.Name = "RemoveServiceButton";
            this.RemoveServiceButton.Size = new System.Drawing.Size(78, 23);
            this.RemoveServiceButton.TabIndex = 13;
            this.RemoveServiceButton.Text = "Xóa dịch vụ";
            this.RemoveServiceButton.UseVisualStyleBackColor = true;
            this.RemoveServiceButton.Click += new System.EventHandler(this.RemoveServiceButton_Click);
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Location = new System.Drawing.Point(312, 314);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(49, 13);
            this.TotalPriceLabel.TabIndex = 12;
            this.TotalPriceLabel.Text = "Tổng giá";
            // 
            // TotalPriceNumericUpDown
            // 
            this.TotalPriceNumericUpDown.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TotalPriceNumericUpDown.Location = new System.Drawing.Point(369, 312);
            this.TotalPriceNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.TotalPriceNumericUpDown.Name = "TotalPriceNumericUpDown";
            this.TotalPriceNumericUpDown.ReadOnly = true;
            this.TotalPriceNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.TotalPriceNumericUpDown.TabIndex = 2;
            this.TotalPriceNumericUpDown.TabStop = false;
            this.TotalPriceNumericUpDown.ThousandsSeparator = true;
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Location = new System.Drawing.Point(6, 288);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(37, 13);
            this.FilterLabel.TabIndex = 10;
            this.FilterLabel.Text = "Bộ lọc";
            // 
            // AddServiceButton
            // 
            this.AddServiceButton.Location = new System.Drawing.Point(400, 335);
            this.AddServiceButton.Name = "AddServiceButton";
            this.AddServiceButton.Size = new System.Drawing.Size(89, 23);
            this.AddServiceButton.TabIndex = 5;
            this.AddServiceButton.Text = "Thêm dịch vụ";
            this.AddServiceButton.UseVisualStyleBackColor = true;
            this.AddServiceButton.Click += new System.EventHandler(this.AddServiceButton_Click);
            // 
            // ServiceCountNumericUpDown
            // 
            this.ServiceCountNumericUpDown.Location = new System.Drawing.Point(66, 338);
            this.ServiceCountNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.ServiceCountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ServiceCountNumericUpDown.Name = "ServiceCountNumericUpDown";
            this.ServiceCountNumericUpDown.Size = new System.Drawing.Size(38, 20);
            this.ServiceCountNumericUpDown.TabIndex = 4;
            this.ServiceCountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ServiceCountLabel
            // 
            this.ServiceCountLabel.AutoSize = true;
            this.ServiceCountLabel.Location = new System.Drawing.Point(6, 340);
            this.ServiceCountLabel.Name = "ServiceCountLabel";
            this.ServiceCountLabel.Size = new System.Drawing.Size(49, 13);
            this.ServiceCountLabel.TabIndex = 8;
            this.ServiceCountLabel.Text = "Số lượng";
            // 
            // ServiceComboBox
            // 
            this.ServiceComboBox.FormattingEnabled = true;
            this.ServiceComboBox.Location = new System.Drawing.Point(66, 311);
            this.ServiceComboBox.Name = "ServiceComboBox";
            this.ServiceComboBox.Size = new System.Drawing.Size(121, 21);
            this.ServiceComboBox.TabIndex = 3;
            this.ServiceComboBox.SelectedIndexChanged += new System.EventHandler(this.ServiceComboBox_SelectedIndexChanged);
            // 
            // ServiceFilterTextbox
            // 
            this.ServiceFilterTextbox.Location = new System.Drawing.Point(66, 285);
            this.ServiceFilterTextbox.Name = "ServiceFilterTextbox";
            this.ServiceFilterTextbox.Size = new System.Drawing.Size(100, 20);
            this.ServiceFilterTextbox.TabIndex = 2;
            // 
            // ServiceLabel
            // 
            this.ServiceLabel.AutoSize = true;
            this.ServiceLabel.Location = new System.Drawing.Point(6, 314);
            this.ServiceLabel.Name = "ServiceLabel";
            this.ServiceLabel.Size = new System.Drawing.Size(44, 13);
            this.ServiceLabel.TabIndex = 6;
            this.ServiceLabel.Text = "Dịch vụ";
            // 
            // EmployeeGroupBox
            // 
            this.EmployeeGroupBox.Controls.Add(this.EmployeeFilterTextbox);
            this.EmployeeGroupBox.Controls.Add(this.EmployeeLabel);
            this.EmployeeGroupBox.Controls.Add(this.EmployeeComboBox);
            this.EmployeeGroupBox.Controls.Add(this.EmployeeFilterLabel);
            this.EmployeeGroupBox.Location = new System.Drawing.Point(527, 306);
            this.EmployeeGroupBox.Name = "EmployeeGroupBox";
            this.EmployeeGroupBox.Size = new System.Drawing.Size(200, 76);
            this.EmployeeGroupBox.TabIndex = 2;
            this.EmployeeGroupBox.TabStop = false;
            this.EmployeeGroupBox.Text = "Thông tin nhân viên";
            // 
            // EmployeeFilterTextbox
            // 
            this.EmployeeFilterTextbox.Location = new System.Drawing.Point(68, 18);
            this.EmployeeFilterTextbox.Name = "EmployeeFilterTextbox";
            this.EmployeeFilterTextbox.Size = new System.Drawing.Size(100, 20);
            this.EmployeeFilterTextbox.TabIndex = 13;
            // 
            // EmployeeLabel
            // 
            this.EmployeeLabel.AutoSize = true;
            this.EmployeeLabel.Location = new System.Drawing.Point(6, 47);
            this.EmployeeLabel.Name = "EmployeeLabel";
            this.EmployeeLabel.Size = new System.Drawing.Size(56, 13);
            this.EmployeeLabel.TabIndex = 10;
            this.EmployeeLabel.Text = "Nhân viên";
            // 
            // EmployeeComboBox
            // 
            this.EmployeeComboBox.FormattingEnabled = true;
            this.EmployeeComboBox.Location = new System.Drawing.Point(68, 44);
            this.EmployeeComboBox.Name = "EmployeeComboBox";
            this.EmployeeComboBox.Size = new System.Drawing.Size(121, 21);
            this.EmployeeComboBox.TabIndex = 14;
            // 
            // EmployeeFilterLabel
            // 
            this.EmployeeFilterLabel.AutoSize = true;
            this.EmployeeFilterLabel.Location = new System.Drawing.Point(6, 21);
            this.EmployeeFilterLabel.Name = "EmployeeFilterLabel";
            this.EmployeeFilterLabel.Size = new System.Drawing.Size(37, 13);
            this.EmployeeFilterLabel.TabIndex = 8;
            this.EmployeeFilterLabel.Text = "Bộ lọc";
            // 
            // CustomerGroupBox
            // 
            this.CustomerGroupBox.Controls.Add(this.ResetCustomerButton);
            this.CustomerGroupBox.Controls.Add(this.DeleteCustomerButton);
            this.CustomerGroupBox.Controls.Add(this.SaveCustomerButton);
            this.CustomerGroupBox.Controls.Add(this.CreateCustomerButton);
            this.CustomerGroupBox.Controls.Add(this.CustomerFemaleButton);
            this.CustomerGroupBox.Controls.Add(this.CustomerMaleButton);
            this.CustomerGroupBox.Controls.Add(this.CustomerSexLabel);
            this.CustomerGroupBox.Controls.Add(this.CustomerDateOfBirthLabel);
            this.CustomerGroupBox.Controls.Add(this.CustomerRLIDTextBox);
            this.CustomerGroupBox.Controls.Add(this.CustomerDateOfBirthPicker);
            this.CustomerGroupBox.Controls.Add(this.CustomerFullNameTextBox);
            this.CustomerGroupBox.Controls.Add(this.HorizontalLineLabel);
            this.CustomerGroupBox.Controls.Add(this.CustomerFilterTextBox);
            this.CustomerGroupBox.Controls.Add(this.CustomerLabel);
            this.CustomerGroupBox.Controls.Add(this.CustomerComboBox);
            this.CustomerGroupBox.Controls.Add(this.CustomerFilterLabel);
            this.CustomerGroupBox.Controls.Add(this.CustomerRLIDLabel);
            this.CustomerGroupBox.Controls.Add(this.CustomerFullNameLabel);
            this.CustomerGroupBox.Location = new System.Drawing.Point(527, 77);
            this.CustomerGroupBox.Name = "CustomerGroupBox";
            this.CustomerGroupBox.Size = new System.Drawing.Size(214, 223);
            this.CustomerGroupBox.TabIndex = 1;
            this.CustomerGroupBox.TabStop = false;
            this.CustomerGroupBox.Text = "Thông tin khách hàng";
            // 
            // ResetCustomerButton
            // 
            this.ResetCustomerButton.Location = new System.Drawing.Point(7, 194);
            this.ResetCustomerButton.Name = "ResetCustomerButton";
            this.ResetCustomerButton.Size = new System.Drawing.Size(46, 23);
            this.ResetCustomerButton.TabIndex = 22;
            this.ResetCustomerButton.Text = "Đặt lại";
            this.ResetCustomerButton.UseVisualStyleBackColor = true;
            this.ResetCustomerButton.Click += new System.EventHandler(this.ResetCustomerButton_Click);
            // 
            // DeleteCustomerButton
            // 
            this.DeleteCustomerButton.Enabled = false;
            this.DeleteCustomerButton.Location = new System.Drawing.Point(165, 194);
            this.DeleteCustomerButton.Name = "DeleteCustomerButton";
            this.DeleteCustomerButton.Size = new System.Drawing.Size(39, 23);
            this.DeleteCustomerButton.TabIndex = 25;
            this.DeleteCustomerButton.Text = "Xóa";
            this.DeleteCustomerButton.UseVisualStyleBackColor = true;
            // 
            // SaveCustomerButton
            // 
            this.SaveCustomerButton.Enabled = false;
            this.SaveCustomerButton.Location = new System.Drawing.Point(121, 194);
            this.SaveCustomerButton.Name = "SaveCustomerButton";
            this.SaveCustomerButton.Size = new System.Drawing.Size(38, 23);
            this.SaveCustomerButton.TabIndex = 24;
            this.SaveCustomerButton.Text = "Lưu";
            this.SaveCustomerButton.UseVisualStyleBackColor = true;
            // 
            // CreateCustomerButton
            // 
            this.CreateCustomerButton.Location = new System.Drawing.Point(59, 194);
            this.CreateCustomerButton.Name = "CreateCustomerButton";
            this.CreateCustomerButton.Size = new System.Drawing.Size(56, 23);
            this.CreateCustomerButton.TabIndex = 23;
            this.CreateCustomerButton.Text = "Tạo mới";
            this.CreateCustomerButton.UseVisualStyleBackColor = true;
            // 
            // CustomerFemaleButton
            // 
            this.CustomerFemaleButton.AutoSize = true;
            this.CustomerFemaleButton.Location = new System.Drawing.Point(121, 141);
            this.CustomerFemaleButton.Name = "CustomerFemaleButton";
            this.CustomerFemaleButton.Size = new System.Drawing.Size(39, 17);
            this.CustomerFemaleButton.TabIndex = 9;
            this.CustomerFemaleButton.Text = "Nữ";
            this.CustomerFemaleButton.UseVisualStyleBackColor = true;
            // 
            // CustomerMaleButton
            // 
            this.CustomerMaleButton.AutoSize = true;
            this.CustomerMaleButton.Checked = true;
            this.CustomerMaleButton.Location = new System.Drawing.Point(68, 141);
            this.CustomerMaleButton.Name = "CustomerMaleButton";
            this.CustomerMaleButton.Size = new System.Drawing.Size(47, 17);
            this.CustomerMaleButton.TabIndex = 8;
            this.CustomerMaleButton.TabStop = true;
            this.CustomerMaleButton.Text = "Nam";
            this.CustomerMaleButton.UseVisualStyleBackColor = true;
            // 
            // CustomerSexLabel
            // 
            this.CustomerSexLabel.AutoSize = true;
            this.CustomerSexLabel.Location = new System.Drawing.Point(6, 143);
            this.CustomerSexLabel.Name = "CustomerSexLabel";
            this.CustomerSexLabel.Size = new System.Drawing.Size(47, 13);
            this.CustomerSexLabel.TabIndex = 13;
            this.CustomerSexLabel.Text = "Giới tính";
            // 
            // CustomerDateOfBirthLabel
            // 
            this.CustomerDateOfBirthLabel.AutoSize = true;
            this.CustomerDateOfBirthLabel.Location = new System.Drawing.Point(6, 120);
            this.CustomerDateOfBirthLabel.Name = "CustomerDateOfBirthLabel";
            this.CustomerDateOfBirthLabel.Size = new System.Drawing.Size(54, 13);
            this.CustomerDateOfBirthLabel.TabIndex = 12;
            this.CustomerDateOfBirthLabel.Text = "Ngày sinh";
            // 
            // CustomerRLIDTextBox
            // 
            this.CustomerRLIDTextBox.Location = new System.Drawing.Point(68, 164);
            this.CustomerRLIDTextBox.Name = "CustomerRLIDTextBox";
            this.CustomerRLIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.CustomerRLIDTextBox.TabIndex = 10;
            // 
            // CustomerDateOfBirthPicker
            // 
            this.CustomerDateOfBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CustomerDateOfBirthPicker.Location = new System.Drawing.Point(68, 116);
            this.CustomerDateOfBirthPicker.Name = "CustomerDateOfBirthPicker";
            this.CustomerDateOfBirthPicker.Size = new System.Drawing.Size(118, 20);
            this.CustomerDateOfBirthPicker.TabIndex = 11;
            this.CustomerDateOfBirthPicker.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // CustomerFullNameTextBox
            // 
            this.CustomerFullNameTextBox.Location = new System.Drawing.Point(68, 90);
            this.CustomerFullNameTextBox.Name = "CustomerFullNameTextBox";
            this.CustomerFullNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.CustomerFullNameTextBox.TabIndex = 7;
            // 
            // HorizontalLineLabel
            // 
            this.HorizontalLineLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HorizontalLineLabel.Location = new System.Drawing.Point(31, 77);
            this.HorizontalLineLabel.Name = "HorizontalLineLabel";
            this.HorizontalLineLabel.Size = new System.Drawing.Size(140, 2);
            this.HorizontalLineLabel.TabIndex = 8;
            // 
            // CustomerFilterTextBox
            // 
            this.CustomerFilterTextBox.Location = new System.Drawing.Point(68, 19);
            this.CustomerFilterTextBox.Name = "CustomerFilterTextBox";
            this.CustomerFilterTextBox.Size = new System.Drawing.Size(100, 20);
            this.CustomerFilterTextBox.TabIndex = 5;
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Location = new System.Drawing.Point(6, 48);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(38, 13);
            this.CustomerLabel.TabIndex = 4;
            this.CustomerLabel.Text = "Khách";
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Location = new System.Drawing.Point(68, 45);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(121, 21);
            this.CustomerComboBox.TabIndex = 6;
            this.CustomerComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomerComboBox_SelectedIndexChanged);
            // 
            // CustomerFilterLabel
            // 
            this.CustomerFilterLabel.AutoSize = true;
            this.CustomerFilterLabel.Location = new System.Drawing.Point(6, 22);
            this.CustomerFilterLabel.Name = "CustomerFilterLabel";
            this.CustomerFilterLabel.Size = new System.Drawing.Size(37, 13);
            this.CustomerFilterLabel.TabIndex = 2;
            this.CustomerFilterLabel.Text = "Bộ lọc";
            // 
            // CustomerRLIDLabel
            // 
            this.CustomerRLIDLabel.AutoSize = true;
            this.CustomerRLIDLabel.Location = new System.Drawing.Point(6, 167);
            this.CustomerRLIDLabel.Name = "CustomerRLIDLabel";
            this.CustomerRLIDLabel.Size = new System.Drawing.Size(39, 13);
            this.CustomerRLIDLabel.TabIndex = 1;
            this.CustomerRLIDLabel.Text = "CMND";
            // 
            // CustomerFullNameLabel
            // 
            this.CustomerFullNameLabel.AutoSize = true;
            this.CustomerFullNameLabel.Location = new System.Drawing.Point(6, 93);
            this.CustomerFullNameLabel.Name = "CustomerFullNameLabel";
            this.CustomerFullNameLabel.Size = new System.Drawing.Size(39, 13);
            this.CustomerFullNameLabel.TabIndex = 0;
            this.CustomerFullNameLabel.Text = "Họ tên";
            // 
            // BillManipulatingGroupBox
            // 
            this.BillManipulatingGroupBox.Controls.Add(this.ResetBillButton);
            this.BillManipulatingGroupBox.Controls.Add(this.DeleteBillButton);
            this.BillManipulatingGroupBox.Controls.Add(this.SaveBillButton);
            this.BillManipulatingGroupBox.Controls.Add(this.NewBillButton);
            this.BillManipulatingGroupBox.Controls.Add(this.ExportBillButton);
            this.BillManipulatingGroupBox.Location = new System.Drawing.Point(527, 388);
            this.BillManipulatingGroupBox.Name = "BillManipulatingGroupBox";
            this.BillManipulatingGroupBox.Size = new System.Drawing.Size(267, 57);
            this.BillManipulatingGroupBox.TabIndex = 3;
            this.BillManipulatingGroupBox.TabStop = false;
            this.BillManipulatingGroupBox.Text = "Chức năng với hóa đơn";
            // 
            // ResetBillButton
            // 
            this.ResetBillButton.Location = new System.Drawing.Point(8, 24);
            this.ResetBillButton.Name = "ResetBillButton";
            this.ResetBillButton.Size = new System.Drawing.Size(45, 23);
            this.ResetBillButton.TabIndex = 18;
            this.ResetBillButton.Text = "Đặt lại";
            this.ResetBillButton.UseVisualStyleBackColor = true;
            this.ResetBillButton.Click += new System.EventHandler(this.ResetBillButton_Click);
            // 
            // DeleteBillButton
            // 
            this.DeleteBillButton.Enabled = false;
            this.DeleteBillButton.Location = new System.Drawing.Point(165, 24);
            this.DeleteBillButton.Name = "DeleteBillButton";
            this.DeleteBillButton.Size = new System.Drawing.Size(39, 23);
            this.DeleteBillButton.TabIndex = 21;
            this.DeleteBillButton.Text = "Xóa";
            this.DeleteBillButton.UseVisualStyleBackColor = true;
            this.DeleteBillButton.Click += new System.EventHandler(this.DeleteBillButton_Click);
            // 
            // SaveBillButton
            // 
            this.SaveBillButton.Enabled = false;
            this.SaveBillButton.Location = new System.Drawing.Point(121, 24);
            this.SaveBillButton.Name = "SaveBillButton";
            this.SaveBillButton.Size = new System.Drawing.Size(38, 23);
            this.SaveBillButton.TabIndex = 20;
            this.SaveBillButton.Text = "Lưu";
            this.SaveBillButton.UseVisualStyleBackColor = true;
            this.SaveBillButton.Click += new System.EventHandler(this.SaveBillButton_Click);
            // 
            // NewBillButton
            // 
            this.NewBillButton.Location = new System.Drawing.Point(59, 24);
            this.NewBillButton.Name = "NewBillButton";
            this.NewBillButton.Size = new System.Drawing.Size(56, 23);
            this.NewBillButton.TabIndex = 19;
            this.NewBillButton.Text = "Tạo mới";
            this.NewBillButton.UseVisualStyleBackColor = true;
            this.NewBillButton.Click += new System.EventHandler(this.NewBillButton_Click);
            // 
            // ExportBillButton
            // 
            this.ExportBillButton.Location = new System.Drawing.Point(210, 24);
            this.ExportBillButton.Name = "ExportBillButton";
            this.ExportBillButton.Size = new System.Drawing.Size(49, 23);
            this.ExportBillButton.TabIndex = 17;
            this.ExportBillButton.Text = "Xuất";
            this.ExportBillButton.UseVisualStyleBackColor = true;
            this.ExportBillButton.Click += new System.EventHandler(this.ExportBillButton_Click);
            // 
            // BillPrintPreviewDialog
            // 
            this.BillPrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.BillPrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.BillPrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.BillPrintPreviewDialog.Enabled = true;
            this.BillPrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("BillPrintPreviewDialog.Icon")));
            this.BillPrintPreviewDialog.Name = "BillPrintPreviewDialog";
            this.BillPrintPreviewDialog.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 458);
            this.Controls.Add(this.BillManipulatingGroupBox);
            this.Controls.Add(this.CustomerGroupBox);
            this.Controls.Add(this.EmployeeGroupBox);
            this.Controls.Add(this.ServiceListGroupBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.MainFormMenuStrip);
            this.MainMenuStrip = this.MainFormMenuStrip;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.MainFormMenuStrip.ResumeLayout(false);
            this.MainFormMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceListGridView)).EndInit();
            this.ServiceListGroupBox.ResumeLayout(false);
            this.ServiceListGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServicePriceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalPriceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceCountNumericUpDown)).EndInit();
            this.EmployeeGroupBox.ResumeLayout(false);
            this.EmployeeGroupBox.PerformLayout();
            this.CustomerGroupBox.ResumeLayout(false);
            this.CustomerGroupBox.PerformLayout();
            this.BillManipulatingGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incomeStatisticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridView ServiceListGridView;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.GroupBox ServiceListGroupBox;
        private System.Windows.Forms.Button AddServiceButton;
        private System.Windows.Forms.TextBox ServiceFilterTextbox;
        private System.Windows.Forms.Label ServiceLabel;
        private System.Windows.Forms.ComboBox ServiceComboBox;
        private System.Windows.Forms.NumericUpDown ServiceCountNumericUpDown;
        private System.Windows.Forms.Label ServiceCountLabel;
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.GroupBox EmployeeGroupBox;
        private System.Windows.Forms.GroupBox CustomerGroupBox;
        private System.Windows.Forms.TextBox CustomerFullNameTextBox;
        private System.Windows.Forms.Label HorizontalLineLabel;
        private System.Windows.Forms.TextBox CustomerFilterTextBox;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.Label CustomerFilterLabel;
        private System.Windows.Forms.Label CustomerRLIDLabel;
        private System.Windows.Forms.Label CustomerFullNameLabel;
        private System.Windows.Forms.DateTimePicker CustomerDateOfBirthPicker;
        private System.Windows.Forms.TextBox CustomerRLIDTextBox;
        private System.Windows.Forms.Label CustomerDateOfBirthLabel;
        private System.Windows.Forms.RadioButton CustomerFemaleButton;
        private System.Windows.Forms.RadioButton CustomerMaleButton;
        private System.Windows.Forms.Label CustomerSexLabel;
        private System.Windows.Forms.TextBox EmployeeFilterTextbox;
        private System.Windows.Forms.Label EmployeeLabel;
        private System.Windows.Forms.ComboBox EmployeeComboBox;
        private System.Windows.Forms.Label EmployeeFilterLabel;
        private System.Windows.Forms.GroupBox BillManipulatingGroupBox;
        private System.Windows.Forms.ToolStripMenuItem manageBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
        private System.Windows.Forms.Button ExportBillButton;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCustomerToolStripMenuItem;
        private System.Windows.Forms.Button ResetBillButton;
        private System.Windows.Forms.Button DeleteBillButton;
        private System.Windows.Forms.Button SaveBillButton;
        private System.Windows.Forms.Button NewBillButton;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.NumericUpDown TotalPriceNumericUpDown;
        private System.Windows.Forms.Button RemoveServiceButton;
        private System.Windows.Forms.Button SaveServiceButton;
        private System.Windows.Forms.NumericUpDown ServicePriceNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ResetCustomerButton;
        private System.Windows.Forms.Button DeleteCustomerButton;
        private System.Windows.Forms.Button SaveCustomerButton;
        private System.Windows.Forms.Button CreateCustomerButton;
        private System.Windows.Forms.PrintPreviewDialog BillPrintPreviewDialog;
    }
}