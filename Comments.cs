﻿using OnlyFriends.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OnlyFriends {
	public partial class Comments : Form {
		bool textBoxEntered = false;
		public Comments(int postId, string userName) {

			User user = User.Instance;


			InitializeComponent();

			PostId = postId;
			UserName = userName;

			populate();

			HashSet<int> likedPostIds = user.getLikedPosts().Select(tempPost => tempPost.PostId).ToHashSet();
			Post post = HelperFunctions.translatePostIdToPostInfo(postId);

			Tweet tweet = new Tweet(PostId, likedPostIds);

			tweet.PostId = post.PostId;
			tweet.UserName = HelperFunctions.translateUserIdToUserName(post.UserId);
			tweet.PostId = postId;
			tweet.Title = post.Title;
			tweet.Content = post.Content;
			tweet.TimeStamp = post.TimeStamp;
			tweet.NumberOfLikes = post.Likes;
			tweet.Tags = post.Tags;
			tweet.NumberOfComments = HelperFunctions.translatePostIdToPostInfo(post.PostId).getComments().Count;
			commentNumberLabel.Text = $"({tweet.NumberOfComments.ToString()})";

			tweet.eraseButtons();

			T = tweet;
			L = commentNumberLabel;

			tweetPanel.Controls.Add(tweet);

		}

		public Label L { get; set; }
		public Tweet T { get; set; }
		public int PostId { get; set; }
		public string UserName { get; set; }

		private void populate() {

			commentsFlowPanel.Controls.Clear();

			List<Comment> comments = HelperFunctions.translatePostIdToPostInfo(PostId).getComments();



			CommentComp[] commentComps = new CommentComp[comments.Count];
			for (int i = 0; i < comments.Count; i++) {

				commentComps[i] = new CommentComp(comments[i].UserId, comments[i].CommentId, this);

				commentComps[i].UserName = HelperFunctions.translateUserIdToUserName(comments[i].UserId);
				commentComps[i].Content = comments[i].Content;
				commentComps[i].TimeStamp = comments[i].TimeStamp;
				

				commentsFlowPanel.Controls.Add(commentComps[i]);

			}

			commentNumberLabel.Text = $"({comments.Count})";

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


			if (textBoxEntered) {

				try {
					User user = User.Instance;
					user.commentOnPost(PostId, comment);

					addCommentBox.Text = "";
					addCommentBox.Text = "add comment...";
					textBoxEntered = false;

					populate();

				}
				catch (Exception ex) {
					addCommentBox.Text = "";
					MessageBox.Show(ex.Message);
				}
			}
			else {
				MessageBox.Show("Write a Comment to Add");
			}
		}


	}
}
