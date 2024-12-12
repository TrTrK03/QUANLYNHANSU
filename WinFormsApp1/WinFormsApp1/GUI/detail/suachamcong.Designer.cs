namespace WinFormsApp1.GUI.detail
{
    partial class suachamcong
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
            panel1 = new Panel();
            label9 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dpNgay = new DateTimePicker();
            txtMCC = new TextBox();
            cbBuoi = new DomainUpDown();
            txtGiovaoca = new TextBox();
            cbNV = new DomainUpDown();
            btnHuy = new Button();
            btnSua = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(466, 94);
            panel1.TabIndex = 89;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.ImeMode = ImeMode.NoControl;
            label9.Location = new Point(58, 22);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(322, 54);
            label9.TabIndex = 46;
            label9.Text = "Sửa Chấm Công";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 345);
            label5.Name = "label5";
            label5.Size = new Size(108, 28);
            label5.TabIndex = 84;
            label5.Text = "Giờ vào ca:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 289);
            label4.Name = "label4";
            label4.Size = new Size(133, 28);
            label4.TabIndex = 85;
            label4.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 235);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 86;
            label3.Text = "Ngày:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 180);
            label2.Name = "label2";
            label2.Size = new Size(55, 28);
            label2.TabIndex = 87;
            label2.Text = "Buổi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 129);
            label1.Name = "label1";
            label1.Size = new Size(145, 28);
            label1.TabIndex = 88;
            label1.Text = "Mã chấm công:";
            // 
            // dpNgay
            // 
            dpNgay.Enabled = false;
            dpNgay.Location = new Point(210, 230);
            dpNgay.Name = "dpNgay";
            dpNgay.Size = new Size(200, 34);
            dpNgay.TabIndex = 83;
            dpNgay.ValueChanged += dpNgay_ValueChanged;
            // 
            // txtMCC
            // 
            txtMCC.Enabled = false;
            txtMCC.Location = new Point(210, 126);
            txtMCC.Name = "txtMCC";
            txtMCC.Size = new Size(200, 34);
            txtMCC.TabIndex = 82;
            // 
            // cbBuoi
            // 
            cbBuoi.Enabled = false;
            cbBuoi.Items.Add("1");
            cbBuoi.Items.Add("2");
            cbBuoi.Location = new Point(210, 178);
            cbBuoi.Name = "cbBuoi";
            cbBuoi.Size = new Size(200, 34);
            cbBuoi.TabIndex = 81;
            cbBuoi.Text = "domainUpDown2";
            cbBuoi.SelectedItemChanged += cbBuoi_SelectedItemChanged_1;
            // 
            // txtGiovaoca
            // 
            txtGiovaoca.Location = new Point(210, 342);
            txtGiovaoca.Name = "txtGiovaoca";
            txtGiovaoca.Size = new Size(200, 34);
            txtGiovaoca.TabIndex = 80;
            // 
            // cbNV
            // 
            cbNV.Enabled = false;
            cbNV.Location = new Point(210, 287);
            cbNV.Name = "cbNV";
            cbNV.Size = new Size(200, 34);
            cbNV.TabIndex = 79;
            cbNV.Text = "domainUpDown1";
            cbNV.SelectedItemChanged += cbNV_SelectedItemChanged_1;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(255, 128, 128);
            btnHuy.Font = new Font("Microsoft Sans Serif", 12F);
            btnHuy.Image = Properties.Resources.icons8_x_48;
            btnHuy.ImeMode = ImeMode.NoControl;
            btnHuy.Location = new Point(266, 420);
            btnHuy.Margin = new Padding(6);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(144, 63);
            btnHuy.TabIndex = 78;
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.MediumTurquoise;
            btnSua.Font = new Font("Microsoft Sans Serif", 12F);
            btnSua.ForeColor = Color.White;
            btnSua.Image = Properties.Resources.icons8_edit_property_48;
            btnSua.ImeMode = ImeMode.NoControl;
            btnSua.Location = new Point(33, 420);
            btnSua.Margin = new Padding(6, 5, 6, 5);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(151, 63);
            btnSua.TabIndex = 96;
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // suachamcong
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(466, 494);
            Controls.Add(btnSua);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dpNgay);
            Controls.Add(txtMCC);
            Controls.Add(cbBuoi);
            Controls.Add(txtGiovaoca);
            Controls.Add(cbNV);
            Controls.Add(btnHuy);
            Name = "suachamcong";
            Text = "suachamcong";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label9;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dpNgay;
        private TextBox txtMCC;
        private DomainUpDown cbBuoi;
        private TextBox txtGiovaoca;
        private DomainUpDown cbNV;
        private Button btnHuy;
        private Button btnSua;
    }
}