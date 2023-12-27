using MySqlConnector;
using System;
using System.Windows.Forms;

namespace OnlyFriends {
	internal partial class User {

		public void addFriend(int friendId) {

			string checkSql = $"SELECT * FROM pendingRequests\n" +
							  $"WHERE friendId = {friendId}";

			MySqlDataReader checkReader = connection.query(checkSql);

			if (!checkReader.HasRows) {

				checkReader.Close();

				string sql1 = $"INSERT INTO pendingrequests(userId, friendId)\n" +
						  $"VALUES ({this.UserId}, {friendId})";

				string sql2 = $"INSERT INTO friendrequests(userId, friendId)\n" +
				$"VALUES ({friendId}, {this.UserId})";

				MySqlDataReader reader1 = connection.query(sql1);
				reader1.Close();
				MySqlDataReader reader2 = connection.query(sql2);
				reader2.Close();

				MessageBox.Show("Friend Request Sent");
			}
			else {

				checkReader.Close();
				throw new Exception("A request has been sent already");
			}

		}

		public void acceptFriendRequest(int friendId) {
			string checkSql = $"SELECT * FROM friendRequests\n" +
							  $"WHERE userId = {this.UserId} AND friendId = {friendId}";
			MySqlDataReader checkReader = connection.query(checkSql);
			if (checkReader.HasRows) {
				// Adding to friends table
				checkReader.Close();
				string addFriendToFriendsSql = $"INSERT INTO friends(userId, friendId)\n" +
											   $"VALUES ({this.UserId}, {friendId})";
				MySqlDataReader addFriendToFriendsTableReader = connection.query(addFriendToFriendsSql);
				addFriendToFriendsTableReader.Close();

				string otherAddSql = $"INSERT INTO friends(userId, friendId)\n" +
								  $"VALUES ({friendId}, {this.UserId})";
				MySqlDataReader otherAddReader = connection.query(otherAddSql);
				otherAddReader.Close();

				// Removing from pending friends table
				string removeFriendFromPendingRequestsSql = $"DELETE FROM pendingRequests\n" +
															$"WHERE userId = {friendId} AND friendId = {this.UserId}";
				MySqlDataReader removeFriendFromPendingRequestsReader = connection.query(removeFriendFromPendingRequestsSql);
				removeFriendFromPendingRequestsReader.Close();

				// Removing from friend requests table
				string removeFriendFromFriendRequestsSql = $"DELETE FROM friendRequests\n" +
														   $"WHERE userID = {this.UserId} AND friendId = {friendId}";
				MySqlDataReader removeFriendFromFriendRequestsReader = connection.query(removeFriendFromFriendRequestsSql);
				removeFriendFromFriendRequestsReader.Close();
			}
			else {
				checkReader.Close();
				throw new Exception("No such request is found");
			}
		}

		public void declineFriendRequest(int friendId) {

			DatabaseConnection connection = DatabaseConnection.Instance;

			string checkSql = $"SELECT * FROM friendRequests\n" +
							  $"WHERE userId = {this.UserId} AND friendId = {friendId}";

			MySqlDataReader checkReader = connection.query(checkSql);

			if (checkReader.HasRows) {

				checkReader.Close();

				// Removing from pending friends table
				string removeFriendFromPendingRequestsSql = $"DELETE FROM pendingRequests\n" +
															$"WHERE userId = {friendId} AND friendId = {this.UserId}";
				MySqlDataReader removeFriendFromPendingRequestsReader = connection.query(removeFriendFromPendingRequestsSql);
				removeFriendFromPendingRequestsReader.Close();

				// Removing from friend requests table
				string removeFriendFromFriendRequestsSql = $"DELETE FROM friendRequests\n" +
														   $"WHERE userID = {this.UserId} AND friendId = {friendId}";
				MySqlDataReader removeFriendFromFriendRequestsReader = connection.query(removeFriendFromFriendRequestsSql);
				removeFriendFromFriendRequestsReader.Close();

			}
			else {
				checkReader.Close();
				throw new Exception("No such Friend Request exists");
			}

		}

		public void removeFriend(int friendId) {

			string checkSql = $"SELECT * FROM friends\n" +
							  $"WHERE userId = {this.UserId} AND friendId = {friendId}";

			MySqlDataReader checkReader = connection.query(checkSql);
			if (checkReader.HasRows) {
				checkReader.Close();
				string removeFrinedSql = $"DELETE FROM friends\n" +
										 $"WHERE (userId = {this.UserId} AND friendId = {friendId}) OR (userId = {friendId} AND friendId = {this.UserId})";
				MySqlDataReader removeFriendReader = connection.query(removeFrinedSql);
				removeFriendReader.Close();
				MessageBox.Show($"Removed Frindshit");
			}
			else {
				checkReader.Close();
				throw new Exception("This friendship doesn't Exist");
			}

		}

		public void addFriendByUserName(string userName) {

			DatabaseConnection connection = DatabaseConnection.Instance;

			string sql = $"SELECT * FROM users\n" +
						 $"WHERE userName = \"{userName}\"";

			MySqlDataReader reader = connection.query(sql);

			if (reader.HasRows) {
				reader.Read();
				int userId = reader.GetInt32("userId");
				reader.Close();
				this.addFriend(userId);
			}
			else {
				reader.Close();
				throw new Exception("Error");
			}

		}

	}
}
