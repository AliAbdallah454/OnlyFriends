using OnlyFriends.Components;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OnlyFriends.UserControls2 {
	public partial class MyFriendsControl : UserControl {
		public MyFriendsControl() {
			InitializeComponent();
			populate();
		}

		private void populate() {

			try {
				User user = User.Instance;
				List<User> friends = user.getFriends();
				MyFriendsComponent[] myFriendsComponents = new MyFriendsComponent[friends.Count];
				for (int i = 0; i < friends.Count; i++) {

					myFriendsComponents[i] = new MyFriendsComponent();

					User friend = HelperFunctions.translateUserIdToUserInfo(friends[i].UserId);

					myFriendsComponents[i].FriendId = friend.UserId;
					myFriendsComponents[i].UserName = friend.UserName;
					myFriendsComponents[i].Email = friend.Email;

					flowLayoutPanel1.Controls.Add(myFriendsComponents[i]);

				}

			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}

		}

	}
}
