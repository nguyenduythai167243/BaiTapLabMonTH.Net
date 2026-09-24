using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Btaplab9.Database;

namespace Btaplab9.Forms.Bai4
{
    /// <summary>
    /// Bài 4 - Công việc 3d: Form tìm kiếm dự án theo tên dự án và theo thời gian
    /// </summary>
    public partial class FormTimKiemDuAn : Form
    {
        private DataTable dtDuAnLocal = new DataTable();

        public FormTimKiemDuAn()
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
            dtDuAnLocal.Columns.Add("Ngaybd", typeof(DateTime));

            dtDuAnLocal.Rows.Add("DA01", "Xây dựng Cổng thông tin Viện CNTT", "Phân tích, thiết kế hệ thống web portal", 120, new DateTime(2023, 1, 15));
            dtDuAnLocal.Rows.Add("DA02", "Phần mềm Quản lý Kho bãi", "Lập trình module nhập xuất kho", 90, new DateTime(2023, 3, 20));
            dtDuAnLocal.Rows.Add("DA03", "Số hóa Hồ sơ Lưu trữ", "Scan và nhận dạng OCR chứng từ", 60, new DateTime(2023, 5, 10));
            dtDuAnLocal.Rows.Add("DA04", "Hệ thống AI Điểm danh sinh viên", "Huấn luyện mô hình nhận diện khuôn mặt", 180, new DateTime(2023, 8, 1));
        }

        private void FormTimKiemDuAn_Load(object? sender, EventArgs e)
        {
            dtpTuNgay.Value = new DateTime(2023, 1, 1);
            dtpDenNgay.Value = DateTime.Now;
            BtnTimKiem_Click(null, EventArgs.Empty);
        }

        private void BtnTimKiem_Click(object? sender, EventArgs e)
        {
            string tenDA = txtTenDA.Text.Trim();
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1);

            string sql = $@"SELECT da.Mada AS [Mã DA], da.Tenda AS [Tên dự án], da.Congviecda AS [Công việc], 
                                  da.Songayda AS [Số ngày], CONVERT(VARCHAR, nd.Ngaybd, 103) AS [Ngày bắt đầu]
                           FROM DUAN da
                           LEFT JOIN NHANVIEN_DUAN nd ON da.Mada = nd.Mada
                           WHERE 1=1";

            if (!string.IsNullOrEmpty(tenDA))
            {
                sql += $" AND da.Tenda LIKE N'%{tenDA}%'";
            }
            if (chkFilterDate.Checked)
            {
                sql += $" AND nd.Ngaybd BETWEEN '{tuNgay:yyyy-MM-dd}' AND '{denNgay:yyyy-MM-dd}'";
            }

            DataTable dt = ketnoi.truyvan(sql, "QLDA");
            DataTable src = (dt.Rows.Count > 0) ? dt : FilterLocalData(tenDA, tuNgay, denNgay, chkFilterDate.Checked);

            dgvKetQua.DataSource = src;
            lblSoKetQua.Text = $"Số kết quả tìm thấy: {src.Rows.Count} dự án";
        }

        private DataTable FilterLocalData(string tenDA, DateTime tuNgay, DateTime denNgay, bool checkDate)
        {
            DataTable res = new DataTable();
            res.Columns.Add("Mã DA");
            res.Columns.Add("Tên dự án");
            res.Columns.Add("Công việc");
            res.Columns.Add("Số ngày", typeof(int));
            res.Columns.Add("Ngày bắt đầu");

            foreach (DataRow r in dtDuAnLocal.Rows)
            {
                string ten = r["Tenda"].ToString()!;
                DateTime ngay = (DateTime)r["Ngaybd"];

                bool matchTen = string.IsNullOrEmpty(tenDA) || ten.Contains(tenDA, StringComparison.OrdinalIgnoreCase);
                bool matchDate = !checkDate || (ngay >= tuNgay && ngay <= denNgay);

                if (matchTen && matchDate)
                {
                    res.Rows.Add(r["Mada"], r["Tenda"], r["Congviecda"], r["Songayda"], ngay.ToString("dd/MM/yyyy"));
                }
            }
            return res;
        }

        private void BtnThoat_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
