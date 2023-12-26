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
                    suggestedFriendComponents[i] = new SuggestedFriendComponent();


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
