namespace WinFormsApp1.GUI
{
    partial class chamconggui
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel2 = new Panel();
            label2 = new Label();
            panel6 = new Panel();
            edit = new Button();
            delete = new Button();
            Tao = new Button();
            txtSearch = new TextBox();
            export = new Button();
            label1 = new Label();
            tongquan = new Button();
            panel5 = new Panel();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            domainUpDown1 = new DomainUpDown();
            domainUpDown2 = new DomainUpDown();
            chitiet = new Button();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.FromArgb(49, 17, 117);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1030, 59);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 16F);
            label2.ForeColor = Color.FromArgb(49, 17, 117);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(159, 59);
            label2.TabIndex = 1;
            label2.Text = "Chấm công";
            // 
            // panel6
            // 
            panel6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel6.BackColor = Color.White;
            panel6.Controls.Add(edit);
            panel6.Controls.Add(delete);
            panel6.Controls.Add(Tao);
            panel6.Controls.Add(txtSearch);
            panel6.Controls.Add(export);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(254, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(776, 59);
            panel6.TabIndex = 6;
            panel6.Paint += panel6_Paint;
            // 
            // edit
            // 
            edit.BackColor = Color.Lavender;
            edit.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            edit.FlatStyle = FlatStyle.Flat;
            edit.Location = new Point(297, 13);
            edit.Name = "edit";
            edit.Size = new Size(80, 30);
            edit.TabIndex = 10;
            edit.Text = "Edit";
            edit.UseVisualStyleBackColor = false;
            edit.Click += edit_Click;
            // 
            // delete
            // 
            delete.BackColor = Color.Lavender;
            delete.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            delete.FlatStyle = FlatStyle.Flat;
            delete.Location = new Point(383, 13);
            delete.Name = "delete";
            delete.Size = new Size(80, 30);
            delete.TabIndex = 9;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // Tao
            // 
            Tao.BackColor = Color.LimeGreen;
            Tao.FlatAppearance.BorderSize = 0;
            Tao.FlatStyle = FlatStyle.Flat;
            Tao.Image = Properties.Resources.add2;
            Tao.Location = new Point(572, 8);
            Tao.Name = "Tao";
            Tao.Size = new Size(90, 40);
            Tao.TabIndex = 2;
            Tao.UseVisualStyleBackColor = false;
            Tao.Click += Tao_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(29, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(237, 27);
            txtSearch.TabIndex = 0;
            // 
            // export
            // 
            export.BackColor = Color.Lavender;
            export.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            export.FlatStyle = FlatStyle.Flat;
            export.Location = new Point(469, 13);
            export.Name = "export";
            export.Size = new Size(80, 30);
            export.TabIndex = 8;
            export.Text = "Thống kê";
            export.UseVisualStyleBackColor = false;
            export.Click += export_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = Color.FromArgb(49, 17, 117);
            label1.Location = new Point(443, -1);
            label1.Name = "label1";
            label1.Size = new Size(149, 47);
            label1.TabIndex = 1;
            label1.Text = "Thông Báo";
            // 
            // tongquan
            // 
            tongquan.BackColor = Color.Lavender;
            tongquan.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            tongquan.FlatStyle = FlatStyle.Flat;
            tongquan.Location = new Point(9, 3);
            tongquan.Name = "tongquan";
            tongquan.Size = new Size(87, 30);
            tongquan.TabIndex = 9;
            tongquan.Text = "Tổng quan";
            tongquan.UseVisualStyleBackColor = false;
            tongquan.Click += tongquan_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Silver;
            panel5.Controls.Add(dataGridView1);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 104);
            panel5.Name = "panel5";
            panel5.Size = new Size(1030, 609);
            panel5.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 70;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.Info;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 100;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(1030, 609);
            dataGridView1.TabIndex = 1;
            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(562, 6);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 9;
            label3.Text = "Tháng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(736, 6);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 10;
            label4.Text = "Năm:";
            // 
            // domainUpDown1
            // 
            domainUpDown1.Items.Add("1");
            domainUpDown1.Items.Add("2");
            domainUpDown1.Items.Add("3");
            domainUpDown1.Items.Add("4");
            domainUpDown1.Items.Add("5");
            domainUpDown1.Items.Add("6");
            domainUpDown1.Items.Add("7");
            domainUpDown1.Items.Add("8");
            domainUpDown1.Items.Add("9");
            domainUpDown1.Items.Add("10");
            domainUpDown1.Items.Add("11");
            domainUpDown1.Items.Add("12");
            domainUpDown1.Location = new Point(617, 5);
            domainUpDown1.Margin = new Padding(2);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.ReadOnly = true;
            domainUpDown1.Size = new Size(87, 27);
            domainUpDown1.TabIndex = 11;
            domainUpDown1.SelectedItemChanged += domainUpDown1_SelectedItemChanged;
            // 
            // domainUpDown2
            // 
            domainUpDown2.Items.Add("2023");
            domainUpDown2.Items.Add("2024");
            domainUpDown2.Items.Add("2025");
            domainUpDown2.Location = new Point(782, 5);
            domainUpDown2.Margin = new Padding(2);
            domainUpDown2.Name = "domainUpDown2";
            domainUpDown2.ReadOnly = true;
            domainUpDown2.Size = new Size(87, 27);
            domainUpDown2.TabIndex = 12;
            domainUpDown2.SelectedItemChanged += domainUpDown2_SelectedItemChanged;
            // 
            // chitiet
            // 
            chitiet.BackColor = Color.Lavender;
            chitiet.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            chitiet.FlatStyle = FlatStyle.Flat;
            chitiet.Location = new Point(102, 3);
            chitiet.Name = "chitiet";
            chitiet.Size = new Size(80, 30);
            chitiet.TabIndex = 13;
            chitiet.Text = "Chi tiết";
            chitiet.UseVisualStyleBackColor = false;
            chitiet.Click += chitiet_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(tongquan);
            panel1.Controls.Add(domainUpDown2);
            panel1.Controls.Add(domainUpDown1);
            panel1.Controls.Add(chitiet);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(1030, 39);
            panel1.TabIndex = 4;
            // 
            // chamconggui
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Margin = new Padding(2);
            Name = "chamconggui";
            Size = new Size(1030, 713);
            Load += chamconggui_Load;
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel6;
        private Button edit;
        private Button delete;
        private Button Tao;
        private Button tongquan;
        private TextBox txtSearch;
        private Label label1;
        private Panel panel5;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DomainUpDown domainUpDown1;
        private DomainUpDown domainUpDown2;
        private Button export;
        private Button chitiet;
        private Panel panel1;
    }
}
