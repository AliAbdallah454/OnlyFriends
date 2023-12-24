using OnlyFriends.User_Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;



namespace OnlyFriends {

	public partial class mainUI : Form {

		private Dictionary<UC, UserControl> panels;
		private UC currentPanel = UC.Home;
		private UC oldPanel;

		public object MessgeBox { get; private set; }

		private void createUser() {

			DatabaseConnection connection = DatabaseConnection.Instance;
			connection.InitializeConnection();

			string email = "linda.white@example.com";
			string password = "password789";

			AuthFunctions.login(email, password);

		}

		private void changePanel(UC panel) {

			//if (panel == oldPanel) {
			//	return;
			//}

			panels[oldPanel].Parent = null;
			//Thread.Sleep(500);
			panels[panel].Parent = mainPanel;
			oldPanel = UC.UNKNOWN;
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

			panels = new Dictionary<UC, UserControl>{

				{ UC.Home, new HomeUC()},
				{ UC.MyPosts, new MyPostsUC()},
				{ UC.LikedPosts, new LikedPostsUC()},
				{ UC.FriendRequests, new FriendRequestsUC()},
				{ UC.Suggestions, new SuggestionsUC() }

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
						currentPanel = UC.Home;
						panels[currentPanel] = new HomeUC();
						scalePanel(panels[currentPanel]);
						break;
					}
					case "dmLabel": {
						currentPanel = UC.Home;
						panels[currentPanel] = new HomeUC();
						scalePanel(panels[currentPanel]);
						break;
					}
					case "myPostLabel": {
						currentPanel = UC.MyPosts;
						panels[currentPanel] = new MyPostsUC();
						scalePanel(panels[currentPanel]);
						break;
					}
					case "reelsLabel": {
						currentPanel = UC.Home;
						panels[currentPanel] = new HomeUC();
						scalePanel(panels[currentPanel]);
						break;
					}
					case "friendrequestLabel": {
						currentPanel = UC.FriendRequests;
						panels[currentPanel] = new FriendRequestsUC();
						scalePanel(panels[currentPanel]);
						break;
					}
					case "likedPostsLabel": {
						currentPanel = UC.LikedPosts;
						panels[currentPanel] = new LikedPostsUC();
						scalePanel(panels[currentPanel]);
						break;
					}
					case "suggestionLabel": {
						currentPanel = UC.Suggestions;
						panels[currentPanel] = new SuggestionsUC();

						scalePanel(panels[currentPanel]);
						break;
					}
					case "settingsLabel": {
						currentPanel = UC.Home;
						panels[currentPanel] = new HomeUC();

						scalePanel(panels[currentPanel]);
						break;
					}
					default: {
						currentPanel = UC.Home;
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


