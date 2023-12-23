namespace OnlyFriends {
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
            this.signUpBtn = new System.Windows.Forms.Button();
            this.logInBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // likeButton
            // 
            this.likeButton.Location = new System.Drawing.Point(645, 146);
            this.likeButton.Name = "likeButton";
            this.likeButton.Size = new System.Drawing.Size(143, 100);
            this.likeButton.TabIndex = 0;
            this.likeButton.Text = "likePost";
            this.likeButton.UseVisualStyleBackColor = true;
            this.likeButton.Click += new System.EventHandler(this.likeButton_Click);
            // 
            // CommentBox
            // 
            this.CommentBox.Location = new System.Drawing.Point(591, 281);
            this.CommentBox.Multiline = true;
            this.CommentBox.Name = "CommentBox";
            this.CommentBox.Size = new System.Drawing.Size(209, 20);
            this.CommentBox.TabIndex = 1;
            // 
            // CommentBtn
            // 
            this.CommentBtn.Location = new System.Drawing.Point(621, 307);
            this.CommentBtn.Name = "CommentBtn";
            this.CommentBtn.Size = new System.Drawing.Size(167, 114);
            this.CommentBtn.TabIndex = 2;
            this.CommentBtn.Text = "Comment";
            this.CommentBtn.UseVisualStyleBackColor = true;
            this.CommentBtn.Click += new System.EventHandler(this.CommentBtn_Click);
            // 
            // RemoveCommentBtn
            // 
            this.RemoveCommentBtn.Location = new System.Drawing.Point(645, 12);
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
            // signUpBtn
            // 
            this.signUpBtn.Location = new System.Drawing.Point(45, 77);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(203, 137);
            this.signUpBtn.TabIndex = 5;
            this.signUpBtn.Text = "SignUp";
            this.signUpBtn.UseVisualStyleBackColor = true;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // logInBtn
            // 
            this.logInBtn.Location = new System.Drawing.Point(45, 236);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(203, 151);
            this.logInBtn.TabIndex = 6;
            this.logInBtn.Text = "LogIn";
            this.logInBtn.UseVisualStyleBackColor = true;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(290, 77);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(171, 137);
            this.logOutBtn.TabIndex = 7;
            this.logOutBtn.Text = "LogOut";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 69);
            this.button1.TabIndex = 3;
            this.button1.Tag = "8";
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MHMDFormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.signUpBtn);
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
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.Button logInBtn;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button button1;
    }
}