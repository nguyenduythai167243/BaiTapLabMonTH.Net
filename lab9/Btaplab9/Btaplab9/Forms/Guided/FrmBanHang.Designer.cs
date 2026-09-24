namespace Btaplab9.Forms.Guided
{
    partial class FrmBanHang
    {
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_shd;
        private System.Windows.Forms.TextBox txt_shd;
        private System.Windows.Forms.Label lbl_makh;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.Label lbl_ngaymua;
        private System.Windows.Forms.DateTimePicker date_ngaymua;
        private System.Windows.Forms.Label lbl_mamh;
        private System.Windows.Forms.TextBox txt_mamh;
        private System.Windows.Forms.Label lbl_soluong;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label lbl_dongia;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.GroupBox group_chitiet;
        private System.Windows.Forms.ListView listview_chitietBH;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colMaMH;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.ColumnHeader colDonGia;
        private System.Windows.Forms.ColumnHeader colThanhTien;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_thoat;

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
            this.lbl_shd = new System.Windows.Forms.Label();
            this.txt_shd = new System.Windows.Forms.TextBox();
            this.lbl_makh = new System.Windows.Forms.Label();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.lbl_ngaymua = new System.Windows.Forms.Label();
            this.date_ngaymua = new System.Windows.Forms.DateTimePicker();
            this.lbl_mamh = new System.Windows.Forms.Label();
            this.txt_mamh = new System.Windows.Forms.TextBox();
            this.lbl_soluong = new System.Windows.Forms.Label();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.lbl_dongia = new System.Windows.Forms.Label();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.group_chitiet = new System.Windows.Forms.GroupBox();
            this.listview_chitietBH = new System.Windows.Forms.ListView();
            this.colSTT = new System.Windows.Forms.ColumnHeader();
            this.colMaMH = new System.Windows.Forms.ColumnHeader();
            this.colSoLuong = new System.Windows.Forms.ColumnHeader();
            this.colDonGia = new System.Windows.Forms.ColumnHeader();
            this.colThanhTien = new System.Windows.Forms.ColumnHeader();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();

            this.group_chitiet.SuspendLayout();
            this.SuspendLayout();

            // lbl_title
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_title.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.ForeColor = System.Drawing.Color.Navy;
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(720, 50);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "CHI TIẾT BÁN HÀNG";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lbl_shd
            this.lbl_shd.Location = new System.Drawing.Point(30, 60);
            this.lbl_shd.Name = "lbl_shd";
            this.lbl_shd.Size = new System.Drawing.Size(100, 20);
            this.lbl_shd.Text = "Số hiệu hóa đơn:";

            // txt_shd
            this.txt_shd.Location = new System.Drawing.Point(135, 57);
            this.txt_shd.Name = "txt_shd";
            this.txt_shd.Size = new System.Drawing.Size(180, 23);

            // lbl_makh
            this.lbl_makh.Location = new System.Drawing.Point(30, 95);
            this.lbl_makh.Name = "lbl_makh";
            this.lbl_makh.Size = new System.Drawing.Size(100, 20);
            this.lbl_makh.Text = "Mã Khách Hàng:";

            // txt_makh
            this.txt_makh.Location = new System.Drawing.Point(135, 92);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(180, 23);

            // lbl_ngaymua
            this.lbl_ngaymua.Location = new System.Drawing.Point(30, 130);
            this.lbl_ngaymua.Name = "lbl_ngaymua";
            this.lbl_ngaymua.Size = new System.Drawing.Size(100, 20);
            this.lbl_ngaymua.Text = "Ngày Mua:";

            // date_ngaymua
            this.date_ngaymua.CustomFormat = "dd/MM/yyyy";
            this.date_ngaymua.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_ngaymua.Location = new System.Drawing.Point(135, 127);
            this.date_ngaymua.Name = "date_ngaymua";
            this.date_ngaymua.Size = new System.Drawing.Size(180, 23);

            // lbl_mamh
            this.lbl_mamh.Location = new System.Drawing.Point(400, 60);
            this.lbl_mamh.Name = "lbl_mamh";
            this.lbl_mamh.Size = new System.Drawing.Size(90, 20);
            this.lbl_mamh.Text = "Mã MH:";

            // txt_mamh
            this.txt_mamh.Location = new System.Drawing.Point(495, 57);
            this.txt_mamh.Name = "txt_mamh";
            this.txt_mamh.Size = new System.Drawing.Size(190, 23);

            // lbl_soluong
            this.lbl_soluong.Location = new System.Drawing.Point(400, 95);
            this.lbl_soluong.Name = "lbl_soluong";
            this.lbl_soluong.Size = new System.Drawing.Size(90, 20);
            this.lbl_soluong.Text = "Số Lượng:";

            // txt_soluong
            this.txt_soluong.Location = new System.Drawing.Point(495, 92);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(190, 23);

            // lbl_dongia
            this.lbl_dongia.Location = new System.Drawing.Point(400, 130);
            this.lbl_dongia.Name = "lbl_dongia";
            this.lbl_dongia.Size = new System.Drawing.Size(90, 20);
            this.lbl_dongia.Text = "Đơn giá:";

            // txt_dongia
            this.txt_dongia.Location = new System.Drawing.Point(495, 127);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(190, 23);

            // group_chitiet
            this.group_chitiet.Controls.Add(this.listview_chitietBH);
            this.group_chitiet.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.group_chitiet.Location = new System.Drawing.Point(20, 165);
            this.group_chitiet.Name = "group_chitiet";
            this.group_chitiet.Size = new System.Drawing.Size(680, 200);
            this.group_chitiet.TabIndex = 7;
            this.group_chitiet.TabStop = false;
            this.group_chitiet.Text = "Hóa đơn chi tiết bán hàng";

            // listview_chitietBH
            this.listview_chitietBH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colSTT,
                this.colMaMH,
                this.colSoLuong,
                this.colDonGia,
                this.colThanhTien
            });
            this.listview_chitietBH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listview_chitietBH.FullRowSelect = true;
            this.listview_chitietBH.GridLines = true;
            this.listview_chitietBH.Location = new System.Drawing.Point(3, 17);
            this.listview_chitietBH.Name = "listview_chitietBH";
            this.listview_chitietBH.Size = new System.Drawing.Size(674, 180);
            this.listview_chitietBH.TabIndex = 0;
            this.listview_chitietBH.UseCompatibleStateImageBehavior = false;
            this.listview_chitietBH.View = System.Windows.Forms.View.Details;
            this.listview_chitietBH.SelectedIndexChanged += new System.EventHandler(this.listview_chitietBH_SelectedIndexChanged);

            // colSTT
            this.colSTT.Text = "STT";
            this.colSTT.Width = 60;

            // colMaMH
            this.colMaMH.Text = "Mã MH";
            this.colMaMH.Width = 120;

            // colSoLuong
            this.colSoLuong.Text = "Số Lượng";
            this.colSoLuong.Width = 120;

            // colDonGia
            this.colDonGia.Text = "Đơn giá";
            this.colDonGia.Width = 150;

            // colThanhTien
            this.colThanhTien.Text = "Thành tiền";
            this.colThanhTien.Width = 180;

            // bt_them
            this.bt_them.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_them.Location = new System.Drawing.Point(80, 380);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(100, 32);
            this.bt_them.TabIndex = 8;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);

            // bt_sua
            this.bt_sua.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_sua.Location = new System.Drawing.Point(230, 380);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(100, 32);
            this.bt_sua.TabIndex = 9;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);

            // bt_xoa
            this.bt_xoa.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_xoa.Location = new System.Drawing.Point(380, 380);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(100, 32);
            this.bt_xoa.TabIndex = 10;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);

            // bt_thoat
            this.bt_thoat.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_thoat.Location = new System.Drawing.Point(530, 380);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(100, 32);
            this.bt_thoat.TabIndex = 11;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);

            // FrmBanHang
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 430);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.group_chitiet);
            this.Controls.Add(this.lbl_dongia);
            this.Controls.Add(this.txt_dongia);
            this.Controls.Add(this.lbl_soluong);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.lbl_mamh);
            this.Controls.Add(this.txt_mamh);
            this.Controls.Add(this.lbl_ngaymua);
            this.Controls.Add(this.date_ngaymua);
            this.Controls.Add(this.lbl_makh);
            this.Controls.Add(this.txt_makh);
            this.Controls.Add(this.lbl_shd);
            this.Controls.Add(this.txt_shd);
            this.Controls.Add(this.lbl_title);
            this.Name = "FrmBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBanHang";
            this.Load += new System.EventHandler(this.FrmBanHang_Load);
            this.group_chitiet.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
