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
            this.dataLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.contentLabel = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(9);
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
            this.panel1.Controls.Add(this.dataLabel);
            this.panel1.Location = new System.Drawing.Point(517, 3);
            this.panel1.MaximumSize = new System.Drawing.Size(200, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 35);
            this.panel1.TabIndex = 1;
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLabel.ForeColor = System.Drawing.Color.White;
            this.dataLabel.Location = new System.Drawing.Point(3, 8);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(81, 15);
            this.dataLabel.TabIndex = 0;
            this.dataLabel.Text = "TimeStamp";
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
            this.titleLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(52, 2);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(50, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.contentLabel);
            this.panel3.Location = new System.Drawing.Point(3, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(714, 93);
            this.panel3.TabIndex = 5;
            // 
            // contentLabel
            // 
            this.contentLabel.AutoSize = true;
            this.contentLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.contentLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentLabel.ForeColor = System.Drawing.Color.White;
            this.contentLabel.Location = new System.Drawing.Point(0, 0);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Size = new System.Drawing.Size(49, 15);
            this.contentLabel.TabIndex = 0;
            this.contentLabel.Text = "Content";
            // 
            // commentButton
            // 
            this.commentButton.FlatAppearance.BorderSize = 0;
            this.commentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commentButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentButton.ForeColor = System.Drawing.Color.White;
            this.commentButton.Image = global::OnlyFriends.Properties.Resources.icons8_chat_30__1_;
            this.commentButton.Location = new System.Drawing.Point(383, 146);
            this.commentButton.Name = "commentButton";
            this.commentButton.Size = new System.Drawing.Size(194, 44);
            this.commentButton.TabIndex = 4;
            this.commentButton.Text = "Comment";
            this.commentButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.commentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.commentButton.UseVisualStyleBackColor = true;
            // 
            // likeButton
            // 
            this.likeButton.FlatAppearance.BorderSize = 0;
            this.likeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.likeButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likeButton.ForeColor = System.Drawing.Color.White;
            this.likeButton.Image = global::OnlyFriends.Properties.Resources.icons8_like_30;
            this.likeButton.Location = new System.Drawing.Point(77, 146);
            this.likeButton.Name = "likeButton";
            this.likeButton.Size = new System.Drawing.Size(194, 44);
            this.likeButton.TabIndex = 4;
            this.likeButton.Text = "Like";
            this.likeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.likeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.likeButton.UseVisualStyleBackColor = true;
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.commentButton);
            this.Controls.Add(this.likeButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Tweet";
            this.Size = new System.Drawing.Size(720, 190);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.Button usernameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button likeButton;
        private System.Windows.Forms.Button commentButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label contentLabel;
    }
}
