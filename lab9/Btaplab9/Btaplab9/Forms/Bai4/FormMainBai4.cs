using System;
using System.Drawing;
using System.Windows.Forms;

namespace Btaplab9.Forms.Bai4
{
    /// <summary>
    /// Bài 4 - Công việc 4: Form giao diện chính quản lý dự án (QLDA)
    /// Hỗ trợ MenuStrip điều hướng tới:
    /// - Quản lý dự án (FormQuanLyDuAn)
    /// - Thống kê dự án (FormThongKeDuAn)
    /// - Thống kê nhân viên (FormThongKeNhanVien)
    /// - Tìm kiếm nhân viên (FormTimKiemNhanVien)
    /// - Tìm kiếm dự án (FormTimKiemDuAn)
    /// </summary>
    public partial class FormMainBai4 : Form
    {
        public FormMainBai4()
        {
            InitializeComponent();
        }

        private void MnuQuanLyDuAn_Click(object? sender, EventArgs e)
        {
            FormQuanLyDuAn f = new FormQuanLyDuAn();
            f.ShowDialog(this);
        }

        private void MnuThongKeDuAn_Click(object? sender, EventArgs e)
        {
            FormThongKeDuAn f = new FormThongKeDuAn();
            f.ShowDialog(this);
        }

        private void MnuThongKeNhanVien_Click(object? sender, EventArgs e)
        {
            FormThongKeNhanVien f = new FormThongKeNhanVien();
            f.ShowDialog(this);
        }

        private void MnuTimKiemNhanVien_Click(object? sender, EventArgs e)
        {
            FormTimKiemNhanVien f = new FormTimKiemNhanVien();
            f.ShowDialog(this);
        }

        private void MnuTimKiemDuAn_Click(object? sender, EventArgs e)
        {
            FormTimKiemDuAn f = new FormTimKiemDuAn();
            f.ShowDialog(this);
        }

        private void MnuThoat_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
