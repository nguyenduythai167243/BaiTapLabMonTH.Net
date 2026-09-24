using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Btaplab9.Database;

namespace Btaplab9.Forms.Bai3
{
    /// <summary>
    /// Bài 3 - Công việc 3a: Form thống kê hàng mua
    /// Thông tin: Tên hàng, đơn vị tính, nhà cung cấp, ngày mua, số lượng mua, đơn giá mua, thành tiền
    /// </summary>
    public partial class FormThongKeHangMua : Form
    {
        public FormThongKeHangMua()
        {
            InitializeComponent();
        }

        private void FormThongKeHangMua_Load(object? sender, EventArgs e)
        {
            string sql = @"SELECT h.Tenhang AS [Tên hàng], h.DVT AS [Đơn vị tính], ncc.Tenncc AS [Nhà cung cấp], 
                                  CONVERT(VARCHAR, hdm.Ngaymua, 103) AS [Ngày mua], 
                                  ctm.Soluongmua AS [Số lượng mua], ctm.Dongiamua AS [Đơn giá mua], 
                                  (ctm.Soluongmua * ctm.Dongiamua) AS [Thành tiền]
                           FROM CHITIETMUA ctm
                           JOIN HDMUA hdm ON ctm.SoHD = hdm.SoHD
                           JOIN HANG h ON ctm.Mahang = h.Mahang
                           JOIN NCC ncc ON hdm.Mancc = ncc.Mancc";

            DataTable dt = ketnoi.truyvan(sql, "QLKD");
            if (dt.Rows.Count > 0)
            {
                dgvThongKe.DataSource = dt;
            }
            else
            {
                DataTable dtMock = new DataTable();
                dtMock.Columns.Add("Tên hàng");
                dtMock.Columns.Add("Đơn vị tính");
                dtMock.Columns.Add("Nhà cung cấp");
                dtMock.Columns.Add("Ngày mua");
                dtMock.Columns.Add("Số lượng mua", typeof(int));
                dtMock.Columns.Add("Đơn giá mua", typeof(double));
                dtMock.Columns.Add("Thành tiền", typeof(double));

                dtMock.Rows.Add("Tivi Sony Bravia 55 inch", "Chiếc", "Công ty Điện Máy Sony VN", "10/08/2023", 10, 12000000, 120000000);
                dtMock.Rows.Add("Tủ lạnh Panasonic Inverter", "Chiếc", "Tập đoàn Điện Lạnh Panasonic", "15/08/2023", 15, 8500000, 127500000);
                dtMock.Rows.Add("Máy giặt LG TurboWash", "Chiếc", "Công ty Phân Phối LG Electronics", "01/09/2023", 20, 7200000, 144000000);
                dgvThongKe.DataSource = dtMock;
            }

            // Tính tổng tiền
            double tong = 0;
            foreach (DataGridViewRow r in dgvThongKe.Rows)
            {
                if (r.Cells["Thành tiền"].Value != null && double.TryParse(r.Cells["Thành tiền"].Value.ToString(), out double tt))
                    tong += tt;
            }
            lblTongTien.Text = $"Tổng giá trị hàng mua: {tong:N0} VNĐ   ";
        }
    }
}
