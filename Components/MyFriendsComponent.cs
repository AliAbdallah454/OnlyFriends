using System;
using System.Windows.Forms;

namespace OnlyFriends.Components {
	public partial class MyFriendsComponent : UserControl {
		public MyFriendsComponent() {
			InitializeComponent();
			User user = User.Instance;
		}

		#region Properties

		private int userId;
		private int friendId;
		private string userName;
		private string email;
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

		private void removeFriendButton_Click(object sender, System.EventArgs e) {

			try {
				User user = User.Instance;
				user.removeFriend(FriendId);
				MessageBox.Show($"{UserName} has been removed from your friends");
				this.Visible = false;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}

		}
	}
}
