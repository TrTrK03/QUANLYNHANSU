namespace WinFormsApp1.GUI
{
    partial class Regist
    {
        private System.ComponentModel.IContainer components = null;



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
            label3 = new Label();
            txtConfirmPassword = new TextBox();
            chckbxPassword = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(186, 57);
            label1.Name = "label1";
            label1.Size = new Size(116, 39);
            label1.TabIndex = 0;
            label1.Text = "Regist";
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.ForeColor = Color.DarkGray;
            Username.Location = new Point(78, 137);
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
            txtUsername.Location = new Point(74, 159);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(350, 28);
            txtUsername.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(78, 214);
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
            txtPassword.Location = new Point(74, 236);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(350, 28);
            txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(74, 290);
            label3.Name = "label3";
            label3.Size = new Size(128, 38);
            label3.TabIndex = 5;
            label3.Text = "Confirm Password\r\n\r\n";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = SystemColors.MenuBar;
            txtConfirmPassword.BorderStyle = BorderStyle.None;
            txtConfirmPassword.Font = new Font("Lucida Console", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(74, 313);
            txtConfirmPassword.Multiline = true;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(350, 28);
            txtConfirmPassword.TabIndex = 6;
            // 
            // chckbxPassword
            // 
            chckbxPassword.AutoSize = true;
            chckbxPassword.Cursor = Cursors.Hand;
            chckbxPassword.FlatStyle = FlatStyle.Flat;
            chckbxPassword.ForeColor = Color.DarkGray;
            chckbxPassword.Location = new Point(297, 347);
            chckbxPassword.Name = "chckbxPassword";
            chckbxPassword.Size = new Size(127, 23);
            chckbxPassword.TabIndex = 7;
            chckbxPassword.Text = "Show Password\r\n";
            chckbxPassword.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(74, 416);
            button1.Name = "button1";
            button1.Size = new Size(350, 35);
            button1.TabIndex = 8;
            button1.Text = "REGISTER";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Indigo;
            button2.Location = new Point(74, 476);
            button2.Name = "button2";
            button2.Size = new Size(350, 35);
            button2.TabIndex = 9;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(159, 528);
            label4.Name = "label4";
            label4.Size = new Size(180, 19);
            label4.TabIndex = 10;
            label4.Text = "Already Have An Account\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.ForeColor = Color.Indigo;
            label5.Location = new Point(201, 557);
            label5.Name = "label5";
            label5.Size = new Size(101, 19);
            label5.TabIndex = 11;
            label5.Text = "Back to Log in";
            label5.Click += label5_Click_1;
            // 
            // Regist
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(500, 650);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(chckbxPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(Username);
            Controls.Add(label1);
            Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Silver;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Regist";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Regist";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.CheckBox chckbxPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

