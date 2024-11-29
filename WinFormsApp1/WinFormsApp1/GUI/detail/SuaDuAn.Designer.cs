namespace WinFormsApp1.GUI.detail
{
    partial class SuaDuAn
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            txtMaDuAn = new TextBox();
            txtTenDuAn = new TextBox();
            txtMoTa = new TextBox();
            txtQuanLyDuAn = new TextBox();
            txtPhongBan = new TextBox();
            dtpNgayBatDau = new DateTimePicker();
            dtpNgayKetThuc = new DateTimePicker();
            btnHuy = new Button();
            btnSua = new Button();
            labelMaDuAn = new Label();
            labelTenDuAn = new Label();
            labelMoTa = new Label();
            labelQuanLyDuAn = new Label();
            labelPhongBan = new Label();
            labelNgayBatDau = new Label();
            labelNgayKetThuc = new Label();
            SuspendLayout();
            // 
            // txtMaDuAn
            // 
            txtMaDuAn.Enabled = false;
            txtMaDuAn.Location = new Point(120, 20);
            txtMaDuAn.Name = "txtMaDuAn";
            txtMaDuAn.Size = new Size(200, 27);
            txtMaDuAn.TabIndex = 0;
            // 
            // txtTenDuAn
            // 
            txtTenDuAn.Location = new Point(120, 60);
            txtTenDuAn.Name = "txtTenDuAn";
            txtTenDuAn.Size = new Size(200, 27);
            txtTenDuAn.TabIndex = 1;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(120, 100);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(200, 60);
            txtMoTa.TabIndex = 2;
            // 
            // txtQuanLyDuAn
            // 
            txtQuanLyDuAn.Location = new Point(143, 180);
            txtQuanLyDuAn.Name = "txtQuanLyDuAn";
            txtQuanLyDuAn.Size = new Size(200, 27);
            txtQuanLyDuAn.TabIndex = 3;
            // 
            // txtPhongBan
            // 
            txtPhongBan.Location = new Point(143, 220);
            txtPhongBan.Name = "txtPhongBan";
            txtPhongBan.Size = new Size(200, 27);
            txtPhongBan.TabIndex = 4;
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.Format = DateTimePickerFormat.Short;
            dtpNgayBatDau.Location = new Point(143, 263);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(200, 27);
            dtpNgayBatDau.TabIndex = 5;
            // 
            // dtpNgayKetThuc
            // 
            dtpNgayKetThuc.Format = DateTimePickerFormat.Short;
            dtpNgayKetThuc.Location = new Point(143, 298);
            dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            dtpNgayKetThuc.Size = new Size(200, 27);
            dtpNgayKetThuc.TabIndex = 6;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(75, 365);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(79, 28);
            btnHuy.TabIndex = 9;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click_1;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(200, 365);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 28);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click_1;
            // 
            // labelMaDuAn
            // 
            labelMaDuAn.AutoSize = true;
            labelMaDuAn.Location = new Point(30, 23);
            labelMaDuAn.Name = "labelMaDuAn";
            labelMaDuAn.Size = new Size(76, 20);
            labelMaDuAn.TabIndex = 11;
            labelMaDuAn.Text = "Mã Dự Án";
            // 
            // labelTenDuAn
            // 
            labelTenDuAn.AutoSize = true;
            labelTenDuAn.Location = new Point(30, 63);
            labelTenDuAn.Name = "labelTenDuAn";
            labelTenDuAn.Size = new Size(78, 20);
            labelTenDuAn.TabIndex = 12;
            labelTenDuAn.Text = "Tên Dự Án";
            // 
            // labelMoTa
            // 
            labelMoTa.AutoSize = true;
            labelMoTa.Location = new Point(30, 103);
            labelMoTa.Name = "labelMoTa";
            labelMoTa.Size = new Size(51, 20);
            labelMoTa.TabIndex = 13;
            labelMoTa.Text = "Mô Tả";
            // 
            // labelQuanLyDuAn
            // 
            labelQuanLyDuAn.AutoSize = true;
            labelQuanLyDuAn.Location = new Point(30, 183);
            labelQuanLyDuAn.Name = "labelQuanLyDuAn";
            labelQuanLyDuAn.Size = new Size(107, 20);
            labelQuanLyDuAn.TabIndex = 14;
            labelQuanLyDuAn.Text = "Quản Lý Dự Án";
            // 
            // labelPhongBan
            // 
            labelPhongBan.AutoSize = true;
            labelPhongBan.Location = new Point(30, 223);
            labelPhongBan.Name = "labelPhongBan";
            labelPhongBan.Size = new Size(103, 20);
            labelPhongBan.TabIndex = 15;
            labelPhongBan.Text = "Phòng Ban P.T";
            // 
            // labelNgayBatDau
            // 
            labelNgayBatDau.AutoSize = true;
            labelNgayBatDau.Location = new Point(30, 263);
            labelNgayBatDau.Name = "labelNgayBatDau";
            labelNgayBatDau.Size = new Size(101, 20);
            labelNgayBatDau.TabIndex = 16;
            labelNgayBatDau.Text = "Ngày Bắt Đầu";
            // 
            // labelNgayKetThuc
            // 
            labelNgayKetThuc.AutoSize = true;
            labelNgayKetThuc.Location = new Point(30, 303);
            labelNgayKetThuc.Name = "labelNgayKetThuc";
            labelNgayKetThuc.Size = new Size(105, 20);
            labelNgayKetThuc.TabIndex = 17;
            labelNgayKetThuc.Text = "Ngày Kết Thúc";
            // 
            // SuaDuAn
            // 
            ClientSize = new Size(388, 420);
            Controls.Add(labelNgayKetThuc);
            Controls.Add(labelNgayBatDau);
            Controls.Add(labelPhongBan);
            Controls.Add(labelQuanLyDuAn);
            Controls.Add(labelMoTa);
            Controls.Add(labelTenDuAn);
            Controls.Add(labelMaDuAn);
            Controls.Add(btnSua);
            Controls.Add(btnHuy);
            Controls.Add(dtpNgayKetThuc);
            Controls.Add(dtpNgayBatDau);
            Controls.Add(txtPhongBan);
            Controls.Add(txtQuanLyDuAn);
            Controls.Add(txtMoTa);
            Controls.Add(txtTenDuAn);
            Controls.Add(txtMaDuAn);
            Name = "SuaDuAn";
            Text = "Sửa Dự Án";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtMaDuAn;
        private System.Windows.Forms.TextBox txtTenDuAn;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtQuanLyDuAn;
        private System.Windows.Forms.TextBox txtPhongBan;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label labelMaDuAn;
        private System.Windows.Forms.Label labelTenDuAn;
        private System.Windows.Forms.Label labelMoTa;
        private System.Windows.Forms.Label labelQuanLyDuAn;
        private System.Windows.Forms.Label labelPhongBan;
        private System.Windows.Forms.Label labelNgayBatDau;
        private System.Windows.Forms.Label labelNgayKetThuc;
    }
}
