namespace WinFormsApp1.GUI.detail
{
    partial class TaoThongBao
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
            txtMaThongBao = new TextBox();
            labelMaDuAn = new Label();
            txtNoiDung = new TextBox();
            labelMoTa = new Label();
            dtpNgayBanHanh = new DateTimePicker();
            labelNgayBatDau = new Label();
            txtNguoiBanHanh = new TextBox();
            labelQuanLyDuAn = new Label();
            btnHuy = new Button();
            btnTao = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            labelTitle.Location = new Point(195, 30);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(279, 67);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Tạo Dự Án";
            // 
            // txtMaThongBao
            // 
            txtMaThongBao.Font = new Font("Microsoft Sans Serif", 12F);
            txtMaThongBao.Location = new Point(289, 133);
            txtMaThongBao.Margin = new Padding(3, 4, 3, 4);
            txtMaThongBao.Name = "txtMaThongBao";
            txtMaThongBao.Size = new Size(274, 30);
            txtMaThongBao.TabIndex = 1;
            // 
            // labelMaDuAn
            // 
            labelMaDuAn.AutoSize = true;
            labelMaDuAn.Font = new Font("Segoe UI", 14.25F);
            labelMaDuAn.Location = new Point(63, 130);
            labelMaDuAn.Name = "labelMaDuAn";
            labelMaDuAn.Size = new Size(171, 32);
            labelMaDuAn.TabIndex = 2;
            labelMaDuAn.Text = "Mã Thông Báo";
            // 
            // txtNoiDung
            // 
            txtNoiDung.Font = new Font("Microsoft Sans Serif", 12F);
            txtNoiDung.Location = new Point(289, 171);
            txtNoiDung.Margin = new Padding(3, 4, 3, 4);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(274, 105);
            txtNoiDung.TabIndex = 5;
            // 
            // labelMoTa
            // 
            labelMoTa.AutoSize = true;
            labelMoTa.Font = new Font("Segoe UI", 14.25F);
            labelMoTa.Location = new Point(63, 168);
            labelMoTa.Name = "labelMoTa";
            labelMoTa.Size = new Size(115, 32);
            labelMoTa.TabIndex = 6;
            labelMoTa.Text = "Nội dung";
            // 
            // dtpNgayBanHanh
            // 
            dtpNgayBanHanh.Font = new Font("Microsoft Sans Serif", 12F);
            dtpNgayBanHanh.Format = DateTimePickerFormat.Short;
            dtpNgayBanHanh.Location = new Point(289, 295);
            dtpNgayBanHanh.Margin = new Padding(3, 4, 3, 4);
            dtpNgayBanHanh.Name = "dtpNgayBanHanh";
            dtpNgayBanHanh.Size = new Size(274, 30);
            dtpNgayBanHanh.TabIndex = 7;
            // 
            // labelNgayBatDau
            // 
            labelNgayBatDau.AutoSize = true;
            labelNgayBatDau.Font = new Font("Segoe UI", 14.25F);
            labelNgayBatDau.Location = new Point(63, 294);
            labelNgayBatDau.Name = "labelNgayBatDau";
            labelNgayBatDau.Size = new Size(181, 32);
            labelNgayBatDau.TabIndex = 8;
            labelNgayBatDau.Text = "Ngày Ban Hành";
            // 
            // txtNguoiBanHanh
            // 
            txtNguoiBanHanh.Font = new Font("Microsoft Sans Serif", 12F);
            txtNguoiBanHanh.Location = new Point(289, 355);
            txtNguoiBanHanh.Margin = new Padding(3, 4, 3, 4);
            txtNguoiBanHanh.Name = "txtNguoiBanHanh";
            txtNguoiBanHanh.Size = new Size(274, 30);
            txtNguoiBanHanh.TabIndex = 11;
            // 
            // labelQuanLyDuAn
            // 
            labelQuanLyDuAn.AutoSize = true;
            labelQuanLyDuAn.Font = new Font("Segoe UI", 14.25F);
            labelQuanLyDuAn.Location = new Point(63, 352);
            labelQuanLyDuAn.Name = "labelQuanLyDuAn";
            labelQuanLyDuAn.Size = new Size(188, 32);
            labelQuanLyDuAn.TabIndex = 12;
            labelQuanLyDuAn.Text = "Người Ban hành";
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Segoe UI", 12F);
            btnHuy.Location = new Point(157, 419);
            btnHuy.Margin = new Padding(3, 4, 3, 4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(114, 53);
            btnHuy.TabIndex = 17;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click_1;
            // 
            // btnTao
            // 
            btnTao.Font = new Font("Segoe UI", 12F);
            btnTao.Location = new Point(305, 419);
            btnTao.Margin = new Padding(3, 4, 3, 4);
            btnTao.Name = "btnTao";
            btnTao.Size = new Size(114, 53);
            btnTao.TabIndex = 18;
            btnTao.Text = "Tạo";
            btnTao.UseVisualStyleBackColor = true;
            btnTao.Click += btnTao_Click_1;
            // 
            // TaoThongBao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 493);
            Controls.Add(labelTitle);
            Controls.Add(labelMaDuAn);
            Controls.Add(txtMaThongBao);
            Controls.Add(labelMoTa);
            Controls.Add(txtNoiDung);
            Controls.Add(labelNgayBatDau);
            Controls.Add(dtpNgayBanHanh);
            Controls.Add(labelQuanLyDuAn);
            Controls.Add(txtNguoiBanHanh);
            Controls.Add(btnHuy);
            Controls.Add(btnTao);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TaoThongBao";
            Text = "Tạo Dự Án";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private TextBox txtMaThongBao;
        private Label labelMaDuAn;
        private TextBox txtNoiDung;
        private Label labelMoTa;
        private DateTimePicker dtpNgayBanHanh;
        private Label labelNgayBatDau;
        private TextBox txtNguoiBanHanh;
        private Label labelQuanLyDuAn;
        private Button btnHuy;
        private Button btnTao;
    }
}
