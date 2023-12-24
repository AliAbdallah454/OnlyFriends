namespace OnlyFriends {
	partial class listItem {
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
			this.textLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textLabel
			// 
			this.textLabel.AutoSize = true;
			this.textLabel.Location = new System.Drawing.Point(266, 50);
			this.textLabel.Name = "textLabel";
			this.textLabel.Size = new System.Drawing.Size(17, 16);
			this.textLabel.TabIndex = 0;
			this.textLabel.Text = "hi";
			this.textLabel.Click += new System.EventHandler(this.label1_Click);
			// 
			// listItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.textLabel);
			this.Name = "listItem";
			this.Size = new System.Drawing.Size(640, 150);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label textLabel;
	}
}
