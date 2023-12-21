using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OnlyFriends {
    public partial class MHMDFormTest : Form {

        public MHMDFormTest() {
            InitializeComponent();

            DatabaseConnection connection = DatabaseConnection.Instance;
            connection.InitializeConnection();

            string email = "john.doe@example.com";
            string password = "password123";

            AuthFunctions.login(email, password);
        }

        private void likeButton_Click(object sender, EventArgs e) {
            try {
                User user = User.Instance;
                user.likePost(10);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void CommentBtn_Click(object sender, EventArgs e) {
            string comment = CommentBox.Text;

            try {

                User user = User.Instance;
                user.commentOnPost(12, comment);
                CommentBox.Text = "";
            }
            catch (Exception ex) {
                CommentBox.Text = "";
                MessageBox.Show(ex.Message);
            }
        }

        private void RemoveCommentBtn_Click(object sender, EventArgs e) {
            try {
                User user = User.Instance;
                user.removeComment(11);

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
