namespace WinFormsApp1.GUI.detail
{
    partial class SuaPhucLoi
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
            txtMaPhucLoi = new TextBox();
            txtTenPhucLoi = new TextBox();
            txtMoTa = new TextBox();
            txtGiaTriPhucLoi = new TextBox();
            txtTrangThai = new TextBox();
            labelMaPhucLoi = new Label();
            labelTenPhucLoi = new Label();
            labelMoTa = new Label();
            labelGiaTriPhucLoi = new Label();
            labelTrangThai = new Label();
            btnHuy = new Button();
            btnSua = new Button();
            SuspendLayout();
            // 
            // txtMaPhucLoi
            // 
            txtMaPhucLoi.Enabled = false;
            txtMaPhucLoi.Location = new Point(136, 33);
            txtMaPhucLoi.Name = "txtMaPhucLoi";
            txtMaPhucLoi.Size = new Size(200, 27);
            txtMaPhucLoi.TabIndex = 1;
            // 
            // txtTenPhucLoi
            // 
            txtTenPhucLoi.Enabled = false;
            txtTenPhucLoi.Location = new Point(136, 66);
            txtTenPhucLoi.Name = "txtTenPhucLoi";
            txtTenPhucLoi.Size = new Size(200, 27);
            txtTenPhucLoi.TabIndex = 2;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(136, 99);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(200, 60);
            txtMoTa.TabIndex = 3;
            // 
            // txtGiaTriPhucLoi
            // 
            txtGiaTriPhucLoi.Location = new Point(136, 165);
            txtGiaTriPhucLoi.Name = "txtGiaTriPhucLoi";
            txtGiaTriPhucLoi.Size = new Size(200, 27);
            txtGiaTriPhucLoi.TabIndex = 4;
            // 
            // txtTrangThai
            // 
            txtTrangThai.Location = new Point(136, 198);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.Size = new Size(200, 27);
            txtTrangThai.TabIndex = 5;
            // 
            // labelMaPhucLoi
            // 
            labelMaPhucLoi.AutoSize = true;
            labelMaPhucLoi.Location = new Point(44, 36);
            labelMaPhucLoi.Name = "labelMaPhucLoi";
            labelMaPhucLoi.Size = new Size(89, 20);
            labelMaPhucLoi.TabIndex = 12;
            labelMaPhucLoi.Text = "Mã Phúc Lợi";
            // 
            // labelTenPhucLoi
            // 
            labelTenPhucLoi.AutoSize = true;
            labelTenPhucLoi.Location = new Point(39, 69);
            labelTenPhucLoi.Name = "labelTenPhucLoi";
            labelTenPhucLoi.Size = new Size(91, 20);
            labelTenPhucLoi.TabIndex = 13;
            labelTenPhucLoi.Text = "Tên Phúc Lợi";
            // 
            // labelMoTa
            // 
            labelMoTa.AutoSize = true;
            labelMoTa.Location = new Point(54, 102);
            labelMoTa.Name = "labelMoTa";
            labelMoTa.Size = new Size(51, 20);
            labelMoTa.TabIndex = 14;
            labelMoTa.Text = "Mô Tả";
            // 
            // labelGiaTriPhucLoi
            // 
            labelGiaTriPhucLoi.AutoSize = true;
            labelGiaTriPhucLoi.Location = new Point(23, 168);
            labelGiaTriPhucLoi.Name = "labelGiaTriPhucLoi";
            labelGiaTriPhucLoi.Size = new Size(110, 20);
            labelGiaTriPhucLoi.TabIndex = 15;
            labelGiaTriPhucLoi.Text = "Giá Trị Phúc Lợi";
            // 
            // labelTrangThai
            // 
            labelTrangThai.AutoSize = true;
            labelTrangThai.Location = new Point(54, 201);
            labelTrangThai.Name = "labelTrangThai";
            labelTrangThai.Size = new Size(78, 20);
            labelTrangThai.TabIndex = 16;
            labelTrangThai.Text = "Trạng Thái";
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(54, 258);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(79, 28);
            btnHuy.TabIndex = 17;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(233, 258);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 28);
            btnSua.TabIndex = 18;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // SuaPhucLoi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 317);
            Controls.Add(btnSua);
            Controls.Add(btnHuy);
            Controls.Add(labelTrangThai);
            Controls.Add(labelGiaTriPhucLoi);
            Controls.Add(labelMoTa);
            Controls.Add(labelTenPhucLoi);
            Controls.Add(labelMaPhucLoi);
            Controls.Add(txtTrangThai);
            Controls.Add(txtGiaTriPhucLoi);
            Controls.Add(txtMoTa);
            Controls.Add(txtTenPhucLoi);
            Controls.Add(txtMaPhucLoi);
            Name = "SuaPhucLoi";
            Text = "Sửa Phúc Lợi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaPhucLoi;
        private TextBox txtTenPhucLoi;
        private TextBox txtMoTa;
        private TextBox txtGiaTriPhucLoi;
        private TextBox txtTrangThai;
        private Label labelMaPhucLoi;
        private Label labelTenPhucLoi;
        private Label labelMoTa;
        private Label labelGiaTriPhucLoi;
        private Label labelTrangThai;
        private Button btnHuy;
        private Button btnSua;
    }
}