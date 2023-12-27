namespace OnlyFriends.UserControls2 {
    partial class FriendRequestsControl {
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
            this.contentFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonsTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.findFriendButton = new System.Windows.Forms.Button();
            this.suggestedFriendButton = new System.Windows.Forms.Button();
            this.buttonsTablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentFlowLayoutPanel
            // 
            this.contentFlowLayoutPanel.AutoScroll = true;
            this.contentFlowLayoutPanel.Location = new System.Drawing.Point(13, 53);
            this.contentFlowLayoutPanel.MaximumSize = new System.Drawing.Size(720, 1000);
            this.contentFlowLayoutPanel.Name = "contentFlowLayoutPanel";
            this.contentFlowLayoutPanel.Size = new System.Drawing.Size(720, 517);
            this.contentFlowLayoutPanel.TabIndex = 2;
            // 
            // buttonsTablePanel
            // 
            this.buttonsTablePanel.ColumnCount = 2;
            this.buttonsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTablePanel.Controls.Add(this.findFriendButton, 0, 0);
            this.buttonsTablePanel.Controls.Add(this.suggestedFriendButton, 1, 0);
            this.buttonsTablePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonsTablePanel.Location = new System.Drawing.Point(0, 0);
            this.buttonsTablePanel.Name = "buttonsTablePanel";
            this.buttonsTablePanel.RowCount = 1;
            this.buttonsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.buttonsTablePanel.Size = new System.Drawing.Size(745, 50);
            this.buttonsTablePanel.TabIndex = 3;
            // 
            // findFriendButton
            // 
            this.findFriendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.findFriendButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.findFriendButton.FlatAppearance.BorderSize = 0;
            this.findFriendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findFriendButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findFriendButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(246)))));
            this.findFriendButton.Image = global::OnlyFriends.Properties.Resources.icons8_find_25;
            this.findFriendButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.findFriendButton.Location = new System.Drawing.Point(3, 3);
            this.findFriendButton.MaximumSize = new System.Drawing.Size(200, 45);
            this.findFriendButton.Name = "findFriendButton";
            this.findFriendButton.Size = new System.Drawing.Size(200, 44);
            this.findFriendButton.TabIndex = 0;
            this.findFriendButton.Text = "Find a Friend";
            this.findFriendButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.findFriendButton.UseVisualStyleBackColor = false;
            //this.findFriendButton.Click += new System.EventHandler(this.findFriend_Click);
            // 
            // suggestedFriendButton
            // 
            this.suggestedFriendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.suggestedFriendButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.suggestedFriendButton.FlatAppearance.BorderSize = 0;
            this.suggestedFriendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suggestedFriendButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suggestedFriendButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(246)))));
            //this.suggestedFriendButton.Image = global::OnlyFriends.Properties.Resources.icons8_coaching_25;
            this.suggestedFriendButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.suggestedFriendButton.Location = new System.Drawing.Point(542, 3);
            this.suggestedFriendButton.MaximumSize = new System.Drawing.Size(200, 45);
            this.suggestedFriendButton.Name = "suggestedFriendButton";
            this.suggestedFriendButton.Size = new System.Drawing.Size(200, 44);
            this.suggestedFriendButton.TabIndex = 1;
            this.suggestedFriendButton.Text = "Suggested Friends";
            this.suggestedFriendButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.suggestedFriendButton.UseVisualStyleBackColor = false;
            //this.suggestedFriendButton.Click += new System.EventHandler(this.suggestedFriendButton_Click);
            // 
            // FriendRequestsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.buttonsTablePanel);
            this.Controls.Add(this.contentFlowLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.Name = "FriendRequestsControl";
            this.Size = new System.Drawing.Size(745, 570);
            this.buttonsTablePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button findFriendButton;
        private System.Windows.Forms.Button suggestedFriendButton;
        private System.Windows.Forms.FlowLayoutPanel contentFlowLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel buttonsTablePanel;
    }
}
