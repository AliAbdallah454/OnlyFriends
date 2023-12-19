using System;
using System.Windows.Forms;

namespace OnlyFriends {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}
		//pushing
		private void button1_Click(object sender, EventArgs e) {

			User user = User.Create(
				1,
				"Ali",
				"Abdallah",
				20,
				"Male",
				"email",
				"p",
				"71672664",
				10
			);


			DatabaseConnection connection = DatabaseConnection.Instance;
			connection.InitializeConnection();

			user.addPost("hassan test", "oooo");

			/*
						try {
							user.deletePost(2);
						}
						catch (Exception ex1) {
							MessageBox.Show(ex1.Message);
						}
			*/
			//string sql = "SELECT * FROM users";

			//MySqlDataReader reader = connection.query(sql);

			//while (reader.Read()) {
			//	MessageBox.Show($"{reader["firstName"]}");
			//}
			//reader.Close();

		}
	}
}
