using OnlyFriends.User_Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

public enum Panels {

	Home,
	MyPosts,
	LikedPosts

}

namespace OnlyFriends {

	public partial class mainUI : Form {

		private Dictionary<Panels, UserControl> panels = new Dictionary<Panels, UserControl>();

		private Panels currentPanel = Panels.Home;
		private Panels ocurrentPanel;

		private void createUser() {

			DatabaseConnection connection = DatabaseConnection.Instance;
			connection.InitializeConnection();

			string email = "linda.white@example.com";
			string password = "password789";

			AuthFunctions.login(email, password);

		}

		private void changePanel(Panels panel) {
			panels[ocurrentPanel].Parent = null;
			panels[panel].Parent = mainPanel;
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

			panels.Add(Panels.Home, new HomeUC());
			panels.Add(Panels.MyPosts, new MyPostsUC());
			panels.Add(Panels.LikedPosts, new LikedPostsUC());

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

				ocurrentPanel = currentPanel;
				switch (label.Name) {

					case "HomeLabel": {
						currentPanel = Panels.Home;
						panels[currentPanel] = new HomeUC();
						break;
					}
					case "dmLabel": {
						currentPanel = Panels.Home;
						break;
					}
					case "myPostLabel": {
						currentPanel = Panels.MyPosts;
						panels[currentPanel] = new MyPostsUC();
						break;
					}
					case "reelsLabel": {
						currentPanel = Panels.Home;
						break;
					}
					case "friendrequestLabel": {
						currentPanel = Panels.Home;
						break;
					}
					case "likedPostsLabel": {
						currentPanel = Panels.LikedPosts;
						panels[currentPanel] = new LikedPostsUC();
						break;
					}
					case "suggestionLabel": {
						currentPanel = Panels.Home;
						break;
					}
					case "settingsLabel": {
						currentPanel = Panels.Home;
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


