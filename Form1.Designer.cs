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
			this.SuspendLayout();
			// 
			// submitButton
			// 
			this.submitButton.Location = new System.Drawing.Point(301, 218);
			this.submitButton.Name = "submitButton";
			this.submitButton.Size = new System.Drawing.Size(159, 74);
			this.submitButton.TabIndex = 0;
			this.submitButton.Text = "Click Me";
			this.submitButton.UseVisualStyleBackColor = true;
			this.submitButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// emailBox
			// 
			this.emailBox.Location = new System.Drawing.Point(253, 91);
			this.emailBox.Name = "emailBox";
			this.emailBox.Size = new System.Drawing.Size(237, 22);
			this.emailBox.TabIndex = 1;
			this.emailBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// passwordBox
			// 
			this.passwordBox.Location = new System.Drawing.Point(253, 145);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.Size = new System.Drawing.Size(237, 22);
			this.passwordBox.TabIndex = 2;
			this.passwordBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
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
	}
}

