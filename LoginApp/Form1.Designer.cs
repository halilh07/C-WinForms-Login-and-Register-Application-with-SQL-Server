namespace LoginApp
{
    partial class LoginForm
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
            label1 = new Label();
            loginButton = new Button();
            usernameTextbox = new TextBox();
            Password = new Label();
            passwordTextbox = new TextBox();
            registernowButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(59, 59);
            label1.Name = "label1";
            label1.Size = new Size(110, 30);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // loginButton
            // 
            loginButton.BackColor = SystemColors.ActiveCaption;
            loginButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            loginButton.Location = new Point(59, 236);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(167, 57);
            loginButton.TabIndex = 1;
            loginButton.Text = "LOGİN";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // usernameTextbox
            // 
            usernameTextbox.Location = new Point(200, 68);
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.Size = new Size(229, 23);
            usernameTextbox.TabIndex = 2;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Password.Location = new Point(59, 142);
            Password.Name = "Password";
            Password.Size = new Size(105, 30);
            Password.TabIndex = 3;
            Password.Text = "Password";
            // 
            // passwordTextbox
            // 
            passwordTextbox.Location = new Point(200, 149);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.Size = new Size(229, 23);
            passwordTextbox.TabIndex = 4;
            // 
            // registernowButton
            // 
            registernowButton.BackColor = Color.YellowGreen;
            registernowButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            registernowButton.Location = new Point(263, 236);
            registernowButton.Name = "registernowButton";
            registernowButton.Size = new Size(215, 57);
            registernowButton.TabIndex = 5;
            registernowButton.Text = "REGİSTER NOW";
            registernowButton.UseVisualStyleBackColor = false;
            registernowButton.Click += registernowButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 376);
            Controls.Add(registernowButton);
            Controls.Add(passwordTextbox);
            Controls.Add(Password);
            Controls.Add(usernameTextbox);
            Controls.Add(loginButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "LoginForm";
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button loginButton;
        private TextBox usernameTextbox;
        private Label Password;
        private TextBox passwordTextbox;
        private Button registernowButton;
    }
}
