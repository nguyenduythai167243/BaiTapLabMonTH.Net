using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Btaplab9.Database;

namespace Btaplab9.Forms.Guided
{
    /// <summary>
    /// Bài tập hướng dẫn Lab 09 - Công việc 3: Form Chi tiết bán hàng (tblBanHang, tblChiTietBanHang)
    /// </summary>
    public partial class FrmBanHang : Form
    {
        private DataTable dtBanHangLocal = new DataTable();

        public FrmBanHang()
        {
            InitializeComponent();
            InitLocalData();
        }

        private void InitLocalData()
        {
            dtBanHangLocal.Columns.Add("SoHieuHD", typeof(string));
            dtBanHangLocal.Columns.Add("MaMH", typeof(string));
            dtBanHangLocal.Columns.Add("SoLuong", typeof(int));
            dtBanHangLocal.Columns.Add("DonGia", typeof(double));
            dtBanHangLocal.Columns.Add("ThanhTien", typeof(double));

            dtBanHangLocal.Rows.Add("HD01", "MH01", 2, 12000000, 24000000);
            dtBanHangLocal.Rows.Add("HD01", "MH02", 1, 8500000, 8500000);
            dtBanHangLocal.Rows.Add("HD02", "MH03", 3, 7200000, 21600000);
        }

        private void FrmBanHang_Load(object? sender, EventArgs e)
        {
            vohieuhoa2(false);
            bt_sua.Enabled = false;
            bt_xoa.Enabled = false;
            date_ngaymua.Value = DateTime.Now;
        }

        private void vohieuhoa1(bool gt)
        {
            txt_shd.Enabled = gt;
            txt_makh.Enabled = gt;
            date_ngaymua.Enabled = gt;
        }

        private void vohieuhoa2(bool gt)
        {
            txt_shd.Enabled = gt;
            txt_makh.Enabled = gt;
            date_ngaymua.Enabled = gt;
            txt_mamh.Enabled = gt;
            txt_soluong.Enabled = gt;
            txt_dongia.Enabled = gt;
        }

        private void reset()
        {
            txt_mamh.ResetText();
            txt_soluong.ResetText();
            txt_dongia.ResetText();
        }

        private void Dua_DL_listview(string soHoadon)
        {
            listview_chitietBH.Items.Clear();
            int d = 1;

            string sql = $"SELECT SoHieuHD, MaMH, SoLuong, DonGia, (SoLuong * DonGia) AS ThanhTien FROM tblChiTietBanHang WHERE SoHieuHD = '{soHoadon}'";
            DataTable dt = ketnoi.truyvan(sql, "QLBH");

            DataTable src = (dt.Rows.Count > 0) ? dt : dtBanHangLocal;

            foreach (DataRow dr in src.Rows)
            {
                if (src == dtBanHangLocal && dr["SoHieuHD"].ToString() != soHoadon) continue;

                ListViewItem item = new ListViewItem(d.ToString());
                item.SubItems.Add(dr["MaMH"].ToString());
                item.SubItems.Add(dr["SoLuong"].ToString());
                item.SubItems.Add(dr["DonGia"].ToString());
                item.SubItems.Add(dr["ThanhTien"].ToString());
                listview_chitietBH.Items.Add(item);
                d++;
            }
        }

        private void bt_them_Click(object? sender, EventArgs e)
        {
            if (string.Compare(bt_them.Text, "Thêm", StringComparison.OrdinalIgnoreCase) == 0)
            {
                vohieuhoa2(true);
                bt_sua.Enabled = true;
                bt_xoa.Enabled = true;
                bt_them.Text = "Lưu";
                txt_shd.Focus();
            }
            else
            {
                string shd = txt_shd.Text.Trim();
                string makh = txt_makh.Text.Trim();
                string mamh = txt_mamh.Text.Trim();

                if (string.IsNullOrEmpty(shd) || string.IsNullOrEmpty(mamh))
                {
                    MessageBox.Show("Số hiệu HĐ và Mã mặt hàng không được rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txt_soluong.Text.Trim(), out int sl) || sl <= 0)
                {
                    MessageBox.Show("Số lượng phải là số dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!double.TryParse(txt_dongia.Text.Trim(), out double dg) || dg <= 0)
                {
                    MessageBox.Show("Đơn giá phải là số dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string sqlHD = $"IF NOT EXISTS (SELECT * FROM tblBanHang WHERE SoHieuHD = '{shd}') INSERT INTO tblBanHang VALUES('{shd}', '{makh}', '{date_ngaymua.Value:yyyy-MM-dd}')";
                ketnoi.thucthi(sqlHD, "QLBH");

                string sqlCT = $"INSERT INTO tblChiTietBanHang VALUES('{shd}', '{mamh}', {sl}, {dg})";
                ketnoi.thucthi(sqlCT, "QLBH");

                dtBanHangLocal.Rows.Add(shd, mamh, sl, dg, sl * dg);

                Dua_DL_listview(shd);
                reset();
                bt_them.Text = "Thêm";
                vohieuhoa1(false);
                MessageBox.Show("Lưu chi tiết bán hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_sua_Click(object? sender, EventArgs e)
        {
            if (listview_chitietBH.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn bản ghi cần sửa trên danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string shd = txt_shd.Text.Trim();
            string mamh = txt_mamh.Text.Trim();

            if (!int.TryParse(txt_soluong.Text.Trim(), out int sl) || !double.TryParse(txt_dongia.Text.Trim(), out double dg))
            {
                MessageBox.Show("Dữ liệu sửa không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = $"UPDATE tblChiTietBanHang SET SoLuong={sl}, DonGia={dg} WHERE SoHieuHD='{shd}' AND MaMH='{mamh}'";
            ketnoi.thucthi(sql, "QLBH");

            foreach (DataRow r in dtBanHangLocal.Rows)
            {
                if (r["SoHieuHD"].ToString() == shd && r["MaMH"].ToString() == mamh)
                {
                    r["SoLuong"] = sl;
                    r["DonGia"] = dg;
                    r["ThanhTien"] = sl * dg;
                    break;
                }
            }

            Dua_DL_listview(shd);
            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bt_xoa_Click(object? sender, EventArgs e)
        {
            if (listview_chitietBH.SelectedItems.Count == 0) return;

            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string shd = txt_shd.Text.Trim();
                string mamh = txt_mamh.Text.Trim();

                ketnoi.thucthi($"DELETE tblChiTietBanHang WHERE SoHieuHD='{shd}' AND MaMH='{mamh}'", "QLBH");

                for (int i = dtBanHangLocal.Rows.Count - 1; i >= 0; i--)
                {
                    if (dtBanHangLocal.Rows[i]["SoHieuHD"].ToString() == shd && dtBanHangLocal.Rows[i]["MaMH"].ToString() == mamh)
                    {
                        dtBanHangLocal.Rows.RemoveAt(i);
                    }
                }

                Dua_DL_listview(shd);
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_thoat_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void listview_chitietBH_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (listview_chitietBH.SelectedItems.Count > 0)
            {
                var item = listview_chitietBH.SelectedItems[0];
                txt_mamh.Text = item.SubItems[1].Text;
                txt_soluong.Text = item.SubItems[2].Text;
                txt_dongia.Text = item.SubItems[3].Text;
            }
        }
    }
}
