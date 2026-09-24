namespace Btaplab9.Forms.Bai2
{
    partial class FormMonHoc
    {
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMaMon;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.ComboBox cboMaKhoa;
        private System.Windows.Forms.Label lblSoHocPhan;
        private System.Windows.Forms.TextBox txtSoHocPhan;
        private System.Windows.Forms.Label lblGiaoVien;
        private System.Windows.Forms.TextBox txtGiaoVien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.ListView lvwMonHoc;
        private System.Windows.Forms.ColumnHeader colMaMon;
        private System.Windows.Forms.ColumnHeader colTenMon;
        private System.Windows.Forms.ColumnHeader colMaKhoa;
        private System.Windows.Forms.ColumnHeader colSoHocPhan;
        private System.Windows.Forms.ColumnHeader colGiaoVien;

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
            this.lblMaMon = new System.Windows.Forms.Label();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.cboMaKhoa = new System.Windows.Forms.ComboBox();
            this.lblSoHocPhan = new System.Windows.Forms.Label();
            this.txtSoHocPhan = new System.Windows.Forms.TextBox();
            this.lblGiaoVien = new System.Windows.Forms.Label();
            this.txtGiaoVien = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.lvwMonHoc = new System.Windows.Forms.ListView();
            this.colMaMon = new System.Windows.Forms.ColumnHeader();
            this.colTenMon = new System.Windows.Forms.ColumnHeader();
            this.colMaKhoa = new System.Windows.Forms.ColumnHeader();
            this.colSoHocPhan = new System.Windows.Forms.ColumnHeader();
            this.colGiaoVien = new System.Windows.Forms.ColumnHeader();

            this.grpThongTin.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(720, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ MÔN HỌC";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // grpThongTin
            this.grpThongTin.Controls.Add(this.lblMaMon);
            this.grpThongTin.Controls.Add(this.txtMaMon);
            this.grpThongTin.Controls.Add(this.lblTenMon);
            this.grpThongTin.Controls.Add(this.txtTenMon);
            this.grpThongTin.Controls.Add(this.lblMaKhoa);
            this.grpThongTin.Controls.Add(this.cboMaKhoa);
            this.grpThongTin.Controls.Add(this.lblSoHocPhan);
            this.grpThongTin.Controls.Add(this.txtSoHocPhan);
            this.grpThongTin.Controls.Add(this.lblGiaoVien);
            this.grpThongTin.Controls.Add(this.txtGiaoVien);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpThongTin.Location = new System.Drawing.Point(20, 55);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(680, 130);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin môn học";

            // lblMaMon
            this.lblMaMon.Location = new System.Drawing.Point(20, 30);
            this.lblMaMon.Name = "lblMaMon";
            this.lblMaMon.Size = new System.Drawing.Size(90, 22);
            this.lblMaMon.Text = "Mã môn:";

            // txtMaMon
            this.txtMaMon.Location = new System.Drawing.Point(110, 27);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(200, 24);

            // lblTenMon
            this.lblTenMon.Location = new System.Drawing.Point(340, 30);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(90, 22);
            this.lblTenMon.Text = "Tên môn:";

            // txtTenMon
            this.txtTenMon.Location = new System.Drawing.Point(430, 27);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(230, 24);

            // lblMaKhoa
            this.lblMaKhoa.Location = new System.Drawing.Point(20, 62);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(90, 22);
            this.lblMaKhoa.Text = "Mã khoa:";

            // cboMaKhoa
            this.cboMaKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaKhoa.Location = new System.Drawing.Point(110, 59);
            this.cboMaKhoa.Name = "cboMaKhoa";
            this.cboMaKhoa.Size = new System.Drawing.Size(200, 24);

            // lblSoHocPhan
            this.lblSoHocPhan.Location = new System.Drawing.Point(340, 62);
            this.lblSoHocPhan.Name = "lblSoHocPhan";
            this.lblSoHocPhan.Size = new System.Drawing.Size(90, 22);
            this.lblSoHocPhan.Text = "Số học phần:";

            // txtSoHocPhan
            this.txtSoHocPhan.Location = new System.Drawing.Point(430, 59);
            this.txtSoHocPhan.Name = "txtSoHocPhan";
            this.txtSoHocPhan.Size = new System.Drawing.Size(230, 24);

            // lblGiaoVien
            this.lblGiaoVien.Location = new System.Drawing.Point(20, 94);
            this.lblGiaoVien.Name = "lblGiaoVien";
            this.lblGiaoVien.Size = new System.Drawing.Size(90, 22);
            this.lblGiaoVien.Text = "Giáo viên:";

            // txtGiaoVien
            this.txtGiaoVien.Location = new System.Drawing.Point(110, 91);
            this.txtGiaoVien.Name = "txtGiaoVien";
            this.txtGiaoVien.Size = new System.Drawing.Size(550, 24);

            // btnThem
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.Location = new System.Drawing.Point(180, 195);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 32);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);

            // btnXoa
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.Location = new System.Drawing.Point(310, 195);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 32);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);

            // btnSua
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSua.Location = new System.Drawing.Point(440, 195);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 32);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);

            // grpDanhSach
            this.grpDanhSach.Controls.Add(this.lvwMonHoc);
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpDanhSach.Location = new System.Drawing.Point(20, 235);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(680, 230);
            this.grpDanhSach.TabIndex = 5;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách môn học (ListView)";

            // lvwMonHoc
            this.lvwMonHoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colMaMon,
                this.colTenMon,
                this.colMaKhoa,
                this.colSoHocPhan,
                this.colGiaoVien
            });
            this.lvwMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwMonHoc.FullRowSelect = true;
            this.lvwMonHoc.GridLines = true;
            this.lvwMonHoc.Location = new System.Drawing.Point(3, 20);
            this.lvwMonHoc.Name = "lvwMonHoc";
            this.lvwMonHoc.Size = new System.Drawing.Size(674, 207);
            this.lvwMonHoc.TabIndex = 0;
            this.lvwMonHoc.UseCompatibleStateImageBehavior = false;
            this.lvwMonHoc.View = System.Windows.Forms.View.Details;
            this.lvwMonHoc.SelectedIndexChanged += new System.EventHandler(this.LvwMonHoc_SelectedIndexChanged);

            // colMaMon
            this.colMaMon.Text = "Mã môn";
            this.colMaMon.Width = 90;

            // colTenMon
            this.colTenMon.Text = "Tên môn học";
            this.colTenMon.Width = 180;

            // colMaKhoa
            this.colMaKhoa.Text = "Mã khoa";
            this.colMaKhoa.Width = 90;

            // colSoHocPhan
            this.colSoHocPhan.Text = "Số HP";
            this.colSoHocPhan.Width = 80;

            // colGiaoVien
            this.colGiaoVien.Text = "Giáo viên giảng dạy";
            this.colGiaoVien.Width = 200;

            // FormMonHoc
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 2 - Quản Lý Môn Học";
            this.Load += new System.EventHandler(this.FormMonHoc_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
