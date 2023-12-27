using MySqlConnector;
using System;
using System.Windows.Forms;

namespace OnlyFriends {
	internal partial class User {

		public void addPost(string title, string content, string tags) {

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
			else if (content.Length > 255) {
				throw new Exception("tags can't be that long, the maximum is 255 character");
			}
			string sql = $"INSERT INTO posts(userId, title, content, timestamp, likes, tags)\n" +
						 $"VALUES({this.UserId}, \"{title}\", \"{content}\", CURRENT_TIMESTAMP, 0, \"{tags}\");";

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

			}
			else {
				checkPost.Close();
				throw new Exception("Post Can't be deleted from this user or the post doesn't exist");
			}

		}

		public void likePost(int postId) {
			string checkSql1 = $"SELECT * FROM posts\n" +
							   $"WHERE postId = {postId};";
			MySqlDataReader checkReader1 = connection.query(checkSql1);
			if (checkReader1.HasRows) {
				checkReader1.Close();

				string checkSql2 = $"SELECT * FROM likedPosts\n" +
								   $"WHERE userId = {this.UserId} AND postId = {postId};";
				MySqlDataReader checkReader2 = connection.query(checkSql2);
				if (!checkReader2.HasRows) {
					checkReader2.Close();

					string addLikedPost = $"INSERT INTO likedPosts\n" +
										  $"VALUES ({this.UserId}, {postId});";
					MySqlDataReader addPostToLikedPosts = connection.query(addLikedPost);
					addPostToLikedPosts.Close();

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
						string removeLikedPost = $"DELETE FROM likedPosts\n" +
												 $"WHERE userId = {this.UserId} AND postId = {postId};";
						MySqlDataReader removePostFromLikedPosts = connection.query(removeLikedPost);
						removePostFromLikedPosts.Close();

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

	}
}