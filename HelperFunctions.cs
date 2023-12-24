﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OnlyFriends {
	internal static class HelperFunctions {

		public static User translateUserIdToUserInfo(int userId) {

			DatabaseConnection connection = DatabaseConnection.Instance;

			string sql = "SELECT * FROM users\n" +
						$"WHERE userId = {userId}";

			MySqlDataReader reader = connection.query(sql);

			reader.Read();

			//string firstName = reader.GetString("firstName");
			//string lastName = reader.GetString("lastName");
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

			reader.Close();
			string tags = "summer,winter";

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

		// Need to look at this
		public static List<string> ConvertCommaSeparatedStringToList(string inputString) {
			// Split the string by commas and remove any leading/trailing whitespaces
			string[] stringArray = inputString.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
											  .Select(s => s.Trim())
											  .ToArray();

			// Convert the array to a list
			List<string> stringList = new List<string>(stringArray);

			return stringList;
		}

		public static void displayPostComments(int postId) {
			List<Comment> comments = HelperFunctions.translatePostIdToPostInfo(postId).getComments();
			if (comments.Count == 0) {
				MessageBox.Show("This post has no comments");
				return;
			}
			foreach (Comment comment in comments) {
				MessageBox.Show(comment.Content);
			}
		}

	}
}
