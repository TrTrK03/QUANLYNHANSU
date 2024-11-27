namespace WinFormsApp1.GUI.detail
{
    partial class TaoDuAn
    {
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new Label();
            txtMaDuAn = new TextBox();
            labelMaDuAn = new Label();
            txtTenDuAn = new TextBox();
            labelTenDuAn = new Label();
            txtMoTa = new TextBox();
            labelMoTa = new Label();
            dtpNgayBatDau = new DateTimePicker();
            labelNgayBatDau = new Label();
            dtpNgayKetThuc = new DateTimePicker();
            labelNgayKetThuc = new Label();
            txtQuanLyDuAn = new TextBox();
            labelQuanLyDuAn = new Label();
            txtPhongBanPhuTrach = new TextBox();
            labelPhongBan = new Label();
            cbTrangThai = new ComboBox();
            labelTrangThai = new Label();
            btnHuy = new Button();
            btnTao = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            labelTitle.Location = new Point(229, 27);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(279, 67);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Tạo Dự Án";
            // 
            // txtMaDuAn
            // 
            txtMaDuAn.Font = new Font("Microsoft Sans Serif", 12F);
            txtMaDuAn.Location = new Point(217, 133);
            txtMaDuAn.Margin = new Padding(3, 4, 3, 4);
            txtMaDuAn.Name = "txtMaDuAn";
            txtMaDuAn.Size = new Size(274, 30);
            txtMaDuAn.TabIndex = 1;
            // 
            // labelMaDuAn
            // 
            labelMaDuAn.AutoSize = true;
            labelMaDuAn.Font = new Font("Segoe UI", 14.25F);
            labelMaDuAn.Location = new Point(57, 133);
            labelMaDuAn.Name = "labelMaDuAn";
            labelMaDuAn.Size = new Size(122, 32);
            labelMaDuAn.TabIndex = 2;
            labelMaDuAn.Text = "Mã Dự Án";
            // 
            // txtTenDuAn
            // 
            txtTenDuAn.Font = new Font("Microsoft Sans Serif", 12F);
            txtTenDuAn.Location = new Point(217, 200);
            txtTenDuAn.Margin = new Padding(3, 4, 3, 4);
            txtTenDuAn.Name = "txtTenDuAn";
            txtTenDuAn.Size = new Size(274, 30);
            txtTenDuAn.TabIndex = 3;
            // 
            // labelTenDuAn
            // 
            labelTenDuAn.AutoSize = true;
            labelTenDuAn.Font = new Font("Segoe UI", 14.25F);
            labelTenDuAn.Location = new Point(57, 200);
            labelTenDuAn.Name = "labelTenDuAn";
            labelTenDuAn.Size = new Size(126, 32);
            labelTenDuAn.TabIndex = 4;
            labelTenDuAn.Text = "Tên Dự Án";
            // 
            // txtMoTa
            // 
            txtMoTa.Font = new Font("Microsoft Sans Serif", 12F);
            txtMoTa.Location = new Point(217, 267);
            txtMoTa.Margin = new Padding(3, 4, 3, 4);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(274, 105);
            txtMoTa.TabIndex = 5;
            // 
            // labelMoTa
            // 
            labelMoTa.AutoSize = true;
            labelMoTa.Font = new Font("Segoe UI", 14.25F);
            labelMoTa.Location = new Point(57, 267);
            labelMoTa.Name = "labelMoTa";
            labelMoTa.Size = new Size(82, 32);
            labelMoTa.TabIndex = 6;
            labelMoTa.Text = "Mô Tả";
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.Font = new Font("Microsoft Sans Serif", 12F);
            dtpNgayBatDau.Format = DateTimePickerFormat.Short;
            dtpNgayBatDau.Location = new Point(217, 400);
            dtpNgayBatDau.Margin = new Padding(3, 4, 3, 4);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(274, 30);
            dtpNgayBatDau.TabIndex = 7;
            // 
            // labelNgayBatDau
            // 
            labelNgayBatDau.AutoSize = true;
            labelNgayBatDau.Font = new Font("Segoe UI", 14.25F);
            labelNgayBatDau.Location = new Point(57, 400);
            labelNgayBatDau.Name = "labelNgayBatDau";
            labelNgayBatDau.Size = new Size(161, 32);
            labelNgayBatDau.TabIndex = 8;
            labelNgayBatDau.Text = "Ngày Bắt Đầu";
            // 
            // dtpNgayKetThuc
            // 
            dtpNgayKetThuc.Font = new Font("Microsoft Sans Serif", 12F);
            dtpNgayKetThuc.Format = DateTimePickerFormat.Short;
            dtpNgayKetThuc.Location = new Point(217, 467);
            dtpNgayKetThuc.Margin = new Padding(3, 4, 3, 4);
            dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            dtpNgayKetThuc.Size = new Size(274, 30);
            dtpNgayKetThuc.TabIndex = 9;
            // 
            // labelNgayKetThuc
            // 
            labelNgayKetThuc.AutoSize = true;
            labelNgayKetThuc.Font = new Font("Segoe UI", 14.25F);
            labelNgayKetThuc.Location = new Point(57, 467);
            labelNgayKetThuc.Name = "labelNgayKetThuc";
            labelNgayKetThuc.Size = new Size(171, 32);
            labelNgayKetThuc.TabIndex = 10;
            labelNgayKetThuc.Text = "Ngày Kết Thúc";
            // 
            // txtQuanLyDuAn
            // 
            txtQuanLyDuAn.Font = new Font("Microsoft Sans Serif", 12F);
            txtQuanLyDuAn.Location = new Point(217, 533);
            txtQuanLyDuAn.Margin = new Padding(3, 4, 3, 4);
            txtQuanLyDuAn.Name = "txtQuanLyDuAn";
            txtQuanLyDuAn.Size = new Size(274, 30);
            txtQuanLyDuAn.TabIndex = 11;
            // 
            // labelQuanLyDuAn
            // 
            labelQuanLyDuAn.AutoSize = true;
            labelQuanLyDuAn.Font = new Font("Segoe UI", 14.25F);
            labelQuanLyDuAn.Location = new Point(57, 533);
            labelQuanLyDuAn.Name = "labelQuanLyDuAn";
            labelQuanLyDuAn.Size = new Size(175, 32);
            labelQuanLyDuAn.TabIndex = 12;
            labelQuanLyDuAn.Text = "Quản Lý Dự Án";
            // 
            // txtPhongBanPhuTrach
            // 
            txtPhongBanPhuTrach.Font = new Font("Microsoft Sans Serif", 12F);
            txtPhongBanPhuTrach.Location = new Point(217, 600);
            txtPhongBanPhuTrach.Margin = new Padding(3, 4, 3, 4);
            txtPhongBanPhuTrach.Name = "txtPhongBanPhuTrach";
            txtPhongBanPhuTrach.Size = new Size(274, 30);
            txtPhongBanPhuTrach.TabIndex = 13;
            // 
            // labelPhongBan
            // 
            labelPhongBan.AutoSize = true;
            labelPhongBan.Font = new Font("Segoe UI", 14.25F);
            labelPhongBan.Location = new Point(57, 600);
            labelPhongBan.Name = "labelPhongBan";
            labelPhongBan.Size = new Size(163, 32);
            labelPhongBan.TabIndex = 14;
            labelPhongBan.Text = "Phòng Ban PT";
            // 
            // cbTrangThai
            // 
            cbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTrangThai.Font = new Font("Microsoft Sans Serif", 12F);
            cbTrangThai.Items.AddRange(new object[] { "Đang Thực Hiện", "Hoàn Thành", "Hủy" });
            cbTrangThai.Location = new Point(217, 667);
            cbTrangThai.Margin = new Padding(3, 4, 3, 4);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(274, 33);
            cbTrangThai.TabIndex = 15;
            // 
            // labelTrangThai
            // 
            labelTrangThai.AutoSize = true;
            labelTrangThai.Font = new Font("Segoe UI", 14.25F);
            labelTrangThai.Location = new Point(57, 667);
            labelTrangThai.Name = "labelTrangThai";
            labelTrangThai.Size = new Size(125, 32);
            labelTrangThai.TabIndex = 16;
            labelTrangThai.Text = "Trạng Thái";
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Segoe UI", 12F);
            btnHuy.Location = new Point(229, 733);
            btnHuy.Margin = new Padding(3, 4, 3, 4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(114, 53);
            btnHuy.TabIndex = 17;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnTao
            // 
            btnTao.Font = new Font("Segoe UI", 12F);
            btnTao.Location = new Point(377, 733);
            btnTao.Margin = new Padding(3, 4, 3, 4);
            btnTao.Name = "btnTao";
            btnTao.Size = new Size(114, 53);
            btnTao.TabIndex = 18;
            btnTao.Text = "Tạo";
            btnTao.UseVisualStyleBackColor = true;
            // 
            // TaoDuAn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 827);
            Controls.Add(labelTitle);
            Controls.Add(labelMaDuAn);
            Controls.Add(txtMaDuAn);
            Controls.Add(labelTenDuAn);
            Controls.Add(txtTenDuAn);
            Controls.Add(labelMoTa);
            Controls.Add(txtMoTa);
            Controls.Add(labelNgayBatDau);
            Controls.Add(dtpNgayBatDau);
            Controls.Add(labelNgayKetThuc);
            Controls.Add(dtpNgayKetThuc);
            Controls.Add(labelQuanLyDuAn);
            Controls.Add(txtQuanLyDuAn);
            Controls.Add(labelPhongBan);
            Controls.Add(txtPhongBanPhuTrach);
            Controls.Add(labelTrangThai);
            Controls.Add(cbTrangThai);
            Controls.Add(btnHuy);
            Controls.Add(btnTao);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TaoDuAn";
            Text = "Tạo Dự Án";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private TextBox txtMaDuAn;
        private Label labelMaDuAn;
        private TextBox txtTenDuAn;
        private Label labelTenDuAn;
        private TextBox txtMoTa;
        private Label labelMoTa;
        private DateTimePicker dtpNgayBatDau;
        private Label labelNgayBatDau;
        private DateTimePicker dtpNgayKetThuc;
        private Label labelNgayKetThuc;
        private TextBox txtQuanLyDuAn;
        private Label labelQuanLyDuAn;
        private TextBox txtPhongBanPhuTrach;
        private Label labelPhongBan;
        private ComboBox cbTrangThai;
        private Label labelTrangThai;
        private Button btnHuy;
        private Button btnTao;
    }
}
