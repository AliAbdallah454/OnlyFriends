using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OnlyFriends {

	public partial class mainUI : Form {
		private List<System.Windows.Forms.Panel> panels = new List<System.Windows.Forms.Panel>() { };
		private List<Post> feed = new List<Post>();
		private int currentPanel = 0, currentPost = 0;
		private void createUser() {

			DatabaseConnection connection = DatabaseConnection.Instance;
			connection.InitializeConnection();


			string email = "linda.white@example.com";
			string password = "password789";

			AuthFunctions.login(email, password);


		}
		private void generatePanels() {

			for (int i = 0; i < 8; i++) {
				if (i == 0 || i == 2 || i == 5) {
					panels.Add(panel1);
					continue;
				}
				panels.Add(new Panel());
				Label l = new Label();
				l.Text = i.ToString();
				panels[i].Controls.Add(l);
			}
		}
		private void generatePosts() {
			feed.Add(new Post(152, 1, "hello", "try", new DateTime(2022, 2, 23, 12, 25, 30), 450));
			feed.Add(new Post(152, 1, "hello", "try", new DateTime(2022, 2, 23, 12, 25, 30), 450));
			feed.Add(new Post(152, 1, "hello", "try", new DateTime(2022, 2, 23, 12, 25, 30), 450));
			feed.Add(new Post(152, 1, "hello", "try", new DateTime(2022, 2, 23, 12, 25, 30), 450));
			feed.Add(new Post(152, 1, "hello", "try", new DateTime(2022, 2, 23, 12, 25, 30), 450));
			feed.Add(new Post(152, 1, "hello", "try", new DateTime(2022, 2, 23, 12, 25, 30), 450));
			feed.Add(new Post(152, 1, "hello", "try", new DateTime(2022, 2, 23, 12, 25, 30), 450));

		}
		User user;
		public mainUI() {
			InitializeComponent();
			createUser();
			user = User.Instance;
			generatePanels();
			generatePosts();
			splitContainer1.Panel2.MouseWheel += feedScroller;

		}
		private void showPost(Post post) {
			postUsername2.Text = postUsernameLabel.Text = HelperFunctions.translateUserIdToUserName(post.UserId);
			postImage.Image = post.Pic;
			postText.Text = post.Content;
			postDate.Text = $"Posted at {post.TimeStamp.Hour}:{post.TimeStamp.Minute} , {post.TimeStamp.Day}/{post.TimeStamp.Month}/{post.TimeStamp.Year}";
			hashtagsContentLabel.Text = String.Empty;
			//if (post.tags.Count() == 0) {
			//	HashtagsLabel.Hide();
			//}
			//else {
			//	HashtagsLabel.Show();
			//	foreach (string tag in post.tags) {
			//		hashtagsContentLabel.Text += $"#{tag} ";
			//	}
			//}
			//likesLabel.Text = $"        Like ({post.Likes})";
			//commentsLabel.Text = $"        Comment ({post.Comments})";
			//commentsLabel.Text = $"        Share ({post.Shares})";
			//postPfpUsername.Image=

		}
		private void feedScroller(object sender, MouseEventArgs e) {
			if (e.Delta > 0 && currentPost > 0) { showPost(feed[--currentPost]); }

			else if (e.Delta < 0 && currentPost < feed.Count() - 1) { showPost(feed[++currentPost]); }
		}
		private void mouseEnter_Bold(object sender, EventArgs e) {
			if (sender is Label panel) {
				panel.Font = new Font(panel.Font, FontStyle.Bold);
				panel.ForeColor = Color.Black;
			}
		}
		private void mouseLeave_Regular(object sender, EventArgs e) {
			if (sender is Label panel) {
				panel.Font = new Font(panel.Font, FontStyle.Regular);
				panel.ForeColor = Color.Gray;
			}
		}
		private void changePanel(object sender, EventArgs e) {
			if (sender is Label x) {
				feed = user.getFeedPosts();
				int ocurrentPanel = currentPanel;
				switch (x.Name) {

					case "HomeLabel":
					currentPanel = 0;
					break;
					case "dmLabel":
					currentPanel = 1;
					break;
					case "myPostLabel":
					currentPanel = 2;
					break;
					case "reelsLabel":
					currentPanel = 3;
					break;
					case "friendrequestLabel":
					currentPanel = 4;
					break;
					case "likedPostsLabel":
					currentPanel = 5;
					break;
					case "suggestionLabel":
					currentPanel = 6;
					break;
					case "settingsLabel":
					currentPanel = 7;
					break;


				}
				splitContainer1.Panel2.Controls.Remove(panels[ocurrentPanel]);
				splitContainer1.Panel2.Controls.Add(panels[currentPanel]);


			}
		}
		private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e) {

		}


		private bool[] buttonclicked = { false, false, false };

		//Button Enter Function
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
	}
}


