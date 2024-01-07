using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlyFriends {
	internal static class HelperFunctions {

		public static User translateUserIdToUserInfo(int userId) {

			DatabaseConnection connection = DatabaseConnection.Instance;

			string sql = "SELECT * FROM users\n" +
						$"WHERE userId = {userId}";

			MySqlDataReader reader = connection.query(sql);

			reader.Read();

			string userName = reader.GetString("userName");
			int age = reader.GetInt32("age");
			string gender = reader.GetString("gender");
			string email = reader.GetString("email");
			string phoneNumber = reader.GetString("phoneNumber");

			reader.Close();

			return new User(userId, userName, age, gender, email, phoneNumber);

		}
		public static Post translatePostIdToPostInfo(int postId) {

			DatabaseConnection connection = DatabaseConnection.Instance;

			string sql = "SELECT * FROM posts\n" +
						$"WHERE postId = {postId}";

			MySqlDataReader reader = connection.query(sql);

			reader.Read();

			int userId = reader.GetInt32("userId");
			string title = reader.GetString("title");
			string content = reader.GetString("content");
			DateTime timeStamp = reader.GetDateTime("timeStamp");
			int likes = reader.GetInt32("likes");
			string tags = ConvertCommaSeparatedStringToList(reader.GetString("tags"));

			reader.Close();


			return new Post(postId, userId, title, content, timeStamp, likes, tags);

		}
		public static Comment translateCommentIdToCommentInfo(int commentId) {

			DatabaseConnection connection = DatabaseConnection.Instance;

			string sql = "SELECT * FROM comments\n" +
						$"WHERE commentId = {commentId}";

			MySqlDataReader reader = connection.query(sql);

			reader.Read();

			int postId = reader.GetInt32("postId");
			int userId = reader.GetInt32("userId");
			string content = reader.GetString("content");
			DateTime timeStamp = reader.GetDateTime("timeStamp");

			reader.Close();

			return new Comment(commentId, postId, userId, content, timeStamp);

		}
		public static string translateUserIdToUserName(int userId) {
			return translateUserIdToUserInfo(userId).getUserName();
		}
		public static bool isInFriendRequests(int friendId) {

			DatabaseConnection connection = DatabaseConnection.Instance;
			User user = User.Instance;

			string sql = $"SELECT * FROM friendRequests\n" +
				$"WHERE userId = {user.UserId} AND friendId = {friendId}";
			MySqlDataReader reader = connection.query(sql);
			if (reader.HasRows) {
				reader.Close();
				return true;
			}
			reader.Close();
			return false;

		}
		public static bool isInPendingRequests(int friendId) {
			DatabaseConnection connection = DatabaseConnection.Instance;
			User user = User.Instance;

			string sql = $"SELECT * FROM pendingRequests\n" +
				$"WHERE userId = {user.UserId} AND friendId = {friendId}";
			MySqlDataReader reader = connection.query(sql);
			if (reader.HasRows) {
				reader.Close();
				return true;
			}
			reader.Close();
			return false;
		}

		// Need to look at this
		public static string ConvertCommaSeparatedStringToList(string inputString) {
			string[] stringArray = inputString.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
											  .Select(s => s.Trim())
											  .ToArray();

			List<string> stringList = new List<string>(stringArray);

			string tagsString = "";
			foreach (string str in stringList) {
				tagsString += $"#{str}";
			}

			return tagsString;
		}

	}
}
