namespace Btaplab9.Forms.Guided
{
    partial class FrmMain
    {
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuMatHang;
        private System.Windows.Forms.ToolStripMenuItem mnuBanHang;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiem;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiemKH;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiemMH;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

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
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMatHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiemKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiemMH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();

            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            // menuStrip1
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuKhachHang,
                this.mnuMatHang,
                this.mnuBanHang,
                this.mnuTimKiem,
                this.mnuThoat
            });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
            this.menuStrip1.TabIndex = 0;

            // mnuKhachHang
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.Size = new System.Drawing.Size(134, 20);
            this.mnuKhachHang.Text = "Thông tin &Khách hàng";
            this.mnuKhachHang.Click += new System.EventHandler(this.ThongTinKhachHangToolStripMenuItem_Click);

            // mnuMatHang
            this.mnuMatHang.Name = "mnuMatHang";
            this.mnuMatHang.Size = new System.Drawing.Size(123, 20);
            this.mnuMatHang.Text = "Thông tin &mặt hàng";
            this.mnuMatHang.Click += new System.EventHandler(this.ThongTinMatHangToolStripMenuItem_Click);

            // mnuBanHang
            this.mnuBanHang.Name = "mnuBanHang";
            this.mnuBanHang.Size = new System.Drawing.Size(110, 20);
            this.mnuBanHang.Text = "&Chi tiết bán hàng";
            this.mnuBanHang.Click += new System.EventHandler(this.ChiTietBanHangToolStripMenuItem_Click);

            // mnuTimKiem
            this.mnuTimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuTimKiemKH,
                this.mnuTimKiemMH
            });
            this.mnuTimKiem.Name = "mnuTimKiem";
            this.mnuTimKiem.Size = new System.Drawing.Size(68, 20);
            this.mnuTimKiem.Text = "Tì&m kiếm";

            // mnuTimKiemKH
            this.mnuTimKiemKH.Name = "mnuTimKiemKH";
            this.mnuTimKiemKH.Size = new System.Drawing.Size(211, 22);
            this.mnuTimKiemKH.Text = "Tìm kiếm thông tin &khách hàng";
            this.mnuTimKiemKH.Click += new System.EventHandler(this.TimKiemKhachHangToolStripMenuItem_Click);

            // mnuTimKiemMH
            this.mnuTimKiemMH.Name = "mnuTimKiemMH";
            this.mnuTimKiemMH.Size = new System.Drawing.Size(211, 22);
            this.mnuTimKiemMH.Text = "Tìm kiếm thông tin &mặt hàng";
            this.mnuTimKiemMH.Click += new System.EventHandler(this.TimKiemMatHangToolStripMenuItem_Click);

            // mnuThoat
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(49, 20);
            this.mnuThoat.Text = "Th&oát";
            this.mnuThoat.Click += new System.EventHandler(this.ThoatToolStripMenuItem_Click);

            // statusStrip1
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.toolStripStatusLabel1
            });
            this.statusStrip1.Location = new System.Drawing.Point(0, 528);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(900, 22);
            this.statusStrip1.TabIndex = 1;

            // toolStripStatusLabel1
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(248, 17);
            this.toolStripStatusLabel1.Text = "Hệ thống Quản lý bán hàng - Lab 09 (MDI)";

            // FrmMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
