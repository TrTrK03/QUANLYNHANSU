namespace WinFormsApp1.GUI.detail
{
    partial class SuaPhongBan
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            txtMaPhongBan = new TextBox();
            txtTenPhongBan = new TextBox();
            txtMoTa = new TextBox();
            txtTruongPhong = new TextBox();
            btnHuy = new Button();
            btnSua = new Button();
            labelMaPhongBan = new Label();
            labelTenPhongBan = new Label();
            labelMoTa = new Label();
            labelTruongPhong = new Label();
            SuspendLayout();
            // 
            // txtMaPhongBan
            // 
            txtMaPhongBan.Enabled = false;
            txtMaPhongBan.Location = new Point(120, 27);
            txtMaPhongBan.Name = "txtMaPhongBan";
            txtMaPhongBan.Size = new Size(200, 27);
            txtMaPhongBan.TabIndex = 0;
            // 
            // txtTenPhongBan
            // 
            txtTenPhongBan.Location = new Point(120, 78);
            txtTenPhongBan.Name = "txtTenPhongBan";
            txtTenPhongBan.Size = new Size(200, 27);
            txtTenPhongBan.TabIndex = 1;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(120, 125);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(200, 60);
            txtMoTa.TabIndex = 2;
            // 
            // txtTruongPhong
            // 
            txtTruongPhong.Location = new Point(120, 213);
            txtTruongPhong.Name = "txtTruongPhong";
            txtTruongPhong.Size = new Size(200, 27);
            txtTruongPhong.TabIndex = 3;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(120, 260);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(79, 28);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(245, 260);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 28);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click_1;
            // 
            // labelMaPhongBan
            // 
            labelMaPhongBan.AutoSize = true;
            labelMaPhongBan.Location = new Point(12, 27);
            labelMaPhongBan.Name = "labelMaPhongBan";
            labelMaPhongBan.Size = new Size(105, 20);
            labelMaPhongBan.TabIndex = 8;
            labelMaPhongBan.Text = "Mã Phòng Ban";
            // 
            // labelTenPhongBan
            // 
            labelTenPhongBan.AutoSize = true;
            labelTenPhongBan.Location = new Point(12, 78);
            labelTenPhongBan.Name = "labelTenPhongBan";
            labelTenPhongBan.Size = new Size(107, 20);
            labelTenPhongBan.TabIndex = 9;
            labelTenPhongBan.Text = "Tên Phòng Ban";
            // 
            // labelMoTa
            // 
            labelMoTa.AutoSize = true;
            labelMoTa.Location = new Point(30, 140);
            labelMoTa.Name = "labelMoTa";
            labelMoTa.Size = new Size(51, 20);
            labelMoTa.TabIndex = 10;
            labelMoTa.Text = "Mô Tả";
            // 
            // labelTruongPhong
            // 
            labelTruongPhong.AutoSize = true;
            labelTruongPhong.Location = new Point(12, 213);
            labelTruongPhong.Name = "labelTruongPhong";
            labelTruongPhong.Size = new Size(102, 20);
            labelTruongPhong.TabIndex = 11;
            labelTruongPhong.Text = "Trưởng Phòng";
            // 
            // SuaPhongBan
            // 
            ClientSize = new Size(388, 320);
            Controls.Add(labelTruongPhong);
            Controls.Add(labelMoTa);
            Controls.Add(labelTenPhongBan);
            Controls.Add(labelMaPhongBan);
            Controls.Add(btnSua);
            Controls.Add(btnHuy);
            Controls.Add(txtTruongPhong);
            Controls.Add(txtMoTa);
            Controls.Add(txtTenPhongBan);
            Controls.Add(txtMaPhongBan);
            Name = "SuaPhongBan";
            Text = "Sửa Phòng Ban";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtMaPhongBan;
        private System.Windows.Forms.TextBox txtTenPhongBan;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtTruongPhong;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label labelMaPhongBan;
        private System.Windows.Forms.Label labelTenPhongBan;
        private System.Windows.Forms.Label labelMoTa;
        private System.Windows.Forms.Label labelTruongPhong;
    }
}
