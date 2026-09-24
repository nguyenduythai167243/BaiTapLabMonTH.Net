using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Btaplab1.Baitap.Bai1;
using Btaplab1.Baitap.Bai2;
using Btaplab1.Baitap.Bai3;
using Btaplab1.Baitap.Bai4;
using Btaplab1.Baitap.Bai5;

namespace Btaplab1
{
    public partial class Form1 : Form
    {
        private Panel panelHeader = null!;
        private Label lblTitle = null!;
        private Panel panelMenu = null!;
        private Button btnBai1 = null!;
        private Button btnBai2 = null!;
        private Button btnBai3 = null!;
        private Button btnBai4 = null!;
        private Button btnBai5 = null!;
        private Button btnClear = null!;
        private RichTextBox txtOutput = null!;

        private Button btnConsole = null!;

        public Form1()
        {
            InitializeComponent();
            InitializeComponentCustom();
        }

        private void InitializeComponentCustom()
        {
            this.Text = "LAB 01 - BÀI TẬP VỀ NHÀ C# (LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG)";
            this.Size = new Size(950, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.BackColor = Color.FromArgb(245, 247, 250);

            // Header Panel
            panelHeader = new Panel
            {
                Dock = DockStyle.Top,
                Height = 70,
                BackColor = Color.FromArgb(41, 128, 185)
            };
            lblTitle = new Label
            {
                Text = "LAB 01: LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG - BÀI TẬP VỀ NHÀ",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            panelHeader.Controls.Add(lblTitle);

            // Menu Panel Left
            panelMenu = new Panel
            {
                Dock = DockStyle.Left,
                Width = 230,
                BackColor = Color.FromArgb(52, 73, 94),
                Padding = new Padding(10)
            };

            btnBai1 = CreateMenuButton("Bài 1: Phân Số", 10, (s, e) => RunBai1GUI());
            btnBai2 = CreateMenuButton("Bài 2: Sinh Viên", 65, (s, e) => RunBai2GUI());
            btnBai3 = CreateMenuButton("Bài 3: Vận Động Viên", 120, (s, e) => RunBai3GUI());
            btnBai4 = CreateMenuButton("Bài 4: Hành Khách", 175, (s, e) => RunBai4GUI());
            btnBai5 = CreateMenuButton("Bài 5: Hóa Đơn Điện", 230, (s, e) => RunBai5GUI());
            btnClear = CreateMenuButton("Xóa Màn Hình Log", 295, (s, e) => txtOutput.Clear());
            btnClear.BackColor = Color.FromArgb(192, 57, 43);

            btnConsole = CreateMenuButton("Chạy Menu Console", 355, (s, e) =>
            {
                MessageBox.Show("Mở cửa sổ Console để thực hiện menu tương tác nhập xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Lab1Runner.RunConsoleMenu();
            });
            btnConsole.BackColor = Color.FromArgb(39, 174, 96);

            panelMenu.Controls.AddRange(new Control[] { btnBai1, btnBai2, btnBai3, btnBai4, btnBai5, btnClear, btnConsole });

            // Output Text Area
            txtOutput = new RichTextBox
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                BackColor = Color.FromArgb(30, 30, 30),
                ForeColor = Color.FromArgb(236, 240, 241),
                Font = new Font("Consolas", 10.5F),
                Padding = new Padding(10)
            };

            this.Controls.Add(txtOutput);
            this.Controls.Add(panelMenu);
            this.Controls.Add(panelHeader);

            Log("=========================================================================");
            Log("  CHÀO MỪNG BẠN ĐẾN VỚI HỆ THỐNG KIỂM THỬ LAB 01 (BÀI TẬP VỀ NHÀ)        ");
            Log("  Nhấn vào các nút bên trái để chạy từng bài tập tương ứng.             ");
            Log("=========================================================================\n");
        }

        private Button CreateMenuButton(string text, int top, EventHandler onClick)
        {
            Button btn = new Button
            {
                Text = text,
                Top = top,
                Left = 10,
                Width = 210,
                Height = 45,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                BackColor = Color.FromArgb(41, 128, 185),
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btn.FlatAppearance.BorderSize = 0;
            btn.Click += onClick;
            return btn;
        }

        private void Log(string message)
        {
            txtOutput.AppendText(message + "\n");
            txtOutput.SelectionStart = txtOutput.Text.Length;
            txtOutput.ScrollToCaret();
        }

        private void RunBai1GUI()
        {
            Log("\n-------------------------------------------------------------------------");
            Log(">>> BÀI 1: THỰC THI THỬ NGHIỆM LỚP PHÂN SỐ <<<");
            Log("-------------------------------------------------------------------------");

            PhanSo ps1 = new PhanSo(3, 4);
            PhanSo ps2 = new PhanSo(5, 6);

            Log($"Phân số obj1: {ps1}");
            Log($"Phân số obj2: {ps2}");
            Log($"Tổng  (obj1 + obj2) = {ps1.Cong(ps2)}");
            Log($"Hiệu  (obj1 - obj2) = {ps1.Tru(ps2)}");
            Log($"Tích  (obj1 * obj2) = {ps1.Nhan(ps2)}");
            Log($"Thương(obj1 / obj2) = {ps1.Chia(ps2)}");
        }

        private void RunBai2GUI()
        {
            Log("\n-------------------------------------------------------------------------");
            Log(">>> BÀI 2: THỰC THI THỬ NGHIỆM QUẢN LÝ SINH VIÊN <<<");
            Log("-------------------------------------------------------------------------");

            QuanLySinhVien ql = new QuanLySinhVien();
            ql.ThemSinhVien(new SinhVien("Trần Văn Nam", "Nam Định", 2003, 8.8));
            ql.ThemSinhVien(new SinhVien("Nguyễn Thị Hoa", "Hà Nội", 2004, 9.5));
            ql.ThemSinhVien(new SinhVien("Lê Hoàng Anh", "Nam Định", 2002, 9.5));
            ql.ThemSinhVien(new SinhVien("Phạm Minh Tuấn", "Hải Phòng", 2003, 7.2));

            Log("1. Danh sách sinh viên hiện có:");
            foreach (var sv in ql.DanhSach) Log("   " + sv.ToString());

            Log("\n2. Danh sách sinh viên có quê quán ở 'Nam Định':");
            foreach (var sv in ql.TimTheoQueQuan("Nam Định")) Log("   " + sv.ToString());

            Log("\n3. Sinh viên có điểm tổng kết cao nhất:");
            foreach (var sv in ql.TimDiemCaoNhat()) Log("   " + sv.ToString());
        }

        private void RunBai3GUI()
        {
            Log("\n-------------------------------------------------------------------------");
            Log(">>> BÀI 3: THỰC THI THỬ NGHIỆM QUẢN LÝ VẬN ĐỘNG VIÊN <<<");
            Log("-------------------------------------------------------------------------");

            VanDongVien p = new VanDongVien("Nguyen Van A", 22, "Bơi lội", 75.5, 1.85);
            Log("1. Khởi tạo đối tượng p bằng 5 tham số:");
            Log("   " + p.ToString());

            VanDongVien[] ds = new VanDongVien[]
            {
                new VanDongVien("Lê Văn B", 20, "Điền kinh", 68.0, 1.78),
                new VanDongVien("Trần Thị C", 21, "Cầu lông", 55.0, 1.65),
                new VanDongVien("Phạm Văn D", 24, "Bóng rổ", 85.0, 1.95)
            };

            QuanLyVanDongVien ql = new QuanLyVanDongVien { DanhSach = ds };
            Log("\n2. Danh sách VĐV vừa tạo:");
            foreach (var vdv in ql.DanhSach) Log("   " + vdv.ToString());

            ql.SapXepTangDan();
            Log("\n3. Danh sách VĐV đã sắp xếp tăng dần theo chiều cao/cân nặng:");
            foreach (var vdv in ql.DanhSach) Log("   " + vdv.ToString());
        }

        private void RunBai4GUI()
        {
            Log("\n-------------------------------------------------------------------------");
            Log(">>> BÀI 4: THỰC THI THỬ NGHIỆM HÀNH KHÁCH & VÉ MÁY BAY <<<");
            Log("-------------------------------------------------------------------------");

            VeMayBay v1 = new VeMayBay("VN123", "15/10/2026", 1500000);
            VeMayBay v2 = new VeMayBay("VJ456", "20/10/2026", 1200000);
            VeMayBay v3 = new VeMayBay("QH789", "25/10/2026", 2000000);

            HanhKhach hk1 = new HanhKhach("Nguyễn Văn X", "Nam", 30, 2, new[] { v1, v2 });
            HanhKhach hk2 = new HanhKhach("Trần Thị Y", "Nữ", 25, 1, new[] { v3 });
            HanhKhach hk3 = new HanhKhach("Lê Văn Z", "Nam", 40, 3, new[] { v1, v2, v3 });

            QuanLyHanhKhach ql = new QuanLyHanhKhach { DanhSach = new List<HanhKhach> { hk1, hk2, hk3 } };

            Log("1. Danh sách hành khách và tổng tiền vé:");
            foreach (var hk in ql.DanhSach) Log("   " + hk.ToString());

            ql.SapXepGiamDanTongTien();
            Log("\n2. Danh sách hành khách sắp xếp giảm dần theo Tổng tiền:");
            foreach (var hk in ql.DanhSach) Log("   " + hk.ToString());
        }

        private void RunBai5GUI()
        {
            Log("\n-------------------------------------------------------------------------");
            Log(">>> BÀI 5: THỰC THI THỬ NGHIỆM QUẢN LÝ HÓA ĐƠN TIỀN ĐIỆN <<<");
            Log("-------------------------------------------------------------------------");

            QuanLyKhachHang ql = new QuanLyKhachHang();
            ql.ThemHoaDon(new KhachHangVietNam("KH01", "Nguyễn Văn Hùng", new DateTime(2020, 9, 15), 150, 2000, "Sinh hoạt", 100));
            ql.ThemHoaDon(new KhachHangVietNam("KH02", "Công ty Kim Long", new DateTime(2020, 9, 20), 500, 3000, "Kinh doanh", 200));
            ql.ThemHoaDon(new KhachHangNuocNgoai("KH03", "John Smith", new DateTime(2020, 9, 10), 300, 2500, "USA"));
            ql.ThemHoaDon(new KhachHangNuocNgoai("KH04", "Tanaka Hiroshi", new DateTime(2020, 10, 5), 250, 2500, "Japan"));

            Log("1. Toàn bộ danh sách hóa đơn khách hàng:");
            foreach (var kh in ql.DanhSach) Log("   " + kh.ToString());

            var (tongVN, tongNN) = ql.TinhTongSoLuongDien();
            Log($"\n2. Tổng số lượng điện tiêu thụ:");
            Log($"   - Khách hàng Việt Nam:   {tongVN:N0} KW");
            Log($"   - Khách hàng Nước ngoài: {tongNN:N0} KW");

            Log($"\n3. Trung bình thành tiền của khách hàng nước ngoài: {ql.TinhTrungBinhThanhTienNN():N0} VNĐ");

            Log("\n4. Danh sách hóa đơn lập trong tháng 09 năm 2020:");
            foreach (var kh in ql.LayHoaDonThang9Nam2020()) Log("   " + kh.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
