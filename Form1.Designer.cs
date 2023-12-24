namespace OnlyFriends {
	partial class Login {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.loginBTN = new System.Windows.Forms.Button();
            this.invalidEmaillbl = new System.Windows.Forms.Label();
            this.InvalidPasswordlbl = new System.Windows.Forms.Label();
            this.createAccountLink = new System.Windows.Forms.LinkLabel();
            this.forgotPasswordLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::OnlyFriends.Properties.Resources.onlyfans_logo_152221;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(299, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(249, 261);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Email";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(249, 306);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(302, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Password";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            // 
            // loginBTN
            // 
            this.loginBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginBTN.Enabled = false;
            this.loginBTN.Location = new System.Drawing.Point(352, 352);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(91, 51);
            this.loginBTN.TabIndex = 0;
            this.loginBTN.Text = "Login";
            this.loginBTN.UseVisualStyleBackColor = true;
            this.loginBTN.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // invalidEmaillbl
            // 
            this.invalidEmaillbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.invalidEmaillbl.AutoSize = true;
            this.invalidEmaillbl.BackColor = System.Drawing.Color.Transparent;
            this.invalidEmaillbl.ForeColor = System.Drawing.Color.Red;
            this.invalidEmaillbl.Location = new System.Drawing.Point(246, 245);
            this.invalidEmaillbl.Name = "invalidEmaillbl";
            this.invalidEmaillbl.Size = new System.Drawing.Size(70, 13);
            this.invalidEmaillbl.TabIndex = 0;
            this.invalidEmaillbl.Text = "*Invalid Email";
            this.invalidEmaillbl.Visible = false;
            // 
            // InvalidPasswordlbl
            // 
            this.InvalidPasswordlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InvalidPasswordlbl.AutoSize = true;
            this.InvalidPasswordlbl.BackColor = System.Drawing.Color.Transparent;
            this.InvalidPasswordlbl.ForeColor = System.Drawing.Color.Red;
            this.InvalidPasswordlbl.Location = new System.Drawing.Point(246, 290);
            this.InvalidPasswordlbl.Name = "InvalidPasswordlbl";
            this.InvalidPasswordlbl.Size = new System.Drawing.Size(91, 13);
            this.InvalidPasswordlbl.TabIndex = 7;
            this.InvalidPasswordlbl.Text = "*Invalid Password";
            this.InvalidPasswordlbl.Visible = false;
            // 
            // createAccountLink
            // 
            this.createAccountLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createAccountLink.AutoSize = true;
            this.createAccountLink.BackColor = System.Drawing.Color.Transparent;
            this.createAccountLink.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountLink.LinkColor = System.Drawing.Color.White;
            this.createAccountLink.Location = new System.Drawing.Point(441, 329);
            this.createAccountLink.Name = "createAccountLink";
            this.createAccountLink.Size = new System.Drawing.Size(110, 14);
            this.createAccountLink.TabIndex = 0;
            this.createAccountLink.TabStop = true;
            this.createAccountLink.Text = "Create an Account?";
            this.createAccountLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createAccountLink_LinkClicked);
            // 
            // forgotPasswordLink
            // 
            this.forgotPasswordLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.forgotPasswordLink.AutoSize = true;
            this.forgotPasswordLink.BackColor = System.Drawing.Color.Transparent;
            this.forgotPasswordLink.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPasswordLink.LinkColor = System.Drawing.Color.White;
            this.forgotPasswordLink.Location = new System.Drawing.Point(246, 329);
            this.forgotPasswordLink.Name = "forgotPasswordLink";
            this.forgotPasswordLink.Size = new System.Drawing.Size(102, 14);
            this.forgotPasswordLink.TabIndex = 11;
            this.forgotPasswordLink.TabStop = true;
            this.forgotPasswordLink.Text = "Forgot Password?";
            this.forgotPasswordLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPasswordLink_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::OnlyFriends.Properties.Resources.ripples_in_blank_black_6m97l43pauyhiw4e1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 447);
            this.Controls.Add(this.forgotPasswordLink);
            this.Controls.Add(this.createAccountLink);
            this.Controls.Add(this.InvalidPasswordlbl);
            this.Controls.Add(this.invalidEmaillbl);
            this.Controls.Add(this.loginBTN);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(800, 490);
            this.MinimumSize = new System.Drawing.Size(800, 490);
            this.Name = "Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Login";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.RosyBrown;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button loginBTN;
        private System.Windows.Forms.Label invalidEmaillbl;
        private System.Windows.Forms.Label InvalidPasswordlbl;
        private System.Windows.Forms.LinkLabel createAccountLink;
        private System.Windows.Forms.LinkLabel forgotPasswordLink;
    }
}

