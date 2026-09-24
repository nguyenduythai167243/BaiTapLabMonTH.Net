namespace Btaplab9.Forms.Guided
{
    partial class FrmMatHang
    {
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox group_chitiet;
        private System.Windows.Forms.Label lbl_mamh;
        private System.Windows.Forms.TextBox txt_mamh;
        private System.Windows.Forms.Label lbl_tenmh;
        private System.Windows.Forms.TextBox txt_tenmh;
        private System.Windows.Forms.Label lbl_dvtinh;
        private System.Windows.Forms.TextBox txt_dvtinh;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_timkiem;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.GroupBox group_danhsach;
        private System.Windows.Forms.ListView listview_mathang;
        private System.Windows.Forms.ColumnHeader colMaMH;
        private System.Windows.Forms.ColumnHeader colTenMH;
        private System.Windows.Forms.ColumnHeader colDVT;

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
            this.lbl_mamh = new System.Windows.Forms.Label();
            this.txt_mamh = new System.Windows.Forms.TextBox();
            this.lbl_tenmh = new System.Windows.Forms.Label();
            this.txt_tenmh = new System.Windows.Forms.TextBox();
            this.lbl_dvtinh = new System.Windows.Forms.Label();
            this.txt_dvtinh = new System.Windows.Forms.TextBox();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_timkiem = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.group_danhsach = new System.Windows.Forms.GroupBox();
            this.listview_mathang = new System.Windows.Forms.ListView();
            this.colMaMH = new System.Windows.Forms.ColumnHeader();
            this.colTenMH = new System.Windows.Forms.ColumnHeader();
            this.colDVT = new System.Windows.Forms.ColumnHeader();

            this.group_chitiet.SuspendLayout();
            this.group_danhsach.SuspendLayout();
            this.SuspendLayout();

            // lbl_title
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_title.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.ForeColor = System.Drawing.Color.Navy;
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(680, 50);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "THÔNG TIN MẶT HÀNG";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // group_chitiet
            this.group_chitiet.Controls.Add(this.lbl_mamh);
            this.group_chitiet.Controls.Add(this.txt_mamh);
            this.group_chitiet.Controls.Add(this.lbl_tenmh);
            this.group_chitiet.Controls.Add(this.txt_tenmh);
            this.group_chitiet.Controls.Add(this.lbl_dvtinh);
            this.group_chitiet.Controls.Add(this.txt_dvtinh);
            this.group_chitiet.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.group_chitiet.Location = new System.Drawing.Point(20, 55);
            this.group_chitiet.Name = "group_chitiet";
            this.group_chitiet.Size = new System.Drawing.Size(420, 130);
            this.group_chitiet.TabIndex = 1;
            this.group_chitiet.TabStop = false;
            this.group_chitiet.Text = "Thông tin chi tiết mặt hàng";

            // lbl_mamh
            this.lbl_mamh.Location = new System.Drawing.Point(20, 30);
            this.lbl_mamh.Name = "lbl_mamh";
            this.lbl_mamh.Size = new System.Drawing.Size(90, 20);
            this.lbl_mamh.Text = "Mã Mặt Hàng:";

            // txt_mamh
            this.txt_mamh.Location = new System.Drawing.Point(120, 27);
            this.txt_mamh.Name = "txt_mamh";
            this.txt_mamh.Size = new System.Drawing.Size(270, 21);

            // lbl_tenmh
            this.lbl_tenmh.Location = new System.Drawing.Point(20, 65);
            this.lbl_tenmh.Name = "lbl_tenmh";
            this.lbl_tenmh.Size = new System.Drawing.Size(90, 20);
            this.lbl_tenmh.Text = "Tên Mặt Hàng:";

            // txt_tenmh
            this.txt_tenmh.Location = new System.Drawing.Point(120, 62);
            this.txt_tenmh.Name = "txt_tenmh";
            this.txt_tenmh.Size = new System.Drawing.Size(270, 21);

            // lbl_dvtinh
            this.lbl_dvtinh.Location = new System.Drawing.Point(20, 100);
            this.lbl_dvtinh.Name = "lbl_dvtinh";
            this.lbl_dvtinh.Size = new System.Drawing.Size(90, 20);
            this.lbl_dvtinh.Text = "Đơn Vị Tính:";

            // txt_dvtinh
            this.txt_dvtinh.Location = new System.Drawing.Point(120, 97);
            this.txt_dvtinh.Name = "txt_dvtinh";
            this.txt_dvtinh.Size = new System.Drawing.Size(270, 21);

            // bt_them
            this.bt_them.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_them.Location = new System.Drawing.Point(460, 60);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(90, 30);
            this.bt_them.TabIndex = 2;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);

            // bt_sua
            this.bt_sua.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_sua.Location = new System.Drawing.Point(460, 100);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(90, 30);
            this.bt_sua.TabIndex = 3;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);

            // bt_xoa
            this.bt_xoa.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_xoa.Location = new System.Drawing.Point(460, 140);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(90, 30);
            this.bt_xoa.TabIndex = 4;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);

            // bt_timkiem
            this.bt_timkiem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_timkiem.Location = new System.Drawing.Point(565, 60);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(90, 30);
            this.bt_timkiem.TabIndex = 5;
            this.bt_timkiem.Text = "Tìm kiếm";
            this.bt_timkiem.UseVisualStyleBackColor = true;
            this.bt_timkiem.Click += new System.EventHandler(this.bt_timkiem_Click);

            // bt_thoat
            this.bt_thoat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_thoat.Location = new System.Drawing.Point(565, 100);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(90, 30);
            this.bt_thoat.TabIndex = 6;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);

            // group_danhsach
            this.group_danhsach.Controls.Add(this.listview_mathang);
            this.group_danhsach.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.group_danhsach.Location = new System.Drawing.Point(20, 200);
            this.group_danhsach.Name = "group_danhsach";
            this.group_danhsach.Size = new System.Drawing.Size(640, 220);
            this.group_danhsach.TabIndex = 7;
            this.group_danhsach.TabStop = false;
            this.group_danhsach.Text = "Danh sách mặt hàng";

            // listview_mathang
            this.listview_mathang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colMaMH,
                this.colTenMH,
                this.colDVT
            });
            this.listview_mathang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listview_mathang.FullRowSelect = true;
            this.listview_mathang.GridLines = true;
            this.listview_mathang.Location = new System.Drawing.Point(3, 17);
            this.listview_mathang.Name = "listview_mathang";
            this.listview_mathang.Size = new System.Drawing.Size(634, 200);
            this.listview_mathang.TabIndex = 0;
            this.listview_mathang.UseCompatibleStateImageBehavior = false;
            this.listview_mathang.View = System.Windows.Forms.View.Details;
            this.listview_mathang.SelectedIndexChanged += new System.EventHandler(this.listview_mathang_SelectedIndexChanged);

            // colMaMH
            this.colMaMH.Text = "Mã Mặt Hàng";
            this.colMaMH.Width = 120;

            // colTenMH
            this.colTenMH.Text = "Tên Mặt Hàng";
            this.colTenMH.Width = 320;

            // colDVT
            this.colDVT.Text = "Đơn Vị Tính";
            this.colDVT.Width = 160;

            // FrmMatHang
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 440);
            this.Controls.Add(this.group_danhsach);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_timkiem);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.group_chitiet);
            this.Controls.Add(this.lbl_title);
            this.Name = "FrmMatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMatHang";
            this.Load += new System.EventHandler(this.FrmMatHang_Load);
            this.group_chitiet.ResumeLayout(false);
            this.group_chitiet.PerformLayout();
            this.group_danhsach.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
