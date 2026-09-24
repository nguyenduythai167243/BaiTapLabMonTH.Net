namespace Btaplab9.Forms.Bai1
{
    partial class FormQuanLyPhong
    {
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.ComboBox cboLoaiPhong;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lblHangPhong;
        private System.Windows.Forms.ComboBox cboHangPhong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvPhong;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblHangPhong = new System.Windows.Forms.Label();
            this.cboHangPhong = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvPhong = new System.Windows.Forms.DataGridView();

            this.grpThongTin.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Text = "QUẢN LÝ PHÒNG";
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Height = 40;

            // grpThongTin
            this.grpThongTin.Text = "Nhập thông tin Phòng";
            this.grpThongTin.Location = new System.Drawing.Point(20, 50);
            this.grpThongTin.Size = new System.Drawing.Size(660, 110);
            this.grpThongTin.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblMaPhong, this.txtMaPhong, this.lblLoaiPhong, this.cboLoaiPhong,
                this.lblDonGia, this.txtDonGia, this.lblHangPhong, this.cboHangPhong
            });

            // lblMaPhong
            this.lblMaPhong.Text = "Mã Phòng:";
            this.lblMaPhong.Location = new System.Drawing.Point(20, 30);
            this.lblMaPhong.Size = new System.Drawing.Size(80, 20);

            // txtMaPhong
            this.txtMaPhong.Location = new System.Drawing.Point(100, 28);
            this.txtMaPhong.Size = new System.Drawing.Size(180, 22);

            // lblLoaiPhong
            this.lblLoaiPhong.Text = "Loại Phòng:";
            this.lblLoaiPhong.Location = new System.Drawing.Point(340, 30);
            this.lblLoaiPhong.Size = new System.Drawing.Size(80, 20);

            // cboLoaiPhong
            this.cboLoaiPhong.Location = new System.Drawing.Point(430, 28);
            this.cboLoaiPhong.Size = new System.Drawing.Size(190, 22);
            this.cboLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiPhong.Items.AddRange(new object[] { "Phòng đơn", "Phòng đôi", "Phòng ba" });
            this.cboLoaiPhong.SelectedIndex = 0;

            // lblDonGia
            this.lblDonGia.Text = "Đơn giá:";
            this.lblDonGia.Location = new System.Drawing.Point(20, 68);
            this.lblDonGia.Size = new System.Drawing.Size(80, 20);

            // txtDonGia
            this.txtDonGia.Location = new System.Drawing.Point(100, 66);
            this.txtDonGia.Size = new System.Drawing.Size(180, 22);

            // lblHangPhong
            this.lblHangPhong.Text = "Hạng Phòng:";
            this.lblHangPhong.Location = new System.Drawing.Point(340, 68);
            this.lblHangPhong.Size = new System.Drawing.Size(80, 20);

            // cboHangPhong
            this.cboHangPhong.Location = new System.Drawing.Point(430, 66);
            this.cboHangPhong.Size = new System.Drawing.Size(190, 22);
            this.cboHangPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHangPhong.Items.AddRange(new object[] { "Thường", "Sang", "VIP" });
            this.cboHangPhong.SelectedIndex = 0;

            // btnThem
            this.btnThem.Text = "Thêm";
            this.btnThem.Location = new System.Drawing.Point(80, 175);
            this.btnThem.Size = new System.Drawing.Size(95, 32);
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);

            // btnSua
            this.btnSua.Text = "Sửa";
            this.btnSua.Location = new System.Drawing.Point(220, 175);
            this.btnSua.Size = new System.Drawing.Size(95, 32);
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);

            // btnXoa
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(360, 175);
            this.btnXoa.Size = new System.Drawing.Size(95, 32);
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);

            // btnThoat
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Location = new System.Drawing.Point(500, 175);
            this.btnThoat.Size = new System.Drawing.Size(95, 32);
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);

            // grpDanhSach
            this.grpDanhSach.Text = "Danh sách Phòng";
            this.grpDanhSach.Location = new System.Drawing.Point(20, 220);
            this.grpDanhSach.Size = new System.Drawing.Size(660, 240);
            this.grpDanhSach.Controls.Add(this.dgvPhong);

            // dgvPhong
            this.dgvPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhong.MultiSelect = true;
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPhong_CellClick);

            // FormQuanLyPhong
            this.Text = "Quản Lý Phòng";
            this.Size = new System.Drawing.Size(720, 520);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitle, this.grpThongTin, this.btnThem, this.btnSua,
                this.btnXoa, this.btnThoat, this.grpDanhSach
            });
            this.Load += new System.EventHandler(this.FormQuanLyPhong_Load);

            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
