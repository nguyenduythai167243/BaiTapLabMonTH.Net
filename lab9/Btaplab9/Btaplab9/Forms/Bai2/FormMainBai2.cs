using System;
using System.Drawing;
using System.Windows.Forms;

namespace Btaplab9.Forms.Bai2
{
    /// <summary>
    /// Bài 2 - Công việc 2: Form frmMain có menu Quản lý điểm, Quản lý môn học
    /// </summary>
    public partial class FormMainBai2 : Form
    {
        public FormMainBai2()
        {
            InitializeComponent();
        }

        private void MnuQuanLyDiem_Click(object? sender, EventArgs e)
        {
            FormDiem f = new FormDiem();
            f.ShowDialog(this);
        }

        private void MnuQuanLyMonHoc_Click(object? sender, EventArgs e)
        {
            FormMonHoc f = new FormMonHoc();
            f.ShowDialog(this);
        }

        private void MnuThoat_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnQuanLyDiem_Click(object? sender, EventArgs e)
        {
            FormDiem f = new FormDiem();
            f.ShowDialog(this);
        }

        private void BtnQuanLyMonHoc_Click(object? sender, EventArgs e)
        {
            FormMonHoc f = new FormMonHoc();
            f.ShowDialog(this);
        }
    }
}
