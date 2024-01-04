using System;
using System.Windows.Forms;

namespace OnlyFriends {
	public partial class SignUpForm : Form {
		public SignUpForm() {
			InitializeComponent();

			DatabaseConnection connection = DatabaseConnection.Instance;
			connection.InitializeConnection();
		}

		private void ageBox_KeyPress(object sender, KeyPressEventArgs e) {
			if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)) {
				e.Handled = true;
			}
		}
		private void phoneNumberBox_KeyPress(object sender, KeyPressEventArgs e) {
			if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)) {
				e.Handled = true;
			}
			if (e.KeyChar == '-') {
				e.Handled = false;
			}
		}

		private void userNameBox_Enter(object sender, EventArgs e) {
			if (userNameBox.Text == "User Name") {
				userNameBox.Text = string.Empty;
				userNameLabel.Visible = true;
			}
		}

		private void emailBox_Enter(object sender, EventArgs e) {
			if (emailBox.Text == "Email") {
				emailBox.Text = string.Empty;
				emailLabel.Visible = true;
			}
		}

		private void passwordBox_Enter(object sender, EventArgs e) {
			passwordBox.UseSystemPasswordChar = true;
			if (passwordBox.Text == "Password") {
				passwordBox.Text = string.Empty;
				passwordLabel.Visible = true;
			}
		}

		private void confirmPasswordBox_Enter(object sender, EventArgs e) {
			confirmPasswordBox.UseSystemPasswordChar = true;
			if (confirmPasswordBox.Text == "Confirm Password") {
				confirmPasswordBox.Text = string.Empty;
				confirmPasswordLabel.Visible = true;
			}
		}

		private void ageBox_Enter(object sender, EventArgs e) {
			if (ageBox.Text == "Age") {
				ageBox.Text = string.Empty;
				ageLabel.Visible = true;
			}
		}

		private void phoneNumberBox_Enter(object sender, EventArgs e) {
			if (phoneNumberBox.Text == "Phone Number") {
				phoneNumberBox.Text = string.Empty;
				phoneNumberLabel.Visible = true;
			}
		}

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

		bool genderListIsOpen = false;
		bool genderChosen = false;
        private void genderListButton_Click(object sender, EventArgs e) {
			if (genderListIsOpen) {
				genderList.Height = 22;
				if (!genderChosen) {
                    genderLabel.Visible = false;
                }
            }
            else {
				genderList.Height = 66;
                genderLabel.Visible = true;
            }

            genderListIsOpen = !genderListIsOpen;
        }

        private void maleButton_Click(object sender, EventArgs e) {
			genderListButton.Text = maleButton.Text;
			genderList.Height = 22;
			genderListIsOpen = false;
            genderLabel.Visible = true;
			genderChosen = true;
        }

        private void femaleButton_Click(object sender, EventArgs e) {
			genderListButton.Text = femaleButton.Text;
            genderList.Height = 22;
            genderListIsOpen = false;
			genderLabel.Visible = true;
			genderChosen = true;
        }


        private void signUpButton_Click(object sender, EventArgs e) {
            string userName = userNameBox.Text;
            string email = emailBox.Text;
            string password = passwordBox.Text;
            string confirmPassword = confirmPasswordBox.Text;
            string phoneNumber = phoneNumberBox.Text;
			string gender = genderListButton.Text;
			int age;
            if (ageBox.Text != "Age") {
                age = int.Parse(ageBox.Text);
            }
            else {
                age = 0;
            }


            try {
				if (!genderChosen) {
					throw new Exception("Please choose a gender");
				}
				if(userNameBox.Text.ToLower() == "user name" || userNameBox.Text.ToLower() == "username") {
					throw new Exception("Please enter a valid username");
				}
                AuthFunctions.signup(userName, email, password, confirmPassword, phoneNumber, gender, age);
                this.Hide();
                MainApp mainApp = new MainApp();
                mainApp.Show();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
