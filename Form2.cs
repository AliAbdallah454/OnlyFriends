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

			Post p = new Post(1, 1, "gay", "f", new DateTime(), 20);

			MessageBox.Show(HelperFunctions.translateCommentIdToCommentInfo(11).Content);

		}
	}
}
