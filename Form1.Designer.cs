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
			this.SuspendLayout();
			// 
			// submitButton
			// 
			this.submitButton.Location = new System.Drawing.Point(92, 213);
			this.submitButton.Name = "submitButton";
			this.submitButton.Size = new System.Drawing.Size(159, 74);
			this.submitButton.TabIndex = 0;
			this.submitButton.Text = "Click Me";
			this.submitButton.UseVisualStyleBackColor = true;
			this.submitButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// emailBox
			// 
			this.emailBox.Location = new System.Drawing.Point(44, 86);
			this.emailBox.Name = "emailBox";
			this.emailBox.Size = new System.Drawing.Size(237, 22);
			this.emailBox.TabIndex = 1;
			this.emailBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// passwordBox
			// 
			this.passwordBox.Location = new System.Drawing.Point(44, 140);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.Size = new System.Drawing.Size(237, 22);
			this.passwordBox.TabIndex = 2;
			this.passwordBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// titleBox
			// 
			this.titleBox.Location = new System.Drawing.Point(474, 86);
			this.titleBox.Name = "titleBox";
			this.titleBox.Size = new System.Drawing.Size(218, 22);
			this.titleBox.TabIndex = 3;
			// 
			// contentBox
			// 
			this.contentBox.Location = new System.Drawing.Point(474, 172);
			this.contentBox.Name = "contentBox";
			this.contentBox.Size = new System.Drawing.Size(218, 22);
			this.contentBox.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(519, 229);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(113, 58);
			this.button1.TabIndex = 5;
			this.button1.Text = "Post";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.contentBox);
			this.Controls.Add(this.titleBox);
			this.Controls.Add(this.passwordBox);
			this.Controls.Add(this.emailBox);
			this.Controls.Add(this.submitButton);
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
	}
}

