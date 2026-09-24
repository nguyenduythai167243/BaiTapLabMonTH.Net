using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Btaplab9.Database;

namespace Btaplab9.Forms.Bai1
{
    /// <summary>
    /// Bài 1 - Công việc 3: Form Quản lý khách thuê phòng
    /// </summary>
    public partial class FormKhachThuePhong : Form
    {
        // Dữ liệu bộ nhớ cục bộ mô phỏng
        private DataTable dtPhongLocal = new DataTable();
        private DataTable dtKHLocal = new DataTable();
        private DataTable dtThuePLocal = new DataTable();

        public FormKhachThuePhong()
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

            dtKHLocal.Columns.Add("SoCMT", typeof(string));
            dtKHLocal.Columns.Add("Hoten", typeof(string));
            dtKHLocal.Columns.Add("Gioitinh", typeof(string));

            dtKHLocal.Rows.Add("162626524", "Đinh Gia Trường", "Nam");
            dtKHLocal.Rows.Add("162707094", "Bùi Thị Thảo", "Nữ");
            dtKHLocal.Rows.Add("162707095", "Đinh Gia Minh", "Nam");
            dtKHLocal.Rows.Add("162709945", "Nguyễn Thị Thu", "Nữ");

            dtThuePLocal.Columns.Add("SoCMT", typeof(string));
            dtThuePLocal.Columns.Add("Hoten", typeof(string));
            dtThuePLocal.Columns.Add("Gioitinh", typeof(string));
            dtThuePLocal.Columns.Add("MaPH", typeof(string));
            dtThuePLocal.Columns.Add("NgayDen", typeof(string));

            dtThuePLocal.Rows.Add("162626524", "Đinh Gia Trường", "Nam", "P007", "21/10/2023");
            dtThuePLocal.Rows.Add("162707094", "Bùi Thị Thảo", "Nữ", "P001", "21/10/2023");
            dtThuePLocal.Rows.Add("162707095", "Đinh Gia Minh", "Nam", "P002", "21/10/2023");
            dtThuePLocal.Rows.Add("162709945", "Nguyễn Thị Thu", "Nữ", "P006", "21/10/2023");
        }

        private void FormKhachThuePhong_Load(object? sender, EventArgs e)
        {
            LoadKhachThueChuaThanhToan();
            LoadPhongTrongVaoCombo();
            BtnXemTinhTrang_Click(null, EventArgs.Empty);
        }

        private void LoadKhachThueChuaThanhToan()
        {
            string sql = @"SELECT t.SoCMT, k.Hoten, k.Gioitinh, t.MaPH, CONVERT(VARCHAR, t.NgayDen, 103) AS NgayDen 
                           FROM ThueP t 
                           JOIN KH k ON t.SoCMT = k.SoCMT 
                           WHERE t.NgayDi IS NULL";
            DataTable dt = ketnoi.truyvan(sql, "QLKhachSan");
            if (dt.Rows.Count > 0)
            {
                dgvChiTietKH.DataSource = dt;
            }
            else
            {
                dgvChiTietKH.DataSource = dtThuePLocal;
            }
        }

        private void LoadPhongTrongVaoCombo()
        {
            cboMaPhong.Items.Clear();
            string sql = "SELECT MaPH FROM Phong WHERE TinhTrang = N'Không'";
            DataTable dt = ketnoi.truyvan(sql, "QLKhachSan");
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    cboMaPhong.Items.Add(r["MaPH"].ToString()!);
                }
            }
            else
            {
                foreach (DataRow r in dtPhongLocal.Rows)
                {
                    if (r["TinhTrang"].ToString() == "Không")
                    {
                        cboMaPhong.Items.Add(r["MaPH"].ToString()!);
                    }
                }
            }

            if (cboMaPhong.Items.Count > 0)
                cboMaPhong.SelectedIndex = 0;
        }

        private void BtnXemTinhTrang_Click(object? sender, EventArgs e)
        {
            string tt = cboTinhTrang.Text;
            string sql = $"SELECT MaPH, LoaiP, HangP, DonGia, TinhTrang FROM Phong WHERE TinhTrang = N'{tt}'";
            DataTable dt = ketnoi.truyvan(sql, "QLKhachSan");
            if (dt.Rows.Count > 0)
            {
                dgvChiTietPhong.DataSource = dt;
            }
            else
            {
                DataView dv = new DataView(dtPhongLocal);
                dv.RowFilter = $"TinhTrang = '{tt}'";
                dgvChiTietPhong.DataSource = dv;
            }
        }

        private void BtnXemLoaiPhong_Click(object? sender, EventArgs e)
        {
            string lp = cboLoaiPhong.Text;
            string sql = $"SELECT MaPH, LoaiP, HangP, DonGia, TinhTrang FROM Phong WHERE LoaiP = N'{lp}'";
            DataTable dt = ketnoi.truyvan(sql, "QLKhachSan");
            if (dt.Rows.Count > 0)
            {
                dgvChiTietPhong.DataSource = dt;
            }
            else
            {
                DataView dv = new DataView(dtPhongLocal);
                dv.RowFilter = $"LoaiP = '{lp}'";
                dgvChiTietPhong.DataSource = dv;
            }
        }

        private void DgvChiTietKH_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvChiTietKH.Rows[e.RowIndex].Cells["SoCMT"].Value != null)
            {
                var r = dgvChiTietKH.Rows[e.RowIndex];
                txtSoCMT.Text = r.Cells["SoCMT"].Value.ToString();
                txtHoTen.Text = r.Cells["Hoten"].Value.ToString();
                cboGioiTinh.Text = r.Cells["Gioitinh"].Value.ToString();
                string maP = r.Cells["MaPH"].Value.ToString()!;
                if (!cboMaPhong.Items.Contains(maP))
                    cboMaPhong.Items.Add(maP);
                cboMaPhong.Text = maP;
            }
        }

        private void BtnNhap_Click(object? sender, EventArgs e)
        {
            string cmt = txtSoCMT.Text.Trim();
            string ten = txtHoTen.Text.Trim();
            string gt = cboGioiTinh.Text;
            string maP = cboMaPhong.Text;

            if (string.IsNullOrEmpty(cmt) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(maP))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Số CMT, Họ tên và chọn Mã phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thêm KH nếu chưa tồn tại
            string sqlKH = $"IF NOT EXISTS (SELECT * FROM KH WHERE SoCMT = N'{cmt}') INSERT INTO KH (SoCMT, Hoten, Gioitinh) VALUES (N'{cmt}', N'{ten}', N'{gt}')";
            ketnoi.thucthi(sqlKH, "QLKhachSan");

            // Thêm ThueP
            string sqlThue = $"INSERT INTO ThueP (SoCMT, MaPH, NgayDen, NgayDi, TienSDDV) VALUES (N'{cmt}', N'{maP}', GETDATE(), NULL, 0)";
            ketnoi.thucthi(sqlThue, "QLKhachSan");

            // Cập nhật tình trạng phòng thành 'Có'
            string sqlPhong = $"UPDATE Phong SET TinhTrang = N'Có' WHERE MaPH = N'{maP}'";
            ketnoi.thucthi(sqlPhong, "QLKhachSan");

            // Cập nhật dữ liệu cục bộ
            dtThuePLocal.Rows.Add(cmt, ten, gt, maP, DateTime.Now.ToString("dd/MM/yyyy"));
            foreach (DataRow r in dtPhongLocal.Rows)
            {
                if (r["MaPH"].ToString() == maP)
                {
                    r["TinhTrang"] = "Có";
                    break;
                }
            }

            LoadKhachThueChuaThanhToan();
            LoadPhongTrongVaoCombo();
            BtnXemTinhTrang_Click(null, EventArgs.Empty);

            MessageBox.Show("Nhập thông tin thuê phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSua_Click(object? sender, EventArgs e)
        {
            string cmt = txtSoCMT.Text.Trim();
            string ten = txtHoTen.Text.Trim();
            string gt = cboGioiTinh.Text;

            if (string.IsNullOrEmpty(cmt))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa trên lưới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = $"UPDATE KH SET Hoten = N'{ten}', Gioitinh = N'{gt}' WHERE SoCMT = N'{cmt}'";
            ketnoi.thucthi(sql, "QLKhachSan");

            foreach (DataRow r in dtThuePLocal.Rows)
            {
                if (r["SoCMT"].ToString() == cmt)
                {
                    r["Hoten"] = ten;
                    r["Gioitinh"] = gt;
                }
            }

            LoadKhachThueChuaThanhToan();
            MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnXoa_Click(object? sender, EventArgs e)
        {
            if (dgvChiTietKH.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khách thuê phòng cần xóa trên lưới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin thuê phòng đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvChiTietKH.SelectedRows)
                {
                    if (row.Cells["SoCMT"].Value != null && row.Cells["MaPH"].Value != null)
                    {
                        string cmt = row.Cells["SoCMT"].Value.ToString()!;
                        string maP = row.Cells["MaPH"].Value.ToString()!;

                        // Xóa thuê phòng
                        ketnoi.thucthi($"DELETE FROM ThueP WHERE SoCMT = N'{cmt}' AND MaPH = N'{maP}'", "QLKhachSan");
                        // Cập nhật tình trạng phòng về 'Không'
                        ketnoi.thucthi($"UPDATE Phong SET TinhTrang = N'Không' WHERE MaPH = N'{maP}'", "QLKhachSan");

                        for (int i = dtThuePLocal.Rows.Count - 1; i >= 0; i--)
                        {
                            if (dtThuePLocal.Rows[i]["SoCMT"].ToString() == cmt && dtThuePLocal.Rows[i]["MaPH"].ToString() == maP)
                            {
                                dtThuePLocal.Rows.RemoveAt(i);
                            }
                        }

                        foreach (DataRow r in dtPhongLocal.Rows)
                        {
                            if (r["MaPH"].ToString() == maP)
                            {
                                r["TinhTrang"] = "Không";
                                break;
                            }
                        }
                    }
                }

                LoadKhachThueChuaThanhToan();
                LoadPhongTrongVaoCombo();
                BtnXemTinhTrang_Click(null, EventArgs.Empty);

                MessageBox.Show("Đã xóa thông tin thuê phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnThoat_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát Form Quản lý khách thuê phòng không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
