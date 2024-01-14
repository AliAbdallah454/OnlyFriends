using OnlyFriends.UserControls2;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace OnlyFriends {

	public enum UC {

		Profile,
		Home,
		MyPosts,
		LikedPosts,
		FriendRequests,
		Suggestions,
		AddPost,
		MyFriends,
		Search,

		UNKNOWN

	}

	public partial class MainApp : Form {

		Color mouseEnterBackColor;
		Color mouseLeaveBackColor;

		private Dictionary<UC, UserControl> userControlsDictionary;
		private UC currentUserControl = UC.Home;
		private UC oldUserControl;
		private Button oldButton = null, currentButton = null;
		WelcomePage wlc;
		User user;
		//private string SplitUsername(string s) {
		//	int i = 0;
		//	while (s[i] < 'A' || s[i] > 'Z') {
		//		i++;
		//	}
		//	return s.Substring(0, i) + "  " + s.Substring(i, s.Length);
		//}
		public MainApp() {
			InitializeComponent();


			DatabaseConnection connection = DatabaseConnection.Instance;
			connection.InitializeConnection();


			user = User.Instance;
			usernameLabel.Text = user.UserName;
			emailLabel.Text = user.Email;
			displayWelcomePage();
			userControlsDictionary = new Dictionary<UC, UserControl>{

				{ UC.Profile, new ProfileControl()},
				{ UC.Home, new HomeControl()},
				{ UC.MyPosts, new MyPostsControl()},
				{ UC.LikedPosts, new LikedPostsControl()},
				{ UC.FriendRequests, new FriendRequestsControl()},
				{ UC.Suggestions, new SuggestedFriends() },
				{ UC.MyFriends, new MyFriendsControl() },
				{ UC.AddPost, new AddPostControl() },
				{ UC.Search, new SearchResults("userName") }

			};
			mouseEnterBackColor = mainPanel.BackColor;
			mouseLeaveBackColor = navPanel.BackColor;
			currentUserControl = UC.Profile;
			changePanel(profileButton, EventArgs.Empty);

		}



		private void displayWelcomePage() {
			//wlc = new WelcomePage(SplitUsername(user.UserName));
			wlc = new WelcomePage(user.UserName);
			wlc.Parent = this;
			wlc.BringToFront();
		}
		private void button_MouseEnter_Bold(object sender, EventArgs e) {
			if (sender is Button button) {
				if (button != currentButton)
					button.BackColor = mouseEnterBackColor;
			}
		}

		private void button_MouseLeave_Regular(object sender, EventArgs e) {
			if (sender is Button button) {
				if (button != currentButton)
					button.BackColor = mouseLeaveBackColor;
			}
		}

		private void changePanelFactory(UC uc, string userName = "") {
			currentUserControl = uc;
			userControlsDictionary[oldUserControl].Parent = null;
			userControlsDictionary[currentUserControl] = UserControlFactory.Create(uc, userName);
			userControlsDictionary[currentUserControl].Parent = mainPanel;
		}

		public class UserControlFactory {
			public UserControlFactory() { }
			public static UserControl Create(UC uc, string userName = "") {
				switch (uc) {
					case UC.Profile: {
						return new ProfileControl();
					}
					case UC.Home: {
						return new HomeControl();
					}
					case UC.MyPosts: {
						return new MyPostsControl();
					}
					case UC.LikedPosts: {
						return new LikedPostsControl();
					}
					case UC.FriendRequests: {
						return new FriendRequestsControl();
					}
					case UC.AddPost: {
						return new AddPostControl();
					}
					case UC.MyFriends: {
						return new MyFriendsControl();
					}
					case UC.Search: {
						return new SearchResults(userName);
					}
				}
				return new ProfileControl();
			}
		}

		public void changePanel(object sender, EventArgs e) {

			if (sender is Button button) {
				if (button != currentButton) {
					oldButton = currentButton;
					currentButton = button;
					currentButton.BackColor = mainPanel.BackColor;
					if (oldButton != null)
						oldButton.BackColor = Color.Transparent;
				}


				oldUserControl = currentUserControl;

				switch (button.Name) {

					case "profileButton": {
						changePanelFactory(UC.Profile);
						break;
					}
					case "homeButton": {
						changePanelFactory(UC.Home);
						break;
					}
					case "myPostsButton": {
						changePanelFactory(UC.MyPosts);
						break;
					}
					case "addPostButton": {
						changePanelFactory(UC.AddPost);
						break;
					}
					case "likedPostsButton": {
						changePanelFactory(UC.LikedPosts);

						break;
					}
					case "myFriendsButton": {
						changePanelFactory(UC.MyFriends);
						break;
					}
					case "friendRequestsButton": {
						changePanelFactory(UC.FriendRequests);
						break;
					}
					case "searchButton": {
						changePanelFactory(UC.Search, searchInput.Text);
						break;
					}
					default: {
						changePanelFactory(UC.Home);
						break;
					}

				}
			}
		}

		private void searchButton_Click(object sender, EventArgs e) {
			//SearchResults px = new SearchResults();
			//px.Parent = mainPanel;
			//px.ClientSize = mainPanel.ClientSize;
			//px.Dock = DockStyle.Fill;
			//px.BringToFront();
		}


		private void searchInput_Enter(object sender, EventArgs e) {
			if (searchInput.Text == "Search") {
				searchInput.Text = String.Empty;
			}
		}

		private void searchInput_Leave(object sender, EventArgs e) {
			if (searchInput.Text == string.Empty) {
				searchInput.Text = "Search";
			}
		}

		private void logOutButton_Click(object sender, EventArgs e) {
			DialogResult result = MessageBox.Show("Click yes to logout from this account\nClick no to stay in your account", "Do You Want to Logout?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (result.Equals(DialogResult.Yes)) {
				try {
					AuthFunctions.logout();
					Login login = new Login();
					this.Hide();
					login.Show();
				}
				catch (Exception ex) {
					MessageBox.Show(ex.Message);
				}
			}
		}


	}
}
