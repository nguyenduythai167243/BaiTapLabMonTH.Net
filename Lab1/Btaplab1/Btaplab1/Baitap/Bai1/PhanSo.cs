using System;

namespace Btaplab1.Baitap.Bai1
{
    /// <summary>
    /// Bài 1: Xây dựng lớp Phanso gồm:
    /// - Thuộc Tính: tuso, mauso.
    /// - Phương thức:
    ///   - Hàm Khởi Tạo Không Tham Số, Hàm Hủy
    ///   - Nhập, Xuất
    ///   - Cong(), Tru(), Nhan(), Chia()
    ///   - Tính Tổng, Hiệu, Tích, Thương 2 phân số obj1 và obj2 rồi in kết quả ra màn hình
    /// </summary>
    public class PhanSo
    {
        private int tuso;
        private int mauso;

        // Properties
        public int TuSo
        {
            get => tuso;
            set => tuso = value;
        }

        public int MauSo
        {
            get => mauso;
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Mẫu số không thể bằng 0.");
                }
                mauso = value;
            }
        }

        // Hàm khởi tạo không tham số
        public PhanSo()
        {
            tuso = 0;
            mauso = 1;
        }

        // Hàm khởi tạo có tham số
        public PhanSo(int tuso, int mauso)
        {
            if (mauso == 0)
            {
                throw new ArgumentException("Mẫu số không thể bằng 0.");
            }
            this.tuso = tuso;
            this.mauso = mauso;
            RutGon();
        }

        // Hàm hủy
        ~PhanSo()
        {
            // Dọn dẹp tài nguyên nếu có
        }

        // Tìm ước chung lớn nhất (UCLN)
        private static int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Tối giản phân số
        public void RutGon()
        {
            if (mauso < 0)
            {
                tuso = -tuso;
                mauso = -mauso;
            }
            int ucln = UCLN(tuso, mauso);
            if (ucln > 1)
            {
                tuso /= ucln;
                mauso /= ucln;
            }
        }

        // Nhập phân số từ Console
        public void Nhap()
        {
            Console.Write("Nhập tử số: ");
            while (!int.TryParse(Console.ReadLine(), out tuso))
            {
                Console.Write("Vui lòng nhập số nguyên hợp lệ cho tử số: ");
            }

            Console.Write("Nhập mẫu số (khác 0): ");
            while (!int.TryParse(Console.ReadLine(), out mauso) || mauso == 0)
            {
                Console.Write("Mẫu số phải là số nguyên khác 0. Nhập lại: ");
            }

            RutGon();
        }

        // Xuất phân số ra Console
        public void Xuat()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            if (mauso == 1)
                return $"{tuso}";
            if (tuso == 0)
                return "0";
            return $"{tuso}/{mauso}";
        }

        // Các phép toán cộng, trừ, nhân, chia
        public PhanSo Cong(PhanSo ps)
        {
            int tu = this.tuso * ps.mauso + ps.tuso * this.mauso;
            int mau = this.mauso * ps.mauso;
            return new PhanSo(tu, mau);
        }

        public PhanSo Tru(PhanSo ps)
        {
            int tu = this.tuso * ps.mauso - ps.tuso * this.mauso;
            int mau = this.mauso * ps.mauso;
            return new PhanSo(tu, mau);
        }

        public PhanSo Nhan(PhanSo ps)
        {
            int tu = this.tuso * ps.tuso;
            int mau = this.mauso * ps.mauso;
            return new PhanSo(tu, mau);
        }

        public PhanSo Chia(PhanSo ps)
        {
            if (ps.tuso == 0)
            {
                throw new DivideByZeroException("Không thể chia cho phân số có tử số bằng 0.");
            }
            int tu = this.tuso * ps.mauso;
            int mau = this.mauso * ps.tuso;
            return new PhanSo(tu, mau);
        }

        // Nạp chồng toán tử
        public static PhanSo operator +(PhanSo a, PhanSo b) => a.Cong(b);
        public static PhanSo operator -(PhanSo a, PhanSo b) => a.Tru(b);
        public static PhanSo operator *(PhanSo a, PhanSo b) => a.Nhan(b);
        public static PhanSo operator /(PhanSo a, PhanSo b) => a.Chia(b);

        // Phương thức tĩnh tính và in kết quả 2 phân số
        public static void TinhVaInKetQua(PhanSo obj1, PhanSo obj2)
        {
            Console.WriteLine($"Phân số 1: {obj1}");
            Console.WriteLine($"Phân số 2: {obj2}");
            Console.WriteLine($"Tổng (obj1 + obj2)   = {obj1.Cong(obj2)}");
            Console.WriteLine($"Hiệu (obj1 - obj2)   = {obj1.Tru(obj2)}");
            Console.WriteLine($"Tích (obj1 * obj2)   = {obj1.Nhan(obj2)}");
            try
            {
                Console.WriteLine($"Thương (obj1 / obj2) = {obj1.Chia(obj2)}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Thương (obj1 / obj2): {ex.Message}");
            }
        }
    }
}
