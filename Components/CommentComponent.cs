namespace OnlyFriends.Components {
	public partial class CommentComponent : UserControl {
		public CommentComponent() {
			InitializeComponent();
			contentLabel.Text = "TESTING";
		}

		private string username;

		public string Username {
			get { return contentLabel.Text; }
			set { username = value; usernameLabel.Text = value; }
		}

		private void CommentComponent_Load(object sender, System.EventArgs e) {

		}
	}
}
