using MySqlConnector;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Transactions;
using System.Windows.Forms;

namespace OnlyFriends {

 
    internal class AuthFunctions {
		public static DatabaseConnection connection = DatabaseConnection.Instance;

		public static void login(string email, string password) {

			string sql = $"SELECT * FROM users\n" +
						 $"WHERE email = \"{email}\"";

			MySqlDataReader emailReader = connection.query(sql);

			if (emailReader.HasRows) {

				emailReader.Close();
				string passwordSql = $"SELECT email, password FROM users\n" +
									 $"WHERE email = \"{email}\"";
				MySqlDataReader passwordReader = connection.query(passwordSql);
				passwordReader.Read();
				string dbPassword = $"{passwordReader["password"]}";
				if (dbPassword == password) {

					passwordReader.Close();

					MessageBox.Show("Password is correct");

					string getInfoSql = $"SELECT * FROM users\n" +
										$"WHERE email = \"{email}\"";

					MySqlDataReader infoReader = connection.query(getInfoSql);

					infoReader.Read();

					int userId = infoReader.GetInt32("userId");
					string firstName = infoReader.GetString("firstName");
					string lastName = infoReader.GetString("lastName");
					// email
					// password
					string phoneNumber = infoReader.GetString("phoneNumber");
					string gender = infoReader.GetString("gender");
					int age = infoReader.GetInt32("age");

					User.CreateInstance(
						userId,
						firstName,
						lastName,
						age,
						gender,
						email,
						password,
						phoneNumber
					);

					infoReader.Close();

					MessageBox.Show($"Login done as {firstName} {lastName}");

				}
				else {
					passwordReader.Close();
					throw new Exception("password is incorrect");
				}
				passwordReader.Close();
			}
			else {
				emailReader.Close();
				throw new Exception("Email doesn't Exist");
			}

		}

		public static void signup(string firstName, string lastName, string email, string password, string confirmPassword, string phoneNumber, string gender, int age) {
            // Check if Email is Unique
            string checkEmail = $"SELECT * FROM users\n" +
								$"WHERE email = \"{email}\";";
            MySqlDataReader checkEmailReader = connection.query(checkEmail);

            if (checkEmailReader.HasRows) {
                checkEmailReader.Close();
                throw new Exception("Email Already Exists");
            }
            checkEmailReader.Close();

			// Check if Phone Number is Unique
            string checkPhone = $"SELECT * FROM users\n" +
                                $"WHERE phoneNumber = \"{phoneNumber}\"";
            MySqlDataReader checkPhoneReader = connection.query(checkPhone);
            if (checkPhoneReader.HasRows) {
                checkPhoneReader.Close();
                throw new Exception("Phone Number Already Exists");
            }
            checkPhoneReader.Close();

			// Check if the Rest are Valid
            if (email.Length == 0 || !email.Contains("@gmail.com") || email.StartsWith("@")) {
				throw new Exception("Invalid Email Entry");
			}
            else if (password.Length == 0) {
				throw new Exception("Please Enter a Password");
			}
			else if (confirmPassword != password) {
				throw new Exception("Passwords Do Not Match");
			}
			else if (firstName.Length == 0 || firstName.Length > 30) {
				throw new Exception("First Name Must Be Between 1 and 30 characters");
			}
			else if (lastName.Length == 0 || lastName.Length > 30) {
				throw new Exception("Last Name Must Be Between 1 and 30 characters");
			}
			else if (age < 18) {
				throw new Exception("You Must Be 18+");
			}
			else if (gender.Length == 0 || gender.Length > 50) {
				throw new Exception("Gender Must Be Between 1 and 50 characters");
			}
			else if (phoneNumber.Length != 9 || phoneNumber[2] != '-') {
				throw new Exception("Invalid Phone Number");
			}
			else { //ALL IS GOOD
				string addUser = $"INSERT INTO users (firstName, lastName, email, password, phonenumber, gender, age)" +
								 $"VALUES (\"{firstName}\", \"{lastName}\", \"{email}\", \"{password}\", \"{phoneNumber}\", \"{gender}\", {age})";

				MySqlDataReader addUserToUsers = connection.query(addUser);
				addUserToUsers.Close();

				login(email, password);
			}
        }

        static int trueLength(string input) {
            return input.Count(c => !char.IsWhiteSpace(c) && c != '/' && c != '-');
        }


    }
}