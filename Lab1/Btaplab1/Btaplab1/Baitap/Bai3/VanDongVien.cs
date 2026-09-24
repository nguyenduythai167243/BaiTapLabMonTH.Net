using System;
using System.Collections.Generic;
using System.Linq;

namespace Btaplab1.Baitap.Bai3
{
    /// <summary>
    /// Bài 3: Xây dựng lớp vận động viên VanDongVien gồm:
    /// - Thuộc tính: hoten (chuỗi ký tự), tuoi (số nguyên), monthidau (chuỗi ký tự), cannang (số thực), chieucao (số thực).
    /// - Phương thức:
    ///   - Thiết lập không tham số.
    ///   - Thiết lập 5 tham số.
    ///   - Hủy bỏ.
    /// </summary>
    public class VanDongVien : IComparable<VanDongVien>
    {
        private string hoten;
        private int tuoi;
        private string monthidau;
        private double cannang;
        private double chieucao;

        // Properties
        public string HoTen
        {
            get => hoten;
            set => hoten = value;
        }

        public int Tuoi
        {
            get => tuoi;
            set => tuoi = value;
        }

        public string MonThiDau
        {
            get => monthidau;
            set => monthidau = value;
        }

        public double CanNang
        {
            get => cannang;
            set => cannang = value;
        }

        public double ChieuCao
        {
            get => chieucao;
            set => chieucao = value;
        }

        // 1. Thiết lập không tham số
        public VanDongVien()
        {
            hoten = string.Empty;
            tuoi = 0;
            monthidau = string.Empty;
            cannang = 0.0;
            chieucao = 0.0;
        }

        // 2. Thiết lập 5 tham số
        public VanDongVien(string hoten, int tuoi, string monthidau, double cannang, double chieucao)
        {
            this.hoten = hoten;
            this.tuoi = tuoi;
            this.monthidau = monthidau;
            this.cannang = cannang;
            this.chieucao = chieucao;
        }

        // 3. Hủy bỏ
        ~VanDongVien()
        {
            // Dọn dẹp tài nguyên
        }

        // Nhập thông tin
        public virtual void Nhap()
        {
            Console.Write("Nhập họ tên VĐV: ");
            hoten = Console.ReadLine() ?? string.Empty;

            Console.Write("Nhập tuổi: ");
            int t;
            while (!int.TryParse(Console.ReadLine(), out t) || t <= 0)
            {
                Console.Write("Tuổi không hợp lệ. Nhập lại: ");
            }
            tuoi = t;

            Console.Write("Nhập môn thi đấu: ");
            monthidau = Console.ReadLine() ?? string.Empty;

            Console.Write("Nhập cân nặng (kg): ");
            double cn;
            while (!double.TryParse(Console.ReadLine(), out cn) || cn <= 0)
            {
                Console.Write("Cân nặng không hợp lệ. Nhập lại: ");
            }
            cannang = cn;

            Console.Write("Nhập chiều cao (m hoặc cm, vd: 1.75): ");
            double cc;
            while (!double.TryParse(Console.ReadLine(), out cc) || cc <= 0)
            {
                Console.Write("Chiều cao không hợp lệ. Nhập lại: ");
            }
            chieucao = cc;
        }

        // Hiển thị thông tin
        public virtual void Xuat()
        {
            Console.WriteLine($"VĐV: {hoten,-20} | Tuổi: {tuoi,-4} | Môn: {monthidau,-15} | Cân nặng: {cannang,5:F1}kg | Chiều cao: {chieucao,5:F2}m");
        }

        public override string ToString()
        {
            return $"{hoten} - {tuoi} tuổi - Môn: {monthidau} - {cannang}kg - {chieucao}m";
        }

        // So sánh theo chiều cao (hoặc cân nặng) để sắp xếp tăng dần
        public int CompareTo(VanDongVien? other)
        {
            if (other == null) return 1;
            int cmp = this.chieucao.CompareTo(other.chieucao);
            if (cmp != 0) return cmp;
            return this.cannang.CompareTo(other.cannang);
        }

        // Nạp chồng toán tử so sánh lớn hơn
        public static bool operator >(VanDongVien a, VanDongVien b)
        {
            return a.CompareTo(b) > 0;
        }

        public static bool operator <(VanDongVien a, VanDongVien b)
        {
            return a.CompareTo(b) < 0;
        }
    }

    /// <summary>
    /// Lớp hỗ trợ quản lý mảng n vận động viên cho Bài 3:
    /// - Nhập mảng n vận động viên
    /// - Hiển thị danh sách đã nhập
    /// - Sắp xếp theo thứ tự tăng dần
    /// </summary>
    public class QuanLyVanDongVien
    {
        private VanDongVien[] danhSach = Array.Empty<VanDongVien>();

        public VanDongVien[] DanhSach
        {
            get => danhSach;
            set => danhSach = value;
        }

        public void NhapMang(int n)
        {
            danhSach = new VanDongVien[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n--- Nhập thông tin VĐV thứ {i + 1} ---");
                danhSach[i] = new VanDongVien();
                danhSach[i].Nhap();
            }
        }

        public void HienThiDanhSach()
        {
            if (danhSach.Length == 0)
            {
                Console.WriteLine("Danh sách VĐV rỗng.");
                return;
            }

            Console.WriteLine("\n--- DANH SÁCH VẬN ĐỘNG VIÊN ---");
            for (int i = 0; i < danhSach.Length; i++)
            {
                Console.Write($"[{i + 1}] ");
                danhSach[i].Xuat();
            }
        }

        // Sắp xếp mảng đã nhập theo thứ tự tăng dần
        public void SapXepTangDan()
        {
            Array.Sort(danhSach);
        }
    }
}
