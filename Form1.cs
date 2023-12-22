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
            invalidEmaillbl.Visible = false;
            if (textBox2.Text == string.Empty) {
				textBox2.Text = "Password";
				textBox2.UseSystemPasswordChar = false;
			}
			if(textBox1.Text == "Email") {
				textBox1.Text = string.Empty;
			}
        }

        private void textBox2_Enter(object sender, EventArgs e) {
			InvalidPasswordlbl.Visible = false;
			if(textBox1.Text == string.Empty) {
				textBox1.Text = "Email";
			}
			if (textBox2.Text == "Password") { 
				textBox2.Text = string.Empty; 
			}
			textBox2.UseSystemPasswordChar = true;
		}

		private void textBox1_Leave(object sender, EventArgs e) {
			//check valid characters for username
			//check for cotrect email format
			//query request
			//change the lbl visibility in case for any error

		}
		//to press any buttons there mustn't be any errors and thus the labels must be noot visble



        private void createAccountLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            SignUpForm signUpForm = new SignUpForm();

            this.Hide();
            signUpForm.Show();
        }

        private void form2btn_Click(object sender, EventArgs e) {
			Form2 form2 = new Form2();
			this.Hide();
			form2.Show();
        }

        private void MhmdForm_Click(object sender, EventArgs e) {
			MHMDFormTest mhmdForm = new MHMDFormTest();
			this.Hide();
			mhmdForm.Show();
        }


		//NOT DONE YET ADD THIS.HIDE MAIN-UI.SHOW TO LOGINBUTTON
        private void loginButton_Click(object sender, EventArgs e) {
			string email = textBox1.Text;
			string password = textBox2.Text;

			try {
				AuthFunctions.login(email, password);
			}
			catch (Exception ex) {
				if(ex.Message == "Email doesn't Exist") {
					invalidEmaillbl.Visible = true;
					textBox1.Text = string.Empty;
                }
				if(ex.Message == "password is incorrect") {
					InvalidPasswordlbl.Visible = true;
					textBox2.Text = string.Empty;
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
