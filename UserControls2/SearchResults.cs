using OnlyFriends.Components;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OnlyFriends.UserControls2 {
	public partial class SearchResults : UserControl {
		public SearchResults(string userName) {
			InitializeComponent();
			UserName = userName;
			populate();
		}

		string UserName { get; set; }

		private void populate() {

			try {
				User user = User.Instance;
				List<User> searchedFriends = user.searcByUserName(UserName);
				SuggestedFriendComponent[] suggestedFriendComponents = new SuggestedFriendComponent[searchedFriends.Count];

				for (int i = 0; i < searchedFriends.Count; i++) {

					suggestedFriendComponents[i] = new SuggestedFriendComponent(searchedFriends[i].UserId);

					suggestedFriendComponents[i].UserName = searchedFriends[i].UserName;
					suggestedFriendComponents[i].Email = searchedFriends[i].Email;
					suggestedFriendComponents[i].FriendId = searchedFriends[i].UserId;

					flowLayoutPanel1.Controls.Add(suggestedFriendComponents[i]);

				}

			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}

		}

		private void button1_Click(object sender, EventArgs e) {
			this.Hide();
		}
	}
}
