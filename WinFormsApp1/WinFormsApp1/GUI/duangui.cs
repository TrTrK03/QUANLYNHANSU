using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Text;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Drawing2D;
using OfficeOpenXml;
using ExcelDataReader;
using WinFormsApp1.BUS;
using WinFormsApp1.DTO;
using WinFormsApp1.Imports;
using WinFormsApp1.Exports;
using WinFormsApp1.GUI.detail;
using static System.Windows.Forms.AxHost;
using System.IO;

namespace WinFormsApp1.GUI
{
    public partial class duangui : UserControl
    {
        static duanbus projectBUS = new duanbus();
        duandto projectDTO = new duandto();
        private TextBox txtPhongBanPhuTrach;
        private Label label11;
        private DateTimePicker dtpNgayBatDau;
        private DateTimePicker dtpNgayKetThuc;
        private ComboBox cmbTrangThai;
        List<duandto> projects = projectBUS.GetDuAn();

        private Panel panel1;
        private Panel panel4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button hienhanh;
        private Button tatca;
        private Button dahoanthanh;
        private Panel panel2;
        private Panel panel6;
        private Button delete;
        private Button Import;
        private Button export;
        private Button Tao;
        private TextBox txtSearch;
        private Label label1;
        private Panel panel5;
        private DataGridView dataGridView1;
        private OpenFileDialog openFileDialog1;
        private Panel panel7;
        private TextBox txtMoTa;
        private TextBox txtTenDuAn;
        private TextBox txtQuanLyDuAn;
        private TextBox txtMaDuAn;
        private Label label9;
        private Label label8;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label2;
        private Panel panel8;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label10;
        private Button edit;

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel5 = new Panel();
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
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            hienhanh = new Button();
            tatca = new Button();
            dahoanthanh = new Button();
            panel2 = new Panel();
            panel6 = new Panel();
            edit = new Button();
            delete = new Button();
            Import = new Button();
            export = new Button();
            Tao = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left;
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(252, 250, 255);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(60, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1581, 951);
            panel1.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.AutoScroll = true;
            panel5.BackColor = Color.FromArgb(192, 0, 0);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(dataGridView1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 111);
            panel5.Name = "panel5";
            panel5.Size = new Size(1581, 840);
            panel5.TabIndex = 5;
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
            panel7.Location = new Point(0, 339);
            panel7.Name = "panel7";
            panel7.Size = new Size(1581, 501);
            panel7.TabIndex = 7;
            // 
            // cmbTrangThai
            // 
            cmbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrangThai.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTrangThai.FormattingEnabled = true;
            cmbTrangThai.Items.AddRange(new object[] { "Đang hoạt động", "Đã hoàn thành", "Tạm dừng" });
            cmbTrangThai.Location = new Point(521, 326);
            cmbTrangThai.Name = "cmbTrangThai";
            cmbTrangThai.Size = new Size(344, 40);
            cmbTrangThai.TabIndex = 75;
            // 
            // dtpNgayKetThuc
            // 
            dtpNgayKetThuc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayKetThuc.Format = DateTimePickerFormat.Short;
            dtpNgayKetThuc.Location = new Point(1100, 185);
            dtpNgayKetThuc.Margin = new Padding(6, 5, 6, 5);
            dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            dtpNgayKetThuc.Size = new Size(344, 39);
            dtpNgayKetThuc.TabIndex = 74;
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayBatDau.Format = DateTimePickerFormat.Short;
            dtpNgayBatDau.Location = new Point(521, 185);
            dtpNgayBatDau.Margin = new Padding(6, 5, 6, 5);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(344, 39);
            dtpNgayBatDau.TabIndex = 63;
            // 
            // txtPhongBanPhuTrach
            // 
            txtPhongBanPhuTrach.Location = new Point(1100, 253);
            txtPhongBanPhuTrach.Name = "txtPhongBanPhuTrach";
            txtPhongBanPhuTrach.Size = new Size(344, 27);
            txtPhongBanPhuTrach.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(962, 259);
            label11.Name = "label11";
            label11.Size = new Size(83, 20);
            label11.TabIndex = 5;
            label11.Text = "Phòng ban:";
            // 
            // txtQuanLyDuAn
            // 
            txtQuanLyDuAn.Location = new Point(1100, 113);
            txtQuanLyDuAn.Name = "txtQuanLyDuAn";
            txtQuanLyDuAn.Size = new Size(344, 27);
            txtQuanLyDuAn.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(962, 116);
            label10.Name = "label10";
            label10.Size = new Size(104, 20);
            label10.TabIndex = 3;
            label10.Text = "Quản lý dự án:";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(521, 253);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(344, 27);
            txtMoTa.TabIndex = 2;
            // 
            // txtTenDuAn
            // 
            txtTenDuAn.Location = new Point(521, 113);
            txtTenDuAn.Name = "txtTenDuAn";
            txtTenDuAn.Size = new Size(344, 27);
            txtTenDuAn.TabIndex = 2;
            // 
            // txtMaDuAn
            // 
            txtMaDuAn.Location = new Point(521, 47);
            txtMaDuAn.Name = "txtMaDuAn";
            txtMaDuAn.Size = new Size(344, 27);
            txtMaDuAn.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(962, 188);
            label9.Name = "label9";
            label9.Size = new Size(103, 20);
            label9.TabIndex = 1;
            label9.Text = "Ngày kết thúc:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(392, 329);
            label8.Name = "label8";
            label8.Size = new Size(78, 20);
            label8.TabIndex = 1;
            label8.Text = "Trạng thái:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(392, 183);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 1;
            label5.Text = "Ngày bắt đầu:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(392, 256);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 1;
            label6.Text = "Mô tả:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(392, 116);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 1;
            label3.Text = "Tên dự án:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(392, 47);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã dự án:";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(255, 192, 255);
            panel8.Controls.Add(pictureBox1);
            panel8.Location = new Point(52, 45);
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 70;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.GridColor = SystemColors.Info;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 100;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(1581, 339);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(200, 158, 255);
            panel4.Location = new Point(0, 108);
            panel4.Name = "panel4";
            panel4.Size = new Size(157, 3);
            panel4.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(hienhanh);
            flowLayoutPanel1.Controls.Add(tatca);
            flowLayoutPanel1.Controls.Add(dahoanthanh);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Font = new Font("Bahnschrift Light", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flowLayoutPanel1.Location = new Point(0, 51);
            flowLayoutPanel1.Margin = new Padding(3, 0, 3, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1581, 60);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.MouseClick += flowLayoutPanel1_MouseClick;
            // 
            // hienhanh
            // 
            hienhanh.AutoSize = true;
            hienhanh.CausesValidation = false;
            hienhanh.FlatAppearance.BorderSize = 0;
            hienhanh.FlatStyle = FlatStyle.Flat;
            hienhanh.Font = new Font("Segoe UI", 15F);
            hienhanh.ForeColor = Color.FromArgb(64, 64, 64);
            hienhanh.Location = new Point(3, 3);
            hienhanh.Name = "hienhanh";
            hienhanh.Size = new Size(138, 57);
            hienhanh.TabIndex = 0;
            hienhanh.Text = "Hiện hành";
            hienhanh.UseVisualStyleBackColor = true;
            hienhanh.Click += hienhanh_Click;
            // 
            // tatca
            // 
            tatca.Anchor = AnchorStyles.None;
            tatca.AutoSize = true;
            tatca.CausesValidation = false;
            tatca.FlatAppearance.BorderSize = 0;
            tatca.FlatStyle = FlatStyle.Flat;
            tatca.Font = new Font("Segoe UI", 15F);
            tatca.Location = new Point(147, 4);
            tatca.Name = "tatca";
            tatca.Size = new Size(94, 56);
            tatca.TabIndex = 1;
            tatca.Text = "Tất cả";
            tatca.UseVisualStyleBackColor = true;
            tatca.Click += tatca_Click;
            // 
            // dahoanthanh
            // 
            dahoanthanh.Anchor = AnchorStyles.None;
            dahoanthanh.AutoSize = true;
            dahoanthanh.CausesValidation = false;
            dahoanthanh.FlatAppearance.BorderSize = 0;
            dahoanthanh.FlatStyle = FlatStyle.Flat;
            dahoanthanh.Font = new Font("Segoe UI", 15F);
            dahoanthanh.Location = new Point(247, 3);
            dahoanthanh.Name = "dahoanthanh";
            dahoanthanh.Size = new Size(189, 58);
            dahoanthanh.TabIndex = 2;
            dahoanthanh.Text = "Đã hoàn thành";
            dahoanthanh.UseVisualStyleBackColor = true;
            dahoanthanh.Click += dahoanthanh_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.FromArgb(49, 17, 117);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1581, 51);
            panel2.TabIndex = 0;
            panel2.MouseClick += panel2_MouseClick;
            // 
            // panel6
            // 
            panel6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel6.BackColor = Color.White;
            panel6.Controls.Add(edit);
            panel6.Controls.Add(delete);
            panel6.Controls.Add(Import);
            panel6.Controls.Add(export);
            panel6.Controls.Add(Tao);
            panel6.Controls.Add(txtSearch);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(239, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1342, 49);
            panel6.TabIndex = 6;
            panel6.MouseClick += panel6_MouseClick;
            // 
            // edit
            // 
            edit.BackColor = Color.Lavender;
            edit.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            edit.FlatStyle = FlatStyle.Flat;
            edit.Location = new Point(485, 1);
            edit.Name = "edit";
            edit.Size = new Size(130, 49);
            edit.TabIndex = 10;
            edit.Text = "Edit";
            edit.UseVisualStyleBackColor = false;
            edit.Click += edit_Click;
            // 
            // delete
            // 
            delete.BackColor = Color.Lavender;
            delete.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            delete.FlatStyle = FlatStyle.Flat;
            delete.Location = new Point(656, 0);
            delete.Name = "delete";
            delete.Size = new Size(130, 49);
            delete.TabIndex = 9;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // Import
            // 
            Import.BackColor = Color.Lavender;
            Import.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            Import.FlatStyle = FlatStyle.Flat;
            Import.Location = new Point(824, 0);
            Import.Name = "Import";
            Import.Size = new Size(130, 49);
            Import.TabIndex = 9;
            Import.Text = "Import";
            Import.UseVisualStyleBackColor = false;
            Import.Click += Import_Click;
            // 
            // export
            // 
            export.BackColor = Color.Lavender;
            export.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            export.FlatStyle = FlatStyle.Flat;
            export.Location = new Point(996, 0);
            export.Name = "export";
            export.Size = new Size(130, 49);
            export.TabIndex = 8;
            export.Text = "Export";
            export.UseVisualStyleBackColor = false;
            export.Click += export_Click;
            // 
            // Tao
            // 
            Tao.BackColor = Color.LimeGreen;
            Tao.Dock = DockStyle.Right;
            Tao.FlatAppearance.BorderSize = 0;
            Tao.FlatStyle = FlatStyle.Flat;
            Tao.Image = Properties.Resources.add2;
            Tao.Location = new Point(1219, 0);
            Tao.Name = "Tao";
            Tao.Size = new Size(123, 49);
            Tao.TabIndex = 2;
            Tao.UseVisualStyleBackColor = false;
            Tao.Click += Tao_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(8, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(344, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(49, 17, 117);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(241, 49);
            label1.TabIndex = 1;
            label1.Text = "Dự án";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(252, 250, 255);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 49);
            panel3.Name = "panel3";
            panel3.Size = new Size(1581, 2);
            panel3.TabIndex = 0;
            panel3.Visible = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // duangui
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.White;
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(49, 17, 117);
            Margin = new Padding(0);
            Name = "duangui";
            Size = new Size(1653, 979);
            Load += duangui_Load;
            MouseClick += duangui_MouseClick;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        private void LoadDataToGUI(int a)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Check", typeof(bool));
            dt.Columns.Add("Ma Du An", typeof(string));
            dt.Columns.Add("Ten Du An", typeof(string));
            dt.Columns.Add("Mo Ta", typeof(string));
            dt.Columns.Add("Ngay Bat Dau", typeof(string));
            dt.Columns.Add("Ngay Ket Thuc", typeof(string));
            dt.Columns.Add("Quan Ly Du An", typeof(string));
            dt.Columns.Add("Phong Ban Phu Trach", typeof(string));
            dt.Columns.Add("Trang Thai", typeof(int));

            if (a == 2)
            {
                foreach (duandto project in projects)
                {
                    dt.Rows.Add(false, project.MaDuAn, project.TenDuAn, project.MoTa, project.NgayBatDau.ToString("dd/MM/yyyy"), project.NgayKetThuc.ToString("dd/MM/yyyy"), project.QuanLyDuAn, project.PhongBanPhuTrach, project.TrangThai);
                }
                dataGridView1.DataSource = dt;
            }
            else
            {
                var filteredProjects = projects.Where(p => p.TrangThai == a).ToList();

                foreach (duandto project in filteredProjects)
                {
                    dt.Rows.Add(false, project.MaDuAn, project.TenDuAn, project.MoTa, project.NgayBatDau.ToString("dd/MM/yyyy"), project.NgayKetThuc.ToString("dd/MM/yyyy"), project.QuanLyDuAn, project.PhongBanPhuTrach, project.TrangThai);
                }
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = dataGridView1.ColumnHeadersDefaultCellStyle.BackColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor;
        }

        public duangui()
        {
            InitializeComponent();
            panel4.Width = hienhanh.Width;
            panel4.Left = hienhanh.Left;
            hienhanh.ForeColor = Color.Green;
        }

        private void duangui_Load(object sender, EventArgs e)
        {
            LoadDataToGUI(1);
            txtSearch.PlaceholderText = "Tìm kiếm ...";
            dataGridView1.Size = new Size(1575, 870);
            panel7.Visible = false;
            panel4.Width = hienhanh.Width;
            panel4.Left = hienhanh.Left;
            hienhanh.ForeColor = Color.FromArgb(49, 17, 117);
            tatca.ForeColor = Color.FromArgb(64, 64, 64);
            dahoanthanh.ForeColor = Color.FromArgb(64, 64, 64);
        }

        string maDuAnSelected;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.Size = new Size(1575, 450);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.FromArgb(49, 17, 117);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Lavender;

            panel7.Visible = true;

            maDuAnSelected = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            duandto selectedProject = projects.FirstOrDefault(project => project.MaDuAn == maDuAnSelected);

            if (selectedProject != null)
            {
                txtMaDuAn.Text = selectedProject.MaDuAn.Trim();
                txtTenDuAn.Text = selectedProject.TenDuAn.Trim();
                txtMoTa.Text = selectedProject.MoTa.Trim();
                dtpNgayBatDau.Value = selectedProject.NgayBatDau;
                dtpNgayKetThuc.Value = selectedProject.NgayKetThuc;
                txtQuanLyDuAn.Text = selectedProject.QuanLyDuAn.Trim();
                txtPhongBanPhuTrach.Text = selectedProject.PhongBanPhuTrach.Trim();
                cmbTrangThai.SelectedIndex = selectedProject.TrangThai - 1;
            }
        }

        private void duangui_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.Size = new Size(1575, 870);
            panel7.Visible = false;
            dataGridView1.ClearSelection();
        }

        private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.Size = new Size(1575, 870);
            panel7.Visible = false;
            dataGridView1.ClearSelection();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.Size = new Size(1575, 870);
            panel7.Visible = false;
            dataGridView1.ClearSelection();
        }

        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.Size = new Size(1575, 870);
            panel7.Visible = false;
            dataGridView1.ClearSelection();
        }

        private void dahoanthanh_Click(object sender, EventArgs e)
        {
            panel4.Width = dahoanthanh.Width;
            panel4.Left = dahoanthanh.Left;
            hienhanh.ForeColor = Color.FromArgb(64, 64, 64);
            tatca.ForeColor = Color.FromArgb(64, 64, 64);
            dahoanthanh.ForeColor = Color.FromArgb(49, 17, 117);
            LoadDataToGUI(2);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            duandto selectedProject = projects.FirstOrDefault(project => project.MaDuAn == maDuAnSelected);
            if (selectedProject != null)
            {
                if (selectedProject.TrangThai == 1)
                {
                    try
                    {
                        projectBUS.UpdateDuAn(new duandto { MaDuAn = selectedProject.MaDuAn, TrangThai = 0 });
                        MessageBox.Show("Xóa dự án thành công!!!");
                        LoadDataToGUI(1);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi xảy ra trong quá trình xóa: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Dự án này đã được xóa hoặc hoàn thành!!!");
                }
            }
            else
            {
                MessageBox.Show("Chọn một dự án để xóa!");
            }
        }

        private void hienhanh_Click(object sender, EventArgs e)
        {
            panel4.Width = hienhanh.Width;
            panel4.Left = hienhanh.Left;
            hienhanh.ForeColor = Color.FromArgb(49, 17, 117);
            tatca.ForeColor = Color.FromArgb(64, 64, 64);
            dahoanthanh.ForeColor = Color.FromArgb(64, 64, 64);
            LoadDataToGUI(1);
        }

        private void tatca_Click(object sender, EventArgs e)
        {
            panel4.Width = tatca.Width;
            panel4.Left = tatca.Left;
            hienhanh.ForeColor = Color.FromArgb(64, 64, 64);
            dahoanthanh.ForeColor = Color.FromArgb(64, 64, 64);
            tatca.ForeColor = Color.FromArgb(49, 17, 117);
            LoadDataToGUI(2);
        }

        private void edit_Click(object sender, EventArgs e)
        {
            duandto selectedProject = projects.FirstOrDefault(project => project.MaDuAn == maDuAnSelected);

            if (selectedProject != null)
            {
                SuaDuAn interf = new SuaDuAn(selectedProject);
                interf.StartPosition = FormStartPosition.CenterParent;
                interf.ShowDialog();
                LoadDataToGUI(1);
            }
            else
            {
                MessageBox.Show("Chọn một dự án để chỉnh sửa!");
            }
        }

        private void Tao_Click(object sender, EventArgs e)
        {
            //TaoDuAn interf = new TaoDuAn();
            //interf.StartPosition = FormStartPosition.CenterParent;
            //interf.ShowDialog();
            //LoadDataToGUI(1);
        }

        private void Import_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Title = "Chọn tệp Excel",
                    Filter = "Excel Files (*.xlsx;*.xls)|*.xlsx;*.xls|All Files (*.*)|*.*",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    Import im = new Import();
                    im.ImportProjectByExcel(filePath);
                    MessageBox.Show("Import dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataToGUI(1);
                }
                else
                {
                    MessageBox.Show("Bạn đã hủy chọn file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Chọn vị trí lưu file",
                Filter = "Excel Files (*.xlsx)|*.xlsx|Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                DefaultExt = "xlsx",
                AddExtension = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                MessageBox.Show($"File sẽ được lưu tại: {filePath}", "Thông báo");

                export ex = new export();
                ex.SaveProjectToExcel(filePath);
            }
            else
            {
                MessageBox.Show("Bạn đã hủy lưu file.", "Thông báo");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.ToLower();

            if (string.IsNullOrWhiteSpace(searchValue))
            {
                txtSearch.PlaceholderText = "Tìm kiếm ...";
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Visible = string.IsNullOrEmpty(searchValue) || RowContainsValue(row, searchValue);
            }
        }

        private bool RowContainsValue(DataGridViewRow row, string searchValue)
        {
            foreach (DataGridViewCell cell in row.Cells)
            {
                if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchValue))
                {
                    return true;
                }
            }
            return false;
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            txtSearch.PlaceholderText = "Tìm kiếm ...";
        }
    }
}