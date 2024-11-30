namespace WinFormsApp1.GUI.wave
{
    partial class themBangLuongGUI
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            textBoxLuongThucNhan = new TextBox();
            textBoxKhauTru = new TextBox();
            textBoxPhuCap = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBoxNhanVien = new ComboBox();
            button1 = new Button();
            addWage = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(229, 36);
            label1.Name = "label1";
            label1.Size = new Size(210, 31);
            label1.TabIndex = 0;
            label1.Text = "Thêm Bảng Lương";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 50);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhân Viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 111);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 2;
            label3.Text = "Tháng Năm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 164);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 3;
            label4.Text = "Phụ Cấp";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 221);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 4;
            label5.Text = "Khấu Trừ";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 285);
            label6.Name = "label6";
            label6.Size = new Size(126, 20);
            label6.TabIndex = 5;
            label6.Text = "Lương Thực Nhận";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxLuongThucNhan);
            groupBox1.Controls.Add(textBoxKhauTru);
            groupBox1.Controls.Add(textBoxPhuCap);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(comboBoxNhanVien);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(66, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(541, 350);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin ";
            // 
            // textBoxLuongThucNhan
            // 
            textBoxLuongThucNhan.Enabled = false;
            textBoxLuongThucNhan.Location = new Point(165, 285);
            textBoxLuongThucNhan.Name = "textBoxLuongThucNhan";
            textBoxLuongThucNhan.Size = new Size(316, 27);
            textBoxLuongThucNhan.TabIndex = 10;
            // 
            // textBoxKhauTru
            // 
            textBoxKhauTru.Location = new Point(163, 221);
            textBoxKhauTru.Name = "textBoxKhauTru";
            textBoxKhauTru.Size = new Size(318, 27);
            textBoxKhauTru.TabIndex = 9;
            textBoxKhauTru.TextChanged += textBoxKhauTru_TextChanged;
            // 
            // textBoxPhuCap
            // 
            textBoxPhuCap.Location = new Point(163, 164);
            textBoxPhuCap.Name = "textBoxPhuCap";
            textBoxPhuCap.Size = new Size(318, 27);
            textBoxPhuCap.TabIndex = 8;
            textBoxPhuCap.TextChanged += textBoxPhuCap_TextChanged_1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(165, 115);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(316, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // comboBoxNhanVien
            // 
            comboBoxNhanVien.FormattingEnabled = true;
            comboBoxNhanVien.Location = new Point(163, 47);
            comboBoxNhanVien.Name = "comboBoxNhanVien";
            comboBoxNhanVien.Size = new Size(318, 28);
            comboBoxNhanVien.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(165, 478);
            button1.Name = "button1";
            button1.Size = new Size(121, 42);
            button1.TabIndex = 11;
            button1.Text = "Hủy";
            button1.UseVisualStyleBackColor = true;
            // 
            // addWage
            // 
            addWage.Location = new Point(380, 476);
            addWage.Name = "addWage";
            addWage.Size = new Size(113, 46);
            addWage.TabIndex = 12;
            addWage.Text = "Thêm mới";
            addWage.UseVisualStyleBackColor = true;
            addWage.Click += addWage_Click;
            // 
            // themBangLuongGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 552);
            Controls.Add(groupBox1);
            Controls.Add(addWage);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "themBangLuongGUI";
            Text = "Form1";
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
        private GroupBox groupBox1;
        private ComboBox comboBoxNhanVien;
        private TextBox textBoxPhuCap;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxKhauTru;
        private TextBox textBoxLuongThucNhan;
        private Button button1;
        private Button addWage;
    }
}