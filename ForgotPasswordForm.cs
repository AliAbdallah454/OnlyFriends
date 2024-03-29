﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlyFriends {
    public partial class ForgotPasswordForm : Form {
        public ForgotPasswordForm() {
            InitializeComponent();

            //DatabaseConnection connection = DatabaseConnection.Instance;
            //connection.InitializeConnection();

            passwordBox.UseSystemPasswordChar = true;
            confirmPasswordBox.UseSystemPasswordChar = true;
        }

        private void confirmButton_Click(object sender, EventArgs e) {

            string email = emailBox.Text;
            string password = passwordBox.Text;
            string confirmPassword = confirmPasswordBox.Text;

            try {
                AuthFunctions.changePassword(email, password, confirmPassword);
                MessageBox.Show("You Can LogIn Now With the New Password", "Password Changed Successfully");
                this.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void emailBox_TextChanged(object sender, EventArgs e) {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e) {
        }
    }
}
