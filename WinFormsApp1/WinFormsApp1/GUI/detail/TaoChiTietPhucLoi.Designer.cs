namespace WinFormsApp1.GUI.detail
{
    partial class TaoChiTietPhucLoi
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
            txtMaPhucLoi = new TextBox();
            pictureBox1 = new PictureBox();
            txtMaNhanVien = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnTao = new Button();
            btnHuy = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(13, 13);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(691, 67);
            panel1.TabIndex = 74;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.ImeMode = ImeMode.NoControl;
            label9.Location = new Point(118, 0);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(481, 67);
            label9.TabIndex = 46;
            label9.Text = "Tham Gia Phúc Lợi ";
            label9.Click += label9_Click;
            // 
            // txtMaPhucLoi
            // 
            txtMaPhucLoi.Font = new Font("Microsoft Sans Serif", 12F);
            txtMaPhucLoi.Location = new Point(192, 130);
            txtMaPhucLoi.Margin = new Padding(4);
            txtMaPhucLoi.Name = "txtMaPhucLoi";
            txtMaPhucLoi.Size = new Size(176, 30);
            txtMaPhucLoi.TabIndex = 75;
            txtMaPhucLoi.TextChanged += txtMaPhucLoi_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(192, 192, 255);
            pictureBox1.Image = Properties.Resources.Untitled;
            pictureBox1.ImeMode = ImeMode.NoControl;
            pictureBox1.Location = new Point(397, 109);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 312);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 76;
            pictureBox1.TabStop = false;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Font = new Font("Microsoft Sans Serif", 12F);
            txtMaNhanVien.Location = new Point(192, 192);
            txtMaNhanVien.Margin = new Padding(4);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(176, 30);
            txtMaNhanVien.TabIndex = 77;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(39, 127);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 32);
            label1.TabIndex = 78;
            label1.Text = "Mã Phúc Lợi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(13, 189);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(175, 32);
            label2.TabIndex = 79;
            label2.Text = "Mã Nhân Viên ";
            // 
            // btnTao
            // 
            btnTao.BackColor = Color.LimeGreen;
            btnTao.Font = new Font("Microsoft Sans Serif", 12F);
            btnTao.ForeColor = Color.White;
            btnTao.Image = Properties.Resources.icons8_plus_48;
            btnTao.ImeMode = ImeMode.NoControl;
            btnTao.Location = new Point(64, 295);
            btnTao.Margin = new Padding(4);
            btnTao.Name = "btnTao";
            btnTao.Size = new Size(110, 45);
            btnTao.TabIndex = 80;
            btnTao.TextAlign = ContentAlignment.MiddleRight;
            btnTao.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTao.UseVisualStyleBackColor = false;
            btnTao.Click += btnTao_Click_1;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(255, 128, 128);
            btnHuy.Font = new Font("Microsoft Sans Serif", 12F);
            btnHuy.Image = Properties.Resources.icons8_x_48;
            btnHuy.ImeMode = ImeMode.NoControl;
            btnHuy.Location = new Point(226, 295);
            btnHuy.Margin = new Padding(4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(105, 45);
            btnHuy.TabIndex = 81;
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // TaoChiTietPhucLoi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 450);
            Controls.Add(btnHuy);
            Controls.Add(btnTao);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMaNhanVien);
            Controls.Add(pictureBox1);
            Controls.Add(txtMaPhucLoi);
            Controls.Add(panel1);
            Name = "TaoChiTietPhucLoi";
            Text = "TaoChiTietPhucLoics";
            Load += TaoChiTietPhucLoi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label9;
        private TextBox txtMaPhucLoi;
        private PictureBox pictureBox1;
        private TextBox txtMaNhanVien;
        private Label label1;
        private Label label2;
        private Button btnTao;
        private Button btnHuy;
    }
}