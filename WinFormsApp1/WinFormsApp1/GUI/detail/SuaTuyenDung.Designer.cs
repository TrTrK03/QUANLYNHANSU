namespace WinFormsApp1.GUI.detail
{
    partial class SuaTuyenDung
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            txtMaKyTuyenDung = new TextBox();
            txtNoiDung = new TextBox();
            txtQuanLy = new TextBox();
            dtpNgayBatDau = new DateTimePicker();
            dtpNgayKetThuc = new DateTimePicker();
            btnHuy = new Button();
            btnSua = new Button();
            labelMaDuAn = new Label();
            labelMoTa = new Label();
            labelQuanLyDuAn = new Label();
            labelNgayBatDau = new Label();
            labelNgayKetThuc = new Label();
            SuspendLayout();
            // 
            // txtMaKyTuyenDung
            // 
            txtMaKyTuyenDung.Enabled = false;
            txtMaKyTuyenDung.Location = new Point(144, 20);
            txtMaKyTuyenDung.Name = "txtMaKyTuyenDung";
            txtMaKyTuyenDung.Size = new Size(200, 27);
            txtMaKyTuyenDung.TabIndex = 0;
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(144, 64);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(200, 60);
            txtNoiDung.TabIndex = 2;
            // 
            // txtQuanLy
            // 
            txtQuanLy.Location = new Point(144, 140);
            txtQuanLy.Name = "txtQuanLy";
            txtQuanLy.Size = new Size(200, 27);
            txtQuanLy.TabIndex = 3;
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.Format = DateTimePickerFormat.Short;
            dtpNgayBatDau.Location = new Point(144, 194);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(200, 27);
            dtpNgayBatDau.TabIndex = 5;
            // 
            // dtpNgayKetThuc
            // 
            dtpNgayKetThuc.Format = DateTimePickerFormat.Short;
            dtpNgayKetThuc.Location = new Point(144, 229);
            dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            dtpNgayKetThuc.Size = new Size(200, 27);
            dtpNgayKetThuc.TabIndex = 6;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(82, 288);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(79, 28);
            btnHuy.TabIndex = 9;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click_1;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(207, 288);
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
            labelMaDuAn.Location = new Point(13, 23);
            labelMaDuAn.Name = "labelMaDuAn";
            labelMaDuAn.Size = new Size(132, 20);
            labelMaDuAn.TabIndex = 11;
            labelMaDuAn.Text = "Mã Kỳ Tuyển Dụng";
            // 
            // labelMoTa
            // 
            labelMoTa.AutoSize = true;
            labelMoTa.Location = new Point(31, 67);
            labelMoTa.Name = "labelMoTa";
            labelMoTa.Size = new Size(73, 20);
            labelMoTa.TabIndex = 13;
            labelMoTa.Text = "Nội Dung";
            // 
            // labelQuanLyDuAn
            // 
            labelQuanLyDuAn.AutoSize = true;
            labelQuanLyDuAn.Location = new Point(31, 143);
            labelQuanLyDuAn.Name = "labelQuanLyDuAn";
            labelQuanLyDuAn.Size = new Size(61, 20);
            labelQuanLyDuAn.TabIndex = 14;
            labelQuanLyDuAn.Text = "Quản Lý";
            // 
            // labelNgayBatDau
            // 
            labelNgayBatDau.AutoSize = true;
            labelNgayBatDau.Location = new Point(31, 194);
            labelNgayBatDau.Name = "labelNgayBatDau";
            labelNgayBatDau.Size = new Size(101, 20);
            labelNgayBatDau.TabIndex = 16;
            labelNgayBatDau.Text = "Ngày Bắt Đầu";
            // 
            // labelNgayKetThuc
            // 
            labelNgayKetThuc.AutoSize = true;
            labelNgayKetThuc.Location = new Point(31, 234);
            labelNgayKetThuc.Name = "labelNgayKetThuc";
            labelNgayKetThuc.Size = new Size(105, 20);
            labelNgayKetThuc.TabIndex = 17;
            labelNgayKetThuc.Text = "Ngày Kết Thúc";
            // 
            // SuaTuyenDung
            // 
            ClientSize = new Size(388, 341);
            Controls.Add(labelNgayKetThuc);
            Controls.Add(labelNgayBatDau);
            Controls.Add(labelQuanLyDuAn);
            Controls.Add(labelMoTa);
            Controls.Add(labelMaDuAn);
            Controls.Add(btnSua);
            Controls.Add(btnHuy);
            Controls.Add(dtpNgayKetThuc);
            Controls.Add(dtpNgayBatDau);
            Controls.Add(txtQuanLy);
            Controls.Add(txtNoiDung);
            Controls.Add(txtMaKyTuyenDung);
            Name = "SuaTuyenDung";
            Text = "Sửa Tuyển Dụng";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtMaKyTuyenDung;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtQuanLy;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label labelMaDuAn;
        private System.Windows.Forms.Label labelMoTa;
        private System.Windows.Forms.Label labelQuanLyDuAn;
        private System.Windows.Forms.Label labelNgayBatDau;
        private System.Windows.Forms.Label labelNgayKetThuc;
    }
}
