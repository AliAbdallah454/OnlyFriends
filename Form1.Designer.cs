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
            this.button2 = new System.Windows.Forms.Button();
            this.invalidEmaillbl = new System.Windows.Forms.Label();
            this.InvalidPasswordlbl = new System.Windows.Forms.Label();
            this.form2btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::OnlyFriends.Properties.Resources.onlyfans_logo_152221;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(268, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 260);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Username/Email";
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(218, 305);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(302, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Password";
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            // 
            // loginBTN
            // 
            this.loginBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBTN.Location = new System.Drawing.Point(268, 352);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(91, 36);
            this.loginBTN.TabIndex = 3;
            this.loginBTN.Text = "Login";
            this.loginBTN.UseVisualStyleBackColor = true;
            this.loginBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(385, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sign-up";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // invalidEmaillbl
            // 
            this.invalidEmaillbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invalidEmaillbl.AutoSize = true;
            this.invalidEmaillbl.BackColor = System.Drawing.Color.Transparent;
            this.invalidEmaillbl.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.invalidEmaillbl.Location = new System.Drawing.Point(215, 244);
            this.invalidEmaillbl.Name = "invalidEmaillbl";
            this.invalidEmaillbl.Size = new System.Drawing.Size(68, 13);
            this.invalidEmaillbl.TabIndex = 6;
            this.invalidEmaillbl.Text = "*invalid email";
            this.invalidEmaillbl.Visible = false;
            // 
            // InvalidPasswordlbl
            // 
            this.InvalidPasswordlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InvalidPasswordlbl.AutoSize = true;
            this.InvalidPasswordlbl.BackColor = System.Drawing.Color.Transparent;
            this.InvalidPasswordlbl.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.InvalidPasswordlbl.Location = new System.Drawing.Point(215, 289);
            this.InvalidPasswordlbl.Name = "InvalidPasswordlbl";
            this.InvalidPasswordlbl.Size = new System.Drawing.Size(89, 13);
            this.InvalidPasswordlbl.TabIndex = 7;
            this.InvalidPasswordlbl.Text = "*invalid password";
            this.InvalidPasswordlbl.Visible = false;
            // 
            // form2btn
            // 
            this.form2btn.Location = new System.Drawing.Point(557, 351);
            this.form2btn.Name = "form2btn";
            this.form2btn.Size = new System.Drawing.Size(86, 36);
            this.form2btn.TabIndex = 8;
            this.form2btn.Text = "form 2";
            this.form2btn.UseVisualStyleBackColor = true;
            this.form2btn.Click += new System.EventHandler(this.form2btn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::OnlyFriends.Properties.Resources.ripples_in_blank_black_6m97l43pauyhiw4e1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(719, 429);
            this.Controls.Add(this.form2btn);
            this.Controls.Add(this.InvalidPasswordlbl);
            this.Controls.Add(this.invalidEmaillbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.loginBTN);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(735, 449);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label invalidEmaillbl;
        private System.Windows.Forms.Label InvalidPasswordlbl;
        private System.Windows.Forms.Button form2btn;
    }
}

