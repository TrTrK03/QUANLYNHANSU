using System.Windows.Forms;

namespace WinFormsApp1.GUI.Info
{
    partial class DanhSachTuyenDung
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            txtSearch = new TextBox();
            button1 = new Button();
            txtQuanLy = new TextBox();
            label10 = new Label();
            dtpNgayKetThuc = new DateTimePicker();
            dtpNgayBatDau = new DateTimePicker();
            label9 = new Label();
            label5 = new Label();
            txtNoiDung = new TextBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtQuanLy);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(dtpNgayKetThuc);
            panel1.Controls.Add(dtpNgayBatDau);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtNoiDung);
            panel1.Location = new Point(5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1337, 78);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(850, 47);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 84;
            button2.Text = "Đậu";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LimeGreen;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(1144, 47);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 83;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 54);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 81;
            label1.Text = "Tìm Kiếm";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(130, 50);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(268, 27);
            txtSearch.TabIndex = 80;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(987, 48);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 79;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtQuanLy
            // 
            txtQuanLy.Enabled = false;
            txtQuanLy.Location = new Point(557, 47);
            txtQuanLy.Name = "txtQuanLy";
            txtQuanLy.Size = new Size(198, 27);
            txtQuanLy.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(489, 50);
            label10.Name = "label10";
            label10.Size = new Size(62, 20);
            label10.TabIndex = 5;
            label10.Text = "Quản lý:";
            // 
            // dtpNgayKetThuc
            // 
            dtpNgayKetThuc.Enabled = false;
            dtpNgayKetThuc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayKetThuc.Format = DateTimePickerFormat.Short;
            dtpNgayKetThuc.Location = new Point(972, 5);
            dtpNgayKetThuc.Margin = new Padding(0);
            dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            dtpNgayKetThuc.Size = new Size(300, 39);
            dtpNgayKetThuc.TabIndex = 78;
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.Enabled = false;
            dtpNgayBatDau.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayBatDau.Format = DateTimePickerFormat.Short;
            dtpNgayBatDau.Location = new Point(488, 5);
            dtpNgayBatDau.Margin = new Padding(0);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(300, 39);
            dtpNgayBatDau.TabIndex = 77;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(841, 20);
            label9.Name = "label9";
            label9.Size = new Size(103, 20);
            label9.TabIndex = 75;
            label9.Text = "Ngày kết thúc:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(358, 20);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 76;
            label5.Text = "Ngày bắt đầu:";
            // 
            // txtNoiDung
            // 
            txtNoiDung.Enabled = false;
            txtNoiDung.Location = new Point(54, 13);
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(268, 27);
            txtNoiDung.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(5, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(1337, 454);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Điều chỉnh chiều cao tiêu đề cột để vừa nội dung
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.Info;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;

            // Điều chỉnh chiều cao dòng cho phù hợp với nội dung
            dataGridView1.RowTemplate.Height = 50;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(1337, 454);
            dataGridView1.TabIndex = 1;

            // 
            // DanhSachTuyenDung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 539);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DanhSachTuyenDung";
            Text = "DanhSachTuyenDung";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtNoiDung;
        private DateTimePicker dtpNgayKetThuc;
        private DateTimePicker dtpNgayBatDau;
        private Label label9;
        private Label label5;
        private TextBox txtQuanLy;
        private Label label10;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox txtSearch;
        private Label label1;
        private Button button3;
        private Button button2;
    }
}