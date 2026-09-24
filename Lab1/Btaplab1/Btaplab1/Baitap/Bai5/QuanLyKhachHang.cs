using System;
using System.Collections.Generic;
using System.Linq;

namespace Btaplab1.Baitap.Bai5
{
    /// <summary>
    /// Bài 5 - Quản lý danh sách hóa đơn khách hàng:
    /// b. Nhập xuất danh sách các hóa đơn khách hàng.
    /// c. Tính tổng số lượng điện tiêu thụ cho từng loại khách hàng.
    /// d. Tính trung bình thành tiền của khách hàng người nước ngoài.
    /// e. Xuất ra các hoá đơn trong tháng 09 năm 2020 (của 2 loại khách hàng).
    /// </summary>
    public class QuanLyKhachHang
    {
        private List<KhachHang> danhSach = new List<KhachHang>();

        public List<KhachHang> DanhSach
        {
            get => danhSach;
            set => danhSach = value;
        }

        // Thêm hóa đơn
        public void ThemHoaDon(KhachHang kh)
        {
            danhSach.Add(kh);
        }

        // b. Nhập danh sách các hóa đơn khách hàng
        public void NhapDanhSach(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n--- Nhập hóa đơn thứ {i + 1} ---");
                Console.WriteLine("Chọn loại khách hàng: 1. Khách hàng Việt Nam | 2. Khách hàng Nước Ngoài");
                Console.Write("Lựa chọn (1 hoặc 2): ");
                string? loai = Console.ReadLine();

                KhachHang kh;
                if (loai == "2")
                {
                    kh = new KhachHangNuocNgoai();
                }
                else
                {
                    kh = new KhachHangVietNam();
                }

                kh.Nhap();
                danhSach.Add(kh);
            }
        }

        // b. Xuất danh sách các hóa đơn khách hàng
        public void XuatDanhSach()
        {
            if (danhSach.Count == 0)
            {
                Console.WriteLine("Danh sách hóa đơn rỗng.");
                return;
            }

            Console.WriteLine("\n============================ DANH SÁCH HÓA ĐƠN ============================");
            for (int i = 0; i < danhSach.Count; i++)
            {
                Console.Write($"[{i + 1}] ");
                danhSach[i].Xuat();
            }
        }

        // c. Tính tổng số lượng điện tiêu thụ cho từng loại khách hàng
        public (double tongSLVN, double tongSLNN) TinhTongSoLuongDien()
        {
            double tongVN = danhSach.OfType<KhachHangVietNam>().Sum(kh => kh.SoLuong);
            double tongNN = danhSach.OfType<KhachHangNuocNgoai>().Sum(kh => kh.SoLuong);
            return (tongVN, tongNN);
        }

        public void HienThiTongSoLuongDien()
        {
            var (tongVN, tongNN) = TinhTongSoLuongDien();
            Console.WriteLine("\n--- TỔNG SỐ LƯỢNG ĐIỆN TIÊU THỤ ---");
            Console.WriteLine($"- Khách hàng Việt Nam:   {tongVN:N0} KW");
            Console.WriteLine($"- Khách hàng Nước ngoài: {tongNN:N0} KW");
        }

        // d. Tính trung bình thành tiền của khách hàng người nước ngoài
        public double TinhTrungBinhThanhTienNN()
        {
            var dsNN = danhSach.OfType<KhachHangNuocNgoai>().ToList();
            if (dsNN.Count == 0) return 0.0;
            return dsNN.Average(kh => kh.ThanhTien);
        }

        public void HienThiTrungBinhThanhTienNN()
        {
            double tb = TinhTrungBinhThanhTienNN();
            Console.WriteLine($"\n--- TRUNG BÌNH THÀNH TIỀN KHÁCH HÀNG NƯỚC NGOÀI: {tb:N0} VNĐ ---");
        }

        // e. Xuất ra các hoá đơn trong tháng 09 năm 2020 (của 2 loại khách hàng)
        public List<KhachHang> LayHoaDonThang9Nam2020()
        {
            return danhSach.Where(kh => kh.NgayHoaDon.Month == 9 && kh.NgayHoaDon.Year == 2020).ToList();
        }

        public void XuatHoaDonThang9Nam2020()
        {
            var dsThang9 = LayHoaDonThang9Nam2020();
            Console.WriteLine("\n--- CÁC HÓA ĐƠN TRONG THÁNG 09 NĂM 2020 ---");
            if (dsThang9.Count == 0)
            {
                Console.WriteLine("Không có hóa đơn nào lập trong tháng 09/2020.");
                return;
            }

            foreach (var kh in dsThang9)
            {
                kh.Xuat();
            }
        }
    }
}
