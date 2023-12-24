namespace OnlyFriends {
    partial class MainApp {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.friendRequestsButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.likedPostsButton = new System.Windows.Forms.Button();
            this.addPostButton = new System.Windows.Forms.Button();
            this.myPostsButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.friendRequestsButton);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.likedPostsButton);
            this.panel1.Controls.Add(this.addPostButton);
            this.panel1.Controls.Add(this.myPostsButton);
            this.panel1.Controls.Add(this.homeButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 570);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.emailLabel);
            this.panel2.Controls.Add(this.usernameLabel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 180);
            this.panel2.TabIndex = 0;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.usernameLabel.Location = new System.Drawing.Point(45, 130);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(87, 21);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.emailLabel.Location = new System.Drawing.Point(6, 151);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(36, 15);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "Email";
            // 
            // friendRequestsButton
            // 
            this.friendRequestsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.friendRequestsButton.FlatAppearance.BorderSize = 0;
            this.friendRequestsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.friendRequestsButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendRequestsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.friendRequestsButton.Image = global::OnlyFriends.Properties.Resources.icons8_github_25;
            this.friendRequestsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.friendRequestsButton.Location = new System.Drawing.Point(0, 360);
            this.friendRequestsButton.Name = "friendRequestsButton";
            this.friendRequestsButton.Size = new System.Drawing.Size(180, 45);
            this.friendRequestsButton.TabIndex = 6;
            this.friendRequestsButton.Text = "Friend Requests";
            this.friendRequestsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.friendRequestsButton.UseVisualStyleBackColor = true;
            this.friendRequestsButton.Click += new System.EventHandler(this.changePanel);
            this.friendRequestsButton.MouseEnter += new System.EventHandler(this.button_MouseEnter_Bold);
            this.friendRequestsButton.MouseLeave += new System.EventHandler(this.button_MouseLeave_Regular);
            // 
            // logoutButton
            // 
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.logoutButton.Image = global::OnlyFriends.Properties.Resources.icons8_logout_25__1_;
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutButton.Location = new System.Drawing.Point(0, 525);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(180, 45);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "Logout";
            this.logoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logOutButton_Click);
            this.logoutButton.MouseEnter += new System.EventHandler(this.button_MouseEnter_Bold);
            this.logoutButton.MouseLeave += new System.EventHandler(this.button_MouseLeave_Regular);
            // 
            // likedPostsButton
            // 
            this.likedPostsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.likedPostsButton.FlatAppearance.BorderSize = 0;
            this.likedPostsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.likedPostsButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likedPostsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.likedPostsButton.Image = global::OnlyFriends.Properties.Resources.icons8_starred_webpage_25;
            this.likedPostsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.likedPostsButton.Location = new System.Drawing.Point(0, 315);
            this.likedPostsButton.Name = "likedPostsButton";
            this.likedPostsButton.Size = new System.Drawing.Size(180, 45);
            this.likedPostsButton.TabIndex = 4;
            this.likedPostsButton.Text = "Liked Posts";
            this.likedPostsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.likedPostsButton.UseVisualStyleBackColor = true;
            this.likedPostsButton.Click += new System.EventHandler(this.changePanel);
            this.likedPostsButton.MouseEnter += new System.EventHandler(this.button_MouseEnter_Bold);
            this.likedPostsButton.MouseLeave += new System.EventHandler(this.button_MouseLeave_Regular);
            // 
            // addPostButton
            // 
            this.addPostButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addPostButton.FlatAppearance.BorderSize = 0;
            this.addPostButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPostButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPostButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.addPostButton.Image = global::OnlyFriends.Properties.Resources.icons8_add_25;
            this.addPostButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addPostButton.Location = new System.Drawing.Point(0, 270);
            this.addPostButton.Name = "addPostButton";
            this.addPostButton.Size = new System.Drawing.Size(180, 45);
            this.addPostButton.TabIndex = 3;
            this.addPostButton.Text = "Add a Post";
            this.addPostButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.addPostButton.UseVisualStyleBackColor = true;
            this.addPostButton.Click += new System.EventHandler(this.changePanel);
            this.addPostButton.MouseEnter += new System.EventHandler(this.button_MouseEnter_Bold);
            this.addPostButton.MouseLeave += new System.EventHandler(this.button_MouseLeave_Regular);
            // 
            // myPostsButton
            // 
            this.myPostsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.myPostsButton.FlatAppearance.BorderSize = 0;
            this.myPostsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myPostsButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myPostsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.myPostsButton.Image = global::OnlyFriends.Properties.Resources.icons8_gallery_25;
            this.myPostsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.myPostsButton.Location = new System.Drawing.Point(0, 225);
            this.myPostsButton.Name = "myPostsButton";
            this.myPostsButton.Size = new System.Drawing.Size(180, 45);
            this.myPostsButton.TabIndex = 2;
            this.myPostsButton.Text = "My Posts";
            this.myPostsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.myPostsButton.UseVisualStyleBackColor = true;
            this.myPostsButton.Click += new System.EventHandler(this.changePanel);
            this.myPostsButton.MouseEnter += new System.EventHandler(this.button_MouseEnter_Bold);
            this.myPostsButton.MouseLeave += new System.EventHandler(this.button_MouseLeave_Regular);
            // 
            // homeButton
            // 
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.homeButton.Image = global::OnlyFriends.Properties.Resources.icons8_home_25;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homeButton.Location = new System.Drawing.Point(0, 180);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(180, 45);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "Home";
            this.homeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.changePanel);
            this.homeButton.MouseEnter += new System.EventHandler(this.button_MouseEnter_Bold);
            this.homeButton.MouseLeave += new System.EventHandler(this.button_MouseLeave_Regular);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::OnlyFriends.Properties.Resources.icons8_male_user_100;
            this.pictureBox1.Location = new System.Drawing.Point(38, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(180, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(720, 570);
            this.mainPanel.TabIndex = 1;
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(900, 570);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainApp";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button likedPostsButton;
        private System.Windows.Forms.Button addPostButton;
        private System.Windows.Forms.Button myPostsButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button friendRequestsButton;
        private System.Windows.Forms.Panel mainPanel;
    }
}