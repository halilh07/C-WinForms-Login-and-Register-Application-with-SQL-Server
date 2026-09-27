namespace LoginApp
{
    partial class RegisterForm
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
            registerButton = new Button();
            usernameTextBox = new TextBox();
            label2 = new Label();
            nameTextBox = new TextBox();
            label3 = new Label();
            ageTextBox = new TextBox();
            loginnowButton = new Button();
            passwordTextbox = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(44, 27);
            label1.Name = "label1";
            label1.Size = new Size(110, 30);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.YellowGreen;
            registerButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            registerButton.Location = new Point(44, 282);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(183, 54);
            registerButton.TabIndex = 1;
            registerButton.Text = "REGISTER";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(179, 34);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(203, 23);
            usernameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(44, 86);
            label2.Name = "label2";
            label2.Size = new Size(71, 30);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(179, 95);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(203, 23);
            nameTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(44, 143);
            label3.Name = "label3";
            label3.Size = new Size(52, 30);
            label3.TabIndex = 5;
            label3.Text = "Age";
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(179, 152);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(203, 23);
            ageTextBox.TabIndex = 6;
            // 
            // loginnowButton
            // 
            loginnowButton.BackColor = Color.LightSeaGreen;
            loginnowButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            loginnowButton.Location = new Point(274, 282);
            loginnowButton.Name = "loginnowButton";
            loginnowButton.Size = new Size(259, 54);
            loginnowButton.TabIndex = 7;
            loginnowButton.Text = "I HAVE A ACCOUNT";
            loginnowButton.UseVisualStyleBackColor = false;
            loginnowButton.Click += loginnowButton_Click;
            // 
            // passwordTextbox
            // 
            passwordTextbox.Location = new Point(179, 212);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.Size = new Size(203, 23);
            passwordTextbox.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(44, 203);
            label4.Name = "label4";
            label4.Size = new Size(105, 30);
            label4.TabIndex = 8;
            label4.Text = "Password";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 388);
            Controls.Add(passwordTextbox);
            Controls.Add(label4);
            Controls.Add(loginnowButton);
            Controls.Add(ageTextBox);
            Controls.Add(label3);
            Controls.Add(nameTextBox);
            Controls.Add(label2);
            Controls.Add(usernameTextBox);
            Controls.Add(registerButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "RegisterForm";
            Text = "Register Window";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button registerButton;
        private TextBox usernameTextBox;
        private Label label2;
        private TextBox nameTextBox;
        private Label label3;
        private TextBox ageTextBox;
        private Button loginnowButton;
        private TextBox passwordTextbox;
        private Label label4;
    }
}