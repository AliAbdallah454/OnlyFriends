using System;

namespace OnlyFriends {
	internal class Comment {

		public int CommentId { get; set; }
		public int PostId { get; set; }
		public int UserId { get; set; }
		public string Content { get; set; }
		public DateTime TimeStamp { get; set; }

		public Comment(int commentId, int postId, int userId, string content, DateTime timeStamp) {
			CommentId = commentId;
			PostId = postId;
			UserId = userId;
			Content = content;
			TimeStamp = timeStamp;
		}

	}
}
