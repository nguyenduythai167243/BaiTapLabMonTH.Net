using System;

namespace Btaplab1.Baitap.Bai4
{
    /// <summary>
    /// Bài 4 - Lớp Vemaybay:
    /// Thuộc tính: tenchuyen, ngaybay, giave
    /// Phương thức:
    /// - Hàm tạo
    /// - Hủy
    /// - Nhập
    /// - Xuất
    /// - getgiave(): hàm trả về giá vé
    /// </summary>
    public class VeMayBay
    {
        private string tenchuyen;
        private string ngaybay;
        private double giave;

        // Properties
        public string TenChuyen
        {
            get => tenchuyen;
            set => tenchuyen = value;
        }

        public string NgayBay
        {
            get => ngaybay;
            set => ngaybay = value;
        }

        public double GiaVe
        {
            get => giave;
            set => giave = value;
        }

        // Hàm tạo không tham số
        public VeMayBay()
        {
            tenchuyen = string.Empty;
            ngaybay = string.Empty;
            giave = 0.0;
        }

        // Hàm tạo có tham số
        public VeMayBay(string tenchuyen, string ngaybay, double giave)
        {
            this.tenchuyen = tenchuyen;
            this.ngaybay = ngaybay;
            this.giave = giave;
        }

        // Hàm hủy
        ~VeMayBay()
        {
            // Dọn dẹp tài nguyên
        }

        // Nhập
        public void Nhap()
        {
            Console.Write("  + Tên chuyến bay: ");
            tenchuyen = Console.ReadLine() ?? string.Empty;

            Console.Write("  + Ngày bay (dd/MM/yyyy): ");
            ngaybay = Console.ReadLine() ?? string.Empty;

            Console.Write("  + Giá vé: ");
            double gv;
            while (!double.TryParse(Console.ReadLine(), out gv) || gv < 0)
            {
                Console.Write("  Giá vé không hợp lệ. Nhập lại: ");
            }
            giave = gv;
        }

        // Xuất
        public void Xuat()
        {
            Console.WriteLine($"    Chuyến: {tenchuyen,-15} | Ngày bay: {ngaybay,-12} | Giá vé: {giave:N0} VNĐ");
        }

        // getgiave() : hàm trả về giá vé theo đúng đặc tả đề bài
        public double getgiave()
        {
            return giave;
        }

        public override string ToString()
        {
            return $"{tenchuyen} ({ngaybay}) - {giave:N0} VNĐ";
        }
    }
}
