namespace OnlyFriends {
	internal interface IUserActions {
		void addPost(string title, string content);
		void deletePost(int postId);
		void addFriend(int friendId);
		void acceptFriendRequest(int friendId);
		void removeFriend(int friendId);
		void likePost(int postId);
		void commentOnPost(int postId, string comment);
		void removeComment(int commentId);
	}
}