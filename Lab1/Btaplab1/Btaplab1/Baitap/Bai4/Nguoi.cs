using System;

namespace Btaplab1.Baitap.Bai4
{
    /// <summary>
    /// Bài 4 - Lớp Nguoi:
    /// Thuộc tính: hoten, gioitinh, tuoi
    /// Phương thức:
    /// - Hàm tạo
    /// - Hủy
    /// - Nhập
    /// - Xuất
    /// </summary>
    public class Nguoi
    {
        protected string hoten;
        protected string gioitinh;
        protected int tuoi;

        // Properties
        public string HoTen
        {
            get => hoten;
            set => hoten = value;
        }

        public string GioiTinh
        {
            get => gioitinh;
            set => gioitinh = value;
        }

        public int Tuoi
        {
            get => tuoi;
            set => tuoi = value;
        }

        // Hàm tạo không tham số
        public Nguoi()
        {
            hoten = string.Empty;
            gioitinh = string.Empty;
            tuoi = 0;
        }

        // Hàm tạo có tham số
        public Nguoi(string hoten, string gioitinh, int tuoi)
        {
            this.hoten = hoten;
            this.gioitinh = gioitinh;
            this.tuoi = tuoi;
        }

        // Hủy
        ~Nguoi()
        {
            // Dọn dẹp tài nguyên
        }

        // Nhập
        public virtual void Nhap()
        {
            Console.Write("Nhập họ tên: ");
            hoten = Console.ReadLine() ?? string.Empty;

            Console.Write("Nhập giới tính: ");
            gioitinh = Console.ReadLine() ?? string.Empty;

            Console.Write("Nhập tuổi: ");
            int t;
            while (!int.TryParse(Console.ReadLine(), out t) || t <= 0)
            {
                Console.Write("Tuổi không hợp lệ. Nhập lại: ");
            }
            tuoi = t;
        }

        // Xuất
        public virtual void Xuat()
        {
            Console.WriteLine($"Họ tên: {hoten,-20} | Giới tính: {gioitinh,-6} | Tuổi: {tuoi,-4}");
        }

        public override string ToString()
        {
            return $"{hoten} ({gioitinh}, {tuoi} tuổi)";
        }
    }
}
