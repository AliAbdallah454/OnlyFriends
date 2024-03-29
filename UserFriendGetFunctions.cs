﻿using MySqlConnector;
using System.Collections.Generic;

namespace OnlyFriends {
	internal partial class User {

		private List<User> readFriendsFromDb(string sql) {

			DatabaseConnection connection = DatabaseConnection.Instance;
			MySqlDataReader reader = connection.query(sql);
			List<User> friends = new List<User>();

			while (reader.Read()) {

				int id = reader.GetInt32("userId");
				string userName = reader.GetString("userName");
				int age = reader.GetInt32("age");
				string gender = reader.GetString("gender");
				string email = reader.GetString("email");
				string phoneNumber = reader.GetString("phoneNumber");

				friends.Add(new User(id, userName, age, gender, email, phoneNumber));

			}
			reader.Close();
			return friends;
		}

		public List<User> getFriends() {
			string sql = $"SELECT * FROM users\n" +
				$"WHERE userId IN (SELECT friendId FROM friends WHERE userId = {UserId})";
			return readFriendsFromDb(sql);
		}

		public List<User> getFriendRequests() {
			string sql = $"SELECT * FROM users\n" +
						 $"WHERE userId IN (SELECT friendId FROM friendRequests WHERE userId = {UserId})";
			return readFriendsFromDb(sql);
		}

		public List<User> getPendingRequests() {
			string sql = $"SELECT * FROM users\n" +
						 $"WHERE userId IN (SELECT friendId FROM pendingRequests WHERE userId = {UserId})";
			return readFriendsFromDb(sql);
		}

		public List<User> getSuggestedFriends() {
			string sql = $@"
				SELECT * FROM users
				WHERE userId IN (SELECT DISTINCT friendId FROM friends WHERE userId IN (SELECT friendId FROM friends WHERE userId = {UserId}))
				AND userId != {UserId}
				AND userId NOT IN (SELECT friendId FROM friends WHERE userId = {UserId})
				AND userId NOT IN (SELECT friendId FROM pendingRequests WHERE userId = {UserId})
			";
			return readFriendsFromDb(sql);
		}

		public List<User> searchByUserName(string userName) {

			string sql = $"SELECT * FROM users\n" +
						 $"WHERE userName REGEXP '{userName}'\n" +
						 $"AND userId != {UserId}\n" +
						 $"AND userId NOT IN (SELECT friendId FROM pendingRequests WHERE userId = {UserId})\n" +
						 $"AND userId NOT IN (SELECT friendId FROM friends WHERE userId = {UserId});";
			return readFriendsFromDb(sql);
		}

	}
}
