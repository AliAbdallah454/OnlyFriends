﻿using MySqlConnector;
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
		public int Comments{get;set;}
		public int Shares { get; set; }
		public List<string> tags { get; set; }
		public Post(int postId, int userId, string title, string content, DateTime timeStamp, int likes) {
			tags = new List<string>();
			tags.Add("NewPost");
			PostId = postId;
			UserId = userId;
			Title = title;
			Content = content;
			TimeStamp = timeStamp;
			Likes = likes;
		}

		public HashSet<Comment> getComments() {

			DatabaseConnection connection = DatabaseConnection.Instance;
			HashSet<Comment> comments = new HashSet<Comment>();

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
