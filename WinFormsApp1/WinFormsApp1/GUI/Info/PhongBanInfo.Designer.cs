
namespace WinFormsApp1.GUI.Info
{
    partial class PhongBanInfo
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
        public void InitializeComponent()
        {
            panel7 = new Panel();
            pictureBox1 = new PictureBox();
            txtTenPB = new TextBox();
            txtMoTa = new TextBox();
            txtTruongPhong = new TextBox();
            txtMaPB = new TextBox();
            label9 = new Label();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.BackColor = Color.Lavender;
            panel7.Controls.Add(pictureBox1);
            panel7.Controls.Add(txtTenPB);
            panel7.Controls.Add(txtMoTa);
            panel7.Controls.Add(txtTruongPhong);
            panel7.Controls.Add(txtMaPB);
            panel7.Controls.Add(label9);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(label2);
            panel7.Dock = DockStyle.Fill;
            panel7.ForeColor = Color.FromArgb(49, 17, 117);
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(800, 450);
            panel7.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Untitled2;
            pictureBox1.Location = new Point(31, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 228);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtTenPB
            // 
            txtTenPB.Enabled = false;
            txtTenPB.Location = new Point(406, 173);
            txtTenPB.Name = "txtTenPB";
            txtTenPB.ReadOnly = true;
            txtTenPB.Size = new Size(233, 27);
            txtTenPB.TabIndex = 2;
            // 
            // txtMoTa
            // 
            txtMoTa.Enabled = false;
            txtMoTa.Location = new Point(406, 259);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.ReadOnly = true;
            txtMoTa.Size = new Size(233, 27);
            txtMoTa.TabIndex = 2;
            // 
            // txtTruongPhong
            // 
            txtTruongPhong.Enabled = false;
            txtTruongPhong.Location = new Point(406, 218);
            txtTruongPhong.Name = "txtTruongPhong";
            txtTruongPhong.ReadOnly = true;
            txtTruongPhong.Size = new Size(233, 27);
            txtTruongPhong.TabIndex = 2;
            // 
            // txtMaPB
            // 
            txtMaPB.Enabled = false;
            txtMaPB.Location = new Point(406, 131);
            txtMaPB.Name = "txtMaPB";
            txtMaPB.ReadOnly = true;
            txtMaPB.Size = new Size(233, 27);
            txtMaPB.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(349, 259);
            label9.Name = "label9";
            label9.Size = new Size(51, 20);
            label9.TabIndex = 1;
            label9.Text = "Mô tả:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(295, 218);
            label7.Name = "label7";
            label7.Size = new Size(105, 20);
            label7.TabIndex = 1;
            label7.Text = "Trưởng Phòng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(292, 176);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 1;
            label3.Text = "Tên Phòng Ban:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 134);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã Phòng Ban:";
            // 
            // PhongBanInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel7);
            Name = "PhongBanInfo";
            Text = "PhongBanInfo";
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel7;
        private PictureBox pictureBox1;
        private TextBox txtTenPB;
        private TextBox txtMoTa;
        private TextBox txtTruongPhong;
        private TextBox txtMaPB;
        private Label label9;
        private Label label7;
        private Label label3;
        private Label label2;
    }
}