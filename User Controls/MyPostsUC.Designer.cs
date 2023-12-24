namespace OnlyFriends.User_Controls {
    partial class MyPostsUC {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPostsUC));
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.postInfo = new System.Windows.Forms.Panel();
			this.postDatePanel = new System.Windows.Forms.Panel();
			this.postDate = new System.Windows.Forms.Label();
			this.postUsernamePanel = new System.Windows.Forms.Panel();
			this.postUsernameLabel = new System.Windows.Forms.Label();
			this.postPfpUsername = new System.Windows.Forms.PictureBox();
			this.postContent = new System.Windows.Forms.Panel();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.postImage = new System.Windows.Forms.PictureBox();
			this.posttagsPanels = new System.Windows.Forms.Panel();
			this.hashtagsContentLabel = new System.Windows.Forms.Label();
			this.HashtagsLabel = new System.Windows.Forms.Label();
			this.postUsername2 = new System.Windows.Forms.Label();
			this.postText = new System.Windows.Forms.Label();
			this.postInteractions = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.shareBtn = new System.Windows.Forms.PictureBox();
			this.commentBtn = new System.Windows.Forms.PictureBox();
			this.likeBtn = new System.Windows.Forms.PictureBox();
			this.sharesLabel = new System.Windows.Forms.Label();
			this.commentsLabel = new System.Windows.Forms.Label();
			this.likesLabel = new System.Windows.Forms.Label();
			this.flowLayoutPanel1.SuspendLayout();
			this.postInfo.SuspendLayout();
			this.postDatePanel.SuspendLayout();
			this.postUsernamePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.postPfpUsername)).BeginInit();
			this.postContent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.postImage)).BeginInit();
			this.posttagsPanels.SuspendLayout();
			this.postInteractions.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.shareBtn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.commentBtn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.likeBtn)).BeginInit();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
			this.flowLayoutPanel1.Controls.Add(this.postInfo);
			this.flowLayoutPanel1.Controls.Add(this.postContent);
			this.flowLayoutPanel1.Controls.Add(this.postInteractions);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(800, 480);
			this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(800, 480);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 6, 20, 6);
			this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 480);
			this.flowLayoutPanel1.TabIndex = 4;
			// 
			// postInfo
			// 
			this.postInfo.BackColor = System.Drawing.Color.Transparent;
			this.postInfo.Controls.Add(this.postDatePanel);
			this.postInfo.Controls.Add(this.postUsernamePanel);
			this.postInfo.Dock = System.Windows.Forms.DockStyle.Top;
			this.postInfo.Location = new System.Drawing.Point(24, 10);
			this.postInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.postInfo.Name = "postInfo";
			this.postInfo.Size = new System.Drawing.Size(773, 37);
			this.postInfo.TabIndex = 0;
			// 
			// postDatePanel
			// 
			this.postDatePanel.Controls.Add(this.postDate);
			this.postDatePanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.postDatePanel.Location = new System.Drawing.Point(550, 0);
			this.postDatePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.postDatePanel.Name = "postDatePanel";
			this.postDatePanel.Size = new System.Drawing.Size(223, 37);
			this.postDatePanel.TabIndex = 2;
			// 
			// postDate
			// 
			this.postDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.postDate.AutoSize = true;
			this.postDate.Font = new System.Drawing.Font("Segoe UI Semibold", 7.75F, System.Drawing.FontStyle.Bold);
			this.postDate.ForeColor = System.Drawing.SystemColors.Desktop;
			this.postDate.Location = new System.Drawing.Point(4, 9);
			this.postDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.postDate.Name = "postDate";
			this.postDate.Size = new System.Drawing.Size(170, 17);
			this.postDate.TabIndex = 1;
			this.postDate.Text = "Posted at 14:32, 14/09/2024";
			this.postDate.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// postUsernamePanel
			// 
			this.postUsernamePanel.Controls.Add(this.postUsernameLabel);
			this.postUsernamePanel.Controls.Add(this.postPfpUsername);
			this.postUsernamePanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.postUsernamePanel.Location = new System.Drawing.Point(0, 0);
			this.postUsernamePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.postUsernamePanel.Name = "postUsernamePanel";
			this.postUsernamePanel.Size = new System.Drawing.Size(160, 37);
			this.postUsernamePanel.TabIndex = 0;
			// 
			// postUsernameLabel
			// 
			this.postUsernameLabel.AutoSize = true;
			this.postUsernameLabel.ForeColor = System.Drawing.Color.Red;
			this.postUsernameLabel.Location = new System.Drawing.Point(44, 9);
			this.postUsernameLabel.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
			this.postUsernameLabel.Name = "postUsernameLabel";
			this.postUsernameLabel.Size = new System.Drawing.Size(81, 16);
			this.postUsernameLabel.TabIndex = 1;
			this.postUsernameLabel.Text = "@username";
			// 
			// postPfpUsername
			// 
			this.postPfpUsername.Dock = System.Windows.Forms.DockStyle.Left;
			this.postPfpUsername.Image = global::OnlyFriends.Properties.Resources.Default_pfp_svg;
			this.postPfpUsername.Location = new System.Drawing.Point(0, 0);
			this.postPfpUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.postPfpUsername.Name = "postPfpUsername";
			this.postPfpUsername.Size = new System.Drawing.Size(40, 37);
			this.postPfpUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.postPfpUsername.TabIndex = 0;
			this.postPfpUsername.TabStop = false;
			// 
			// postContent
			// 
			this.postContent.Controls.Add(this.splitContainer2);
			this.postContent.Location = new System.Drawing.Point(24, 55);
			this.postContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.postContent.Name = "postContent";
			this.postContent.Size = new System.Drawing.Size(747, 357);
			this.postContent.TabIndex = 1;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.AccessibleName = "postImagePanel";
			this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Transparent;
			this.splitContainer2.Panel1.Controls.Add(this.postImage);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.AccessibleName = "postTextPanel";
			this.splitContainer2.Panel2.BackColor = System.Drawing.Color.Transparent;
			this.splitContainer2.Panel2.Controls.Add(this.posttagsPanels);
			this.splitContainer2.Panel2.Controls.Add(this.postUsername2);
			this.splitContainer2.Panel2.Controls.Add(this.postText);
			this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
			this.splitContainer2.Size = new System.Drawing.Size(747, 357);
			this.splitContainer2.SplitterDistance = 385;
			this.splitContainer2.SplitterWidth = 1;
			this.splitContainer2.TabIndex = 0;
			// 
			// postImage
			// 
			this.postImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.postImage.Image = global::OnlyFriends.Properties.Resources.pfp333;
			this.postImage.Location = new System.Drawing.Point(0, 0);
			this.postImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.postImage.Name = "postImage";
			this.postImage.Size = new System.Drawing.Size(385, 357);
			this.postImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.postImage.TabIndex = 1;
			this.postImage.TabStop = false;
			this.postImage.Click += new System.EventHandler(this.postImage_Click);
			// 
			// posttagsPanels
			// 
			this.posttagsPanels.Controls.Add(this.hashtagsContentLabel);
			this.posttagsPanels.Controls.Add(this.HashtagsLabel);
			this.posttagsPanels.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.posttagsPanels.Location = new System.Drawing.Point(0, 323);
			this.posttagsPanels.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.posttagsPanels.Name = "posttagsPanels";
			this.posttagsPanels.Size = new System.Drawing.Size(361, 22);
			this.posttagsPanels.TabIndex = 3;
			// 
			// hashtagsContentLabel
			// 
			this.hashtagsContentLabel.AutoSize = true;
			this.hashtagsContentLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hashtagsContentLabel.ForeColor = System.Drawing.Color.Peru;
			this.hashtagsContentLabel.Location = new System.Drawing.Point(103, 0);
			this.hashtagsContentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.hashtagsContentLabel.MaximumSize = new System.Drawing.Size(253, 18);
			this.hashtagsContentLabel.MinimumSize = new System.Drawing.Size(253, 18);
			this.hashtagsContentLabel.Name = "hashtagsContentLabel";
			this.hashtagsContentLabel.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
			this.hashtagsContentLabel.Size = new System.Drawing.Size(253, 18);
			this.hashtagsContentLabel.TabIndex = 1;
			this.hashtagsContentLabel.Text = "#summer #fun #cool #beach";
			this.hashtagsContentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// HashtagsLabel
			// 
			this.HashtagsLabel.AutoSize = true;
			this.HashtagsLabel.Dock = System.Windows.Forms.DockStyle.Left;
			this.HashtagsLabel.ForeColor = System.Drawing.Color.Peru;
			this.HashtagsLabel.Location = new System.Drawing.Point(0, 0);
			this.HashtagsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.HashtagsLabel.Name = "HashtagsLabel";
			this.HashtagsLabel.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
			this.HashtagsLabel.Size = new System.Drawing.Size(85, 16);
			this.HashtagsLabel.TabIndex = 0;
			this.HashtagsLabel.Text = "#Hashtags :";
			// 
			// postUsername2
			// 
			this.postUsername2.AutoSize = true;
			this.postUsername2.ForeColor = System.Drawing.Color.Red;
			this.postUsername2.Location = new System.Drawing.Point(3, 7);
			this.postUsername2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.postUsername2.Name = "postUsername2";
			this.postUsername2.Size = new System.Drawing.Size(81, 16);
			this.postUsername2.TabIndex = 2;
			this.postUsername2.Text = "@username";
			// 
			// postText
			// 
			this.postText.AutoSize = true;
			this.postText.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.postText.Location = new System.Drawing.Point(4, 28);
			this.postText.Margin = new System.Windows.Forms.Padding(13, 0, 4, 0);
			this.postText.MaximumSize = new System.Drawing.Size(340, 277);
			this.postText.Name = "postText";
			this.postText.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
			this.postText.Size = new System.Drawing.Size(334, 277);
			this.postText.TabIndex = 1;
			this.postText.Text = resources.GetString("postText.Text");
			this.postText.Click += new System.EventHandler(this.postText_Click);
			// 
			// postInteractions
			// 
			this.postInteractions.BackColor = System.Drawing.Color.Transparent;
			this.postInteractions.Controls.Add(this.tableLayoutPanel1);
			this.postInteractions.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.postInteractions.Location = new System.Drawing.Point(24, 420);
			this.postInteractions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.postInteractions.Name = "postInteractions";
			this.postInteractions.Size = new System.Drawing.Size(775, 31);
			this.postInteractions.TabIndex = 2;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Controls.Add(this.shareBtn, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.commentBtn, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.likeBtn, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.sharesLabel, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.commentsLabel, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.likesLabel, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(775, 31);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// shareBtn
			// 
			this.shareBtn.Dock = System.Windows.Forms.DockStyle.Left;
			this.shareBtn.Image = global::OnlyFriends.Properties.Resources.social;
			this.shareBtn.Location = new System.Drawing.Point(516, 0);
			this.shareBtn.Margin = new System.Windows.Forms.Padding(0);
			this.shareBtn.MaximumSize = new System.Drawing.Size(29, 27);
			this.shareBtn.MinimumSize = new System.Drawing.Size(29, 27);
			this.shareBtn.Name = "shareBtn";
			this.shareBtn.Size = new System.Drawing.Size(29, 27);
			this.shareBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.shareBtn.TabIndex = 2;
			this.shareBtn.TabStop = false;
			this.shareBtn.Click += new System.EventHandler(this.shareButton_Click);
			this.shareBtn.MouseEnter += new System.EventHandler(this.shareButton_MouseEnter);
			this.shareBtn.MouseLeave += new System.EventHandler(this.shareButton_MouseLeave);
			// 
			// commentBtn
			// 
			this.commentBtn.Dock = System.Windows.Forms.DockStyle.Left;
			this.commentBtn.Image = global::OnlyFriends.Properties.Resources.chat__bubble;
			this.commentBtn.Location = new System.Drawing.Point(258, 0);
			this.commentBtn.Margin = new System.Windows.Forms.Padding(0);
			this.commentBtn.MaximumSize = new System.Drawing.Size(29, 27);
			this.commentBtn.MinimumSize = new System.Drawing.Size(29, 27);
			this.commentBtn.Name = "commentBtn";
			this.commentBtn.Size = new System.Drawing.Size(29, 27);
			this.commentBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.commentBtn.TabIndex = 1;
			this.commentBtn.TabStop = false;
			this.commentBtn.Click += new System.EventHandler(this.commentButton_Click);
			this.commentBtn.MouseEnter += new System.EventHandler(this.commentButton_MouseEnter);
			this.commentBtn.MouseLeave += new System.EventHandler(this.commentButton_MouseLeave);
			// 
			// likeBtn
			// 
			this.likeBtn.Dock = System.Windows.Forms.DockStyle.Left;
			this.likeBtn.Image = global::OnlyFriends.Properties.Resources.heart__2_;
			this.likeBtn.Location = new System.Drawing.Point(0, 0);
			this.likeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.likeBtn.MaximumSize = new System.Drawing.Size(29, 27);
			this.likeBtn.MinimumSize = new System.Drawing.Size(29, 27);
			this.likeBtn.Name = "likeBtn";
			this.likeBtn.Size = new System.Drawing.Size(29, 27);
			this.likeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.likeBtn.TabIndex = 0;
			this.likeBtn.TabStop = false;
			this.likeBtn.Click += new System.EventHandler(this.likeButton_Click);
			this.likeBtn.MouseEnter += new System.EventHandler(this.likeButton_MouseEnter);
			this.likeBtn.MouseLeave += new System.EventHandler(this.likeButton_MouseLeave);
			// 
			// sharesLabel
			// 
			this.sharesLabel.AutoSize = true;
			this.sharesLabel.Dock = System.Windows.Forms.DockStyle.Left;
			this.sharesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 7.75F, System.Drawing.FontStyle.Bold);
			this.sharesLabel.Location = new System.Drawing.Point(520, 6);
			this.sharesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.sharesLabel.Name = "sharesLabel";
			this.sharesLabel.Size = new System.Drawing.Size(111, 25);
			this.sharesLabel.TabIndex = 3;
			this.sharesLabel.Text = "        Share (999) ";
			// 
			// commentsLabel
			// 
			this.commentsLabel.AutoSize = true;
			this.commentsLabel.Dock = System.Windows.Forms.DockStyle.Left;
			this.commentsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 7.75F, System.Drawing.FontStyle.Bold);
			this.commentsLabel.Location = new System.Drawing.Point(262, 6);
			this.commentsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.commentsLabel.Name = "commentsLabel";
			this.commentsLabel.Size = new System.Drawing.Size(137, 25);
			this.commentsLabel.TabIndex = 4;
			this.commentsLabel.Text = "        Comment (999) ";
			// 
			// likesLabel
			// 
			this.likesLabel.AutoSize = true;
			this.likesLabel.Dock = System.Windows.Forms.DockStyle.Left;
			this.likesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 7.75F, System.Drawing.FontStyle.Bold);
			this.likesLabel.Location = new System.Drawing.Point(4, 6);
			this.likesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.likesLabel.Name = "likesLabel";
			this.likesLabel.Size = new System.Drawing.Size(100, 25);
			this.likesLabel.TabIndex = 5;
			this.likesLabel.Text = "        Like (999) ";
			// 
			// MyPostsUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Controls.Add(this.flowLayoutPanel1);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "MyPostsUC";
			this.Size = new System.Drawing.Size(800, 480);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.postInfo.ResumeLayout(false);
			this.postDatePanel.ResumeLayout(false);
			this.postDatePanel.PerformLayout();
			this.postUsernamePanel.ResumeLayout(false);
			this.postUsernamePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.postPfpUsername)).EndInit();
			this.postContent.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.postImage)).EndInit();
			this.posttagsPanels.ResumeLayout(false);
			this.posttagsPanels.PerformLayout();
			this.postInteractions.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.shareBtn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.commentBtn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.likeBtn)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel postInfo;
        private System.Windows.Forms.Panel postDatePanel;
        private System.Windows.Forms.Label postDate;
        private System.Windows.Forms.Panel postUsernamePanel;
        private System.Windows.Forms.Label postUsernameLabel;
        private System.Windows.Forms.PictureBox postPfpUsername;
        private System.Windows.Forms.Panel postContent;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox postImage;
        private System.Windows.Forms.Panel posttagsPanels;
        private System.Windows.Forms.Label hashtagsContentLabel;
        private System.Windows.Forms.Label HashtagsLabel;
        private System.Windows.Forms.Label postUsername2;
        private System.Windows.Forms.Label postText;
        private System.Windows.Forms.Panel postInteractions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox shareBtn;
        private System.Windows.Forms.PictureBox commentBtn;
        private System.Windows.Forms.PictureBox likeBtn;
        private System.Windows.Forms.Label sharesLabel;
        private System.Windows.Forms.Label commentsLabel;
        private System.Windows.Forms.Label likesLabel;
    }
}
