using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OnlyFriends {

	internal class User : Person, IUserActions, IUserGetFunctions {

		private string password;

		public string Password { get; set; }

		private static User instance = null;

		private DatabaseConnection connection = DatabaseConnection.Instance;

		private User(int userId, string firstName, string lastName, int age, string gender, string email, string password, string phoneNumber)
			: base(userId, firstName, lastName, age, gender, email, phoneNumber) {
			this.Password = password;
		}

		private User(int userId, string firstName, string lastName, int age, string gender, string email, string phoneNumber)
			: base(userId, firstName, lastName, age, gender, email, phoneNumber) {
		}

		public static void CreateInstance(int userId, string firstName, string lastName, int age, string gender, string email, string password, string phoneNumber) {

			if (instance == null) {

				instance = new User(userId, firstName, lastName, age, gender, email, password, phoneNumber);

			}
		}

		public static void DestroyInstance() {
			if (instance != null) {
				instance = null;
			}
			else {
				throw new Exception("User Not Logged In");
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
						 $"VALUES({this.UserId}, \"{title}\", \"{content}\", CURRENT_TIMESTAMP, 0);";

			MySqlDataReader reader = connection.query(sql);
			reader.Close();
			MessageBox.Show("Post Created");
		}

		public void deletePost(int postId) {

			string validationSql = $"SELECT * FROM posts\n" +
			$"WHERE userId = {this.UserId} AND postId = {postId};";

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

		public void likePost(int postId) {
			//check if post exist
			string checkSql1 = $"SELECT * FROM posts\n" +
							   $"WHERE postId = {postId};";
			MySqlDataReader checkReader1 = connection.query(checkSql1);
			if (checkReader1.HasRows) {
				checkReader1.Close();

				//check if already liked
				string checkSql2 = $"SELECT * FROM likedPosts\n" +
								   $"WHERE userId = {this.UserId} AND postId = {postId};";
				MySqlDataReader checkReader2 = connection.query(checkSql2);
				if (!checkReader2.HasRows) {
					checkReader2.Close();

					//add post to liked posts
					string addLikedPost = $"INSERT INTO likedPosts\n" +
										  $"VALUES ({this.UserId}, {postId});";
					MySqlDataReader addPostToLikedPosts = connection.query(addLikedPost);
					addPostToLikedPosts.Close();

					//increment likes in posts
					string incrementLikes = $"UPDATE posts\n" +
											$"SET likes = likes + 1\n" +
											$"WHERE postId = {postId};";
					MySqlDataReader incrementLikesInPosts = connection.query(incrementLikes);
					incrementLikesInPosts.Close();

				}
				else {
					checkReader2.Close();
					DialogResult result = MessageBox.Show("Do You Want to Remove the Like?", "Remove Like", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

					if (result == DialogResult.Yes) {
						// remove post from liked posts
						string removeLikedPost = $"DELETE FROM likedPosts\n" +
												 $"WHERE userId = {this.UserId} AND postId = {postId};";
						MySqlDataReader removePostFromLikedPosts = connection.query(removeLikedPost);
						removePostFromLikedPosts.Close();

						//decrement likes in posts
						string decrementLikes = $"UPDATE posts\n" +
												$"SET likes = likes - 1\n" +
												$"WHERE postId = {postId};";
						MySqlDataReader decrementLikesInPosts = connection.query(decrementLikes);
						decrementLikesInPosts.Close();
					}
				}
			}
			else {
				checkReader1.Close();
				throw new Exception("Post Not Found");
			}

		}

		public void commentOnPost(int postId, string comment) {
			string checkSql = $"SELECT * FROM posts\n" +
							  $"WHERE postId = {postId};";
			MySqlDataReader checkReader = connection.query(checkSql);
			if (checkReader.HasRows) {
				checkReader.Close();

				if (comment.Length == 0) {
					throw new Exception("Comment Can't Be Null");
				}
				else if (comment.Length > 500) {
					throw new Exception("Comment Must Be Less Than 500 Character");
				}
				else {
					string addComment = $"INSERT INTO comments (userId, postId, content, timestamp)\n" +
										$"VALUES ({this.UserId}, {postId}, \"{comment}\", CURRENT_TIMESTAMP);";
					MySqlDataReader addCommentToComments = connection.query(addComment);
					addCommentToComments.Close();
				}

			}
			else {
				checkReader.Close();
				throw new Exception("Post Not Found");
			}
		}

		public void removeComment(int commentId) {
			string checkSql = $"SELECT * FROM comments\n" +
							  $"WHERE commentId = {commentId};";
			MySqlDataReader checkReader = connection.query(checkSql);

			if (checkReader.HasRows) {
				checkReader.Close();

				string removeComment = $"DELETE FROM comments\n" +
									   $"WHERE commentId = {commentId};";
				MySqlDataReader removeCommentFromComments = connection.query(removeComment);
				removeCommentFromComments.Close();
			}
			else {
				checkReader.Close();
				throw new Exception("Comment Not Found");
			}
		}

		// FRIENDS RELATED FUNCTIONS

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