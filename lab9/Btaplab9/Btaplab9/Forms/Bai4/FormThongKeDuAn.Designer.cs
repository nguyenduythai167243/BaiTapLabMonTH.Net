namespace Btaplab9.Forms.Bai4
{
    partial class FormThongKeDuAn
    {
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvThongKeDA;
        private System.Windows.Forms.Label lblTongSo;

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
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvThongKeDA = new System.Windows.Forms.DataGridView();
            this.lblTongSo = new System.Windows.Forms.Label();

            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeDA)).BeginInit();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(900, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THỐNG KÊ CÁC DỰ ÁN ĐANG THỰC HIỆN CỦA VIỆN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // grpDanhSach
            this.grpDanhSach.Controls.Add(this.dgvThongKeDA);
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpDanhSach.Location = new System.Drawing.Point(20, 55);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(860, 370);
            this.grpDanhSach.TabIndex = 1;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Chi tiết dự án và nhân viên tham gia";

            // dgvThongKeDA
            this.dgvThongKeDA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKeDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongKeDA.Location = new System.Drawing.Point(3, 20);
            this.dgvThongKeDA.Name = "dgvThongKeDA";
            this.dgvThongKeDA.ReadOnly = true;
            this.dgvThongKeDA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKeDA.Size = new System.Drawing.Size(854, 347);
            this.dgvThongKeDA.TabIndex = 0;

            // lblTongSo
            this.lblTongSo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTongSo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTongSo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTongSo.Location = new System.Drawing.Point(0, 430);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(900, 40);
            this.lblTongSo.TabIndex = 2;
            this.lblTongSo.Text = "Tổng số phân công dự án: 0";
            this.lblTongSo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // FormThongKeDuAn
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 470);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.lblTongSo);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormThongKeDuAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 4 - Thống Kê Dự Án Đang Thực Hiện";
            this.Load += new System.EventHandler(this.FormThongKeDuAn_Load);
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeDA)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
