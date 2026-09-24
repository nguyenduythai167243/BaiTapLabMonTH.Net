namespace Btaplab9.Forms.Guided
{
    partial class FrmTimkiemMH
    {
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox group_tieuchi;
        private System.Windows.Forms.Label lbl_timtheo;
        private System.Windows.Forms.RadioButton radio_mamh;
        private System.Windows.Forms.RadioButton radio_tenmh;
        private System.Windows.Forms.Label lbl_noidungTK;
        private System.Windows.Forms.TextBox txt_noidungTK;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.GroupBox group_ketqua;
        private System.Windows.Forms.ListView listview_kqtimkiem;
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
            this.group_tieuchi = new System.Windows.Forms.GroupBox();
            this.lbl_timtheo = new System.Windows.Forms.Label();
            this.radio_mamh = new System.Windows.Forms.RadioButton();
            this.radio_tenmh = new System.Windows.Forms.RadioButton();
            this.lbl_noidungTK = new System.Windows.Forms.Label();
            this.txt_noidungTK = new System.Windows.Forms.TextBox();
            this.bt_tim = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.group_ketqua = new System.Windows.Forms.GroupBox();
            this.listview_kqtimkiem = new System.Windows.Forms.ListView();
            this.colMaMH = new System.Windows.Forms.ColumnHeader();
            this.colTenMH = new System.Windows.Forms.ColumnHeader();
            this.colDVT = new System.Windows.Forms.ColumnHeader();

            this.group_tieuchi.SuspendLayout();
            this.group_ketqua.SuspendLayout();
            this.SuspendLayout();

            // lbl_title
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_title.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.ForeColor = System.Drawing.Color.Red;
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(640, 50);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "TÌM KIẾM MẶT HÀNG";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // group_tieuchi
            this.group_tieuchi.Controls.Add(this.lbl_timtheo);
            this.group_tieuchi.Controls.Add(this.radio_mamh);
            this.group_tieuchi.Controls.Add(this.radio_tenmh);
            this.group_tieuchi.Controls.Add(this.lbl_noidungTK);
            this.group_tieuchi.Controls.Add(this.txt_noidungTK);
            this.group_tieuchi.Controls.Add(this.bt_tim);
            this.group_tieuchi.Controls.Add(this.bt_thoat);
            this.group_tieuchi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.group_tieuchi.Location = new System.Drawing.Point(20, 55);
            this.group_tieuchi.Name = "group_tieuchi";
            this.group_tieuchi.Size = new System.Drawing.Size(600, 130);
            this.group_tieuchi.TabIndex = 1;
            this.group_tieuchi.TabStop = false;
            this.group_tieuchi.Text = "Tiêu chí tìm kiếm";

            // lbl_timtheo
            this.lbl_timtheo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_timtheo.Location = new System.Drawing.Point(30, 25);
            this.lbl_timtheo.Name = "lbl_timtheo";
            this.lbl_timtheo.Size = new System.Drawing.Size(90, 20);
            this.lbl_timtheo.Text = "Tìm theo:";

            // radio_mamh
            this.radio_mamh.AutoSize = true;
            this.radio_mamh.Checked = true;
            this.radio_mamh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radio_mamh.Location = new System.Drawing.Point(130, 23);
            this.radio_mamh.Name = "radio_mamh";
            this.radio_mamh.Size = new System.Drawing.Size(67, 19);
            this.radio_mamh.TabIndex = 1;
            this.radio_mamh.TabStop = true;
            this.radio_mamh.Text = "Mã MH";

            // radio_tenmh
            this.radio_tenmh.AutoSize = true;
            this.radio_tenmh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radio_tenmh.Location = new System.Drawing.Point(230, 23);
            this.radio_tenmh.Name = "radio_tenmh";
            this.radio_tenmh.Size = new System.Drawing.Size(71, 19);
            this.radio_tenmh.TabIndex = 2;
            this.radio_tenmh.Text = "Tên MH";

            // lbl_noidungTK
            this.lbl_noidungTK.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_noidungTK.Location = new System.Drawing.Point(30, 60);
            this.lbl_noidungTK.Name = "lbl_noidungTK";
            this.lbl_noidungTK.Size = new System.Drawing.Size(120, 20);
            this.lbl_noidungTK.Text = "NỘI DUNG tìm kiếm:";

            // txt_noidungTK
            this.txt_noidungTK.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_noidungTK.Location = new System.Drawing.Point(160, 57);
            this.txt_noidungTK.Name = "txt_noidungTK";
            this.txt_noidungTK.Size = new System.Drawing.Size(240, 21);

            // bt_tim
            this.bt_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_tim.Location = new System.Drawing.Point(180, 90);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(90, 28);
            this.bt_tim.TabIndex = 4;
            this.bt_tim.Text = "Tìm";
            this.bt_tim.UseVisualStyleBackColor = true;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);

            // bt_thoat
            this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_thoat.Location = new System.Drawing.Point(290, 90);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(90, 28);
            this.bt_thoat.TabIndex = 5;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);

            // group_ketqua
            this.group_ketqua.Controls.Add(this.listview_kqtimkiem);
            this.group_ketqua.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.group_ketqua.Location = new System.Drawing.Point(20, 195);
            this.group_ketqua.Name = "group_ketqua";
            this.group_ketqua.Size = new System.Drawing.Size(600, 190);
            this.group_ketqua.TabIndex = 2;
            this.group_ketqua.TabStop = false;
            this.group_ketqua.Text = "Kết quả tìm kiếm";

            // listview_kqtimkiem
            this.listview_kqtimkiem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colMaMH,
                this.colTenMH,
                this.colDVT
            });
            this.listview_kqtimkiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listview_kqtimkiem.FullRowSelect = true;
            this.listview_kqtimkiem.GridLines = true;
            this.listview_kqtimkiem.Location = new System.Drawing.Point(3, 17);
            this.listview_kqtimkiem.Name = "listview_kqtimkiem";
            this.listview_kqtimkiem.Size = new System.Drawing.Size(594, 170);
            this.listview_kqtimkiem.TabIndex = 0;
            this.listview_kqtimkiem.UseCompatibleStateImageBehavior = false;
            this.listview_kqtimkiem.View = System.Windows.Forms.View.Details;

            // colMaMH
            this.colMaMH.Text = "Mã MH";
            this.colMaMH.Width = 110;

            // colTenMH
            this.colTenMH.Text = "Tên Mặt Hàng";
            this.colTenMH.Width = 320;

            // colDVT
            this.colDVT.Text = "Đơn Vị Tính";
            this.colDVT.Width = 140;

            // FrmTimkiemMH
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 400);
            this.Controls.Add(this.group_ketqua);
            this.Controls.Add(this.group_tieuchi);
            this.Controls.Add(this.lbl_title);
            this.Name = "FrmTimkiemMH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTimkiemMH";
            this.group_tieuchi.ResumeLayout(false);
            this.group_tieuchi.PerformLayout();
            this.group_ketqua.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
