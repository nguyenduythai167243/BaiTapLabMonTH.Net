using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Btaplab9.Database;

namespace Btaplab9.Forms.Bai2
{
    /// <summary>
    /// Bài 2 - Công việc 3: Form Môn học (bảng tblMonHoc)
    /// </summary>
    public partial class FormMonHoc : Form
    {
        // Dữ liệu bộ nhớ giả lập khi không kết nối được SQL Server
        private DataTable dtMonHocLocal = new DataTable();
        private DataTable dtKhoaLocal = new DataTable();

        public FormMonHoc()
        {
            InitializeComponent();
            InitLocalData();
        }

        private void InitLocalData()
        {
            dtKhoaLocal.Columns.Add("Makhoa", typeof(string));
            dtKhoaLocal.Columns.Add("Tenkhoa", typeof(string));
            dtKhoaLocal.Rows.Add("K01", "Công nghệ thông tin");
            dtKhoaLocal.Rows.Add("K02", "Kinh tế & Quản trị");
            dtKhoaLocal.Rows.Add("K03", "Điện tử viễn thông");

            dtMonHocLocal.Columns.Add("Mamon", typeof(string));
            dtMonHocLocal.Columns.Add("Tenmon", typeof(string));
            dtMonHocLocal.Columns.Add("Makhoa", typeof(string));
            dtMonHocLocal.Columns.Add("Sohocphan", typeof(int));
            dtMonHocLocal.Columns.Add("Giaovien", typeof(string));

            dtMonHocLocal.Rows.Add("M01", "Lập trình C# .NET", "K01", 3, "ThS. Nguyễn Văn A");
            dtMonHocLocal.Rows.Add("M02", "Cơ sở dữ liệu SQL", "K01", 3, "TS. Lê Thị B");
            dtMonHocLocal.Rows.Add("M03", "Cấu trúc dữ liệu", "K01", 4, "ThS. Trần Văn C");
            dtMonHocLocal.Rows.Add("M04", "Quản trị học", "K02", 3, "PGS. Hoàng Văn D");
        }

        // a) Khi form load: hiển thị ListView, nút Xóa, Sửa và các Textbox, combobox mờ đi (vô hiệu hóa)
        private void FormMonHoc_Load(object? sender, EventArgs e)
        {
            VoHieuHoaControls(false);
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            LoadMaKhoa();
            LoadDataListView();
        }

        private void VoHieuHoaControls(bool enable)
        {
            txtMaMon.Enabled = enable;
            txtTenMon.Enabled = enable;
            cboMaKhoa.Enabled = enable;
            txtSoHocPhan.Enabled = enable;
            txtGiaoVien.Enabled = enable;
        }

        private void ResetInputs()
        {
            txtMaMon.ResetText();
            txtTenMon.ResetText();
            txtSoHocPhan.ResetText();
            txtGiaoVien.ResetText();
        }

        private void LoadMaKhoa()
        {
            cboMaKhoa.Items.Clear();
            DataTable dt = ketnoi.truyvan("SELECT Makhoa FROM tblKhoa", "QLDiem");
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                    cboMaKhoa.Items.Add(r["Makhoa"].ToString()!);
            }
            else
            {
                foreach (DataRow r in dtKhoaLocal.Rows)
                    cboMaKhoa.Items.Add(r["Makhoa"].ToString()!);
            }
            if (cboMaKhoa.Items.Count > 0)
                cboMaKhoa.SelectedIndex = 0;
        }

        private void LoadDataListView()
        {
            lvwMonHoc.Items.Clear();
            DataTable dt = ketnoi.truyvan("SELECT Mamon, Tenmon, Makhoa, Sohocphan, Giaovien FROM tblMonHoc", "QLDiem");
            DataTable src = (dt.Rows.Count > 0) ? dt : dtMonHocLocal;

            foreach (DataRow dr in src.Rows)
            {
                ListViewItem item = new ListViewItem(dr["Mamon"].ToString());
                item.SubItems.Add(dr["Tenmon"].ToString());
                item.SubItems.Add(dr["Makhoa"].ToString());
                item.SubItems.Add(dr["Sohocphan"].ToString());
                item.SubItems.Add(dr["Giaovien"].ToString());
                lvwMonHoc.Items.Add(item);
            }
        }

        // b) Nút Thêm chuyển thành Lưu, controls sáng lên, kiểm tra trùng mã môn học
        private void BtnThem_Click(object? sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                VoHieuHoaControls(true);
                ResetInputs();
                txtMaMon.Focus();
                btnThem.Text = "Lưu";
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
            else // Click vào nút "Lưu"
            {
                string ma = txtMaMon.Text.Trim();
                string ten = txtTenMon.Text.Trim();
                string khoa = cboMaKhoa.Text;
                string gv = txtGiaoVien.Text.Trim();

                if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))
                {
                    MessageBox.Show("Mã môn và tên môn học không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtSoHocPhan.Text.Trim(), out int shp) || shp <= 0)
                {
                    MessageBox.Show("Số học phần phải là số nguyên dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoHocPhan.Focus();
                    return;
                }

                // Kiểm tra trùng mã môn học
                DataTable dtCheck = ketnoi.truyvan($"SELECT Mamon FROM tblMonHoc WHERE Mamon = '{ma}'", "QLDiem");
                bool isDup = dtCheck.Rows.Count > 0;
                if (!isDup)
                {
                    foreach (DataRow r in dtMonHocLocal.Rows)
                    {
                        if (r["Mamon"].ToString() == ma) { isDup = true; break; }
                    }
                }

                if (isDup)
                {
                    MessageBox.Show($"Mã môn học '{ma}' đã tồn tại! Vui lòng chọn mã khác.", "Trùng mã môn học", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaMon.Focus();
                    return;
                }

                // Lưu vào CSDL
                string sql = $"INSERT INTO tblMonHoc (Mamon, Tenmon, Makhoa, Sohocphan, Giaovien) VALUES (N'{ma}', N'{ten}', N'{khoa}', {shp}, N'{gv}')";
                ketnoi.thucthi(sql, "QLDiem");

                dtMonHocLocal.Rows.Add(ma, ten, khoa, shp, gv);

                LoadDataListView();
                btnThem.Text = "Thêm";
                VoHieuHoaControls(false);
                ResetInputs();
                MessageBox.Show("Lưu môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // c, d) Khi click vào ListView thì nút Xóa và Sửa sẽ sáng lên
        private void LvwMonHoc_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (lvwMonHoc.SelectedItems.Count > 0)
            {
                var item = lvwMonHoc.SelectedItems[0];
                txtMaMon.Text = item.Text;
                txtTenMon.Text = item.SubItems[1].Text;
                cboMaKhoa.Text = item.SubItems[2].Text;
                txtSoHocPhan.Text = item.SubItems[3].Text;
                txtGiaoVien.Text = item.SubItems[4].Text;

                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                VoHieuHoaControls(true);
                txtMaMon.Enabled = false; // Không cho sửa khóa chính
            }
        }

        // c) Nút Xóa
        private void BtnXoa_Click(object? sender, EventArgs e)
        {
            if (lvwMonHoc.SelectedItems.Count == 0) return;

            string ma = lvwMonHoc.SelectedItems[0].Text;
            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa môn học '{ma}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ketnoi.thucthi($"DELETE FROM tblMonHoc WHERE Mamon = N'{ma}'", "QLDiem");

                for (int i = dtMonHocLocal.Rows.Count - 1; i >= 0; i--)
                {
                    if (dtMonHocLocal.Rows[i]["Mamon"].ToString() == ma)
                    {
                        dtMonHocLocal.Rows.RemoveAt(i);
                    }
                }

                LoadDataListView();
                VoHieuHoaControls(false);
                ResetInputs();
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                MessageBox.Show("Đã xóa môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // d) Nút Sửa
        private void BtnSua_Click(object? sender, EventArgs e)
        {
            if (lvwMonHoc.SelectedItems.Count == 0) return;

            string ma = txtMaMon.Text;
            string ten = txtTenMon.Text.Trim();
            string khoa = cboMaKhoa.Text;
            string gv = txtGiaoVien.Text.Trim();

            if (!int.TryParse(txtSoHocPhan.Text.Trim(), out int shp) || shp <= 0)
            {
                MessageBox.Show("Số học phần không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = $"UPDATE tblMonHoc SET Tenmon = N'{ten}', Makhoa = N'{khoa}', Sohocphan = {shp}, Giaovien = N'{gv}' WHERE Mamon = N'{ma}'";
            ketnoi.thucthi(sql, "QLDiem");

            foreach (DataRow r in dtMonHocLocal.Rows)
            {
                if (r["Mamon"].ToString() == ma)
                {
                    r["Tenmon"] = ten;
                    r["Makhoa"] = khoa;
                    r["Sohocphan"] = shp;
                    r["Giaovien"] = gv;
                    break;
                }
            }

            LoadDataListView();
            VoHieuHoaControls(false);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            MessageBox.Show("Cập nhật thông tin môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
