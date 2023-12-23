using MySqlConnector;
using System.Collections.Generic;

namespace OnlyFriends {
	internal partial class User {

		private HashSet<User> readFriendsFromDb(string sql) {

			DatabaseConnection connection = DatabaseConnection.Instance;
			MySqlDataReader reader = connection.query(sql);
			HashSet<User> friends = new HashSet<User>();

			while (reader.Read()) {

				int id = reader.GetInt32("userId");
				string firstName = reader.GetString("firstName");
				string lastName = reader.GetString("lastName");
				int age = reader.GetInt32("age");
				string gender = reader.GetString("gender");
				string email = reader.GetString("email");
				string phoneNumber = reader.GetString("phoneNumber");

				friends.Add(new User(id, firstName, lastName, age, gender, email, phoneNumber));

			}

			reader.Close();
			return friends;

		}

		public HashSet<User> getFriends() {

			string sql = $"SELECT * FROM users\n" +
				$"WHERE userId IN (SELECT friendId FROM friends WHERE userId = {UserId})";
			return readFriendsFromDb(sql);

		}

		public HashSet<User> getFriendRequests() {
			string sql = $"SELECT * FROM users\n" +
						 $"WHERE userId IN (SELECT friendId FROM friendRequests WHERE userId = {UserId})";
			return readFriendsFromDb(sql);
		}

		public HashSet<User> getSuggestedFriends() {

			string sql = $@"
				SELECT * FROM users
				WHERE userId IN (SELECT DISTINCT friendId FROM (SELECT * FROM friends
						WHERE userId IN (SELECT friendId FROM friends WHERE userId = {UserId}))
						AS ff WHERE friendId != {UserId})
				ORDER BY userId
			";

			return readFriendsFromDb(sql);

		}

	}
}
