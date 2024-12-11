
using System.Windows.Forms;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel7 = new Panel();
            txtTenPB = new TextBox();
            txtMoTa = new TextBox();
            txtTruongPhong = new TextBox();
            txtMaPB = new TextBox();
            label9 = new Label();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.BackColor = Color.Lavender;
            panel7.Controls.Add(txtTenPB);
            panel7.Controls.Add(txtMoTa);
            panel7.Controls.Add(txtTruongPhong);
            panel7.Controls.Add(txtMaPB);
            panel7.Controls.Add(label9);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(label2);
            panel7.Dock = DockStyle.Left;
            panel7.ForeColor = Color.FromArgb(49, 17, 117);
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(383, 282);
            panel7.TabIndex = 8;
            // 
            // txtTenPB
            // 
            txtTenPB.Enabled = false;
            txtTenPB.Location = new Point(124, 54);
            txtTenPB.Name = "txtTenPB";
            txtTenPB.ReadOnly = true;
            txtTenPB.Size = new Size(233, 27);
            txtTenPB.TabIndex = 2;
            // 
            // txtMoTa
            // 
            txtMoTa.Enabled = false;
            txtMoTa.Location = new Point(124, 140);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.ReadOnly = true;
            txtMoTa.Size = new Size(233, 84);
            txtMoTa.TabIndex = 2;
            // 
            // txtTruongPhong
            // 
            txtTruongPhong.Enabled = false;
            txtTruongPhong.Location = new Point(124, 99);
            txtTruongPhong.Name = "txtTruongPhong";
            txtTruongPhong.ReadOnly = true;
            txtTruongPhong.Size = new Size(233, 27);
            txtTruongPhong.TabIndex = 2;
            // 
            // txtMaPB
            // 
            txtMaPB.Enabled = false;
            txtMaPB.Location = new Point(124, 12);
            txtMaPB.Name = "txtMaPB";
            txtMaPB.ReadOnly = true;
            txtMaPB.Size = new Size(233, 27);
            txtMaPB.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(67, 140);
            label9.Name = "label9";
            label9.Size = new Size(51, 20);
            label9.TabIndex = 1;
            label9.Text = "Mô tả:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 99);
            label7.Name = "label7";
            label7.Size = new Size(105, 20);
            label7.TabIndex = 1;
            label7.Text = "Trưởng Phòng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 57);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 1;
            label3.Text = "Tên Phòng Ban:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 15);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã Phòng Ban:";
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(383, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(461, 282);
            panel1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Điều chỉnh chiều cao tiêu đề cột để vừa nội dung
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.Info;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;

            // Điều chỉnh chiều cao dòng cho phù hợp với nội dung
            dataGridView1.RowTemplate.Height = 50;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(1337, 454);
            dataGridView1.TabIndex = 1;
            // 
            // PhongBanInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 282);
            Controls.Add(panel1);
            Controls.Add(panel7);
            Name = "PhongBanInfo";
            Text = "PhongBanInfo";
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel7;
        private TextBox txtTenPB;
        private TextBox txtMoTa;
        private TextBox txtTruongPhong;
        private TextBox txtMaPB;
        private Label label9;
        private Label label7;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private DataGridView dataGridView1;
    }
}