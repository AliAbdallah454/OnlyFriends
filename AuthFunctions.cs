using MySqlConnector;
using System;
using System.Windows.Forms;

namespace OnlyFriends {

	internal class AuthFunctions {
		public static DatabaseConnection connection = DatabaseConnection.Instance;

		static string Encrypt(string plaintext, int shift) {
			char[] encryptedChars = new char[plaintext.Length];

			for (int i = 0; i < plaintext.Length; i++) {
				if (char.IsLetter(plaintext[i])) {
					char baseChar = char.IsUpper(plaintext[i]) ? 'A' : 'a';
					encryptedChars[i] = (char)((plaintext[i] - baseChar + shift) % 26 + baseChar);
				}
				else {
					encryptedChars[i] = plaintext[i];
				}
			}

			return new string(encryptedChars);
		}

		static string Decrypt(string ciphertext, int shift) {
			return Encrypt(ciphertext, -shift);
		}

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
				if (Decrypt(dbPassword, 3) == password) {

					passwordReader.Close();

					string getInfoSql = $"SELECT * FROM users\n" +
										$"WHERE email = \"{email}\"";

					MySqlDataReader infoReader = connection.query(getInfoSql);

					infoReader.Read();

					int userId = infoReader.GetInt32("userId");
					string userName = infoReader.GetString("userName");
					string phoneNumber = infoReader.GetString("phoneNumber");
					string gender = infoReader.GetString("gender");
					int age = infoReader.GetInt32("age");

					User.CreateInstance(
						userId,
						userName,
						age,
						gender,
						email,
						password,
						phoneNumber
					);

					infoReader.Close();

					MessageBox.Show($"Login done as {userName}");
					User.CreateInstance(userId, userName, age, gender, email, password, phoneNumber);
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

		public static void signup(string userName, string email, string password, string confirmPassword, string phoneNumber, string gender, int age) {
			// Check if Email is Unique
			string checkEmail = $"SELECT * FROM users\n" +
								$"WHERE email = \"{email}\";";
			MySqlDataReader checkEmailReader = connection.query(checkEmail);

			if (checkEmailReader.HasRows) {
				checkEmailReader.Close();
				throw new Exception("Email Already Exists");
			}
			checkEmailReader.Close();

			//Checking if userName is unique
			string checkUserName = $@"SELECT * FROM users
								      WHERE userName = '{userName}'
									 ";
			MySqlDataReader checkUserNameReader = connection.query(checkUserName);
			if (checkUserNameReader.HasRows) {
				checkUserNameReader.Close();
				throw new Exception("User name is taken");
			}
			checkUserNameReader.Close();
			// Check if Phone Number is Unique 
			if (phoneNumber.Length != 0) {
				string checkPhone = $"SELECT * FROM users\n" +
									$"WHERE phoneNumber = \"{phoneNumber}\"";
				MySqlDataReader checkPhoneReader = connection.query(checkPhone);
				if (checkPhoneReader.HasRows) {
					checkPhoneReader.Close();
					throw new Exception("Phone Number Already Exists");
				}
				checkPhoneReader.Close();
			}

			// Check if the Rest are Valid
			if (email.Length == 0 || !email.Contains("@gmail.com") || email.StartsWith("@")) {
				throw new Exception("Invalid Email Entry");
			}
			else if (userName.Length == 0 || userName.Length >= 30) {
				throw new Exception("Username Must Be Between 1 and 30 Characters");
			}
			else if (password.Length == 0) {
				throw new Exception("Please Enter a Password");
			}
			else if (confirmPassword != password) {
				throw new Exception("Passwords Do Not Match");
			}
			else if (age < 18) {
				throw new Exception("You Must Be 18+");
			}
			else if (age > 100) {
				throw new Exception("Bro You Dead!!");
			}
			else if (gender.Length == 0 || gender.Length > 50) {
				throw new Exception("Gender Must Be Between 1 and 50 Characters");
			}
			else if (phoneNumber.Length != 9 || phoneNumber[2] != '-') {
				throw new Exception("Invalid Phone Number");
			}
			else { //ALL IS GOOD

				string encryptedPassword = Encrypt(password, 3);

				string addUser = $"INSERT INTO users (userName, email, password, phonenumber, gender, age)" +
								 $"VALUES (\"{userName}\", \"{email}\", \"{encryptedPassword}\", \"{phoneNumber}\", \"{gender}\", {age})";

				MySqlDataReader addUserToUsers = connection.query(addUser);
				addUserToUsers.Close();

				login(email, password);
			}
		}

		public static void logout() {
			MessageBox.Show("Logging out from " + User.Instance.getUserName());
			User.DestroyInstance();

			MessageBox.Show("Logout Successful");

		}

		public static void changePassword(string email, string password, string confirmedPassword) {
			string checkEmail = $"SELECT * FROM users\n" +
								$"WHERE email = \"{email}\";";
			MySqlDataReader checkEmailReader = connection.query(checkEmail);
			if (checkEmailReader.HasRows) {
				checkEmailReader.Close();

				if (password.Length == 0) {
					throw new Exception("Password Can't Be Null");
				}
				if (password != confirmedPassword) {
					throw new Exception("Passwords Do Not Match");
				}

				string updatePassword = $"UPDATE users\n" +
										$"SET password = \"{password}\"\n" +
										$"WHERE email = \"{email}\";";
				MySqlDataReader updatePasswordInUsers = connection.query(updatePassword);
				updatePasswordInUsers.Close();
			}
			else {
				checkEmailReader.Close();
				throw new Exception("Email Not Found");
			}
		}

	}
}