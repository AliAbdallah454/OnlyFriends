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

namespace OnlyFriends {
    public partial class PostCommentsForm : Form {

        bool textBoxEntered = false;
        private int PostId;
        public PostCommentsForm(int postId) {
            InitializeComponent();
            PostId = postId;
        }

        private void exitButton_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void addCommentBox_Enter(object sender, EventArgs e) {
            if (!textBoxEntered) {
                addCommentBox.Text = string.Empty;
                textBoxEntered = true;
            }
        }
        private void addCommentBox_Leave(object sender, EventArgs e) {
            if (addCommentBox.Text == string.Empty) {
                addCommentBox.Text = "add comment...";
                textBoxEntered = false;
            }
        }
        private void addCommentButton_Click(object sender, EventArgs e) {
            string comment = addCommentBox.Text;

            try {

                User user = User.Instance;
                user.commentOnPost(12, comment);
                addCommentBox.Text = "";
            }
            catch (Exception ex) {
                addCommentBox.Text = "";
                MessageBox.Show(ex.Message);
            }
        }


        public void populate() {

            Post post = HelperFunctions.translatePostIdToPostInfo(PostId);


            List<Comments> Comments = post.getComments();

            int nbOfComments = Comments.Count;
            Tweet[] tweets = new Tweet[nbOfComments];

            for (int i = 0; i < Comments.Count; i++) {

                int commentId = Comments[i].CommentId;
                tweets[i] = new Tweet(postId, likedPostIds);

                tweets[i].PostId = postId;
                tweets[i].UserName = HelperFunctions.translateUserIdToUserName(Comments[i].UserId);
                
                tweets[i].Content = Comments[i].Content;
                tweets[i].TimeStamp = Comments[i].TimeStamp;
             

                commentsFlowPanel.Controls.Add(tweets[i]);
            }

        }
    }
}
