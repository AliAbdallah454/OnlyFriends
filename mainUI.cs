using OnlyFriends.User_Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

public enum Panels {

	Home,
	MyPosts,
	LikedPosts,
	FriendRequests,
	Suggestions,

	UNKNOWN

}

namespace OnlyFriends {

	public partial class mainUI : Form {

		private Dictionary<Panels, UserControl> panels;
		private Panels currentPanel = Panels.Home;
		private Panels oldPanel;

		private void createUser() {

			DatabaseConnection connection = DatabaseConnection.Instance;
			connection.InitializeConnection();

			string email = "linda.white@example.com";
			string password = "password789";

			AuthFunctions.login(email, password);

		}

		private void changePanel(Panels panel) {

			//if (panel == oldPanel) {
			//	return;
			//}

			panels[oldPanel].Parent = null;
			//Thread.Sleep(500);
			panels[panel].Parent = mainPanel;
			oldPanel = Panels.UNKNOWN;
		}

		private void scalePanel(UserControl panel) {
			panel.ClientSize = mainPanel.ClientSize;
			panel.Dock = DockStyle.Fill;
		}

		private void scalePanels() {
			foreach (var kvp in panels.ToList()) {
				scalePanel(kvp.Value);
			}
		}

		public mainUI() {

			createUser();

			panels = new Dictionary<Panels, UserControl>{

				{ Panels.Home, new HomeUC()},
				{ Panels.MyPosts, new MyPostsUC()},
				{ Panels.LikedPosts, new LikedPostsUC()},
				{ Panels.FriendRequests, new FriendRequestsUC()},
				{ Panels.Suggestions, new SuggestionsUC() }

			};

			InitializeComponent();
			scalePanels();
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

			if (sender is Label label) {

				oldPanel = currentPanel;

				switch (label.Name) {

					case "HomeLabel": {
						currentPanel = Panels.Home;
						panels[currentPanel] = new HomeUC();
						scalePanel(panels[currentPanel]);
						break;
					}
					case "dmLabel": {
						currentPanel = Panels.Home;
						panels[currentPanel] = new HomeUC();
						scalePanel(panels[currentPanel]);
						break;
					}
					case "myPostLabel": {
						currentPanel = Panels.MyPosts;
						panels[currentPanel] = new MyPostsUC();
						scalePanel(panels[currentPanel]);
						break;
					}
					case "reelsLabel": {
						currentPanel = Panels.Home;
						panels[currentPanel] = new HomeUC();
						scalePanel(panels[currentPanel]);
						break;
					}
					case "friendrequestLabel": {
						currentPanel = Panels.FriendRequests;
						panels[currentPanel] = new FriendRequestsUC();
						scalePanel(panels[currentPanel]);
						break;
					}
					case "likedPostsLabel": {
						currentPanel = Panels.LikedPosts;
						panels[currentPanel] = new LikedPostsUC();
						scalePanel(panels[currentPanel]);
						break;
					}
					case "suggestionLabel": {
						currentPanel = Panels.Suggestions;
						panels[currentPanel] = new SuggestionsUC();
						scalePanel(panels[currentPanel]);
						break;
					}
					case "settingsLabel": {
						currentPanel = Panels.Home;
						panels[currentPanel] = new HomeUC();
						scalePanel(panels[currentPanel]);
						break;
					}
					default: {
						currentPanel = Panels.Home;
						panels[currentPanel] = new HomeUC();
						scalePanel(panels[currentPanel]);
						break;
					}

				}
				changePanel(currentPanel);
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

		private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e) {

		}

	}
}


