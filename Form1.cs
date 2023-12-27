using System;
using System.Windows.Forms;

namespace OnlyFriends {
	public partial class Login : Form {
		public Login() {
			InitializeComponent();

			DatabaseConnection connection = DatabaseConnection.Instance;
			connection.InitializeConnection();
		}
		private void Form1_Load(object sender, EventArgs e) {

		}

		private void textBox1_Enter(object sender, EventArgs e) {
			//invalidEmaillbl.Visible = false;
			if (textBox2.Text == string.Empty) {
				textBox2.Text = "Password";
				textBox2.UseSystemPasswordChar = false;
			}
			if (textBox1.Text == "Email") {
				textBox1.Text = string.Empty;
			}
		}

		private void textBox2_Enter(object sender, EventArgs e) {
			//InvalidPasswordlbl.Visible = false;
			if (textBox1.Text == string.Empty) {
				textBox1.Text = "Email";
			}
			if (textBox2.Text == "Password") {
				textBox2.Text = string.Empty;
			}
			textBox2.UseSystemPasswordChar = true;
		}


		private void createAccountLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			SignUpForm signUpForm = new SignUpForm();

			this.Hide();
			signUpForm.Show();
		}

		private void forgotPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();

			forgotPasswordForm.Show();
		}


		//NOT DONE YET ADD THIS.HIDE MAIN-UI.SHOW TO LOGINBUTTON
		private void loginButton_Click(object sender, EventArgs e) {
			string email = textBox1.Text;
			string password = textBox2.Text;

			try {
				AuthFunctions.login(email, password);
				this.Hide();
                MainApp mainApp = new MainApp();
                mainApp.Show();
            }
			catch (Exception ex) {
				if (ex.Message == "Email doesn't Exist") {
                    invalidEmaillbl.Visible = true;
					textBox1.Text = string.Empty;
				}
				else if (ex.Message == "password is incorrect") {
					InvalidPasswordlbl.Visible = true;
					textBox2.Text = string.Empty;
				}
				else {
					MessageBox.Show(ex.Message);
				}

			}
			
		}

		private void textBox1_TextChanged_1(object sender, EventArgs e) {
			UpdateButtonState();
		}

		private void textBox2_TextChanged(object sender, EventArgs e) {
			UpdateButtonState();
		}

		private void UpdateButtonState() {
			loginBTN.Enabled = !string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text);
		}






	}

}
