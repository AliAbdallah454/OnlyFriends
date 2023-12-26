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
            this.navPanel = new System.Windows.Forms.Panel();
            this.friendRequestsButton = new System.Windows.Forms.Button();
            this.myFriendsButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.likedPostsButton = new System.Windows.Forms.Button();
            this.addPostButton = new System.Windows.Forms.Button();
            this.myPostsButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.emailLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.navPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.navPanel.Controls.Add(this.friendRequestsButton);
            this.navPanel.Controls.Add(this.myFriendsButton);
            this.navPanel.Controls.Add(this.logoutButton);
            this.navPanel.Controls.Add(this.likedPostsButton);
            this.navPanel.Controls.Add(this.addPostButton);
            this.navPanel.Controls.Add(this.myPostsButton);
            this.navPanel.Controls.Add(this.homeButton);
            this.navPanel.Controls.Add(this.panel2);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navPanel.Location = new System.Drawing.Point(0, 0);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(184, 570);
            this.navPanel.TabIndex = 0;
            // 
            // friendRequestsButton
            // 
            this.friendRequestsButton.BackColor = System.Drawing.Color.Transparent;
            this.friendRequestsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.friendRequestsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.friendRequestsButton.FlatAppearance.BorderSize = 0;
            this.friendRequestsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.friendRequestsButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendRequestsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.friendRequestsButton.Image = global::OnlyFriends.Properties.Resources.icons8_github_25;
            this.friendRequestsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.friendRequestsButton.Location = new System.Drawing.Point(0, 394);
            this.friendRequestsButton.Name = "friendRequestsButton";
            this.friendRequestsButton.Size = new System.Drawing.Size(184, 41);
            this.friendRequestsButton.TabIndex = 7;
            this.friendRequestsButton.Text = "Friend Requests";
            this.friendRequestsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.friendRequestsButton.UseVisualStyleBackColor = false;
            this.friendRequestsButton.Click += new System.EventHandler(this.changePanel);
            this.friendRequestsButton.MouseEnter += new System.EventHandler(this.button_MouseEnter_Bold);
            this.friendRequestsButton.MouseLeave += new System.EventHandler(this.button_MouseLeave_Regular);
            // 
            // myFriendsButton
            // 
            this.myFriendsButton.BackColor = System.Drawing.Color.Transparent;
            this.myFriendsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myFriendsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.myFriendsButton.FlatAppearance.BorderSize = 0;
            this.myFriendsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myFriendsButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myFriendsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.myFriendsButton.Image = global::OnlyFriends.Properties.Resources.icons8_friends_25;
            this.myFriendsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.myFriendsButton.Location = new System.Drawing.Point(0, 353);
            this.myFriendsButton.Name = "myFriendsButton";
            this.myFriendsButton.Size = new System.Drawing.Size(184, 41);
            this.myFriendsButton.TabIndex = 6;
            this.myFriendsButton.Text = "My Friends";
            this.myFriendsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.myFriendsButton.UseVisualStyleBackColor = false;
            this.myFriendsButton.Click += new System.EventHandler(this.changePanel);
            this.myFriendsButton.MouseEnter += new System.EventHandler(this.button_MouseEnter_Bold);
            this.myFriendsButton.MouseLeave += new System.EventHandler(this.button_MouseLeave_Regular);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Transparent;
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.logoutButton.Image = global::OnlyFriends.Properties.Resources.icons8_logout_25__1_;
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutButton.Location = new System.Drawing.Point(0, 525);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(184, 45);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "Logout";
            this.logoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logOutButton_Click);
            this.logoutButton.MouseEnter += new System.EventHandler(this.button_MouseEnter_Bold);
            this.logoutButton.MouseLeave += new System.EventHandler(this.button_MouseLeave_Regular);
            // 
            // likedPostsButton
            // 
            this.likedPostsButton.BackColor = System.Drawing.Color.Transparent;
            this.likedPostsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.likedPostsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.likedPostsButton.FlatAppearance.BorderSize = 0;
            this.likedPostsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.likedPostsButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likedPostsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.likedPostsButton.Image = global::OnlyFriends.Properties.Resources.icons8_starred_webpage_25;
            this.likedPostsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.likedPostsButton.Location = new System.Drawing.Point(0, 312);
            this.likedPostsButton.Name = "likedPostsButton";
            this.likedPostsButton.Size = new System.Drawing.Size(184, 41);
            this.likedPostsButton.TabIndex = 4;
            this.likedPostsButton.Text = "Liked Posts";
            this.likedPostsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.likedPostsButton.UseVisualStyleBackColor = false;
            this.likedPostsButton.Click += new System.EventHandler(this.changePanel);
            this.likedPostsButton.MouseEnter += new System.EventHandler(this.button_MouseEnter_Bold);
            this.likedPostsButton.MouseLeave += new System.EventHandler(this.button_MouseLeave_Regular);
            // 
            // addPostButton
            // 
            this.addPostButton.BackColor = System.Drawing.Color.Transparent;
            this.addPostButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPostButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addPostButton.FlatAppearance.BorderSize = 0;
            this.addPostButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPostButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPostButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.addPostButton.Image = global::OnlyFriends.Properties.Resources.icons8_add_25;
            this.addPostButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addPostButton.Location = new System.Drawing.Point(0, 271);
            this.addPostButton.Name = "addPostButton";
            this.addPostButton.Size = new System.Drawing.Size(184, 41);
            this.addPostButton.TabIndex = 3;
            this.addPostButton.Text = "Add a Post";
            this.addPostButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.addPostButton.UseVisualStyleBackColor = false;
            this.addPostButton.Click += new System.EventHandler(this.changePanel);
            this.addPostButton.MouseEnter += new System.EventHandler(this.button_MouseEnter_Bold);
            this.addPostButton.MouseLeave += new System.EventHandler(this.button_MouseLeave_Regular);
            // 
            // myPostsButton
            // 
            this.myPostsButton.BackColor = System.Drawing.Color.Transparent;
            this.myPostsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myPostsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.myPostsButton.FlatAppearance.BorderSize = 0;
            this.myPostsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myPostsButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myPostsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.myPostsButton.Image = global::OnlyFriends.Properties.Resources.icons8_gallery_25;
            this.myPostsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.myPostsButton.Location = new System.Drawing.Point(0, 230);
            this.myPostsButton.Name = "myPostsButton";
            this.myPostsButton.Size = new System.Drawing.Size(184, 41);
            this.myPostsButton.TabIndex = 2;
            this.myPostsButton.Text = "My Posts";
            this.myPostsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.myPostsButton.UseVisualStyleBackColor = false;
            this.myPostsButton.Click += new System.EventHandler(this.changePanel);
            this.myPostsButton.MouseEnter += new System.EventHandler(this.button_MouseEnter_Bold);
            this.myPostsButton.MouseLeave += new System.EventHandler(this.button_MouseLeave_Regular);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Transparent;
            this.homeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.homeButton.Image = global::OnlyFriends.Properties.Resources.icons8_home_25;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homeButton.Location = new System.Drawing.Point(0, 189);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(184, 41);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "Home";
            this.homeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.changePanel);
            this.homeButton.MouseEnter += new System.EventHandler(this.button_MouseEnter_Bold);
            this.homeButton.MouseLeave += new System.EventHandler(this.button_MouseLeave_Regular);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.emailLabel);
            this.panel2.Controls.Add(this.usernameLabel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 189);
            this.panel2.TabIndex = 0;
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
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
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainPanel.Location = new System.Drawing.Point(193, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(10);
            this.mainPanel.MaximumSize = new System.Drawing.Size(700, 570);
            this.mainPanel.MinimumSize = new System.Drawing.Size(700, 570);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(700, 570);
            this.mainPanel.TabIndex = 1;
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(903, 570);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.navPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainApp";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainApp";
            this.navPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button likedPostsButton;
        private System.Windows.Forms.Button addPostButton;
        private System.Windows.Forms.Button myPostsButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button myFriendsButton;
        private System.Windows.Forms.Button friendRequestsButton;
        private System.Windows.Forms.Panel mainPanel;
    }
}