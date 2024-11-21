using System.Windows.Forms;

namespace WinFormsApp1.GUI
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            linkLabel2 = new LinkLabel();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            button2 = new Button();
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 690);
            panel1.TabIndex = 0;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.ForeColor = Color.Black;
            linkLabel2.Location = new Point(300, 613);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(79, 28);
            linkLabel2.TabIndex = 12;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Sign up";
            linkLabel2.VisitedLinkColor = Color.Navy;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 8F);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(84, 616);
            label3.Name = "label3";
            label3.Size = new Size(210, 34);
            label3.TabIndex = 11;
            label3.Text = "Don't have an ccount yet?\r\n\r\n";
            label3.Click += label3_Click_1;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(271, 496);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(156, 28);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forget Password";
            linkLabel1.UseMnemonic = false;
            linkLabel1.VisitedLinkColor = Color.Blue;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 0, 192);
            button2.ForeColor = Color.White;
            button2.Location = new Point(66, 547);
            button2.Name = "button2";
            button2.Size = new Size(363, 56);
            button2.TabIndex = 9;
            button2.Text = "Log in";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(66, 495);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(157, 32);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Keep me login";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(66, 439);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(363, 34);
            textBox2.TabIndex = 5;
            textBox2.Text = "Your Password";
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(66, 386);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(363, 34);
            textBox1.TabIndex = 0;
            textBox1.Text = "Your Email";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(148, 330);
            label2.Name = "label2";
            label2.Size = new Size(124, 13);
            label2.TabIndex = 4;
            label2.Text = "OR LOGIN WITH EMAIL";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.ForeColor = Color.Silver;
            panel3.Location = new Point(84, 340);
            panel3.Name = "panel3";
            panel3.Size = new Size(324, 3);
            panel3.TabIndex = 3;
            // 
            // button1
            // 
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(66, 256);
            button1.Name = "button1";
            button1.Size = new Size(363, 38);
            button1.TabIndex = 2;
            button1.Text = "Log in with Google";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            //pictureBox1.Image = WinFormsApp1.Properties.Resources.read__1_;
            pictureBox1.Location = new Point(184, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 149);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            label1.Location = new Point(122, 180);
            label1.Name = "label1";
            label1.Size = new Size(267, 43);
            label1.TabIndex = 0;
            label1.Text = "Welcome Back";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 255);
            //panel2.BackgroundImage = WinFormsApp1.Properties.Resources.congso;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(494, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(440, 690);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 690);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label2;
        private Panel panel3;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private TextBox textBox2;
        private Button button2;
        private LinkLabel linkLabel1;
        private Label label3;
        private LinkLabel linkLabel2;
    }
}
