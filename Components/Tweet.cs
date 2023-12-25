using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Vml;
using OnlyFriends.Properties;

namespace OnlyFriends.Components {
	public partial class Tweet : UserControl {


        public Tweet() {
			InitializeComponent();

			User user = User.Instance;
			//HashSet<int> likedPostIds = user.getLikedPosts().Select(post => post.PostId).ToHashSet();
			HashSet<int> likedPostIds = user.getLikedPosts().Select(post => post.PostId).ToHashSet();


            if (likedPostIds.Contains(postId)) {
                likeButton.Image = Properties.Resources.icons8_like_30__3_;
                isLiked = true;
            }
            else {
                likeButton.Image = Properties.Resources.icons8_like_30__2_;
                isLiked = false;
            }


        }

       
        #region Properties

        private bool isLiked = false;

		private int postId;
		private string userName;
		private string title;
		private DateTime timeStamp;
		private string timeStampString;
		private string content;
		private string likes;
		private string comments;

		public int PostId {
			get { return postId; }
			set { postId = value; }
		}
		public string UserName {
			get { return userName; }
			set { userName = value; usernameLabel.Text = value; }
		}
		public string Title {
			get { return title; }
			set { title = value; titleLabel.Text = value; }
		}
		public string Content {
			get { return content; }
			set { content = value; contentLabel.Text = value; }
		}

		public DateTime TimeStamp {
			get { return timeStamp; }
			set { timeStamp = value; timeStampLabel.Text = value.ToString(); }
		}

		#endregion Properties


		
		private void likeButton_Click(object sender, System.EventArgs e) {
            User user = User.Instance;
            user.likePost(postId);
            isLiked = !isLiked;


            if (isLiked) {
				likeButton.Image = Properties.Resources.icons8_like_30__3_;
			}
			else {
				likeButton.Image = Properties.Resources.icons8_like_30__2_;
			}
		}

		private void commentButton_Click(object sender, System.EventArgs e) {

			List<Comment> comments = HelperFunctions.translatePostIdToPostInfo(postId).getComments();
			if (comments.Count == 0) MessageBox.Show("This post has not Comments");
			foreach (Comment comment in comments) {
				MessageBox.Show(comment.Content, comment.UserId.ToString());
			}

		}
	}
}
