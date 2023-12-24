using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlyFriends.User_Controls;

public enum UC {

    Home,
    MyPosts,
    LikedPosts,
    FriendRequests,
    Suggestions,
    AddPost,

    UNKNOWN

}

namespace OnlyFriends {
    public partial class MainApp : Form {
        Color mouseEnterBackColor = Color.FromArgb(46, 51, 73);
        Color mouseLeaveBackColor = Color.FromArgb(24, 30, 54);

        private Dictionary<UC, UserControl> userControlsDictionary;
        private UC currentUserControl = UC.Home;
        private UC oldUserControl;

        private void createUser() {

            DatabaseConnection connection = DatabaseConnection.Instance;
            connection.InitializeConnection();

            string email = "linda.white@example.com";
            string password = "password789";

            AuthFunctions.login(email, password);

            

        }

        private void changePanel(UC userControl) {
            userControlsDictionary[oldUserControl].Parent = null;
            userControlsDictionary[userControl].Parent = mainPanel;
            oldUserControl = UC.UNKNOWN;
        }

        //private void scaleUserControl(UserControl userControl) {
        //    userControl.ClientSize = mainPanel.ClientSize;
        //    userControl.Dock = DockStyle.Fill;
        //}

        //private void scaleUserControls() {
        //    foreach (var kvp in userControlsDictionary.ToList()) {
        //        scaleUserControl(kvp.Value);
        //    }
        //}

        public MainApp() {
            InitializeComponent();

            createUser();

            User user = User.Instance;
            usernameLabel.Text = user.UserName;
            emailLabel.Text = user.Email;

            userControlsDictionary = new Dictionary<UC, UserControl>{

                { UC.Home, new HomeUC()},
                { UC.MyPosts, new MyPostsUC()},
                { UC.LikedPosts, new LikedPostsUC()},
                { UC.FriendRequests, new FriendRequestsUC()},
                { UC.Suggestions, new SuggestionsUC() }

            };

            //scaleUserControls();
        }


        private void button_MouseEnter_Bold(object sender, EventArgs e) {
            if (sender is Button button) {
                button.BackColor = mouseEnterBackColor;
            }
        }

        private void button_MouseLeave_Regular(object sender, EventArgs e) {
            if (sender is Button button) {
                button.BackColor = mouseLeaveBackColor;
            }
        }

        private void changePanel(object sender, EventArgs e) {

            if (sender is Button button) {

                oldUserControl = currentUserControl;

                switch (button.Name) {

                    case "homeButton": {
                            currentUserControl = UC.Home;
                            userControlsDictionary[currentUserControl] = new HomeUC();
                            //scaleUserControl(userControlsDictionary[currentUserControl]);
                            break;
                        }
                    case "myPostsButton": {
                            currentUserControl = UC.MyPosts;
                            userControlsDictionary[currentUserControl] = new MyPostsUC();
                            //scaleUserControl(userControlsDictionary[currentUserControl]);
                            break;
                        }
                    case "addPostButton": {
                            currentUserControl = UC.Suggestions;
                            userControlsDictionary[currentUserControl] = new SuggestionsUC();
                            //scaleUserControl(userControlsDictionary[currentUserControl]);
                            break;
                        }
                    case "likedPostsButton": {
                            currentUserControl = UC.LikedPosts;
                            userControlsDictionary[currentUserControl] = new LikedPostsUC();
                            //scaleUserControl(userControlsDictionary[currentUserControl]);
                            break;
                        }
                    case "friendRequestsButton": {
                            currentUserControl = UC.FriendRequests;
                            userControlsDictionary[currentUserControl] = new FriendRequestsUC();
                            //scaleUserControl(userControlsDictionary[currentUserControl]);
                            break;
                        }
                    default: {
                            currentUserControl = UC.Home;
                            userControlsDictionary[currentUserControl] = new HomeUC();

                            //scaleUserControl(userControlsDictionary[currentUserControl]);
                            break;
                        }

                }
                changePanel(currentUserControl);
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
    }
}
