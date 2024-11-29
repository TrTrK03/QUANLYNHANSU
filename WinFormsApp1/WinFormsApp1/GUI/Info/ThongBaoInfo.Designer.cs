namespace WinFormsApp1.GUI.Info
{
    partial class ThongBaoInfo
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
            panel7 = new Panel();
            dtpNgayBanHanh = new DateTimePicker();
            txtNoiDung = new TextBox();
            txtNguoiBanHanh = new TextBox();
            txtMaThongBao = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel8 = new Panel();
            pictureBox1 = new PictureBox();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.BackColor = Color.Lavender;
            panel7.Controls.Add(dtpNgayBanHanh);
            panel7.Controls.Add(txtNoiDung);
            panel7.Controls.Add(txtNguoiBanHanh);
            panel7.Controls.Add(txtMaThongBao);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(label6);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Fill;
            panel7.ForeColor = Color.FromArgb(49, 17, 117);
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(776, 278);
            panel7.TabIndex = 8;
            // 
            // dtpNgayBanHanh
            // 
            dtpNgayBanHanh.Enabled = false;
            dtpNgayBanHanh.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayBanHanh.Format = DateTimePickerFormat.Short;
            dtpNgayBanHanh.Location = new Point(408, 127);
            dtpNgayBanHanh.Margin = new Padding(6, 5, 6, 5);
            dtpNgayBanHanh.Name = "dtpNgayBanHanh";
            dtpNgayBanHanh.Size = new Size(344, 39);
            dtpNgayBanHanh.TabIndex = 63;
            // 
            // txtNoiDung
            // 
            txtNoiDung.Enabled = false;
            txtNoiDung.Location = new Point(408, 174);
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(344, 27);
            txtNoiDung.TabIndex = 2;
            // 
            // txtNguoiBanHanh
            // 
            txtNguoiBanHanh.Enabled = false;
            txtNguoiBanHanh.Location = new Point(408, 92);
            txtNguoiBanHanh.Name = "txtNguoiBanHanh";
            txtNguoiBanHanh.Size = new Size(344, 27);
            txtNguoiBanHanh.TabIndex = 2;
            // 
            // txtMaThongBao
            // 
            txtMaThongBao.Enabled = false;
            txtMaThongBao.Location = new Point(408, 59);
            txtMaThongBao.Name = "txtMaThongBao";
            txtMaThongBao.Size = new Size(344, 27);
            txtMaThongBao.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(279, 135);
            label5.Name = "label5";
            label5.Size = new Size(112, 20);
            label5.TabIndex = 1;
            label5.Text = "Ngày ban hành:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(279, 177);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 1;
            label6.Text = "Nội dung:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(279, 95);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 1;
            label3.Text = "Người ban hành:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(279, 59);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã thông báo:";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(255, 192, 255);
            panel8.Controls.Add(pictureBox1);
            panel8.Location = new Point(12, 27);
            panel8.Name = "panel8";
            panel8.Size = new Size(251, 228);
            panel8.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Untitled2;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 228);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ThongBaoInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 278);
            Controls.Add(panel7);
            Name = "ThongBaoInfo";
            Text = "ThongBaoInfo";
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel7;
        private DateTimePicker dtpNgayBanHanh;
        private TextBox txtNoiDung;
        private TextBox txtNguoiBanHanh;
        private TextBox txtMaThongBao;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label2;
        private Panel panel8;
        private PictureBox pictureBox1;
    }
}