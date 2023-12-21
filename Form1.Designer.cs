namespace OnlyFriends {
	partial class Form1 {
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
            this.submitButton = new System.Windows.Forms.Button();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.contentBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Form2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(69, 173);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(119, 60);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Click Me";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(33, 70);
            this.emailBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(179, 20);
            this.emailBox.TabIndex = 1;
            this.emailBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(33, 114);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(179, 20);
            this.passwordBox.TabIndex = 2;
            this.passwordBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(356, 70);
            this.titleBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(164, 20);
            this.titleBox.TabIndex = 3;
            // 
            // contentBox
            // 
            this.contentBox.Location = new System.Drawing.Point(356, 140);
            this.contentBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contentBox.Name = "contentBox";
            this.contentBox.Size = new System.Drawing.Size(164, 20);
            this.contentBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 186);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Post";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.Form2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Form2.Location = new System.Drawing.Point(0, 343);
            this.Form2.Name = "Form2";
            this.Form2.Size = new System.Drawing.Size(600, 23);
            this.Form2.TabIndex = 6;
            this.Form2.Text = "Form2";
            this.Form2.UseVisualStyleBackColor = true;
            this.Form2.Click += new System.EventHandler(this.form2Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Form2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.contentBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.submitButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button submitButton;
		private System.Windows.Forms.TextBox emailBox;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.TextBox titleBox;
		private System.Windows.Forms.TextBox contentBox;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Form2;
    }
}

