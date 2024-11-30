namespace WinFormsApp1.GUI.NewFolder
{
    partial class bangLuongGUI
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
            groupBox1 = new GroupBox();
            dataWage = new DataGridView();
            groupBox2 = new GroupBox();
            btnReset = new Button();
            searchWage = new TextBox();
            searchWaveByEmployee = new Button();
            deleteWate = new Button();
            editWave = new Button();
            addWave = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataWage).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataWage);
            groupBox1.Location = new Point(18, 143);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1023, 492);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách bảng lương";
            // 
            // dataWage
            // 
            dataWage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataWage.Location = new Point(33, 35);
            dataWage.Name = "dataWage";
            dataWage.RowHeadersWidth = 51;
            dataWage.Size = new Size(970, 451);
            dataWage.TabIndex = 0;
            dataWage.CellContentClick += dataWage_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnReset);
            groupBox2.Controls.Add(searchWage);
            groupBox2.Controls.Add(searchWaveByEmployee);
            groupBox2.Controls.Add(deleteWate);
            groupBox2.Controls.Add(editWave);
            groupBox2.Controls.Add(addWave);
            groupBox2.Location = new Point(18, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1023, 97);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(451, 33);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(113, 41);
            btnReset.TabIndex = 5;
            btnReset.Text = "Làm mới";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // searchWage
            // 
            searchWage.Location = new Point(626, 41);
            searchWage.Name = "searchWage";
            searchWage.PlaceholderText = "Tìm kiếm theo mã hoặc tên ";
            searchWage.Size = new Size(248, 27);
            searchWage.TabIndex = 4;
            // 
            // searchWaveByEmployee
            // 
            searchWaveByEmployee.Image = Properties.Resources.search;
            searchWaveByEmployee.Location = new Point(908, 34);
            searchWaveByEmployee.Name = "searchWaveByEmployee";
            searchWaveByEmployee.Size = new Size(84, 41);
            searchWaveByEmployee.TabIndex = 3;
            searchWaveByEmployee.UseVisualStyleBackColor = true;
            searchWaveByEmployee.Click += searchWaveByEmployee_Click;
            // 
            // deleteWate
            // 
            deleteWate.Location = new Point(316, 33);
            deleteWate.Name = "deleteWate";
            deleteWate.Size = new Size(116, 41);
            deleteWate.TabIndex = 2;
            deleteWate.Text = "Xóa";
            deleteWate.UseVisualStyleBackColor = true;
            deleteWate.Click += button3_Click;
            // 
            // editWave
            // 
            editWave.Location = new Point(169, 34);
            editWave.Name = "editWave";
            editWave.Size = new Size(122, 41);
            editWave.TabIndex = 1;
            editWave.Text = "Sửa";
            editWave.UseVisualStyleBackColor = true;
            editWave.Click += editWave_Click;
            // 
            // addWave
            // 
            addWave.Location = new Point(33, 33);
            addWave.Name = "addWave";
            addWave.Size = new Size(111, 41);
            addWave.TabIndex = 0;
            addWave.Text = "Thêm";
            addWave.UseVisualStyleBackColor = true;
            addWave.Click += addWave_Click;
            // 
            // bangLuongGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "bangLuongGUI";
            Size = new Size(1060, 638);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataWage).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataWage;
        private GroupBox groupBox2;
        private Button deleteWate;
        private Button editWave;
        private Button addWave;
        private TextBox searchWage;
        private Button searchWaveByEmployee;
        private Button btnReset;
    }
}