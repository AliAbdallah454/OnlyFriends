using OnlyFriends.User_Controls;
using OnlyFriends.UserControls2;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


public enum UC {

	Home,
	MyPosts,
	LikedPosts,
	FriendRequests,
	Suggestions,
	AddPost,
	MyFriends,
	Seach,

	UNKNOWN

}

namespace OnlyFriends {
	public partial class MainApp : Form {
		Color mouseEnterBackColor;
		Color mouseLeaveBackColor;



		private Dictionary<UC, UserControl> userControlsDictionary;
		private UC currentUserControl = UC.Home;
		private UC oldUserControl;
		private Button oldButton = null, currentButton = null;
		WelcomePage wlc;
		User user;
		private string SplitUsername(string s) {
			int i = 0;
			while (s[i] < 'A' || s[i] > 'Z') {
				i++;
			}
			return s.Substring(0, i) + "  " + s.Substring(i, s.Length);
		}
		public MainApp() {
			InitializeComponent();


			DatabaseConnection connection = DatabaseConnection.Instance;
			connection.InitializeConnection();
			AuthFunctions.login("linda.white@example.com", "password789");

			user = User.Instance;
			usernameLabel.Text = user.UserName;
			emailLabel.Text = user.Email;
			displayWelcomePage();
			userControlsDictionary = new Dictionary<UC, UserControl>{

				{ UC.Home, new HomeControl()},
				{ UC.MyPosts, new MyPostsControl()},
				{ UC.LikedPosts, new LikedPostsControl()},
				{ UC.FriendRequests, new FriendRequestsControl()},
				{ UC.Suggestions, new SuggestionsUC() },
				{ UC.MyFriends, new MyFriendsControl() },
				{ UC.AddPost, new AddPostControl() },
				{ UC.Seach, new SearchResults("Ali") }


			};
			mouseEnterBackColor = mainPanel.BackColor;
			mouseLeaveBackColor = navPanel.BackColor;
			currentUserControl = UC.Home;
			changePanel(homeButton, EventArgs.Empty);

		}
		private void displayWelcomePage() {
			wlc = new WelcomePage(SplitUsername(user.UserName));
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

		private void changePanel(UC userControl) {
			userControlsDictionary[oldUserControl].Parent = null;
			userControlsDictionary[userControl].Parent = mainPanel;
			oldUserControl = UC.UNKNOWN;
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

					case "homeButton": {
						currentUserControl = UC.Home;
						userControlsDictionary[oldUserControl].Parent = null;
						userControlsDictionary[currentUserControl] = new HomeControl();
						userControlsDictionary[currentUserControl].Parent = mainPanel;
						break;
					}
					case "myPostsButton": {
						currentUserControl = UC.MyPosts;
						userControlsDictionary[oldUserControl].Parent = null;
						userControlsDictionary[currentUserControl] = new MyPostsControl();
						userControlsDictionary[currentUserControl].Parent = mainPanel;
						break;
					}
					case "addPostButton": {
						currentUserControl = UC.Suggestions;
						userControlsDictionary[oldUserControl].Parent = null;
						userControlsDictionary[currentUserControl] = new AddPostControl();
						userControlsDictionary[currentUserControl].Parent = mainPanel;
						break;
					}
					case "likedPostsButton": {
						currentUserControl = UC.LikedPosts;
						userControlsDictionary[oldUserControl].Parent = null;
						userControlsDictionary[currentUserControl] = new LikedPostsControl();
						userControlsDictionary[currentUserControl].Parent = mainPanel;
						break;
					}
					case "myFriendsButton": {
						currentUserControl = UC.MyFriends;
						userControlsDictionary[oldUserControl].Parent = null;
						userControlsDictionary[currentUserControl] = new MyFriendsControl();
						userControlsDictionary[currentUserControl].Parent = mainPanel;
						break;
					}
					case "friendRequestsButton": {
						currentUserControl = UC.FriendRequests;
						userControlsDictionary[oldUserControl].Parent = null;
						userControlsDictionary[currentUserControl] = new FriendRequestsControl();
						userControlsDictionary[currentUserControl].Parent = mainPanel;
						break;
					}
					case "searchButton": {
						currentUserControl = UC.Seach;
						userControlsDictionary[oldUserControl].Parent = null;
						userControlsDictionary[currentUserControl] = new SearchResults(searchInput.Text);
						userControlsDictionary[currentUserControl].Parent = mainPanel;
						break;
					}
					default: {
						currentUserControl = UC.Home;
						userControlsDictionary[oldUserControl].Parent = null;
						userControlsDictionary[currentUserControl] = new HomeUC();
						userControlsDictionary[currentUserControl].Parent = mainPanel;
						break;
					}

				}
				changePanel(currentUserControl);
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
