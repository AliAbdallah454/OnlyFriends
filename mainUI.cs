using OnlyFriends.User_Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OnlyFriends {

	public partial class mainUI : Form {
		private List<UserControl> panels;

		private int currentPanel = 0, ocurrentPanel;
		private void createUser() {

			DatabaseConnection connection = DatabaseConnection.Instance;
			connection.InitializeConnection();

			string email = "linda.white@example.com";
			string password = "password789";

			AuthFunctions.login(email, password);

		}

		private void changePanel(int i) {
			if (i >= 0 && i < panels.Count()) {
				panels[ocurrentPanel].Parent = null;
				panels[i].Parent = mainPanel;

			}
		}
		private void scalePanels() {
			foreach (UserControl x in panels) {
				x.ClientSize = mainPanel.ClientSize;
				x.Scale(0.82f);
				x.Dock = DockStyle.Fill;
			}
		}

		public mainUI() {
			createUser();
			panels = new List<UserControl>() { new HomeUC(), new MyPostsUC(), new LikedPostsUC() };
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
			if (sender is Label x) {

				ocurrentPanel = currentPanel;
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
				changePanel(currentPanel);



			}
		}
		private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e) {

		}


		private bool[] buttonclicked = { false, false, false };


	}
}


