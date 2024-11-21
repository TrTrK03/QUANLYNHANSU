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

namespace WinFormsApp1.GUI
{
    public partial class test : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]


        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public test()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panel4.Width = button1.Width;
            panel4.Left = button1.Left;
            button1.ForeColor = Color.Green;

        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel6 = new Panel();
            button5 = new Button();
            button6 = new Button();
            export = new Button();
            button7 = new Button();
            button8 = new Button();
            textBox2 = new TextBox();
            textBox6 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            textBox9 = new TextBox();
            textBox7 = new TextBox();
            textBox1 = new TextBox();
            label8 = new Label();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            openFileDialog1 = new OpenFileDialog();
            label2 = new Label();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            panel8 = new Panel();
            panel7 = new Panel();
            panel5 = new Panel();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            ((ISupportInitialize)dataGridView1).BeginInit();
            ((ISupportInitialize)pictureBox1).BeginInit();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel6.BackColor = SystemColors.ActiveCaption;
            panel6.Controls.Add(button5);
            panel6.Controls.Add(button6);
            panel6.Controls.Add(export);
            panel6.Controls.Add(button7);
            panel6.Controls.Add(button8);
            panel6.Controls.Add(textBox2);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(341, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1240, 49);
            panel6.TabIndex = 6;
            // 
            // button5
            // 
            button5.BackColor = Color.Blue;
            button5.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(500, 0);
            button5.Name = "button5";
            button5.Size = new Size(130, 49);
            button5.TabIndex = 9;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(653, 2);
            button6.Name = "button6";
            button6.Size = new Size(130, 49);
            button6.TabIndex = 9;
            button6.Text = "Import";
            button6.UseVisualStyleBackColor = true;
            // 
            // export
            // 
            export.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            export.FlatStyle = FlatStyle.Flat;
            export.Location = new Point(808, 3);
            export.Name = "export";
            export.Size = new Size(130, 49);
            export.TabIndex = 8;
            export.Text = "Export";
            export.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.BackColor = Color.LimeGreen;
            button7.Dock = DockStyle.Right;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Image = Properties.Resources.add2;
            button7.Location = new Point(1117, 0);
            button7.Name = "button7";
            button7.Size = new Size(123, 49);
            button7.TabIndex = 2;
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Image = Properties.Resources.search;
            button8.Location = new Point(301, 6);
            button8.Name = "button8";
            button8.Size = new Size(75, 37);
            button8.TabIndex = 1;
            button8.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(15, 9);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(251, 34);
            textBox2.TabIndex = 0;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(521, 326);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(344, 34);
            textBox6.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(521, 256);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(344, 34);
            textBox4.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(521, 180);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(344, 34);
            textBox3.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(521, 113);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(344, 34);
            textBox5.TabIndex = 2;
            // 
            // textBox9
            // 
            textBox9.Enabled = false;
            textBox9.Location = new Point(1100, 113);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(344, 247);
            textBox9.TabIndex = 2;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(1100, 47);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(344, 34);
            textBox7.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(521, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(344, 34);
            textBox1.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(962, 116);
            label8.Name = "label8";
            label8.Size = new Size(99, 28);
            label8.TabIndex = 1;
            label8.Text = "Nội dung:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(392, 183);
            label5.Name = "label5";
            label5.Size = new Size(75, 28);
            label5.TabIndex = 1;
            label5.Text = "Tác giả:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(962, 45);
            label7.Name = "label7";
            label7.Size = new Size(106, 28);
            label7.TabIndex = 1;
            label7.Text = "Đối tượng:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(392, 326);
            label6.Name = "label6";
            label6.Size = new Size(88, 28);
            label6.TabIndex = 1;
            label6.Text = "Kết thúc:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(392, 116);
            label3.Name = "label3";
            label3.Size = new Size(79, 28);
            label3.TabIndex = 1;
            label3.Text = "Tiêu đề:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 224, 192);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1581, 51);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Enabled = false;
            label1.Font = new Font("Tw Cen MT", 25F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 49);
            label1.TabIndex = 1;
            label1.Text = "Thông báo";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 255, 192);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 49);
            panel3.Name = "panel3";
            panel3.Size = new Size(1581, 2);
            panel3.TabIndex = 0;
            panel3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(392, 256);
            label4.Name = "label4";
            label4.Size = new Size(103, 28);
            label4.TabIndex = 1;
            label4.Text = "Phát hành:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(392, 47);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 1;
            label2.Text = "Mã TB:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(200, 158, 255);
            panel4.Location = new Point(0, 108);
            panel4.Name = "panel4";
            panel4.Size = new Size(157, 3);
            panel4.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(192, 0, 192);
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
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(255, 192, 255);
            panel8.Controls.Add(pictureBox1);
            panel8.Location = new Point(52, 45);
            panel8.Name = "panel8";
            panel8.Size = new Size(251, 315);
            panel8.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(192, 192, 255);
            panel7.Controls.Add(textBox6);
            panel7.Controls.Add(textBox4);
            panel7.Controls.Add(textBox3);
            panel7.Controls.Add(textBox5);
            panel7.Controls.Add(textBox9);
            panel7.Controls.Add(textBox7);
            panel7.Controls.Add(textBox1);
            panel7.Controls.Add(label8);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(label6);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Fill;
            panel7.Enabled = false;
            panel7.Location = new Point(0, 405);
            panel7.Name = "panel7";
            panel7.Size = new Size(1581, 435);
            panel7.TabIndex = 7;
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left;
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(59, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(1581, 951);
            panel1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Font = new Font("Bahnschrift Light", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flowLayoutPanel1.Location = new Point(0, 51);
            flowLayoutPanel1.Margin = new Padding(3, 0, 3, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1581, 60);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.CausesValidation = false;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Candara", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(64, 64, 64);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(108, 57);
            button1.TabIndex = 0;
            button1.Text = "Hiện hành";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.AutoSize = true;
            button2.CausesValidation = false;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Candara", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(117, 3);
            button2.Name = "button2";
            button2.Size = new Size(86, 58);
            button2.TabIndex = 1;
            button2.Text = "Tất cả";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.AutoSize = true;
            button3.CausesValidation = false;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Candara", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(209, 3);
            button3.Name = "button3";
            button3.Size = new Size(155, 58);
            button3.TabIndex = 2;
            button3.Text = "Chưa phát hành";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.AutoSize = true;
            button4.CausesValidation = false;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Candara", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(370, 3);
            button4.Name = "button4";
            button4.Size = new Size(108, 58);
            button4.TabIndex = 3;
            button4.Text = "Hết hạn";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // thongbaogui
            // 
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(panel1);
            Name = "thongbaogui";
            Size = new Size(1698, 1100);
            Load += this.thongbaogui_Load;
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            ((ISupportInitialize)dataGridView1).EndInit();
            ((ISupportInitialize)pictureBox1).EndInit();
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        private void thongbaogui_Load(object? sender, EventArgs e)
        {
            hienthi();
            panel4.Width = button1.Width;
            panel4.Left = button1.Left;
            button1.ForeColor = Color.FromArgb(49, 17, 117);
            button2.ForeColor = Color.FromArgb(64, 64, 64);
            button3.ForeColor = Color.FromArgb(64, 64, 64);
            button4.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridView1.Size = new Size(1575, 870);
            panel7.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Width = button1.Width;
            panel4.Left = button1.Left;
            button1.ForeColor = Color.FromArgb(49,17,117);
            button2.ForeColor = Color.FromArgb(64, 64, 64);
            button3.ForeColor = Color.FromArgb(64, 64, 64);
            button4.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Width = button2.Width;
            panel4.Left = button2.Left;
            button1.ForeColor = Color.FromArgb(64, 64, 64);
            button3.ForeColor = Color.FromArgb(64, 64, 64);
            button4.ForeColor = Color.FromArgb(64, 64, 64);
            button2.ForeColor = Color.FromArgb(49,17,117);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Width = button3.Width;
            panel4.Left = button3.Left;
            button1.ForeColor = Color.FromArgb(64, 64, 64);
            button2.ForeColor = Color.FromArgb(64, 64, 64);
            button4.ForeColor = Color.FromArgb(64, 64, 64);
            button3.ForeColor = Color.FromArgb(49,17,117);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Width = button4.Width;
            panel4.Left = button4.Left;
            button1.ForeColor = Color.FromArgb(64, 64, 64);
            button3.ForeColor = Color.FromArgb(64, 64, 64);
            button2.ForeColor = Color.FromArgb(64, 64, 64);
            button4.ForeColor = Color.FromArgb(49,17,117);
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            // Đường dẫn đến file Excel
            //string filePath = "Book1.xlsx";

            //using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
            //{
            //    ExcelWorksheet worksheet = package.Workbook.Worksheets[1]; // Chọn sheet đầu tiên


            //    // Đọc dữ liệu và thêm vào DataTable
            //    for (int i = 2; i <= 7; i++)
            //    {

            //        var a = worksheet.Cells[i, 1].Value;
            //        var b = worksheet.Cells[i, 2].Value;
            //        var c = worksheet.Cells[i, 3].Value;
            //        var d = worksheet.Cells[i, 4].Value;
            //        var f = worksheet.Cells[i, 5].Value;
            //        var g = worksheet.Cells[i, 6].Value;
            //        var h = worksheet.Cells[i, 7].Value;

            //        if(a== "FALSE") dataGridView1.Rows.Add(false,b,c,d,f,g,h);

            //        //dt.Rows.Add(dr);
            //    }

            //    // Hiển thị dữ liệu lên DataGridView
            //    //dataGridView1.DataSource = dt;
            //}


            //using (var stream = File.Open("C:/Users/Antho/Desktop/New folder/WinFormsApp1/WinFormsApp1/GUI/Book1.xlsx", FileMode.Open, FileAccess.Read))
            //{
            //    using (var reader = ExcelReaderFactory.CreateReader(stream))
            //    {
            //        var result = reader.GetData;
            //        if (result != null)
            //        {
            //            System.Console.WriteLine("Thành công");

            //        }
            //    }
            //}
        }
        private void hienthi() {
            DataTable dtSinhVien = new DataTable();
            dataGridView1.ClearSelection();

            // Thêm các cột vào DataTable
            dtSinhVien.Columns.Add("Column1", typeof(bool));
            dtSinhVien.Columns.Add("Column2", typeof(string));
            dtSinhVien.Columns.Add("Column3", typeof(string));
            dtSinhVien.Columns.Add("Column4", typeof(string));
            dtSinhVien.Columns.Add("Column5", typeof(string));
            dtSinhVien.Columns.Add("Column6", typeof(string));
            dtSinhVien.Columns.Add("Column7", typeof(string));



            dtSinhVien.Rows.Add(false, "7", "Kế hoạch 7", "Chi tiết kế hoạch 7", "18/2/2024", "10/11/2024", "Ông G");
            dtSinhVien.Rows.Add(false, "7", "Kế hoạch 7", "Chi tiết kế hoạch 7", "18/2/2024", "10/11/2024", "Ông G");
            dtSinhVien.Rows.Add(false, "7", "Kế hoạch 7", "Chi tiết kế hoạch 7", "18/2/2024", "10/11/2024", "Ông G");
            dtSinhVien.Rows.Add(true, "7", "Kế hoạch 7", "Chi tiết kế hoạch 7", "18/2/2024", "10/11/2024", "Ông G");
            dtSinhVien.Rows.Add(false, "7", "Kế hoạch 7", "Chi tiết kế hoạch 7", "18/2/2024", "10/11/2024", "Ông G");
            dtSinhVien.Rows.Add(false, "7", "Kế hoạch 7", "Chi tiết kế hoạch 7", "18/2/2024", "10/11/2024", "Ông G");



            dataGridView1.DataSource = dtSinhVien;
        }
        


        
        private Panel panel6;
        private Button button5;
        private Button button6;
        private Button export;
        private Button button7;
        private Button button8;
        private TextBox textBox2;
        private TextBox textBox6;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox9;
        private TextBox textBox7;
        private TextBox textBox1;
        private Label label8;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label3;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label4;
        private OpenFileDialog openFileDialog1;
        private Label label2;
        private Panel panel4;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Panel panel8;
        private Panel panel7;
        private Panel panel5;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button3;
    }

}
