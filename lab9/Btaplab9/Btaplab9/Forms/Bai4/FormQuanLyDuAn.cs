using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Btaplab9.Database;

namespace Btaplab9.Forms.Bai4
{
    /// <summary>
    /// Bài 4 - Công việc 2: Form Quản lý Dự án (Bảng DUAN trong CSDL QLDA)
    /// </summary>
    public partial class FormQuanLyDuAn : Form
    {
        private DataTable dtDuAnLocal = new DataTable();
        private bool isEditing = false;

        public FormQuanLyDuAn()
        {
            InitializeComponent();
            InitLocalData();
        }

        private void InitLocalData()
        {
            dtDuAnLocal.Columns.Add("Mada", typeof(string));
            dtDuAnLocal.Columns.Add("Tenda", typeof(string));
            dtDuAnLocal.Columns.Add("Congviecda", typeof(string));
            dtDuAnLocal.Columns.Add("Songayda", typeof(int));

            dtDuAnLocal.Rows.Add("DA01", "Xây dựng Cổng thông tin Viện CNTT", "Phân tích, thiết kế hệ thống web portal", 120);
            dtDuAnLocal.Rows.Add("DA02", "Phần mềm Quản lý Kho bãi", "Lập trình module nhập xuất kho", 90);
            dtDuAnLocal.Rows.Add("DA03", "Số hóa Hồ sơ Lưu trữ", "Scan và nhận dạng OCR chứng từ", 60);
            dtDuAnLocal.Rows.Add("DA04", "Hệ thống AI Điểm danh sinh viên", "Huấn luyện mô hình nhận diện khuôn mặt", 180);
        }

        private void FormQuanLyDuAn_Load(object? sender, EventArgs e)
        {
            LoadData();
            EnableInputs(false);
            btnLuu.Enabled = false;
        }

        private void LoadData()
        {
            DataTable dt = ketnoi.truyvan("SELECT Mada, Tenda, Congviecda, Songayda FROM DUAN", "QLDA");
            if (dt.Rows.Count > 0)
            {
                dgvDuAn.DataSource = dt;
            }
            else
            {
                dgvDuAn.DataSource = dtDuAnLocal;
            }
        }

        private void EnableInputs(bool enable)
        {
            txtMaDA.Enabled = enable;
            txtTenDA.Enabled = enable;
            txtCongViecDA.Enabled = enable;
            txtSoNgayDA.Enabled = enable;
        }

        private void ClearInputs()
        {
            txtMaDA.ResetText();
            txtTenDA.ResetText();
            txtCongViecDA.ResetText();
            txtSoNgayDA.ResetText();
        }

        private void DgvDuAn_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDuAn.Rows[e.RowIndex].Cells["Mada"].Value != null)
            {
                var r = dgvDuAn.Rows[e.RowIndex];
                txtMaDA.Text = r.Cells["Mada"].Value.ToString();
                txtTenDA.Text = r.Cells["Tenda"].Value.ToString();
                txtCongViecDA.Text = r.Cells["Congviecda"].Value.ToString();
                txtSoNgayDA.Text = r.Cells["Songayda"].Value.ToString();
            }
        }

        private void BtnThem_Click(object? sender, EventArgs e)
        {
            isEditing = false;
            EnableInputs(true);
            ClearInputs();
            txtMaDA.Focus();
            btnLuu.Enabled = true;
        }

        private void BtnSua_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDA.Text))
            {
                MessageBox.Show("Vui lòng chọn dự án cần sửa trên lưới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isEditing = true;
            EnableInputs(true);
            txtMaDA.Enabled = false; // Không sửa khóa chính
            txtTenDA.Focus();
            btnLuu.Enabled = true;
        }

        private void BtnLuu_Click(object? sender, EventArgs e)
        {
            string ma = txtMaDA.Text.Trim();
            string ten = txtTenDA.Text.Trim();
            string cv = txtCongViecDA.Text.Trim();

            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Mã dự án và tên dự án không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtSoNgayDA.Text.Trim(), out int songay) || songay <= 0)
            {
                MessageBox.Show("Số ngày làm dự án phải là số nguyên dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoNgayDA.Focus();
                return;
            }

            if (!isEditing)
            {
                // Kiểm tra trùng mã
                DataTable dtCheck = ketnoi.truyvan($"SELECT Mada FROM DUAN WHERE Mada = '{ma}'", "QLDA");
                bool exists = dtCheck.Rows.Count > 0;
                if (!exists)
                {
                    foreach (DataRow r in dtDuAnLocal.Rows)
                    {
                        if (r["Mada"].ToString() == ma) { exists = true; break; }
                    }
                }

                if (exists)
                {
                    MessageBox.Show($"Mã dự án '{ma}' đã tồn tại!", "Trùng mã dự án", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaDA.Focus();
                    return;
                }

                // Thêm mới
                string sql = $"INSERT INTO DUAN (Mada, Tenda, Congviecda, Songayda) VALUES (N'{ma}', N'{ten}', N'{cv}', {songay})";
                ketnoi.thucthi(sql, "QLDA");
                dtDuAnLocal.Rows.Add(ma, ten, cv, songay);
                MessageBox.Show("Thêm mới dự án thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Cập nhật
                string sql = $"UPDATE DUAN SET Tenda = N'{ten}', Congviecda = N'{cv}', Songayda = {songay} WHERE Mada = N'{ma}'";
                ketnoi.thucthi(sql, "QLDA");

                foreach (DataRow r in dtDuAnLocal.Rows)
                {
                    if (r["Mada"].ToString() == ma)
                    {
                        r["Tenda"] = ten;
                        r["Congviecda"] = cv;
                        r["Songayda"] = songay;
                        break;
                    }
                }
                MessageBox.Show("Cập nhật dự án thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadData();
            EnableInputs(false);
            btnLuu.Enabled = false;
        }

        private void BtnXoa_Click(object? sender, EventArgs e)
        {
            if (dgvDuAn.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng dự án cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ma = dgvDuAn.SelectedRows[0].Cells["Mada"].Value?.ToString()!;
            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa dự án '{ma}'?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ketnoi.thucthi($"DELETE FROM DUAN WHERE Mada = N'{ma}'", "QLDA");

                for (int i = dtDuAnLocal.Rows.Count - 1; i >= 0; i--)
                {
                    if (dtDuAnLocal.Rows[i]["Mada"].ToString() == ma)
                    {
                        dtDuAnLocal.Rows.RemoveAt(i);
                    }
                }

                LoadData();
                ClearInputs();
                MessageBox.Show("Đã xóa dự án thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnThoat_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát Form Quản lý dự án không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
