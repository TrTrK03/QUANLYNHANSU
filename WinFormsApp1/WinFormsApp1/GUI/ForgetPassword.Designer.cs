namespace WinFormsApp1.GUI
{
    partial class ForgetPassword
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
            panel1 = new Panel();
            linkLabel2 = new LinkLabel();
            label5 = new Label();
            label4 = new Label();
            button2 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(837, 514);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.ForeColor = Color.Black;
            linkLabel2.Location = new Point(523, 419);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(61, 25);
            linkLabel2.TabIndex = 17;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Log in";
            linkLabel2.VisitedLinkColor = Color.Navy;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(263, 422);
            label5.Name = "label5";
            label5.Size = new Size(254, 30);
            label5.TabIndex = 12;
            label5.Text = "Did you reminder your password ? ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(223, 268);
            label4.Name = "label4";
            label4.Size = new Size(84, 21);
            label4.TabIndex = 16;
            label4.Text = "Your Email";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 0, 192);
            button2.ForeColor = Color.White;
            button2.Location = new Point(190, 366);
            button2.Name = "button2";
            button2.Size = new Size(479, 41);
            button2.TabIndex = 15;
            button2.Text = "Send";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(223, 307);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(410, 31);
            textBox3.TabIndex = 14;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(190, 178);
            label3.Name = "label3";
            label3.Size = new Size(479, 63);
            label3.TabIndex = 6;
            label3.Text = "Resetting your password is easy. Just type your email, and we will send you an email to reset your password.";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(285, 145);
            label2.Name = "label2";
            label2.Size = new Size(279, 21);
            label2.TabIndex = 5;
            label2.Text = "Don't worry. Happens to the best of us.";
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(285, 56);
            label1.Name = "label1";
            label1.Size = new Size(279, 38);
            label1.TabIndex = 3;
            label1.Text = "Forgot Password";
            // 
            // pictureBox1
            // 
            //pictureBox1.Image = Properties.Resources.read__1_;
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 94);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // ForgetPassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 514);
            Controls.Add(panel1);
            Name = "ForgetPassword";
            Text = "ForgetPassword";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Button button2;
        private Label label4;
        private Label label5;
        private LinkLabel linkLabel2;
    }
}