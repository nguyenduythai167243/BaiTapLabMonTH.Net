using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Btaplab9.Database;

namespace Btaplab9.Forms.Guided
{
    /// <summary>
    /// Bài tập hướng dẫn Lab 09 - Công việc 4a: Form Tìm kiếm thông tin khách hàng (tblKhachHang)
    /// </summary>
    public partial class FrmTimkiemKH : Form
    {
        private DataTable dtKHLocal = new DataTable();

        public FrmTimkiemKH()
        {
            InitializeComponent();
            InitLocalData();
        }

        private void InitLocalData()
        {
            dtKHLocal.Columns.Add("MaKH", typeof(string));
            dtKHLocal.Columns.Add("Hoten", typeof(string));
            dtKHLocal.Columns.Add("Gioitinh", typeof(string));
            dtKHLocal.Columns.Add("Diachi", typeof(string));
            dtKHLocal.Columns.Add("Dienthoai", typeof(string));

            dtKHLocal.Rows.Add("KH01", "Bùi Thị Thảo", "Nữ", "NĐ", "0912832749");
            dtKHLocal.Rows.Add("KH02", "Nguyễn Văn Toàn", "Nam", "NĐ", "0909092883");
            dtKHLocal.Rows.Add("KH03", "Trần Anh Tuấn", "Nam", "Hà Nội", "0988776655");
        }

        private void bt_tim_Click(object? sender, EventArgs e)
        {
            string keyword = txt_noidungTK.Text.Trim();
            string sql = "SELECT MaKH, Hoten, Gioitinh, Diachi, Dienthoai FROM tblKhachHang WHERE 1=1";

            if (radio_makh.Checked)
                sql += $" AND MaKH = '{keyword}'";
            else if (radio_tenkh.Checked)
                sql += $" AND Hoten LIKE N'%{keyword}%'";
            else
                sql += $" AND Dienthoai LIKE '%{keyword}%'";

            DataTable dt = ketnoi.truyvan(sql, "QLBH");

            DataTable res = (dt.Rows.Count > 0) ? dt : FilterLocalData(keyword);

            listview_kqtimkiem.Items.Clear();
            if (res.Rows.Count == 0)
            {
                MessageBox.Show("Tìm kiếm không thấy", "Thông báo tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (DataRow dr in res.Rows)
            {
                ListViewItem item = new ListViewItem(dr["MaKH"].ToString());
                item.SubItems.Add(dr["Hoten"].ToString());
                item.SubItems.Add(dr["Gioitinh"].ToString());
                item.SubItems.Add(dr["Diachi"].ToString());
                item.SubItems.Add(dr["Dienthoai"].ToString());
                listview_kqtimkiem.Items.Add(item);
            }
        }

        private DataTable FilterLocalData(string keyword)
        {
            DataTable res = dtKHLocal.Clone();
            foreach (DataRow r in dtKHLocal.Rows)
            {
                string ma = r["MaKH"].ToString()!;
                string ten = r["Hoten"].ToString()!;
                string dt = r["Dienthoai"].ToString()!;

                bool match = false;
                if (radio_makh.Checked && ma.Equals(keyword, StringComparison.OrdinalIgnoreCase)) match = true;
                else if (radio_tenkh.Checked && ten.Contains(keyword, StringComparison.OrdinalIgnoreCase)) match = true;
                else if (radio_sodt.Checked && dt.Contains(keyword, StringComparison.OrdinalIgnoreCase)) match = true;
                else if (!radio_makh.Checked && !radio_tenkh.Checked && !radio_sodt.Checked) match = true;

                if (match) res.ImportRow(r);
            }
            return res;
        }

        private void bt_thoat_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
