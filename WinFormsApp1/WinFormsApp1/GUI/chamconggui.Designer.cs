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
            panel6 = new Panel();
            edit = new Button();
            delete = new Button();
            Tao = new Button();
            Import = new Button();
            export = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            panel5 = new Panel();
            dataGridView1 = new DataGridView();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.FromArgb(49, 17, 117);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1016, 59);
            panel2.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel6.BackColor = Color.White;
            panel6.Controls.Add(edit);
            panel6.Controls.Add(delete);
            panel6.Controls.Add(Tao);
            panel6.Controls.Add(Import);
            panel6.Controls.Add(export);
            panel6.Controls.Add(txtSearch);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(159, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(857, 59);
            panel6.TabIndex = 6;
            // 
            // edit
            // 
            edit.BackColor = Color.Lavender;
            edit.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            edit.FlatStyle = FlatStyle.Flat;
            edit.Location = new Point(383, 13);
            edit.Name = "edit";
            edit.Size = new Size(80, 30);
            edit.TabIndex = 10;
            edit.Text = "Edit";
            edit.UseVisualStyleBackColor = false;
            // 
            // delete
            // 
            delete.BackColor = Color.Lavender;
            delete.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            delete.FlatStyle = FlatStyle.Flat;
            delete.Location = new Point(469, 13);
            delete.Name = "delete";
            delete.Size = new Size(80, 30);
            delete.TabIndex = 9;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            // 
            // Tao
            // 
            Tao.BackColor = Color.LimeGreen;
            Tao.FlatAppearance.BorderSize = 0;
            Tao.FlatStyle = FlatStyle.Flat;
            Tao.Image = Properties.Resources.add2;
            Tao.Location = new Point(742, 8);
            Tao.Name = "Tao";
            Tao.Size = new Size(90, 40);
            Tao.TabIndex = 2;
            Tao.UseVisualStyleBackColor = false;
            // 
            // Import
            // 
            Import.BackColor = Color.Lavender;
            Import.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            Import.FlatStyle = FlatStyle.Flat;
            Import.Location = new Point(555, 13);
            Import.Name = "Import";
            Import.Size = new Size(80, 30);
            Import.TabIndex = 9;
            Import.Text = "Import";
            Import.UseVisualStyleBackColor = false;
            // 
            // export
            // 
            export.BackColor = Color.Lavender;
            export.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            export.FlatStyle = FlatStyle.Flat;
            export.Location = new Point(641, 13);
            export.Name = "export";
            export.Size = new Size(80, 30);
            export.TabIndex = 8;
            export.Text = "Export";
            export.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(29, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(344, 27);
            txtSearch.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = Color.FromArgb(49, 17, 117);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(159, 59);
            label1.TabIndex = 1;
            label1.Text = "Chấm Công";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Silver;
            panel5.Controls.Add(dataGridView1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 59);
            panel5.Name = "panel5";
            panel5.Size = new Size(1016, 654);
            panel5.TabIndex = 7;
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
            dataGridView1.Size = new Size(1016, 654);
            dataGridView1.TabIndex = 1;
            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
            // 
            // chamconggui
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel5);
            Controls.Add(panel2);
            Margin = new Padding(2);
            Name = "chamconggui";
            Size = new Size(1016, 713);
            Load += chamconggui_Load;
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel6;
        private Button edit;
        private Button delete;
        private Button Tao;
        private Button Import;
        private Button export;
        private TextBox txtSearch;
        private Label label1;
        private Panel panel5;
        private DataGridView dataGridView1;
    }
}
