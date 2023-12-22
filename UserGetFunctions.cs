using MySqlConnector;
using System.Collections.Generic;

namespace OnlyFriends {
	internal partial class User : Person {

		private HashSet<User> translateFriendIdsToFriendDetails(HashSet<int> friendsIds) {

			HashSet<User> FriendDetails = new HashSet<User>();

			string idsString = $"({string.Join(", ", friendsIds)})";
			string requestingFriendsInfoSql = $"SELECT * FROM users\n" +
											  $"WHERE userId IN {idsString}";

			MySqlDataReader requestingFrinedsInfoReader = connection.query(requestingFriendsInfoSql);

			while (requestingFrinedsInfoReader.Read()) {

				int id = requestingFrinedsInfoReader.GetInt32("userId");
				string firstName = requestingFrinedsInfoReader.GetString("firstName");
				string lastName = requestingFrinedsInfoReader.GetString("lastName");
				int age = requestingFrinedsInfoReader.GetInt32("age");
				string gender = requestingFrinedsInfoReader.GetString("gender");
				string email = requestingFrinedsInfoReader.GetString("email");
				string phoneNumber = requestingFrinedsInfoReader.GetString("phoneNumber");

				FriendDetails.Add(new User(id, firstName, lastName, age, gender, email, phoneNumber));

			}

			requestingFrinedsInfoReader.Close();

			return FriendDetails;

		}

		private HashSet<int> getIds(string table) {
			string friendsSql = $"SELECT * FROM {table}\n" +
								$"WHERE userId = {this.UserId}";

			MySqlDataReader reader = connection.query(friendsSql);
			HashSet<int> friendsIds = new HashSet<int>();
			while (reader.Read()) {
				friendsIds.Add(reader.GetInt32("friendId"));
			}

			reader.Close();

			return friendsIds;
		}

		public HashSet<User> getFriends() {

			HashSet<int> friendIds = getIds("friends");
			return this.translateFriendIdsToFriendDetails(friendIds);

		}

		public HashSet<User> getFriendRequests() {

			HashSet<int> requestingFriendIds = this.getIds("friendRequests");
			return translateFriendIdsToFriendDetails(requestingFriendIds);
		}

		public HashSet<User> getSuggestedFriends() {

			HashSet<int> suggestedFriendIds = new HashSet<int>();

			HashSet<User> friends = this.getFriends();
			HashSet<int> friendIds = this.getIds("friends");

			foreach (User friend in friends) {
				HashSet<int> friendFriendIds = friend.getIds("friends");
				if (friendFriendIds.Count != 0) {
					foreach (int friendFriendId in friendFriendIds) {
						if (!friendIds.Contains(friendFriendId)) {
							suggestedFriendIds.Add(friendFriendId);
						}
					}
				}
			}

			return this.translateFriendIdsToFriendDetails(suggestedFriendIds);
		}

	}
}
