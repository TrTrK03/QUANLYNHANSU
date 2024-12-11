namespace WinFormsApp1
{
    partial class index
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Timer timer;

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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            panNav = new Panel();
            khenthuong = new Button();
            chamcong = new Button();
            nhanvien = new Button();
            bangluong = new Button();
            phucloi = new Button();
            thongbao = new Button();
            tuyendung = new Button();
            duan = new Button();
            phongban = new Button();
            panel2 = new Panel();
            label1 = new Label();
            fontDialog1 = new FontDialog();
            panel3 = new Panel();
            panel5 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(panNav);
            panel1.Controls.Add(khenthuong);
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
            panel1.Size = new Size(164, 713);
            panel1.TabIndex = 0;
            // 
            // panNav
            // 
            panNav.BackColor = Color.FromArgb(0, 126, 249);
            panNav.Location = new Point(2, 103);
            panNav.Margin = new Padding(2);
            panNav.Name = "panNav";
            panNav.Size = new Size(5, 71);
            panNav.TabIndex = 3;
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
            khenthuong.Size = new Size(164, 64);
            khenthuong.TabIndex = 4;
            khenthuong.Text = "Khen Thưởng";
            khenthuong.TextAlign = ContentAlignment.MiddleLeft;
            khenthuong.TextImageRelation = TextImageRelation.ImageBeforeText;
            khenthuong.UseVisualStyleBackColor = true;
            khenthuong.Click += button1_Click;
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
            chamcong.Size = new Size(164, 64);
            chamcong.TabIndex = 2;
            chamcong.Text = "Chấm công";
            chamcong.TextAlign = ContentAlignment.MiddleLeft;
            chamcong.TextImageRelation = TextImageRelation.ImageBeforeText;
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
            nhanvien.Size = new Size(164, 64);
            nhanvien.TabIndex = 2;
            nhanvien.Text = "Nhân viên";
            nhanvien.TextAlign = ContentAlignment.MiddleLeft;
            nhanvien.TextImageRelation = TextImageRelation.ImageBeforeText;
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
            bangluong.Size = new Size(164, 64);
            bangluong.TabIndex = 2;
            bangluong.Text = "Bảng lương";
            bangluong.TextAlign = ContentAlignment.MiddleLeft;
            bangluong.TextImageRelation = TextImageRelation.ImageBeforeText;
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
            phucloi.Size = new Size(164, 64);
            phucloi.TabIndex = 2;
            phucloi.Text = "Phúc Lợi";
            phucloi.TextAlign = ContentAlignment.MiddleLeft;
            phucloi.TextImageRelation = TextImageRelation.ImageBeforeText;
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
            thongbao.Size = new Size(164, 64);
            thongbao.TabIndex = 2;
            thongbao.Text = "Thông báo";
            thongbao.TextAlign = ContentAlignment.MiddleLeft;
            thongbao.TextImageRelation = TextImageRelation.ImageBeforeText;
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
            tuyendung.Size = new Size(164, 64);
            tuyendung.TabIndex = 2;
            tuyendung.Text = "Tuyển dụng";
            tuyendung.TextAlign = ContentAlignment.MiddleLeft;
            tuyendung.TextImageRelation = TextImageRelation.ImageBeforeText;
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
            duan.Size = new Size(164, 64);
            duan.TabIndex = 2;
            duan.Text = "Dự án";
            duan.TextAlign = ContentAlignment.MiddleLeft;
            duan.TextImageRelation = TextImageRelation.ImageBeforeText;
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
            phongban.Size = new Size(164, 64);
            phongban.TabIndex = 2;
            phongban.Text = "Phòng ban";
            phongban.TextAlign = ContentAlignment.MiddleLeft;
            phongban.TextImageRelation = TextImageRelation.ImageBeforeText;
            phongban.UseVisualStyleBackColor = true;
            phongban.Click += phongban_Click;
            phongban.Leave += phongban_Leave;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(164, 103);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 64, 64);
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(24, 27);
            label1.Name = "label1";
            label1.Size = new Size(117, 46);
            label1.TabIndex = 0;
            label1.Text = "00 : 00";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.BackColor = Color.Navy;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(164, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1016, 0);
            panel3.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(164, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1016, 713);
            panel5.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += Timer_Tick;
            // 
            // index
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Silver;
            ClientSize = new Size(1180, 713);
            Controls.Add(label1);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2);
            Name = "index";
            Text = "Quản lý nhân sự";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
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
        private Panel panel5;
        private Button khenthuong;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}
