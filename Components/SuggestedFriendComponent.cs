using System;
using System.Windows.Forms;

namespace OnlyFriends.Components {
	public partial class SuggestedFriendComponent : UserControl {
		public SuggestedFriendComponent(int friendId) {
			InitializeComponent();

			if (HelperFunctions.isInFriendRequests(friendId)) {
				addButton.Image = Properties.Resources.icons8_accept_30;
				addButton.Text = "Accept";
				IsInFriendRequests = true;
			}
			else if (HelperFunctions.isInPendingRequests(friendId)) {
				addButton.Image = Properties.Resources.icons8_wait_25;
			}

			requestedButton.Visible = false;
		}

		#region Properties

		private int userId;
		private int friendId;
		private string userName;
		private string email;
		private bool isInFriendRequests;
		private bool isInPendingRequests;
		public bool IsInPendingRequests { get; set; }
		public bool IsInFriendRequests { get; set; }
		public int FriendId { get; set; }
		public int UserId { get; set; }
		public string UserName {
			get { return userName; }
			set { userName = value; usernameLabel.Text = userName; }
		}
		public string Email {
			get { return Email; }
			set { email = value; emailLabel.Text = value; }
		}

		#endregion Properties

		private void addButton_Click(object sender, EventArgs e) {
			addButton.Visible = false;
			requestedButton.Visible = true;

			try {
				User user = User.Instance;
				if (IsInFriendRequests) {
					user.acceptFriendRequest(FriendId);
				}
				else {
					user.addFriend(FriendId);
					addButton.Visible = false;
					requestedButton.Visible = true;
				}
				this.Visible = false;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void requestedButton_Click(object sender, EventArgs e) {
			requestedButton.Visible = false;
			addButton.Visible = true;
		}
	}
}
