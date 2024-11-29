namespace WinFormsApp1.GUI.Info
{
    partial class DuAnInfo
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
            panel7 = new Panel();
            cmbTrangThai = new ComboBox();
            dtpNgayKetThuc = new DateTimePicker();
            dtpNgayBatDau = new DateTimePicker();
            txtPhongBanPhuTrach = new TextBox();
            label11 = new Label();
            txtQuanLyDuAn = new TextBox();
            label10 = new Label();
            txtMoTa = new TextBox();
            txtTenDuAn = new TextBox();
            txtMaDuAn = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel8 = new Panel();
            pictureBox1 = new PictureBox();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.BackColor = Color.Lavender;
            panel7.Controls.Add(cmbTrangThai);
            panel7.Controls.Add(dtpNgayKetThuc);
            panel7.Controls.Add(dtpNgayBatDau);
            panel7.Controls.Add(txtPhongBanPhuTrach);
            panel7.Controls.Add(label11);
            panel7.Controls.Add(txtQuanLyDuAn);
            panel7.Controls.Add(label10);
            panel7.Controls.Add(txtMoTa);
            panel7.Controls.Add(txtTenDuAn);
            panel7.Controls.Add(txtMaDuAn);
            panel7.Controls.Add(label9);
            panel7.Controls.Add(label8);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(label6);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Fill;
            panel7.ForeColor = Color.FromArgb(49, 17, 117);
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(1269, 412);
            panel7.TabIndex = 8;
            // 
            // cmbTrangThai
            // 
            cmbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrangThai.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTrangThai.FormattingEnabled = true;
            cmbTrangThai.Items.AddRange(new object[] { "Đang hoạt động", "Đã hoàn thành", "Tạm dừng" });
            cmbTrangThai.Location = new Point(406, 339);
            cmbTrangThai.Name = "cmbTrangThai";
            cmbTrangThai.Size = new Size(344, 40);
            cmbTrangThai.TabIndex = 75;
            // 
            // dtpNgayKetThuc
            // 
            dtpNgayKetThuc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayKetThuc.Format = DateTimePickerFormat.Short;
            dtpNgayKetThuc.Location = new Point(907, 198);
            dtpNgayKetThuc.Margin = new Padding(6, 5, 6, 5);
            dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            dtpNgayKetThuc.Size = new Size(344, 39);
            dtpNgayKetThuc.TabIndex = 74;
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayBatDau.Format = DateTimePickerFormat.Short;
            dtpNgayBatDau.Location = new Point(406, 198);
            dtpNgayBatDau.Margin = new Padding(6, 5, 6, 5);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(344, 39);
            dtpNgayBatDau.TabIndex = 63;
            // 
            // txtPhongBanPhuTrach
            // 
            txtPhongBanPhuTrach.Location = new Point(907, 266);
            txtPhongBanPhuTrach.Name = "txtPhongBanPhuTrach";
            txtPhongBanPhuTrach.Size = new Size(344, 27);
            txtPhongBanPhuTrach.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(769, 272);
            label11.Name = "label11";
            label11.Size = new Size(83, 20);
            label11.TabIndex = 5;
            label11.Text = "Phòng ban:";
            // 
            // txtQuanLyDuAn
            // 
            txtQuanLyDuAn.Location = new Point(907, 126);
            txtQuanLyDuAn.Name = "txtQuanLyDuAn";
            txtQuanLyDuAn.Size = new Size(344, 27);
            txtQuanLyDuAn.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(769, 129);
            label10.Name = "label10";
            label10.Size = new Size(104, 20);
            label10.TabIndex = 3;
            label10.Text = "Quản lý dự án:";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(406, 266);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(344, 27);
            txtMoTa.TabIndex = 2;
            // 
            // txtTenDuAn
            // 
            txtTenDuAn.Location = new Point(406, 126);
            txtTenDuAn.Name = "txtTenDuAn";
            txtTenDuAn.Size = new Size(344, 27);
            txtTenDuAn.TabIndex = 2;
            // 
            // txtMaDuAn
            // 
            txtMaDuAn.Location = new Point(406, 60);
            txtMaDuAn.Name = "txtMaDuAn";
            txtMaDuAn.Size = new Size(344, 27);
            txtMaDuAn.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(769, 201);
            label9.Name = "label9";
            label9.Size = new Size(103, 20);
            label9.TabIndex = 1;
            label9.Text = "Ngày kết thúc:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(277, 342);
            label8.Name = "label8";
            label8.Size = new Size(78, 20);
            label8.TabIndex = 1;
            label8.Text = "Trạng thái:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(277, 196);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 1;
            label5.Text = "Ngày bắt đầu:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(277, 269);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 1;
            label6.Text = "Mô tả:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(277, 129);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 1;
            label3.Text = "Tên dự án:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 60);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã dự án:";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(255, 192, 255);
            panel8.Controls.Add(pictureBox1);
            panel8.Location = new Point(12, 51);
            panel8.Name = "panel8";
            panel8.Size = new Size(251, 315);
            panel8.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Untitled2;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 315);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // DuAnInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 412);
            Controls.Add(panel7);
            Name = "DuAnInfo";
            Text = "DuAnInfo";
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel7;
        private ComboBox cmbTrangThai;
        private DateTimePicker dtpNgayKetThuc;
        private DateTimePicker dtpNgayBatDau;
        private TextBox txtPhongBanPhuTrach;
        private Label label11;
        private TextBox txtQuanLyDuAn;
        private Label label10;
        private TextBox txtMoTa;
        private TextBox txtTenDuAn;
        private TextBox txtMaDuAn;
        private Label label9;
        private Label label8;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label2;
        private Panel panel8;
        private PictureBox pictureBox1;
    }
}