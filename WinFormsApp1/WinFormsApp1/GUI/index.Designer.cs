﻿namespace WinFormsApp1
{
    partial class index
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            khenthuong = new Button();
            panNav = new Panel();
            chamcong = new Button();
            nhanvien = new Button();
            bangluong = new Button();
            phucloi = new Button();
            thongbao = new Button();
            tuyendung = new Button();
            duan = new Button();
            phongban = new Button();
            panel2 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            fontDialog1 = new FontDialog();
            panel3 = new Panel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(khenthuong);
            panel1.Controls.Add(panNav);
            panel1.Controls.Add(chamcong);
            panel1.Controls.Add(nhanvien);
            panel1.Controls.Add(bangluong);
            panel1.Controls.Add(phucloi);
            panel1.Controls.Add(thongbao);
            panel1.Controls.Add(tuyendung);
            panel1.Controls.Add(duan);
            panel1.Controls.Add(phongban);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(143, 713);
            panel1.TabIndex = 0;
            // 
            // khenthuong
            // 
            khenthuong.Dock = DockStyle.Top;
            khenthuong.FlatAppearance.BorderSize = 0;
            khenthuong.FlatStyle = FlatStyle.Flat;
            khenthuong.ForeColor = Color.FromArgb(192, 192, 255);
            khenthuong.Image = Properties.Resources.home;
            khenthuong.ImageAlign = ContentAlignment.MiddleLeft;
            khenthuong.Location = new Point(0, 615);
            khenthuong.Margin = new Padding(2);
            khenthuong.Name = "khenthuong";
            khenthuong.Size = new Size(143, 64);
            khenthuong.TabIndex = 4;
            khenthuong.Text = "Khen Thưởng";
            khenthuong.TextAlign = ContentAlignment.MiddleRight;
            khenthuong.TextImageRelation = TextImageRelation.TextBeforeImage;
            khenthuong.UseVisualStyleBackColor = true;
            khenthuong.Click += button1_Click;
            // 
            // panNav
            // 
            panNav.BackColor = Color.FromArgb(0, 126, 249);
            panNav.Location = new Point(0, 138);
            panNav.Margin = new Padding(2);
            panNav.Name = "panNav";
            panNav.Size = new Size(5, 71);
            panNav.TabIndex = 3;
            // 
            // chamcong
            // 
            chamcong.Dock = DockStyle.Top;
            chamcong.FlatAppearance.BorderSize = 0;
            chamcong.FlatStyle = FlatStyle.Flat;
            chamcong.ForeColor = Color.FromArgb(192, 192, 255);
            chamcong.Image = Properties.Resources.home;
            chamcong.ImageAlign = ContentAlignment.MiddleLeft;
            chamcong.Location = new Point(0, 551);
            chamcong.Margin = new Padding(2);
            chamcong.Name = "chamcong";
            chamcong.Size = new Size(143, 64);
            chamcong.TabIndex = 2;
            chamcong.Text = "Chấm công";
            chamcong.TextAlign = ContentAlignment.MiddleRight;
            chamcong.TextImageRelation = TextImageRelation.TextBeforeImage;
            chamcong.UseVisualStyleBackColor = true;
            chamcong.Click += chamcong_Click;
            chamcong.Leave += chamcong_Leave;
            // 
            // nhanvien
            // 
            nhanvien.Dock = DockStyle.Top;
            nhanvien.FlatAppearance.BorderSize = 0;
            nhanvien.FlatStyle = FlatStyle.Flat;
            nhanvien.ForeColor = Color.FromArgb(192, 192, 255);
            nhanvien.Image = Properties.Resources.home;
            nhanvien.ImageAlign = ContentAlignment.MiddleLeft;
            nhanvien.Location = new Point(0, 487);
            nhanvien.Margin = new Padding(2);
            nhanvien.Name = "nhanvien";
            nhanvien.Size = new Size(143, 64);
            nhanvien.TabIndex = 2;
            nhanvien.Text = "Nhân viên";
            nhanvien.TextAlign = ContentAlignment.MiddleRight;
            nhanvien.TextImageRelation = TextImageRelation.TextBeforeImage;
            nhanvien.UseVisualStyleBackColor = true;
            nhanvien.Click += nhanvien_Click;
            nhanvien.Leave += nhanvien_Leave;
            // 
            // bangluong
            // 
            bangluong.Dock = DockStyle.Top;
            bangluong.FlatAppearance.BorderSize = 0;
            bangluong.FlatStyle = FlatStyle.Flat;
            bangluong.ForeColor = Color.FromArgb(192, 192, 255);
            bangluong.Image = Properties.Resources.home;
            bangluong.ImageAlign = ContentAlignment.MiddleLeft;
            bangluong.Location = new Point(0, 423);
            bangluong.Margin = new Padding(2);
            bangluong.Name = "bangluong";
            bangluong.Size = new Size(143, 64);
            bangluong.TabIndex = 2;
            bangluong.Text = "Bảng lương";
            bangluong.TextAlign = ContentAlignment.MiddleRight;
            bangluong.TextImageRelation = TextImageRelation.TextBeforeImage;
            bangluong.UseVisualStyleBackColor = true;
            bangluong.Click += bangluong_Click;
            bangluong.Leave += bangluong_Leave;
            // 
            // phucloi
            // 
            phucloi.Dock = DockStyle.Top;
            phucloi.FlatAppearance.BorderSize = 0;
            phucloi.FlatStyle = FlatStyle.Flat;
            phucloi.ForeColor = Color.FromArgb(192, 192, 255);
            phucloi.Image = Properties.Resources.home;
            phucloi.ImageAlign = ContentAlignment.MiddleLeft;
            phucloi.Location = new Point(0, 359);
            phucloi.Margin = new Padding(2);
            phucloi.Name = "phucloi";
            phucloi.Size = new Size(143, 64);
            phucloi.TabIndex = 2;
            phucloi.Text = "Phúc Lợi";
            phucloi.TextAlign = ContentAlignment.MiddleRight;
            phucloi.TextImageRelation = TextImageRelation.TextBeforeImage;
            phucloi.UseVisualStyleBackColor = true;
            phucloi.Click += phucloi_Click;
            phucloi.Leave += phucloi_Leave;
            // 
            // thongbao
            // 
            thongbao.Dock = DockStyle.Top;
            thongbao.FlatAppearance.BorderSize = 0;
            thongbao.FlatStyle = FlatStyle.Flat;
            thongbao.ForeColor = Color.FromArgb(192, 192, 255);
            thongbao.Image = Properties.Resources.home;
            thongbao.ImageAlign = ContentAlignment.MiddleLeft;
            thongbao.Location = new Point(0, 295);
            thongbao.Margin = new Padding(2);
            thongbao.Name = "thongbao";
            thongbao.Size = new Size(143, 64);
            thongbao.TabIndex = 2;
            thongbao.Text = "Thông báo";
            thongbao.TextAlign = ContentAlignment.MiddleRight;
            thongbao.TextImageRelation = TextImageRelation.TextBeforeImage;
            thongbao.UseVisualStyleBackColor = true;
            thongbao.Click += thongbao_Click;
            thongbao.Leave += thongbao_Leave;
            // 
            // tuyendung
            // 
            tuyendung.Dock = DockStyle.Top;
            tuyendung.FlatAppearance.BorderSize = 0;
            tuyendung.FlatStyle = FlatStyle.Flat;
            tuyendung.ForeColor = Color.FromArgb(192, 192, 255);
            tuyendung.Image = Properties.Resources.home;
            tuyendung.ImageAlign = ContentAlignment.MiddleLeft;
            tuyendung.Location = new Point(0, 231);
            tuyendung.Margin = new Padding(2);
            tuyendung.Name = "tuyendung";
            tuyendung.Size = new Size(143, 64);
            tuyendung.TabIndex = 2;
            tuyendung.Text = "Tuyển dụng";
            tuyendung.TextAlign = ContentAlignment.MiddleRight;
            tuyendung.TextImageRelation = TextImageRelation.TextBeforeImage;
            tuyendung.UseVisualStyleBackColor = true;
            tuyendung.Click += tuyendung_Click;
            tuyendung.Leave += tuyendung_Leave;
            // 
            // duan
            // 
            duan.Dock = DockStyle.Top;
            duan.FlatAppearance.BorderSize = 0;
            duan.FlatStyle = FlatStyle.Flat;
            duan.ForeColor = Color.FromArgb(192, 192, 255);
            duan.Image = Properties.Resources.home;
            duan.ImageAlign = ContentAlignment.MiddleLeft;
            duan.Location = new Point(0, 167);
            duan.Margin = new Padding(2);
            duan.Name = "duan";
            duan.Size = new Size(143, 64);
            duan.TabIndex = 2;
            duan.Text = "Dự án";
            duan.TextAlign = ContentAlignment.MiddleRight;
            duan.TextImageRelation = TextImageRelation.TextBeforeImage;
            duan.UseVisualStyleBackColor = true;
            duan.Click += duan_Click;
            duan.Leave += duan_Leave;
            // 
            // phongban
            // 
            phongban.Dock = DockStyle.Top;
            phongban.FlatAppearance.BorderSize = 0;
            phongban.FlatStyle = FlatStyle.Flat;
            phongban.ForeColor = Color.FromArgb(192, 192, 255);
            phongban.Image = Properties.Resources.home;
            phongban.ImageAlign = ContentAlignment.MiddleLeft;
            phongban.Location = new Point(0, 103);
            phongban.Margin = new Padding(2);
            phongban.Name = "phongban";
            phongban.Size = new Size(143, 64);
            phongban.TabIndex = 2;
            phongban.Text = "Phòng ban";
            phongban.TextAlign = ContentAlignment.MiddleRight;
            phongban.TextImageRelation = TextImageRelation.TextBeforeImage;
            phongban.UseVisualStyleBackColor = true;
            phongban.Click += phongban_Click;
            phongban.Leave += phongban_Leave;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(143, 103);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // panel4
            // 
            panel4.Location = new Point(146, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(998, 570);
            panel4.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 156, 149);
            label1.Location = new Point(11, 76);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 1;
            label1.Text = "User name";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox1.Image = Properties.Resources.hr;
            pictureBox1.Location = new Point(38, 11);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.BackColor = Color.Navy;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(143, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1037, 0);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(143, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1037, 713);
            panel5.TabIndex = 2;
            // 
            // index
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1180, 713);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "index";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private FontDialog fontDialog1;
        private Button tuyendung;
        private Button duan;
        private Button phongban;
        private Button chamcong;
        private Button nhanvien;
        private Button bangluong;
        private Button thongbao;
        private Panel panNav;
        private Button phucloi;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Button khenthuong;
    }
}
