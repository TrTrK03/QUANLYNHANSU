namespace WinFormsApp1.GUI
{
    partial class Login
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
            label1 = new Label();
            Username = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            chckbxPassword = new CheckBox();
            butlogin = new Button();
            clear = new Button();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(185, 90);
            label1.Name = "label1";
            label1.Size = new Size(115, 39);
            label1.TabIndex = 0;
            label1.Text = "Log in";
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.ForeColor = Color.DarkGray;
            Username.Location = new Point(78, 177);
            Username.Name = "Username";
            Username.Size = new Size(75, 19);
            Username.TabIndex = 1;
            Username.Text = "Username\r\n";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.MenuBar;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Lucida Console", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(74, 199);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(350, 28);
            txtUsername.TabIndex = 2;
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(78, 261);
            label2.Name = "label2";
            label2.Size = new Size(70, 19);
            label2.TabIndex = 3;
            label2.Text = "Password\r\n";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.MenuBar;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Lucida Console", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(74, 283);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(350, 28);
            txtPassword.TabIndex = 4;
            
            // 
            // chckbxPassword
            // 
            chckbxPassword.AutoSize = true;
            chckbxPassword.Cursor = Cursors.Hand;
            chckbxPassword.FlatStyle = FlatStyle.Flat;
            chckbxPassword.ForeColor = Color.DarkGray;
            chckbxPassword.Location = new Point(297, 317);
            chckbxPassword.Name = "chckbxPassword";
            chckbxPassword.Size = new Size(127, 23);
            chckbxPassword.TabIndex = 7;
            chckbxPassword.Text = "Show Password\r\n";
            chckbxPassword.UseVisualStyleBackColor = true;
            chckbxPassword.CheckedChanged += chckbxPassword_CheckedChanged_1;
            // 
            // butlogin
            // 
            butlogin.BackColor = Color.Indigo;
            butlogin.Cursor = Cursors.Hand;
            butlogin.FlatAppearance.BorderSize = 0;
            butlogin.FlatStyle = FlatStyle.Flat;
            butlogin.ForeColor = Color.White;
            butlogin.Location = new Point(74, 393);
            butlogin.Name = "butlogin";
            butlogin.Size = new Size(350, 35);
            butlogin.TabIndex = 8;
            butlogin.Text = "LOGIN";
            butlogin.UseVisualStyleBackColor = false;
            butlogin.Click += butlogin_Click;
            // 
            // clear
            // 
            clear.BackColor = Color.White;
            clear.Cursor = Cursors.Hand;
            clear.FlatStyle = FlatStyle.Flat;
            clear.ForeColor = Color.Indigo;
            clear.Location = new Point(74, 463);
            clear.Name = "clear";
            clear.Size = new Size(350, 35);
            clear.TabIndex = 9;
            clear.Text = "CLEAR";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(159, 515);
            label4.Name = "label4";
            label4.Size = new Size(163, 19);
            label4.TabIndex = 10;
            label4.Text = "Don't Have An Account\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.ForeColor = Color.Indigo;
            label5.Location = new Point(175, 541);
            label5.Name = "label5";
            label5.Size = new Size(141, 19);
            label5.TabIndex = 11;
            label5.Text = "Regist New Account";
            label5.Click += label5_Click_1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(500, 650);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(clear);
            Controls.Add(butlogin);
            Controls.Add(chckbxPassword);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(Username);
            Controls.Add(label1);
            Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Silver;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chckbxPassword;
        private System.Windows.Forms.Button butlogin;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

