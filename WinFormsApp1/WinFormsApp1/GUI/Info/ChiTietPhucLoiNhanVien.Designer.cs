namespace WinFormsApp1.GUI.Info
{
    partial class ChiTietPhucLoiNhanVien
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
            txtMoTa = new TextBox();
            txtGiaTriPhucLoi = new TextBox();
            txtSearch = new TextBox();
            label10 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            BtnTao = new Button();
            btn2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtMoTa
            // 
            txtMoTa.Enabled = false;
            txtMoTa.Location = new Point(12, 12);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(344, 70);
            txtMoTa.TabIndex = 3;
            // 
            // txtGiaTriPhucLoi
            // 
            txtGiaTriPhucLoi.Enabled = false;
            txtGiaTriPhucLoi.Location = new Point(445, 12);
            txtGiaTriPhucLoi.Name = "txtGiaTriPhucLoi";
            txtGiaTriPhucLoi.Size = new Size(268, 27);
            txtGiaTriPhucLoi.TabIndex = 4;
            
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(445, 55);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(268, 27);
            txtSearch.TabIndex = 81;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(385, 15);
            label10.Name = "label10";
            label10.Size = new Size(54, 20);
            label10.TabIndex = 82;
            label10.Text = "Giá Trị:";
            label10.Click += label10_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(364, 58);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 83;
            label1.Text = "Tìm Kiếm:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1007, 350);
            dataGridView1.TabIndex = 84;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BtnTao
            // 
            BtnTao.Location = new Point(751, 15);
            BtnTao.Name = "BtnTao";
            BtnTao.Size = new Size(94, 63);
            BtnTao.TabIndex = 85;
            BtnTao.Text = "Thêm";
            BtnTao.UseVisualStyleBackColor = true;
            BtnTao.Click += BtnTao_Click_1;
            // 
            // btn2
            // 
            btn2.Location = new Point(882, 15);
            btn2.Name = "btn2";
            btn2.Size = new Size(94, 63);
            btn2.TabIndex = 86;
            btn2.Text = "Xóa";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // ChiTietPhucLoiNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 450);
            Controls.Add(btn2);
            Controls.Add(BtnTao);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(label10);
            Controls.Add(txtSearch);
            Controls.Add(txtGiaTriPhucLoi);
            Controls.Add(txtMoTa);
            Name = "ChiTietPhucLoiNhanVien";
            Text = "ChiTietPhucLoiNhanVien";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMoTa;
        private TextBox txtGiaTriPhucLoi;
        private TextBox txtSearch;
        private Label label10;
        private Label label1;
        private DataGridView dataGridView1;
        private Button BtnTao;
        private Button btn2;
    }
}