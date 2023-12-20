using System;
using System.Windows.Forms;

namespace OnlyFriends {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}
		//pushing
		private void button1_Click(object sender, EventArgs e) {

			DatabaseConnection connection = DatabaseConnection.Instance;
			connection.InitializeConnection();

			string email = emailBox.Text;
			string password = passwordBox.Text;

			AuthFunctions.login(email, password);

		}

		private void button1_Click_1(object sender, EventArgs e) {


			string title = titleBox.Text;
			string content = contentBox.Text;

			try {
				User user = User.Instance;
				user.addPost(title, content);
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}

		}

		private void textBox1_TextChanged(object sender, EventArgs e) {

		}

		private void textBox2_TextChanged(object sender, EventArgs e) {

		}

	}
}
