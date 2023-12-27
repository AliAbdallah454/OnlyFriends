namespace OnlyFriends.Components {
    partial class CommentComp {
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
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.usernameLabel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeStampLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.contentLabel = new System.Windows.Forms.Label();
            this.removeCommentButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(200, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 35);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // userPicture
            // 
            this.userPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPicture.Image = global::OnlyFriends.Properties.Resources.icons8_male_user_25;
            this.userPicture.Location = new System.Drawing.Point(3, 3);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(29, 29);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPicture.TabIndex = 0;
            this.userPicture.TabStop = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameLabel.FlatAppearance.BorderSize = 0;
            this.usernameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usernameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panel1.Location = new System.Drawing.Point(533, 3);
            this.panel1.MaximumSize = new System.Drawing.Size(155, 35);
            this.panel1.MinimumSize = new System.Drawing.Size(155, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 35);
            this.panel1.TabIndex = 2;
            // 
            // timeStampLabel
            // 
            this.timeStampLabel.AutoSize = true;
            this.timeStampLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeStampLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.timeStampLabel.Location = new System.Drawing.Point(3, 8);
            this.timeStampLabel.Name = "timeStampLabel";
            this.timeStampLabel.Size = new System.Drawing.Size(67, 12);
            this.timeStampLabel.TabIndex = 0;
            this.timeStampLabel.Text = "TimeStamp";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.contentLabel);
            this.panel3.Location = new System.Drawing.Point(29, 38);
            this.panel3.MaximumSize = new System.Drawing.Size(635, 180);
            this.panel3.MinimumSize = new System.Drawing.Size(635, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(635, 64);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
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
            // removeCommentButton
            // 
            this.removeCommentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.removeCommentButton.FlatAppearance.BorderSize = 0;
            this.removeCommentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeCommentButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeCommentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(60)))), ((int)(((byte)(79)))));
            this.removeCommentButton.Image = global::OnlyFriends.Properties.Resources.icons8_remove_25;
            this.removeCommentButton.Location = new System.Drawing.Point(400, 3);
            this.removeCommentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeCommentButton.Name = "removeCommentButton";
            this.removeCommentButton.Size = new System.Drawing.Size(92, 30);
            this.removeCommentButton.TabIndex = 7;
            this.removeCommentButton.Text = "Remove";
            this.removeCommentButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeCommentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removeCommentButton.UseVisualStyleBackColor = false;
            this.removeCommentButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CommentComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.removeCommentButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 1, 1);
            this.MaximumSize = new System.Drawing.Size(690, 250);
            this.MinimumSize = new System.Drawing.Size(690, 105);
            this.Name = "CommentComp";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Size = new System.Drawing.Size(690, 133);
            this.Load += new System.EventHandler(this.CommentComp_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.Button usernameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label timeStampLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label contentLabel;
		private System.Windows.Forms.Button removeCommentButton;
	}
}
