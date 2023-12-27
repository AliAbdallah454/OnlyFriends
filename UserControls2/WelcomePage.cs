using System;
using System.Windows.Forms;

namespace OnlyFriends.UserControls2 {
	public partial class WelcomePage : UserControl {
		public WelcomePage(string username) {
			InitializeComponent();

			label2.Text = username;
		}

		public void WelcomePage_Click(object sender, EventArgs e) {
			this.Hide();
		}
	}
}
