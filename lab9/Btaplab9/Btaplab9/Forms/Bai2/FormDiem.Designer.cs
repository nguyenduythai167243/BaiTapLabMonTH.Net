namespace Btaplab9.Forms.Bai2
{
    partial class FormDiem
    {
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.ComboBox cboMaSV;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Label lblMaMH;
        private System.Windows.Forms.ComboBox cboMaMH;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.ListView lvwDiem;
        private System.Windows.Forms.ColumnHeader colMaSV;
        private System.Windows.Forms.ColumnHeader colMaMH;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colNgaySinh;
        private System.Windows.Forms.ColumnHeader colDiem;
        private System.Windows.Forms.ColumnHeader colMaKhoa;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.cboMaSV = new System.Windows.Forms.ComboBox();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.lblMaMH = new System.Windows.Forms.Label();
            this.cboMaMH = new System.Windows.Forms.ComboBox();
            this.lblDiem = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.lvwDiem = new System.Windows.Forms.ListView();
            this.colMaSV = new System.Windows.Forms.ColumnHeader();
            this.colMaMH = new System.Windows.Forms.ColumnHeader();
            this.colHoTen = new System.Windows.Forms.ColumnHeader();
            this.colNgaySinh = new System.Windows.Forms.ColumnHeader();
            this.colDiem = new System.Windows.Forms.ColumnHeader();
            this.colMaKhoa = new System.Windows.Forms.ColumnHeader();

            this.grpThongTin.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(760, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ ĐIỂM SINH VIÊN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // grpThongTin
            this.grpThongTin.Controls.Add(this.lblMaSV);
            this.grpThongTin.Controls.Add(this.cboMaSV);
            this.grpThongTin.Controls.Add(this.lblTenSV);
            this.grpThongTin.Controls.Add(this.txtTenSV);
            this.grpThongTin.Controls.Add(this.lblNgaySinh);
            this.grpThongTin.Controls.Add(this.dtpNgaySinh);
            this.grpThongTin.Controls.Add(this.lblMaKhoa);
            this.grpThongTin.Controls.Add(this.txtMaKhoa);
            this.grpThongTin.Controls.Add(this.lblMaMH);
            this.grpThongTin.Controls.Add(this.cboMaMH);
            this.grpThongTin.Controls.Add(this.lblDiem);
            this.grpThongTin.Controls.Add(this.txtDiem);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpThongTin.Location = new System.Drawing.Point(20, 55);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(720, 140);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Nhập thông tin điểm";

            // lblMaSV
            this.lblMaSV.Location = new System.Drawing.Point(20, 30);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(80, 22);
            this.lblMaSV.Text = "Mã SV:";

            // cboMaSV
            this.cboMaSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaSV.Location = new System.Drawing.Point(100, 27);
            this.cboMaSV.Name = "cboMaSV";
            this.cboMaSV.Size = new System.Drawing.Size(150, 24);
            this.cboMaSV.SelectedIndexChanged += new System.EventHandler(this.CboMaSV_SelectedIndexChanged);

            // lblTenSV
            this.lblTenSV.Location = new System.Drawing.Point(270, 30);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(80, 22);
            this.lblTenSV.Text = "Họ tên SV:";

            // txtTenSV
            this.txtTenSV.Location = new System.Drawing.Point(350, 27);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.ReadOnly = true;
            this.txtTenSV.Size = new System.Drawing.Size(160, 24);

            // lblNgaySinh
            this.lblNgaySinh.Location = new System.Drawing.Point(525, 30);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(75, 22);
            this.lblNgaySinh.Text = "Ngày sinh:";

            // dtpNgaySinh
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(600, 27);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(100, 24);

            // lblMaMH
            this.lblMaMH.Location = new System.Drawing.Point(20, 70);
            this.lblMaMH.Name = "lblMaMH";
            this.lblMaMH.Size = new System.Drawing.Size(80, 22);
            this.lblMaMH.Text = "Mã môn:";

            // cboMaMH
            this.cboMaMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaMH.Location = new System.Drawing.Point(100, 67);
            this.cboMaMH.Name = "cboMaMH";
            this.cboMaMH.Size = new System.Drawing.Size(150, 24);

            // lblMaKhoa
            this.lblMaKhoa.Location = new System.Drawing.Point(270, 70);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(80, 22);
            this.lblMaKhoa.Text = "Mã khoa:";

            // txtMaKhoa
            this.txtMaKhoa.Location = new System.Drawing.Point(350, 67);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.ReadOnly = true;
            this.txtMaKhoa.Size = new System.Drawing.Size(160, 24);

            // lblDiem
            this.lblDiem.Location = new System.Drawing.Point(525, 70);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(75, 22);
            this.lblDiem.Text = "Điểm số:";

            // txtDiem
            this.txtDiem.Location = new System.Drawing.Point(600, 67);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(100, 24);

            // btnThem
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.Location = new System.Drawing.Point(140, 205);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 32);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);

            // btnSua
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSua.Location = new System.Drawing.Point(270, 205);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 32);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);

            // btnXoa
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.Location = new System.Drawing.Point(400, 205);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 32);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);

            // btnTimKiem
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTimKiem.Location = new System.Drawing.Point(530, 205);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(110, 32);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.BtnTimKiem_Click);

            // grpDanhSach
            this.grpDanhSach.Controls.Add(this.lvwDiem);
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpDanhSach.Location = new System.Drawing.Point(20, 245);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(720, 240);
            this.grpDanhSach.TabIndex = 6;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách điểm sinh viên (ListView)";

            // lvwDiem
            this.lvwDiem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colMaSV,
                this.colMaMH,
                this.colHoTen,
                this.colNgaySinh,
                this.colDiem,
                this.colMaKhoa
            });
            this.lvwDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwDiem.FullRowSelect = true;
            this.lvwDiem.GridLines = true;
            this.lvwDiem.Location = new System.Drawing.Point(3, 20);
            this.lvwDiem.Name = "lvwDiem";
            this.lvwDiem.Size = new System.Drawing.Size(714, 217);
            this.lvwDiem.TabIndex = 0;
            this.lvwDiem.UseCompatibleStateImageBehavior = false;
            this.lvwDiem.View = System.Windows.Forms.View.Details;
            this.lvwDiem.SelectedIndexChanged += new System.EventHandler(this.LvwDiem_SelectedIndexChanged);

            // colMaSV
            this.colMaSV.Text = "Mã SV";
            this.colMaSV.Width = 90;

            // colMaMH
            this.colMaMH.Text = "Mã môn";
            this.colMaMH.Width = 90;

            // colHoTen
            this.colHoTen.Text = "Họ và tên";
            this.colHoTen.Width = 180;

            // colNgaySinh
            this.colNgaySinh.Text = "Ngày sinh";
            this.colNgaySinh.Width = 110;

            // colDiem
            this.colDiem.Text = "Điểm";
            this.colDiem.Width = 90;

            // colMaKhoa
            this.colMaKhoa.Text = "Mã khoa";
            this.colMaKhoa.Width = 100;

            // FormDiem
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 500);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 2 - Quản Lý Điểm";
            this.Load += new System.EventHandler(this.FormDiem_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
