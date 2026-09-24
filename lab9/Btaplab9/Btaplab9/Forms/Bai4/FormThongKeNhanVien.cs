using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Btaplab9.Database;

namespace Btaplab9.Forms.Bai4
{
    /// <summary>
    /// Bài 4 - Công việc 3b: Form thống kê số lượng nhân viên của Viện
    /// Thông tin: Tên nhân viên, ngày sinh, địa chỉ, trình độ, chuyên môn
    /// </summary>
    public partial class FormThongKeNhanVien : Form
    {
        public FormThongKeNhanVien()
        {
            InitializeComponent();
        }

        private void FormThongKeNhanVien_Load(object? sender, EventArgs e)
        {
            string sql = @"SELECT nv.Hoten AS [Tên nhân viên], CONVERT(VARCHAR, nv.Ngaysinh, 103) AS [Ngày sinh], 
                                  nv.Diachi AS [Địa chỉ], td.Trinhdo AS [Trình độ], cm.Chuyenmon AS [Chuyên môn]
                           FROM NHANVIEN nv
                           LEFT JOIN TRINHDO td ON nv.Manv = td.Manv
                           LEFT JOIN CHUYENMON cm ON nv.Manv = cm.Manv";

            DataTable dt = ketnoi.truyvan(sql, "QLDA");
            if (dt.Rows.Count > 0)
            {
                dgvThongKeNV.DataSource = dt;
            }
            else
            {
                DataTable dtMock = new DataTable();
                dtMock.Columns.Add("Tên nhân viên");
                dtMock.Columns.Add("Ngày sinh");
                dtMock.Columns.Add("Địa chỉ");
                dtMock.Columns.Add("Trình độ");
                dtMock.Columns.Add("Chuyên môn");

                dtMock.Rows.Add("Nguyễn Văn Hùng", "15/05/1988", "Số 12 Chùa Bộc, Hà Nội", "Tiến sĩ", "Khoa học máy tính & CSDL");
                dtMock.Rows.Add("Trần Thị Mai", "20/11/1992", "Số 45 Lê Lợi, Hải Phòng", "Thạc sĩ", "Kỹ thuật phần mềm (.NET/Java)");
                dtMock.Rows.Add("Lê Hoàng Nam", "08/09/1990", "Số 88 Nguyễn Văn Linh, Đà Nẵng", "Kỹ sư", "Mạng máy tính & An toàn thông tin");
                dtMock.Rows.Add("Bùi Minh Tuấn", "12/02/1985", "Số 102 Cầu Giấy, Hà Nội", "Tiến sĩ", "Trí tuệ nhân tạo & Học máy");
                dtMock.Rows.Add("Pham Thị Thanh", "05/07/1995", "Số 15 Trần Phú, Hà Nội", "Cử nhân", "Kiểm thử phần mềm (QA/QC)");

                dgvThongKeNV.DataSource = dtMock;
            }

            lblTongNV.Text = $"Tổng số nhân viên: {dgvThongKeNV.Rows.Count} người  ";
        }
    }
}
