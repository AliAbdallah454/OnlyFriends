namespace OnlyFriends {
    partial class Form2 {
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
			this.EXIT = new System.Windows.Forms.Button();
			this.removeFriendButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// EXIT
			// 
			this.EXIT.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.EXIT.Location = new System.Drawing.Point(0, 526);
			this.EXIT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.EXIT.Name = "EXIT";
			this.EXIT.Size = new System.Drawing.Size(1067, 28);
			this.EXIT.TabIndex = 0;
			this.EXIT.Text = "EXIT";
			this.EXIT.UseVisualStyleBackColor = true;
			this.EXIT.Click += new System.EventHandler(this.exit_Click);
			// 
			// removeFriendButton
			// 
			this.removeFriendButton.Location = new System.Drawing.Point(159, 186);
			this.removeFriendButton.Name = "removeFriendButton";
			this.removeFriendButton.Size = new System.Drawing.Size(149, 51);
			this.removeFriendButton.TabIndex = 1;
			this.removeFriendButton.Text = "removeFriend";
			this.removeFriendButton.UseVisualStyleBackColor = true;
			this.removeFriendButton.Click += new System.EventHandler(this.removeFriendButton_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.removeFriendButton);
			this.Controls.Add(this.EXIT);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form2";
			this.Text = "Form2";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EXIT;
		private System.Windows.Forms.Button removeFriendButton;
	}
}