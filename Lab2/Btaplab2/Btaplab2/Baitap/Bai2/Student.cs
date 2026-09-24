using System;
using System.Collections.Generic;
using System.Linq;

namespace Btaplab2.Baitap.Bai2
{
    /// <summary>
    /// Bài 2: Interface Person có 2 phương thức: input(), display()
    /// </summary>
    public interface Person
    {
        void input();
        void display();
    }

    /// <summary>
    /// Lớp Student thực thi giao diện Person và bổ sung thêm:
    /// - String name;
    /// - int Age;
    /// - String nativePlace;
    /// - String id.
    /// Phương thức: tạo, set, get, display()
    /// </summary>
    public class Student : Person
    {
        private string name;
        private int age;
        private string nativePlace;
        private string id;

        // Set, Get properties
        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public string NativePlace
        {
            get => nativePlace;
            set => nativePlace = value;
        }

        public string Id
        {
            get => id;
            set => id = value;
        }

        // Phương thức tạo không tham số
        public Student()
        {
            name = string.Empty;
            age = 0;
            nativePlace = string.Empty;
            id = string.Empty;
        }

        // Phương thức tạo có tham số
        public Student(string id, string name, int age, string nativePlace)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.nativePlace = nativePlace;
        }

        // Phương thức input() từ giao diện Person
        public void input()
        {
            Console.Write("Nhập mã sinh viên (id): ");
            id = Console.ReadLine() ?? string.Empty;

            Console.Write("Nhập họ tên sinh viên: ");
            name = Console.ReadLine() ?? string.Empty;

            Console.Write("Nhập tuổi: ");
            int a;
            while (!int.TryParse(Console.ReadLine(), out a) || a <= 0)
            {
                Console.Write("Tuổi không hợp lệ. Nhập lại: ");
            }
            age = a;

            Console.Write("Nhập quê quán: ");
            nativePlace = Console.ReadLine() ?? string.Empty;
        }

        // Phương thức display() từ giao diện Person
        public void display()
        {
            Console.WriteLine($"Mã SV: {id,-10} | Tên: {name,-20} | Tuổi: {age,-4} | Quê quán: {nativePlace,-15}");
        }

        public override string ToString()
        {
            return $"[{id}] {name} - {age} tuổi - Quê: {nativePlace}";
        }
    }

    /// <summary>
    /// Quản lý danh sách sinh viên cho Bài 2:
    /// 1. Nhập vào một danh sách sinh viên
    /// 2. Hiển thị danh sách sinh viên vừa nhập ra màn hình
    /// 3. Tìm kiếm và đưa ra thông tin của sinh viên có tên là “Nam”
    /// </summary>
    public class QuanLyStudent
    {
        private List<Student> danhSach = new List<Student>();

        public List<Student> DanhSach
        {
            get => danhSach;
            set => danhSach = value;
        }

        // 1. Nhập danh sách sinh viên
        public void NhapDanhSach(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n--- Nhập sinh viên thứ {i + 1} ---");
                Student sv = new Student();
                sv.input();
                danhSach.Add(sv);
            }
        }

        // 2. Hiển thị danh sách sinh viên vừa nhập ra màn hình
        public void HienThiDanhSach()
        {
            if (danhSach.Count == 0)
            {
                Console.WriteLine("Danh sách sinh viên rỗng.");
                return;
            }

            Console.WriteLine("\n--- DANH SÁCH SINH VIÊN ---");
            for (int i = 0; i < danhSach.Count; i++)
            {
                Console.Write($"[{i + 1}] ");
                danhSach[i].display();
            }
        }

        // 3. Tìm kiếm và đưa ra thông tin của sinh viên có tên là “Nam”
        public List<Student> TimKiemTheoTen(string tenCanTim = "Nam")
        {
            if (string.IsNullOrWhiteSpace(tenCanTim)) return new List<Student>();
            string search = tenCanTim.Trim();
            return danhSach.Where(sv =>
            {
                if (string.IsNullOrWhiteSpace(sv.Name)) return false;
                string[] parts = sv.Name.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string lastName = parts.Length > 0 ? parts[parts.Length - 1] : "";
                return lastName.Equals(search, StringComparison.OrdinalIgnoreCase) ||
                       sv.Name.Trim().Equals(search, StringComparison.OrdinalIgnoreCase) ||
                       sv.Name.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0;
            }).ToList();
        }

        public void HienThiSinhVienTenNam()
        {
            Console.WriteLine("\n--- KẾT QUẢ TÌM KIẾM SINH VIÊN CÓ TÊN 'Nam' ---");
            var ketQua = TimKiemTheoTen("Nam");
            if (ketQua.Count == 0)
            {
                Console.WriteLine("Không tìm thấy sinh viên nào có tên 'Nam'.");
                return;
            }

            foreach (var sv in ketQua)
            {
                sv.display();
            }
        }
    }
}
