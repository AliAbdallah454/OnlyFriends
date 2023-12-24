﻿using OnlyFriends.Components;
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
				tweets[i] = new Tweet();
				tweets[i].UName = HelperFunctions.translateUserIdToUserName(posts[i].UserId);
				flowLayoutPanel1.Controls.Add(tweets[i]);
			}


		}

	}
}