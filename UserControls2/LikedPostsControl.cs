using OnlyFriends.Components;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace OnlyFriends.UserControls2 {
	public partial class LikedPostsControl : UserControl {
		public LikedPostsControl() {
			InitializeComponent();
			populate();
		}

		public void populate() {

			try {
				User user = User.Instance;

				List<Post> posts = user.getLikedPosts();
				HashSet<int> likedPostIds = user.getLikedPosts().Select(post => post.PostId).ToHashSet();

				int nbOfPosts = posts.Count;
				Tweet[] tweets = new Tweet[nbOfPosts];

				for (int i = 0; i < posts.Count; i++) {

					int postId = posts[i].PostId;
					tweets[i] = new Tweet(postId, likedPostIds);
					tweets[i].disableDeleteButton();
					tweets[i].PostId = postId;
					tweets[i].UserName = HelperFunctions.translateUserIdToUserName(posts[i].UserId);
					tweets[i].Title = posts[i].Title;
					tweets[i].Content = posts[i].Content;
					tweets[i].TimeStamp = posts[i].TimeStamp;
					tweets[i].NumberOfLikes = posts[i].Likes;
					tweets[i].NumberOfComments = HelperFunctions.translatePostIdToPostInfo(postId).getComments().Count;

					tweets[i].Tags = posts[i].Tags;

					flowLayoutPanel1.Controls.Add(tweets[i]);

				}

			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}

		}


		private void LikedPostsControl_Load(object sender, EventArgs e) {

		}

		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) {

		}
	}
}
