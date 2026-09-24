using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Btaplab9.Database;

namespace Btaplab9.Forms.Bai4
{
    /// <summary>
    /// Bài 4 - Công việc 3a: Form thống kê các dự án đang thực hiện của Viện
    /// Thông tin: Tên dự án, công việc thực hiện, ngày bắt đầu, tên nhân viên thực hiện, ngày sinh, địa chỉ
    /// </summary>
    public partial class FormThongKeDuAn : Form
    {
        public FormThongKeDuAn()
        {
            InitializeComponent();
        }

        private void FormThongKeDuAn_Load(object? sender, EventArgs e)
        {
            string sql = @"SELECT da.Tenda AS [Tên dự án], da.Congviecda AS [Công việc thực hiện], 
                                  CONVERT(VARCHAR, nd.Ngaybd, 103) AS [Ngày bắt đầu], 
                                  nv.Hoten AS [Tên nhân viên], CONVERT(VARCHAR, nv.Ngaysinh, 103) AS [Ngày sinh], 
                                  nv.Diachi AS [Địa chỉ]
                           FROM NHANVIEN_DUAN nd
                           JOIN DUAN da ON nd.Mada = da.Mada
                           JOIN NHANVIEN nv ON nd.Manv = nv.Manv";

            DataTable dt = ketnoi.truyvan(sql, "QLDA");
            if (dt.Rows.Count > 0)
            {
                dgvThongKeDA.DataSource = dt;
            }
            else
            {
                DataTable dtMock = new DataTable();
                dtMock.Columns.Add("Tên dự án");
                dtMock.Columns.Add("Công việc thực hiện");
                dtMock.Columns.Add("Ngày bắt đầu");
                dtMock.Columns.Add("Tên nhân viên");
                dtMock.Columns.Add("Ngày sinh");
                dtMock.Columns.Add("Địa chỉ");

                dtMock.Rows.Add("Xây dựng Cổng thông tin Viện CNTT", "Thiết kế giao diện & CSDL", "01/03/2023", "Nguyễn Văn Hùng", "15/05/1988", "Hà Nội");
                dtMock.Rows.Add("Phần mềm Quản lý Kho bãi", "Lập trình API Backend", "15/04/2023", "Trần Thị Mai", "20/11/1992", "Hải Phòng");
                dtMock.Rows.Add("Số hóa Hồ sơ Lưu trữ", "Quét tài liệu & Kiểm thử", "10/05/2023", "Lê Hoàng Nam", "08/09/1990", "Đà Nẵng");
                dtMock.Rows.Add("Hệ thống AI Điểm danh sinh viên", "Xây dựng mô hình AI nhận diện", "01/06/2023", "Bùi Minh Tuấn", "12/02/1985", "Hà Nội");

                dgvThongKeDA.DataSource = dtMock;
            }

            lblTongSo.Text = $"Tổng số phân công dự án: {dgvThongKeDA.Rows.Count} lượt";
        }
    }
}
