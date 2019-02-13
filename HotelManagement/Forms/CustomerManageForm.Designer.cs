namespace HotelManagement
{
    partial class CustomerManageForm
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
            this.IdNumericUpdown = new System.Windows.Forms.NumericUpDown();
            this.CustomerInforGroupBox = new System.Windows.Forms.GroupBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.SexLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.RealLifeIdNumberTextbox = new System.Windows.Forms.TextBox();
            this.DateOfBirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.RealLifeIdNumberLabel = new System.Windows.Forms.Label();
            this.FullNameTextbox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.CustomerListGroupBox = new System.Windows.Forms.GroupBox();
            this.FilterTextbox = new System.Windows.Forms.TextBox();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.CustomerGridView = new System.Windows.Forms.DataGridView();
            this.TitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpdown)).BeginInit();
            this.CustomerInforGroupBox.SuspendLayout();
            this.CustomerListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // IdNumericUpdown
            // 
            this.IdNumericUpdown.Location = new System.Drawing.Point(614, 12);
            this.IdNumericUpdown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.IdNumericUpdown.Name = "IdNumericUpdown";
            this.IdNumericUpdown.Size = new System.Drawing.Size(0, 20);
            this.IdNumericUpdown.TabIndex = 2;
            this.IdNumericUpdown.TabStop = false;
            this.IdNumericUpdown.Visible = false;
            // 
            // CustomerInforGroupBox
            // 
            this.CustomerInforGroupBox.Controls.Add(this.ResetButton);
            this.CustomerInforGroupBox.Controls.Add(this.DeleteButton);
            this.CustomerInforGroupBox.Controls.Add(this.SaveButton);
            this.CustomerInforGroupBox.Controls.Add(this.NewButton);
            this.CustomerInforGroupBox.Controls.Add(this.FemaleRadioButton);
            this.CustomerInforGroupBox.Controls.Add(this.MaleRadioButton);
            this.CustomerInforGroupBox.Controls.Add(this.SexLabel);
            this.CustomerInforGroupBox.Controls.Add(this.DateOfBirthLabel);
            this.CustomerInforGroupBox.Controls.Add(this.RealLifeIdNumberTextbox);
            this.CustomerInforGroupBox.Controls.Add(this.DateOfBirthDatePicker);
            this.CustomerInforGroupBox.Controls.Add(this.RealLifeIdNumberLabel);
            this.CustomerInforGroupBox.Controls.Add(this.FullNameTextbox);
            this.CustomerInforGroupBox.Controls.Add(this.FullNameLabel);
            this.CustomerInforGroupBox.Location = new System.Drawing.Point(12, 283);
            this.CustomerInforGroupBox.Name = "CustomerInforGroupBox";
            this.CustomerInforGroupBox.Size = new System.Drawing.Size(229, 164);
            this.CustomerInforGroupBox.TabIndex = 1;
            this.CustomerInforGroupBox.TabStop = false;
            this.CustomerInforGroupBox.Text = "Thông tin khách hàng";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(6, 130);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(56, 23);
            this.ResetButton.TabIndex = 8;
            this.ResetButton.Text = "Đặt lại";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(173, 130);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(39, 23);
            this.DeleteButton.TabIndex = 11;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(129, 130);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(38, 23);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Lưu";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(68, 130);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(55, 23);
            this.NewButton.TabIndex = 9;
            this.NewButton.Text = "Tạo mới";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Location = new System.Drawing.Point(146, 73);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(39, 17);
            this.FemaleRadioButton.TabIndex = 6;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Nữ";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Checked = true;
            this.MaleRadioButton.Location = new System.Drawing.Point(93, 73);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(47, 17);
            this.MaleRadioButton.TabIndex = 5;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Nam";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.Location = new System.Drawing.Point(6, 75);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(47, 13);
            this.SexLabel.TabIndex = 21;
            this.SexLabel.Text = "Giới tính";
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(6, 52);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(54, 13);
            this.DateOfBirthLabel.TabIndex = 20;
            this.DateOfBirthLabel.Text = "Ngày sinh";
            // 
            // RealLifeIdNumberTextbox
            // 
            this.RealLifeIdNumberTextbox.Location = new System.Drawing.Point(93, 96);
            this.RealLifeIdNumberTextbox.Name = "RealLifeIdNumberTextbox";
            this.RealLifeIdNumberTextbox.Size = new System.Drawing.Size(100, 20);
            this.RealLifeIdNumberTextbox.TabIndex = 7;
            // 
            // DateOfBirthDatePicker
            // 
            this.DateOfBirthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfBirthDatePicker.Location = new System.Drawing.Point(93, 48);
            this.DateOfBirthDatePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.DateOfBirthDatePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DateOfBirthDatePicker.Name = "DateOfBirthDatePicker";
            this.DateOfBirthDatePicker.Size = new System.Drawing.Size(118, 20);
            this.DateOfBirthDatePicker.TabIndex = 4;
            this.DateOfBirthDatePicker.Value = new System.DateTime(1990, 1, 1, 2, 0, 0, 0);
            // 
            // RealLifeIdNumberLabel
            // 
            this.RealLifeIdNumberLabel.AutoSize = true;
            this.RealLifeIdNumberLabel.Location = new System.Drawing.Point(6, 99);
            this.RealLifeIdNumberLabel.Name = "RealLifeIdNumberLabel";
            this.RealLifeIdNumberLabel.Size = new System.Drawing.Size(55, 13);
            this.RealLifeIdNumberLabel.TabIndex = 14;
            this.RealLifeIdNumberLabel.Text = "Số CMND";
            // 
            // FullNameTextbox
            // 
            this.FullNameTextbox.Location = new System.Drawing.Point(93, 19);
            this.FullNameTextbox.MaxLength = 50;
            this.FullNameTextbox.Name = "FullNameTextbox";
            this.FullNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.FullNameTextbox.TabIndex = 3;
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(6, 22);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(39, 13);
            this.FullNameLabel.TabIndex = 2;
            this.FullNameLabel.Text = "Họ tên";
            // 
            // CustomerListGroupBox
            // 
            this.CustomerListGroupBox.Controls.Add(this.FilterTextbox);
            this.CustomerListGroupBox.Controls.Add(this.FilterLabel);
            this.CustomerListGroupBox.Controls.Add(this.CustomerGridView);
            this.CustomerListGroupBox.Location = new System.Drawing.Point(11, 38);
            this.CustomerListGroupBox.Name = "CustomerListGroupBox";
            this.CustomerListGroupBox.Size = new System.Drawing.Size(334, 238);
            this.CustomerListGroupBox.TabIndex = 0;
            this.CustomerListGroupBox.TabStop = false;
            this.CustomerListGroupBox.Text = "Danh sách khách hàng";
            // 
            // FilterTextbox
            // 
            this.FilterTextbox.Location = new System.Drawing.Point(49, 19);
            this.FilterTextbox.Name = "FilterTextbox";
            this.FilterTextbox.Size = new System.Drawing.Size(100, 20);
            this.FilterTextbox.TabIndex = 1;
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
            // CustomerGridView
            // 
            this.CustomerGridView.AllowUserToAddRows = false;
            this.CustomerGridView.AllowUserToDeleteRows = false;
            this.CustomerGridView.AllowUserToResizeRows = false;
            this.CustomerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGridView.Location = new System.Drawing.Point(6, 45);
            this.CustomerGridView.MultiSelect = false;
            this.CustomerGridView.Name = "CustomerGridView";
            this.CustomerGridView.ReadOnly = true;
            this.CustomerGridView.RowHeadersVisible = false;
            this.CustomerGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerGridView.ShowEditingIcon = false;
            this.CustomerGridView.Size = new System.Drawing.Size(319, 187);
            this.CustomerGridView.TabIndex = 2;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(28, 6);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(294, 26);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Quản lý thông tin khách hàng";
            // 
            // CustomerManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 459);
            this.Controls.Add(this.IdNumericUpdown);
            this.Controls.Add(this.CustomerInforGroupBox);
            this.Controls.Add(this.CustomerListGroupBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "CustomerManageForm";
            this.Text = "Quản lý thông tin khách hàng";
            this.Shown += new System.EventHandler(this.CustomerManageForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpdown)).EndInit();
            this.CustomerInforGroupBox.ResumeLayout(false);
            this.CustomerInforGroupBox.PerformLayout();
            this.CustomerListGroupBox.ResumeLayout(false);
            this.CustomerListGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown IdNumericUpdown;
        private System.Windows.Forms.GroupBox CustomerInforGroupBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.TextBox RealLifeIdNumberTextbox;
        private System.Windows.Forms.DateTimePicker DateOfBirthDatePicker;
        private System.Windows.Forms.Label RealLifeIdNumberLabel;
        private System.Windows.Forms.TextBox FullNameTextbox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.GroupBox CustomerListGroupBox;
        private System.Windows.Forms.TextBox FilterTextbox;
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.DataGridView CustomerGridView;
        private System.Windows.Forms.Label TitleLabel;
    }
}