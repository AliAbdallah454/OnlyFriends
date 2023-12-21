using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OnlyFriends {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}
		private void button1_Click(object sender, EventArgs e) {

			DatabaseConnection connection = DatabaseConnection.Instance;
			connection.InitializeConnection();

			string email = emailBox.Text;
			string password = passwordBox.Text;

			email = "john.doe@example.com";
			password = "password123";

			AuthFunctions.login(email, password);

		}

		private void button1_Click_1(object sender, EventArgs e) {

			string title = titleBox.Text;
			//string content = contentBox.Text;

			try {
				User user = User.Instance;
				//user.addFriend(int.Parse(title));
				List<int> friends = user.getPendingFriends();
				foreach (int friend in friends) {
					MessageBox.Show(friend.ToString());
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}

		}

		private void textBox1_TextChanged(object sender, EventArgs e) {

		}

		private void textBox2_TextChanged(object sender, EventArgs e) {

		}


        private void form2Button_Click(object sender, EventArgs e) {
            Form2 form2 = new Form2();

            this.Hide();
            form2.Show();
        }
    }
}
