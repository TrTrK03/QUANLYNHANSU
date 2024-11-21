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
using System;
using System.Drawing;
using System.Windows.Forms;
using OfficeOpenXml;
using ExcelDataReader;
using WinFormsApp1.BUS;
using WinFormsApp1.DTO;
using WinFormsApp1.Imports;
using WinFormsApp1.Exports;
using WinFormsApp1.GUI.detail;
using static System.Windows.Forms.AxHost;
using System;
using System.Collections.Generic;
using System.IO;
using OfficeOpenXml;

//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1.GUI
{
    public partial class nhanviengui : UserControl
    {
        static nhanvienbus employeeBUS = new nhanvienbus();
        nhanviendto employeeDTO = new nhanviendto();
        private TextBox txtPhongBan;
        private Label label11;
        private DateTimePicker dtpNgaySinh;
        private CheckBox cbNu;
        private CheckBox cbNam;
        List<nhanviendto> employees = employeeBUS.GetNhanVien();

        //Khoi tao
        private Panel panel1;
        private Panel panel4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button hienhanh;
        private Button tatca;
        private Button danghi;
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
        private TextBox txtDiaChi;
        private TextBox txtHoTen;
        private TextBox txtDuAn;
        private TextBox txtSdt;
        private TextBox txtEmail;
        private TextBox txtMaNV;
        private Label label9;
        private Label label8;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel8;
        private PictureBox pictureBox1;
        private Panel panel3;
        private TextBox txtNQL;
        private Label label10;
        private Button edit;

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel5 = new Panel();
            panel7 = new Panel();
            cbNu = new CheckBox();
            cbNam = new CheckBox();
            dtpNgaySinh = new DateTimePicker();
            txtPhongBan = new TextBox();
            label11 = new Label();
            txtNQL = new TextBox();
            label10 = new Label();
            txtDiaChi = new TextBox();
            txtHoTen = new TextBox();
            txtDuAn = new TextBox();
            txtSdt = new TextBox();
            txtEmail = new TextBox();
            txtMaNV = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel8 = new Panel();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            hienhanh = new Button();
            tatca = new Button();
            danghi = new Button();
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
            panel1.Location = new Point(60, 60);
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
            panel7.Controls.Add(cbNu);
            panel7.Controls.Add(cbNam);
            panel7.Controls.Add(dtpNgaySinh);
            panel7.Controls.Add(txtPhongBan);
            panel7.Controls.Add(label11);
            panel7.Controls.Add(txtNQL);
            panel7.Controls.Add(label10);
            panel7.Controls.Add(txtDiaChi);
            panel7.Controls.Add(txtHoTen);
            panel7.Controls.Add(txtDuAn);
            panel7.Controls.Add(txtSdt);
            panel7.Controls.Add(txtEmail);
            panel7.Controls.Add(txtMaNV);
            panel7.Controls.Add(label9);
            panel7.Controls.Add(label8);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(label6);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Fill;
            panel7.ForeColor = Color.FromArgb(49, 17, 117);
            panel7.Location = new Point(0, 405);
            panel7.Name = "panel7";
            panel7.Size = new Size(1581, 435);
            panel7.TabIndex = 7;
            // 
            // cbNu
            // 
            cbNu.AutoSize = true;
            cbNu.Font = new Font("Microsoft Sans Serif", 12F);
            cbNu.ImeMode = ImeMode.NoControl;
            cbNu.Location = new Point(649, 260);
            cbNu.Margin = new Padding(6, 5, 6, 5);
            cbNu.Name = "cbNu";
            cbNu.Size = new Size(48, 24);
            cbNu.TabIndex = 74;
            cbNu.Text = "Nữ";
            cbNu.UseVisualStyleBackColor = true;
            // 
            // cbNam
            // 
            cbNam.AutoSize = true;
            cbNam.Font = new Font("Microsoft Sans Serif", 12F);
            cbNam.ImeMode = ImeMode.NoControl;
            cbNam.Location = new Point(521, 260);
            cbNam.Margin = new Padding(6, 5, 6, 5);
            cbNam.Name = "cbNam";
            cbNam.Size = new Size(61, 24);
            cbNam.TabIndex = 73;
            cbNam.Text = "Nam";
            cbNam.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(521, 185);
            dtpNgaySinh.Margin = new Padding(6, 5, 6, 5);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(344, 33);
            dtpNgaySinh.TabIndex = 63;
            // 
            // txtPhongBan
            // 
            txtPhongBan.Location = new Point(1100, 253);
            txtPhongBan.Name = "txtPhongBan";
            txtPhongBan.Size = new Size(344, 34);
            txtPhongBan.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(962, 259);
            label11.Name = "label11";
            label11.Size = new Size(111, 28);
            label11.TabIndex = 5;
            label11.Text = "Phòng ban:";
            // 
            // txtNQL
            // 
            txtNQL.Location = new Point(1100, 180);
            txtNQL.Name = "txtNQL";
            txtNQL.Size = new Size(344, 34);
            txtNQL.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(962, 183);
            label10.Name = "label10";
            label10.Size = new Size(141, 28);
            label10.TabIndex = 3;
            label10.Text = "Người quản lý:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(521, 326);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(344, 34);
            txtDiaChi.TabIndex = 2;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(521, 113);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(344, 34);
            txtHoTen.TabIndex = 2;
            // 
            // txtDuAn
            // 
            txtDuAn.Enabled = false;
            txtDuAn.Location = new Point(1100, 326);
            txtDuAn.Multiline = true;
            txtDuAn.Name = "txtDuAn";
            txtDuAn.Size = new Size(344, 34);
            txtDuAn.TabIndex = 2;
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(1100, 113);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(344, 34);
            txtSdt.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(1100, 47);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(344, 34);
            txtEmail.TabIndex = 2;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(521, 47);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(344, 34);
            txtMaNV.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(962, 329);
            label9.Name = "label9";
            label9.Size = new Size(68, 28);
            label9.TabIndex = 1;
            label9.Text = "Dự án:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(962, 116);
            label8.Name = "label8";
            label8.Size = new Size(132, 28);
            label8.TabIndex = 1;
            label8.Text = "Số điện thoại:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(392, 183);
            label5.Name = "label5";
            label5.Size = new Size(103, 28);
            label5.TabIndex = 1;
            label5.Text = "Ngày sinh:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(962, 45);
            label7.Name = "label7";
            label7.Size = new Size(63, 28);
            label7.TabIndex = 1;
            label7.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(392, 326);
            label6.Name = "label6";
            label6.Size = new Size(71, 28);
            label6.TabIndex = 1;
            label6.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(392, 256);
            label4.Name = "label4";
            label4.Size = new Size(91, 28);
            label4.TabIndex = 1;
            label4.Text = "Giới tính:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(392, 116);
            label3.Name = "label3";
            label3.Size = new Size(75, 28);
            label3.TabIndex = 1;
            label3.Text = "Họ tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(392, 47);
            label2.Name = "label2";
            label2.Size = new Size(76, 28);
            label2.TabIndex = 1;
            label2.Text = "Mã NV:";
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
            dataGridView1.RowTemplate.Height = 100;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(1581, 405);
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
            flowLayoutPanel1.Controls.Add(danghi);
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
            hienhanh.Size = new Size(130, 57);
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
            tatca.Location = new Point(139, 4);
            tatca.Name = "tatca";
            tatca.Size = new Size(94, 56);
            tatca.TabIndex = 1;
            tatca.Text = "Tất cả";
            tatca.UseVisualStyleBackColor = true;
            tatca.Click += tatca_Click;
            // 
            // danghi
            // 
            danghi.Anchor = AnchorStyles.None;
            danghi.AutoSize = true;
            danghi.CausesValidation = false;
            danghi.FlatAppearance.BorderSize = 0;
            danghi.FlatStyle = FlatStyle.Flat;
            danghi.Font = new Font("Segoe UI", 15F);
            danghi.Location = new Point(239, 3);
            danghi.Name = "danghi";
            danghi.Size = new Size(108, 58);
            danghi.TabIndex = 2;
            danghi.Text = "Đã nghỉ";
            danghi.UseVisualStyleBackColor = true;
            danghi.Click += danghi_Click;
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
            txtSearch.Location = new Point(46, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(344, 34);
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
            label1.Size = new Size(171, 49);
            label1.TabIndex = 1;
            label1.Text = "Nhân viên";
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
            // nhanviengui
            // 
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(49, 17, 117);
            Name = "nhanviengui";
            Size = new Size(1698, 1100);
            Load += nhanviengui_Load;
            MouseClick += nhanviengui_MouseClick;
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
            dt.Columns.Add("Ma Nhan Vien", typeof(string));
            dt.Columns.Add("Ho Ten", typeof(string));
            dt.Columns.Add("Ngay sinh", typeof(string));
            dt.Columns.Add("Gioi tinh", typeof(string));
            dt.Columns.Add("Dia chi", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("SDT", typeof(string));
            dt.Columns.Add("Nguoi quan ly", typeof(string));
            dt.Columns.Add("Phong Ban", typeof(string));
            dt.Columns.Add("Chuc vu", typeof(string));
            dt.Columns.Add("Trang Thai", typeof(int));

            if (a == 2)
            {
                foreach (nhanviendto employee in employees)
                {
                    dt.Rows.Add(false, employee.MaNhanVien, employee.HoTen, employee.NgaySinh.ToString(), employee.GioiTinh, employee.DiaChi, employee.Email, employee.SDT, employee.NguoiQuanLy, employee.PhongBan, employee.ChucVu, employee.TrangThai.ToString());
                }
                dataGridView1.DataSource = dt;
            }
            else
            {
                var state = employees.Where(e => e.TrangThai == a).ToList();

                foreach (nhanviendto employee in state)
                {
                    dt.Rows.Add(false, employee.MaNhanVien, employee.HoTen, employee.NgaySinh.ToString(), employee.GioiTinh, employee.DiaChi, employee.Email, employee.SDT, employee.NguoiQuanLy, employee.PhongBan, employee.ChucVu, employee.TrangThai.ToString());
                }
                dataGridView1.DataSource = dt;
            }

        }  //da xong
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = dataGridView1.ColumnHeadersDefaultCellStyle.BackColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor;
        }
        public nhanviengui()
        {
            InitializeComponent();
            panel4.Width = hienhanh.Width;
            panel4.Left = hienhanh.Left;
            hienhanh.ForeColor = Color.Green;

        }

        private void nhanviengui_Load(object? sender, EventArgs e)
        {
            LoadDataToGUI(1);
            txtSearch.PlaceholderText = "Tìm kiếm ...";
            dataGridView1.Size = new Size(1575, 870);
            panel7.Visible = false;
            //dataGridView1.ClearSelection();
            panel4.Width = hienhanh.Width;
            panel4.Left = hienhanh.Left;
            hienhanh.ForeColor = Color.FromArgb(49, 17, 117);
            tatca.ForeColor = Color.FromArgb(64, 64, 64);
            danghi.ForeColor = Color.FromArgb(64, 64, 64);
        }

        string maNVSelected;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //hien thi bang detail

            dataGridView1.Size = new Size(1575, 450);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.FromArgb(49, 17, 117);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Lavender;

            panel7.Visible = true;

            //get data
            maNVSelected = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            nhanviendto selectedEmployee = employees.FirstOrDefault(employee => employee.MaNhanVien == maNVSelected);

            if (selectedEmployee != null)
            {
                txtMaNV.Text = selectedEmployee.MaNhanVien.Trim();
                txtDiaChi.Text = selectedEmployee.DiaChi.Trim();
                txtEmail.Text = selectedEmployee.Email.Trim();
                txtHoTen.Text = selectedEmployee.HoTen.Trim();
                txtNQL.Text = selectedEmployee.NguoiQuanLy.Trim();
                txtPhongBan.Text = selectedEmployee.PhongBan.Trim();
                txtSdt.Text = selectedEmployee.SDT.Trim();
                //DateTime ngaySinh = DateTime.TryParse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                DateTime ngaySinh;

                // Sử dụng TryParse để chuyển đổi giá trị từ DataGridView
                bool isValidDate = DateTime.TryParse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString(), out ngaySinh);

                if (isValidDate)
                {
                    // Gán giá trị cho DateTimePicker nếu chuyển đổi thành công
                    dtpNgaySinh.Value = ngaySinh;
                }
                else
                {
                    MessageBox.Show("Giá trị ngày sinh không hợp lệ.");
                }

                //dtpNgaySinh.Value = ngaySinh;
                //DateTime date = DateTime.Parse(
                if (selectedEmployee.GioiTinh.Trim().ToLower() == "nam")
                {
                    cbNam.Checked = true;
                }
                else if (selectedEmployee.GioiTinh.Trim().ToLower() == "nữ")
                {
                    cbNu.Checked = true;
                }

            }

        }





        private void nhanviengui_MouseClick(object sender, MouseEventArgs e)
        {
            //LoadDataToGUI();
            dataGridView1.Size = new Size(1575, 870);
            panel7.Visible = false;
            dataGridView1.ClearSelection();

        }

        private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            //LoadDataToGUI();
            dataGridView1.Size = new Size(1575, 870);
            panel7.Visible = false;
            dataGridView1.ClearSelection();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            //LoadDataToGUI();
            dataGridView1.Size = new Size(1575, 870);
            panel7.Visible = false;
            dataGridView1.ClearSelection();
        }

        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {
            //LoadDataToGUI();
            dataGridView1.Size = new Size(1575, 870);
            panel7.Visible = false;
            dataGridView1.ClearSelection();
        }

        private void danghi_Click(object sender, EventArgs e)
        {
            panel4.Width = danghi.Width;
            panel4.Left = danghi.Left;
            hienhanh.ForeColor = Color.FromArgb(64, 64, 64);
            tatca.ForeColor = Color.FromArgb(64, 64, 64);
            danghi.ForeColor = Color.FromArgb(49, 17, 117);
            LoadDataToGUI(0);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            nhanviendto selectedEmployee = employees.FirstOrDefault(employee => employee.MaNhanVien == maNVSelected);
            if (selectedEmployee != null)
            {
                if (selectedEmployee.TrangThai == 1)
                {
                    try
                    {
                        employeeBUS.HideEmployee(selectedEmployee);
                        MessageBox.Show("Xóa nhân viên thành công!!!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi xảy ra trong quá trình xóa: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Nhân viên này đã được xóa!!!");
                }
            }
            else
            {
                MessageBox.Show("Chọn một nhân viên để xóa!");
            }
        }

        private void hienhanh_Click(object sender, EventArgs e)
        {
            panel4.Width = hienhanh.Width;
            panel4.Left = hienhanh.Left;
            hienhanh.ForeColor = Color.FromArgb(49, 17, 117);
            tatca.ForeColor = Color.FromArgb(64, 64, 64);
            danghi.ForeColor = Color.FromArgb(64, 64, 64);
            LoadDataToGUI(1);
        }

        private void tatca_Click(object sender, EventArgs e)
        {
            panel4.Width = tatca.Width;
            panel4.Left = tatca.Left;
            hienhanh.ForeColor = Color.FromArgb(64, 64, 64);
            danghi.ForeColor = Color.FromArgb(64, 64, 64);

            tatca.ForeColor = Color.FromArgb(49, 17, 117);
            LoadDataToGUI(2);

        }



        private void edit_Click(object sender, EventArgs e)
        {
            nhanviendto selectedEmployee = employees.FirstOrDefault(employee => employee.MaNhanVien == maNVSelected);

            if (selectedEmployee != null)
            {
                SuaNhanVien interf = new SuaNhanVien(selectedEmployee);
                interf.StartPosition = FormStartPosition.CenterParent;
                interf.ShowDialog();

            }
            else
            {
                MessageBox.Show("Chọn một nhân viên để chỉnh sửa!");
            }
        }

        private void Tao_Click(object sender, EventArgs e)
        {
            TaoNhanVien interf = new TaoNhanVien();
            interf.StartPosition = FormStartPosition.CenterParent;
            interf.ShowDialog();
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

                    // Gọi hàm xử lý import với file được chọn
                    Import im = new Import();
                    im.importEmpByExcel(filePath);

                    MessageBox.Show("Import dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bạn đã hủy chọn file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void export_Click(object sender, EventArgs e)
        {
            // Tạo hộp thoại SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Chọn vị trí lưu file",
                Filter = "Excel Files (*.xlsx)|*.xlsx|Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                DefaultExt = "xlsx", // Định dạng mặc định
                AddExtension = true, // Tự động thêm phần mở rộng
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) // Thư mục mặc định
            };

            // Hiển thị hộp thoại
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                MessageBox.Show($"File sẽ được lưu tại: {filePath}", "Thông báo");

                // Gọi hàm lưu file
                export ex = new export();
                ex.SaveEmployeeToExcel(filePath);

            }
            else
            {
                MessageBox.Show("Bạn đã hủy lưu file.", "Thông báo");
            }
        }

        private void SaveToExcel(string filePath)
        {

            try
            {
                // Đặt LicenseContext để tránh lỗi
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;

                // Khởi tạo EPPlus
                using (ExcelPackage package = new ExcelPackage())
                {
                    // Tạo một worksheet mới
                    var worksheet = package.Workbook.Worksheets.Add("Sheet1");

                    // Ghi dữ liệu vào ô đầu tiên
                    worksheet.Cells[1, 1].Value = "Dữ liệu mẫu";

                    // Lưu file Excel
                    package.SaveAs(new FileInfo(filePath));
                }

                MessageBox.Show("File Excel đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi lưu file Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //string searchValue = txtSearch.Text.ToLower();
            //if (searchValue == "")
            //{
            //    txtSearch.PlaceholderText = "Tìm kiếm ...";
            //}

            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    row.Visible = string.IsNullOrEmpty(searchValue) || RowContainsValue(row, searchValue);
            //}

            string searchValue = txtSearch.Text.ToLower();

            // Kiểm tra và đặt lại placeholder nếu trống
            if (string.IsNullOrWhiteSpace(searchValue))
            {
                txtSearch.PlaceholderText = "Tìm kiếm ...";
            }

            // Lọc các hàng của DataGridView dựa trên giá trị tìm kiếm
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Visible = string.IsNullOrEmpty(searchValue) || RowContainsValue(row, searchValue);
            }
        }

        // Hàm kiểm tra hàng có chứa chuỗi tìm kiếm không
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

        //private void txtSearch_Enter(object sender, EventArgs e)
        //{
        //    if (txtSearch.Text == "Tìm kiếm ...")
        //    {
        //        txtSearch.Text = ""; // Xóa chữ khi người dùng bắt đầu nhập
        //        txtSearch.ForeColor = Color.Black; // Chuyển sang màu chữ thường
        //    }
        //}

        //private void txtSearch_Leave(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txtSearch.Text))
        //    {
        //        txtSearch.Text = "Tìm kiếm ..."; // Hiển thị lại chữ khi trống
        //        txtSearch.ForeColor = Color.Gray; // Chuyển sang màu chữ mờ
        //    }
        //}
    }

}
