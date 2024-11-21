namespace WinFormsApp1.GUI
{
    partial class Home
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
            panel1 = new Panel();
            panel4 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel2 = new Panel();
            panel6 = new Panel();
            button5 = new Button();
            button6 = new Button();
            export = new Button();
            button7 = new Button();
            button8 = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left;
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1698, 1100);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint_1;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveBorder;
            panel4.Location = new Point(0, 108);
            panel4.Name = "panel4";
            panel4.Size = new Size(157, 3);
            panel4.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Font = new Font("Bahnschrift Light", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flowLayoutPanel1.Location = new Point(0, 59);
            flowLayoutPanel1.Margin = new Padding(3, 0, 3, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1578, 52);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.CausesValidation = false;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Candara", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(64, 64, 64);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(108, 49);
            button1.TabIndex = 0;
            button1.Text = "Hiện hành";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.AutoSize = true;
            button2.CausesValidation = false;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Candara", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(117, 3);
            button2.Name = "button2";
            button2.Size = new Size(86, 49);
            button2.TabIndex = 1;
            button2.Text = "Tất cả";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.AutoSize = true;
            button3.CausesValidation = false;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Candara", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(209, 3);
            button3.Name = "button3";
            button3.Size = new Size(108, 49);
            button3.TabIndex = 2;
            button3.Text = "Tương lai";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.AutoSize = true;
            button4.CausesValidation = false;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Candara", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(323, 3);
            button4.Name = "button4";
            button4.Size = new Size(108, 49);
            button4.TabIndex = 3;
            button4.Text = "Hết hạn";
            button4.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1698, 51);
            panel2.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel6.BackColor = SystemColors.ActiveCaption;
            panel6.Controls.Add(button5);
            panel6.Controls.Add(button6);
            panel6.Controls.Add(export);
            panel6.Controls.Add(button7);
            panel6.Controls.Add(button8);
            panel6.Controls.Add(textBox2);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(458, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1240, 49);
            panel6.TabIndex = 6;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(450, 0);
            button5.Name = "button5";
            button5.Size = new Size(130, 49);
            button5.TabIndex = 9;
            button5.Text = "Import";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(603, 2);
            button6.Name = "button6";
            button6.Size = new Size(130, 49);
            button6.TabIndex = 9;
            button6.Text = "Import";
            button6.UseVisualStyleBackColor = true;
            // 
            // export
            // 
            export.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            export.FlatStyle = FlatStyle.Flat;
            export.Location = new Point(808, 3);
            export.Name = "export";
            export.Size = new Size(130, 49);
            export.TabIndex = 8;
            export.Text = "Export";
            export.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.BackColor = Color.LimeGreen;
            button7.Dock = DockStyle.Right;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Image = Properties.Resources.add2;
            button7.Location = new Point(1117, 0);
            button7.Name = "button7";
            button7.Size = new Size(123, 49);
            button7.TabIndex = 2;
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Image = Properties.Resources.search;
            button8.Location = new Point(301, 6);
            button8.Name = "button8";
            button8.Size = new Size(75, 37);
            button8.TabIndex = 1;
            button8.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(15, 9);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(251, 34);
            textBox2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Enabled = false;
            label1.Font = new Font("Tw Cen MT", 25F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 49);
            label1.TabIndex = 1;
            label1.Text = "Thông báo";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.AppWorkspace;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 49);
            panel3.Name = "panel3";
            panel3.Size = new Size(1698, 2);
            panel3.TabIndex = 0;
            panel3.Visible = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Home";
            Size = new Size(1698, 1100);
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel2;
        private Panel panel6;
        private Button button5;
        private Button button6;
        private Button export;
        private Button button7;
        private Button button8;
        private TextBox textBox2;
        private Label label1;
        private Panel panel3;
    }
}
