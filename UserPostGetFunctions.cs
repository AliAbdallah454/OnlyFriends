using MySqlConnector;
using System;
using System.Collections.Generic;

namespace OnlyFriends {
	internal partial class User {

		public List<Post> readPostsFromDb(string sql) {

			DatabaseConnection connection = DatabaseConnection.Instance;
			MySqlDataReader reader = connection.query(sql);
			List<Post> posts = new List<Post>();

			while (reader.Read()) {

				int id = reader.GetInt32("postId");
				int userId = reader.GetInt32("userId");
				string title = reader.GetString("title");
				string content = reader.GetString("content");
				DateTime timeStamp = reader.GetDateTime("timeStamp");
				int likes = reader.GetInt32("likes");

				posts.Add(new Post(id, userId, title, content, timeStamp, likes));

			}

			reader.Close();
			return posts;

		}

		public List<Post> getPosts() {

			string sql = $"SELECT * FROM posts\n" +
						 $"	WHERE userId = {UserId}";
			return readPostsFromDb(sql);

		}

		public List<Post> getLikedPosts() {

			string sql = $"SELECT * from likedPosts l\n" +
						 $"JOIN posts p ON p.postId = l.postId\n" +
						 $"WHERE l.userId = {UserId}";
			return readPostsFromDb(sql);

		}

		public List<Post> getFeedPosts() {

			string sql = $"SELECT * FROM posts\n" +
						 $"WHERE userId IN (SELECT friendId FROM friends WHERE userId = {UserId})\n" +
						 $"ORDER BY timeStamp\n" +
						 $"LIMIT 15";
			return readPostsFromDb(sql);



		}

	}
}
