using System;
using System.Drawing;
using System.Windows.Forms;

namespace Btaplab9.Forms.Guided
{
    /// <summary>
    /// Bài tập hướng dẫn Lab 09 - Công việc 5, 6, 7: Form MDI Quản lý bán hàng (FrmMain)
    /// </summary>
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void ThongTinKhachHangToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            FrmKhachHang f = new FrmKhachHang();
            f.MdiParent = this;
            f.Show();
        }

        private void ThongTinMatHangToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            FrmMatHang f = new FrmMatHang();
            f.MdiParent = this;
            f.Show();
        }

        private void ChiTietBanHangToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            FrmBanHang f = new FrmBanHang();
            f.MdiParent = this;
            f.Show();
        }

        private void TimKiemKhachHangToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            FrmTimkiemKH f = new FrmTimkiemKH();
            f.MdiParent = this;
            f.Show();
        }

        private void TimKiemMatHangToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            FrmTimkiemMH f = new FrmTimkiemMH();
            f.MdiParent = this;
            f.Show();
        }

        private void ThoatToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
