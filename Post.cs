using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace OnlyFriends {
	internal class Post {
		public Image Pic { get; set; }
		public int PostId { get; set; }
		public int UserId { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
		public DateTime TimeStamp { get; set; }
		public int Likes { get; set; }
		public string Tags { get; set; }

		public Post(int postId, int userId, string title, string content, DateTime timeStamp, int likes, string tags) {
			PostId = postId;
			UserId = userId;
			Title = title;
			Content = content;
			TimeStamp = timeStamp;
			Likes = likes;
			Tags = HelperFunctions.ConvertCommaSeparatedStringToList(tags);

			//string resourceName = $"pic"; // Replace with the actual resource name

			// Get the type of the generated Resources class
			//Type resourcesType = typeof(Properties.Resources);

			//// Use reflection to get the specified resource by name
			//PropertyInfo propertyInfo = resourcesType.GetProperty(resourceName, BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
			//Pic = (Image)propertyInfo.GetValue(null, null);

			Pic = Properties.Resources.chat;

			//string absolutePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "chat.png");

		}

		public List<Comment> getComments() {

			DatabaseConnection connection = DatabaseConnection.Instance;
			List<Comment> comments = new List<Comment>();

			string getCommentsSql = $"SELECT * FROM comments\n" +
									$"WHERE postId = {PostId}";

			MySqlDataReader reader = connection.query(getCommentsSql);

			while (reader.Read()) {

				int commentId = reader.GetInt32("commentId");
				int pId = reader.GetInt32("postId");
				int uId = reader.GetInt32("userId");
				string cContent = reader.GetString("content");
				DateTime cTimeStamp = reader.GetDateTime("timeStamp");

				comments.Add(new Comment(commentId, pId, uId, cContent, cTimeStamp));

			}
			reader.Close();
			return comments;

		}

	}
}
