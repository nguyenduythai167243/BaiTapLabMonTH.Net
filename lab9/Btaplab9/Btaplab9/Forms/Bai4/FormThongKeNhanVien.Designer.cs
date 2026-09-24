namespace Btaplab9.Forms.Bai4
{
    partial class FormThongKeNhanVien
    {
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvThongKeNV;
        private System.Windows.Forms.Label lblTongNV;

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
            this.dgvThongKeNV = new System.Windows.Forms.DataGridView();
            this.lblTongNV = new System.Windows.Forms.Label();

            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeNV)).BeginInit();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(880, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BÁO CÁO THỐNG KÊ NHÂN VIÊN VIỆN CNTT";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // grpDanhSach
            this.grpDanhSach.Controls.Add(this.dgvThongKeNV);
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpDanhSach.Location = new System.Drawing.Point(20, 55);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(840, 360);
            this.grpDanhSach.TabIndex = 1;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách chi tiết nhân viên, trình độ và chuyên môn";

            // dgvThongKeNV
            this.dgvThongKeNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKeNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongKeNV.Location = new System.Drawing.Point(3, 20);
            this.dgvThongKeNV.Name = "dgvThongKeNV";
            this.dgvThongKeNV.ReadOnly = true;
            this.dgvThongKeNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKeNV.Size = new System.Drawing.Size(834, 337);
            this.dgvThongKeNV.TabIndex = 0;

            // lblTongNV
            this.lblTongNV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTongNV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTongNV.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTongNV.Location = new System.Drawing.Point(0, 420);
            this.lblTongNV.Name = "lblTongNV";
            this.lblTongNV.Size = new System.Drawing.Size(880, 40);
            this.lblTongNV.TabIndex = 2;
            this.lblTongNV.Text = "Tổng số nhân viên: 0 người";
            this.lblTongNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // FormThongKeNhanVien
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 460);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.lblTongNV);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormThongKeNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 4 - Thống Kê Nhân Viên";
            this.Load += new System.EventHandler(this.FormThongKeNhanVien_Load);
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeNV)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
