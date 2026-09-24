using System;
using System.Collections.Generic;
using System.Text;
using Btaplab1.Baitap.Bai1;
using Btaplab1.Baitap.Bai2;
using Btaplab1.Baitap.Bai3;
using Btaplab1.Baitap.Bai4;
using Btaplab1.Baitap.Bai5;

namespace Btaplab1
{
    public static class Lab1Runner
    {
        private static void SafeClear()
        {
            try { Console.Clear(); } catch { }
        }

        private static void SafePause()
        {
            try
            {
                Console.WriteLine("\nBấm phím bất kỳ để quay lại menu...");
                Console.ReadKey();
            }
            catch
            {
                Console.ReadLine();
            }
        }

        public static void RunConsoleMenu()
        {
            try
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.InputEncoding = Encoding.UTF8;
            }
            catch { }

            while (true)
            {
                SafeClear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("=================================================================");
                Console.WriteLine("           BÀI TẬP VỀ NHÀ LAB 1 - LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG       ");
                Console.WriteLine("=================================================================");
                Console.ResetColor();
                Console.WriteLine(" 1. Bài 1: Lớp Phanso (Cộng, Trừ, Nhân, Chia 2 phân số)");
                Console.WriteLine(" 2. Bài 2: Lớp SinhVien (Quản lý danh sách, tìm Nam Định, max điểm)");
                Console.WriteLine(" 3. Bài 3: Lớp VanDongVien (Khởi tạo 5 tham số, mảng VĐV, sắp xếp)");
                Console.WriteLine(" 4. Bài 4: Lớp Hanhkhach & Vemaybay (Tính tổng tiền vé, sắp xếp giảm)");
                Console.WriteLine(" 5. Bài 5: Lớp KhachHang (Tiêu thụ điện VN & Nước Ngoài, HD 09/2020)");
                Console.WriteLine(" 0. Thoát menu Console (Chuyển sang giao diện WinForms)");
                Console.WriteLine("=================================================================");
                Console.Write(" Nhập lựa chọn của bạn (0-5): ");

                string? choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        RunBai1();
                        break;
                    case "2":
                        RunBai2();
                        break;
                    case "3":
                        RunBai3();
                        break;
                    case "4":
                        RunBai4();
                        break;
                    case "5":
                        RunBai5();
                        break;
                    case "0":
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Lựa chọn không hợp lệ. Bấm phím bất kỳ để thử lại...");
                        Console.ResetColor();
                        SafePause();
                        break;
                }
            }
        }

        #region Bài 1: Lớp Phanso
        private static void RunBai1()
        {
            SafeClear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=== BÀI 1: LỚP PHÂN SỐ ===");
            Console.ResetColor();

            Console.WriteLine("\n[1] Thử nghiệm với dữ liệu khởi tạo mặc định & mẫu:");
            PhanSo ps1 = new PhanSo(3, 4);
            PhanSo ps2 = new PhanSo(2, 5);
            PhanSo.TinhVaInKetQua(ps1, ps2);

            Console.WriteLine("\n[2] Nhập 2 phân số từ bàn phím:");
            PhanSo obj1 = new PhanSo();
            Console.WriteLine("-> Nhập phân số obj1:");
            obj1.Nhap();

            PhanSo obj2 = new PhanSo();
            Console.WriteLine("-> Nhập phân số obj2:");
            obj2.Nhap();

            Console.WriteLine("\n--- KẾT QUẢ PHÉP TÍNH ---");
            PhanSo.TinhVaInKetQua(obj1, obj2);

            SafePause();
        }
        #endregion

        #region Bài 2: Lớp SinhVien
        private static void RunBai2()
        {
            SafeClear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=== BÀI 2: QUẢN LÝ SINH VIÊN ===");
            Console.ResetColor();

            QuanLySinhVien ql = new QuanLySinhVien();

            // Khởi tạo sẵn một số dữ liệu mẫu phong phú
            ql.ThemSinhVien(new SinhVien("Trần Văn Nam", "Nam Định", 2003, 8.8));
            ql.ThemSinhVien(new SinhVien("Nguyễn Thị Hoa", "Hà Nội", 2004, 9.5));
            ql.ThemSinhVien(new SinhVien("Lê Hoàng Anh", "Nam Định", 2002, 9.5));
            ql.ThemSinhVien(new SinhVien("Phạm Minh Tuấn", "Hải Phòng", 2003, 7.2));

            while (true)
            {
                Console.WriteLine("\n-------------------------------------------------------------");
                Console.WriteLine("a) Tạo/Thêm sinh viên mới vào danh sách");
                Console.WriteLine("b) Sửa thông tin của một sinh viên");
                Console.WriteLine("c) Xóa thông tin về một sinh viên ra khỏi danh sách");
                Console.WriteLine("d) Đưa ra những sinh viên có quê quán ở 'Nam Định'");
                Console.WriteLine("e) Đưa ra những sinh viên có điểm tổng kết lớn nhất");
                Console.WriteLine("h) Hiển thị toàn bộ danh sách sinh viên");
                Console.WriteLine("0) Quay lại Menu chính");
                Console.Write("Lựa chọn (a/b/c/d/e/h/0): ");

                string? opt = Console.ReadLine()?.Trim().ToLower();
                if (opt == "0") break;

                switch (opt)
                {
                    case "a":
                        Console.Write("Nhập số lượng sinh viên muốn thêm: ");
                        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                        {
                            ql.NhapDanhSach(n);
                        }
                        break;

                    case "b":
                        ql.HienThiDanhSach();
                        Console.Write("Nhập tên sinh viên cần sửa: ");
                        string? tenSua = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(tenSua))
                        {
                            ql.SuaThongTinTheoTen(tenSua);
                        }
                        break;

                    case "c":
                        ql.HienThiDanhSach();
                        Console.Write("Nhập tên sinh viên cần xóa: ");
                        string? tenXoa = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(tenXoa))
                        {
                            if (ql.XoaTheoTen(tenXoa))
                                Console.WriteLine("-> Đã xóa thành công!");
                            else
                                Console.WriteLine("-> Không tìm thấy sinh viên để xóa.");
                        }
                        break;

                    case "d":
                        Console.WriteLine("\n--- DANH SÁCH SINH VIÊN QUÊ Ở 'NAM ĐỊNH' ---");
                        var dsND = ql.TimTheoQueQuan("Nam Định");
                        if (dsND.Count == 0)
                            Console.WriteLine("Không có sinh viên nào quê ở Nam Định.");
                        else
                            foreach (var sv in dsND) sv.Xuat();
                        break;

                    case "e":
                        Console.WriteLine("\n--- DANH SÁCH SINH VIÊN CÓ ĐIỂM TỔNG KẾT LỚN NHẤT ---");
                        var dsMax = ql.TimDiemCaoNhat();
                        if (dsMax.Count == 0)
                            Console.WriteLine("Danh sách rỗng.");
                        else
                            foreach (var sv in dsMax) sv.Xuat();
                        break;

                    case "h":
                        ql.HienThiDanhSach();
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }
            }
        }
        #endregion

        #region Bài 3: Lớp VanDongVien
        private static void RunBai3()
        {
            SafeClear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=== BÀI 3: QUẢN LÝ VẬN ĐỘNG VIÊN ===");
            Console.ResetColor();

            Console.WriteLine("\n1. Khai báo p là đối tượng lớp VanDongVien (thiết lập 5 tham số) và hiển thị:");
            VanDongVien p = new VanDongVien("Nguyen Van A", 22, "Bơi lội", 75.5, 1.85);
            p.Xuat();

            Console.WriteLine("\n2. Nhập vào mảng gồm n vận động viên:");
            Console.Write("Nhập số lượng vận động viên n: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                QuanLyVanDongVien ql = new QuanLyVanDongVien();
                ql.NhapMang(n);

                Console.WriteLine("\n--- DANH SÁCH VỪA NHẬP ---");
                ql.HienThiDanhSach();

                Console.WriteLine("\n--- DANH SÁCH SẮP XẾP TĂNG DẦN (Theo chiều cao / cân nặng) ---");
                ql.SapXepTangDan();
                ql.HienThiDanhSach();
            }
            else
            {
                Console.WriteLine("Số lượng n không hợp lệ.");
            }

            SafePause();
        }
        #endregion

        #region Bài 4: Lớp Hanhkhach
        private static void RunBai4()
        {
            SafeClear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=== BÀI 4: QUẢN LÝ HÀNH KHÁCH & VÉ MÁY BAY ===");
            Console.ResetColor();

            QuanLyHanhKhach ql = new QuanLyHanhKhach();

            Console.Write("Nhập số lượng hành khách n: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                ql.NhapDanhSach(n);

                Console.WriteLine("\n--- DANH SÁCH HÀNH KHÁCH & TỔNG TIỀN VÉ ---");
                ql.HienThiDanhSach();

                Console.WriteLine("\n--- DANH SÁCH HÀNH KHÁCH SẮP XẾP GIẢM DẦN THEO TỔNG TIỀN ---");
                ql.SapXepGiamDanTongTien();
                ql.HienThiDanhSach();
            }
            else
            {
                Console.WriteLine("Số lượng n không hợp lệ.");
            }

            SafePause();
        }
        #endregion

        #region Bài 5: Lớp KhachHang
        private static void RunBai5()
        {
            SafeClear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=== BÀI 5: QUẢN LÝ HÓA ĐƠN TIỀN ĐIỆN KHÁCH HÀNG ===");
            Console.ResetColor();

            QuanLyKhachHang ql = new QuanLyKhachHang();

            // Khởi tạo một số dữ liệu mẫu phong phú
            ql.ThemHoaDon(new KhachHangVietNam("KH01", "Nguyễn Văn Hùng", new DateTime(2020, 9, 15), 150, 2000, "Sinh hoạt", 100));
            ql.ThemHoaDon(new KhachHangVietNam("KH02", "Công ty Kim Long", new DateTime(2020, 9, 20), 500, 3000, "Kinh doanh", 200));
            ql.ThemHoaDon(new KhachHangNuocNgoai("KH03", "John Smith", new DateTime(2020, 9, 10), 300, 2500, "USA"));
            ql.ThemHoaDon(new KhachHangNuocNgoai("KH04", "Tanaka Hiroshi", new DateTime(2020, 10, 5), 250, 2500, "Japan"));

            while (true)
            {
                Console.WriteLine("\n-------------------------------------------------------------");
                Console.WriteLine("b) Nhập thêm / Xuất danh sách hóa đơn");
                Console.WriteLine("c) Tính tổng số lượng điện tiêu thụ cho từng loại khách hàng");
                Console.WriteLine("d) Tính trung bình thành tiền của khách hàng nước ngoài");
                Console.WriteLine("e) Xuất ra các hóa đơn lập trong tháng 09 năm 2020");
                Console.WriteLine("h) Hiển thị toàn bộ hóa đơn hiện có");
                Console.WriteLine("0) Quay lại Menu chính");
                Console.Write("Lựa chọn (b/c/d/e/h/0): ");

                string? opt = Console.ReadLine()?.Trim().ToLower();
                if (opt == "0") break;

                switch (opt)
                {
                    case "b":
                        Console.Write("Nhập số lượng hóa đơn muốn nhập thêm: ");
                        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                        {
                            ql.NhapDanhSach(n);
                        }
                        ql.XuatDanhSach();
                        break;

                    case "c":
                        ql.HienThiTongSoLuongDien();
                        break;

                    case "d":
                        ql.HienThiTrungBinhThanhTienNN();
                        break;

                    case "e":
                        ql.XuatHoaDonThang9Nam2020();
                        break;

                    case "h":
                        ql.XuatDanhSach();
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }
            }
        }
        #endregion
    }
}
