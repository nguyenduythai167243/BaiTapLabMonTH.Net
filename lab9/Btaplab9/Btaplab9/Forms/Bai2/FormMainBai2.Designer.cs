namespace Btaplab9.Forms.Bai2
{
    partial class FormMainBai2
    {
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyDiem;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyMonHoc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpQuickAccess;
        private System.Windows.Forms.Button btnQuanLyDiem;
        private System.Windows.Forms.Button btnQuanLyMonHoc;

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
            this.mnuQuanLyDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpQuickAccess = new System.Windows.Forms.GroupBox();
            this.btnQuanLyDiem = new System.Windows.Forms.Button();
            this.btnQuanLyMonHoc = new System.Windows.Forms.Button();

            this.menuStrip1.SuspendLayout();
            this.grpQuickAccess.SuspendLayout();
            this.SuspendLayout();

            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuQuanLy
            });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";

            // 
            // mnuQuanLy
            // 
            this.mnuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuQuanLyDiem,
                this.mnuQuanLyMonHoc,
                this.toolStripSeparator1,
                this.mnuThoat
            });
            this.mnuQuanLy.Name = "mnuQuanLy";
            this.mnuQuanLy.Size = new System.Drawing.Size(60, 20);
            this.mnuQuanLy.Text = "&Quản lý";

            // 
            // mnuQuanLyDiem
            // 
            this.mnuQuanLyDiem.Name = "mnuQuanLyDiem";
            this.mnuQuanLyDiem.Size = new System.Drawing.Size(170, 22);
            this.mnuQuanLyDiem.Text = "Quản lý &điểm";
            this.mnuQuanLyDiem.Click += new System.EventHandler(this.MnuQuanLyDiem_Click);

            // 
            // mnuQuanLyMonHoc
            // 
            this.mnuQuanLyMonHoc.Name = "mnuQuanLyMonHoc";
            this.mnuQuanLyMonHoc.Size = new System.Drawing.Size(170, 22);
            this.mnuQuanLyMonHoc.Text = "Quản lý &môn học";
            this.mnuQuanLyMonHoc.Click += new System.EventHandler(this.MnuQuanLyMonHoc_Click);

            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);

            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(170, 22);
            this.mnuThoat.Text = "Th&oát";
            this.mnuThoat.Click += new System.EventHandler(this.MnuThoat_Click);

            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(0, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(600, 60);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "BÀI 2 - HỆ THỐNG QUẢN LÝ ĐIỂM VÀ MÔN HỌC";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // grpQuickAccess
            // 
            this.grpQuickAccess.Controls.Add(this.btnQuanLyDiem);
            this.grpQuickAccess.Controls.Add(this.btnQuanLyMonHoc);
            this.grpQuickAccess.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpQuickAccess.Location = new System.Drawing.Point(50, 100);
            this.grpQuickAccess.Name = "grpQuickAccess";
            this.grpQuickAccess.Size = new System.Drawing.Size(500, 180);
            this.grpQuickAccess.TabIndex = 2;
            this.grpQuickAccess.TabStop = false;
            this.grpQuickAccess.Text = "Truy cập nhanh chức năng";

            // 
            // btnQuanLyMonHoc
            // 
            this.btnQuanLyMonHoc.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnQuanLyMonHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyMonHoc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuanLyMonHoc.Location = new System.Drawing.Point(50, 50);
            this.btnQuanLyMonHoc.Name = "btnQuanLyMonHoc";
            this.btnQuanLyMonHoc.Size = new System.Drawing.Size(180, 80);
            this.btnQuanLyMonHoc.TabIndex = 0;
            this.btnQuanLyMonHoc.Text = "Quản Lý Môn Học";
            this.btnQuanLyMonHoc.UseVisualStyleBackColor = false;
            this.btnQuanLyMonHoc.Click += new System.EventHandler(this.BtnQuanLyMonHoc_Click);

            // 
            // btnQuanLyDiem
            // 
            this.btnQuanLyDiem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnQuanLyDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyDiem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuanLyDiem.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyDiem.Location = new System.Drawing.Point(270, 50);
            this.btnQuanLyDiem.Name = "btnQuanLyDiem";
            this.btnQuanLyDiem.Size = new System.Drawing.Size(180, 80);
            this.btnQuanLyDiem.TabIndex = 1;
            this.btnQuanLyDiem.Text = "Quản Lý Điểm";
            this.btnQuanLyDiem.UseVisualStyleBackColor = false;
            this.btnQuanLyDiem.Click += new System.EventHandler(this.BtnQuanLyDiem_Click);

            // 
            // FormMainBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 320);
            this.Controls.Add(this.grpQuickAccess);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMainBai2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 2 - Form Main Quản lý Điểm & Môn Học";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpQuickAccess.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
