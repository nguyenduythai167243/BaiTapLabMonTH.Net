using System;

namespace Btaplab2.Baitap.Bai1
{
    /// <summary>
    /// Bài 1: Tạo lớp trừu tượng SinhVienUneti gồm:
    /// - Hai thuộc tính: hoTen, nganh
    /// - Phương thức trừu tượng: getDiem()
    /// - Phương thức: getXepLoaiHL() để xếp loại học lực
    /// - Phương thức: xuat() để xuất họ tên, ngành, điểm và học lực ra màn hình
    /// </summary>
    public abstract class SinhVienUneti
    {
        private string hoTen;
        private string nganh;

        // Properties
        public string HoTen
        {
            get => hoTen;
            set => hoTen = value;
        }

        public string Nganh
        {
            get => nganh;
            set => nganh = value;
        }

        // Constructors
        public SinhVienUneti()
        {
            hoTen = string.Empty;
            nganh = string.Empty;
        }

        public SinhVienUneti(string hoTen, string nganh)
        {
            this.hoTen = hoTen;
            this.nganh = nganh;
        }

        // Phương thức trừu tượng tính điểm
        public abstract double getDiem();

        // Phương thức xếp loại học lực
        public virtual string getXepLoaiHL()
        {
            double diem = getDiem();
            if (diem >= 9.0)
                return "Xuất sắc";
            if (diem >= 8.0)
                return "Giỏi";
            if (diem >= 6.5)
                return "Khá";
            if (diem >= 5.0)
                return "Trung bình";
            return "Yếu";
        }

        // Phương thức xuất thông tin sinh viên
        public virtual void xuat()
        {
            Console.WriteLine($"Họ tên: {hoTen,-22} | Ngành: {nganh,-18} | Điểm: {getDiem(),5:F2} | Học lực: {getXepLoaiHL()}");
        }

        public override string ToString()
        {
            return $"{hoTen} - {nganh} - Điểm: {getDiem():F2} - Học lực: {getXepLoaiHL()}";
        }
    }

    /// <summary>
    /// Lớp con SinhVienIT kế thừa SinhVienUneti để cài đặt phương thức trừu tượng getDiem()
    /// </summary>
    public class SinhVienIT : SinhVienUneti
    {
        private double diemJava;
        private double diemCSharp;
        private double diemHtmlCss;

        public double DiemJava { get => diemJava; set => diemJava = value; }
        public double DiemCSharp { get => diemCSharp; set => diemCSharp = value; }
        public double DiemHtmlCss { get => diemHtmlCss; set => diemHtmlCss = value; }

        public SinhVienIT() : base()
        {
            Nganh = "Công nghệ thông tin";
        }

        public SinhVienIT(string hoTen, double diemJava, double diemCSharp, double diemHtmlCss)
            : base(hoTen, "Công nghệ thông tin")
        {
            this.diemJava = diemJava;
            this.diemCSharp = diemCSharp;
            this.diemHtmlCss = diemHtmlCss;
        }

        public override double getDiem()
        {
            return (diemJava * 2 + diemCSharp * 2 + diemHtmlCss) / 5.0;
        }

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine($"   (Chi tiết điểm: Java = {diemJava:F1}, C# = {diemCSharp:F1}, HTML/CSS = {diemHtmlCss:F1})");
        }
    }

    /// <summary>
    /// Lớp con SinhVienKinhTe kế thừa SinhVienUneti
    /// </summary>
    public class SinhVienKinhTe : SinhVienUneti
    {
        private double diemMarketing;
        private double diemSales;

        public double DiemMarketing { get => diemMarketing; set => diemMarketing = value; }
        public double DiemSales { get => diemSales; set => diemSales = value; }

        public SinhVienKinhTe() : base()
        {
            Nganh = "Quản trị kinh doanh";
        }

        public SinhVienKinhTe(string hoTen, double diemMarketing, double diemSales)
            : base(hoTen, "Quản trị kinh doanh")
        {
            this.diemMarketing = diemMarketing;
            this.diemSales = diemSales;
        }

        public override double getDiem()
        {
            return (diemMarketing * 2 + diemSales) / 3.0;
        }

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine($"   (Chi tiết điểm: Marketing = {diemMarketing:F1}, Sales = {diemSales:F1})");
        }
    }
}
