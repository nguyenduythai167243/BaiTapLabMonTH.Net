using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Btaplab9.Database;

namespace Btaplab9.Forms.Guided
{
    /// <summary>
    /// Bài tập hướng dẫn Lab 09 - Công việc 2: Form thông tin mặt hàng (tblMatHang)
    /// </summary>
    public partial class FrmMatHang : Form
    {
        private DataTable dtMHLocal = new DataTable();

        public FrmMatHang()
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

        private void FrmMatHang_Load(object? sender, EventArgs e)
        {
            vohieuhoa(false);
            Dua_DL_listview();
        }

        private void vohieuhoa(bool gt)
        {
            txt_mamh.Enabled = gt;
            txt_tenmh.Enabled = gt;
            txt_dvtinh.Enabled = gt;
        }

        private bool kiemtra(string s)
        {
            return string.IsNullOrWhiteSpace(s);
        }

        private bool kiemtra_du_lieu()
        {
            return !(kiemtra(txt_mamh.Text) || kiemtra(txt_tenmh.Text) || kiemtra(txt_dvtinh.Text));
        }

        private void reset()
        {
            txt_mamh.ResetText();
            txt_tenmh.ResetText();
            txt_dvtinh.ResetText();
        }

        private void Dua_DL_listview()
        {
            listview_mathang.Items.Clear();
            DataTable dt = ketnoi.truyvan("SELECT MaMH, TenMH, DVT FROM tblMatHang", "QLBH");
            DataTable src = (dt.Rows.Count > 0) ? dt : dtMHLocal;

            foreach (DataRow dr in src.Rows)
            {
                ListViewItem item = new ListViewItem(dr["MaMH"].ToString());
                item.SubItems.Add(dr["TenMH"].ToString());
                item.SubItems.Add(dr["DVT"].ToString());
                listview_mathang.Items.Add(item);
            }
        }

        private bool kiemTraMaMathang(string maMH)
        {
            DataTable dt = ketnoi.truyvan($"SELECT MaMH FROM tblMatHang WHERE MaMH = '{maMH}'", "QLBH");
            if (dt.Rows.Count > 0) return true;

            foreach (DataRow r in dtMHLocal.Rows)
            {
                if (r["MaMH"].ToString() == maMH) return true;
            }
            return false;
        }

        private void bt_them_Click(object? sender, EventArgs e)
        {
            if (string.Compare(bt_them.Text, "Thêm", StringComparison.OrdinalIgnoreCase) == 0)
            {
                vohieuhoa(true);
                reset();
                txt_mamh.Focus();
                bt_them.Text = "Lưu";
            }
            else
            {
                if (kiemtra_du_lieu())
                {
                    string ma = txt_mamh.Text.Trim();
                    if (kiemTraMaMathang(ma))
                    {
                        MessageBox.Show("Trùng mã mặt hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_mamh.Focus();
                        return;
                    }

                    string ten = txt_tenmh.Text.Trim();
                    string dvt = txt_dvtinh.Text.Trim();

                    ketnoi.thucthi($"INSERT INTO tblMatHang VALUES(N'{ma}', N'{ten}', N'{dvt}')", "QLBH");
                    dtMHLocal.Rows.Add(ma, ten, dvt);

                    reset();
                    bt_them.Text = "Thêm";
                    vohieuhoa(false);
                    Dua_DL_listview();
                    MessageBox.Show("Thêm mới mặt hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Dữ liệu nhập vào không hợp lệ", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void bt_sua_Click(object? sender, EventArgs e)
        {
            if (string.Compare(bt_sua.Text, "Sửa", StringComparison.OrdinalIgnoreCase) == 0)
            {
                if (listview_mathang.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn mặt hàng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                vohieuhoa(true);
                txt_mamh.Enabled = false;
                txt_tenmh.Focus();
                bt_sua.Text = "Cập nhật";
            }
            else
            {
                if (kiemtra_du_lieu())
                {
                    string ma = txt_mamh.Text.Trim();
                    string ten = txt_tenmh.Text.Trim();
                    string dvt = txt_dvtinh.Text.Trim();

                    ketnoi.thucthi($"UPDATE tblMatHang SET TenMH=N'{ten}', DVT=N'{dvt}' WHERE MaMH=N'{ma}'", "QLBH");

                    foreach (DataRow r in dtMHLocal.Rows)
                    {
                        if (r["MaMH"].ToString() == ma)
                        {
                            r["TenMH"] = ten;
                            r["DVT"] = dvt;
                            break;
                        }
                    }

                    Dua_DL_listview();
                    bt_sua.Text = "Sửa";
                    vohieuhoa(false);
                    reset();
                    MessageBox.Show("Cập nhật mặt hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Dữ liệu sửa không hợp lệ", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void bt_xoa_Click(object? sender, EventArgs e)
        {
            if (listview_mathang.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn phần tử để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string ma = listview_mathang.SelectedItems[0].Text;
                ketnoi.thucthi($"DELETE tblMatHang WHERE MaMH = '{ma}'", "QLBH");

                for (int i = dtMHLocal.Rows.Count - 1; i >= 0; i--)
                {
                    if (dtMHLocal.Rows[i]["MaMH"].ToString() == ma)
                    {
                        dtMHLocal.Rows.RemoveAt(i);
                    }
                }

                Dua_DL_listview();
                reset();
                MessageBox.Show("Đã xóa mặt hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_timkiem_Click(object? sender, EventArgs e)
        {
            new FrmTimkiemMH().ShowDialog(this);
        }

        private void bt_thoat_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void listview_mathang_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (listview_mathang.SelectedItems.Count > 0)
            {
                var item = listview_mathang.SelectedItems[0];
                txt_mamh.Text = item.Text;
                txt_tenmh.Text = item.SubItems[1].Text;
                txt_dvtinh.Text = item.SubItems[2].Text;
            }
        }
    }
}
