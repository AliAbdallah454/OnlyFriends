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
			this.emailLabel = new System.Windows.Forms.Label();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.confirmPasswordLabel = new System.Windows.Forms.Label();
			this.ageLabel = new System.Windows.Forms.Label();
			this.phoneNumberLabel = new System.Windows.Forms.Label();
			this.genderLabel = new System.Windows.Forms.Label();
			this.userNameBox = new System.Windows.Forms.TextBox();
			this.userNameLabel = new System.Windows.Forms.Label();
			this.signUpButton = new System.Windows.Forms.Button();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.genderList = new System.Windows.Forms.Panel();
			this.femaleButton = new System.Windows.Forms.Button();
			this.maleButton = new System.Windows.Forms.Button();
			this.genderListButton = new System.Windows.Forms.Button();
			this.genderList.SuspendLayout();
			this.SuspendLayout();
			// 
			// emailBox
			// 
			this.emailBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.emailBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailBox.Location = new System.Drawing.Point(363, 158);
			this.emailBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.emailBox.Name = "emailBox";
			this.emailBox.Size = new System.Drawing.Size(260, 26);
			this.emailBox.TabIndex = 2;
			this.emailBox.Text = "Email";
			this.emailBox.Enter += new System.EventHandler(this.emailBox_Enter);
			// 
			// passwordBox
			// 
			this.passwordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.passwordBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordBox.Location = new System.Drawing.Point(176, 234);
			this.passwordBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.Size = new System.Drawing.Size(260, 26);
			this.passwordBox.TabIndex = 3;
			this.passwordBox.Text = "Password";
			this.passwordBox.Enter += new System.EventHandler(this.passwordBox_Enter);
			// 
			// confirmPasswordBox
			// 
			this.confirmPasswordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.confirmPasswordBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.confirmPasswordBox.Location = new System.Drawing.Point(527, 234);
			this.confirmPasswordBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.confirmPasswordBox.Name = "confirmPasswordBox";
			this.confirmPasswordBox.Size = new System.Drawing.Size(260, 26);
			this.confirmPasswordBox.TabIndex = 4;
			this.confirmPasswordBox.Text = "Confirm Password";
			this.confirmPasswordBox.Enter += new System.EventHandler(this.confirmPasswordBox_Enter);
			// 
			// ageBox
			// 
			this.ageBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ageBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ageBox.Location = new System.Drawing.Point(183, 316);
			this.ageBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ageBox.Name = "ageBox";
			this.ageBox.Size = new System.Drawing.Size(113, 26);
			this.ageBox.TabIndex = 5;
			this.ageBox.Text = "Age";
			this.ageBox.Enter += new System.EventHandler(this.ageBox_Enter);
			this.ageBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ageBox_KeyPress);
			// 
			// phoneNumberBox
			// 
			this.phoneNumberBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.phoneNumberBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.phoneNumberBox.Location = new System.Drawing.Point(369, 316);
			this.phoneNumberBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.phoneNumberBox.Name = "phoneNumberBox";
			this.phoneNumberBox.Size = new System.Drawing.Size(216, 26);
			this.phoneNumberBox.TabIndex = 6;
			this.phoneNumberBox.Text = "Phone Number";
			this.phoneNumberBox.Enter += new System.EventHandler(this.phoneNumberBox_Enter);
			this.phoneNumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNumberBox_KeyPress);
			// 
			// emailLabel
			// 
			this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.emailLabel.AutoSize = true;
			this.emailLabel.BackColor = System.Drawing.Color.Transparent;
			this.emailLabel.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailLabel.ForeColor = System.Drawing.Color.Snow;
			this.emailLabel.Location = new System.Drawing.Point(456, 129);
			this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.Size = new System.Drawing.Size(64, 23);
			this.emailLabel.TabIndex = 3;
			this.emailLabel.Text = "Email";
			this.emailLabel.Visible = false;
			// 
			// passwordLabel
			// 
			this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
			this.passwordLabel.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordLabel.ForeColor = System.Drawing.Color.Snow;
			this.passwordLabel.Location = new System.Drawing.Point(171, 206);
			this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(102, 23);
			this.passwordLabel.TabIndex = 3;
			this.passwordLabel.Text = "Password";
			this.passwordLabel.Visible = false;
			// 
			// confirmPasswordLabel
			// 
			this.confirmPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.confirmPasswordLabel.AutoSize = true;
			this.confirmPasswordLabel.BackColor = System.Drawing.Color.Transparent;
			this.confirmPasswordLabel.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.confirmPasswordLabel.ForeColor = System.Drawing.Color.Snow;
			this.confirmPasswordLabel.Location = new System.Drawing.Point(521, 206);
			this.confirmPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.confirmPasswordLabel.Name = "confirmPasswordLabel";
			this.confirmPasswordLabel.Size = new System.Drawing.Size(183, 23);
			this.confirmPasswordLabel.TabIndex = 3;
			this.confirmPasswordLabel.Text = "Confirm Password";
			this.confirmPasswordLabel.Visible = false;
			// 
			// ageLabel
			// 
			this.ageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ageLabel.AutoSize = true;
			this.ageLabel.BackColor = System.Drawing.Color.Transparent;
			this.ageLabel.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ageLabel.ForeColor = System.Drawing.Color.Snow;
			this.ageLabel.Location = new System.Drawing.Point(185, 288);
			this.ageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.ageLabel.Name = "ageLabel";
			this.ageLabel.Size = new System.Drawing.Size(47, 23);
			this.ageLabel.TabIndex = 3;
			this.ageLabel.Text = "Age";
			this.ageLabel.Visible = false;
			// 
			// phoneNumberLabel
			// 
			this.phoneNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.phoneNumberLabel.AutoSize = true;
			this.phoneNumberLabel.BackColor = System.Drawing.Color.Transparent;
			this.phoneNumberLabel.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.phoneNumberLabel.ForeColor = System.Drawing.Color.Snow;
			this.phoneNumberLabel.Location = new System.Drawing.Point(408, 288);
			this.phoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.phoneNumberLabel.Name = "phoneNumberLabel";
			this.phoneNumberLabel.Size = new System.Drawing.Size(150, 23);
			this.phoneNumberLabel.TabIndex = 3;
			this.phoneNumberLabel.Text = "Phone Number";
			this.phoneNumberLabel.Visible = false;
			// 
			// genderLabel
			// 
			this.genderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.genderLabel.AutoSize = true;
			this.genderLabel.BackColor = System.Drawing.Color.Transparent;
			this.genderLabel.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.genderLabel.ForeColor = System.Drawing.Color.Snow;
			this.genderLabel.Location = new System.Drawing.Point(629, 288);
			this.genderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.genderLabel.Name = "genderLabel";
			this.genderLabel.Size = new System.Drawing.Size(79, 23);
			this.genderLabel.TabIndex = 3;
			this.genderLabel.Text = "Gender";
			this.genderLabel.Visible = false;
			// 
			// userNameBox
			// 
			this.userNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.userNameBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.userNameBox.Location = new System.Drawing.Point(363, 86);
			this.userNameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.userNameBox.Name = "userNameBox";
			this.userNameBox.Size = new System.Drawing.Size(260, 26);
			this.userNameBox.TabIndex = 1;
			this.userNameBox.Text = "User Name";
			this.userNameBox.Enter += new System.EventHandler(this.userNameBox_Enter);
			// 
			// userNameLabel
			// 
			this.userNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.userNameLabel.AutoSize = true;
			this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
			this.userNameLabel.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.userNameLabel.ForeColor = System.Drawing.Color.Snow;
			this.userNameLabel.Location = new System.Drawing.Point(436, 52);
			this.userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.userNameLabel.Name = "userNameLabel";
			this.userNameLabel.Size = new System.Drawing.Size(113, 23);
			this.userNameLabel.TabIndex = 3;
			this.userNameLabel.Text = "User Name";
			this.userNameLabel.Visible = false;
			// 
			// signUpButton
			// 
			this.signUpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.signUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
			this.signUpButton.FlatAppearance.BorderSize = 0;
			this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.signUpButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.signUpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(246)))));
			this.signUpButton.Image = global::OnlyFriends.Properties.Resources.icons8_sign_up_35;
			this.signUpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.signUpButton.Location = new System.Drawing.Point(389, 412);
			this.signUpButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.signUpButton.Name = "signUpButton";
			this.signUpButton.Size = new System.Drawing.Size(187, 68);
			this.signUpButton.TabIndex = 0;
			this.signUpButton.Text = "Sign Up";
			this.signUpButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.signUpButton.UseVisualStyleBackColor = false;
			this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel1.LinkColor = System.Drawing.Color.White;
			this.linkLabel1.Location = new System.Drawing.Point(423, 480);
			this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(95, 18);
			this.linkLabel1.TabIndex = 8;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Back to Login?";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// genderList
			// 
			this.genderList.Controls.Add(this.femaleButton);
			this.genderList.Controls.Add(this.maleButton);
			this.genderList.Controls.Add(this.genderListButton);
			this.genderList.Location = new System.Drawing.Point(625, 316);
			this.genderList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.genderList.Name = "genderList";
			this.genderList.Size = new System.Drawing.Size(156, 27);
			this.genderList.TabIndex = 9;
			// 
			// femaleButton
			// 
			this.femaleButton.BackColor = System.Drawing.SystemColors.Window;
			this.femaleButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.femaleButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.femaleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.femaleButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.femaleButton.Location = new System.Drawing.Point(0, 54);
			this.femaleButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.femaleButton.Name = "femaleButton";
			this.femaleButton.Size = new System.Drawing.Size(156, 27);
			this.femaleButton.TabIndex = 3;
			this.femaleButton.Text = "Female";
			this.femaleButton.UseVisualStyleBackColor = false;
			this.femaleButton.Click += new System.EventHandler(this.femaleButton_Click);
			// 
			// maleButton
			// 
			this.maleButton.BackColor = System.Drawing.SystemColors.Window;
			this.maleButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.maleButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.maleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.maleButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.maleButton.Location = new System.Drawing.Point(0, 27);
			this.maleButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.maleButton.Name = "maleButton";
			this.maleButton.Size = new System.Drawing.Size(156, 27);
			this.maleButton.TabIndex = 2;
			this.maleButton.Text = "Male";
			this.maleButton.UseVisualStyleBackColor = false;
			this.maleButton.Click += new System.EventHandler(this.maleButton_Click);
			// 
			// genderListButton
			// 
			this.genderListButton.BackColor = System.Drawing.SystemColors.Window;
			this.genderListButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.genderListButton.FlatAppearance.BorderSize = 0;
			this.genderListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.genderListButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.genderListButton.Location = new System.Drawing.Point(0, 0);
			this.genderListButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 6);
			this.genderListButton.Name = "genderListButton";
			this.genderListButton.Size = new System.Drawing.Size(156, 27);
			this.genderListButton.TabIndex = 1;
			this.genderListButton.Text = "Gender";
			this.genderListButton.UseVisualStyleBackColor = false;
			this.genderListButton.Click += new System.EventHandler(this.genderListButton_Click);
			// 
			// SignUpForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
			this.ClientSize = new System.Drawing.Size(1036, 538);
			this.Controls.Add(this.genderList);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.userNameLabel);
			this.Controls.Add(this.emailLabel);
			this.Controls.Add(this.confirmPasswordLabel);
			this.Controls.Add(this.genderLabel);
			this.Controls.Add(this.phoneNumberLabel);
			this.Controls.Add(this.ageLabel);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.signUpButton);
			this.Controls.Add(this.phoneNumberBox);
			this.Controls.Add(this.ageBox);
			this.Controls.Add(this.emailBox);
			this.Controls.Add(this.confirmPasswordBox);
			this.Controls.Add(this.passwordBox);
			this.Controls.Add(this.userNameBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximumSize = new System.Drawing.Size(1058, 589);
			this.MinimumSize = new System.Drawing.Size(1058, 589);
			this.Name = "SignUpForm";
			this.Text = "SignUpForm";
			this.genderList.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox confirmPasswordBox;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.TextBox phoneNumberBox;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label genderLabel;
		private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel genderList;
        private System.Windows.Forms.Button genderListButton;
        private System.Windows.Forms.Button femaleButton;
        private System.Windows.Forms.Button maleButton;
    }
}