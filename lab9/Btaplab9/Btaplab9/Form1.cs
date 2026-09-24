using System;
using System.Drawing;
using System.Windows.Forms;
using Btaplab9.Forms.Guided;
using Btaplab9.Forms.Bai1;
using Btaplab9.Forms.Bai2;
using Btaplab9.Forms.Bai3;
using Btaplab9.Forms.Bai4;

namespace Btaplab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // --- BÀI HƯỚNG DẪN (QLBH) ---
        private void BtnGuided_Main_Click(object? sender, EventArgs e) => new FrmMain().ShowDialog(this);
        private void BtnGuided_KH_Click(object? sender, EventArgs e) => new FrmKhachHang().ShowDialog(this);
        private void BtnGuided_MH_Click(object? sender, EventArgs e) => new FrmMatHang().ShowDialog(this);
        private void BtnGuided_BH_Click(object? sender, EventArgs e) => new FrmBanHang().ShowDialog(this);
        private void BtnGuided_TK_KH_Click(object? sender, EventArgs e) => new FrmTimkiemKH().ShowDialog(this);
        private void BtnGuided_TK_MH_Click(object? sender, EventArgs e) => new FrmTimkiemMH().ShowDialog(this);

        // --- BÀI 1 (QLKhachSan) ---
        private void BtnBai1_QuanLyPhong_Click(object? sender, EventArgs e) => new FormQuanLyPhong().ShowDialog(this);
        private void BtnBai1_KhachThuePhong_Click(object? sender, EventArgs e) => new FormKhachThuePhong().ShowDialog(this);

        // --- BÀI 2 (QLDiem) ---
        private void BtnBai2_Main_Click(object? sender, EventArgs e) => new FormMainBai2().ShowDialog(this);
        private void BtnBai2_MonHoc_Click(object? sender, EventArgs e) => new FormMonHoc().ShowDialog(this);
        private void BtnBai2_Diem_Click(object? sender, EventArgs e) => new FormDiem().ShowDialog(this);

        // --- BÀI 3 (QLKD) ---
        private void BtnBai3_MuaHang_Click(object? sender, EventArgs e) => new FormMuaHang().ShowDialog(this);
        private void BtnBai3_ThongKe_Click(object? sender, EventArgs e) => new FormThongKeHangMua().ShowDialog(this);

        // --- BÀI 4 (QLDA) ---
        private void BtnBai4_Main_Click(object? sender, EventArgs e) => new FormMainBai4().ShowDialog(this);
        private void BtnBai4_DuAn_Click(object? sender, EventArgs e) => new FormQuanLyDuAn().ShowDialog(this);
        private void BtnBai4_ThongKeDA_Click(object? sender, EventArgs e) => new FormThongKeDuAn().ShowDialog(this);
        private void BtnBai4_ThongKeNV_Click(object? sender, EventArgs e) => new FormThongKeNhanVien().ShowDialog(this);
        private void BtnBai4_TimKiemNV_Click(object? sender, EventArgs e) => new FormTimKiemNhanVien().ShowDialog(this);
        private void BtnBai4_TimKiemDA_Click(object? sender, EventArgs e) => new FormTimKiemDuAn().ShowDialog(this);

        private void BtnThoat_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
