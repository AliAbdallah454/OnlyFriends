namespace OnlyFriends.User_Controls {
    partial class LikedPostsUC {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LikedPostsUC));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.postInfo = new System.Windows.Forms.Panel();
            this.postDatePanel = new System.Windows.Forms.Panel();
            this.postDate = new System.Windows.Forms.Label();
            this.postUsernamePanel = new System.Windows.Forms.Panel();
            this.postUsernameLabel = new System.Windows.Forms.Label();
            this.postContent = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.posttagsPanels = new System.Windows.Forms.Panel();
            this.hashtagsContentLabel = new System.Windows.Forms.Label();
            this.HashtagsLabel = new System.Windows.Forms.Label();
            this.postUsername2 = new System.Windows.Forms.Label();
            this.postText = new System.Windows.Forms.Label();
            this.postInteractions = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sharesLabel = new System.Windows.Forms.Label();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.likesLabel = new System.Windows.Forms.Label();
            this.postPfpUsername = new System.Windows.Forms.PictureBox();
            this.postImage = new System.Windows.Forms.PictureBox();
            this.shareBtn = new System.Windows.Forms.PictureBox();
            this.commentBtn = new System.Windows.Forms.PictureBox();
            this.likeBtn = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.postInfo.SuspendLayout();
            this.postDatePanel.SuspendLayout();
            this.postUsernamePanel.SuspendLayout();
            this.postContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.posttagsPanels.SuspendLayout();
            this.postInteractions.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postPfpUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postImage)).BeginInit();
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
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(600, 390);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(600, 390);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // postInfo
            // 
            this.postInfo.BackColor = System.Drawing.Color.Transparent;
            this.postInfo.Controls.Add(this.postDatePanel);
            this.postInfo.Controls.Add(this.postUsernamePanel);
            this.postInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.postInfo.Location = new System.Drawing.Point(18, 8);
            this.postInfo.Name = "postInfo";
            this.postInfo.Size = new System.Drawing.Size(580, 30);
            this.postInfo.TabIndex = 0;
            // 
            // postDatePanel
            // 
            this.postDatePanel.Controls.Add(this.postDate);
            this.postDatePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.postDatePanel.Location = new System.Drawing.Point(413, 0);
            this.postDatePanel.Name = "postDatePanel";
            this.postDatePanel.Size = new System.Drawing.Size(167, 30);
            this.postDatePanel.TabIndex = 2;
            // 
            // postDate
            // 
            this.postDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.postDate.AutoSize = true;
            this.postDate.Font = new System.Drawing.Font("Segoe UI Semibold", 7.75F, System.Drawing.FontStyle.Bold);
            this.postDate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.postDate.Location = new System.Drawing.Point(3, 7);
            this.postDate.Name = "postDate";
            this.postDate.Size = new System.Drawing.Size(145, 13);
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
            this.postUsernamePanel.Name = "postUsernamePanel";
            this.postUsernamePanel.Size = new System.Drawing.Size(120, 30);
            this.postUsernamePanel.TabIndex = 0;
            // 
            // postUsernameLabel
            // 
            this.postUsernameLabel.AutoSize = true;
            this.postUsernameLabel.ForeColor = System.Drawing.Color.Red;
            this.postUsernameLabel.Location = new System.Drawing.Point(33, 7);
            this.postUsernameLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.postUsernameLabel.Name = "postUsernameLabel";
            this.postUsernameLabel.Size = new System.Drawing.Size(64, 13);
            this.postUsernameLabel.TabIndex = 1;
            this.postUsernameLabel.Text = "@username";
            // 
            // postContent
            // 
            this.postContent.Controls.Add(this.splitContainer2);
            this.postContent.Location = new System.Drawing.Point(18, 44);
            this.postContent.Name = "postContent";
            this.postContent.Size = new System.Drawing.Size(560, 290);
            this.postContent.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
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
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.splitContainer2.Size = new System.Drawing.Size(560, 290);
            this.splitContainer2.SplitterDistance = 289;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            // 
            // posttagsPanels
            // 
            this.posttagsPanels.Controls.Add(this.hashtagsContentLabel);
            this.posttagsPanels.Controls.Add(this.HashtagsLabel);
            this.posttagsPanels.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.posttagsPanels.Location = new System.Drawing.Point(0, 262);
            this.posttagsPanels.Name = "posttagsPanels";
            this.posttagsPanels.Size = new System.Drawing.Size(270, 18);
            this.posttagsPanels.TabIndex = 3;
            // 
            // hashtagsContentLabel
            // 
            this.hashtagsContentLabel.AutoSize = true;
            this.hashtagsContentLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hashtagsContentLabel.ForeColor = System.Drawing.Color.Peru;
            this.hashtagsContentLabel.Location = new System.Drawing.Point(77, 0);
            this.hashtagsContentLabel.MaximumSize = new System.Drawing.Size(190, 15);
            this.hashtagsContentLabel.MinimumSize = new System.Drawing.Size(190, 15);
            this.hashtagsContentLabel.Name = "hashtagsContentLabel";
            this.hashtagsContentLabel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.hashtagsContentLabel.Size = new System.Drawing.Size(190, 15);
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
            this.HashtagsLabel.Name = "HashtagsLabel";
            this.HashtagsLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.HashtagsLabel.Size = new System.Drawing.Size(70, 13);
            this.HashtagsLabel.TabIndex = 0;
            this.HashtagsLabel.Text = "#Hashtags :";
            // 
            // postUsername2
            // 
            this.postUsername2.AutoSize = true;
            this.postUsername2.ForeColor = System.Drawing.Color.Red;
            this.postUsername2.Location = new System.Drawing.Point(2, 6);
            this.postUsername2.Name = "postUsername2";
            this.postUsername2.Size = new System.Drawing.Size(64, 13);
            this.postUsername2.TabIndex = 2;
            this.postUsername2.Text = "@username";
            // 
            // postText
            // 
            this.postText.AutoSize = true;
            this.postText.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postText.Location = new System.Drawing.Point(3, 23);
            this.postText.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.postText.MaximumSize = new System.Drawing.Size(255, 225);
            this.postText.Name = "postText";
            this.postText.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.postText.Size = new System.Drawing.Size(250, 225);
            this.postText.TabIndex = 1;
            this.postText.Text = resources.GetString("postText.Text");
            // 
            // postInteractions
            // 
            this.postInteractions.BackColor = System.Drawing.Color.Transparent;
            this.postInteractions.Controls.Add(this.tableLayoutPanel1);
            this.postInteractions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.postInteractions.Location = new System.Drawing.Point(18, 340);
            this.postInteractions.Name = "postInteractions";
            this.postInteractions.Size = new System.Drawing.Size(581, 25);
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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(581, 25);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // sharesLabel
            // 
            this.sharesLabel.AutoSize = true;
            this.sharesLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sharesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 7.75F, System.Drawing.FontStyle.Bold);
            this.sharesLabel.Location = new System.Drawing.Point(389, 5);
            this.sharesLabel.Name = "sharesLabel";
            this.sharesLabel.Size = new System.Drawing.Size(91, 20);
            this.sharesLabel.TabIndex = 3;
            this.sharesLabel.Text = "        Share (999) ";
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.commentsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 7.75F, System.Drawing.FontStyle.Bold);
            this.commentsLabel.Location = new System.Drawing.Point(196, 5);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(113, 20);
            this.commentsLabel.TabIndex = 4;
            this.commentsLabel.Text = "        Comment (999) ";
            // 
            // likesLabel
            // 
            this.likesLabel.AutoSize = true;
            this.likesLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.likesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 7.75F, System.Drawing.FontStyle.Bold);
            this.likesLabel.Location = new System.Drawing.Point(3, 5);
            this.likesLabel.Name = "likesLabel";
            this.likesLabel.Size = new System.Drawing.Size(83, 20);
            this.likesLabel.TabIndex = 5;
            this.likesLabel.Text = "        Like (999) ";
            // 
            // postPfpUsername
            // 
            this.postPfpUsername.Dock = System.Windows.Forms.DockStyle.Left;
            this.postPfpUsername.Image = global::OnlyFriends.Properties.Resources.Default_pfp_svg;
            this.postPfpUsername.Location = new System.Drawing.Point(0, 0);
            this.postPfpUsername.Name = "postPfpUsername";
            this.postPfpUsername.Size = new System.Drawing.Size(30, 30);
            this.postPfpUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.postPfpUsername.TabIndex = 0;
            this.postPfpUsername.TabStop = false;
            // 
            // postImage
            // 
            this.postImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postImage.Image = global::OnlyFriends.Properties.Resources.pfp333;
            this.postImage.Location = new System.Drawing.Point(0, 0);
            this.postImage.Name = "postImage";
            this.postImage.Size = new System.Drawing.Size(289, 290);
            this.postImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.postImage.TabIndex = 1;
            this.postImage.TabStop = false;
            // 
            // shareBtn
            // 
            this.shareBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.shareBtn.Image = global::OnlyFriends.Properties.Resources.social;
            this.shareBtn.Location = new System.Drawing.Point(386, 0);
            this.shareBtn.Margin = new System.Windows.Forms.Padding(0);
            this.shareBtn.MaximumSize = new System.Drawing.Size(22, 22);
            this.shareBtn.MinimumSize = new System.Drawing.Size(22, 22);
            this.shareBtn.Name = "shareBtn";
            this.shareBtn.Size = new System.Drawing.Size(22, 22);
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
            this.commentBtn.Location = new System.Drawing.Point(193, 0);
            this.commentBtn.Margin = new System.Windows.Forms.Padding(0);
            this.commentBtn.MaximumSize = new System.Drawing.Size(22, 22);
            this.commentBtn.MinimumSize = new System.Drawing.Size(22, 22);
            this.commentBtn.Name = "commentBtn";
            this.commentBtn.Size = new System.Drawing.Size(22, 22);
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
            this.likeBtn.MaximumSize = new System.Drawing.Size(22, 22);
            this.likeBtn.MinimumSize = new System.Drawing.Size(22, 22);
            this.likeBtn.Name = "likeBtn";
            this.likeBtn.Size = new System.Drawing.Size(22, 22);
            this.likeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.likeBtn.TabIndex = 0;
            this.likeBtn.TabStop = false;
            this.likeBtn.Click += new System.EventHandler(this.likeButton_Click);
            this.likeBtn.MouseEnter += new System.EventHandler(this.likeButton_MouseEnter);
            this.likeBtn.MouseLeave += new System.EventHandler(this.likeButton_MouseLeave);
            // 
            // LikedPostsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "LikedPostsUC";
            this.Size = new System.Drawing.Size(605, 394);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.postInfo.ResumeLayout(false);
            this.postDatePanel.ResumeLayout(false);
            this.postDatePanel.PerformLayout();
            this.postUsernamePanel.ResumeLayout(false);
            this.postUsernamePanel.PerformLayout();
            this.postContent.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.posttagsPanels.ResumeLayout(false);
            this.posttagsPanels.PerformLayout();
            this.postInteractions.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postPfpUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postImage)).EndInit();
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
