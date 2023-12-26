namespace OnlyFriends.Components {
    partial class FriendRequestComponent {
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
            this.emailLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.usernameLabel = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.rejectButton = new System.Windows.Forms.Button();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(41, 38);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(44, 15);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "Email";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel1.Controls.Add(this.userPicture, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.usernameLabel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(9, 30, 9, 9);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(200, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 35);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameLabel.FlatAppearance.BorderSize = 0;
            this.usernameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usernameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.usernameLabel.Location = new System.Drawing.Point(38, 3);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(159, 29);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usernameLabel.UseVisualStyleBackColor = true;
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.Color.Gainsboro;
            this.acceptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptButton.FlatAppearance.BorderSize = 0;
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.acceptButton.Image = global::OnlyFriends.Properties.Resources.icons8_accept_30;
            this.acceptButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.acceptButton.Location = new System.Drawing.Point(377, 25);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(130, 45);
            this.acceptButton.TabIndex = 6;
            this.acceptButton.Text = "Accept";
            this.acceptButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // rejectButton
            // 
            this.rejectButton.BackColor = System.Drawing.Color.Gainsboro;
            this.rejectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rejectButton.FlatAppearance.BorderSize = 0;
            this.rejectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rejectButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rejectButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(60)))), ((int)(((byte)(79)))));
            this.rejectButton.Image = global::OnlyFriends.Properties.Resources.icons8_remove_30;
            this.rejectButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rejectButton.Location = new System.Drawing.Point(527, 25);
            this.rejectButton.Name = "rejectButton";
            this.rejectButton.Size = new System.Drawing.Size(130, 45);
            this.rejectButton.TabIndex = 6;
            this.rejectButton.Text = "Reject";
            this.rejectButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rejectButton.UseVisualStyleBackColor = false;
            this.rejectButton.Click += new System.EventHandler(this.rejectButton_Click);
            // 
            // userPicture
            // 
            this.userPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPicture.Image = global::OnlyFriends.Properties.Resources.icons8_male_user_35;
            this.userPicture.Location = new System.Drawing.Point(3, 3);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(29, 29);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPicture.TabIndex = 0;
            this.userPicture.TabStop = false;
            // 
            // FriendRequestComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.rejectButton);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(690, 90);
            this.MinimumSize = new System.Drawing.Size(690, 90);
            this.Name = "FriendRequestComponent";
            this.Size = new System.Drawing.Size(690, 90);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rejectButton;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.Button usernameLabel;
        private System.Windows.Forms.Button acceptButton;
    }
}
