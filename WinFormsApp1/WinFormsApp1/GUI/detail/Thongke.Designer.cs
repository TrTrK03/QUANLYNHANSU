namespace WinFormsApp1.GUI.detail
{
    partial class Thongke
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            domainUpDown2 = new DomainUpDown();
            domainUpDown1 = new DomainUpDown();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(49, 21);
            chart1.Margin = new Padding(2);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(218, 214);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart2.Legends.Add(legend2);
            chart2.Location = new Point(49, 254);
            chart2.Margin = new Padding(2);
            chart2.Name = "chart2";
            chart2.RightToLeft = RightToLeft.Yes;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
            series2.Legend = "Legend1";
            series2.Name = "Đúng giờ";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
            series3.Legend = "Legend1";
            series3.Name = "Trễ giờ";
            chart2.Series.Add(series2);
            chart2.Series.Add(series3);
            chart2.Size = new Size(663, 257);
            chart2.TabIndex = 1;
            chart2.Text = "chart2";
            // 
            // domainUpDown2
            // 
            domainUpDown2.Items.Add("2023");
            domainUpDown2.Items.Add("2024");
            domainUpDown2.Items.Add("2025");
            domainUpDown2.Location = new Point(511, 82);
            domainUpDown2.Margin = new Padding(2);
            domainUpDown2.Name = "domainUpDown2";
            domainUpDown2.ReadOnly = true;
            domainUpDown2.Size = new Size(87, 27);
            domainUpDown2.TabIndex = 16;
            //domainUpDown2.SelectedItemChanged += domainUpDown2_SelectedItemChanged;
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
            domainUpDown1.Location = new Point(511, 36);
            domainUpDown1.Margin = new Padding(2);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.ReadOnly = true;
            domainUpDown1.Size = new Size(87, 27);
            domainUpDown1.TabIndex = 15;
            //domainUpDown1.SelectedItemChanged += domainUpDown1_SelectedItemChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(455, 84);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 14;
            label4.Text = "Năm:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(455, 38);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 13;
            label3.Text = "Tháng:";
            // 
            // Thongke
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 533);
            Controls.Add(domainUpDown2);
            Controls.Add(domainUpDown1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(chart2);
            Controls.Add(chart1);
            Margin = new Padding(2);
            Name = "Thongke";
            Text = "Thongke";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private DomainUpDown domainUpDown2;
        private DomainUpDown domainUpDown1;
        private Label label4;
        private Label label3;
    }
}