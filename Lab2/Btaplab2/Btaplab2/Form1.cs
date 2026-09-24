using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Btaplab2.Baitap.Bai1;
using Btaplab2.Baitap.Bai2;
using Btaplab2.Baitap.Bai3;
using Btaplab2.Baitap.Bai4;
using Btaplab2.Baitap.Bai5;

namespace Btaplab2
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
            this.Text = "LAB 02 - BÀI TẬP VỀ NHÀ C# (ABSTRACT CLASS & INTERFACE)";
            this.Size = new Size(950, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.BackColor = Color.FromArgb(245, 247, 250);

            // Header Panel
            panelHeader = new Panel
            {
                Dock = DockStyle.Top,
                Height = 70,
                BackColor = Color.FromArgb(39, 174, 96)
            };
            lblTitle = new Label
            {
                Text = "LAB 02: ABSTRACT CLASS & INTERFACE - BÀI TẬP VỀ NHÀ",
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
                BackColor = Color.FromArgb(44, 62, 80),
                Padding = new Padding(10)
            };

            btnBai1 = CreateMenuButton("Bài 1: SinhVienUneti", 10, (s, e) => RunBai1GUI());
            btnBai2 = CreateMenuButton("Bài 2: Student & Person", 65, (s, e) => RunBai2GUI());
            btnBai3 = CreateMenuButton("Bài 3: Ma Trận N x M", 120, (s, e) => RunBai3GUI());
            btnBai4 = CreateMenuButton("Bài 4: Ma Trận Vuông N", 175, (s, e) => RunBai4GUI());
            btnBai5 = CreateMenuButton("Bài 5: Xử Lý Xâu Ký Tự", 230, (s, e) => RunBai5GUI());
            btnClear = CreateMenuButton("Xóa Màn Hình Log", 295, (s, e) => txtOutput.Clear());
            btnClear.BackColor = Color.FromArgb(192, 57, 43);

            btnConsole = CreateMenuButton("Chạy Menu Console", 355, (s, e) =>
            {
                MessageBox.Show("Mở cửa sổ Console để thực hiện menu tương tác nhập xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Lab2Runner.RunConsoleMenu();
            });
            btnConsole.BackColor = Color.FromArgb(41, 128, 185);

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
            Log("  CHÀO MỪNG BẠN ĐẾN VỚI HỆ THỐNG KIỂM THỬ LAB 02 (BÀI TẬP VỀ NHÀ)        ");
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
                BackColor = Color.FromArgb(39, 174, 96),
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
            Log(">>> BÀI 1: THỰC THI LỚP TRỪU TƯỢNG SinhVienUneti <<<");
            Log("-------------------------------------------------------------------------");

            List<SinhVienUneti> danhSach = new List<SinhVienUneti>
            {
                new SinhVienIT("Nguyễn Văn A", 8.5, 9.0, 7.5),
                new SinhVienIT("Trần Thị B", 6.0, 5.5, 7.0),
                new SinhVienKinhTe("Lê Văn C", 9.0, 8.5),
                new SinhVienKinhTe("Phạm Thị D", 4.5, 5.0)
            };

            Log("Danh sách sinh viên Uneti (IT & Kinh tế):");
            foreach (var sv in danhSach)
            {
                Log("   " + sv.ToString());
            }
        }

        private void RunBai2GUI()
        {
            Log("\n-------------------------------------------------------------------------");
            Log(">>> BÀI 2: THỰC THI INTERFACE Person & LỚP Student <<<");
            Log("-------------------------------------------------------------------------");

            QuanLyStudent ql = new QuanLyStudent();
            ql.DanhSach.Add(new Student("SV01", "Nguyễn Văn Nam", 21, "Nam Định"));
            ql.DanhSach.Add(new Student("SV02", "Trần Thị Mai", 20, "Hà Nội"));
            ql.DanhSach.Add(new Student("SV03", "Phạm Hoài Nam", 22, "Hải Phòng"));
            ql.DanhSach.Add(new Student("SV04", "Lê Văn An", 19, "Đà Nẵng"));

            Log("1. Danh sách sinh viên hiện có:");
            foreach (var sv in ql.DanhSach) Log("   " + sv.ToString());

            Log("\n2. Sinh viên có tên 'Nam':");
            var ketQua = ql.TimKiemTheoTen("Nam");
            foreach (var sv in ketQua) Log("   " + sv.ToString());
        }

        private void RunBai3GUI()
        {
            Log("\n-------------------------------------------------------------------------");
            Log(">>> BÀI 3: THỰC THI MA TRẬN SỐ THỰC N HÀNG, M CỘT <<<");
            Log("-------------------------------------------------------------------------");

            double[,] sample = {
                { 2.5, -4.2, 6.0, -1.8 },
                { -8.5, 4.0, 2.0, 10.0 },
                { 3.0, -1.5, 8.0, 4.0 }
            };

            MaTranChuNhat mt = new MaTranChuNhat(sample);

            Log("1. Ma trận ban đầu (3x4):");
            InMaTranGUI(mt.Data);

            Log($"2. Số âm nhỏ nhất của ma trận: {mt.TimSoAmNhoNhat()}");

            double? tbc = mt.TinhTrungBinhCongGiaTriChan();
            Log($"3. Trung bình cộng các phần tử chẵn: {tbc:F2}");

            Log("\n4. Sau khi xóa cột thứ 2:");
            mt.XoaCot(2);
            InMaTranGUI(mt.Data);

            Log("\n5. Sau khi sắp xếp từng cột tăng dần:");
            mt.SapXepTungCotTangDan();
            InMaTranGUI(mt.Data);
        }

        private void RunBai4GUI()
        {
            Log("\n-------------------------------------------------------------------------");
            Log(">>> BÀI 4: THỰC THI MA TRẬN SỐ THỰC VUÔNG CẤP N <<<");
            Log("-------------------------------------------------------------------------");

            double[,] sample = {
                { -3.0, 15.0, 5.0 },
                { 7.0, -1.5, 30.0 },
                { 10.0, 2.0, -8.0 }
            };

            MaTranVuong mt = new MaTranVuong(sample);

            Log("1. Ma trận vuông cấp 3:");
            InMaTranGUI(mt.Data);

            Log($"2. Tổng các phần tử trên đường chéo phụ: {mt.TinhTongDuongCheoPhu()}");
            Log($"3. Số âm lớn nhất trên đường chéo chính: {mt.TimSoAmLonNhatDuongCheoChinh()}");
            Log($"4. Số phần tử chia hết cho cả 3 và 5 (như 15, 30): {mt.DemPhanTuChiaHetCho3Va5()}");
        }

        private void RunBai5GUI()
        {
            Log("\n-------------------------------------------------------------------------");
            Log(">>> BÀI 5: THỰC THI XỬ LÝ XÂU KÝ TỰ <<<");
            Log("-------------------------------------------------------------------------");

            XuLyChuoi xl = new XuLyChuoi("Lap trinh CSharp va Visual Studio 2022 tai UNETI");

            Log($"Xâu ký tự: \"{xl.NoiDung}\"");
            var (thuong, hoa) = xl.DemChuThuongVaHoa();
            Log($"1. Đếm chữ thường và chữ hoa: {thuong} chữ thường, {hoa} chữ hoa.");
            Log($"2. Số từ trong xâu: {xl.DemSoTu()}");

            var (nguyenAm, phuAm) = xl.DemNguyenAmVaPhuAm();
            Log($"3. Đếm nguyên âm và phụ âm: {nguyenAm} nguyên âm, {phuAm} phụ âm.");

            string subStr = "trinh";
            Log($"4. Số lần xuất hiện của xâu con \"{subStr}\": {xl.DemSoLanXuatHien(subStr)}");
        }

        private void InMaTranGUI(double[,] data)
        {
            int rows = data.GetLength(0);
            int cols = data.GetLength(1);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < rows; i++)
            {
                sb.Append("   ");
                for (int j = 0; j < cols; j++)
                {
                    sb.Append($"{data[i, j],8:F2} ");
                }
                sb.AppendLine();
            }
            Log(sb.ToString().TrimEnd());
        }
    }
}
