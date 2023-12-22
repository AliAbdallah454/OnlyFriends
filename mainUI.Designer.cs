namespace OnlyFriends {
    partial class mainUI {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainUI));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.navBarTable = new System.Windows.Forms.TableLayoutPanel();
            this.HomeLabel = new System.Windows.Forms.Label();
            this.dmLabel = new System.Windows.Forms.Label();
            this.myPostLabel = new System.Windows.Forms.Label();
            this.reelsLabel = new System.Windows.Forms.Label();
            this.friendrequestLabel = new System.Windows.Forms.Label();
            this.likedPostsLabel = new System.Windows.Forms.Label();
            this.suggestionLabel = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.postInfo = new System.Windows.Forms.Panel();
            this.postContent = new System.Windows.Forms.Panel();
            this.postInteractions = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.settingsIcon = new System.Windows.Forms.PictureBox();
            this.suggestionsIcon = new System.Windows.Forms.PictureBox();
            this.likedPostsIcon = new System.Windows.Forms.PictureBox();
            this.requestIcon = new System.Windows.Forms.PictureBox();
            this.reelsIcon = new System.Windows.Forms.PictureBox();
            this.myPostsIcon = new System.Windows.Forms.PictureBox();
            this.dmIcon = new System.Windows.Forms.PictureBox();
            this.HomeIcon = new System.Windows.Forms.PictureBox();
            this.postImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.navBarTable.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.postContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suggestionsIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.likedPostsIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reelsIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPostsIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postImage)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.navBarTable);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.75F, System.Drawing.FontStyle.Bold);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.Controls.Add(this.Panel1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(15);
            this.splitContainer1.Size = new System.Drawing.Size(784, 451);
            this.splitContainer1.SplitterDistance = 130;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // navBarTable
            // 
            this.navBarTable.BackColor = System.Drawing.Color.Transparent;
            this.navBarTable.ColumnCount = 2;
            this.navBarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.navBarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.navBarTable.Controls.Add(this.settingsLabel, 1, 8);
            this.navBarTable.Controls.Add(this.settingsIcon, 0, 8);
            this.navBarTable.Controls.Add(this.suggestionLabel, 1, 7);
            this.navBarTable.Controls.Add(this.likedPostsLabel, 1, 6);
            this.navBarTable.Controls.Add(this.friendrequestLabel, 1, 5);
            this.navBarTable.Controls.Add(this.reelsLabel, 1, 4);
            this.navBarTable.Controls.Add(this.myPostLabel, 1, 3);
            this.navBarTable.Controls.Add(this.dmLabel, 1, 2);
            this.navBarTable.Controls.Add(this.suggestionsIcon, 0, 7);
            this.navBarTable.Controls.Add(this.likedPostsIcon, 0, 6);
            this.navBarTable.Controls.Add(this.requestIcon, 0, 5);
            this.navBarTable.Controls.Add(this.reelsIcon, 0, 4);
            this.navBarTable.Controls.Add(this.myPostsIcon, 0, 3);
            this.navBarTable.Controls.Add(this.dmIcon, 0, 2);
            this.navBarTable.Controls.Add(this.HomeIcon, 0, 1);
            this.navBarTable.Controls.Add(this.HomeLabel, 1, 1);
            this.navBarTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarTable.Location = new System.Drawing.Point(4, 4);
            this.navBarTable.Name = "navBarTable";
            this.navBarTable.RowCount = 10;
            this.navBarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.navBarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.navBarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.navBarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.navBarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.navBarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.navBarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.navBarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.navBarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.navBarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.navBarTable.Size = new System.Drawing.Size(122, 443);
            this.navBarTable.TabIndex = 0;
            // 
            // HomeLabel
            // 
            this.HomeLabel.AutoSize = true;
            this.HomeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.HomeLabel.ForeColor = System.Drawing.Color.Gray;
            this.HomeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeLabel.Location = new System.Drawing.Point(31, 71);
            this.HomeLabel.Margin = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(38, 25);
            this.HomeLabel.TabIndex = 17;
            this.HomeLabel.Tag = "";
            this.HomeLabel.Text = "Home";
            this.HomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HomeLabel.MouseEnter += new System.EventHandler(this.mouseEnter_Bold);
            this.HomeLabel.MouseLeave += new System.EventHandler(this.mouseLeave_Regular);
            // 
            // dmLabel
            // 
            this.dmLabel.AutoSize = true;
            this.dmLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dmLabel.ForeColor = System.Drawing.Color.Gray;
            this.dmLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dmLabel.Location = new System.Drawing.Point(31, 96);
            this.dmLabel.Margin = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.dmLabel.Name = "dmLabel";
            this.dmLabel.Size = new System.Drawing.Size(90, 25);
            this.dmLabel.TabIndex = 20;
            this.dmLabel.Tag = "";
            this.dmLabel.Text = "Direct Messages";
            this.dmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dmLabel.MouseEnter += new System.EventHandler(this.mouseEnter_Bold);
            this.dmLabel.MouseLeave += new System.EventHandler(this.mouseLeave_Regular);
            // 
            // myPostLabel
            // 
            this.myPostLabel.AutoSize = true;
            this.myPostLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.myPostLabel.ForeColor = System.Drawing.Color.Gray;
            this.myPostLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myPostLabel.Location = new System.Drawing.Point(31, 121);
            this.myPostLabel.Margin = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.myPostLabel.Name = "myPostLabel";
            this.myPostLabel.Size = new System.Drawing.Size(53, 25);
            this.myPostLabel.TabIndex = 21;
            this.myPostLabel.Tag = "";
            this.myPostLabel.Text = "My Posts";
            this.myPostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.myPostLabel.MouseEnter += new System.EventHandler(this.mouseEnter_Bold);
            this.myPostLabel.MouseLeave += new System.EventHandler(this.mouseLeave_Regular);
            // 
            // reelsLabel
            // 
            this.reelsLabel.AutoSize = true;
            this.reelsLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.reelsLabel.ForeColor = System.Drawing.Color.Gray;
            this.reelsLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reelsLabel.Location = new System.Drawing.Point(31, 146);
            this.reelsLabel.Margin = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.reelsLabel.Name = "reelsLabel";
            this.reelsLabel.Size = new System.Drawing.Size(34, 25);
            this.reelsLabel.TabIndex = 22;
            this.reelsLabel.Tag = "";
            this.reelsLabel.Text = "Reels";
            this.reelsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reelsLabel.MouseEnter += new System.EventHandler(this.mouseEnter_Bold);
            this.reelsLabel.MouseLeave += new System.EventHandler(this.mouseLeave_Regular);
            // 
            // friendrequestLabel
            // 
            this.friendrequestLabel.AutoSize = true;
            this.friendrequestLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.friendrequestLabel.ForeColor = System.Drawing.Color.Gray;
            this.friendrequestLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.friendrequestLabel.Location = new System.Drawing.Point(31, 171);
            this.friendrequestLabel.Margin = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.friendrequestLabel.Name = "friendrequestLabel";
            this.friendrequestLabel.Size = new System.Drawing.Size(83, 25);
            this.friendrequestLabel.TabIndex = 23;
            this.friendrequestLabel.Tag = "";
            this.friendrequestLabel.Text = "Friend Request";
            this.friendrequestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.friendrequestLabel.MouseEnter += new System.EventHandler(this.mouseEnter_Bold);
            this.friendrequestLabel.MouseLeave += new System.EventHandler(this.mouseLeave_Regular);
            // 
            // likedPostsLabel
            // 
            this.likedPostsLabel.AutoSize = true;
            this.likedPostsLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.likedPostsLabel.ForeColor = System.Drawing.Color.Gray;
            this.likedPostsLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.likedPostsLabel.Location = new System.Drawing.Point(31, 196);
            this.likedPostsLabel.Margin = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.likedPostsLabel.Name = "likedPostsLabel";
            this.likedPostsLabel.Size = new System.Drawing.Size(64, 25);
            this.likedPostsLabel.TabIndex = 24;
            this.likedPostsLabel.Tag = "";
            this.likedPostsLabel.Text = "Liked Posts";
            this.likedPostsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.likedPostsLabel.MouseEnter += new System.EventHandler(this.mouseEnter_Bold);
            this.likedPostsLabel.MouseLeave += new System.EventHandler(this.mouseLeave_Regular);
            // 
            // suggestionLabel
            // 
            this.suggestionLabel.AutoSize = true;
            this.suggestionLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.suggestionLabel.ForeColor = System.Drawing.Color.Gray;
            this.suggestionLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.suggestionLabel.Location = new System.Drawing.Point(31, 221);
            this.suggestionLabel.Margin = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.suggestionLabel.Name = "suggestionLabel";
            this.suggestionLabel.Size = new System.Drawing.Size(69, 25);
            this.suggestionLabel.TabIndex = 25;
            this.suggestionLabel.Tag = "";
            this.suggestionLabel.Text = "Suggestions";
            this.suggestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.suggestionLabel.MouseEnter += new System.EventHandler(this.mouseEnter_Bold);
            this.suggestionLabel.MouseLeave += new System.EventHandler(this.mouseLeave_Regular);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.Controls.Add(this.postInfo);
            this.Panel1.Controls.Add(this.postContent);
            this.Panel1.Controls.Add(this.postInteractions);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(15, 15);
            this.Panel1.Name = "Panel1";
            this.Panel1.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.Panel1.Size = new System.Drawing.Size(623, 421);
            this.Panel1.TabIndex = 0;
            // 
            // postInfo
            // 
            this.postInfo.BackColor = System.Drawing.Color.Transparent;
            this.postInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.postInfo.Location = new System.Drawing.Point(23, 18);
            this.postInfo.Name = "postInfo";
            this.postInfo.Size = new System.Drawing.Size(580, 30);
            this.postInfo.TabIndex = 0;
            // 
            // postContent
            // 
            this.postContent.Controls.Add(this.splitContainer2);
            this.postContent.Location = new System.Drawing.Point(23, 54);
            this.postContent.Name = "postContent";
            this.postContent.Size = new System.Drawing.Size(580, 326);
            this.postContent.TabIndex = 1;
            // 
            // postInteractions
            // 
            this.postInteractions.BackColor = System.Drawing.Color.Transparent;
            this.postInteractions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.postInteractions.Location = new System.Drawing.Point(23, 386);
            this.postInteractions.Name = "postInteractions";
            this.postInteractions.Size = new System.Drawing.Size(581, 25);
            this.postInteractions.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
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
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Size = new System.Drawing.Size(580, 326);
            this.splitContainer2.SplitterDistance = 326;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer2_SplitterMoved);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.MaximumSize = new System.Drawing.Size(220, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "change the program.cs ya ali abdalah ya hmar w helu";
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.settingsLabel.ForeColor = System.Drawing.Color.Gray;
            this.settingsLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsLabel.Location = new System.Drawing.Point(31, 246);
            this.settingsLabel.Margin = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(48, 25);
            this.settingsLabel.TabIndex = 31;
            this.settingsLabel.Tag = "";
            this.settingsLabel.Text = "Settings";
            this.settingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // settingsIcon
            // 
            this.settingsIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsIcon.Image = global::OnlyFriends.Properties.Resources.cogwheel;
            this.settingsIcon.Location = new System.Drawing.Point(2, 248);
            this.settingsIcon.Margin = new System.Windows.Forms.Padding(2);
            this.settingsIcon.Name = "settingsIcon";
            this.settingsIcon.Padding = new System.Windows.Forms.Padding(1);
            this.settingsIcon.Size = new System.Drawing.Size(20, 21);
            this.settingsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingsIcon.TabIndex = 28;
            this.settingsIcon.TabStop = false;
            // 
            // suggestionsIcon
            // 
            this.suggestionsIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suggestionsIcon.Image = global::OnlyFriends.Properties.Resources.tips;
            this.suggestionsIcon.Location = new System.Drawing.Point(2, 223);
            this.suggestionsIcon.Margin = new System.Windows.Forms.Padding(2);
            this.suggestionsIcon.Name = "suggestionsIcon";
            this.suggestionsIcon.Padding = new System.Windows.Forms.Padding(1);
            this.suggestionsIcon.Size = new System.Drawing.Size(20, 21);
            this.suggestionsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.suggestionsIcon.TabIndex = 16;
            this.suggestionsIcon.TabStop = false;
            // 
            // likedPostsIcon
            // 
            this.likedPostsIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.likedPostsIcon.Image = global::OnlyFriends.Properties.Resources.appwle;
            this.likedPostsIcon.Location = new System.Drawing.Point(2, 198);
            this.likedPostsIcon.Margin = new System.Windows.Forms.Padding(2);
            this.likedPostsIcon.Name = "likedPostsIcon";
            this.likedPostsIcon.Padding = new System.Windows.Forms.Padding(1);
            this.likedPostsIcon.Size = new System.Drawing.Size(20, 21);
            this.likedPostsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.likedPostsIcon.TabIndex = 14;
            this.likedPostsIcon.TabStop = false;
            // 
            // requestIcon
            // 
            this.requestIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestIcon.Image = global::OnlyFriends.Properties.Resources.apple__1_;
            this.requestIcon.Location = new System.Drawing.Point(2, 173);
            this.requestIcon.Margin = new System.Windows.Forms.Padding(2);
            this.requestIcon.Name = "requestIcon";
            this.requestIcon.Padding = new System.Windows.Forms.Padding(1);
            this.requestIcon.Size = new System.Drawing.Size(20, 21);
            this.requestIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.requestIcon.TabIndex = 12;
            this.requestIcon.TabStop = false;
            // 
            // reelsIcon
            // 
            this.reelsIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reelsIcon.Image = global::OnlyFriends.Properties.Resources.video;
            this.reelsIcon.Location = new System.Drawing.Point(2, 148);
            this.reelsIcon.Margin = new System.Windows.Forms.Padding(2);
            this.reelsIcon.Name = "reelsIcon";
            this.reelsIcon.Padding = new System.Windows.Forms.Padding(1);
            this.reelsIcon.Size = new System.Drawing.Size(20, 21);
            this.reelsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.reelsIcon.TabIndex = 10;
            this.reelsIcon.TabStop = false;
            // 
            // myPostsIcon
            // 
            this.myPostsIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myPostsIcon.Image = global::OnlyFriends.Properties.Resources.icons8_ios_photos_48;
            this.myPostsIcon.Location = new System.Drawing.Point(2, 123);
            this.myPostsIcon.Margin = new System.Windows.Forms.Padding(2);
            this.myPostsIcon.Name = "myPostsIcon";
            this.myPostsIcon.Padding = new System.Windows.Forms.Padding(1);
            this.myPostsIcon.Size = new System.Drawing.Size(20, 21);
            this.myPostsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.myPostsIcon.TabIndex = 8;
            this.myPostsIcon.TabStop = false;
            // 
            // dmIcon
            // 
            this.dmIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dmIcon.Image = global::OnlyFriends.Properties.Resources.message;
            this.dmIcon.Location = new System.Drawing.Point(2, 98);
            this.dmIcon.Margin = new System.Windows.Forms.Padding(2);
            this.dmIcon.Name = "dmIcon";
            this.dmIcon.Padding = new System.Windows.Forms.Padding(1);
            this.dmIcon.Size = new System.Drawing.Size(20, 21);
            this.dmIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dmIcon.TabIndex = 6;
            this.dmIcon.TabStop = false;
            // 
            // HomeIcon
            // 
            this.HomeIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeIcon.Image = global::OnlyFriends.Properties.Resources.apple;
            this.HomeIcon.Location = new System.Drawing.Point(2, 73);
            this.HomeIcon.Margin = new System.Windows.Forms.Padding(2);
            this.HomeIcon.Name = "HomeIcon";
            this.HomeIcon.Padding = new System.Windows.Forms.Padding(1);
            this.HomeIcon.Size = new System.Drawing.Size(20, 21);
            this.HomeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HomeIcon.TabIndex = 4;
            this.HomeIcon.TabStop = false;
            // 
            // postImage
            // 
            this.postImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postImage.Image = global::OnlyFriends.Properties.Resources.pfp333;
            this.postImage.Location = new System.Drawing.Point(0, 0);
            this.postImage.Name = "postImage";
            this.postImage.Size = new System.Drawing.Size(326, 326);
            this.postImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.postImage.TabIndex = 0;
            this.postImage.TabStop = false;
            // 
            // mainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 451);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.75F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(800, 490);
            this.MinimumSize = new System.Drawing.Size(800, 490);
            this.Name = "mainUI";
            this.Text = "Only Friends";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.navBarTable.ResumeLayout(false);
            this.navBarTable.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.postContent.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.settingsIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suggestionsIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.likedPostsIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reelsIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPostsIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel navBarTable;
        private System.Windows.Forms.PictureBox suggestionsIcon;
        private System.Windows.Forms.PictureBox likedPostsIcon;
        private System.Windows.Forms.PictureBox requestIcon;
        private System.Windows.Forms.PictureBox reelsIcon;
        private System.Windows.Forms.PictureBox myPostsIcon;
        private System.Windows.Forms.PictureBox dmIcon;
        private System.Windows.Forms.PictureBox HomeIcon;
        private System.Windows.Forms.Label HomeLabel;
        private System.Windows.Forms.Label suggestionLabel;
        private System.Windows.Forms.Label likedPostsLabel;
        private System.Windows.Forms.Label friendrequestLabel;
        private System.Windows.Forms.Label reelsLabel;
        private System.Windows.Forms.Label myPostLabel;
        private System.Windows.Forms.Label dmLabel;
        private System.Windows.Forms.FlowLayoutPanel Panel1;
        private System.Windows.Forms.Panel postInfo;
        private System.Windows.Forms.Panel postContent;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel postInteractions;
        private System.Windows.Forms.PictureBox postImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.PictureBox settingsIcon;
    }
}