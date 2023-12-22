using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlyFriends {
    public partial class SignUpForm : Form {
        public SignUpForm() {
            InitializeComponent();

            DatabaseConnection connection = DatabaseConnection.Instance;
            connection.InitializeConnection();
        }

        private void ageBox_KeyPress(object sender, KeyPressEventArgs e) {
            if(!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)) {
                e.Handled = true;
            }
        }
        private void phoneNumberBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)) {
                e.Handled = true;
            }
            if(e.KeyChar == '-') {
                e.Handled = false;
            }
        }


        private void firstNameBox_Enter(object sender, EventArgs e) {
            if(firstNameBox.Text == "First Name") {
                firstNameBox.Text = string.Empty;
                firstNameLabel.Visible = true;
            }
        }

        private void lastNameBox_Enter(object sender, EventArgs e) {
            if(lastNameBox.Text == "Last Name") {
                lastNameBox.Text = string.Empty;
                lastNameLabel.Visible = true;
            }
        }

        private void emailBox_Enter(object sender, EventArgs e) {
            if(emailBox.Text == "Email") {
                emailBox.Text = string.Empty;
                emailLabel.Visible = true;
            }
        }

        private void passwordBox_Enter(object sender, EventArgs e) {
            if(passwordBox.Text == "Password") {
                passwordBox.Text = string.Empty;
                passwordLabel.Visible = true;
            }
        }

        private void confirmPasswordBox_Enter(object sender, EventArgs e) {
            if(confirmPasswordBox.Text == "Confirm Password") {
                confirmPasswordBox.Text = string.Empty;
                confirmPasswordLabel.Visible = true;
            }
        }

        private void ageBox_Enter(object sender, EventArgs e) {
            if(ageBox.Text == "Age") {
                ageBox.Text = string.Empty;
                ageLabel.Visible = true;
            }
        }

        private void phoneNumberBox_Enter(object sender, EventArgs e) {
            if(phoneNumberBox.Text == "Phone Number") {
                phoneNumberBox.Text = string.Empty;
                phoneNumberLabel.Visible = true;
            }
        }

        private void genderBox_Enter(object sender, EventArgs e) {
            if(genderBox.Text == "Gender") {
                genderBox.Text = string.Empty;
                genderLabel.Visible = true;
            }
        }

        private void signUpButton_Click(object sender, EventArgs e) {
            string firstName = firstNameBox.Text;
            string lastName = lastNameBox.Text;
            string email = emailBox.Text;
            string password = passwordBox.Text;
            string confirmPassword = confirmPasswordBox.Text;
            string phoneNumber = phoneNumberBox.Text;
            string gender = genderBox.Text;
            int age = int.Parse(ageBox.Text);

            try {
                AuthFunctions.signup(firstName, lastName, email, password, confirmPassword, phoneNumber, gender, age);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
