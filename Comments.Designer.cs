namespace OnlyFriends {
    partial class Comments {
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
			this.tweetPanel = new System.Windows.Forms.Panel();
			this.commentsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.exitButton = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.addCommentBox = new System.Windows.Forms.TextBox();
			this.addCommentButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.commentNumberLabel = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tweetPanel
			// 
			this.tweetPanel.AutoSize = true;
			this.tweetPanel.Location = new System.Drawing.Point(17, 69);
			this.tweetPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tweetPanel.MaximumSize = new System.Drawing.Size(920, 172);
			this.tweetPanel.MinimumSize = new System.Drawing.Size(920, 172);
			this.tweetPanel.Name = "tweetPanel";
			this.tweetPanel.Size = new System.Drawing.Size(920, 172);
			this.tweetPanel.TabIndex = 1;
			// 
			// commentsFlowPanel
			// 
			this.commentsFlowPanel.AutoScroll = true;
			this.commentsFlowPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.commentsFlowPanel.Location = new System.Drawing.Point(0, 284);
			this.commentsFlowPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.commentsFlowPanel.MinimumSize = new System.Drawing.Size(960, 406);
			this.commentsFlowPanel.Name = "commentsFlowPanel";
			this.commentsFlowPanel.Size = new System.Drawing.Size(960, 418);
			this.commentsFlowPanel.TabIndex = 3;
			// 
			// exitButton
			// 
			this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
			this.exitButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.exitButton.FlatAppearance.BorderSize = 0;
			this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exitButton.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
			this.exitButton.Image = global::OnlyFriends.Properties.Resources.icons8_exit_30;
			this.exitButton.Location = new System.Drawing.Point(773, 0);
			this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.exitButton.MaximumSize = new System.Drawing.Size(187, 62);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(187, 62);
			this.exitButton.TabIndex = 2;
			this.exitButton.Text = "Exit Comments";
			this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.exitButton.UseVisualStyleBackColor = false;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.addCommentBox);
			this.panel2.Controls.Add(this.addCommentButton);
			this.panel2.Location = new System.Drawing.Point(17, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(748, 62);
			this.panel2.TabIndex = 4;
			// 
			// addCommentBox
			// 
			this.addCommentBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.addCommentBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addCommentBox.Location = new System.Drawing.Point(159, 0);
			this.addCommentBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.addCommentBox.MinimumSize = new System.Drawing.Size(532, 61);
			this.addCommentBox.Multiline = true;
			this.addCommentBox.Name = "addCommentBox";
			this.addCommentBox.Size = new System.Drawing.Size(589, 62);
			this.addCommentBox.TabIndex = 1;
			this.addCommentBox.TabStop = false;
			this.addCommentBox.Text = "add comment....";
			this.addCommentBox.Enter += new System.EventHandler(this.addCommentBox_Enter);
			this.addCommentBox.Leave += new System.EventHandler(this.addCommentBox_Leave);
			// 
			// addCommentButton
			// 
			this.addCommentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
			this.addCommentButton.Dock = System.Windows.Forms.DockStyle.Left;
			this.addCommentButton.FlatAppearance.BorderSize = 0;
			this.addCommentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addCommentButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addCommentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
			this.addCommentButton.Location = new System.Drawing.Point(0, 0);
			this.addCommentButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.addCommentButton.Name = "addCommentButton";
			this.addCommentButton.Size = new System.Drawing.Size(159, 62);
			this.addCommentButton.TabIndex = 0;
			this.addCommentButton.Text = "Add Comment";
			this.addCommentButton.UseVisualStyleBackColor = false;
			this.addCommentButton.Click += new System.EventHandler(this.addCommentButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
			this.label1.Location = new System.Drawing.Point(11, 249);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 32);
			this.label1.TabIndex = 5;
			this.label1.Text = "Comments";
			// 
			// commentNumberLabel
			// 
			this.commentNumberLabel.AutoSize = true;
			this.commentNumberLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.commentNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
			this.commentNumberLabel.Location = new System.Drawing.Point(145, 249);
			this.commentNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.commentNumberLabel.Name = "commentNumberLabel";
			this.commentNumberLabel.Size = new System.Drawing.Size(28, 32);
			this.commentNumberLabel.TabIndex = 5;
			this.commentNumberLabel.Text = "0";
			// 
			// Comments
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
			this.ClientSize = new System.Drawing.Size(960, 702);
			this.Controls.Add(this.commentNumberLabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.commentsFlowPanel);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.tweetPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximumSize = new System.Drawing.Size(960, 702);
			this.MinimumSize = new System.Drawing.Size(960, 702);
			this.Name = "Comments";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Comments";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel tweetPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.FlowLayoutPanel commentsFlowPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addCommentButton;
        private System.Windows.Forms.TextBox addCommentBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label commentNumberLabel;
    }
}