using MySqlConnector;
using System;
using System.Windows.Forms;

namespace OnlyFriends {

	internal class User {

		public int userId;
		public string firstName;
		public string lastName;
		public int age;
		public string gender;
		public string email;
		public string password;
		public string phoneNumber;
		public int numberOfPosts;

		public static User instance = null;

		private DatabaseConnection connection = DatabaseConnection.Instance;

		private User() {
		}

		public static User Create(int userId, string firstName, string lastName, int age, string gender, string email, string password, string phoneNumber, int numberOfPosts) {

			if (instance == null) {

				instance = new User();

				instance.userId = userId;
				instance.firstName = firstName;
				instance.lastName = lastName;
				instance.age = age;
				instance.gender = gender;
				instance.email = email;
				instance.password = password;
				instance.phoneNumber = phoneNumber;
				instance.numberOfPosts = numberOfPosts;

			}
			return instance;
		}
		public static User Instance {
			get {
				if (instance == null) {
					throw new Exception("No user found");
				}
				return instance;
			}
		}
		public string sayHi() {
			return $"Hello, my name is {firstName}";
		}

		public void addPost(string title, string content) {

			string sql = $"INSERT INTO posts(userId, title, content, timestamp, likes)\n" +
						 $"VALUES({userId}, \"{title}\", \"{content}\", CURRENT_TIMESTAMP, 0);";

			MySqlDataReader reader = connection.query(sql);
			if (reader == null) {
				MessageBox.Show("Reader is null");
			}
			reader.Close();
			MessageBox.Show("Post Created");
		}

		public void deletePost(int postId) {

			string validationSql = $"SELECT * FROM posts\n" +
			$"WHERE userId = {userId} AND postId = {postId};";

			MySqlDataReader r1 = connection.query(validationSql);

			if (r1.HasRows) {
				r1.Close();
				string sql = $"DELETE FROM posts\n" +
				$"WHERE postId = {postId};";

				MySqlDataReader reader = connection.query(sql);
				reader.Close();
				MessageBox.Show($"Post with id {postId} has been deleted");

				return;

			}

			r1.Close();
			throw new Exception("Post Can't be deleted from this user");

		}

		public void addFriend(int friendId) {

			// Handle repeated Request

			string sql1 = $"INSERT INTO pendingrequests(userId, friendId)\n" +
						  $"VALUES ({userId}, {friendId})";

			string sql2 = $"INSERT INTO friendrequests(userId, friendId)\n" +
			$"VALUES ({friendId}, {userId})";

			MySqlDataReader reader1 = connection.query(sql1);
			reader1.Close();
			MySqlDataReader reader2 = connection.query(sql2);
			reader2.Close();

			MessageBox.Show("Friend Request Sent");
		}

		public void acceptFriendRequest(int friendId) {

		}

	}

}
