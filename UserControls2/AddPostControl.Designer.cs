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
            this.postButton = new System.Windows.Forms.Button();
            this.postTagsInput = new System.Windows.Forms.RichTextBox();
            this.postContentInput = new System.Windows.Forms.RichTextBox();
            this.postTitleInput = new System.Windows.Forms.RichTextBox();
            this.error = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(234)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.error);
            this.panel1.Controls.Add(this.postButton);
            this.panel1.Controls.Add(this.postTagsInput);
            this.panel1.Controls.Add(this.postContentInput);
            this.panel1.Controls.Add(this.postTitleInput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(120, 120);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.panel1.Size = new System.Drawing.Size(460, 330);
            this.panel1.TabIndex = 0;
            // 
            // postButton
            // 
            this.postButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.postButton.Location = new System.Drawing.Point(134, 237);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(166, 65);
            this.postButton.TabIndex = 7;
            this.postButton.Text = "Post";
            this.postButton.UseVisualStyleBackColor = false;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // postTagsInput
            // 
            this.postTagsInput.AcceptsTab = true;
            this.postTagsInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.postTagsInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.postTagsInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.postTagsInput.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Bold);
            this.postTagsInput.Location = new System.Drawing.Point(10, 179);
            this.postTagsInput.MaxLength = 1000;
            this.postTagsInput.Name = "postTagsInput";
            this.postTagsInput.Size = new System.Drawing.Size(440, 40);
            this.postTagsInput.TabIndex = 6;
            this.postTagsInput.Text = "Tags";
            this.postTagsInput.Click += new System.EventHandler(this.clearer);
            // 
            // postContentInput
            // 
            this.postContentInput.AcceptsTab = true;
            this.postContentInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.postContentInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.postContentInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.postContentInput.Font = new System.Drawing.Font("Monospac821 BT", 9.75F);
            this.postContentInput.Location = new System.Drawing.Point(10, 49);
            this.postContentInput.Name = "postContentInput";
            this.postContentInput.Size = new System.Drawing.Size(440, 130);
            this.postContentInput.TabIndex = 3;
            this.postContentInput.Text = "What are you thinking about?";
            this.postContentInput.Click += new System.EventHandler(this.clearer);
            // 
            // postTitleInput
            // 
            this.postTitleInput.AcceptsTab = true;
            this.postTitleInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.postTitleInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.postTitleInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.postTitleInput.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Bold);
            this.postTitleInput.Location = new System.Drawing.Point(10, 15);
            this.postTitleInput.MaxLength = 250;
            this.postTitleInput.Name = "postTitleInput";
            this.postTitleInput.Size = new System.Drawing.Size(440, 34);
            this.postTitleInput.TabIndex = 5;
            this.postTitleInput.Text = "Title";
            this.postTitleInput.Click += new System.EventHandler(this.clearer);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(131, 222);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(133, 13);
            this.error.TabIndex = 8;
            this.error.Text = "*One or more missing fields";
            this.error.Visible = false;
            // 
            // AddPostControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "AddPostControl";
            this.Padding = new System.Windows.Forms.Padding(120);
            this.Size = new System.Drawing.Size(700, 570);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.RichTextBox postTagsInput;
        private System.Windows.Forms.RichTextBox postContentInput;
        private System.Windows.Forms.RichTextBox postTitleInput;
        private System.Windows.Forms.Label error;
    }
}
