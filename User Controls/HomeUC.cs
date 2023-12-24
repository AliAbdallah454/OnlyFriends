using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OnlyFriends.User_Controls {
	public partial class HomeUC : UserControl {

		public HomeUC() {
			InitializeComponent();
			flowLayoutPanel1.MouseWheel += feedScroller;
			generatePosts();
			showPost(feed[0]);
		}
		bool[] buttonclicked = new bool[3];
		private List<Post> feed = new List<Post>();
		private int currentPost = 0;

		private void likeButton_MouseEnter(object sender, EventArgs e) {
			if (!buttonclicked[0]) {
				likeBtn.Image = Properties.Resources.heart__1_;
			}
		}
		private void commentButton_MouseEnter(object sender, EventArgs e) {
			if (!buttonclicked[1]) {
				commentBtn.Image = Properties.Resources.chat;
			}
		}
		private void shareButton_MouseEnter(object sender, EventArgs e) {
			if (!buttonclicked[2]) {
				shareBtn.Image = Properties.Resources.share;
			}
		}

		//Button Leave Functions
		private void likeButton_MouseLeave(object sender, EventArgs e) {
			if (!buttonclicked[0]) {
				likeBtn.Image = Properties.Resources.heart__2_;
			}
		}
		private void commentButton_MouseLeave(object sender, EventArgs e) {
			if (!buttonclicked[1]) {
				commentBtn.Image = Properties.Resources.chat_bubble;
			}
		}
		private void shareButton_MouseLeave(object sender, EventArgs e) {
			if (!buttonclicked[2]) {
				shareBtn.Image = Properties.Resources.social;
			}
		}

		//Button Click Functions
		private void likeButton_Click(object sender, EventArgs e) {
			if (!buttonclicked[0]) {
				likeBtn.Image = Properties.Resources.heart__1_;
			}
			else {
				likeBtn.Image = Properties.Resources.heart__2_;
			}
			buttonclicked[0] = !buttonclicked[0];
		}
		private void commentButton_Click(object sender, EventArgs e) {
			if (!buttonclicked[1]) {
				commentBtn.Image = Properties.Resources.chat;
			}
			else {
				commentBtn.Image = Properties.Resources.chat_bubble;
			}
			buttonclicked[1] = !buttonclicked[1];
		}
		private void shareButton_Click(object sender, EventArgs e) {
			if (!buttonclicked[2]) {
				shareBtn.Image = Properties.Resources.share;
			}
			else {
				shareBtn.Image = Properties.Resources.social;
			}
			buttonclicked[2] = !buttonclicked[2];
		}

		private void showPost(Post post) {

			postUsername2.Text = postUsernameLabel.Text = HelperFunctions.translateUserIdToUserName(post.UserId);
			postImage.Image = post.Pic;
			postText.Text = post.Content;
			postDate.Text = $"Posted at {post.TimeStamp.Hour}:{post.TimeStamp.Minute} , {post.TimeStamp.Day}/{post.TimeStamp.Month}/{post.TimeStamp.Year}";
			hashtagsContentLabel.Text = String.Empty;
			if (post.Tags.Count() == 0) {
				HashtagsLabel.Hide();
			}
			else {
				HashtagsLabel.Show();
				foreach (string tag in post.Tags) {
					hashtagsContentLabel.Text += $"#{tag} ";
				}
			}
			likesLabel.Text = $"        Like ({post.Likes})";
			commentsLabel.Text = $"        Comment ({post.getComments().Count})";
			commentsLabel.Text = $"        Share ({post.Likes / 2})";

			//postPfpUsername.Image=

		}

		private void generatePosts() {

			User user = User.Instance;

			foreach (Post post in user.getFeedPosts()) {
				feed.Add(post);
			}
		}
		private void feedScroller(object sender, MouseEventArgs e) {
			if (e.Delta > 0 && currentPost > 0) { showPost(feed[--currentPost]); }

			else if (e.Delta < 0 && currentPost < feed.Count() - 1) { showPost(feed[++currentPost]); }

		}

		private void HomeUC_Load(object sender, EventArgs e) {

		}

		private void postText_Click(object sender, EventArgs e) {

		}

		private void postImage_Click(object sender, EventArgs e) {

		}
	}
}
