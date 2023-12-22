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


			string email = "eva.brown@example.com";
			string password = "mysecret";

			AuthFunctions.login(email, password);

			try {
				User user = User.Instance;
				user.acceptFriendRequest(9);
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}

			//try {
			//	User user = User.Instance;
			//	foreach (User friend in user.getSuggestedFriends()) {
			//		MessageBox.Show(friend.getFullName(), $"{friend.UserId}");
			//	}
			//}
			//catch (Exception ex) {
			//	MessageBox.Show(ex.Message);
			//}

		}
	}
}
