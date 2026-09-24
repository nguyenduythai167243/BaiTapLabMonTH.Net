using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Btaplab9.Database;

namespace Btaplab9.Forms.Bai4
{
    /// <summary>
    /// Bài 4 - Công việc 3c: Form tìm kiếm nhân viên
    /// </summary>
    public partial class FormTimKiemNhanVien : Form
    {
        private DataTable dtNVLocal = new DataTable();

        public FormTimKiemNhanVien()
        {
            InitializeComponent();
            InitLocalData();
        }

        private void InitLocalData()
        {
            dtNVLocal.Columns.Add("Manv", typeof(string));
            dtNVLocal.Columns.Add("Hoten", typeof(string));
            dtNVLocal.Columns.Add("SoCMTND", typeof(string));
            dtNVLocal.Columns.Add("Ngaysinh", typeof(string));
            dtNVLocal.Columns.Add("Gioitinh", typeof(string));
            dtNVLocal.Columns.Add("Diachi", typeof(string));
            dtNVLocal.Columns.Add("Chuyenmon", typeof(string));
            dtNVLocal.Columns.Add("Trinhdo", typeof(string));

            dtNVLocal.Rows.Add("NV01", "Nguyễn Văn Hùng", "012345678", "15/05/1988", "Nam", "Số 12 Chùa Bộc, Hà Nội", "Khoa học máy tính", "Tiến sĩ");
            dtNVLocal.Rows.Add("NV02", "Trần Thị Mai", "012345679", "20/11/1992", "Nữ", "Số 45 Lê Lợi, Hải Phòng", "Kỹ thuật phần mềm", "Thạc sĩ");
            dtNVLocal.Rows.Add("NV03", "Lê Hoàng Nam", "012345680", "08/09/1990", "Nam", "Số 88 Nguyễn Văn Linh, Đà Nẵng", "Mạng máy tính", "Kỹ sư");
            dtNVLocal.Rows.Add("NV04", "Bùi Minh Tuấn", "012345681", "12/02/1985", "Nam", "Số 102 Cầu Giấy, Hà Nội", "Trí tuệ nhân tạo", "Tiến sĩ");
            dtNVLocal.Rows.Add("NV05", "Phạm Thị Thanh", "012345682", "05/07/1995", "Nữ", "Số 15 Trần Phú, Hà Nội", "Kiểm thử phần mềm", "Cử nhân");
        }

        private void FormTimKiemNhanVien_Load(object? sender, EventArgs e)
        {
            cboTieuChi.SelectedIndex = 0;
            BtnTimKiem_Click(null, EventArgs.Empty);
        }

        private void BtnTimKiem_Click(object? sender, EventArgs e)
        {
            string keyword = txtTuKhoa.Text.Trim();
            int tieuChi = cboTieuChi.SelectedIndex; // 0: Tất cả, 1: Mã NV, 2: Tên NV, 3: Chuyên môn

            string sql = @"SELECT nv.Manv, nv.Hoten, nv.SoCMTND, CONVERT(VARCHAR, nv.Ngaysinh, 103) AS Ngaysinh, 
                                  nv.Gioitinh, nv.Diachi, cm.Chuyenmon, td.Trinhdo 
                           FROM NHANVIEN nv
                           LEFT JOIN CHUYENMON cm ON nv.Manv = cm.Manv
                           LEFT JOIN TRINHDO td ON nv.Manv = td.Manv";

            if (!string.IsNullOrEmpty(keyword))
            {
                if (tieuChi == 1) sql += $" WHERE nv.Manv LIKE '%{keyword}%'";
                else if (tieuChi == 2) sql += $" WHERE nv.Hoten LIKE N'%{keyword}%'";
                else if (tieuChi == 3) sql += $" WHERE cm.Chuyenmon LIKE N'%{keyword}%'";
                else sql += $" WHERE (nv.Manv LIKE '%{keyword}%' OR nv.Hoten LIKE N'%{keyword}%' OR cm.Chuyenmon LIKE N'%{keyword}%')";
            }

            DataTable dt = ketnoi.truyvan(sql, "QLDA");
            DataTable src = (dt.Rows.Count > 0) ? dt : FilterLocalData(keyword, tieuChi);

            dgvKetQua.DataSource = src;
            lblSoKetQua.Text = $"Số kết quả tìm thấy: {src.Rows.Count} bản ghi";
        }

        private DataTable FilterLocalData(string keyword, int tieuChi)
        {
            if (string.IsNullOrEmpty(keyword)) return dtNVLocal;

            DataTable res = dtNVLocal.Clone();
            foreach (DataRow r in dtNVLocal.Rows)
            {
                string ma = r["Manv"].ToString()!;
                string ten = r["Hoten"].ToString()!;
                string cm = r["Chuyenmon"].ToString()!;

                bool match = false;
                if (tieuChi == 1 && ma.Contains(keyword, StringComparison.OrdinalIgnoreCase)) match = true;
                else if (tieuChi == 2 && ten.Contains(keyword, StringComparison.OrdinalIgnoreCase)) match = true;
                else if (tieuChi == 3 && cm.Contains(keyword, StringComparison.OrdinalIgnoreCase)) match = true;
                else if (tieuChi == 0 && (ma.Contains(keyword, StringComparison.OrdinalIgnoreCase) || ten.Contains(keyword, StringComparison.OrdinalIgnoreCase) || cm.Contains(keyword, StringComparison.OrdinalIgnoreCase))) match = true;

                if (match) res.ImportRow(r);
            }
            return res;
        }

        private void BtnThoat_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
