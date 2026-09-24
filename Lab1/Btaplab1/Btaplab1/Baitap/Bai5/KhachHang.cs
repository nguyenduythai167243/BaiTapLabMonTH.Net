using System;

namespace Btaplab1.Baitap.Bai5
{
    /// <summary>
    /// Bài 5: Lớp Khách hàng gồm các thuộc tính:
    /// mã khách hàng, số lượng, đơn giá, thành tiền, ngày của hóa đơn và họ tên khách hàng.
    /// Phương thức: Hàm tạo, Hủy, Nhập, Xuất.
    /// </summary>
    public class KhachHang
    {
        protected string maKhachHang;
        protected string hoTenKhachHang;
        protected DateTime ngayHoaDon;
        protected double soLuong; // số lượng KW điện tiêu thụ
        protected double donGia;
        protected double thanhTien;

        public string MaKhachHang
        {
            get => maKhachHang;
            set => maKhachHang = value;
        }

        public string HoTenKhachHang
        {
            get => hoTenKhachHang;
            set => hoTenKhachHang = value;
        }

        public DateTime NgayHoaDon
        {
            get => ngayHoaDon;
            set => ngayHoaDon = value;
        }

        public double SoLuong
        {
            get => soLuong;
            set => soLuong = value;
        }

        public double DonGia
        {
            get => donGia;
            set => donGia = value;
        }

        public double ThanhTien
        {
            get => thanhTien;
            set => thanhTien = value;
        }

        // Hàm tạo không tham số
        public KhachHang()
        {
            maKhachHang = string.Empty;
            hoTenKhachHang = string.Empty;
            ngayHoaDon = DateTime.Now;
            soLuong = 0;
            donGia = 0;
            thanhTien = 0;
        }

        // Hàm tạo có tham số
        public KhachHang(string maKhachHang, string hoTenKhachHang, DateTime ngayHoaDon, double soLuong, double donGia)
        {
            this.maKhachHang = maKhachHang;
            this.hoTenKhachHang = hoTenKhachHang;
            this.ngayHoaDon = ngayHoaDon;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.thanhTien = TinhThanhTien();
        }

        // Hàm hủy
        ~KhachHang()
        {
            // Dọn dẹp tài nguyên
        }

        // Phương thức tính thành tiền đa hình
        public virtual double TinhThanhTien()
        {
            thanhTien = soLuong * donGia;
            return thanhTien;
        }

        // Nhập
        public virtual void Nhap()
        {
            Console.Write("Nhập mã khách hàng: ");
            maKhachHang = Console.ReadLine() ?? string.Empty;

            Console.Write("Nhập họ tên khách hàng: ");
            hoTenKhachHang = Console.ReadLine() ?? string.Empty;

            Console.Write("Nhập ngày hóa đơn (dd/MM/yyyy): ");
            DateTime dt;
            string inputNgay = Console.ReadLine() ?? string.Empty;
            while (!DateTime.TryParseExact(inputNgay, new[] { "d/M/yyyy", "dd/MM/yyyy", "d/M/yy", "dd/MM/yy" }, null, System.Globalization.DateTimeStyles.None, out dt)
                   && !DateTime.TryParse(inputNgay, out dt))
            {
                Console.Write("Ngày không đúng định dạng. Nhập lại (dd/MM/yyyy): ");
                inputNgay = Console.ReadLine() ?? string.Empty;
            }
            ngayHoaDon = dt;

            Console.Write("Nhập số lượng điện (KW): ");
            double sl;
            while (!double.TryParse(Console.ReadLine(), out sl) || sl < 0)
            {
                Console.Write("Số lượng không hợp lệ. Nhập lại: ");
            }
            soLuong = sl;

            Console.Write("Nhập đơn giá: ");
            double dg;
            while (!double.TryParse(Console.ReadLine(), out dg) || dg < 0)
            {
                Console.Write("Đơn giá không hợp lệ. Nhập lại: ");
            }
            donGia = dg;

            TinhThanhTien();
        }

        // Xuất
        public virtual void Xuat()
        {
            Console.WriteLine($"Mã KH: {maKhachHang,-10} | Tên: {hoTenKhachHang,-20} | Ngày: {ngayHoaDon:dd/MM/yyyy} | SL: {soLuong,6:N0} KW | ĐG: {donGia,8:N0} | Thành tiền: {thanhTien,12:N0} VNĐ");
        }

        public override string ToString()
        {
            return $"[{maKhachHang}] {hoTenKhachHang} - {ngayHoaDon:dd/MM/yyyy} - SL: {soLuong} KW - Thành tiền: {thanhTien:N0} VNĐ";
        }
    }
}
