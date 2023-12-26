using System;
using System.Windows.Forms;

namespace OnlyFriends.Components {
	public partial class CommentComp : UserControl {
		public CommentComp() {
			InitializeComponent();
		}

		#region Properties

		private string userName;
		private string content;
		private DateTime timeStamp;

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
	}
}
