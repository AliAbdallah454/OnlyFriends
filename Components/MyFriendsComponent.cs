using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlyFriends.Components {
    public partial class MyFriendsComponent : UserControl {
        public MyFriendsComponent() {
            InitializeComponent();
            User user = User.Instance;
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
    }
}
