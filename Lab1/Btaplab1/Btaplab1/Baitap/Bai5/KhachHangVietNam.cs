using System;

namespace Btaplab1.Baitap.Bai5
{
    /// <summary>
    /// Bài 5: Lớp Khách hàng Việt Nam thừa kế lớp Khách hàng bao gồm thuộc tính:
    /// loại khách hàng (sinh hoạt, kinh doanh, sản xuất), định mức.
    /// Phương thức: Hàm tạo, Hủy, Nhập, Xuất.
    /// Tính thành tiền:
    /// - Nếu số lượng <= định mức: thành tiền = số lượng * đơn giá
    /// - Nếu số lượng > định mức: thành tiền = định mức * đơn giá + (số lượng - định mức) * đơn giá * 2.5
    /// </summary>
    public class KhachHangVietNam : KhachHang
    {
        private string loaiKhachHang; // sinh hoạt, kinh doanh, sản xuất
        private double dinhMuc;

        public string LoaiKhachHang
        {
            get => loaiKhachHang;
            set => loaiKhachHang = value;
        }

        public double DinhMuc
        {
            get => dinhMuc;
            set => dinhMuc = value;
        }

        // Hàm tạo không tham số
        public KhachHangVietNam() : base()
        {
            loaiKhachHang = "Sinh hoạt";
            dinhMuc = 0.0;
        }

        // Hàm tạo có tham số
        public KhachHangVietNam(string maKhachHang, string hoTenKhachHang, DateTime ngayHoaDon, double soLuong, double donGia, string loaiKhachHang, double dinhMuc)
            : base(maKhachHang, hoTenKhachHang, ngayHoaDon, soLuong, donGia)
        {
            this.loaiKhachHang = loaiKhachHang;
            this.dinhMuc = dinhMuc;
            TinhThanhTien();
        }

        // Hủy
        ~KhachHangVietNam()
        {
            // Dọn dẹp tài nguyên
        }

        // Tính thành tiền theo định mức điện Việt Nam
        public override double TinhThanhTien()
        {
            if (soLuong <= dinhMuc)
            {
                thanhTien = soLuong * donGia;
            }
            else
            {
                thanhTien = (dinhMuc * donGia) + ((soLuong - dinhMuc) * donGia * 2.5);
            }
            return thanhTien;
        }

        // Nhập
        public override void Nhap()
        {
            Console.WriteLine("[Nhập thông tin Khách hàng Việt Nam]");
            base.Nhap();

            Console.WriteLine("Chọn loại khách hàng: 1. Sinh hoạt  2. Kinh doanh  3. Sản xuất");
            Console.Write("Lựa chọn (1-3): ");
            string? choice = Console.ReadLine();
            loaiKhachHang = choice switch
            {
                "1" => "Sinh hoạt",
                "2" => "Kinh doanh",
                "3" => "Sản xuất",
                _ => "Sinh hoạt"
            };

            Console.Write("Nhập định mức tiêu thụ (KW): ");
            double dm;
            while (!double.TryParse(Console.ReadLine(), out dm) || dm < 0)
            {
                Console.Write("Định mức không hợp lệ. Nhập lại: ");
            }
            dinhMuc = dm;

            TinhThanhTien();
        }

        // Xuất
        public override void Xuat()
        {
            Console.WriteLine($"[KH Việt Nam]   Mã: {maKhachHang,-8} | Họ tên: {hoTenKhachHang,-18} | Loại: {loaiKhachHang,-11} | Định mức: {dinhMuc,5} | Ngày: {ngayHoaDon:dd/MM/yyyy} | SL: {soLuong,5} | ĐG: {donGia,8:N0} | Thành tiền: {thanhTien,12:N0} VNĐ");
        }

        public override string ToString()
        {
            return $"[Việt Nam - {loaiKhachHang}] {base.ToString()} (Định mức: {dinhMuc})";
        }
    }
}
