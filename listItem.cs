using System;
using System.Windows.Forms;

namespace OnlyFriends {
	public partial class listItem : UserControl {
		public listItem() {
			InitializeComponent();
		}

		#region Properties

		private string message;

		public string Message {
			get { return message; }
			set { message = value; textLabel.Text = value; }
		}

		#endregion Properties

		private void label1_Click(object sender, EventArgs e) {

		}
	}
}
