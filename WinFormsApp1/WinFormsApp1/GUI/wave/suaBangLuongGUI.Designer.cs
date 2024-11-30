namespace WinFormsApp1.GUI.wave
{
    partial class suaBangLuongGUI
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxMaNV = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBoxPhuCap = new TextBox();
            textBoxKhauTru = new TextBox();
            textBoxLuongThucNhan = new TextBox();
            button1 = new Button();
            buttonUpdateWage = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(236, 24);
            label1.Name = "label1";
            label1.Size = new Size(190, 31);
            label1.TabIndex = 0;
            label1.Text = "Sửa Bảng Lương";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 82);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã Nhân Viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 154);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 3;
            label4.Text = "Tháng Năm";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 233);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 4;
            label5.Text = "Phụ Cấp";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(74, 305);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 5;
            label6.Text = "Khấu Trừ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(74, 373);
            label7.Name = "label7";
            label7.Size = new Size(126, 20);
            label7.TabIndex = 6;
            label7.Text = "Lương Thực Nhận";
            // 
            // textBoxMaNV
            // 
            textBoxMaNV.Enabled = false;
            textBoxMaNV.Location = new Point(219, 82);
            textBoxMaNV.Name = "textBoxMaNV";
            textBoxMaNV.Size = new Size(296, 27);
            textBoxMaNV.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(219, 154);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(296, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // textBoxPhuCap
            // 
            textBoxPhuCap.Location = new Point(219, 230);
            textBoxPhuCap.Name = "textBoxPhuCap";
            textBoxPhuCap.Size = new Size(296, 27);
            textBoxPhuCap.TabIndex = 10;
            // 
            // textBoxKhauTru
            // 
            textBoxKhauTru.Location = new Point(219, 305);
            textBoxKhauTru.Name = "textBoxKhauTru";
            textBoxKhauTru.Size = new Size(296, 27);
            textBoxKhauTru.TabIndex = 11;
            // 
            // textBoxLuongThucNhan
            // 
            textBoxLuongThucNhan.Enabled = false;
            textBoxLuongThucNhan.Location = new Point(219, 370);
            textBoxLuongThucNhan.Name = "textBoxLuongThucNhan";
            textBoxLuongThucNhan.Size = new Size(296, 27);
            textBoxLuongThucNhan.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(180, 452);
            button1.Name = "button1";
            button1.Size = new Size(105, 40);
            button1.TabIndex = 13;
            button1.Text = "Hủy";
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateWage
            // 
            buttonUpdateWage.Location = new Point(363, 452);
            buttonUpdateWage.Name = "buttonUpdateWage";
            buttonUpdateWage.Size = new Size(118, 40);
            buttonUpdateWage.TabIndex = 14;
            buttonUpdateWage.Text = "Cập nhật";
            buttonUpdateWage.UseVisualStyleBackColor = true;
            buttonUpdateWage.Click += buttonUpdateWage_Click;
            // 
            // suaBangLuongGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 504);
            Controls.Add(buttonUpdateWage);
            Controls.Add(button1);
            Controls.Add(textBoxLuongThucNhan);
            Controls.Add(textBoxKhauTru);
            Controls.Add(textBoxPhuCap);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxMaNV);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "suaBangLuongGUI";
            Text = "suaBangLuongGUI";
            Load += suaBangLuongGUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxMaNV;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxPhuCap;
        private TextBox textBoxKhauTru;
        private TextBox textBoxLuongThucNhan;
        private Button button1;
        private Button buttonUpdateWage;
    }
}