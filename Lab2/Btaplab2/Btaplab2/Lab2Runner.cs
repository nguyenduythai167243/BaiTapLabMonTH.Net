using System;
using System.Collections.Generic;
using System.Text;
using Btaplab2.Baitap.Bai1;
using Btaplab2.Baitap.Bai2;
using Btaplab2.Baitap.Bai3;
using Btaplab2.Baitap.Bai4;
using Btaplab2.Baitap.Bai5;

namespace Btaplab2
{
    public static class Lab2Runner
    {
        private static void SafeClear()
        {
            try { Console.Clear(); } catch { }
        }

        private static void SafePause()
        {
            try
            {
                Console.WriteLine("\nBấm phím bất kỳ để tiếp tục...");
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
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("=================================================================");
                Console.WriteLine("           BÀI TẬP VỀ NHÀ LAB 2 - ABSTRACT CLASS & INTERFACE      ");
                Console.WriteLine("=================================================================");
                Console.ResetColor();
                Console.WriteLine(" 1. Bài 1: Lớp SinhVienUneti (Lớp trừu tượng & xếp loại học lực)");
                Console.WriteLine(" 2. Bài 2: Interface Person & Lớp Student (Tìm sinh viên tên 'Nam')");
                Console.WriteLine(" 3. Bài 3: Ma trận số thực n x m (Số âm min, xếp cột, xóa cột, tbc chẵn)");
                Console.WriteLine(" 4. Bài 4: Ma trận số thực vuông cấp n (Chéo phụ, chéo chính, chia hết 3&5)");
                Console.WriteLine(" 5. Bài 5: Xử lý xâu ký tự (Hoa/thường, số từ, phụ/nguyên âm, đếm xâu con)");
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

        #region Bài 1: SinhVienUneti
        private static void RunBai1()
        {
            SafeClear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=== BÀI 1: LỚP TRỪU TƯỢNG SinhVienUneti ===");
            Console.ResetColor();

            List<SinhVienUneti> danhSach = new List<SinhVienUneti>
            {
                new SinhVienIT("Nguyễn Văn A", 8.5, 9.0, 7.5),
                new SinhVienIT("Trần Thị B", 6.0, 5.5, 7.0),
                new SinhVienKinhTe("Lê Văn C", 9.0, 8.5),
                new SinhVienKinhTe("Phạm Thị D", 4.5, 5.0)
            };

            Console.WriteLine("\n--- DANH SÁCH SINH VIÊN UNETI (CẢ IT VÀ KINH TẾ) ---");
            foreach (var sv in danhSach)
            {
                sv.xuat();
            }

            SafePause();
        }
        #endregion

        #region Bài 2: Interface Person & Student
        private static void RunBai2()
        {
            SafeClear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=== BÀI 2: INTERFACE Person & LỚP Student ===");
            Console.ResetColor();

            QuanLyStudent ql = new QuanLyStudent();

            // Dữ liệu mẫu khởi tạo sẵn
            ql.DanhSach.Add(new Student("SV01", "Nguyễn Văn Nam", 21, "Nam Định"));
            ql.DanhSach.Add(new Student("SV02", "Trần Thị Mai", 20, "Hà Nội"));
            ql.DanhSach.Add(new Student("SV03", "Phạm Hoài Nam", 22, "Hải Phòng"));
            ql.DanhSach.Add(new Student("SV04", "Lê Văn An", 19, "Đà Nẵng"));

            while (true)
            {
                Console.WriteLine("\n-------------------------------------------------------------");
                Console.WriteLine("1. Nhập vào một danh sách sinh viên");
                Console.WriteLine("2. Hiển thị danh sách sinh viên vừa nhập ra màn hình");
                Console.WriteLine("3. Tìm kiếm và đưa ra thông tin của sinh viên có tên là 'Nam'");
                Console.WriteLine("0. Quay lại Menu chính");
                Console.Write("Lựa chọn (1-3, 0): ");

                string? opt = Console.ReadLine()?.Trim();
                if (opt == "0") break;

                switch (opt)
                {
                    case "1":
                        Console.Write("Nhập số lượng sinh viên n: ");
                        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                        {
                            ql.NhapDanhSach(n);
                        }
                        break;

                    case "2":
                        ql.HienThiDanhSach();
                        break;

                    case "3":
                        ql.HienThiSinhVienTenNam();
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }
            }
        }
        #endregion

        #region Bài 3: Ma trận số thực n x m
        private static void RunBai3()
        {
            SafeClear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=== BÀI 3: THAO TÁC TRÊN MA TRẬN SỐ THỰC N HÀNG, M CỘT ===");
            Console.ResetColor();

            // Khởi tạo mẫu hoặc nhập mới
            Console.WriteLine("Bạn muốn dùng ma trận mẫu 3x4 hay nhập từ bàn phím?");
            Console.WriteLine("1. Dùng ma trận mẫu (3x4)");
            Console.WriteLine("2. Nhập từ bàn phím");
            Console.Write("Lựa chọn (1 hoặc 2): ");
            string? choice = Console.ReadLine();

            MaTranChuNhat mt;
            if (choice == "2")
            {
                mt = new MaTranChuNhat();
                mt.Nhap();
            }
            else
            {
                double[,] sample = {
                    { 2.5, -4.2, 6.0, -1.8 },
                    { -8.5, 4.0, 2.0, 10.0 },
                    { 3.0, -1.5, 8.0, 4.0 }
                };
                mt = new MaTranChuNhat(sample);
            }

            while (true)
            {
                Console.WriteLine("\n-------------------------------------------------------------");
                Console.WriteLine("2. Hiển thị ma trận");
                Console.WriteLine("3. Tìm số âm nhỏ nhất của ma trận");
                Console.WriteLine("4. Sắp xếp từng cột của ma trận theo thứ tự tăng dần");
                Console.WriteLine("5. Nhập số nguyên dương k, xóa cột thứ k của ma trận nếu có");
                Console.WriteLine("6. Tính trung bình cộng các phần tử có giá trị chẵn trong ma trận");
                Console.WriteLine("0. Quay lại Menu chính");
                Console.Write("Lựa chọn (2-6, 0): ");

                string? opt = Console.ReadLine()?.Trim();
                if (opt == "0") break;

                switch (opt)
                {
                    case "2":
                        mt.HienThi();
                        break;

                    case "3":
                        double? minAm = mt.TimSoAmNhoNhat();
                        if (minAm.HasValue)
                            Console.WriteLine($"-> Số âm nhỏ nhất của ma trận là: {minAm.Value}");
                        else
                            Console.WriteLine("-> Ma trận không có số âm.");
                        break;

                    case "4":
                        mt.SapXepTungCotTangDan();
                        Console.WriteLine("-> Đã sắp xếp từng cột theo thứ tự tăng dần:");
                        mt.HienThi();
                        break;

                    case "5":
                        Console.Write("Nhập chỉ số cột k cần xóa (1 đến m): ");
                        if (int.TryParse(Console.ReadLine(), out int k))
                        {
                            if (mt.XoaCot(k))
                            {
                                Console.WriteLine($"-> Đã xóa cột thứ {k} thành công.");
                                mt.HienThi();
                            }
                            else
                            {
                                Console.WriteLine("-> Chỉ số k không hợp lệ.");
                            }
                        }
                        break;

                    case "6":
                        double? tbc = mt.TinhTrungBinhCongGiaTriChan();
                        if (tbc.HasValue)
                            Console.WriteLine($"-> Trung bình cộng các phần tử chẵn là: {tbc.Value:F2}");
                        else
                            Console.WriteLine("-> Ma trận không có phần tử số nguyên chẵn.");
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }
            }
        }
        #endregion

        #region Bài 4: Ma trận vuông cấp n
        private static void RunBai4()
        {
            SafeClear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=== BÀI 4: THAO TÁC TRÊN MA TRẬN SỐ THỰC VUÔNG CẤP N ===");
            Console.ResetColor();

            Console.WriteLine("1. Dùng ma trận vuông mẫu 3x3");
            Console.WriteLine("2. Nhập từ bàn phím");
            Console.Write("Lựa chọn (1 hoặc 2): ");
            string? choice = Console.ReadLine();

            MaTranVuong mt;
            if (choice == "2")
            {
                mt = new MaTranVuong();
                mt.Nhap();
            }
            else
            {
                double[,] sample = {
                    { -3.0, 15.0, 5.0 },
                    { 7.0, -1.5, 30.0 },
                    { 10.0, 2.0, -8.0 }
                };
                mt = new MaTranVuong(sample);
            }

            while (true)
            {
                Console.WriteLine("\n-------------------------------------------------------------");
                Console.WriteLine("2. Hiển thị ma trận");
                Console.WriteLine("3. Tính tổng các phần tử nằm trên đường chéo phụ");
                Console.WriteLine("4. Tìm số âm lớn nhất trên đường chéo chính");
                Console.WriteLine("5. Đếm các phần tử có giá trị chia hết cho 3 và 5");
                Console.WriteLine("0. Quay lại Menu chính");
                Console.Write("Lựa chọn (2-5, 0): ");

                string? opt = Console.ReadLine()?.Trim();
                if (opt == "0") break;

                switch (opt)
                {
                    case "2":
                        mt.HienThi();
                        break;

                    case "3":
                        double tongPhu = mt.TinhTongDuongCheoPhu();
                        Console.WriteLine($"-> Tổng các phần tử trên đường chéo phụ: {tongPhu}");
                        break;

                    case "4":
                        double? maxAm = mt.TimSoAmLonNhatDuongCheoChinh();
                        if (maxAm.HasValue)
                            Console.WriteLine($"-> Số âm lớn nhất trên đường chéo chính: {maxAm.Value}");
                        else
                            Console.WriteLine("-> Không có số âm nào trên đường chéo chính.");
                        break;

                    case "5":
                        int dem = mt.DemPhanTuChiaHetCho3Va5();
                        Console.WriteLine($"-> Số phần tử chia hết cho cả 3 và 5: {dem}");
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }
            }
        }
        #endregion

        #region Bài 5: Xử lý xâu ký tự
        private static void RunBai5()
        {
            SafeClear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=== BÀI 5: XỬ LÝ XÂU KÝ TỰ ===");
            Console.ResetColor();

            XuLyChuoi xl = new XuLyChuoi("Lap trinh CSharp va Visual Studio 2022 tai UNETI");

            while (true)
            {
                Console.WriteLine("\n-------------------------------------------------------------");
                Console.WriteLine($"Xâu hiện tại: \"{xl.NoiDung}\"");
                Console.WriteLine("1. Nhập vào một xâu ký tự mới và hiển thị");
                Console.WriteLine("2. Đếm số chữ thường và chữ hoa");
                Console.WriteLine("3. Đếm số từ trong xâu");
                Console.WriteLine("4. Đếm số phụ âm và nguyên âm");
                Console.WriteLine("5. Nhập xâu con và đếm số lần xuất hiện");
                Console.WriteLine("0. Quay lại Menu chính");
                Console.Write("Lựa chọn (1-5, 0): ");

                string? opt = Console.ReadLine()?.Trim();
                if (opt == "0") break;

                switch (opt)
                {
                    case "1":
                        xl.Nhap();
                        xl.HienThi();
                        break;

                    case "2":
                        var (thuong, hoa) = xl.DemChuThuongVaHoa();
                        Console.WriteLine($"-> Chữ thường: {thuong} | Chữ hoa: {hoa}");
                        break;

                    case "3":
                        int soTu = xl.DemSoTu();
                        Console.WriteLine($"-> Số từ trong xâu: {soTu}");
                        break;

                    case "4":
                        var (nguyenAm, phuAm) = xl.DemNguyenAmVaPhuAm();
                        Console.WriteLine($"-> Nguyên âm: {nguyenAm} | Phụ âm: {phuAm}");
                        break;

                    case "5":
                        Console.Write("Nhập xâu con cần đếm: ");
                        string? subStr = Console.ReadLine();
                        if (!string.IsNullOrEmpty(subStr))
                        {
                            int count = xl.DemSoLanXuatHien(subStr);
                            Console.WriteLine($"-> Xâu con \"{subStr}\" xuất hiện {count} lần.");
                        }
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
