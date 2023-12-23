using MySqlConnector;
using System.Collections.Generic;
using System.Linq;

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

		// Still Need to look to see if a single query can replace this fucntion :)
		public HashSet<User> getSuggestedFriends() {

			HashSet<User> suggestedFriends = new HashSet<User>();
			HashSet<User> friends = this.getFriends();
			HashSet<int> usersNotToConsider = friends.Select(friend => friend.UserId).ToHashSet();
			usersNotToConsider.Add(UserId);

			foreach (User friend in friends) {
				HashSet<User> friendFriends = friend.getFriends();
				foreach (User friendFriend in friendFriends) {
					if (!usersNotToConsider.Contains(friendFriend.UserId)) {
						suggestedFriends.Add(friendFriend);
						usersNotToConsider.Add(friendFriend.UserId);
					}
				}
			}
			return suggestedFriends;
		}

	}
}
