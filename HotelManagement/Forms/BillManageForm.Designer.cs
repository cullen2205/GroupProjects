namespace HotelManagement
{
    partial class BillManageForm
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
            this.BilListGroupBox = new System.Windows.Forms.GroupBox();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.FilterTextbox = new System.Windows.Forms.TextBox();
            this.BillGridView = new System.Windows.Forms.DataGridView();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.BilListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(102, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(357, 26);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Quản lý các hóa đơn đã được lưu lại";
            // 
            // BilListGroupBox
            // 
            this.BilListGroupBox.Controls.Add(this.FilterLabel);
            this.BilListGroupBox.Controls.Add(this.FilterTextbox);
            this.BilListGroupBox.Controls.Add(this.BillGridView);
            this.BilListGroupBox.Location = new System.Drawing.Point(14, 51);
            this.BilListGroupBox.Name = "BilListGroupBox";
            this.BilListGroupBox.Size = new System.Drawing.Size(516, 320);
            this.BilListGroupBox.TabIndex = 1;
            this.BilListGroupBox.TabStop = false;
            this.BilListGroupBox.Text = "Danh sách các hóa đơn";
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Location = new System.Drawing.Point(6, 26);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(37, 13);
            this.FilterLabel.TabIndex = 10;
            this.FilterLabel.Text = "Bộ lọc";
            // 
            // FilterTextbox
            // 
            this.FilterTextbox.Location = new System.Drawing.Point(66, 23);
            this.FilterTextbox.Name = "FilterTextbox";
            this.FilterTextbox.Size = new System.Drawing.Size(100, 20);
            this.FilterTextbox.TabIndex = 2;
            // 
            // BillGridView
            // 
            this.BillGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillGridView.Location = new System.Drawing.Point(6, 49);
            this.BillGridView.Name = "BillGridView";
            this.BillGridView.Size = new System.Drawing.Size(500, 260);
            this.BillGridView.TabIndex = 1;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(455, 377);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(293, 377);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(75, 23);
            this.NewButton.TabIndex = 3;
            this.NewButton.Text = "Thêm";
            this.NewButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(374, 377);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Sửa";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // BillManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 416);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.BilListGroupBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "BillManageForm";
            this.Text = "BillManageForm";
            this.Shown += new System.EventHandler(this.BillManageForm_Shown);
            this.BilListGroupBox.ResumeLayout(false);
            this.BilListGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.GroupBox BilListGroupBox;
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.TextBox FilterTextbox;
        private System.Windows.Forms.DataGridView BillGridView;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button EditButton;
    }
}