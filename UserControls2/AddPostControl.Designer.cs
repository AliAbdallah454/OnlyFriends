namespace OnlyFriends.UserControls2 {
    partial class AddPostControl {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.postContentInput = new System.Windows.Forms.RichTextBox();
            this.postButton = new System.Windows.Forms.Button();
            this.postTitleInput = new System.Windows.Forms.RichTextBox();
            this.postTagsInput = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.postTagsInput);
            this.panel1.Controls.Add(this.postTitleInput);
            this.panel1.Controls.Add(this.postButton);
            this.panel1.Controls.Add(this.postContentInput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(130, 130);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(440, 310);
            this.panel1.TabIndex = 0;
            // 
            // postContentInput
            // 
            this.postContentInput.BackColor = System.Drawing.SystemColors.Info;
            this.postContentInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.postContentInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.postContentInput.Location = new System.Drawing.Point(10, 10);
            this.postContentInput.Name = "postContentInput";
            this.postContentInput.Size = new System.Drawing.Size(416, 134);
            this.postContentInput.TabIndex = 0;
            this.postContentInput.Text = "Post Here!";
            // 
            // postButton
            // 
            this.postButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.postButton.BackColor = System.Drawing.Color.DarkGray;
            this.postButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.postButton.Location = new System.Drawing.Point(135, 245);
            this.postButton.Margin = new System.Windows.Forms.Padding(0);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(141, 51);
            this.postButton.TabIndex = 1;
            this.postButton.Text = "Post";
            this.postButton.UseVisualStyleBackColor = false;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // postTitleInput
            // 
            this.postTitleInput.BackColor = System.Drawing.SystemColors.Info;
            this.postTitleInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.postTitleInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.postTitleInput.Location = new System.Drawing.Point(10, 144);
            this.postTitleInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.postTitleInput.Name = "postTitleInput";
            this.postTitleInput.Size = new System.Drawing.Size(416, 34);
            this.postTitleInput.TabIndex = 2;
            this.postTitleInput.Text = "Insert Title";
            // 
            // postTagsInput
            // 
            this.postTagsInput.BackColor = System.Drawing.SystemColors.Info;
            this.postTagsInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.postTagsInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.postTagsInput.Location = new System.Drawing.Point(10, 178);
            this.postTagsInput.Name = "postTagsInput";
            this.postTagsInput.Size = new System.Drawing.Size(416, 32);
            this.postTagsInput.TabIndex = 3;
            this.postTagsInput.Text = "Hashtags:";
            // 
            // AddPostControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "AddPostControl";
            this.Padding = new System.Windows.Forms.Padding(130);
            this.Size = new System.Drawing.Size(700, 570);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox postContentInput;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.RichTextBox postTagsInput;
        private System.Windows.Forms.RichTextBox postTitleInput;
    }
}
