using System;

namespace Btaplab1.Baitap.Bai5
{
    /// <summary>
    /// Bài 5: Lớp Khách hàng nước ngoài thừa kế lớp Khách hàng bao gồm thuộc tính: quốc tịch.
    /// Phương thức: Hàm tạo, Hủy, Nhập, Xuất.
    /// Thành tiền = số lượng * đơn giá.
    /// </summary>
    public class KhachHangNuocNgoai : KhachHang
    {
        private string quocTich;

        public string QuocTich
        {
            get => quocTich;
            set => quocTich = value;
        }

        // Hàm tạo không tham số
        public KhachHangNuocNgoai() : base()
        {
            quocTich = string.Empty;
        }

        // Hàm tạo có tham số
        public KhachHangNuocNgoai(string maKhachHang, string hoTenKhachHang, DateTime ngayHoaDon, double soLuong, double donGia, string quocTich)
            : base(maKhachHang, hoTenKhachHang, ngayHoaDon, soLuong, donGia)
        {
            this.quocTich = quocTich;
            TinhThanhTien();
        }

        // Hủy
        ~KhachHangNuocNgoai()
        {
            // Dọn dẹp tài nguyên
        }

        // Tính thành tiền cho khách nước ngoài: Thành tiền = số lượng * đơn giá
        public override double TinhThanhTien()
        {
            thanhTien = soLuong * donGia;
            return thanhTien;
        }

        // Nhập
        public override void Nhap()
        {
            Console.WriteLine("[Nhập thông tin Khách hàng Nước Ngoài]");
            base.Nhap();

            Console.Write("Nhập quốc tịch: ");
            quocTich = Console.ReadLine() ?? string.Empty;

            TinhThanhTien();
        }

        // Xuất
        public override void Xuat()
        {
            Console.WriteLine($"[KH Nước Ngoài] Mã: {maKhachHang,-8} | Họ tên: {hoTenKhachHang,-18} | Quốc tịch: {quocTich,-12} | Ngày: {ngayHoaDon:dd/MM/yyyy} | SL: {soLuong,5} | ĐG: {donGia,8:N0} | Thành tiền: {thanhTien,12:N0} VNĐ");
        }

        public override string ToString()
        {
            return $"[Nước Ngoài - {quocTich}] {base.ToString()}";
        }
    }
}
