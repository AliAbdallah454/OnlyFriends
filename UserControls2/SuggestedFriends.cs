using OnlyFriends.Components;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OnlyFriends.UserControls2 {
	public partial class SuggestedFriends : UserControl {
		public SuggestedFriends() {
			InitializeComponent();
			this.Visible = false;
			populate();
		}

		public void populate() {
			try {

				User user = User.Instance;
				List<User> suggestedFriends = user.getSuggestedFriends();
				SuggestedFriendComponent[] suggestedFriendComponents = new SuggestedFriendComponent[suggestedFriends.Count];

				for (int i = 0; i < suggestedFriends.Count; i++) {
					suggestedFriendComponents[i] = new SuggestedFriendComponent(suggestedFriends[i].UserId);


					suggestedFriendComponents[i].UserName = suggestedFriends[i].UserName;
					suggestedFriendComponents[i].Email = suggestedFriends[i].Email;
					suggestedFriendComponents[i].FriendId = suggestedFriends[i].UserId;

					flowLayoutPanel1.Controls.Add(suggestedFriendComponents[i]);
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}
	}
}
