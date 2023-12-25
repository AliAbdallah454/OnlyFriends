using OnlyFriends.Components;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OnlyFriends.UserControls2 {
	public partial class HomeControl : UserControl {
		public HomeControl() {
			InitializeComponent();
			populate();
		}

		public void populate() {

			User user = User.Instance;

			List<Post> posts = user.getFeedPosts();
			int nbOfPosts = posts.Count;

			Tweet[] tweets = new Tweet[nbOfPosts];

			for (int i = 0; i < posts.Count; i++) {

				tweets[i] = new Tweet(posts[i].PostId);

				tweets[i].PostId = posts[i].PostId;
				tweets[i].UserName = HelperFunctions.translateUserIdToUserName(posts[i].UserId);
				tweets[i].Title = posts[i].Title;
				tweets[i].Content = posts[i].Content;
				tweets[i].TimeStamp = posts[i].TimeStamp;

				flowLayoutPanel1.Controls.Add(tweets[i]);
			}


		}

	}
}
