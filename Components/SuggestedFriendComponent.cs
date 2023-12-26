using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlyFriends.Components {
    public partial class SuggestedFriendComponent : UserControl {
        public SuggestedFriendComponent() {
            InitializeComponent();
            requestedButton.Visible = false;
        }

        #region Properties

        private int userId;
        private int friendId;
        private string userName;
        private string email;
        public int FriendId { get; set; }
        public int UserId { get; set; }
        public string UserName {
            get { return userName; }
            set { userName = value; usernameLabel.Text = userName; }
        }
        public string Email {
            get { return Email; }
            set { email = value; emailLabel.Text = value; }
        }

        #endregion Properties

        private void addButton_Click(object sender, EventArgs e) {
            addButton.Visible = false;
            requestedButton.Visible = true;

            try {
                User user = User.Instance;
                user.addFriend(FriendId);
                addButton.Visible = false;
                requestedButton.Visible = true;
                //Thread.Sleep(3000);
                this.Visible = false;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void requestedButton_Click(object sender, EventArgs e) {
            requestedButton.Visible = false;
            addButton.Visible = true;
        }
    }
}
