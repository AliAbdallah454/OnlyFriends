﻿namespace OnlyFriends.User_Controls {
	partial class FriendRequestsUC {
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
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(82, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(122, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "FriendRequestsUC";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// FriendRequestsUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label2);
			this.Name = "FriendRequestsUC";
			this.Size = new System.Drawing.Size(628, 422);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
	}
}
