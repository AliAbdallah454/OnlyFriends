using System;
using System.Windows.Forms;

namespace OnlyFriends {
	public partial class Form2 : Form {
		public Form2() {
			InitializeComponent();
		}

		private void exit_Click(object sender, EventArgs e) {
			Application.Exit();

		}

		private void removeFriendButton_Click(object sender, EventArgs e) {

			DatabaseConnection connection = DatabaseConnection.Instance;
			connection.InitializeConnection();


			string email = "linda.white@example.com";
			string password = "password789";

			AuthFunctions.login(email, password);

			try {
				User user = User.Instance;
				MessageBox.Show("hi");
				foreach (User friend in user.getFriends()) {
					MessageBox.Show(friend.UserName, HelperFunctions.translateUserIdToUserName(friend.UserId));
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}

		}
	}
}
