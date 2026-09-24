using System;

namespace Btaplab2.Baitap.Bai4
{
    /// <summary>
    /// Bài 4: Ma trận số thực vuông cấp n (với n là số nguyên dương)
    /// 1. Nhập một ma trận số thực vuông cấp n
    /// 2. Hiển thị ma trận
    /// 3. Tính tổng các phần tử nằm trên đường chéo phụ của ma trận
    /// 4. Tìm số âm lớn nhất trên đường chéo chính của ma trận
    /// 5. Đếm các phần tử của ma trận có giá trị chia hết cho 3 và 5
    /// </summary>
    public class MaTranVuong
    {
        private int capN;
        private double[,] maTran;

        public int CapN => capN;
        public double[,] Data => maTran;

        public MaTranVuong()
        {
            capN = 0;
            maTran = new double[0, 0];
        }

        public MaTranVuong(int n)
        {
            capN = n;
            maTran = new double[n, n];
        }

        public MaTranVuong(double[,] data)
        {
            capN = data.GetLength(0);
            maTran = (double[,])data.Clone();
        }

        // 1. Nhập ma trận số thực vuông cấp n
        public void Nhap()
        {
            Console.Write("Nhập cấp n của ma trận vuông (nguyên dương): ");
            while (!int.TryParse(Console.ReadLine(), out capN) || capN <= 0)
            {
                Console.Write("Cấp n phải là số nguyên dương. Nhập lại: ");
            }

            maTran = new double[capN, capN];
            Console.WriteLine($"Nhập các phần tử cho ma trận vuông cấp {capN}:");
            for (int i = 0; i < capN; i++)
            {
                for (int j = 0; j < capN; j++)
                {
                    Console.Write($"Phần tử [{i},{j}]: ");
                    while (!double.TryParse(Console.ReadLine(), out maTran[i, j]))
                    {
                        Console.Write($"Giá trị không hợp lệ. Nhập lại phần tử [{i},{j}]: ");
                    }
                }
            }
        }

        // 2. Hiển thị ma trận
        public void HienThi()
        {
            if (capN == 0)
            {
                Console.WriteLine("Ma trận rỗng.");
                return;
            }

            Console.WriteLine($"\n--- MA TRẬN VUÔNG CẤP {capN} ---");
            for (int i = 0; i < capN; i++)
            {
                for (int j = 0; j < capN; j++)
                {
                    Console.Write($"{maTran[i, j],8:F2} ");
                }
                Console.WriteLine();
            }
        }

        // 3. Tính tổng các phần tử nằm trên đường chéo phụ của ma trận (i + j == capN - 1)
        public double TinhTongDuongCheoPhu()
        {
            double tong = 0.0;
            for (int i = 0; i < capN; i++)
            {
                int j = capN - 1 - i;
                tong += maTran[i, j];
            }
            return tong;
        }

        // 4. Tìm số âm lớn nhất trên đường chéo chính của ma trận (i == j, số âm gần 0 nhất)
        public double? TimSoAmLonNhatDuongCheoChinh()
        {
            double? maxAm = null;
            for (int i = 0; i < capN; i++)
            {
                double val = maTran[i, i];
                if (val < 0)
                {
                    if (!maxAm.HasValue || val > maxAm.Value)
                    {
                        maxAm = val;
                    }
                }
            }
            return maxAm;
        }

        // 5. Đếm các phần tử của ma trận có giá trị chia hết cho 3 và 5 (chia hết cho 15)
        public int DemPhanTuChiaHetCho3Va5()
        {
            int dem = 0;
            for (int i = 0; i < capN; i++)
            {
                for (int j = 0; j < capN; j++)
                {
                    double val = maTran[i, j];
                    if (Math.Abs(val % 1) < 1e-9)
                    {
                        long intVal = (long)Math.Round(val);
                        if (intVal != 0 && intVal % 3 == 0 && intVal % 5 == 0)
                        {
                            dem++;
                        }
                    }
                }
            }
            return dem;
        }
    }
}
