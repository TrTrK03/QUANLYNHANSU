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
    public partial class phongbangui : UserControl
    {
        static phongbanbus phongbanBUS = new phongbanbus();
        phongbandto phongbanDTO = new phongbandto();
        private Label label11;
        private DateTimePicker dtpNgaySinh;
        private CheckBox cbNu;
        private CheckBox cbNam;
        List<phongbandto> phongbans = phongbanBUS.GetPhongBan();

        //Khoi tao
        private Panel panel1;
        private Panel panel4;
        private Panel panel2;
        private Panel panel6;
        private Button delete;
        private TextBox txtSearch;
        private Label label1;
        private Panel panel5;
        private DataGridView dataGridView1;
        private OpenFileDialog openFileDialog1;
        private Panel panel7;
        private TextBox txtTenPB;
        private TextBox txtMoTa;
        private TextBox txtTruongPhong;
        private TextBox txtMaPB;
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
            label11 = new Label();
            label10 = new Label();
            txtTenPB = new TextBox();
            txtMoTa = new TextBox();
            txtTruongPhong = new TextBox();
            txtMaPB = new TextBox();
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
            panel2 = new Panel();
            panel6 = new Panel();
            edit = new Button();
            delete = new Button();
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
            panel5.Location = new Point(0, 51);
            panel5.Name = "panel5";
            panel5.Size = new Size(1581, 900);
            panel5.TabIndex = 5;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Lavender;
            panel7.Controls.Add(cbNu);
            panel7.Controls.Add(cbNam);
            panel7.Controls.Add(dtpNgaySinh);
            panel7.Controls.Add(label11);
            panel7.Controls.Add(label10);
            panel7.Controls.Add(txtTenPB);
            panel7.Controls.Add(txtMoTa);
            panel7.Controls.Add(txtTruongPhong);
            panel7.Controls.Add(txtMaPB);
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
            panel7.Size = new Size(1581, 495);
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
            cbNu.Size = new Size(59, 29);
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
            cbNam.Size = new Size(75, 29);
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
            dtpNgaySinh.Size = new Size(344, 39);
            dtpNgaySinh.TabIndex = 63;
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
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(962, 183);
            label10.Name = "label10";
            label10.Size = new Size(106, 20);
            label10.TabIndex = 3;
            label10.Text = "Người quản lý:";
            // 
            // txtTenPB
            // 
            txtTenPB.Location = new Point(521, 113);
            txtTenPB.Name = "txtTenPB";
            txtTenPB.Size = new Size(344, 27);
            txtTenPB.TabIndex = 2;
            // 
            // txtMoTa
            // 
            txtMoTa.Enabled = false;
            txtMoTa.Location = new Point(1100, 326);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(344, 34);
            txtMoTa.TabIndex = 2;
            // 
            // txtTruongPhong
            // 
            txtTruongPhong.Location = new Point(1100, 47);
            txtTruongPhong.Name = "txtTruongPhong";
            txtTruongPhong.Size = new Size(344, 27);
            txtTruongPhong.TabIndex = 2;
            // 
            // txtMaPB
            // 
            txtMaPB.Location = new Point(521, 47);
            txtMaPB.Name = "txtMaPB";
            txtMaPB.Size = new Size(344, 27);
            txtMaPB.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(962, 329);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 1;
            label9.Text = "Dự án:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(962, 116);
            label8.Name = "label8";
            label8.Size = new Size(100, 20);
            label8.TabIndex = 1;
            label8.Text = "Số điện thoại:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(392, 183);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 1;
            label5.Text = "Ngày sinh:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(962, 45);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 1;
            label7.Text = "TruongPhong:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(392, 326);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 1;
            label6.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(392, 256);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 1;
            label4.Text = "Giới tính:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(392, 116);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 1;
            label3.Text = "Họ tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(392, 47);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
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
            dataGridView1.RowHeadersWidth = 51;
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
            //edit.Click += edit_Click;
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
            // txtSearch
            // 
            txtSearch.Location = new Point(56, 11);
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
            label1.Size = new Size(233, 49);
            label1.TabIndex = 1;
            label1.Text = "Phòng Ban";
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
            // phongbangui
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(49, 17, 117);
            Margin = new Padding(0);
            Name = "phongbangui";
            Size = new Size(1698, 1100);
            Load += phongbangui_Load;
            MouseClick += phongbangui_MouseClick;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        private void LoadDataToGUI()
        {
            
            DataTable dt = new DataTable();
            dt.Columns.Add("Check", typeof(bool));
            dt.Columns.Add("Ma Phong Ban", typeof(string));
            dt.Columns.Add("Ten Phong Ban", typeof(string));
            dt.Columns.Add("Mo ta", typeof(string));
            dt.Columns.Add("Truong Phong", typeof(string));
            dt.Columns.Add("Trang Thai", typeof(int));

            foreach (phongbandto phongban in phongbans)
            {
                dt.Rows.Add(false, phongban.MaPhongBan, phongban.TenPhongBan, phongban.MoTa, phongban.TruongPhong, phongban.TrangThai.ToString());
            }
            dataGridView1.DataSource = dt;


        }  //da xong
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = dataGridView1.ColumnHeadersDefaultCellStyle.BackColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor;
        }
        public phongbangui()
        {
            InitializeComponent();

        }

        private void phongbangui_Load(object? sender, EventArgs e)
        {
            LoadDataToGUI();
            txtSearch.PlaceholderText = "Tìm kiếm ...";
            dataGridView1.Size = new Size(1575, 870);
            panel7.Visible = false;
            //dataGridView1.ClearSelection();
        }

        string maPBSelected;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //hien thi bang detail

            dataGridView1.Size = new Size(1575, 450);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.FromArgb(49, 17, 117);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Lavender;

            panel7.Visible = true;

            //get data
            maPBSelected = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            phongbandto selectedphongban = phongbans.FirstOrDefault(phongban => phongban.MaPhongBan == maPBSelected);

            if (selectedphongban != null)
            {
                txtMaPB.Text = selectedphongban.MaPhongBan.Trim();
                txtTruongPhong.Text = selectedphongban.TruongPhong.Trim();
                txtTenPB.Text = selectedphongban.TenPhongBan.Trim();
                txtMoTa.Text = selectedphongban.MoTa.Trim();

            }

        }





        private void phongbangui_MouseClick(object sender, MouseEventArgs e)
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

        private void delete_Click(object sender, EventArgs e)
        {
            phongbandto selectedphongban = phongbans.FirstOrDefault(phongban => phongban.MaPhongBan == maPBSelected);
            if (selectedphongban != null)
            {
                if (selectedphongban.TrangThai == 1)
                {
                    try
                    {
                        phongbanBUS.DeletePhongBan(selectedphongban);
                        MessageBox.Show("Xóa Phòng Ban thành công!!!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi xảy ra trong quá trình xóa: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Phòng Ban này đã được xóa!!!");
                }
            }
            else
            {
                MessageBox.Show("Chọn một Phòng Ban để xóa!");
            }
        }

        //private void edit_Click(object sender, EventArgs e)
        //{
        //    phongbandto selectedphongban = phongbans.FirstOrDefault(phongban => phongban.MaPhongBan == maPBSelected);

        //    if (selectedphongban != null)
        //    {
        //        SuaPhongBan interf = new SuaPhongBan(selectedphongban);
        //        interf.StartPosition = FormStartPosition.CenterParent;
        //        interf.ShowDialog();

        //    }
        //    else
        //    {
        //        MessageBox.Show("Chọn một Phòng Ban để chỉnh sửa!");
        //    }
        //}

        //private void Tao_Click(object sender, EventArgs e)
        //{
        //    TaoPhongBan interf = new TaoPhongBan();
        //    interf.StartPosition = FormStartPosition.CenterParent;
        //    interf.ShowDialog();
        //}



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
