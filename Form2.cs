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


			string email = "grace.jones@example.com";
			string password = "open123";

			AuthFunctions.login(email, password);

			try {
				User user = User.Instance;
				//user.acceptFriendRequest(1);
				user.removeFriend(1);
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}

		}
	}
}
