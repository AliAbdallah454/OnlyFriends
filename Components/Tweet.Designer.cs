namespace OnlyFriends.Components {
    partial class Tweet {
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.usernameLabel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeStampLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.contentLabel = new System.Windows.Forms.Label();
            this.likeNumberLabel = new System.Windows.Forms.Label();
            this.commentNumberLabel = new System.Windows.Forms.Label();
            this.commentButton = new System.Windows.Forms.Button();
            this.likeButton = new System.Windows.Forms.Button();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel1.Controls.Add(this.userPicture, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.usernameLabel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(200, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 35);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameLabel.FlatAppearance.BorderSize = 0;
            this.usernameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usernameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.usernameLabel.Location = new System.Drawing.Point(38, 3);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(159, 29);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usernameLabel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.timeStampLabel);
            this.panel1.Location = new System.Drawing.Point(512, 3);
            this.panel1.MaximumSize = new System.Drawing.Size(200, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 35);
            this.panel1.TabIndex = 1;
            // 
            // timeStampLabel
            // 
            this.timeStampLabel.AutoSize = true;
            this.timeStampLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeStampLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.timeStampLabel.Location = new System.Drawing.Point(3, 8);
            this.timeStampLabel.Name = "timeStampLabel";
            this.timeStampLabel.Size = new System.Drawing.Size(81, 15);
            this.timeStampLabel.TabIndex = 0;
            this.timeStampLabel.Text = "TimeStamp";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.titleLabel);
            this.panel2.Location = new System.Drawing.Point(263, 11);
            this.panel2.MaximumSize = new System.Drawing.Size(250, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 40);
            this.panel2.TabIndex = 2;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.titleLabel.Location = new System.Drawing.Point(23, 2);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(46, 23);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.contentLabel);
            this.panel3.Location = new System.Drawing.Point(22, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(630, 82);
            this.panel3.TabIndex = 5;
            // 
            // contentLabel
            // 
            this.contentLabel.AutoSize = true;
            this.contentLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.contentLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.contentLabel.Location = new System.Drawing.Point(0, 0);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Size = new System.Drawing.Size(49, 15);
            this.contentLabel.TabIndex = 0;
            this.contentLabel.Text = "Content";
            // 
            // likeNumberLabel
            // 
            this.likeNumberLabel.AutoSize = true;
            this.likeNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likeNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.likeNumberLabel.Location = new System.Drawing.Point(221, 151);
            this.likeNumberLabel.Name = "likeNumberLabel";
            this.likeNumberLabel.Size = new System.Drawing.Size(25, 16);
            this.likeNumberLabel.TabIndex = 6;
            this.likeNumberLabel.Text = "(0)";
            // 
            // commentNumberLabel
            // 
            this.commentNumberLabel.AutoSize = true;
            this.commentNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.commentNumberLabel.Location = new System.Drawing.Point(552, 151);
            this.commentNumberLabel.Name = "commentNumberLabel";
            this.commentNumberLabel.Size = new System.Drawing.Size(25, 16);
            this.commentNumberLabel.TabIndex = 6;
            this.commentNumberLabel.Text = "(0)";
            // 
            // commentButton
            // 
            this.commentButton.FlatAppearance.BorderSize = 0;
            this.commentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commentButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.commentButton.Image = global::OnlyFriends.Properties.Resources.icons8_chat_30__2_;
            this.commentButton.Location = new System.Drawing.Point(383, 135);
            this.commentButton.Name = "commentButton";
            this.commentButton.Size = new System.Drawing.Size(194, 45);
            this.commentButton.TabIndex = 4;
            this.commentButton.Text = "Comment";
            this.commentButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.commentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.commentButton.UseVisualStyleBackColor = true;
            this.commentButton.Click += new System.EventHandler(this.commentButton_Click);
            // 
            // likeButton
            // 
            this.likeButton.FlatAppearance.BorderSize = 0;
            this.likeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.likeButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.likeButton.Image = global::OnlyFriends.Properties.Resources.icons8_like_30__2_;
            this.likeButton.Location = new System.Drawing.Point(77, 135);
            this.likeButton.Name = "likeButton";
            this.likeButton.Size = new System.Drawing.Size(194, 45);
            this.likeButton.TabIndex = 4;
            this.likeButton.Text = "Like";
            this.likeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.likeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.likeButton.UseVisualStyleBackColor = true;
            this.likeButton.Click += new System.EventHandler(this.likeButton_Click);
            // 
            // userPicture
            // 
            this.userPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPicture.Image = global::OnlyFriends.Properties.Resources.icons8_male_user_35;
            this.userPicture.Location = new System.Drawing.Point(3, 3);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(29, 29);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPicture.TabIndex = 0;
            this.userPicture.TabStop = false;
            // 
            // Tweet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.commentNumberLabel);
            this.Controls.Add(this.likeNumberLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.commentButton);
            this.Controls.Add(this.likeButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.Name = "Tweet";
            this.Size = new System.Drawing.Size(690, 180);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.Button usernameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label timeStampLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button likeButton;
        private System.Windows.Forms.Button commentButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label contentLabel;
        private System.Windows.Forms.Label likeNumberLabel;
        private System.Windows.Forms.Label commentNumberLabel;
    }
}
