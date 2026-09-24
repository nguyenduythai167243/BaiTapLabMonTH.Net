namespace Btaplab9.Forms.Bai1
{
    partial class FormKhachThuePhong
    {
        // Nhóm Xem thông tin phòng
        private System.Windows.Forms.GroupBox grpXemPhong;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.Button btnXemTinhTrang;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.ComboBox cboLoaiPhong;
        private System.Windows.Forms.Button btnXemLoaiPhong;

        // Lưới chi tiết phòng
        private System.Windows.Forms.GroupBox grpChiTietPhong;
        private System.Windows.Forms.DataGridView dgvChiTietPhong;

        // Nhóm Thông tin khách thuê
        private System.Windows.Forms.GroupBox grpThongTinKH;
        private System.Windows.Forms.Label lblSoCMT;
        private System.Windows.Forms.TextBox txtSoCMT;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.ComboBox cboMaPhong;

        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;

        // Lưới Chi tiết khách hàng
        private System.Windows.Forms.GroupBox grpChiTietKH;
        private System.Windows.Forms.DataGridView dgvChiTietKH;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpXemPhong = new System.Windows.Forms.GroupBox();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            this.btnXemTinhTrang = new System.Windows.Forms.Button();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
            this.btnXemLoaiPhong = new System.Windows.Forms.Button();
            this.grpChiTietPhong = new System.Windows.Forms.GroupBox();
            this.dgvChiTietPhong = new System.Windows.Forms.DataGridView();
            this.grpThongTinKH = new System.Windows.Forms.GroupBox();
            this.lblSoCMT = new System.Windows.Forms.Label();
            this.txtSoCMT = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.cboMaPhong = new System.Windows.Forms.ComboBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpChiTietKH = new System.Windows.Forms.GroupBox();
            this.dgvChiTietKH = new System.Windows.Forms.DataGridView();

            this.grpXemPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhong)).BeginInit();
            this.grpChiTietPhong.SuspendLayout();
            this.grpThongTinKH.SuspendLayout();
            this.grpChiTietKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietKH)).BeginInit();
            this.SuspendLayout();

            // grpXemPhong
            this.grpXemPhong.Text = "Xem thông tin Phòng";
            this.grpXemPhong.Location = new System.Drawing.Point(20, 15);
            this.grpXemPhong.Size = new System.Drawing.Size(760, 95);
            this.grpXemPhong.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTinhTrang, this.cboTinhTrang, this.btnXemTinhTrang,
                this.lblLoaiPhong, this.cboLoaiPhong, this.btnXemLoaiPhong
            });

            // lblTinhTrang
            this.lblTinhTrang.Text = "Tình trạng Phòng:";
            this.lblTinhTrang.Location = new System.Drawing.Point(20, 28);
            this.lblTinhTrang.Size = new System.Drawing.Size(110, 22);

            // cboTinhTrang
            this.cboTinhTrang.Location = new System.Drawing.Point(135, 26);
            this.cboTinhTrang.Size = new System.Drawing.Size(130, 22);
            this.cboTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinhTrang.Items.AddRange(new object[] { "Có", "Không" });
            this.cboTinhTrang.SelectedIndex = 0;

            // btnXemTinhTrang
            this.btnXemTinhTrang.Text = "Xem theo tình trạng";
            this.btnXemTinhTrang.Location = new System.Drawing.Point(285, 24);
            this.btnXemTinhTrang.Size = new System.Drawing.Size(160, 28);
            this.btnXemTinhTrang.Click += new System.EventHandler(this.BtnXemTinhTrang_Click);

            // lblLoaiPhong
            this.lblLoaiPhong.Text = "Loại Phòng:";
            this.lblLoaiPhong.Location = new System.Drawing.Point(20, 60);
            this.lblLoaiPhong.Size = new System.Drawing.Size(110, 22);

            // cboLoaiPhong
            this.cboLoaiPhong.Location = new System.Drawing.Point(135, 58);
            this.cboLoaiPhong.Size = new System.Drawing.Size(130, 22);
            this.cboLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiPhong.Items.AddRange(new object[] { "Phòng đơn", "Phòng đôi", "Phòng ba" });
            this.cboLoaiPhong.SelectedIndex = 0;

            // btnXemLoaiPhong
            this.btnXemLoaiPhong.Text = "Xem theo loại phòng";
            this.btnXemLoaiPhong.Location = new System.Drawing.Point(285, 56);
            this.btnXemLoaiPhong.Size = new System.Drawing.Size(160, 28);
            this.btnXemLoaiPhong.Click += new System.EventHandler(this.BtnXemLoaiPhong_Click);

            // grpChiTietPhong
            this.grpChiTietPhong.Text = "Chi tiết Phòng";
            this.grpChiTietPhong.Location = new System.Drawing.Point(20, 115);
            this.grpChiTietPhong.Size = new System.Drawing.Size(760, 140);
            this.grpChiTietPhong.Controls.Add(this.dgvChiTietPhong);

            // dgvChiTietPhong
            this.dgvChiTietPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietPhong.ReadOnly = true;
            this.dgvChiTietPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // grpThongTinKH
            this.grpThongTinKH.Text = "Thông tin Khách thuê";
            this.grpThongTinKH.Location = new System.Drawing.Point(20, 265);
            this.grpThongTinKH.Size = new System.Drawing.Size(760, 145);
            this.grpThongTinKH.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblSoCMT, this.txtSoCMT, this.lblGioiTinh, this.cboGioiTinh,
                this.lblHoTen, this.txtHoTen, this.lblMaPhong, this.cboMaPhong,
                this.btnNhap, this.btnXoa, this.btnSua, this.btnThoat
            });

            // lblSoCMT
            this.lblSoCMT.Text = "Số CMT:";
            this.lblSoCMT.Location = new System.Drawing.Point(20, 30);
            this.lblSoCMT.Size = new System.Drawing.Size(70, 22);

            // txtSoCMT
            this.txtSoCMT.Location = new System.Drawing.Point(95, 28);
            this.txtSoCMT.Size = new System.Drawing.Size(180, 22);

            // lblGioiTinh
            this.lblGioiTinh.Text = "Giới tính:";
            this.lblGioiTinh.Location = new System.Drawing.Point(410, 30);
            this.lblGioiTinh.Size = new System.Drawing.Size(70, 22);

            // cboGioiTinh
            this.cboGioiTinh.Location = new System.Drawing.Point(490, 28);
            this.cboGioiTinh.Size = new System.Drawing.Size(180, 22);
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            this.cboGioiTinh.SelectedIndex = 0;

            // lblHoTen
            this.lblHoTen.Text = "Họ tên:";
            this.lblHoTen.Location = new System.Drawing.Point(20, 68);
            this.lblHoTen.Size = new System.Drawing.Size(70, 22);

            // txtHoTen
            this.txtHoTen.Location = new System.Drawing.Point(95, 66);
            this.txtHoTen.Size = new System.Drawing.Size(180, 22);

            // lblMaPhong
            this.lblMaPhong.Text = "Mã Phòng:";
            this.lblMaPhong.Location = new System.Drawing.Point(410, 68);
            this.lblMaPhong.Size = new System.Drawing.Size(70, 22);

            // cboMaPhong
            this.cboMaPhong.Location = new System.Drawing.Point(490, 66);
            this.cboMaPhong.Size = new System.Drawing.Size(180, 22);
            this.cboMaPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // btnNhap
            this.btnNhap.Text = "Nhập";
            this.btnNhap.Location = new System.Drawing.Point(95, 105);
            this.btnNhap.Size = new System.Drawing.Size(95, 30);
            this.btnNhap.Click += new System.EventHandler(this.BtnNhap_Click);

            // btnXoa
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(245, 105);
            this.btnXoa.Size = new System.Drawing.Size(95, 30);
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);

            // btnSua
            this.btnSua.Text = "Sửa";
            this.btnSua.Location = new System.Drawing.Point(395, 105);
            this.btnSua.Size = new System.Drawing.Size(95, 30);
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);

            // btnThoat
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Location = new System.Drawing.Point(545, 105);
            this.btnThoat.Size = new System.Drawing.Size(95, 30);
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);

            // grpChiTietKH
            this.grpChiTietKH.Text = "Chi tiết Khách hàng";
            this.grpChiTietKH.Location = new System.Drawing.Point(20, 420);
            this.grpChiTietKH.Size = new System.Drawing.Size(760, 200);
            this.grpChiTietKH.Controls.Add(this.dgvChiTietKH);

            // dgvChiTietKH
            this.dgvChiTietKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietKH.ReadOnly = true;
            this.dgvChiTietKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvChiTietKH_CellClick);

            // FormKhachThuePhong
            this.Text = "QL Khách Thuê Phòng";
            this.Size = new System.Drawing.Size(820, 680);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.grpXemPhong, this.grpChiTietPhong, this.grpThongTinKH, this.grpChiTietKH
            });
            this.Load += new System.EventHandler(this.FormKhachThuePhong_Load);

            this.grpXemPhong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhong)).EndInit();
            this.grpChiTietPhong.ResumeLayout(false);
            this.grpThongTinKH.ResumeLayout(false);
            this.grpThongTinKH.PerformLayout();
            this.grpChiTietKH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietKH)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
