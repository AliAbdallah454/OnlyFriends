namespace OnlyFriends {
    partial class PostCommentsForm {
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.addCommentBox = new System.Windows.Forms.TextBox();
            this.addCommentButton = new System.Windows.Forms.Button();
            this.commentsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tweetPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addCommentBox);
            this.panel2.Controls.Add(this.addCommentButton);
            this.panel2.Location = new System.Drawing.Point(13, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 50);
            this.panel2.TabIndex = 8;
            // 
            // addCommentBox
            // 
            this.addCommentBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addCommentBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCommentBox.Location = new System.Drawing.Point(119, 0);
            this.addCommentBox.MinimumSize = new System.Drawing.Size(400, 50);
            this.addCommentBox.Multiline = true;
            this.addCommentBox.Name = "addCommentBox";
            this.addCommentBox.Size = new System.Drawing.Size(442, 50);
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
            this.addCommentButton.Name = "addCommentButton";
            this.addCommentButton.Size = new System.Drawing.Size(119, 50);
            this.addCommentButton.TabIndex = 0;
            this.addCommentButton.Text = "Add Comment";
            this.addCommentButton.UseVisualStyleBackColor = false;
            this.addCommentButton.Click += new System.EventHandler(this.addCommentButton_Click);
            // 
            // commentsFlowPanel
            // 
            this.commentsFlowPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.commentsFlowPanel.Location = new System.Drawing.Point(0, 240);
            this.commentsFlowPanel.MinimumSize = new System.Drawing.Size(720, 330);
            this.commentsFlowPanel.Name = "commentsFlowPanel";
            this.commentsFlowPanel.Size = new System.Drawing.Size(720, 330);
            this.commentsFlowPanel.TabIndex = 7;
            // 
            // tweetPanel
            // 
            this.tweetPanel.Location = new System.Drawing.Point(13, 56);
            this.tweetPanel.MaximumSize = new System.Drawing.Size(690, 180);
            this.tweetPanel.Name = "tweetPanel";
            this.tweetPanel.Size = new System.Drawing.Size(690, 180);
            this.tweetPanel.TabIndex = 5;
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
            this.exitButton.Location = new System.Drawing.Point(580, 0);
            this.exitButton.MaximumSize = new System.Drawing.Size(140, 50);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(140, 50);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit Comments";
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // PostCommentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(720, 570);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.commentsFlowPanel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tweetPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(720, 570);
            this.MinimumSize = new System.Drawing.Size(720, 570);
            this.Name = "PostCommentsForm";
            this.Text = "PostCommentsForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox addCommentBox;
        private System.Windows.Forms.Button addCommentButton;
        private System.Windows.Forms.FlowLayoutPanel commentsFlowPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel tweetPanel;
    }
}