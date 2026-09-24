namespace Btaplab9.Forms.Bai4
{
    partial class FormMainBai4
    {
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyDuAn;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKe;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKeDuAn;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKeNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiem;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiemNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiemDuAn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpDashboard;
        private System.Windows.Forms.Button btnQuanLyDuAn;
        private System.Windows.Forms.Button btnThongKeDuAn;
        private System.Windows.Forms.Button btnThongKeNhanVien;
        private System.Windows.Forms.Button btnTimKiemNhanVien;
        private System.Windows.Forms.Button btnTimKiemDuAn;

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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyDuAn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKeDuAn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKeNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiemNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiemDuAn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpDashboard = new System.Windows.Forms.GroupBox();
            this.btnQuanLyDuAn = new System.Windows.Forms.Button();
            this.btnThongKeDuAn = new System.Windows.Forms.Button();
            this.btnThongKeNhanVien = new System.Windows.Forms.Button();
            this.btnTimKiemNhanVien = new System.Windows.Forms.Button();
            this.btnTimKiemDuAn = new System.Windows.Forms.Button();

            this.menuStrip1.SuspendLayout();
            this.grpDashboard.SuspendLayout();
            this.SuspendLayout();

            // menuStrip1
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuQuanLy,
                this.mnuThongKe,
                this.mnuTimKiem
            });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 0;

            // mnuQuanLy
            this.mnuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuQuanLyDuAn,
                this.toolStripSeparator1,
                this.mnuThoat
            });
            this.mnuQuanLy.Name = "mnuQuanLy";
            this.mnuQuanLy.Size = new System.Drawing.Size(60, 20);
            this.mnuQuanLy.Text = "&Quản lý";

            // mnuQuanLyDuAn
            this.mnuQuanLyDuAn.Name = "mnuQuanLyDuAn";
            this.mnuQuanLyDuAn.Size = new System.Drawing.Size(152, 22);
            this.mnuQuanLyDuAn.Text = "Quản lý &dự án";
            this.mnuQuanLyDuAn.Click += new System.EventHandler(this.MnuQuanLyDuAn_Click);

            // toolStripSeparator1
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);

            // mnuThoat
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(152, 22);
            this.mnuThoat.Text = "Th&oát";
            this.mnuThoat.Click += new System.EventHandler(this.MnuThoat_Click);

            // mnuThongKe
            this.mnuThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuThongKeDuAn,
                this.mnuThongKeNhanVien
            });
            this.mnuThongKe.Name = "mnuThongKe";
            this.mnuThongKe.Size = new System.Drawing.Size(68, 20);
            this.mnuThongKe.Text = "&Thống kê";

            // mnuThongKeDuAn
            this.mnuThongKeDuAn.Name = "mnuThongKeDuAn";
            this.mnuThongKeDuAn.Size = new System.Drawing.Size(185, 22);
            this.mnuThongKeDuAn.Text = "Thống kê &dự án";
            this.mnuThongKeDuAn.Click += new System.EventHandler(this.MnuThongKeDuAn_Click);

            // mnuThongKeNhanVien
            this.mnuThongKeNhanVien.Name = "mnuThongKeNhanVien";
            this.mnuThongKeNhanVien.Size = new System.Drawing.Size(185, 22);
            this.mnuThongKeNhanVien.Text = "Thống kê &nhân viên";
            this.mnuThongKeNhanVien.Click += new System.EventHandler(this.MnuThongKeNhanVien_Click);

            // mnuTimKiem
            this.mnuTimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuTimKiemNhanVien,
                this.mnuTimKiemDuAn
            });
            this.mnuTimKiem.Name = "mnuTimKiem";
            this.mnuTimKiem.Size = new System.Drawing.Size(68, 20);
            this.mnuTimKiem.Text = "Tì&m kiếm";

            // mnuTimKiemNhanVien
            this.mnuTimKiemNhanVien.Name = "mnuTimKiemNhanVien";
            this.mnuTimKiemNhanVien.Size = new System.Drawing.Size(182, 22);
            this.mnuTimKiemNhanVien.Text = "Tìm kiếm &nhân viên";
            this.mnuTimKiemNhanVien.Click += new System.EventHandler(this.MnuTimKiemNhanVien_Click);

            // mnuTimKiemDuAn
            this.mnuTimKiemDuAn.Name = "mnuTimKiemDuAn";
            this.mnuTimKiemDuAn.Size = new System.Drawing.Size(182, 22);
            this.mnuTimKiemDuAn.Text = "Tìm kiếm &dự án";
            this.mnuTimKiemDuAn.Click += new System.EventHandler(this.MnuTimKiemDuAn_Click);

            // lblTitle
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(0, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(760, 60);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "BÀI 4 - HỆ THỐNG QUẢN LÝ DỰ ÁN VIỆN CNTT (QLDA)";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // grpDashboard
            this.grpDashboard.Controls.Add(this.btnQuanLyDuAn);
            this.grpDashboard.Controls.Add(this.btnThongKeDuAn);
            this.grpDashboard.Controls.Add(this.btnThongKeNhanVien);
            this.grpDashboard.Controls.Add(this.btnTimKiemNhanVien);
            this.grpDashboard.Controls.Add(this.btnTimKiemDuAn);
            this.grpDashboard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpDashboard.Location = new System.Drawing.Point(40, 95);
            this.grpDashboard.Name = "grpDashboard";
            this.grpDashboard.Size = new System.Drawing.Size(680, 240);
            this.grpDashboard.TabIndex = 2;
            this.grpDashboard.TabStop = false;
            this.grpDashboard.Text = "Các chức năng quản lý chính";

            // btnQuanLyDuAn
            this.btnQuanLyDuAn.BackColor = System.Drawing.Color.SteelBlue;
            this.btnQuanLyDuAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyDuAn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuanLyDuAn.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyDuAn.Location = new System.Drawing.Point(40, 40);
            this.btnQuanLyDuAn.Name = "btnQuanLyDuAn";
            this.btnQuanLyDuAn.Size = new System.Drawing.Size(180, 65);
            this.btnQuanLyDuAn.TabIndex = 0;
            this.btnQuanLyDuAn.Text = "Quản Lý Dự Án";
            this.btnQuanLyDuAn.UseVisualStyleBackColor = false;
            this.btnQuanLyDuAn.Click += new System.EventHandler(this.MnuQuanLyDuAn_Click);

            // btnThongKeDuAn
            this.btnThongKeDuAn.BackColor = System.Drawing.Color.Teal;
            this.btnThongKeDuAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKeDuAn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThongKeDuAn.ForeColor = System.Drawing.Color.White;
            this.btnThongKeDuAn.Location = new System.Drawing.Point(250, 40);
            this.btnThongKeDuAn.Name = "btnThongKeDuAn";
            this.btnThongKeDuAn.Size = new System.Drawing.Size(180, 65);
            this.btnThongKeDuAn.TabIndex = 1;
            this.btnThongKeDuAn.Text = "Thống Kê Dự Án";
            this.btnThongKeDuAn.UseVisualStyleBackColor = false;
            this.btnThongKeDuAn.Click += new System.EventHandler(this.MnuThongKeDuAn_Click);

            // btnThongKeNhanVien
            this.btnThongKeNhanVien.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThongKeNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKeNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThongKeNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnThongKeNhanVien.Location = new System.Drawing.Point(460, 40);
            this.btnThongKeNhanVien.Name = "btnThongKeNhanVien";
            this.btnThongKeNhanVien.Size = new System.Drawing.Size(180, 65);
            this.btnThongKeNhanVien.TabIndex = 2;
            this.btnThongKeNhanVien.Text = "Thống Kê Nhân Viên";
            this.btnThongKeNhanVien.UseVisualStyleBackColor = false;
            this.btnThongKeNhanVien.Click += new System.EventHandler(this.MnuThongKeNhanVien_Click);

            // btnTimKiemNhanVien
            this.btnTimKiemNhanVien.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnTimKiemNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTimKiemNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemNhanVien.Location = new System.Drawing.Point(145, 140);
            this.btnTimKiemNhanVien.Name = "btnTimKiemNhanVien";
            this.btnTimKiemNhanVien.Size = new System.Drawing.Size(180, 65);
            this.btnTimKiemNhanVien.TabIndex = 3;
            this.btnTimKiemNhanVien.Text = "Tìm Kiếm Nhân Viên";
            this.btnTimKiemNhanVien.UseVisualStyleBackColor = false;
            this.btnTimKiemNhanVien.Click += new System.EventHandler(this.MnuTimKiemNhanVien_Click);

            // btnTimKiemDuAn
            this.btnTimKiemDuAn.BackColor = System.Drawing.Color.Chocolate;
            this.btnTimKiemDuAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemDuAn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTimKiemDuAn.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemDuAn.Location = new System.Drawing.Point(355, 140);
            this.btnTimKiemDuAn.Name = "btnTimKiemDuAn";
            this.btnTimKiemDuAn.Size = new System.Drawing.Size(180, 65);
            this.btnTimKiemDuAn.TabIndex = 4;
            this.btnTimKiemDuAn.Text = "Tìm Kiếm Dự Án";
            this.btnTimKiemDuAn.UseVisualStyleBackColor = false;
            this.btnTimKiemDuAn.Click += new System.EventHandler(this.MnuTimKiemDuAn_Click);

            // FormMainBai4
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 360);
            this.Controls.Add(this.grpDashboard);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMainBai4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 4 - Main Quản Lý Dự Án Viện CNTT";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpDashboard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
