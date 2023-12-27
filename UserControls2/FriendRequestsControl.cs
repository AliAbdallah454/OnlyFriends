using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlyFriends.Components;

namespace OnlyFriends.UserControls2 {
    public partial class FriendRequestsControl : UserControl {
        /*//private SuggestedFriends suggestedFriends;
        private FindFriend findFriend;

        public FriendRequestsControl() {
            InitializeComponent();
            populate();

            suggestedFriends = new SuggestedFriends();
            findFriend = new FindFriend();

            this.Controls.Add(suggestedFriends);
            this.Controls.Add(findFriend);

            contentFlowLayoutPanel.SendToBack();
        }

        private void findFriend_Click(object sender, EventArgs e) {
            suggestedFriends.Visible = false;
            findFriend.Visible = !findFriend.Visible;

            findFriend.Location = new Point(contentFlowLayoutPanel.Left, contentFlowLayoutPanel.Top);
        }

        private void suggestedFriendButton_Click(object sender, EventArgs e) {
            findFriend.Visible = false;
            suggestedFriends.Visible = !suggestedFriends.Visible;


            suggestedFriends.Location = new Point(contentFlowLayoutPanel.Left, contentFlowLayoutPanel.Top);


        }

        */



        public void populate() {
            try {
                User user = User.Instance;
                List<User> friendRequests = user.getFriendRequests();
                FriendRequestComponent[] friendRequestComponent = new FriendRequestComponent[friendRequests.Count];

                for (int i = 0; i < friendRequests.Count; i++) {

                    friendRequestComponent[i] = new FriendRequestComponent();

                    User friend = HelperFunctions.translateUserIdToUserInfo(friendRequests[i].UserId);

                    friendRequestComponent[i].FriendId = friend.UserId;
                    friendRequestComponent[i].UserName = friend.UserName;
                    friendRequestComponent[i].Email = friend.Email;

                    contentFlowLayoutPanel.Controls.Add(friendRequestComponent[i]);

                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void suggestedFriendButton_Click(object sender, EventArgs e) {

        }
    }
}
