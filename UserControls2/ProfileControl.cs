using System;
using System.Linq;
using System.Windows.Forms;

namespace OnlyFriends.UserControls2 {
	public partial class ProfileControl : UserControl {

		public ProfileControl() {
			InitializeComponent();

			try {
				User user = User.Instance;

				usernameLabel.Text = HelperFunctions.translateUserIdToUserName(user.UserId);
				emailLabel.Text = user.Email;
				genderLabel.Text = user.Gender;

				postNumber.Text = $"{user.getPosts().Count()}";
				friendNumber.Text = $"{user.getFriends().Count()}";
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}


		}

		private void friendNumber_Click(object sender, EventArgs e) {

		}
	}
}
