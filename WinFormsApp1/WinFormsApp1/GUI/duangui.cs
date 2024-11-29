﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Text;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Drawing2D;
using OfficeOpenXml;
using ExcelDataReader;
using WinFormsApp1.BUS;
using WinFormsApp1.DTO;
using WinFormsApp1.Imports;
using WinFormsApp1.Exports;
using WinFormsApp1.GUI.detail;
using static System.Windows.Forms.AxHost;
using System.IO;

namespace WinFormsApp1.GUI
{
    public partial class duangui : UserControl
    {
        static duanbus projectBUS = new duanbus();
        duandto projectDTO = new duandto();
        List<duandto> projects = projectBUS.GetDuAn();

        private Panel panel1;
        private Panel panel2;
        private Panel panel6;
        private Button delete;
        private Button Import;
        private Button export;
        private Button Tao;
        private TextBox txtSearch;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private Panel panel3;
        private Panel panel5;
        private DataGridView dataGridView1;
        private Button edit;

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel5 = new Panel();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            panel6 = new Panel();
            edit = new Button();
            delete = new Button();
            Import = new Button();
            export = new Button();
            Tao = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(252, 250, 255);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 600);
            panel1.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(dataGridView1);
            panel5.Location = new Point(3, 47);
            panel5.Name = "panel5";
            panel5.Size = new Size(994, 550);
            panel5.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 70;
            dataGridView1.GridColor = SystemColors.Info;
            dataGridView1.Location = new Point(0, 8);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
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
            dataGridView1.Size = new Size(994, 542);
            dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.ForeColor = Color.FromArgb(49, 17, 117);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 49);
            panel2.TabIndex = 0;
            panel2.MouseClick += panel2_MouseClick;
            // 
            // panel6
            // 
            panel6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel6.BackColor = Color.White;
            panel6.Controls.Add(edit);
            panel6.Controls.Add(delete);
            panel6.Controls.Add(Import);
            panel6.Controls.Add(export);
            panel6.Controls.Add(Tao);
            panel6.Controls.Add(txtSearch);
            panel6.Location = new Point(132, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(825, 49);
            panel6.TabIndex = 6;
            panel6.MouseClick += panel6_MouseClick;
            // 
            // edit
            // 
            edit.BackColor = Color.Lavender;
            edit.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            edit.FlatStyle = FlatStyle.Flat;
            edit.Location = new Point(370, 9);
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
            delete.Location = new Point(456, 9);
            delete.Name = "delete";
            delete.Size = new Size(80, 30);
            delete.TabIndex = 9;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // Import
            // 
            Import.BackColor = Color.Lavender;
            Import.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            Import.FlatStyle = FlatStyle.Flat;
            Import.Location = new Point(542, 9);
            Import.Name = "Import";
            Import.Size = new Size(80, 30);
            Import.TabIndex = 9;
            Import.Text = "Import";
            Import.UseVisualStyleBackColor = false;
            Import.Click += Import_Click;
            // 
            // export
            // 
            export.BackColor = Color.Lavender;
            export.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            export.FlatStyle = FlatStyle.Flat;
            export.Location = new Point(628, 9);
            export.Name = "export";
            export.Size = new Size(80, 30);
            export.TabIndex = 8;
            export.Text = "Export";
            export.UseVisualStyleBackColor = false;
            export.Click += export_Click;
            // 
            // Tao
            // 
            Tao.BackColor = Color.LimeGreen;
            Tao.FlatAppearance.BorderSize = 0;
            Tao.FlatStyle = FlatStyle.Flat;
            Tao.Image = Properties.Resources.add2;
            Tao.Location = new Point(725, 4);
            Tao.Name = "Tao";
            Tao.Size = new Size(90, 40);
            Tao.TabIndex = 2;
            Tao.UseVisualStyleBackColor = false;
            Tao.Click += Tao_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(6, 11);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(344, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(49, 17, 117);
            label1.Location = new Point(0, -5);
            label1.Name = "label1";
            label1.Size = new Size(141, 47);
            label1.TabIndex = 1;
            label1.Text = "Dự án";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(252, 250, 255);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 47);
            panel3.Name = "panel3";
            panel3.Size = new Size(1000, 2);
            panel3.TabIndex = 0;
            panel3.Visible = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // duangui
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(49, 17, 117);
            Margin = new Padding(0);
            Name = "duangui";
            Size = new Size(1000, 600);
            Load += duangui_Load;
            MouseClick += duangui_MouseClick;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        private void LoadDataToGUI(int a)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Check", typeof(bool));
            dt.Columns.Add("Ma Du An", typeof(string));
            dt.Columns.Add("Ten Du An", typeof(string));
            dt.Columns.Add("Mo Ta", typeof(string));
            dt.Columns.Add("Ngay Bat Dau", typeof(string));
            dt.Columns.Add("Ngay Ket Thuc", typeof(string));
            dt.Columns.Add("Quan Ly Du An", typeof(string));
            dt.Columns.Add("Phong Ban Phu Trach", typeof(string));
            dt.Columns.Add("Trang Thai", typeof(int));

            if (a == 2)
            {
                foreach (duandto project in projects)
                {
                    dt.Rows.Add(false, project.MaDuAn, project.TenDuAn, project.MoTa, project.NgayBatDau.ToString("dd/MM/yyyy"), project.NgayKetThuc.ToString("dd/MM/yyyy"), project.QuanLyDuAn, project.PhongBanPhuTrach, project.TrangThai);
                }
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["Mo ta"].Visible = false;
                dataGridView1.Columns["Ngay Bat Dau"].Visible = false;
                dataGridView1.Columns["Ngay Ket Thuc"].Visible = false;
                dataGridView1.Columns["Quan Ly Du An"].Visible = false;
                dataGridView1.Columns["Trang Thai"].Visible = false;
            }
            else
            {
                var filteredProjects = projects.Where(p => p.TrangThai == a).ToList();

                foreach (duandto project in filteredProjects)
                {
                    dt.Rows.Add(false, project.MaDuAn, project.TenDuAn, project.MoTa, project.NgayBatDau.ToString("dd/MM/yyyy"), project.NgayKetThuc.ToString("dd/MM/yyyy"), project.QuanLyDuAn, project.PhongBanPhuTrach, project.TrangThai);
                }
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["Mo ta"].Visible = false;
                dataGridView1.Columns["Ngay Bat Dau"].Visible = false;
                dataGridView1.Columns["Ngay Ket Thuc"].Visible = false;
                dataGridView1.Columns["Quan Ly Du An"].Visible = false;
                dataGridView1.Columns["Trang Thai"].Visible = false;
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = dataGridView1.ColumnHeadersDefaultCellStyle.BackColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor;
        }

        public duangui()
        {
            InitializeComponent();
        }

        private void duangui_Load(object sender, EventArgs e)
        {
            LoadDataToGUI(1);
            txtSearch.PlaceholderText = "Tìm kiếm ...";
            dataGridView1.Size = new Size(1575, 870);
        }

        string maDuAnSelected;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //    dataGridView1.Size = new Size(1575, 450);
            //    dataGridView1.DefaultCellStyle.SelectionForeColor = Color.FromArgb(49, 17, 117);
            //    dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Lavender;


            //    maDuAnSelected = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            //    duandto selectedProject = projects.FirstOrDefault(project => project.MaDuAn == maDuAnSelected);

            //    if (selectedProject != null)
            //    {
            //        txtMaDuAn.Text = selectedProject.MaDuAn.Trim();
            //        txtTenDuAn.Text = selectedProject.TenDuAn.Trim();
            //        txtMoTa.Text = selectedProject.MoTa.Trim();
            //        dtpNgayBatDau.Value = selectedProject.NgayBatDau;
            //        dtpNgayKetThuc.Value = selectedProject.NgayKetThuc;
            //        txtQuanLyDuAn.Text = selectedProject.QuanLyDuAn.Trim();
            //        txtPhongBanPhuTrach.Text = selectedProject.PhongBanPhuTrach.Trim();
            //        cmbTrangThai.SelectedIndex = selectedProject.TrangThai - 1;
            //    }
        }

        private void duangui_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.Size = new Size(1575, 870);
            dataGridView1.ClearSelection();
        }

        private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.Size = new Size(1575, 870);
            dataGridView1.ClearSelection();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.Size = new Size(1575, 870);
            dataGridView1.ClearSelection();
        }

        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.Size = new Size(1575, 870);
            dataGridView1.ClearSelection();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            duandto selectedProject = projects.FirstOrDefault(project => project.MaDuAn == maDuAnSelected);
            if (selectedProject != null)
            {
                if (selectedProject.TrangThai == 1)
                {
                    try
                    {
                        projectBUS.UpdateDuAn(new duandto { MaDuAn = selectedProject.MaDuAn, TrangThai = 0 });
                        MessageBox.Show("Xóa dự án thành công!!!");
                        LoadDataToGUI(1);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi xảy ra trong quá trình xóa: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Dự án này đã được xóa hoặc hoàn thành!!!");
                }
            }
            else
            {
                MessageBox.Show("Chọn một dự án để xóa!");
            }
        }


        private void edit_Click(object sender, EventArgs e)
        {
            duandto selectedProject = projects.FirstOrDefault(project => project.MaDuAn == maDuAnSelected);

            if (selectedProject != null)
            {
                SuaDuAn interf = new SuaDuAn(selectedProject);
                interf.StartPosition = FormStartPosition.CenterParent;
                interf.ShowDialog();
                LoadDataToGUI(1);
            }
            else
            {
                MessageBox.Show("Chọn một dự án để chỉnh sửa!");
            }
        }

        private void Tao_Click(object sender, EventArgs e)
        {
            //TaoDuAn interf = new TaoDuAn();
            //interf.StartPosition = FormStartPosition.CenterParent;
            //interf.ShowDialog();
            //LoadDataToGUI(1);
        }

        private void Import_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Title = "Chọn tệp Excel",
                    Filter = "Excel Files (*.xlsx;*.xls)|*.xlsx;*.xls|All Files (*.*)|*.*",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    Import im = new Import();
                    im.ImportProjectByExcel(filePath);
                    MessageBox.Show("Import dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataToGUI(1);
                }
                else
                {
                    MessageBox.Show("Bạn đã hủy chọn file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Chọn vị trí lưu file",
                Filter = "Excel Files (*.xlsx)|*.xlsx|Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                DefaultExt = "xlsx",
                AddExtension = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                MessageBox.Show($"File sẽ được lưu tại: {filePath}", "Thông báo");

                export ex = new export();
                ex.SaveProjectToExcel(filePath);
            }
            else
            {
                MessageBox.Show("Bạn đã hủy lưu file.", "Thông báo");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.ToLower();

            if (string.IsNullOrWhiteSpace(searchValue))
            {
                txtSearch.PlaceholderText = "Tìm kiếm ...";
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Visible = string.IsNullOrEmpty(searchValue) || RowContainsValue(row, searchValue);
            }
        }

        private bool RowContainsValue(DataGridViewRow row, string searchValue)
        {
            foreach (DataGridViewCell cell in row.Cells)
            {
                if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchValue))
                {
                    return true;
                }
            }
            return false;
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            txtSearch.PlaceholderText = "Tìm kiếm ...";
        }
    }
}