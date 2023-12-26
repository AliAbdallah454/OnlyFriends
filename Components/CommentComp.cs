using System;
using System.Windows.Forms;

namespace OnlyFriends.Components {
	public partial class CommentComp : UserControl {
		public CommentComp(int userId, int commentId) {
			InitializeComponent();

			CommentId = commentId;

			try {
				User user = User.Instance;
				if (user.UserId == userId) {
					removeCommentButton.Visible = true;
				}
				else {
					removeCommentButton.Visible = false;
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}

		}

		#region Properties

		private int userId;
		private int commentId;
		private string userName;
		private string content;
		private DateTime timeStamp;

		public int CommentId { get; set; }
		public int UserId { get; set; }
		public string UserName {
			get { return userName; }
			set { userName = value; usernameLabel.Text = userName; }
		}
		public string Content {
			get { return Content; }
			set { content = value; contentLabel.Text = value; }
		}
		public DateTime TimeStamp {
			get { return timeStamp; }
			set { timeStamp = value; timeStampLabel.Text = value.ToString(); }
		}
		#endregion Properties

		private void CommentComp_Load(object sender, EventArgs e) {

		}

		private void panel3_Paint(object sender, PaintEventArgs e) {

		}

		private void button1_Click(object sender, EventArgs e) {

			try {
				User user = User.Instance;
				user.removeComment(CommentId);
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}

		}
	}
}
