using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OnlyFriends.Components {

	public partial class Tweet : UserControl {

		public Tweet(int postId, HashSet<int> likedPostIds) {

			InitializeComponent();

			if (likedPostIds.Contains(postId)) {
				likeButton.Image = Properties.Resources.icons8_like_30__3_;
				isLiked = true;
			}
			else {
				likeButton.Image = Properties.Resources.icons8_like_30__2_;
				isLiked = false;
			}
		}

		#region Properties

		private bool isLiked = false;

		private int postId;
		private string userName;
		private string title;
		private string content;
		private DateTime timeStamp;
		private int numberOfLikes;
		private int numberOfComments;

		public int PostId {
			get { return postId; }
			set { postId = value; }
		}
		public string UserName {
			get { return userName; }
			set { userName = value; usernameLabel.Text = value; }
		}
		public string Title {
			get { return title; }
			set { title = value; titleLabel.Text = value; }
		}
		public string Content {
			get { return content; }
			set { content = value; contentLabel.Text = value; }
		}
		public DateTime TimeStamp {
			get { return timeStamp; }
			set { timeStamp = value; timeStampLabel.Text = value.ToString(); }
		}
		public int NumberOfLikes {
			get { return numberOfLikes; }
			set { numberOfLikes = value; likeNumberLabel.Text = value.ToString(); }
		}
		public int NumberOfComments {
			get { return numberOfComments; }
			set { numberOfComments = value; commentNumberLabel.Text = value.ToString(); }
		}

		#endregion Properties

		private void likeButton_Click(object sender, System.EventArgs e) {

			User user = User.Instance;
			user.likePost(postId);
			isLiked = !isLiked;

			if (isLiked) {
				likeButton.Image = Properties.Resources.icons8_like_30__3_;
				NumberOfLikes++;
				likeNumberLabel.Text = (NumberOfLikes).ToString();
			}
			else {
				likeButton.Image = Properties.Resources.icons8_like_30__2_;
				NumberOfLikes--;
				likeNumberLabel.Text = NumberOfLikes.ToString();
			}
		}

		private void commentButton_Click(object sender, System.EventArgs e) {

			List<Comment> comments = HelperFunctions.translatePostIdToPostInfo(postId).getComments();
			if (comments.Count == 0) MessageBox.Show("This post has not Comments");
			foreach (Comment comment in comments) {
				MessageBox.Show(comment.Content, comment.UserId.ToString());
			}

		}
	}
}