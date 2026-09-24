using System;
using System.Collections.Generic;
using System.Linq;

namespace Btaplab2.Baitap.Bai3
{
    /// <summary>
    /// Bài 3: Ma trận số thực n hàng, m cột (với n, m là hai số nguyên dương)
    /// 1. Nhập một ma trận số thực gồm n hàng, m cột
    /// 2. Hiển thị ma trận
    /// 3. Tìm số âm nhỏ nhất của ma trận
    /// 4. Sắp xếp từng cột của ma trận theo thứ tự tăng dần
    /// 5. Nhập số nguyên dương k, xóa cột thứ k của ma trận nếu có
    /// 6. Tính trung bình cộng các phần tử có giá trị chẵn trong ma trận
    /// </summary>
    public class MaTranChuNhat
    {
        private int soHang;
        private int soCot;
        private double[,] maTran;

        public int SoHang => soHang;
        public int SoCot => soCot;
        public double[,] Data => maTran;

        public MaTranChuNhat()
        {
            soHang = 0;
            soCot = 0;
            maTran = new double[0, 0];
        }

        public MaTranChuNhat(int n, int m)
        {
            soHang = n;
            soCot = m;
            maTran = new double[n, m];
        }

        public MaTranChuNhat(double[,] data)
        {
            soHang = data.GetLength(0);
            soCot = data.GetLength(1);
            maTran = (double[,])data.Clone();
        }

        // 1. Nhập ma trận n hàng, m cột
        public void Nhap()
        {
            Console.Write("Nhập số hàng n (nguyên dương): ");
            while (!int.TryParse(Console.ReadLine(), out soHang) || soHang <= 0)
            {
                Console.Write("Số hàng phải là số nguyên dương. Nhập lại: ");
            }

            Console.Write("Nhập số cột m (nguyên dương): ");
            while (!int.TryParse(Console.ReadLine(), out soCot) || soCot <= 0)
            {
                Console.Write("Số cột phải là số nguyên dương. Nhập lại: ");
            }

            maTran = new double[soHang, soCot];
            Console.WriteLine("Nhập các phần tử của ma trận:");
            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
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
            if (soHang == 0 || soCot == 0)
            {
                Console.WriteLine("Ma trận rỗng.");
                return;
            }

            Console.WriteLine($"\n--- MA TRẬN ({soHang} x {soCot}) ---");
            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    Console.Write($"{maTran[i, j],8:F2} ");
                }
                Console.WriteLine();
            }
        }

        // 3. Tìm số âm nhỏ nhất của ma trận (giá trị âm bé nhất)
        public double? TimSoAmNhoNhat()
        {
            double? minAm = null;
            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    if (maTran[i, j] < 0)
                    {
                        if (!minAm.HasValue || maTran[i, j] < minAm.Value)
                        {
                            minAm = maTran[i, j];
                        }
                    }
                }
            }
            return minAm;
        }

        // 4. Sắp xếp từng cột của ma trận theo thứ tự tăng dần
        public void SapXepTungCotTangDan()
        {
            for (int j = 0; j < soCot; j++)
            {
                double[] cot = new double[soHang];
                for (int i = 0; i < soHang; i++)
                {
                    cot[i] = maTran[i, j];
                }

                Array.Sort(cot);

                for (int i = 0; i < soHang; i++)
                {
                    maTran[i, j] = cot[i];
                }
            }
        }

        // 5. Xóa cột thứ k của ma trận (k là số nguyên dương, tính từ 1)
        public bool XoaCot(int k)
        {
            if (k < 1 || k > soCot)
            {
                return false;
            }

            int indexCanXoa = k - 1;
            double[,] maTranMoi = new double[soHang, soCot - 1];

            for (int i = 0; i < soHang; i++)
            {
                int cotMoi = 0;
                for (int j = 0; j < soCot; j++)
                {
                    if (j == indexCanXoa) continue;
                    maTranMoi[i, cotMoi] = maTran[i, j];
                    cotMoi++;
                }
            }

            maTran = maTranMoi;
            soCot--;
            return true;
        }

        // 6. Tính trung bình cộng các phần tử có giá trị chẵn trong ma trận
        public double? TinhTrungBinhCongGiaTriChan()
        {
            double tong = 0;
            int dem = 0;

            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    double val = maTran[i, j];
                    if (Math.Abs(val % 1) < 1e-9)
                    {
                        long intVal = (long)Math.Round(val);
                        if (intVal % 2 == 0)
                        {
                            tong += val;
                            dem++;
                        }
                    }
                }
            }

            if (dem == 0) return null;
            return tong / dem;
        }
    }
}
