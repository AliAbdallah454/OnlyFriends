using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlyFriends.UserControls2 {
    public partial class ProfileControl : UserControl {
        User user = User.Instance;
        public ProfileControl() {
            InitializeComponent();

            usernameLabel.Text = HelperFunctions.translateUserIdToUserName(user.UserId);
            emailLabel.Text = user.Email;
            genderLabel.Text = user.Gender;

            postNumber.Text = $"({user.getPosts().Count()})";
            friendNumber.Text = $"({user.getFriends().Count()})";

        }

        


        
    }
}
