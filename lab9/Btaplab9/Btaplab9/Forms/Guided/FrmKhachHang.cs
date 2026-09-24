using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Btaplab9.Database;

namespace Btaplab9.Forms.Guided
{
    /// <summary>
    /// Bài tập hướng dẫn Lab 09 - Công việc 1: Form thông tin khách hàng (tblKhachHang)
    /// </summary>
    public partial class FrmKhachHang : Form
    {
        private DataTable dtKHLocal = new DataTable();

        public FrmKhachHang()
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

        private void FrmKhachHang_Load(object? sender, EventArgs e)
        {
            vohieuhoa(false);
            Dua_DL_listview();
        }

        private void vohieuhoa(bool gt)
        {
            txt_makh.Enabled = gt;
            txt_hoten.Enabled = gt;
            combo_gioitinh.Enabled = gt;
            txt_diachi.Enabled = gt;
            txt_dienthoai.Enabled = gt;
        }

        private bool kiemtra(string s)
        {
            return string.IsNullOrWhiteSpace(s);
        }

        private bool kiemtra_du_lieu()
        {
            if (kiemtra(txt_makh.Text) || kiemtra(txt_hoten.Text) || kiemtra(combo_gioitinh.Text) ||
                kiemtra(txt_diachi.Text) || kiemtra(txt_dienthoai.Text))
                return false;

            string dt = txt_dienthoai.Text.Trim();
            if (dt.Length < 9 || dt.Length > 11) return false;
            foreach (char c in dt)
            {
                if (!char.IsDigit(c)) return false;
            }
            return true;
        }

        private void reset()
        {
            txt_makh.ResetText();
            txt_hoten.ResetText();
            combo_gioitinh.SelectedIndex = 0;
            txt_diachi.ResetText();
            txt_dienthoai.ResetText();
        }

        private void Dua_DL_listview()
        {
            listview_khachhang.Items.Clear();
            DataTable dt = ketnoi.truyvan("SELECT MaKH, Hoten, Gioitinh, Diachi, Dienthoai FROM tblKhachHang", "QLBH");
            DataTable src = (dt.Rows.Count > 0) ? dt : dtKHLocal;

            foreach (DataRow dr in src.Rows)
            {
                ListViewItem item = new ListViewItem(dr["MaKH"].ToString());
                item.SubItems.Add(dr["Hoten"].ToString());
                item.SubItems.Add(dr["Gioitinh"].ToString());
                item.SubItems.Add(dr["Diachi"].ToString());
                item.SubItems.Add(dr["Dienthoai"].ToString());
                listview_khachhang.Items.Add(item);
            }
        }

        private bool kiemTraMaKhachhang(string maKH)
        {
            DataTable dt = ketnoi.truyvan($"SELECT MaKH FROM tblKhachHang WHERE MaKH = '{maKH}'", "QLBH");
            if (dt.Rows.Count > 0) return true;

            foreach (DataRow r in dtKHLocal.Rows)
            {
                if (r["MaKH"].ToString() == maKH) return true;
            }
            return false;
        }

        private void bt_them_Click(object? sender, EventArgs e)
        {
            if (string.Compare(bt_them.Text, "Thêm", StringComparison.OrdinalIgnoreCase) == 0)
            {
                vohieuhoa(true);
                reset();
                txt_makh.Focus();
                bt_them.Text = "Lưu";
            }
            else
            {
                if (kiemtra_du_lieu())
                {
                    string ma = txt_makh.Text.Trim();
                    if (kiemTraMaKhachhang(ma))
                    {
                        MessageBox.Show("Trùng mã khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_makh.Focus();
                        return;
                    }

                    string ten = txt_hoten.Text.Trim();
                    string gt = combo_gioitinh.Text;
                    string dc = txt_diachi.Text.Trim();
                    string dt = txt_dienthoai.Text.Trim();

                    ketnoi.thucthi($"INSERT INTO tblKhachHang VALUES(N'{ma}', N'{ten}', N'{gt}', N'{dc}', N'{dt}')", "QLBH");
                    dtKHLocal.Rows.Add(ma, ten, gt, dc, dt);

                    reset();
                    bt_them.Text = "Thêm";
                    vohieuhoa(false);
                    Dua_DL_listview();
                    MessageBox.Show("Thêm mới khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Dữ liệu nhập vào không hợp lệ!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void bt_sua_Click(object? sender, EventArgs e)
        {
            if (string.Compare(bt_sua.Text, "Sửa", StringComparison.OrdinalIgnoreCase) == 0)
            {
                if (listview_khachhang.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần sửa trên danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                vohieuhoa(true);
                txt_makh.Enabled = false;
                txt_hoten.Focus();
                bt_sua.Text = "Cập nhật";
            }
            else
            {
                if (kiemtra_du_lieu())
                {
                    string ma = txt_makh.Text.Trim();
                    string ten = txt_hoten.Text.Trim();
                    string gt = combo_gioitinh.Text;
                    string dc = txt_diachi.Text.Trim();
                    string dt = txt_dienthoai.Text.Trim();

                    ketnoi.thucthi($"UPDATE tblKhachHang SET Hoten=N'{ten}', Gioitinh=N'{gt}', Diachi=N'{dc}', Dienthoai=N'{dt}' WHERE MaKH=N'{ma}'", "QLBH");

                    foreach (DataRow r in dtKHLocal.Rows)
                    {
                        if (r["MaKH"].ToString() == ma)
                        {
                            r["Hoten"] = ten;
                            r["Gioitinh"] = gt;
                            r["Diachi"] = dc;
                            r["Dienthoai"] = dt;
                            break;
                        }
                    }

                    Dua_DL_listview();
                    bt_sua.Text = "Sửa";
                    vohieuhoa(false);
                    reset();
                    MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Dữ liệu sửa không hợp lệ!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void bt_xoa_Click(object? sender, EventArgs e)
        {
            if (listview_khachhang.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn phần tử để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string ma = listview_khachhang.SelectedItems[0].Text;
                ketnoi.thucthi($"DELETE tblKhachHang WHERE MaKH = '{ma}'", "QLBH");

                for (int i = dtKHLocal.Rows.Count - 1; i >= 0; i--)
                {
                    if (dtKHLocal.Rows[i]["MaKH"].ToString() == ma)
                    {
                        dtKHLocal.Rows.RemoveAt(i);
                    }
                }

                Dua_DL_listview();
                reset();
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_timkiem_Click(object? sender, EventArgs e)
        {
            new FrmTimkiemKH().ShowDialog(this);
        }

        private void bt_thoat_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void listview_khachhang_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (listview_khachhang.SelectedItems.Count > 0)
            {
                var item = listview_khachhang.SelectedItems[0];
                txt_makh.Text = item.Text;
                txt_hoten.Text = item.SubItems[1].Text;
                combo_gioitinh.Text = item.SubItems[2].Text;
                txt_diachi.Text = item.SubItems[3].Text;
                txt_dienthoai.Text = item.SubItems[4].Text;
            }
        }
    }
}
