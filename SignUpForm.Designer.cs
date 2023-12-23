namespace OnlyFriends {
    partial class SignUpForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
			this.emailBox = new System.Windows.Forms.TextBox();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.confirmPasswordBox = new System.Windows.Forms.TextBox();
			this.ageBox = new System.Windows.Forms.TextBox();
			this.phoneNumberBox = new System.Windows.Forms.TextBox();
			this.genderBox = new System.Windows.Forms.TextBox();
			this.firstNameLabel = new System.Windows.Forms.Label();
			this.emailLabel = new System.Windows.Forms.Label();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.confirmPasswordLabel = new System.Windows.Forms.Label();
			this.ageLabel = new System.Windows.Forms.Label();
			this.phoneNumberLabel = new System.Windows.Forms.Label();
			this.genderLabel = new System.Windows.Forms.Label();
			this.signUpButton = new System.Windows.Forms.Button();
			this.userNameBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// emailBox
			// 
			this.emailBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.emailBox.Location = new System.Drawing.Point(363, 174);
			this.emailBox.Margin = new System.Windows.Forms.Padding(4);
			this.emailBox.Name = "emailBox";
			this.emailBox.Size = new System.Drawing.Size(260, 22);
			this.emailBox.TabIndex = 3;
			this.emailBox.Text = "Email";
			this.emailBox.Enter += new System.EventHandler(this.emailBox_Enter);
			// 
			// passwordBox
			// 
			this.passwordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.passwordBox.Location = new System.Drawing.Point(176, 246);
			this.passwordBox.Margin = new System.Windows.Forms.Padding(4);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.Size = new System.Drawing.Size(260, 22);
			this.passwordBox.TabIndex = 4;
			this.passwordBox.Text = "Password";
			this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
			this.passwordBox.Enter += new System.EventHandler(this.passwordBox_Enter);
			// 
			// confirmPasswordBox
			// 
			this.confirmPasswordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.confirmPasswordBox.Location = new System.Drawing.Point(527, 246);
			this.confirmPasswordBox.Margin = new System.Windows.Forms.Padding(4);
			this.confirmPasswordBox.Name = "confirmPasswordBox";
			this.confirmPasswordBox.Size = new System.Drawing.Size(260, 22);
			this.confirmPasswordBox.TabIndex = 5;
			this.confirmPasswordBox.Text = "Confirm Password";
			this.confirmPasswordBox.Enter += new System.EventHandler(this.confirmPasswordBox_Enter);
			// 
			// ageBox
			// 
			this.ageBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ageBox.Location = new System.Drawing.Point(176, 322);
			this.ageBox.Margin = new System.Windows.Forms.Padding(4);
			this.ageBox.Name = "ageBox";
			this.ageBox.Size = new System.Drawing.Size(113, 22);
			this.ageBox.TabIndex = 6;
			this.ageBox.Text = "Age";
			this.ageBox.Enter += new System.EventHandler(this.ageBox_Enter);
			this.ageBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ageBox_KeyPress);
			// 
			// phoneNumberBox
			// 
			this.phoneNumberBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.phoneNumberBox.Location = new System.Drawing.Point(363, 322);
			this.phoneNumberBox.Margin = new System.Windows.Forms.Padding(4);
			this.phoneNumberBox.Name = "phoneNumberBox";
			this.phoneNumberBox.Size = new System.Drawing.Size(216, 22);
			this.phoneNumberBox.TabIndex = 7;
			this.phoneNumberBox.Text = "Phone Number";
			this.phoneNumberBox.Enter += new System.EventHandler(this.phoneNumberBox_Enter);
			this.phoneNumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNumberBox_KeyPress);
			// 
			// genderBox
			// 
			this.genderBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.genderBox.Location = new System.Drawing.Point(632, 322);
			this.genderBox.Margin = new System.Windows.Forms.Padding(4);
			this.genderBox.Name = "genderBox";
			this.genderBox.Size = new System.Drawing.Size(155, 22);
			this.genderBox.TabIndex = 8;
			this.genderBox.Text = "Gender";
			this.genderBox.Enter += new System.EventHandler(this.genderBox_Enter);
			// 
			// firstNameLabel
			// 
			this.firstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.firstNameLabel.AutoSize = true;
			this.firstNameLabel.BackColor = System.Drawing.Color.Transparent;
			this.firstNameLabel.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.firstNameLabel.ForeColor = System.Drawing.Color.White;
			this.firstNameLabel.Location = new System.Drawing.Point(171, 71);
			this.firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.firstNameLabel.Name = "firstNameLabel";
			this.firstNameLabel.Size = new System.Drawing.Size(95, 19);
			this.firstNameLabel.TabIndex = 3;
			this.firstNameLabel.Text = "User Name";
			this.firstNameLabel.Visible = false;
			this.firstNameLabel.Click += new System.EventHandler(this.firstNameLabel_Click);
			// 
			// emailLabel
			// 
			this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.emailLabel.AutoSize = true;
			this.emailLabel.BackColor = System.Drawing.Color.Transparent;
			this.emailLabel.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailLabel.ForeColor = System.Drawing.Color.White;
			this.emailLabel.Location = new System.Drawing.Point(456, 145);
			this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.Size = new System.Drawing.Size(51, 19);
			this.emailLabel.TabIndex = 3;
			this.emailLabel.Text = "Email";
			this.emailLabel.Visible = false;
			// 
			// passwordLabel
			// 
			this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
			this.passwordLabel.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordLabel.ForeColor = System.Drawing.Color.White;
			this.passwordLabel.Location = new System.Drawing.Point(171, 218);
			this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(86, 19);
			this.passwordLabel.TabIndex = 3;
			this.passwordLabel.Text = "Password";
			this.passwordLabel.Visible = false;
			// 
			// confirmPasswordLabel
			// 
			this.confirmPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.confirmPasswordLabel.AutoSize = true;
			this.confirmPasswordLabel.BackColor = System.Drawing.Color.Transparent;
			this.confirmPasswordLabel.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.confirmPasswordLabel.ForeColor = System.Drawing.Color.White;
			this.confirmPasswordLabel.Location = new System.Drawing.Point(521, 218);
			this.confirmPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.confirmPasswordLabel.Name = "confirmPasswordLabel";
			this.confirmPasswordLabel.Size = new System.Drawing.Size(153, 19);
			this.confirmPasswordLabel.TabIndex = 3;
			this.confirmPasswordLabel.Text = "Confirm Password";
			this.confirmPasswordLabel.Visible = false;
			// 
			// ageLabel
			// 
			this.ageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ageLabel.AutoSize = true;
			this.ageLabel.BackColor = System.Drawing.Color.Transparent;
			this.ageLabel.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ageLabel.ForeColor = System.Drawing.Color.White;
			this.ageLabel.Location = new System.Drawing.Point(171, 294);
			this.ageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.ageLabel.Name = "ageLabel";
			this.ageLabel.Size = new System.Drawing.Size(39, 19);
			this.ageLabel.TabIndex = 3;
			this.ageLabel.Text = "Age";
			this.ageLabel.Visible = false;
			// 
			// phoneNumberLabel
			// 
			this.phoneNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.phoneNumberLabel.AutoSize = true;
			this.phoneNumberLabel.BackColor = System.Drawing.Color.Transparent;
			this.phoneNumberLabel.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.phoneNumberLabel.ForeColor = System.Drawing.Color.White;
			this.phoneNumberLabel.Location = new System.Drawing.Point(401, 294);
			this.phoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.phoneNumberLabel.Name = "phoneNumberLabel";
			this.phoneNumberLabel.Size = new System.Drawing.Size(126, 19);
			this.phoneNumberLabel.TabIndex = 3;
			this.phoneNumberLabel.Text = "Phone Number";
			this.phoneNumberLabel.Visible = false;
			// 
			// genderLabel
			// 
			this.genderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.genderLabel.AutoSize = true;
			this.genderLabel.BackColor = System.Drawing.Color.Transparent;
			this.genderLabel.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.genderLabel.ForeColor = System.Drawing.Color.White;
			this.genderLabel.Location = new System.Drawing.Point(627, 294);
			this.genderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.genderLabel.Name = "genderLabel";
			this.genderLabel.Size = new System.Drawing.Size(66, 19);
			this.genderLabel.TabIndex = 3;
			this.genderLabel.Text = "Gender";
			this.genderLabel.Visible = false;
			// 
			// signUpButton
			// 
			this.signUpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.signUpButton.BackColor = System.Drawing.Color.White;
			this.signUpButton.FlatAppearance.BorderSize = 0;
			this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.signUpButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.signUpButton.Location = new System.Drawing.Point(389, 412);
			this.signUpButton.Margin = new System.Windows.Forms.Padding(4);
			this.signUpButton.Name = "signUpButton";
			this.signUpButton.Size = new System.Drawing.Size(191, 64);
			this.signUpButton.TabIndex = 0;
			this.signUpButton.Text = "Sign Up";
			this.signUpButton.UseVisualStyleBackColor = false;
			this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
			// 
			// userNameBox
			// 
			this.userNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.userNameBox.Location = new System.Drawing.Point(176, 100);
			this.userNameBox.Margin = new System.Windows.Forms.Padding(4);
			this.userNameBox.Name = "userNameBox";
			this.userNameBox.Size = new System.Drawing.Size(260, 22);
			this.userNameBox.TabIndex = 1;
			this.userNameBox.Text = "User Name";
			this.userNameBox.TextChanged += new System.EventHandler(this.firstNameBox_TextChanged);
			// 
			// SignUpForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(135)))), ((int)(((byte)(185)))));
			this.ClientSize = new System.Drawing.Size(1037, 540);
			this.Controls.Add(this.emailLabel);
			this.Controls.Add(this.confirmPasswordLabel);
			this.Controls.Add(this.genderLabel);
			this.Controls.Add(this.phoneNumberLabel);
			this.Controls.Add(this.ageLabel);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.firstNameLabel);
			this.Controls.Add(this.signUpButton);
			this.Controls.Add(this.phoneNumberBox);
			this.Controls.Add(this.ageBox);
			this.Controls.Add(this.genderBox);
			this.Controls.Add(this.emailBox);
			this.Controls.Add(this.confirmPasswordBox);
			this.Controls.Add(this.passwordBox);
			this.Controls.Add(this.userNameBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximumSize = new System.Drawing.Size(1059, 591);
			this.MinimumSize = new System.Drawing.Size(1059, 591);
			this.Name = "SignUpForm";
			this.Text = "SignUpForm";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox confirmPasswordBox;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.TextBox phoneNumberBox;
        private System.Windows.Forms.TextBox genderBox;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label genderLabel;
		private System.Windows.Forms.TextBox userNameBox;
	}
}