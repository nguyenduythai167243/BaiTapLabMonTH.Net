using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Btaplab9.Database;

namespace Btaplab9.Forms.Bai2
{
    /// <summary>
    /// Bài 2 - Công việc 4: Form điểm (bảng tblDiem, tblSinhVien, tblMonHoc)
    /// </summary>
    public partial class FormDiem : Form
    {
        // Dữ liệu bộ nhớ cục bộ
        private DataTable dtDiemLocal = new DataTable();

        public FormDiem()
        {
            InitializeComponent();
            InitLocalData();
        }

        private void InitLocalData()
        {
            dtDiemLocal.Columns.Add("MaSV", typeof(string));
            dtDiemLocal.Columns.Add("Mamon", typeof(string));
            dtDiemLocal.Columns.Add("Hoten", typeof(string));
            dtDiemLocal.Columns.Add("Ngaysinh", typeof(string));
            dtDiemLocal.Columns.Add("Diem", typeof(double));
            dtDiemLocal.Columns.Add("Makhoa", typeof(string));

            dtDiemLocal.Rows.Add("SV01", "M02", "Bùi Thị Thảo", "07/07/1985", 3.0, "K01");
            dtDiemLocal.Rows.Add("SV01", "M01", "Bùi Thị Thảo", "07/07/1985", 9.0, "K01");
            dtDiemLocal.Rows.Add("SV01", "M04", "Bùi Thị Thảo", "07/07/1985", 3.0, "K01");
            dtDiemLocal.Rows.Add("SV02", "M04", "Trần Tuấn Anh", "05/06/1984", 2.0, "K01");
            dtDiemLocal.Rows.Add("SV02", "M02", "Trần Tuấn Anh", "05/06/1984", 9.0, "K01");
            dtDiemLocal.Rows.Add("SV03", "M02", "Nguyễn Thị Mai", "03/04/1982", 8.0, "K01");
            dtDiemLocal.Rows.Add("SV04", "M02", "Trần Thị Yến", "03/02/1982", 6.0, "K02");
            dtDiemLocal.Rows.Add("SV05", "M01", "Bùi Thanh Mai", "03/03/2003", 5.0, "K03");
        }

        private void FormDiem_Load(object? sender, EventArgs e)
        {
            LoadCombos();
            LoadDataListView();
        }

        private void LoadCombos()
        {
            cboMaSV.Items.Clear();
            cboMaMH.Items.Clear();

            DataTable dtSV = ketnoi.truyvan("SELECT MaSV FROM tblSinhVien", "QLDiem");
            if (dtSV.Rows.Count > 0)
            {
                foreach (DataRow r in dtSV.Rows) cboMaSV.Items.Add(r["MaSV"].ToString()!);
            }
            else
            {
                cboMaSV.Items.AddRange(new object[] { "SV01", "SV02", "SV03", "SV04", "SV05", "SV06" });
            }

            DataTable dtMH = ketnoi.truyvan("SELECT Mamon FROM tblMonHoc", "QLDiem");
            if (dtMH.Rows.Count > 0)
            {
                foreach (DataRow r in dtMH.Rows) cboMaMH.Items.Add(r["Mamon"].ToString()!);
            }
            else
            {
                cboMaMH.Items.AddRange(new object[] { "M01", "M02", "M03", "M04", "M05" });
            }

            if (cboMaSV.Items.Count > 0) cboMaSV.SelectedIndex = 0;
            if (cboMaMH.Items.Count > 0) cboMaMH.SelectedIndex = 0;
        }

        private void CboMaSV_SelectedIndexChanged(object? sender, EventArgs e)
        {
            string ma = cboMaSV.Text;
            DataTable dt = ketnoi.truyvan($"SELECT Hoten, Ngaysinh, Makhoa FROM tblSinhVien WHERE MaSV = '{ma}'", "QLDiem");
            if (dt.Rows.Count > 0)
            {
                txtTenSV.Text = dt.Rows[0]["Hoten"].ToString();
                txtMaKhoa.Text = dt.Rows[0]["Makhoa"].ToString();
                if (DateTime.TryParse(dt.Rows[0]["Ngaysinh"].ToString(), out DateTime ns))
                    dtpNgaySinh.Value = ns;
            }
            else
            {
                foreach (DataRow r in dtDiemLocal.Rows)
                {
                    if (r["MaSV"].ToString() == ma)
                    {
                        txtTenSV.Text = r["Hoten"].ToString();
                        txtMaKhoa.Text = r["Makhoa"].ToString();
                        break;
                    }
                }
            }
        }

        private void LoadDataListView(string filter = "")
        {
            lvwDiem.Items.Clear();
            string sql = @"SELECT d.MaSV, d.Mamon, sv.Hoten, CONVERT(VARCHAR, sv.Ngaysinh, 103) AS Ngaysinh, d.Diem, sv.Makhoa 
                           FROM tblDiem d 
                           JOIN tblSinhVien sv ON d.MaSV = sv.MaSV";
            if (!string.IsNullOrEmpty(filter))
            {
                sql += $" WHERE (d.MaSV LIKE '%{filter}%' OR sv.Hoten LIKE N'%{filter}%')";
            }

            DataTable dt = ketnoi.truyvan(sql, "QLDiem");
            DataTable src = (dt.Rows.Count > 0) ? dt : dtDiemLocal;

            foreach (DataRow dr in src.Rows)
            {
                if (!string.IsNullOrEmpty(filter))
                {
                    string ma = dr["MaSV"].ToString()!;
                    string ten = dr["Hoten"].ToString()!;
                    if (!ma.Contains(filter, StringComparison.OrdinalIgnoreCase) && !ten.Contains(filter, StringComparison.OrdinalIgnoreCase))
                        continue;
                }

                ListViewItem item = new ListViewItem(dr["MaSV"].ToString());
                item.SubItems.Add(dr["Mamon"].ToString());
                item.SubItems.Add(dr["Hoten"].ToString());
                item.SubItems.Add(dr["Ngaysinh"].ToString());
                item.SubItems.Add(dr["Diem"].ToString());
                item.SubItems.Add(dr["Makhoa"].ToString());
                lvwDiem.Items.Add(item);
            }
        }

        private void LvwDiem_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (lvwDiem.SelectedItems.Count > 0)
            {
                var item = lvwDiem.SelectedItems[0];
                cboMaSV.Text = item.Text;
                cboMaMH.Text = item.SubItems[1].Text;
                txtTenSV.Text = item.SubItems[2].Text;
                if (DateTime.TryParse(item.SubItems[3].Text, out DateTime ns))
                    dtpNgaySinh.Value = ns;
                txtDiem.Text = item.SubItems[4].Text;
                txtMaKhoa.Text = item.SubItems[5].Text;
            }
        }

        // 2. Thêm điểm
        private void BtnThem_Click(object? sender, EventArgs e)
        {
            string maSV = cboMaSV.Text.Trim();
            string maMH = cboMaMH.Text.Trim();

            if (!double.TryParse(txtDiem.Text.Trim(), out double diem) || diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm nhập không hợp lệ! Vui lòng nhập số thực từ 0 đến 10.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiem.Focus();
                return;
            }

            // Thêm vào CSDL
            string sql = $"IF EXISTS (SELECT * FROM tblDiem WHERE MaSV = '{maSV}' AND Mamon = '{maMH}') " +
                         $"UPDATE tblDiem SET Diem = {diem} WHERE MaSV = '{maSV}' AND Mamon = '{maMH}' " +
                         $"ELSE INSERT INTO tblDiem (MaSV, Mamon, Diem) VALUES ('{maSV}', '{maMH}', {diem})";
            ketnoi.thucthi(sql, "QLDiem");

            bool found = false;
            foreach (DataRow r in dtDiemLocal.Rows)
            {
                if (r["MaSV"].ToString() == maSV && r["Mamon"].ToString() == maMH)
                {
                    r["Diem"] = diem;
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                dtDiemLocal.Rows.Add(maSV, maMH, txtTenSV.Text, dtpNgaySinh.Value.ToString("dd/MM/yyyy"), diem, txtMaKhoa.Text);
            }

            LoadDataListView();
            MessageBox.Show("Thêm/Cập nhật điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 3. Xóa điểm
        private void BtnXoa_Click(object? sender, EventArgs e)
        {
            if (lvwDiem.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một bản ghi điểm trên lưới để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa các điểm đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (ListViewItem item in lvwDiem.SelectedItems)
                {
                    string maSV = item.Text;
                    string maMH = item.SubItems[1].Text;

                    ketnoi.thucthi($"DELETE FROM tblDiem WHERE MaSV = '{maSV}' AND Mamon = '{maMH}'", "QLDiem");

                    for (int i = dtDiemLocal.Rows.Count - 1; i >= 0; i--)
                    {
                        if (dtDiemLocal.Rows[i]["MaSV"].ToString() == maSV && dtDiemLocal.Rows[i]["Mamon"].ToString() == maMH)
                        {
                            dtDiemLocal.Rows.RemoveAt(i);
                        }
                    }
                }

                LoadDataListView();
                MessageBox.Show("Đã xóa điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // 4. Sửa điểm
        private void BtnSua_Click(object? sender, EventArgs e)
        {
            if (lvwDiem.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn bản ghi cần sửa trên ListView!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maSV = cboMaSV.Text.Trim();
            string maMH = cboMaMH.Text.Trim();

            if (!double.TryParse(txtDiem.Text.Trim(), out double diem) || diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm số phải từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = $"UPDATE tblDiem SET Diem = {diem} WHERE MaSV = '{maSV}' AND Mamon = '{maMH}'";
            ketnoi.thucthi(sql, "QLDiem");

            foreach (DataRow r in dtDiemLocal.Rows)
            {
                if (r["MaSV"].ToString() == maSV && r["Mamon"].ToString() == maMH)
                {
                    r["Diem"] = diem;
                    break;
                }
            }

            LoadDataListView();
            MessageBox.Show("Sửa điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 5. Tìm kiếm sinh viên theo MaSV hoặc TênSV
        private void BtnTimKiem_Click(object? sender, EventArgs e)
        {
            using Form fInput = new Form();
            fInput.Text = "Tìm kiếm sinh viên";
            fInput.Size = new Size(380, 160);
            fInput.StartPosition = FormStartPosition.CenterParent;

            Label lbl = new Label() { Text = "Nhập Mã SV hoặc Tên SV:", Location = new Point(20, 20), AutoSize = true };
            TextBox txt = new TextBox() { Location = new Point(20, 45), Width = 320 };
            Button btnOk = new Button() { Text = "Tìm", DialogResult = DialogResult.OK, Location = new Point(160, 80), Width = 80 };
            Button btnAll = new Button() { Text = "Hiện tất cả", DialogResult = DialogResult.Retry, Location = new Point(250, 80), Width = 90 };

            fInput.Controls.AddRange(new Control[] { lbl, txt, btnOk, btnAll });
            fInput.AcceptButton = btnOk;

            DialogResult res = fInput.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                LoadDataListView(txt.Text.Trim());
            }
            else if (res == DialogResult.Retry)
            {
                LoadDataListView("");
            }
        }
    }
}
