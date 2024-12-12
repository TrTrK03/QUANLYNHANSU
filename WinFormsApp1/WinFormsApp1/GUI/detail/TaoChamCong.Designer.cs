namespace WinFormsApp1.GUI.detail
{
    partial class TaoChamCong
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
            btnHuy = new Button();
            btnTao = new Button();
            cbNV = new DomainUpDown();
            txtGiovaoca = new TextBox();
            cbBuoi = new DomainUpDown();
            txtMCC = new TextBox();
            dpNgay = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            label9 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(255, 128, 128);
            btnHuy.Font = new Font("Microsoft Sans Serif", 12F);
            btnHuy.Image = Properties.Resources.icons8_x_48;
            btnHuy.ImeMode = ImeMode.NoControl;
            btnHuy.Location = new Point(266, 408);
            btnHuy.Margin = new Padding(6);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(144, 63);
            btnHuy.TabIndex = 68;
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnTao
            // 
            btnTao.BackColor = Color.LimeGreen;
            btnTao.Font = new Font("Microsoft Sans Serif", 12F);
            btnTao.ForeColor = Color.White;
            btnTao.Image = Properties.Resources.icons8_plus_48;
            btnTao.ImeMode = ImeMode.NoControl;
            btnTao.Location = new Point(33, 408);
            btnTao.Margin = new Padding(6);
            btnTao.Name = "btnTao";
            btnTao.Size = new Size(151, 63);
            btnTao.TabIndex = 67;
            btnTao.TextAlign = ContentAlignment.MiddleRight;
            btnTao.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTao.UseVisualStyleBackColor = false;
            btnTao.Click += btnTao_Click;
            // 
            // cbNV
            // 
            cbNV.Location = new Point(210, 275);
            cbNV.Name = "cbNV";
            cbNV.Size = new Size(200, 34);
            cbNV.TabIndex = 69;
            cbNV.Text = "domainUpDown1";
            cbNV.SelectedItemChanged += cbNV_SelectedItemChanged;
            // 
            // txtGiovaoca
            // 
            txtGiovaoca.Location = new Point(210, 330);
            txtGiovaoca.Name = "txtGiovaoca";
            txtGiovaoca.Size = new Size(200, 34);
            txtGiovaoca.TabIndex = 70;
            // 
            // cbBuoi
            // 
            cbBuoi.Items.Add("1");
            cbBuoi.Items.Add("2");
            cbBuoi.Location = new Point(210, 166);
            cbBuoi.Name = "cbBuoi";
            cbBuoi.Size = new Size(200, 34);
            cbBuoi.TabIndex = 72;
            cbBuoi.Text = "domainUpDown2";
            cbBuoi.SelectedItemChanged += cbBuoi_SelectedItemChanged;
            // 
            // txtMCC
            // 
            txtMCC.Enabled = false;
            txtMCC.Location = new Point(210, 114);
            txtMCC.Name = "txtMCC";
            txtMCC.Size = new Size(200, 34);
            txtMCC.TabIndex = 73;
            // 
            // dpNgay
            // 
            dpNgay.Location = new Point(210, 218);
            dpNgay.Name = "dpNgay";
            dpNgay.Size = new Size(200, 34);
            dpNgay.TabIndex = 74;
            dpNgay.ValueChanged += dpNgay_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 117);
            label1.Name = "label1";
            label1.Size = new Size(145, 28);
            label1.TabIndex = 75;
            label1.Text = "Mã chấm công:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 168);
            label2.Name = "label2";
            label2.Size = new Size(55, 28);
            label2.TabIndex = 75;
            label2.Text = "Buổi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 223);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 75;
            label3.Text = "Ngày:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 277);
            label4.Name = "label4";
            label4.Size = new Size(133, 28);
            label4.TabIndex = 75;
            label4.Text = "Mã nhân viên:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 333);
            label5.Name = "label5";
            label5.Size = new Size(108, 28);
            label5.TabIndex = 75;
            label5.Text = "Giờ vào ca:";
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
            panel1.TabIndex = 76;
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
            label9.Size = new Size(320, 54);
            label9.TabIndex = 46;
            label9.Text = "Tạo Chấm Công";
            // 
            // TaoChamCong
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(466, 494);
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
            Controls.Add(btnTao);
            Name = "TaoChamCong";
            Text = "TaoChamCong";
            Load += TaoChamCong_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHuy;
        private Button btnTao;
        private DomainUpDown domainUpDown1;
        private TextBox textBox1;
        private TextBox textBox2;
        private DomainUpDown domainUpDown2;
        private TextBox textBox3;
        private DateTimePicker dpNgay;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Label label9;
        private DomainUpDown cbNV;
        private TextBox txtGiovaoca;
        private DomainUpDown cbBuoi;
        private TextBox txtMCC;
    }
}