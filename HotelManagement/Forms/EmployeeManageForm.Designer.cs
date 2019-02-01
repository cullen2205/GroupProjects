namespace HotelManagement
{
    partial class EmployeeManageForm
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
            this.components = new System.ComponentModel.Container();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.EmployeeGridView = new System.Windows.Forms.DataGridView();
            this.EmployeeListGroupBox = new System.Windows.Forms.GroupBox();
            this.FilterTextbox = new System.Windows.Forms.TextBox();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.EmployeeInforGroupBox = new System.Windows.Forms.GroupBox();
            this.PhonenumberTextbox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.PhonenumberLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.IsAdminCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AddressRichTextbox = new System.Windows.Forms.RichTextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.NewButton = new System.Windows.Forms.Button();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.SexLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.RealLifeIdNumberTextbox = new System.Windows.Forms.TextBox();
            this.DateOfBirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.RealLifeIdNumberLabel = new System.Windows.Forms.Label();
            this.FullNameTextbox = new System.Windows.Forms.TextBox();
            this.HorizontalLineLabel = new System.Windows.Forms.Label();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.IdNumericUpdown = new System.Windows.Forms.NumericUpDown();
            this.ValidatingErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).BeginInit();
            this.EmployeeListGroupBox.SuspendLayout();
            this.EmployeeInforGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidatingErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(156, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(187, 26);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Quản lý nhân viên";
            // 
            // EmployeeGridView
            // 
            this.EmployeeGridView.AllowUserToAddRows = false;
            this.EmployeeGridView.AllowUserToDeleteRows = false;
            this.EmployeeGridView.AllowUserToResizeRows = false;
            this.EmployeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeGridView.Location = new System.Drawing.Point(6, 45);
            this.EmployeeGridView.MultiSelect = false;
            this.EmployeeGridView.Name = "EmployeeGridView";
            this.EmployeeGridView.ReadOnly = true;
            this.EmployeeGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeeGridView.ShowEditingIcon = false;
            this.EmployeeGridView.Size = new System.Drawing.Size(490, 309);
            this.EmployeeGridView.TabIndex = 2;
            this.EmployeeGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeGridView_RowEnter);
            // 
            // EmployeeListGroupBox
            // 
            this.EmployeeListGroupBox.Controls.Add(this.FilterTextbox);
            this.EmployeeListGroupBox.Controls.Add(this.FilterLabel);
            this.EmployeeListGroupBox.Controls.Add(this.EmployeeGridView);
            this.EmployeeListGroupBox.Location = new System.Drawing.Point(12, 38);
            this.EmployeeListGroupBox.Name = "EmployeeListGroupBox";
            this.EmployeeListGroupBox.Size = new System.Drawing.Size(503, 362);
            this.EmployeeListGroupBox.TabIndex = 0;
            this.EmployeeListGroupBox.TabStop = false;
            this.EmployeeListGroupBox.Text = "Danh sách nhân viên";
            // 
            // FilterTextbox
            // 
            this.FilterTextbox.Location = new System.Drawing.Point(49, 19);
            this.FilterTextbox.Name = "FilterTextbox";
            this.FilterTextbox.Size = new System.Drawing.Size(100, 20);
            this.FilterTextbox.TabIndex = 1;
            this.FilterTextbox.TextChanged += new System.EventHandler(this.FilterTextbox_TextChanged);
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Location = new System.Drawing.Point(6, 22);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(37, 13);
            this.FilterLabel.TabIndex = 2;
            this.FilterLabel.Text = "Bộ lọc";
            // 
            // EmployeeInforGroupBox
            // 
            this.EmployeeInforGroupBox.Controls.Add(this.PhonenumberTextbox);
            this.EmployeeInforGroupBox.Controls.Add(this.ResetButton);
            this.EmployeeInforGroupBox.Controls.Add(this.PhonenumberLabel);
            this.EmployeeInforGroupBox.Controls.Add(this.DeleteButton);
            this.EmployeeInforGroupBox.Controls.Add(this.IsAdminCheckBox);
            this.EmployeeInforGroupBox.Controls.Add(this.SaveButton);
            this.EmployeeInforGroupBox.Controls.Add(this.AddressRichTextbox);
            this.EmployeeInforGroupBox.Controls.Add(this.AddressLabel);
            this.EmployeeInforGroupBox.Controls.Add(this.NewButton);
            this.EmployeeInforGroupBox.Controls.Add(this.FemaleRadioButton);
            this.EmployeeInforGroupBox.Controls.Add(this.MaleRadioButton);
            this.EmployeeInforGroupBox.Controls.Add(this.SexLabel);
            this.EmployeeInforGroupBox.Controls.Add(this.DateOfBirthLabel);
            this.EmployeeInforGroupBox.Controls.Add(this.RealLifeIdNumberTextbox);
            this.EmployeeInforGroupBox.Controls.Add(this.DateOfBirthDatePicker);
            this.EmployeeInforGroupBox.Controls.Add(this.RealLifeIdNumberLabel);
            this.EmployeeInforGroupBox.Controls.Add(this.FullNameTextbox);
            this.EmployeeInforGroupBox.Controls.Add(this.HorizontalLineLabel);
            this.EmployeeInforGroupBox.Controls.Add(this.PasswordTextbox);
            this.EmployeeInforGroupBox.Controls.Add(this.UsernameTextbox);
            this.EmployeeInforGroupBox.Controls.Add(this.FullNameLabel);
            this.EmployeeInforGroupBox.Controls.Add(this.PasswordLabel);
            this.EmployeeInforGroupBox.Controls.Add(this.UsernameLabel);
            this.EmployeeInforGroupBox.Location = new System.Drawing.Point(521, 38);
            this.EmployeeInforGroupBox.Name = "EmployeeInforGroupBox";
            this.EmployeeInforGroupBox.Size = new System.Drawing.Size(229, 362);
            this.EmployeeInforGroupBox.TabIndex = 1;
            this.EmployeeInforGroupBox.TabStop = false;
            this.EmployeeInforGroupBox.Text = "Thông tin nhân viên";
            // 
            // PhonenumberTextbox
            // 
            this.PhonenumberTextbox.Location = new System.Drawing.Point(94, 295);
            this.PhonenumberTextbox.MaxLength = 20;
            this.PhonenumberTextbox.Name = "PhonenumberTextbox";
            this.PhonenumberTextbox.Size = new System.Drawing.Size(100, 20);
            this.PhonenumberTextbox.TabIndex = 24;
            this.PhonenumberTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.PhonenumberTextbox_Validating);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(6, 331);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(56, 23);
            this.ResetButton.TabIndex = 23;
            this.ResetButton.Text = "Đặt lại";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // PhonenumberLabel
            // 
            this.PhonenumberLabel.AutoSize = true;
            this.PhonenumberLabel.Location = new System.Drawing.Point(7, 298);
            this.PhonenumberLabel.Name = "PhonenumberLabel";
            this.PhonenumberLabel.Size = new System.Drawing.Size(70, 13);
            this.PhonenumberLabel.TabIndex = 25;
            this.PhonenumberLabel.Text = "Số điện thoại";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(173, 331);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(39, 23);
            this.DeleteButton.TabIndex = 13;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // IsAdminCheckBox
            // 
            this.IsAdminCheckBox.AutoSize = true;
            this.IsAdminCheckBox.Location = new System.Drawing.Point(94, 71);
            this.IsAdminCheckBox.Name = "IsAdminCheckBox";
            this.IsAdminCheckBox.Size = new System.Drawing.Size(105, 17);
            this.IsAdminCheckBox.TabIndex = 5;
            this.IsAdminCheckBox.Text = "Là quản trị viên?";
            this.IsAdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(129, 331);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(38, 23);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Lưu";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddressRichTextbox
            // 
            this.AddressRichTextbox.Location = new System.Drawing.Point(94, 217);
            this.AddressRichTextbox.MaxLength = 100;
            this.AddressRichTextbox.Name = "AddressRichTextbox";
            this.AddressRichTextbox.Size = new System.Drawing.Size(118, 72);
            this.AddressRichTextbox.TabIndex = 10;
            this.AddressRichTextbox.Text = "";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(7, 220);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(40, 13);
            this.AddressLabel.TabIndex = 22;
            this.AddressLabel.Text = "Địa chỉ";
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(68, 331);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(55, 23);
            this.NewButton.TabIndex = 11;
            this.NewButton.Text = "Tạo mới";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Location = new System.Drawing.Point(147, 168);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(39, 17);
            this.FemaleRadioButton.TabIndex = 8;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Nữ";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Checked = true;
            this.MaleRadioButton.Location = new System.Drawing.Point(94, 168);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(47, 17);
            this.MaleRadioButton.TabIndex = 7;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Nam";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.Location = new System.Drawing.Point(7, 170);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(47, 13);
            this.SexLabel.TabIndex = 21;
            this.SexLabel.Text = "Giới tính";
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(7, 147);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(54, 13);
            this.DateOfBirthLabel.TabIndex = 20;
            this.DateOfBirthLabel.Text = "Ngày sinh";
            // 
            // RealLifeIdNumberTextbox
            // 
            this.RealLifeIdNumberTextbox.Location = new System.Drawing.Point(94, 191);
            this.RealLifeIdNumberTextbox.Name = "RealLifeIdNumberTextbox";
            this.RealLifeIdNumberTextbox.Size = new System.Drawing.Size(100, 20);
            this.RealLifeIdNumberTextbox.TabIndex = 9;
            this.RealLifeIdNumberTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.RealLifeIdNumberTextbox_Validating);
            // 
            // DateOfBirthDatePicker
            // 
            this.DateOfBirthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfBirthDatePicker.Location = new System.Drawing.Point(94, 143);
            this.DateOfBirthDatePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.DateOfBirthDatePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DateOfBirthDatePicker.Name = "DateOfBirthDatePicker";
            this.DateOfBirthDatePicker.Size = new System.Drawing.Size(118, 20);
            this.DateOfBirthDatePicker.TabIndex = 6;
            this.DateOfBirthDatePicker.Value = new System.DateTime(1990, 1, 1, 2, 0, 0, 0);
            // 
            // RealLifeIdNumberLabel
            // 
            this.RealLifeIdNumberLabel.AutoSize = true;
            this.RealLifeIdNumberLabel.Location = new System.Drawing.Point(7, 194);
            this.RealLifeIdNumberLabel.Name = "RealLifeIdNumberLabel";
            this.RealLifeIdNumberLabel.Size = new System.Drawing.Size(55, 13);
            this.RealLifeIdNumberLabel.TabIndex = 14;
            this.RealLifeIdNumberLabel.Text = "Số CMND";
            // 
            // FullNameTextbox
            // 
            this.FullNameTextbox.Location = new System.Drawing.Point(94, 114);
            this.FullNameTextbox.MaxLength = 50;
            this.FullNameTextbox.Name = "FullNameTextbox";
            this.FullNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.FullNameTextbox.TabIndex = 5;
            this.FullNameTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.FullNameTextbox_Validating);
            // 
            // HorizontalLineLabel
            // 
            this.HorizontalLineLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HorizontalLineLabel.Location = new System.Drawing.Point(35, 100);
            this.HorizontalLineLabel.Name = "HorizontalLineLabel";
            this.HorizontalLineLabel.Size = new System.Drawing.Size(151, 2);
            this.HorizontalLineLabel.TabIndex = 9;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(94, 45);
            this.PasswordTextbox.MaxLength = 31;
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '⏺';
            this.PasswordTextbox.Size = new System.Drawing.Size(100, 20);
            this.PasswordTextbox.TabIndex = 4;
            this.PasswordTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.PasswordTextbox_Validating);
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Location = new System.Drawing.Point(94, 19);
            this.UsernameTextbox.MaxLength = 20;
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(100, 20);
            this.UsernameTextbox.TabIndex = 3;
            this.UsernameTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.UsernameTextbox_Validating);
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(7, 117);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(39, 13);
            this.FullNameLabel.TabIndex = 2;
            this.FullNameLabel.Text = "Họ tên";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(7, 48);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(52, 13);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Mật khẩu";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(7, 22);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(81, 13);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Tên đăng nhập";
            // 
            // IdNumericUpdown
            // 
            this.IdNumericUpdown.Location = new System.Drawing.Point(615, 12);
            this.IdNumericUpdown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.IdNumericUpdown.Name = "IdNumericUpdown";
            this.IdNumericUpdown.Size = new System.Drawing.Size(0, 20);
            this.IdNumericUpdown.TabIndex = 0;
            this.IdNumericUpdown.TabStop = false;
            this.IdNumericUpdown.Visible = false;
            // 
            // ValidatingErrorProvider
            // 
            this.ValidatingErrorProvider.ContainerControl = this;
            // 
            // EmployeeManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 412);
            this.Controls.Add(this.IdNumericUpdown);
            this.Controls.Add(this.EmployeeInforGroupBox);
            this.Controls.Add(this.EmployeeListGroupBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "EmployeeManageForm";
            this.Text = "Khung quản lý nhân viên";
            this.Shown += new System.EventHandler(this.EmployeeManageForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).EndInit();
            this.EmployeeListGroupBox.ResumeLayout(false);
            this.EmployeeListGroupBox.PerformLayout();
            this.EmployeeInforGroupBox.ResumeLayout(false);
            this.EmployeeInforGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidatingErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.DataGridView EmployeeGridView;
        private System.Windows.Forms.GroupBox EmployeeListGroupBox;
        private System.Windows.Forms.GroupBox EmployeeInforGroupBox;
        private System.Windows.Forms.TextBox FilterTextbox;
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.Label HorizontalLineLabel;
        private System.Windows.Forms.TextBox FullNameTextbox;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.TextBox RealLifeIdNumberTextbox;
        private System.Windows.Forms.DateTimePicker DateOfBirthDatePicker;
        private System.Windows.Forms.Label RealLifeIdNumberLabel;
        private System.Windows.Forms.RichTextBox AddressRichTextbox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.CheckBox IsAdminCheckBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.NumericUpDown IdNumericUpdown;
        private System.Windows.Forms.TextBox PhonenumberTextbox;
        private System.Windows.Forms.Label PhonenumberLabel;
        private System.Windows.Forms.ErrorProvider ValidatingErrorProvider;
    }
}