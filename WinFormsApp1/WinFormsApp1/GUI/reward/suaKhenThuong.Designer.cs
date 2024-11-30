namespace WinFormsApp1.GUI.reward
{
    partial class suaKhenThuong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            dateTimePicker = new DateTimePicker();
            richTextBoxChiTietKT = new RichTextBox();
            textBoxGiaTriKT = new TextBox();
            textBoxMaKhenThuong = new TextBox();
            button1 = new Button();
            button2 = new Button();
            comboBoxMaNV = new ComboBox();
            comboBoxLoaiKT = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(246, 31);
            label1.Name = "label1";
            label1.Size = new Size(181, 28);
            label1.TabIndex = 0;
            label1.Text = "Sửa Khen Thưởng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 42);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã Khen Thưởng";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 90);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 2;
            label3.Text = "Mã Nhân Viên";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 140);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 3;
            label4.Text = "Loại Khen Thưởng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 250);
            label5.Name = "label5";
            label5.Size = new Size(151, 20);
            label5.TabIndex = 4;
            label5.Text = "Chi Tiết Khen Thưởng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 193);
            label6.Name = "label6";
            label6.Size = new Size(143, 20);
            label6.TabIndex = 5;
            label6.Text = "Giá Trị Khen Thưởng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 321);
            label7.Name = "label7";
            label7.Size = new Size(136, 20);
            label7.TabIndex = 6;
            label7.Text = "Ngày Khen Thưởng";
            label7.Click += label7_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxLoaiKT);
            groupBox1.Controls.Add(comboBoxMaNV);
            groupBox1.Controls.Add(dateTimePicker);
            groupBox1.Controls.Add(richTextBoxChiTietKT);
            groupBox1.Controls.Add(textBoxGiaTriKT);
            groupBox1.Controls.Add(textBoxMaKhenThuong);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(38, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(596, 366);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khen thưởng";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(207, 321);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(313, 27);
            dateTimePicker.TabIndex = 12;
            // 
            // richTextBoxChiTietKT
            // 
            richTextBoxChiTietKT.Location = new Point(208, 247);
            richTextBoxChiTietKT.Name = "richTextBoxChiTietKT";
            richTextBoxChiTietKT.Size = new Size(312, 51);
            richTextBoxChiTietKT.TabIndex = 11;
            richTextBoxChiTietKT.Text = "";
            // 
            // textBoxGiaTriKT
            // 
            textBoxGiaTriKT.Location = new Point(208, 193);
            textBoxGiaTriKT.Name = "textBoxGiaTriKT";
            textBoxGiaTriKT.Size = new Size(312, 27);
            textBoxGiaTriKT.TabIndex = 10;
            // 
            // textBoxMaKhenThuong
            // 
            textBoxMaKhenThuong.Location = new Point(208, 39);
            textBoxMaKhenThuong.Name = "textBoxMaKhenThuong";
            textBoxMaKhenThuong.Size = new Size(312, 27);
            textBoxMaKhenThuong.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(176, 491);
            button1.Name = "button1";
            button1.Size = new Size(127, 41);
            button1.TabIndex = 8;
            button1.Text = "Hủy";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(414, 491);
            button2.Name = "button2";
            button2.Size = new Size(132, 41);
            button2.TabIndex = 9;
            button2.Text = "Cập nhật";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBoxMaNV
            // 
            comboBoxMaNV.FormattingEnabled = true;
            comboBoxMaNV.Location = new Point(208, 87);
            comboBoxMaNV.Name = "comboBoxMaNV";
            comboBoxMaNV.Size = new Size(312, 28);
            comboBoxMaNV.TabIndex = 13;
            // 
            // comboBoxLoaiKT
            // 
            comboBoxLoaiKT.FormattingEnabled = true;
            comboBoxLoaiKT.Location = new Point(208, 140);
            comboBoxLoaiKT.Name = "comboBoxLoaiKT";
            comboBoxLoaiKT.Size = new Size(312, 28);
            comboBoxLoaiKT.TabIndex = 14;
            // 
            // suaKhenThuong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "suaKhenThuong";
            Size = new Size(680, 561);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private GroupBox groupBox1;
        private TextBox textBoxGiaTriKT;
        private TextBox textBoxMaKhenThuong;
        private RichTextBox richTextBoxChiTietKT;
        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker;
        private ComboBox comboBoxMaNV;
        private ComboBox comboBoxLoaiKT;
    }
}
