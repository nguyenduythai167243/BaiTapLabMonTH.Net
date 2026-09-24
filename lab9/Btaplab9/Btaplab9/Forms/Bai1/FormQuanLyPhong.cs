using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Btaplab9.Database;

namespace Btaplab9.Forms.Bai1
{
    /// <summary>
    /// Bài 1 - Công việc 2: Form quản lý phòng (bảng Phong)
    /// </summary>
    public partial class FormQuanLyPhong : Form
    {
        // CSDL giả lập cục bộ khi không có SQL Server
        private DataTable dtPhongLocal = new DataTable();

        public FormQuanLyPhong()
        {
            InitializeComponent();
            InitLocalData();
        }

        private void InitLocalData()
        {
            dtPhongLocal.Columns.Add("MaPH", typeof(string));
            dtPhongLocal.Columns.Add("LoaiP", typeof(string));
            dtPhongLocal.Columns.Add("HangP", typeof(string));
            dtPhongLocal.Columns.Add("DonGia", typeof(double));
            dtPhongLocal.Columns.Add("TinhTrang", typeof(string));

            dtPhongLocal.Rows.Add("P001", "Phòng đơn", "Thường", 200000, "Có");
            dtPhongLocal.Rows.Add("P002", "Phòng đơn", "Thường", 200000, "Có");
            dtPhongLocal.Rows.Add("P003", "Phòng đơn", "Thường", 200000, "Không");
            dtPhongLocal.Rows.Add("P004", "Phòng đơn", "Sang", 300000, "Không");
            dtPhongLocal.Rows.Add("P005", "Phòng đơn", "Sang", 300000, "Không");
            dtPhongLocal.Rows.Add("P006", "Phòng đơn", "VIP", 400000, "Có");
            dtPhongLocal.Rows.Add("P007", "Phòng đôi", "Thường", 300000, "Có");
        }

        private void FormQuanLyPhong_Load(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = ketnoi.truyvan("SELECT MaPH, LoaiP, HangP, DonGia, TinhTrang FROM Phong", "QLKhachSan");
            if (dt.Rows.Count > 0)
            {
                dgvPhong.DataSource = dt;
            }
            else
            {
                dgvPhong.DataSource = dtPhongLocal;
            }
        }

        private void DgvPhong_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPhong.Rows[e.RowIndex].Cells["MaPH"].Value != null)
            {
                var row = dgvPhong.Rows[e.RowIndex];
                txtMaPhong.Text = row.Cells["MaPH"].Value.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
                cboLoaiPhong.Text = row.Cells["LoaiP"].Value.ToString();
                cboHangPhong.Text = row.Cells["HangP"].Value.ToString();
            }
        }

        private void BtnThem_Click(object? sender, EventArgs e)
        {
            string ma = txtMaPhong.Text.Trim();
            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show("Mã phòng không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhong.Focus();
                return;
            }

            if (!double.TryParse(txtDonGia.Text.Trim(), out double donGia) || donGia <= 0)
            {
                MessageBox.Show("Đơn giá phải là số dương hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            // Kiểm tra trùng mã
            DataTable dtCheck = ketnoi.truyvan($"SELECT MaPH FROM Phong WHERE MaPH = '{ma}'", "QLKhachSan");
            bool exists = dtCheck.Rows.Count > 0;
            if (!exists)
            {
                foreach (DataRow r in dtPhongLocal.Rows)
                {
                    if (r["MaPH"].ToString() == ma) { exists = true; break; }
                }
            }

            if (exists)
            {
                MessageBox.Show("Mã phòng đã tồn tại. Vui lòng nhập mã khác!", "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhong.Focus();
                return;
            }

            // Thêm vào SQL Server
            string sql = $"INSERT INTO Phong (MaPH, LoaiP, HangP, DonGia, TinhTrang) VALUES (N'{ma}', N'{cboLoaiPhong.Text}', N'{cboHangPhong.Text}', {donGia}, N'Không')";
            ketnoi.thucthi(sql, "QLKhachSan");

            // Thêm vào local data
            dtPhongLocal.Rows.Add(ma, cboLoaiPhong.Text, cboHangPhong.Text, donGia, "Không");
            LoadData();
            MessageBox.Show("Thêm phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSua_Click(object? sender, EventArgs e)
        {
            string ma = txtMaPhong.Text.Trim();
            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show("Vui lòng chọn phòng cần sửa từ lưới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtDonGia.Text.Trim(), out double donGia) || donGia <= 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Không cho phép sửa mã phòng
            string sql = $"UPDATE Phong SET LoaiP = N'{cboLoaiPhong.Text}', HangP = N'{cboHangPhong.Text}', DonGia = {donGia} WHERE MaPH = N'{ma}'";
            ketnoi.thucthi(sql, "QLKhachSan");

            foreach (DataRow r in dtPhongLocal.Rows)
            {
                if (r["MaPH"].ToString() == ma)
                {
                    r["LoaiP"] = cboLoaiPhong.Text;
                    r["HangP"] = cboHangPhong.Text;
                    r["DonGia"] = donGia;
                    break;
                }
            }

            LoadData();
            MessageBox.Show("Cập nhật thông tin phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnXoa_Click(object? sender, EventArgs e)
        {
            if (dgvPhong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa các phòng đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvPhong.SelectedRows)
                {
                    if (row.Cells["MaPH"].Value != null)
                    {
                        string ma = row.Cells["MaPH"].Value.ToString()!;
                        ketnoi.thucthi($"DELETE FROM Phong WHERE MaPH = N'{ma}'", "QLKhachSan");

                        for (int i = dtPhongLocal.Rows.Count - 1; i >= 0; i--)
                        {
                            if (dtPhongLocal.Rows[i]["MaPH"].ToString() == ma)
                            {
                                dtPhongLocal.Rows.RemoveAt(i);
                            }
                        }
                    }
                }

                LoadData();
                MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnThoat_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát Form Quản lý phòng không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
