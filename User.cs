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

		private static User instance = null;

		private DatabaseConnection connection = DatabaseConnection.Instance;

		private User() { }

		public static void CreateInstance(int userId, string firstName, string lastName, int age, string gender, string email, string password, string phoneNumber) {

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

			}

		}
		public static User Instance {
			get {
				if (instance == null) {
					throw new Exception("No user found");
				}
				return instance;
			}
		}
		public void addPost(string title, string content) {

			if (title.Length == 0) {
				throw new Exception("Title can't be empty");
			}
			else if (content.Length == 0) {
				throw new Exception("Content can't be empty");
			}
			else if (title.Length > 255) {
				throw new Exception("Title is too long my man (or woman or 2 spirit penguin)");
			}
			else if (content.Length > 1024) {
				throw new Exception("Post can't be that long, the maximum is 1024 character");
			}

			string sql = $"INSERT INTO posts(userId, title, content, timestamp, likes)\n" +
						 $"VALUES({userId}, \"{title}\", \"{content}\", CURRENT_TIMESTAMP, 0);";

			MySqlDataReader reader = connection.query(sql);
			reader.Close();
			MessageBox.Show("Post Created");
		}

		public void deletePost(int postId) {

			string validationSql = $"SELECT * FROM posts\n" +
			$"WHERE userId = {userId} AND postId = {postId};";

			MySqlDataReader checkPost = connection.query(validationSql);

			if (checkPost.HasRows) {
				checkPost.Close();
				string sql = $"DELETE FROM posts\n" +
				$"WHERE postId = {postId};";

				MySqlDataReader reader = connection.query(sql);
				reader.Close();
				MessageBox.Show($"Post with id {postId} has been deleted");

			}
			else {
				checkPost.Close();
				throw new Exception("Post Can't be deleted from this user or the post doesn't exist");
			}

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
