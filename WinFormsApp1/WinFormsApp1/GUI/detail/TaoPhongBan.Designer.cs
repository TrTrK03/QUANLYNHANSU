namespace WinFormsApp1.GUI.detail
{
    partial class TaoPhongBan
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
            txtMaPhongBan = new TextBox();
            labelMaPhongBan = new Label();
            txtTenPhongBan = new TextBox();
            labelTenPhongBan = new Label();
            txtMoTa = new TextBox();
            labelMoTa = new Label();
            txtTruongPhong = new TextBox();
            labelTruongPhong = new Label();
            btnHuy = new Button();
            btnTao = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            labelTitle.Location = new Point(153, 25);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(386, 67);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Tạo Phòng Ban";
            // 
            // txtMaPhongBan
            // 
            txtMaPhongBan.Font = new Font("Microsoft Sans Serif", 12F);
            txtMaPhongBan.Location = new Point(217, 133);
            txtMaPhongBan.Margin = new Padding(3, 4, 3, 4);
            txtMaPhongBan.Name = "txtMaPhongBan";
            txtMaPhongBan.Size = new Size(274, 30);
            txtMaPhongBan.TabIndex = 1;
            // 
            // labelMaPhongBan
            // 
            labelMaPhongBan.AutoSize = true;
            labelMaPhongBan.Font = new Font("Segoe UI", 14.25F);
            labelMaPhongBan.Location = new Point(57, 133);
            labelMaPhongBan.Name = "labelMaPhongBan";
            labelMaPhongBan.Size = new Size(171, 32);
            labelMaPhongBan.TabIndex = 2;
            labelMaPhongBan.Text = "Mã Phòng Ban";
            // 
            // txtTenPhongBan
            // 
            txtTenPhongBan.Font = new Font("Microsoft Sans Serif", 12F);
            txtTenPhongBan.Location = new Point(217, 200);
            txtTenPhongBan.Margin = new Padding(3, 4, 3, 4);
            txtTenPhongBan.Name = "txtTenPhongBan";
            txtTenPhongBan.Size = new Size(274, 30);
            txtTenPhongBan.TabIndex = 3;
            // 
            // labelTenPhongBan
            // 
            labelTenPhongBan.AutoSize = true;
            labelTenPhongBan.Font = new Font("Segoe UI", 14.25F);
            labelTenPhongBan.Location = new Point(57, 200);
            labelTenPhongBan.Name = "labelTenPhongBan";
            labelTenPhongBan.Size = new Size(175, 32);
            labelTenPhongBan.TabIndex = 4;
            labelTenPhongBan.Text = "Tên Phòng Ban";
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
            // txtTruongPhong
            // 
            txtTruongPhong.Font = new Font("Microsoft Sans Serif", 12F);
            txtTruongPhong.Location = new Point(217, 400);
            txtTruongPhong.Margin = new Padding(3, 4, 3, 4);
            txtTruongPhong.Name = "txtTruongPhong";
            txtTruongPhong.Size = new Size(274, 30);
            txtTruongPhong.TabIndex = 7;
            // 
            // labelTruongPhong
            // 
            labelTruongPhong.AutoSize = true;
            labelTruongPhong.Font = new Font("Segoe UI", 14.25F);
            labelTruongPhong.Location = new Point(57, 400);
            labelTruongPhong.Name = "labelTruongPhong";
            labelTruongPhong.Size = new Size(165, 32);
            labelTruongPhong.TabIndex = 8;
            labelTruongPhong.Text = "Trưởng Phòng";
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Segoe UI", 12F);
            btnHuy.Location = new Point(229, 480);
            btnHuy.Margin = new Padding(3, 4, 3, 4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(114, 53);
            btnHuy.TabIndex = 9;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click_1;
            // 
            // btnTao
            // 
            btnTao.Font = new Font("Segoe UI", 12F);
            btnTao.Location = new Point(377, 480);
            btnTao.Margin = new Padding(3, 4, 3, 4);
            btnTao.Name = "btnTao";
            btnTao.Size = new Size(114, 53);
            btnTao.TabIndex = 10;
            btnTao.Text = "Tạo";
            btnTao.UseVisualStyleBackColor = true;
            btnTao.Click += btnTao_Click_1;
            // 
            // TaoPhongBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 563);
            Controls.Add(labelTitle);
            Controls.Add(labelMaPhongBan);
            Controls.Add(txtMaPhongBan);
            Controls.Add(labelTenPhongBan);
            Controls.Add(txtTenPhongBan);
            Controls.Add(labelMoTa);
            Controls.Add(txtMoTa);
            Controls.Add(labelTruongPhong);
            Controls.Add(txtTruongPhong);
            Controls.Add(btnHuy);
            Controls.Add(btnTao);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TaoPhongBan";
            Text = "Tạo Phòng Ban";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private TextBox txtMaPhongBan;
        private Label labelMaPhongBan;
        private TextBox txtTenPhongBan;
        private Label labelTenPhongBan;
        private TextBox txtMoTa;
        private Label labelMoTa;
        private TextBox txtTruongPhong;
        private Label labelTruongPhong;
        private Button btnHuy;
        private Button btnTao;
    }
}
