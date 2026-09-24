using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Btaplab9.Database;

namespace Btaplab9.Forms.Bai3
{
    /// <summary>
    /// Bài 3 - Công việc 2: Form Mua hàng trong CSDL QLKD
    /// Lưới hiển thị dữ liệu và các nút: Thêm, Sửa, Lưu, Xóa, Thoát
    /// </summary>
    public partial class FormMuaHang : Form
    {
        private DataTable dtMuaHangLocal = new DataTable();
        private bool isEditing = false;

        public FormMuaHang()
        {
            InitializeComponent();
            InitLocalData();
        }

        private void InitLocalData()
        {
            dtMuaHangLocal.Columns.Add("SoHD", typeof(string));
            dtMuaHangLocal.Columns.Add("Ngaymua", typeof(string));
            dtMuaHangLocal.Columns.Add("Mancc", typeof(string));
            dtMuaHangLocal.Columns.Add("Mahang", typeof(string));
            dtMuaHangLocal.Columns.Add("Soluongmua", typeof(int));
            dtMuaHangLocal.Columns.Add("Dongiamua", typeof(double));
            dtMuaHangLocal.Columns.Add("ThanhTien", typeof(double));

            dtMuaHangLocal.Rows.Add("HDM01", "10/08/2023", "NCC01", "H01", 10, 12000000, 120000000);
            dtMuaHangLocal.Rows.Add("HDM02", "15/08/2023", "NCC02", "H02", 15, 8500000, 127500000);
            dtMuaHangLocal.Rows.Add("HDM03", "01/09/2023", "NCC03", "H03", 20, 7200000, 144000000);
        }

        private void FormMuaHang_Load(object? sender, EventArgs e)
        {
            LoadCombos();
            LoadDataGrid();
            EnableControls(false);
        }

        private void LoadCombos()
        {
            cboNhaCungCap.Items.Clear();
            cboHangHoa.Items.Clear();

            DataTable dtNCC = ketnoi.truyvan("SELECT Mancc FROM NCC", "QLKD");
            if (dtNCC.Rows.Count > 0)
            {
                foreach (DataRow r in dtNCC.Rows) cboNhaCungCap.Items.Add(r["Mancc"].ToString()!);
            }
            else
            {
                cboNhaCungCap.Items.AddRange(new object[] { "NCC01", "NCC02", "NCC03" });
            }

            DataTable dtH = ketnoi.truyvan("SELECT Mahang FROM HANG", "QLKD");
            if (dtH.Rows.Count > 0)
            {
                foreach (DataRow r in dtH.Rows) cboHangHoa.Items.Add(r["Mahang"].ToString()!);
            }
            else
            {
                cboHangHoa.Items.AddRange(new object[] { "H01", "H02", "H03", "H04" });
            }

            if (cboNhaCungCap.Items.Count > 0) cboNhaCungCap.SelectedIndex = 0;
            if (cboHangHoa.Items.Count > 0) cboHangHoa.SelectedIndex = 0;
        }

        private void EnableControls(bool enable)
        {
            txtSoHD.Enabled = enable;
            dtpNgayMua.Enabled = enable;
            cboNhaCungCap.Enabled = enable;
            cboHangHoa.Enabled = enable;
            txtSoLuong.Enabled = enable;
            txtDonGia.Enabled = enable;
        }

        private void LoadDataGrid()
        {
            string sql = @"SELECT h.SoHD, CONVERT(VARCHAR, h.Ngaymua, 103) AS Ngaymua, h.Mancc, c.Mahang, c.Soluongmua, c.Dongiamua, (c.Soluongmua * c.Dongiamua) AS ThanhTien
                           FROM HDMUA h
                           JOIN CHITIETMUA c ON h.SoHD = c.SoHD";
            DataTable dt = ketnoi.truyvan(sql, "QLKD");
            if (dt.Rows.Count > 0)
            {
                dgvMuaHang.DataSource = dt;
            }
            else
            {
                dgvMuaHang.DataSource = dtMuaHangLocal;
            }
        }

        private void DgvMuaHang_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvMuaHang.Rows[e.RowIndex].Cells["SoHD"].Value != null)
            {
                var r = dgvMuaHang.Rows[e.RowIndex];
                txtSoHD.Text = r.Cells["SoHD"].Value.ToString();
                cboNhaCungCap.Text = r.Cells["Mancc"].Value.ToString();
                cboHangHoa.Text = r.Cells["Mahang"].Value.ToString();
                txtSoLuong.Text = r.Cells["Soluongmua"].Value.ToString();
                txtDonGia.Text = r.Cells["Dongiamua"].Value.ToString();
                if (DateTime.TryParse(r.Cells["Ngaymua"].Value.ToString(), out DateTime d))
                    dtpNgayMua.Value = d;
            }
        }

        private void BtnThem_Click(object? sender, EventArgs e)
        {
            isEditing = false;
            EnableControls(true);
            txtSoHD.ResetText();
            txtSoLuong.ResetText();
            txtDonGia.ResetText();
            txtSoHD.Focus();
            btnLuu.Enabled = true;
        }

        private void BtnSua_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoHD.Text))
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa trên lưới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isEditing = true;
            EnableControls(true);
            txtSoHD.Enabled = false; // Khóa số HĐ
            btnLuu.Enabled = true;
        }

        private void BtnLuu_Click(object? sender, EventArgs e)
        {
            string shd = txtSoHD.Text.Trim();
            string ncc = cboNhaCungCap.Text;
            string mh = cboHangHoa.Text;

            if (string.IsNullOrEmpty(shd))
            {
                MessageBox.Show("Số hóa đơn không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtSoLuong.Text.Trim(), out int sl) || sl <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtDonGia.Text.Trim(), out double dg) || dg <= 0)
            {
                MessageBox.Show("Đơn giá phải là số dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!isEditing)
            {
                // Thêm mới
                string sqlHD = $"IF NOT EXISTS (SELECT * FROM HDMUA WHERE SoHD = '{shd}') INSERT INTO HDMUA (SoHD, Ngaymua, Mancc) VALUES ('{shd}', '{dtpNgayMua.Value:yyyy-MM-dd}', '{ncc}')";
                ketnoi.thucthi(sqlHD, "QLKD");
                string sqlCT = $"INSERT INTO CHITIETMUA (SoHD, Mahang, Soluongmua, Dongiamua) VALUES ('{shd}', '{mh}', {sl}, {dg})";
                ketnoi.thucthi(sqlCT, "QLKD");

                dtMuaHangLocal.Rows.Add(shd, dtpNgayMua.Value.ToString("dd/MM/yyyy"), ncc, mh, sl, dg, sl * dg);
            }
            else
            {
                // Sửa
                string sql = $"UPDATE CHITIETMUA SET Soluongmua = {sl}, Dongiamua = {dg} WHERE SoHD = '{shd}' AND Mahang = '{mh}'";
                ketnoi.thucthi(sql, "QLKD");

                foreach (DataRow r in dtMuaHangLocal.Rows)
                {
                    if (r["SoHD"].ToString() == shd && r["Mahang"].ToString() == mh)
                    {
                        r["Soluongmua"] = sl;
                        r["Dongiamua"] = dg;
                        r["ThanhTien"] = sl * dg;
                        break;
                    }
                }
            }

            LoadDataGrid();
            EnableControls(false);
            btnLuu.Enabled = false;
            MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnXoa_Click(object? sender, EventArgs e)
        {
            if (dgvMuaHang.SelectedRows.Count == 0) return;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var row = dgvMuaHang.SelectedRows[0];
                string shd = row.Cells["SoHD"].Value.ToString()!;
                string mh = row.Cells["Mahang"].Value.ToString()!;

                ketnoi.thucthi($"DELETE FROM CHITIETMUA WHERE SoHD = '{shd}' AND Mahang = '{mh}'", "QLKD");

                for (int i = dtMuaHangLocal.Rows.Count - 1; i >= 0; i--)
                {
                    if (dtMuaHangLocal.Rows[i]["SoHD"].ToString() == shd && dtMuaHangLocal.Rows[i]["Mahang"].ToString() == mh)
                    {
                        dtMuaHangLocal.Rows.RemoveAt(i);
                    }
                }

                LoadDataGrid();
                MessageBox.Show("Đã xóa bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnThoat_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát Form Mua hàng không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
