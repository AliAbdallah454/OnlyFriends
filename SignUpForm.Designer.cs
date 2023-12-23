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
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.phoneNumberBox = new System.Windows.Forms.TextBox();
            this.genderBox = new System.Windows.Forms.TextBox();
            this.signUpButton = new System.Windows.Forms.Button();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNameBox
            // 
            this.firstNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstNameBox.Location = new System.Drawing.Point(132, 81);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(196, 20);
            this.firstNameBox.TabIndex = 0;
            this.firstNameBox.TabStop = false;
            this.firstNameBox.Text = "First Name";
            this.firstNameBox.Enter += new System.EventHandler(this.firstNameBox_Enter);
            // 
            // lastNameBox
            // 
            this.lastNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastNameBox.Location = new System.Drawing.Point(395, 81);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(196, 20);
            this.lastNameBox.TabIndex = 0;
            this.lastNameBox.TabStop = false;
            this.lastNameBox.Text = "Last Name";
            this.lastNameBox.Enter += new System.EventHandler(this.lastNameBox_Enter);
            // 
            // emailBox
            // 
            this.emailBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailBox.Location = new System.Drawing.Point(272, 141);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(196, 20);
            this.emailBox.TabIndex = 0;
            this.emailBox.TabStop = false;
            this.emailBox.Text = "Email";
            this.emailBox.Enter += new System.EventHandler(this.emailBox_Enter);
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordBox.Location = new System.Drawing.Point(132, 200);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(196, 20);
            this.passwordBox.TabIndex = 0;
            this.passwordBox.TabStop = false;
            this.passwordBox.Text = "Password";
            this.passwordBox.Enter += new System.EventHandler(this.passwordBox_Enter);
            // 
            // confirmPasswordBox
            // 
            this.confirmPasswordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmPasswordBox.Location = new System.Drawing.Point(395, 200);
            this.confirmPasswordBox.Name = "confirmPasswordBox";
            this.confirmPasswordBox.Size = new System.Drawing.Size(196, 20);
            this.confirmPasswordBox.TabIndex = 0;
            this.confirmPasswordBox.TabStop = false;
            this.confirmPasswordBox.Text = "Confirm Password";
            this.confirmPasswordBox.Enter += new System.EventHandler(this.confirmPasswordBox_Enter);
            // 
            // ageBox
            // 
            this.ageBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ageBox.Location = new System.Drawing.Point(132, 262);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(86, 20);
            this.ageBox.TabIndex = 1;
            this.ageBox.TabStop = false;
            this.ageBox.Text = "Age";
            this.ageBox.Enter += new System.EventHandler(this.ageBox_Enter);
            this.ageBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ageBox_KeyPress);
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneNumberBox.Location = new System.Drawing.Point(272, 262);
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(163, 20);
            this.phoneNumberBox.TabIndex = 1;
            this.phoneNumberBox.TabStop = false;
            this.phoneNumberBox.Text = "Phone Number";
            this.phoneNumberBox.Enter += new System.EventHandler(this.phoneNumberBox_Enter);
            this.phoneNumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNumberBox_KeyPress);
            // 
            // genderBox
            // 
            this.genderBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.genderBox.Location = new System.Drawing.Point(474, 262);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(117, 20);
            this.genderBox.TabIndex = 0;
            this.genderBox.TabStop = false;
            this.genderBox.Text = "Gender";
            this.genderBox.Enter += new System.EventHandler(this.genderBox_Enter);
            // 
            // signUpButton
            // 
            this.signUpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signUpButton.Location = new System.Drawing.Point(292, 335);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(143, 52);
            this.signUpButton.TabIndex = 2;
            this.signUpButton.TabStop = false;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(128, 58);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(71, 16);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.Visible = false;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(391, 58);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(70, 16);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name";
            this.lastNameLabel.Visible = false;
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(342, 118);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(40, 16);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email";
            this.emailLabel.Visible = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(128, 177);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(63, 16);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.Visible = false;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordLabel.Location = new System.Drawing.Point(391, 177);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(112, 16);
            this.confirmPasswordLabel.TabIndex = 3;
            this.confirmPasswordLabel.Text = "Confirm Password";
            this.confirmPasswordLabel.Visible = false;
            // 
            // ageLabel
            // 
            this.ageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.Location = new System.Drawing.Point(128, 239);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(30, 16);
            this.ageLabel.TabIndex = 3;
            this.ageLabel.Text = "Age";
            this.ageLabel.Visible = false;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel.Location = new System.Drawing.Point(301, 239);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(94, 16);
            this.phoneNumberLabel.TabIndex = 3;
            this.phoneNumberLabel.Text = "Phone Number";
            this.phoneNumberLabel.Visible = false;
            // 
            // genderLabel
            // 
            this.genderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(470, 239);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(49, 16);
            this.genderLabel.TabIndex = 3;
            this.genderLabel.Text = "Gender";
            this.genderLabel.Visible = false;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 451);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.phoneNumberBox);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.confirmPasswordBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(800, 490);
            this.MinimumSize = new System.Drawing.Size(800, 490);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox confirmPasswordBox;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.TextBox phoneNumberBox;
        private System.Windows.Forms.TextBox genderBox;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label genderLabel;
    }
}