namespace WinFormsApp1.GUI.detail
{
    partial class SuaThongBao
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            txtMaThongBao = new TextBox();
            txtNoiDung = new TextBox();
            txtNguoiBanHanh = new TextBox();
            dtpNgayBanHanh = new DateTimePicker();
            btnHuy = new Button();
            btnSua = new Button();
            labelMaDuAn = new Label();
            labelMoTa = new Label();
            labelQuanLyDuAn = new Label();
            labelNgayBatDau = new Label();
            SuspendLayout();
            // 
            // txtMaThongBao
            // 
            txtMaThongBao.Enabled = false;
            txtMaThongBao.Location = new Point(143, 20);
            txtMaThongBao.Name = "txtMaThongBao";
            txtMaThongBao.Size = new Size(200, 27);
            txtMaThongBao.TabIndex = 0;
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(143, 66);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(200, 60);
            txtNoiDung.TabIndex = 2;
            // 
            // txtNguoiBanHanh
            // 
            txtNguoiBanHanh.Location = new Point(143, 134);
            txtNguoiBanHanh.Name = "txtNguoiBanHanh";
            txtNguoiBanHanh.Size = new Size(200, 27);
            txtNguoiBanHanh.TabIndex = 3;
            // 
            // dtpNgayBanHanh
            // 
            dtpNgayBanHanh.Format = DateTimePickerFormat.Short;
            dtpNgayBanHanh.Location = new Point(143, 174);
            dtpNgayBanHanh.Name = "dtpNgayBanHanh";
            dtpNgayBanHanh.Size = new Size(200, 27);
            dtpNgayBanHanh.TabIndex = 5;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(63, 225);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(79, 28);
            btnHuy.TabIndex = 9;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click_1;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(188, 225);
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
            labelMaDuAn.Location = new Point(12, 23);
            labelMaDuAn.Name = "labelMaDuAn";
            labelMaDuAn.Size = new Size(106, 20);
            labelMaDuAn.TabIndex = 11;
            labelMaDuAn.Text = "Mã Thông Báo";
            // 
            // labelMoTa
            // 
            labelMoTa.AutoSize = true;
            labelMoTa.Location = new Point(12, 69);
            labelMoTa.Name = "labelMoTa";
            labelMoTa.Size = new Size(71, 20);
            labelMoTa.TabIndex = 13;
            labelMoTa.Text = "Nội dung";
            // 
            // labelQuanLyDuAn
            // 
            labelQuanLyDuAn.AutoSize = true;
            labelQuanLyDuAn.Location = new Point(12, 137);
            labelQuanLyDuAn.Name = "labelQuanLyDuAn";
            labelQuanLyDuAn.Size = new Size(116, 20);
            labelQuanLyDuAn.TabIndex = 14;
            labelQuanLyDuAn.Text = "Người ban hành";
            // 
            // labelNgayBatDau
            // 
            labelNgayBatDau.AutoSize = true;
            labelNgayBatDau.Location = new Point(12, 179);
            labelNgayBatDau.Name = "labelNgayBatDau";
            labelNgayBatDau.Size = new Size(112, 20);
            labelNgayBatDau.TabIndex = 16;
            labelNgayBatDau.Text = "Ngày Ban Hành";
            // 
            // SuaThongBao
            // 
            ClientSize = new Size(375, 288);
            Controls.Add(labelNgayBatDau);
            Controls.Add(labelQuanLyDuAn);
            Controls.Add(labelMoTa);
            Controls.Add(labelMaDuAn);
            Controls.Add(btnSua);
            Controls.Add(btnHuy);
            Controls.Add(dtpNgayBanHanh);
            Controls.Add(txtNguoiBanHanh);
            Controls.Add(txtNoiDung);
            Controls.Add(txtMaThongBao);
            Name = "SuaThongBao";
            Text = "Sửa Thông Báo";
            Load += SuaThongBao_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtMaThongBao;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtNguoiBanHanh;
        private System.Windows.Forms.DateTimePicker dtpNgayBanHanh;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label labelMaDuAn;
        private System.Windows.Forms.Label labelMoTa;
        private System.Windows.Forms.Label labelQuanLyDuAn;
        private System.Windows.Forms.Label labelNgayBatDau;
    }
}
