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


			//string email = "linda.white@example.com";
			//string password = "password789";

			string email = "alice.johnson@example.com";
			string password = "pass123";

			AuthFunctions.login(email, password);

			try {
				User user = User.Instance;

				user.declineFriendRequest(9);
				//user.addFriend(3);
				//user.addFriendByUserName("CharlieDavis");

			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}

		}
	}
}
