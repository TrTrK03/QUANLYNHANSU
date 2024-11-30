﻿namespace WinFormsApp1.GUI
{
    partial class khenThuongGUI
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
            comboBoxNhanVien = new ComboBox();
            label1 = new Label();
            textBoxKhenThuong = new TextBox();
            buttonAdd = new Button();
            label2 = new Label();
            dateTimePicker = new DateTimePicker();
            buttonDelete = new Button();
            Ngày = new Label();
            buttonReset = new Button();
            label3 = new Label();
            comboBoxKhenThuong = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button1 = new Button();
            groupBox3 = new GroupBox();
            dataKhenThuong = new DataGridView();
            searchReward = new TextBox();
            btnSearch = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataKhenThuong).BeginInit();
            SuspendLayout();
            // 
            // comboBoxNhanVien
            // 
            comboBoxNhanVien.FormattingEnabled = true;
            comboBoxNhanVien.Location = new Point(171, 58);
            comboBoxNhanVien.Name = "comboBoxNhanVien";
            comboBoxNhanVien.Size = new Size(194, 28);
            comboBoxNhanVien.TabIndex = 0;
            comboBoxNhanVien.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 58);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 1;
            label1.Text = "Nhân Viên";
            label1.Click += label1_Click;
            // 
            // textBoxKhenThuong
            // 
            textBoxKhenThuong.Location = new Point(176, 129);
            textBoxKhenThuong.Name = "textBoxKhenThuong";
            textBoxKhenThuong.Size = new Size(194, 27);
            textBoxKhenThuong.TabIndex = 2;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(25, 36);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(106, 38);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Thêm";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 129);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 3;
            label2.Text = "Số tiền khen thưởng";
            label2.Click += label2_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(609, 132);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(239, 27);
            dateTimePicker.TabIndex = 4;
            dateTimePicker.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(285, 36);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(128, 41);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Xóa";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // Ngày
            // 
            Ngày.AutoSize = true;
            Ngày.Location = new Point(441, 132);
            Ngày.Name = "Ngày";
            Ngày.Size = new Size(131, 20);
            Ngày.TabIndex = 5;
            Ngày.Text = "Ngày khen thưởng";
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(432, 36);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(118, 41);
            buttonReset.TabIndex = 6;
            buttonReset.Text = "Làm mới";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(441, 66);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 7;
            label3.Text = "Loại khen thưởng";
            label3.Click += label3_Click;
            // 
            // comboBoxKhenThuong
            // 
            comboBoxKhenThuong.FormattingEnabled = true;
            comboBoxKhenThuong.Location = new Point(609, 63);
            comboBoxKhenThuong.Name = "comboBoxKhenThuong";
            comboBoxKhenThuong.Size = new Size(239, 28);
            comboBoxKhenThuong.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePicker);
            groupBox1.Controls.Add(comboBoxNhanVien);
            groupBox1.Controls.Add(Ngày);
            groupBox1.Controls.Add(comboBoxKhenThuong);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxKhenThuong);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(20, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(961, 303);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Khen Thưởng";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(searchReward);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(buttonAdd);
            groupBox2.Controls.Add(buttonReset);
            groupBox2.Controls.Add(buttonDelete);
            groupBox2.Location = new Point(39, 197);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(903, 92);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // button1
            // 
            button1.Location = new Point(159, 36);
            button1.Name = "button1";
            button1.Size = new Size(120, 41);
            button1.TabIndex = 7;
            button1.Text = "Sửa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataKhenThuong);
            groupBox3.Location = new Point(20, 312);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(961, 276);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách khen thưởng";
            // 
            // dataKhenThuong
            // 
            dataKhenThuong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataKhenThuong.Location = new Point(6, 26);
            dataKhenThuong.Name = "dataKhenThuong";
            dataKhenThuong.RowHeadersWidth = 51;
            dataKhenThuong.Size = new Size(949, 249);
            dataKhenThuong.TabIndex = 0;
            // 
            // searchReward
            // 
            searchReward.Location = new Point(570, 42);
            searchReward.Name = "searchReward";
            searchReward.Size = new Size(221, 27);
            searchReward.TabIndex = 8;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.White;
            btnSearch.Image = Properties.Resources.search;
            btnSearch.Location = new Point(809, 36);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(88, 33);
            btnSearch.TabIndex = 9;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // khenThuongGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "khenThuongGUI";
            Size = new Size(1000, 600);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataKhenThuong).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox comboBoxNhanVien;
        private Label label1;
        private TextBox textBoxKhenThuong;
        private Button buttonAdd;
        private Label label2;
        private DateTimePicker dateTimePicker;
        private Button buttonDelete;
        private Label Ngày;
        private Button buttonReset;
        private Label label3;
        private ComboBox comboBoxKhenThuong;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dataKhenThuong;
        private Button button1;
        private Button btnSearch;
        private TextBox searchReward;
    }
}