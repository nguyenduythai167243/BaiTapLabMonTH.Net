using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Btaplab9.Database;

namespace Btaplab9.Forms.Guided
{
    /// <summary>
    /// Bài tập hướng dẫn Lab 09 - Công việc 4b: Form Tìm kiếm thông tin mặt hàng (tblMatHang)
    /// </summary>
    public partial class FrmTimkiemMH : Form
    {
        private DataTable dtMHLocal = new DataTable();

        public FrmTimkiemMH()
        {
            InitializeComponent();
            InitLocalData();
        }

        private void InitLocalData()
        {
            dtMHLocal.Columns.Add("MaMH", typeof(string));
            dtMHLocal.Columns.Add("TenMH", typeof(string));
            dtMHLocal.Columns.Add("DVT", typeof(string));

            dtMHLocal.Rows.Add("MH01", "Tivi Sony Bravia", "Chiếc");
            dtMHLocal.Rows.Add("MH02", "Tủ Lạnh Panasonic", "Chiếc");
            dtMHLocal.Rows.Add("MH03", "Máy Giặt LG", "Chiếc");
        }

        private void bt_tim_Click(object? sender, EventArgs e)
        {
            string keyword = txt_noidungTK.Text.Trim();
            string sql = "SELECT MaMH, TenMH, DVT FROM tblMatHang WHERE 1=1";

            if (radio_mamh.Checked)
                sql += $" AND MaMH = '{keyword}'";
            else
                sql += $" AND TenMH LIKE N'%{keyword}%'";

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
                ListViewItem item = new ListViewItem(dr["MaMH"].ToString());
                item.SubItems.Add(dr["TenMH"].ToString());
                item.SubItems.Add(dr["DVT"].ToString());
                listview_kqtimkiem.Items.Add(item);
            }
        }

        private DataTable FilterLocalData(string keyword)
        {
            DataTable res = dtMHLocal.Clone();
            foreach (DataRow r in dtMHLocal.Rows)
            {
                string ma = r["MaMH"].ToString()!;
                string ten = r["TenMH"].ToString()!;

                bool match = false;
                if (radio_mamh.Checked && ma.Equals(keyword, StringComparison.OrdinalIgnoreCase)) match = true;
                else if (radio_tenmh.Checked && ten.Contains(keyword, StringComparison.OrdinalIgnoreCase)) match = true;
                else if (!radio_mamh.Checked && !radio_tenmh.Checked) match = true;

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
