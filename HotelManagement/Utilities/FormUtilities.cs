using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public static class FormUtilities
    {
        public static void SetRowIndex
        (
            DataGridView gridView, 
            int index = Int32.MaxValue
        )
        {
            if (gridView.Rows.Count > 0)
            {
                if (index < 0)
                    index = 0;
                else if (index >= gridView.Rows.Count)
                    index = gridView.Rows.Count - 1;

                gridView.Rows[index].Selected = true;
                gridView.Rows[index].Cells["ServiceName"].Selected = true;
            }
        }

        public static void FilterDataGridView(DataGridView gridView, string text)
        {
            gridView.ClearSelection();
            DataTable table = (DataTable)gridView.DataSource;
            string filterString = "";
            foreach (string word in
                text.Split
                (
                    new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries
                )
            )
            {
                filterString += string.Format("Filter like '%{0}%' and ", word);
            }
            table.DefaultView.RowFilter = filterString.Length > 4
                ? filterString.Substring(0, filterString.Length - 4)
                : "";
            gridView.DataSource = table;
        }

        public static void NumericCharactersValidating(ErrorProvider provider, Control control, string controlsName,
            int minNumberOfCharacters)
        {
            bool emptyString = string.IsNullOrEmpty(control.Text);
            if (!emptyString && !StringUtilities.IsNumber(control.Text))
                provider.SetError(control,
                    string.Format("{0} phải là một dãy toàn các chữ số.",
                    controlsName));
            else if (!emptyString && control.Text.Length < minNumberOfCharacters)
                provider.SetError(control,
                    string.Format("{0} phải có ít nhất {1} chữ số.",
                    controlsName, minNumberOfCharacters));
            else
                provider.SetError(control, "");

        }

        public static void CharacterLengthValidating(ErrorProvider provider, Control control, string controlsName,
            int minLength, int maxLength)
        {
            if (string.IsNullOrEmpty(control.Text))
                provider.SetError(control,
                    string.Format("{0} không được để trống.",
                    controlsName));
            else if (control.Text.Length < minLength)
                provider.SetError(control,
                    string.Format("{0} phải có ít nhất {1} ký tự " +
                    "và nhỏ hơn hoặc bằng {2} ký tự.",
                    controlsName, minLength, maxLength));
            else
                provider.SetError(control, "");
        }

        public static void NotifyFailure()
        {
            MessageBox.Show("Thao tác thất bại!", "Thất bại",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
        }

        public static void NotifySuccess()
        {
            MessageBox.Show("Thao tác thành công!", "Thành công", 
                MessageBoxButtons.OK, MessageBoxIcon.Information, 
                MessageBoxDefaultButton.Button1);
        }

        public static bool ConfirmDeletion()
        {
            return (MessageBox.Show("Bạn có chắc chắn muốn xóa?" + Environment.NewLine
                + "Một khi đã xóa thì dữ liệu sẽ không lấy lại được!", "Xóa dữ liệu",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes);
        }
    }
}
