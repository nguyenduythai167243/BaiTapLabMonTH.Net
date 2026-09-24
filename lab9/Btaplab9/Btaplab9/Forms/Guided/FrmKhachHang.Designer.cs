namespace Btaplab9.Forms.Guided
{
    partial class FrmKhachHang
    {
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox group_chitiet;
        private System.Windows.Forms.Label lbl_makh;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.Label lbl_hoten;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label lbl_gioitinh;
        private System.Windows.Forms.ComboBox combo_gioitinh;
        private System.Windows.Forms.Label lbl_diachi;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label lbl_dienthoai;
        private System.Windows.Forms.TextBox txt_dienthoai;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_timkiem;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.GroupBox group_danhsach;
        private System.Windows.Forms.ListView listview_khachhang;
        private System.Windows.Forms.ColumnHeader colMaKH;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colGioiTinh;
        private System.Windows.Forms.ColumnHeader colDiaChi;
        private System.Windows.Forms.ColumnHeader colDienThoai;

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
            this.lbl_title = new System.Windows.Forms.Label();
            this.group_chitiet = new System.Windows.Forms.GroupBox();
            this.lbl_makh = new System.Windows.Forms.Label();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.lbl_hoten = new System.Windows.Forms.Label();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.lbl_gioitinh = new System.Windows.Forms.Label();
            this.combo_gioitinh = new System.Windows.Forms.ComboBox();
            this.lbl_diachi = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.lbl_dienthoai = new System.Windows.Forms.Label();
            this.txt_dienthoai = new System.Windows.Forms.TextBox();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_timkiem = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.group_danhsach = new System.Windows.Forms.GroupBox();
            this.listview_khachhang = new System.Windows.Forms.ListView();
            this.colMaKH = new System.Windows.Forms.ColumnHeader();
            this.colHoTen = new System.Windows.Forms.ColumnHeader();
            this.colGioiTinh = new System.Windows.Forms.ColumnHeader();
            this.colDiaChi = new System.Windows.Forms.ColumnHeader();
            this.colDienThoai = new System.Windows.Forms.ColumnHeader();

            this.group_chitiet.SuspendLayout();
            this.group_danhsach.SuspendLayout();
            this.SuspendLayout();

            // lbl_title
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_title.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.ForeColor = System.Drawing.Color.Navy;
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(720, 50);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "THÔNG TIN KHÁCH HÀNG";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // group_chitiet
            this.group_chitiet.Controls.Add(this.lbl_makh);
            this.group_chitiet.Controls.Add(this.txt_makh);
            this.group_chitiet.Controls.Add(this.lbl_hoten);
            this.group_chitiet.Controls.Add(this.txt_hoten);
            this.group_chitiet.Controls.Add(this.lbl_gioitinh);
            this.group_chitiet.Controls.Add(this.combo_gioitinh);
            this.group_chitiet.Controls.Add(this.lbl_diachi);
            this.group_chitiet.Controls.Add(this.txt_diachi);
            this.group_chitiet.Controls.Add(this.lbl_dienthoai);
            this.group_chitiet.Controls.Add(this.txt_dienthoai);
            this.group_chitiet.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.group_chitiet.Location = new System.Drawing.Point(20, 55);
            this.group_chitiet.Name = "group_chitiet";
            this.group_chitiet.Size = new System.Drawing.Size(680, 130);
            this.group_chitiet.TabIndex = 1;
            this.group_chitiet.TabStop = false;
            this.group_chitiet.Text = "Thông tin chi tiết khách hàng";

            // lbl_makh
            this.lbl_makh.Location = new System.Drawing.Point(20, 25);
            this.lbl_makh.Name = "lbl_makh";
            this.lbl_makh.Size = new System.Drawing.Size(90, 20);
            this.lbl_makh.Text = "Mã KH:";

            // txt_makh
            this.txt_makh.Location = new System.Drawing.Point(110, 22);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(200, 21);

            // lbl_hoten
            this.lbl_hoten.Location = new System.Drawing.Point(20, 60);
            this.lbl_hoten.Name = "lbl_hoten";
            this.lbl_hoten.Size = new System.Drawing.Size(90, 20);
            this.lbl_hoten.Text = "Họ tên:";

            // txt_hoten
            this.txt_hoten.Location = new System.Drawing.Point(110, 57);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(200, 21);

            // lbl_gioitinh
            this.lbl_gioitinh.Location = new System.Drawing.Point(20, 95);
            this.lbl_gioitinh.Name = "lbl_gioitinh";
            this.lbl_gioitinh.Size = new System.Drawing.Size(90, 20);
            this.lbl_gioitinh.Text = "Giới tính:";

            // combo_gioitinh
            this.combo_gioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_gioitinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            this.combo_gioitinh.Location = new System.Drawing.Point(110, 92);
            this.combo_gioitinh.Name = "combo_gioitinh";
            this.combo_gioitinh.Size = new System.Drawing.Size(200, 23);
            this.combo_gioitinh.SelectedIndex = 0;

            // lbl_diachi
            this.lbl_diachi.Location = new System.Drawing.Point(360, 25);
            this.lbl_diachi.Name = "lbl_diachi";
            this.lbl_diachi.Size = new System.Drawing.Size(90, 20);
            this.lbl_diachi.Text = "Địa chỉ:";

            // txt_diachi
            this.txt_diachi.Location = new System.Drawing.Point(450, 22);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(210, 21);

            // lbl_dienthoai
            this.lbl_dienthoai.Location = new System.Drawing.Point(360, 60);
            this.lbl_dienthoai.Name = "lbl_dienthoai";
            this.lbl_dienthoai.Size = new System.Drawing.Size(90, 20);
            this.lbl_dienthoai.Text = "Điện thoại:";

            // txt_dienthoai
            this.txt_dienthoai.Location = new System.Drawing.Point(450, 57);
            this.txt_dienthoai.Name = "txt_dienthoai";
            this.txt_dienthoai.Size = new System.Drawing.Size(210, 21);

            // bt_them
            this.bt_them.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_them.Location = new System.Drawing.Point(60, 195);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(90, 30);
            this.bt_them.TabIndex = 2;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);

            // bt_sua
            this.bt_sua.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_sua.Location = new System.Drawing.Point(180, 195);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(90, 30);
            this.bt_sua.TabIndex = 3;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);

            // bt_xoa
            this.bt_xoa.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_xoa.Location = new System.Drawing.Point(300, 195);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(90, 30);
            this.bt_xoa.TabIndex = 4;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);

            // bt_timkiem
            this.bt_timkiem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_timkiem.Location = new System.Drawing.Point(420, 195);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(90, 30);
            this.bt_timkiem.TabIndex = 5;
            this.bt_timkiem.Text = "Tìm kiếm";
            this.bt_timkiem.UseVisualStyleBackColor = true;
            this.bt_timkiem.Click += new System.EventHandler(this.bt_timkiem_Click);

            // bt_thoat
            this.bt_thoat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_thoat.Location = new System.Drawing.Point(540, 195);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(90, 30);
            this.bt_thoat.TabIndex = 6;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);

            // group_danhsach
            this.group_danhsach.Controls.Add(this.listview_khachhang);
            this.group_danhsach.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.group_danhsach.Location = new System.Drawing.Point(20, 235);
            this.group_danhsach.Name = "group_danhsach";
            this.group_danhsach.Size = new System.Drawing.Size(680, 200);
            this.group_danhsach.TabIndex = 7;
            this.group_danhsach.TabStop = false;
            this.group_danhsach.Text = "Danh sách khách hàng";

            // listview_khachhang
            this.listview_khachhang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colMaKH,
                this.colHoTen,
                this.colGioiTinh,
                this.colDiaChi,
                this.colDienThoai
            });
            this.listview_khachhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listview_khachhang.FullRowSelect = true;
            this.listview_khachhang.GridLines = true;
            this.listview_khachhang.Location = new System.Drawing.Point(3, 17);
            this.listview_khachhang.Name = "listview_khachhang";
            this.listview_khachhang.Size = new System.Drawing.Size(674, 180);
            this.listview_khachhang.TabIndex = 0;
            this.listview_khachhang.UseCompatibleStateImageBehavior = false;
            this.listview_khachhang.View = System.Windows.Forms.View.Details;
            this.listview_khachhang.SelectedIndexChanged += new System.EventHandler(this.listview_khachhang_SelectedIndexChanged);

            // colMaKH
            this.colMaKH.Text = "Mã KH";
            this.colMaKH.Width = 90;

            // colHoTen
            this.colHoTen.Text = "Họ tên";
            this.colHoTen.Width = 160;

            // colGioiTinh
            this.colGioiTinh.Text = "Giới tính";
            this.colGioiTinh.Width = 90;

            // colDiaChi
            this.colDiaChi.Text = "Địa chỉ";
            this.colDiaChi.Width = 170;

            // colDienThoai
            this.colDienThoai.Text = "Điện thoại";
            this.colDienThoai.Width = 140;

            // FrmKhachHang
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.group_danhsach);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_timkiem);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.group_chitiet);
            this.Controls.Add(this.lbl_title);
            this.Name = "FrmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKhachHang";
            this.Load += new System.EventHandler(this.FrmKhachHang_Load);
            this.group_chitiet.ResumeLayout(false);
            this.group_chitiet.PerformLayout();
            this.group_danhsach.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
