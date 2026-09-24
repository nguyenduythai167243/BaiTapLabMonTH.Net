namespace Btaplab9
{
    partial class Form1
    {
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpGuided;
        private System.Windows.Forms.Button btnGuided_Main;
        private System.Windows.Forms.Button btnGuided_KH;
        private System.Windows.Forms.Button btnGuided_MH;
        private System.Windows.Forms.Button btnGuided_BH;
        private System.Windows.Forms.Button btnGuided_TK_KH;
        private System.Windows.Forms.Button btnGuided_TK_MH;
        private System.Windows.Forms.GroupBox grpBai1;
        private System.Windows.Forms.Button btnBai1_QuanLyPhong;
        private System.Windows.Forms.Button btnBai1_KhachThuePhong;
        private System.Windows.Forms.GroupBox grpBai2;
        private System.Windows.Forms.Button btnBai2_Main;
        private System.Windows.Forms.Button btnBai2_MonHoc;
        private System.Windows.Forms.Button btnBai2_Diem;
        private System.Windows.Forms.GroupBox grpBai3;
        private System.Windows.Forms.Button btnBai3_MuaHang;
        private System.Windows.Forms.Button btnBai3_ThongKe;
        private System.Windows.Forms.GroupBox grpBai4;
        private System.Windows.Forms.Button btnBai4_Main;
        private System.Windows.Forms.Button btnBai4_DuAn;
        private System.Windows.Forms.Button btnBai4_ThongKeDA;
        private System.Windows.Forms.Button btnBai4_ThongKeNV;
        private System.Windows.Forms.Button btnBai4_TimKiemNV;
        private System.Windows.Forms.Button btnBai4_TimKiemDA;
        private System.Windows.Forms.Button btnThoat;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpGuided = new System.Windows.Forms.GroupBox();
            this.btnGuided_Main = new System.Windows.Forms.Button();
            this.btnGuided_KH = new System.Windows.Forms.Button();
            this.btnGuided_MH = new System.Windows.Forms.Button();
            this.btnGuided_BH = new System.Windows.Forms.Button();
            this.btnGuided_TK_KH = new System.Windows.Forms.Button();
            this.btnGuided_TK_MH = new System.Windows.Forms.Button();
            this.grpBai1 = new System.Windows.Forms.GroupBox();
            this.btnBai1_QuanLyPhong = new System.Windows.Forms.Button();
            this.btnBai1_KhachThuePhong = new System.Windows.Forms.Button();
            this.grpBai2 = new System.Windows.Forms.GroupBox();
            this.btnBai2_Main = new System.Windows.Forms.Button();
            this.btnBai2_MonHoc = new System.Windows.Forms.Button();
            this.btnBai2_Diem = new System.Windows.Forms.Button();
            this.grpBai3 = new System.Windows.Forms.GroupBox();
            this.btnBai3_MuaHang = new System.Windows.Forms.Button();
            this.btnBai3_ThongKe = new System.Windows.Forms.Button();
            this.grpBai4 = new System.Windows.Forms.GroupBox();
            this.btnBai4_Main = new System.Windows.Forms.Button();
            this.btnBai4_DuAn = new System.Windows.Forms.Button();
            this.btnBai4_ThongKeDA = new System.Windows.Forms.Button();
            this.btnBai4_ThongKeNV = new System.Windows.Forms.Button();
            this.btnBai4_TimKiemNV = new System.Windows.Forms.Button();
            this.btnBai4_TimKiemDA = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();

            this.grpGuided.SuspendLayout();
            this.grpBai1.SuspendLayout();
            this.grpBai2.SuspendLayout();
            this.grpBai3.SuspendLayout();
            this.grpBai4.SuspendLayout();
            this.SuspendLayout();

            // lblHeader
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(800, 50);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "MENU TỔNG HỢP TOÀN BỘ BÀI TẬP LAB 9";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // grpGuided
            this.grpGuided.Controls.Add(this.btnGuided_Main);
            this.grpGuided.Controls.Add(this.btnGuided_KH);
            this.grpGuided.Controls.Add(this.btnGuided_MH);
            this.grpGuided.Controls.Add(this.btnGuided_BH);
            this.grpGuided.Controls.Add(this.btnGuided_TK_KH);
            this.grpGuided.Controls.Add(this.btnGuided_TK_MH);
            this.grpGuided.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpGuided.ForeColor = System.Drawing.Color.DarkBlue;
            this.grpGuided.Location = new System.Drawing.Point(30, 55);
            this.grpGuided.Name = "grpGuided";
            this.grpGuided.Size = new System.Drawing.Size(740, 105);
            this.grpGuided.TabIndex = 1;
            this.grpGuided.TabStop = false;
            this.grpGuided.Text = "BÀI HƯỚNG DẪN CHI TIẾT: Quản Lý Bán Hàng (QLBH)";

            // btnGuided_Main
            this.btnGuided_Main.BackColor = System.Drawing.Color.Navy;
            this.btnGuided_Main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuided_Main.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuided_Main.ForeColor = System.Drawing.Color.White;
            this.btnGuided_Main.Location = new System.Drawing.Point(20, 22);
            this.btnGuided_Main.Name = "btnGuided_Main";
            this.btnGuided_Main.Size = new System.Drawing.Size(220, 32);
            this.btnGuided_Main.TabIndex = 0;
            this.btnGuided_Main.Text = "Form Main MDI Bán Hàng";
            this.btnGuided_Main.UseVisualStyleBackColor = false;
            this.btnGuided_Main.Click += new System.EventHandler(this.BtnGuided_Main_Click);

            // btnGuided_KH
            this.btnGuided_KH.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnGuided_KH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuided_KH.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuided_KH.ForeColor = System.Drawing.Color.White;
            this.btnGuided_KH.Location = new System.Drawing.Point(260, 22);
            this.btnGuided_KH.Name = "btnGuided_KH";
            this.btnGuided_KH.Size = new System.Drawing.Size(220, 32);
            this.btnGuided_KH.TabIndex = 1;
            this.btnGuided_KH.Text = "Thông Tin Khách Hàng";
            this.btnGuided_KH.UseVisualStyleBackColor = false;
            this.btnGuided_KH.Click += new System.EventHandler(this.BtnGuided_KH_Click);

            // btnGuided_MH
            this.btnGuided_MH.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuided_MH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuided_MH.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuided_MH.ForeColor = System.Drawing.Color.White;
            this.btnGuided_MH.Location = new System.Drawing.Point(500, 22);
            this.btnGuided_MH.Name = "btnGuided_MH";
            this.btnGuided_MH.Size = new System.Drawing.Size(220, 32);
            this.btnGuided_MH.TabIndex = 2;
            this.btnGuided_MH.Text = "Thông Tin Mặt Hàng";
            this.btnGuided_MH.UseVisualStyleBackColor = false;
            this.btnGuided_MH.Click += new System.EventHandler(this.BtnGuided_MH_Click);

            // btnGuided_BH
            this.btnGuided_BH.BackColor = System.Drawing.Color.Teal;
            this.btnGuided_BH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuided_BH.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuided_BH.ForeColor = System.Drawing.Color.White;
            this.btnGuided_BH.Location = new System.Drawing.Point(20, 60);
            this.btnGuided_BH.Name = "btnGuided_BH";
            this.btnGuided_BH.Size = new System.Drawing.Size(220, 32);
            this.btnGuided_BH.TabIndex = 3;
            this.btnGuided_BH.Text = "Chi Tiết Bán Hàng";
            this.btnGuided_BH.UseVisualStyleBackColor = false;
            this.btnGuided_BH.Click += new System.EventHandler(this.BtnGuided_BH_Click);

            // btnGuided_TK_KH
            this.btnGuided_TK_KH.BackColor = System.Drawing.Color.DarkCyan;
            this.btnGuided_TK_KH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuided_TK_KH.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuided_TK_KH.ForeColor = System.Drawing.Color.White;
            this.btnGuided_TK_KH.Location = new System.Drawing.Point(260, 60);
            this.btnGuided_TK_KH.Name = "btnGuided_TK_KH";
            this.btnGuided_TK_KH.Size = new System.Drawing.Size(220, 32);
            this.btnGuided_TK_KH.TabIndex = 4;
            this.btnGuided_TK_KH.Text = "Tìm Kiếm Khách Hàng";
            this.btnGuided_TK_KH.UseVisualStyleBackColor = false;
            this.btnGuided_TK_KH.Click += new System.EventHandler(this.BtnGuided_TK_KH_Click);

            // btnGuided_TK_MH
            this.btnGuided_TK_MH.BackColor = System.Drawing.Color.CadetBlue;
            this.btnGuided_TK_MH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuided_TK_MH.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuided_TK_MH.ForeColor = System.Drawing.Color.White;
            this.btnGuided_TK_MH.Location = new System.Drawing.Point(500, 60);
            this.btnGuided_TK_MH.Name = "btnGuided_TK_MH";
            this.btnGuided_TK_MH.Size = new System.Drawing.Size(220, 32);
            this.btnGuided_TK_MH.TabIndex = 5;
            this.btnGuided_TK_MH.Text = "Tìm Kiếm Mặt Hàng";
            this.btnGuided_TK_MH.UseVisualStyleBackColor = false;
            this.btnGuided_TK_MH.Click += new System.EventHandler(this.BtnGuided_TK_MH_Click);

            // grpBai1
            this.grpBai1.Controls.Add(this.btnBai1_QuanLyPhong);
            this.grpBai1.Controls.Add(this.btnBai1_KhachThuePhong);
            this.grpBai1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpBai1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.grpBai1.Location = new System.Drawing.Point(30, 168);
            this.grpBai1.Name = "grpBai1";
            this.grpBai1.Size = new System.Drawing.Size(740, 70);
            this.grpBai1.TabIndex = 2;
            this.grpBai1.TabStop = false;
            this.grpBai1.Text = "BÀI TẬP VỀ NHÀ 1: Quản Lý Khách Sạn (QLKhachSan)";

            // btnBai1_QuanLyPhong
            this.btnBai1_QuanLyPhong.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBai1_QuanLyPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBai1_QuanLyPhong.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBai1_QuanLyPhong.ForeColor = System.Drawing.Color.White;
            this.btnBai1_QuanLyPhong.Location = new System.Drawing.Point(40, 22);
            this.btnBai1_QuanLyPhong.Name = "btnBai1_QuanLyPhong";
            this.btnBai1_QuanLyPhong.Size = new System.Drawing.Size(320, 35);
            this.btnBai1_QuanLyPhong.TabIndex = 0;
            this.btnBai1_QuanLyPhong.Text = "Quản Lý Phòng";
            this.btnBai1_QuanLyPhong.UseVisualStyleBackColor = false;
            this.btnBai1_QuanLyPhong.Click += new System.EventHandler(this.BtnBai1_QuanLyPhong_Click);

            // btnBai1_KhachThuePhong
            this.btnBai1_KhachThuePhong.BackColor = System.Drawing.Color.Teal;
            this.btnBai1_KhachThuePhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBai1_KhachThuePhong.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBai1_KhachThuePhong.ForeColor = System.Drawing.Color.White;
            this.btnBai1_KhachThuePhong.Location = new System.Drawing.Point(380, 22);
            this.btnBai1_KhachThuePhong.Name = "btnBai1_KhachThuePhong";
            this.btnBai1_KhachThuePhong.Size = new System.Drawing.Size(320, 35);
            this.btnBai1_KhachThuePhong.TabIndex = 1;
            this.btnBai1_KhachThuePhong.Text = "Khách Thuê Phòng";
            this.btnBai1_KhachThuePhong.UseVisualStyleBackColor = false;
            this.btnBai1_KhachThuePhong.Click += new System.EventHandler(this.BtnBai1_KhachThuePhong_Click);

            // grpBai2
            this.grpBai2.Controls.Add(this.btnBai2_Main);
            this.grpBai2.Controls.Add(this.btnBai2_MonHoc);
            this.grpBai2.Controls.Add(this.btnBai2_Diem);
            this.grpBai2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpBai2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.grpBai2.Location = new System.Drawing.Point(30, 245);
            this.grpBai2.Name = "grpBai2";
            this.grpBai2.Size = new System.Drawing.Size(740, 70);
            this.grpBai2.TabIndex = 3;
            this.grpBai2.TabStop = false;
            this.grpBai2.Text = "BÀI TẬP VỀ NHÀ 2: Quản Lý Điểm & Môn Học (QLDiem)";

            // btnBai2_Main
            this.btnBai2_Main.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnBai2_Main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBai2_Main.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBai2_Main.ForeColor = System.Drawing.Color.White;
            this.btnBai2_Main.Location = new System.Drawing.Point(20, 22);
            this.btnBai2_Main.Name = "btnBai2_Main";
            this.btnBai2_Main.Size = new System.Drawing.Size(220, 35);
            this.btnBai2_Main.TabIndex = 0;
            this.btnBai2_Main.Text = "Form Main (Bài 2)";
            this.btnBai2_Main.UseVisualStyleBackColor = false;
            this.btnBai2_Main.Click += new System.EventHandler(this.BtnBai2_Main_Click);

            // btnBai2_MonHoc
            this.btnBai2_MonHoc.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBai2_MonHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBai2_MonHoc.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBai2_MonHoc.ForeColor = System.Drawing.Color.White;
            this.btnBai2_MonHoc.Location = new System.Drawing.Point(260, 22);
            this.btnBai2_MonHoc.Name = "btnBai2_MonHoc";
            this.btnBai2_MonHoc.Size = new System.Drawing.Size(220, 35);
            this.btnBai2_MonHoc.TabIndex = 1;
            this.btnBai2_MonHoc.Text = "Quản Lý Môn Học";
            this.btnBai2_MonHoc.UseVisualStyleBackColor = false;
            this.btnBai2_MonHoc.Click += new System.EventHandler(this.BtnBai2_MonHoc_Click);

            // btnBai2_Diem
            this.btnBai2_Diem.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBai2_Diem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBai2_Diem.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBai2_Diem.ForeColor = System.Drawing.Color.White;
            this.btnBai2_Diem.Location = new System.Drawing.Point(500, 22);
            this.btnBai2_Diem.Name = "btnBai2_Diem";
            this.btnBai2_Diem.Size = new System.Drawing.Size(220, 35);
            this.btnBai2_Diem.TabIndex = 2;
            this.btnBai2_Diem.Text = "Quản Lý Điểm";
            this.btnBai2_Diem.UseVisualStyleBackColor = false;
            this.btnBai2_Diem.Click += new System.EventHandler(this.BtnBai2_Diem_Click);

            // grpBai3
            this.grpBai3.Controls.Add(this.btnBai3_MuaHang);
            this.grpBai3.Controls.Add(this.btnBai3_ThongKe);
            this.grpBai3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpBai3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.grpBai3.Location = new System.Drawing.Point(30, 322);
            this.grpBai3.Name = "grpBai3";
            this.grpBai3.Size = new System.Drawing.Size(740, 70);
            this.grpBai3.TabIndex = 4;
            this.grpBai3.TabStop = false;
            this.grpBai3.Text = "BÀI TẬP VỀ NHÀ 3: Quản Lý Kinh Doanh (QLKD)";

            // btnBai3_MuaHang
            this.btnBai3_MuaHang.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnBai3_MuaHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBai3_MuaHang.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBai3_MuaHang.ForeColor = System.Drawing.Color.White;
            this.btnBai3_MuaHang.Location = new System.Drawing.Point(40, 22);
            this.btnBai3_MuaHang.Name = "btnBai3_MuaHang";
            this.btnBai3_MuaHang.Size = new System.Drawing.Size(320, 35);
            this.btnBai3_MuaHang.TabIndex = 0;
            this.btnBai3_MuaHang.Text = "Quản Lý Mua Hàng";
            this.btnBai3_MuaHang.UseVisualStyleBackColor = false;
            this.btnBai3_MuaHang.Click += new System.EventHandler(this.BtnBai3_MuaHang_Click);

            // btnBai3_ThongKe
            this.btnBai3_ThongKe.BackColor = System.Drawing.Color.Chocolate;
            this.btnBai3_ThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBai3_ThongKe.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBai3_ThongKe.ForeColor = System.Drawing.Color.White;
            this.btnBai3_ThongKe.Location = new System.Drawing.Point(380, 22);
            this.btnBai3_ThongKe.Name = "btnBai3_ThongKe";
            this.btnBai3_ThongKe.Size = new System.Drawing.Size(320, 35);
            this.btnBai3_ThongKe.TabIndex = 1;
            this.btnBai3_ThongKe.Text = "Thống Kê Hàng Mua";
            this.btnBai3_ThongKe.UseVisualStyleBackColor = false;
            this.btnBai3_ThongKe.Click += new System.EventHandler(this.BtnBai3_ThongKe_Click);

            // grpBai4
            this.grpBai4.Controls.Add(this.btnBai4_Main);
            this.grpBai4.Controls.Add(this.btnBai4_DuAn);
            this.grpBai4.Controls.Add(this.btnBai4_ThongKeDA);
            this.grpBai4.Controls.Add(this.btnBai4_ThongKeNV);
            this.grpBai4.Controls.Add(this.btnBai4_TimKiemNV);
            this.grpBai4.Controls.Add(this.btnBai4_TimKiemDA);
            this.grpBai4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpBai4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.grpBai4.Location = new System.Drawing.Point(30, 398);
            this.grpBai4.Name = "grpBai4";
            this.grpBai4.Size = new System.Drawing.Size(740, 105);
            this.grpBai4.TabIndex = 5;
            this.grpBai4.TabStop = false;
            this.grpBai4.Text = "BÀI TẬP VỀ NHÀ 4: Quản Lý Dự Án Viện CNTT (QLDA)";

            // btnBai4_Main
            this.btnBai4_Main.BackColor = System.Drawing.Color.DarkBlue;
            this.btnBai4_Main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBai4_Main.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBai4_Main.ForeColor = System.Drawing.Color.White;
            this.btnBai4_Main.Location = new System.Drawing.Point(20, 22);
            this.btnBai4_Main.Name = "btnBai4_Main";
            this.btnBai4_Main.Size = new System.Drawing.Size(220, 32);
            this.btnBai4_Main.TabIndex = 0;
            this.btnBai4_Main.Text = "Form Main (Bài 4)";
            this.btnBai4_Main.UseVisualStyleBackColor = false;
            this.btnBai4_Main.Click += new System.EventHandler(this.BtnBai4_Main_Click);

            // btnBai4_DuAn
            this.btnBai4_DuAn.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBai4_DuAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBai4_DuAn.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBai4_DuAn.ForeColor = System.Drawing.Color.White;
            this.btnBai4_DuAn.Location = new System.Drawing.Point(260, 22);
            this.btnBai4_DuAn.Name = "btnBai4_DuAn";
            this.btnBai4_DuAn.Size = new System.Drawing.Size(220, 32);
            this.btnBai4_DuAn.TabIndex = 1;
            this.btnBai4_DuAn.Text = "Quản Lý Dự Án";
            this.btnBai4_DuAn.UseVisualStyleBackColor = false;
            this.btnBai4_DuAn.Click += new System.EventHandler(this.BtnBai4_DuAn_Click);

            // btnBai4_ThongKeDA
            this.btnBai4_ThongKeDA.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBai4_ThongKeDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBai4_ThongKeDA.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBai4_ThongKeDA.ForeColor = System.Drawing.Color.White;
            this.btnBai4_ThongKeDA.Location = new System.Drawing.Point(500, 22);
            this.btnBai4_ThongKeDA.Name = "btnBai4_ThongKeDA";
            this.btnBai4_ThongKeDA.Size = new System.Drawing.Size(220, 32);
            this.btnBai4_ThongKeDA.TabIndex = 2;
            this.btnBai4_ThongKeDA.Text = "Thống Kê Dự Án";
            this.btnBai4_ThongKeDA.UseVisualStyleBackColor = false;
            this.btnBai4_ThongKeDA.Click += new System.EventHandler(this.BtnBai4_ThongKeDA_Click);

            // btnBai4_ThongKeNV
            this.btnBai4_ThongKeNV.BackColor = System.Drawing.Color.DarkGreen;
            this.btnBai4_ThongKeNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBai4_ThongKeNV.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBai4_ThongKeNV.ForeColor = System.Drawing.Color.White;
            this.btnBai4_ThongKeNV.Location = new System.Drawing.Point(20, 60);
            this.btnBai4_ThongKeNV.Name = "btnBai4_ThongKeNV";
            this.btnBai4_ThongKeNV.Size = new System.Drawing.Size(220, 32);
            this.btnBai4_ThongKeNV.TabIndex = 3;
            this.btnBai4_ThongKeNV.Text = "Thống Kê Nhân Viên";
            this.btnBai4_ThongKeNV.UseVisualStyleBackColor = false;
            this.btnBai4_ThongKeNV.Click += new System.EventHandler(this.BtnBai4_ThongKeNV_Click);

            // btnBai4_TimKiemNV
            this.btnBai4_TimKiemNV.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnBai4_TimKiemNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBai4_TimKiemNV.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBai4_TimKiemNV.ForeColor = System.Drawing.Color.White;
            this.btnBai4_TimKiemNV.Location = new System.Drawing.Point(260, 60);
            this.btnBai4_TimKiemNV.Name = "btnBai4_TimKiemNV";
            this.btnBai4_TimKiemNV.Size = new System.Drawing.Size(220, 32);
            this.btnBai4_TimKiemNV.TabIndex = 4;
            this.btnBai4_TimKiemNV.Text = "Tìm Kiếm Nhân Viên";
            this.btnBai4_TimKiemNV.UseVisualStyleBackColor = false;
            this.btnBai4_TimKiemNV.Click += new System.EventHandler(this.BtnBai4_TimKiemNV_Click);

            // btnBai4_TimKiemDA
            this.btnBai4_TimKiemDA.BackColor = System.Drawing.Color.Sienna;
            this.btnBai4_TimKiemDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBai4_TimKiemDA.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBai4_TimKiemDA.ForeColor = System.Drawing.Color.White;
            this.btnBai4_TimKiemDA.Location = new System.Drawing.Point(500, 60);
            this.btnBai4_TimKiemDA.Name = "btnBai4_TimKiemDA";
            this.btnBai4_TimKiemDA.Size = new System.Drawing.Size(220, 32);
            this.btnBai4_TimKiemDA.TabIndex = 5;
            this.btnBai4_TimKiemDA.Text = "Tìm Kiếm Dự Án";
            this.btnBai4_TimKiemDA.UseVisualStyleBackColor = false;
            this.btnBai4_TimKiemDA.Click += new System.EventHandler(this.BtnBai4_TimKiemDA_Click);

            // btnThoat
            this.btnThoat.BackColor = System.Drawing.Color.Crimson;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(300, 515);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(200, 38);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát Chương Trình";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grpBai4);
            this.Controls.Add(this.grpBai3);
            this.Controls.Add(this.grpBai2);
            this.Controls.Add(this.grpBai1);
            this.Controls.Add(this.grpGuided);
            this.Controls.Add(this.lblHeader);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Quản Lý Tất Cả Bài Tập Lab 9";
            this.grpGuided.ResumeLayout(false);
            this.grpBai1.ResumeLayout(false);
            this.grpBai2.ResumeLayout(false);
            this.grpBai3.ResumeLayout(false);
            this.grpBai4.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
