﻿namespace OnlyFriends {
    partial class MHMDFormTest {
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
            this.likeButton = new System.Windows.Forms.Button();
            this.CommentBox = new System.Windows.Forms.TextBox();
            this.CommentBtn = new System.Windows.Forms.Button();
            this.RemoveCommentBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // likeButton
            // 
            this.likeButton.Location = new System.Drawing.Point(116, 201);
            this.likeButton.Name = "likeButton";
            this.likeButton.Size = new System.Drawing.Size(143, 100);
            this.likeButton.TabIndex = 0;
            this.likeButton.Text = "likePost";
            this.likeButton.UseVisualStyleBackColor = true;
            this.likeButton.Click += new System.EventHandler(this.likeButton_Click);
            // 
            // CommentBox
            // 
            this.CommentBox.Location = new System.Drawing.Point(516, 119);
            this.CommentBox.Multiline = true;
            this.CommentBox.Name = "CommentBox";
            this.CommentBox.Size = new System.Drawing.Size(209, 20);
            this.CommentBox.TabIndex = 1;
            // 
            // CommentBtn
            // 
            this.CommentBtn.Location = new System.Drawing.Point(542, 194);
            this.CommentBtn.Name = "CommentBtn";
            this.CommentBtn.Size = new System.Drawing.Size(167, 114);
            this.CommentBtn.TabIndex = 2;
            this.CommentBtn.Text = "Comment";
            this.CommentBtn.UseVisualStyleBackColor = true;
            this.CommentBtn.Click += new System.EventHandler(this.CommentBtn_Click);
            // 
            // RemoveCommentBtn
            // 
            this.RemoveCommentBtn.Location = new System.Drawing.Point(116, 35);
            this.RemoveCommentBtn.Name = "RemoveCommentBtn";
            this.RemoveCommentBtn.Size = new System.Drawing.Size(143, 104);
            this.RemoveCommentBtn.TabIndex = 3;
            this.RemoveCommentBtn.Text = "Remove Comment";
            this.RemoveCommentBtn.UseVisualStyleBackColor = true;
            this.RemoveCommentBtn.Click += new System.EventHandler(this.RemoveCommentBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitBtn.Location = new System.Drawing.Point(0, 427);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(800, 23);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // MHMDFormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.RemoveCommentBtn);
            this.Controls.Add(this.CommentBtn);
            this.Controls.Add(this.CommentBox);
            this.Controls.Add(this.likeButton);
            this.Name = "MHMDFormTest";
            this.Text = "MHMDFormTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button likeButton;
        private System.Windows.Forms.TextBox CommentBox;
        private System.Windows.Forms.Button CommentBtn;
        private System.Windows.Forms.Button RemoveCommentBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}