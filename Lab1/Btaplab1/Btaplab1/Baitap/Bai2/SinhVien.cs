using System;
using System.Collections.Generic;
using System.Linq;

namespace Btaplab1.Baitap.Bai2
{
    /// <summary>
    /// Bài 2: Xây dựng lớp SinhVien gồm các thuộc tính:
    /// Họ và tên, quê quán, năm sinh, điểm tổng kết.
    /// Các phương thức: Hàm tạo, Hủy, Nhập, Xuất.
    /// </summary>
    public class SinhVien
    {
        private string hoTen;
        private string queQuan;
        private int namSinh;
        private double diemTongKet;

        // Properties
        public string HoTen
        {
            get => hoTen;
            set => hoTen = value;
        }

        public string QueQuan
        {
            get => queQuan;
            set => queQuan = value;
        }

        public int NamSinh
        {
            get => namSinh;
            set => namSinh = value;
        }

        public double DiemTongKet
        {
            get => diemTongKet;
            set => diemTongKet = value;
        }

        // Hàm tạo không tham số
        public SinhVien()
        {
            hoTen = string.Empty;
            queQuan = string.Empty;
            namSinh = DateTime.Now.Year;
            diemTongKet = 0.0;
        }

        // Hàm tạo có tham số
        public SinhVien(string hoTen, string queQuan, int namSinh, double diemTongKet)
        {
            this.hoTen = hoTen;
            this.queQuan = queQuan;
            this.namSinh = namSinh;
            this.diemTongKet = diemTongKet;
        }

        // Hàm hủy
        ~SinhVien()
        {
            // Dọn dẹp tài nguyên
        }

        // Phương thức Nhập
        public virtual void Nhap()
        {
            Console.Write("Nhập họ và tên: ");
            hoTen = Console.ReadLine() ?? string.Empty;

            Console.Write("Nhập quê quán: ");
            queQuan = Console.ReadLine() ?? string.Empty;

            Console.Write("Nhập năm sinh: ");
            int ns;
            while (!int.TryParse(Console.ReadLine(), out ns) || ns <= 1900 || ns > DateTime.Now.Year)
            {
                Console.Write("Năm sinh không hợp lệ. Nhập lại: ");
            }
            namSinh = ns;

            Console.Write("Nhập điểm tổng kết (0 - 10): ");
            double diem;
            while (!double.TryParse(Console.ReadLine(), out diem) || diem < 0 || diem > 10)
            {
                Console.Write("Điểm tổng kết phải từ 0 đến 10. Nhập lại: ");
            }
            diemTongKet = diem;
        }

        // Phương thức Xuất
        public virtual void Xuat()
        {
            Console.WriteLine($"Họ tên: {hoTen,-22} | Quê quán: {queQuan,-15} | Năm sinh: {namSinh,-6} | Điểm TK: {diemTongKet:F2}");
        }

        public override string ToString()
        {
            return $"Họ tên: {hoTen} - Quê quán: {queQuan} - Năm sinh: {namSinh} - Điểm tổng kết: {diemTongKet:F2}";
        }
    }

    /// <summary>
    /// Lớp quản lý danh sách sinh viên thực hiện các chức năng:
    /// a) Tạo danh sách học sinh
    /// b) Sửa thông tin của một học sinh
    /// c) Xóa thông tin về một học sinh ra khỏi danh sách
    /// d) Đưa ra những học sinh có quê quán ở “Nam Định”
    /// e) Đưa ra những học sinh có điểm tổng kết lớn nhất
    /// </summary>
    public class QuanLySinhVien
    {
        private List<SinhVien> danhSach = new List<SinhVien>();

        public List<SinhVien> DanhSach
        {
            get => danhSach;
            set => danhSach = value;
        }

        // a) Thêm / Tạo danh sách
        public void ThemSinhVien(SinhVien sv)
        {
            danhSach.Add(sv);
        }

        public void NhapDanhSach(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n--- Nhập thông tin sinh viên thứ {i + 1} ---");
                SinhVien sv = new SinhVien();
                sv.Nhap();
                danhSach.Add(sv);
            }
        }

        // Hiển thị toàn bộ danh sách
        public void HienThiDanhSach()
        {
            if (danhSach.Count == 0)
            {
                Console.WriteLine("Danh sách sinh viên đang trống.");
                return;
            }

            Console.WriteLine("\n--- DANH SÁCH SINH VIÊN ---");
            for (int i = 0; i < danhSach.Count; i++)
            {
                Console.Write($"[{i + 1}] ");
                danhSach[i].Xuat();
            }
        }

        // b) Sửa thông tin của một học sinh theo chỉ số hoặc theo tên
        public bool SuaThongTin(int index, string hoTenMoi, string queQuanMoi, int namSinhMoi, double diemMoi)
        {
            if (index < 0 || index >= danhSach.Count)
                return false;

            danhSach[index].HoTen = hoTenMoi;
            danhSach[index].QueQuan = queQuanMoi;
            danhSach[index].NamSinh = namSinhMoi;
            danhSach[index].DiemTongKet = diemMoi;
            return true;
        }

        public bool SuaThongTinTheoTen(string tenCanSua)
        {
            var sv = danhSach.FirstOrDefault(s => s.HoTen.Equals(tenCanSua, StringComparison.OrdinalIgnoreCase));
            if (sv == null)
            {
                Console.WriteLine($"Không tìm thấy sinh viên có tên: {tenCanSua}");
                return false;
            }

            Console.WriteLine("Nhập thông tin mới:");
            sv.Nhap();
            return true;
        }

        // c) Xóa thông tin về một học sinh ra khỏi danh sách
        public bool XoaTheoViTri(int index)
        {
            if (index < 0 || index >= danhSach.Count)
                return false;

            danhSach.RemoveAt(index);
            return true;
        }

        public bool XoaTheoTen(string tenCanXoa)
        {
            var sv = danhSach.FirstOrDefault(s => s.HoTen.Equals(tenCanXoa, StringComparison.OrdinalIgnoreCase));
            if (sv == null)
                return false;

            danhSach.Remove(sv);
            return true;
        }

        // d) Đưa ra những học sinh có quê quán ở “Nam Định”
        public List<SinhVien> TimTheoQueQuan(string queQuan = "Nam Định")
        {
            if (string.IsNullOrWhiteSpace(queQuan)) return new List<SinhVien>();
            string search = queQuan.Trim();
            return danhSach.Where(s => s.QueQuan.Trim().Equals(search, StringComparison.OrdinalIgnoreCase) 
                                    || s.QueQuan.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }

        // e) Đưa ra những học sinh có điểm tổng kết lớn nhất
        public List<SinhVien> TimDiemCaoNhat()
        {
            if (danhSach.Count == 0)
                return new List<SinhVien>();

            double maxDiem = danhSach.Max(s => s.DiemTongKet);
            return danhSach.Where(s => Math.Abs(s.DiemTongKet - maxDiem) < 0.001).ToList();
        }
    }
}
