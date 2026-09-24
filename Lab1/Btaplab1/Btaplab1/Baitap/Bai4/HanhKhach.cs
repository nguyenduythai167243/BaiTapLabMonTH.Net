using System;
using System.Collections.Generic;
using System.Linq;

namespace Btaplab1.Baitap.Bai4
{
    /// <summary>
    /// Bài 4 - Lớp Hanhkhach kế thừa lớp Nguoi
    /// Thuộc tính bổ sung: Vemaybay[] ve; int soluong;
    /// Phương thức:
    /// - Hàm tạo
    /// - Hủy
    /// - Nhập
    /// - Xuất
    /// - tongtien(): trả về Tổng số tiền phải trả của hành khách
    /// </summary>
    public class HanhKhach : Nguoi
    {
        private VeMayBay[] ve;
        private int soluong;

        // Properties
        public VeMayBay[] Ve
        {
            get => ve;
            set => ve = value;
        }

        public int SoLuong
        {
            get => soluong;
            set => soluong = value;
        }

        // Hàm tạo không tham số
        public HanhKhach() : base()
        {
            soluong = 0;
            ve = Array.Empty<VeMayBay>();
        }

        // Hàm tạo có tham số
        public HanhKhach(string hoten, string gioitinh, int tuoi, int soluong, VeMayBay[] ve) 
            : base(hoten, gioitinh, tuoi)
        {
            this.soluong = soluong;
            this.ve = ve;
        }

        // Hàm hủy
        ~HanhKhach()
        {
            // Dọn dẹp tài nguyên
        }

        // Nhập
        public override void Nhap()
        {
            base.Nhap();

            Console.Write("Nhập số lượng vé đã mua: ");
            int sl;
            while (!int.TryParse(Console.ReadLine(), out sl) || sl < 0)
            {
                Console.Write("Số lượng vé không hợp lệ. Nhập lại: ");
            }
            soluong = sl;

            ve = new VeMayBay[soluong];
            for (int i = 0; i < soluong; i++)
            {
                Console.WriteLine($"  * Nhập thông tin vé thứ {i + 1}:");
                ve[i] = new VeMayBay();
                ve[i].Nhap();
            }
        }

        // Xuất
        public override void Xuat()
        {
            Console.WriteLine("------------------------------------------------------------");
            base.Xuat();
            Console.WriteLine($"Số lượng vé đã mua: {soluong}");
            if (soluong > 0 && ve != null)
            {
                Console.WriteLine("Chi tiết các vé:");
                for (int i = 0; i < soluong; i++)
                {
                    Console.Write($"  [{i + 1}] ");
                    ve[i].Xuat();
                }
            }
            Console.WriteLine($"=> TỔNG TIỀN PHẢI TRẢ: {tongtien():N0} VNĐ");
        }

        // tongtien(): trả về Tổng số tiền phải trả của hành khách
        public double tongtien()
        {
            if (ve == null || soluong == 0) return 0.0;
            double tong = 0.0;
            foreach (var item in ve)
            {
                if (item != null)
                {
                    tong += item.getgiave();
                }
            }
            return tong;
        }

        public override string ToString()
        {
            return $"{hoten} - {tuoi} tuổi - Mua: {soluong} vé - Tổng tiền: {tongtien():N0} VNĐ";
        }
    }

    /// <summary>
    /// Quản lý danh sách hành khách cho chương trình chính Bài 4:
    /// - Nhập vào 1 danh sách n hành khách
    /// - Hiển thị danh sách hành khách và số tiền phải trả tương ứng của mỗi khách hàng
    /// - Sắp xếp danh sách hành khách theo chiều giảm dần của Tổng tiền
    /// </summary>
    public class QuanLyHanhKhach
    {
        private List<HanhKhach> danhSach = new List<HanhKhach>();

        public List<HanhKhach> DanhSach
        {
            get => danhSach;
            set => danhSach = value;
        }

        public void NhapDanhSach(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n=== NHẬP HÀNH KHÁCH THỨ {i + 1} ===");
                HanhKhach hk = new HanhKhach();
                hk.Nhap();
                danhSach.Add(hk);
            }
        }

        public void HienThiDanhSach()
        {
            if (danhSach.Count == 0)
            {
                Console.WriteLine("Danh sách hành khách rỗng.");
                return;
            }

            Console.WriteLine("\n================= DANH SÁCH HÀNH KHÁCH =================");
            foreach (var hk in danhSach)
            {
                hk.Xuat();
            }
        }

        // Sắp xếp danh sách theo chiều giảm dần của Tổng tiền
        public void SapXepGiamDanTongTien()
        {
            danhSach = danhSach.OrderByDescending(hk => hk.tongtien()).ToList();
        }
    }
}
