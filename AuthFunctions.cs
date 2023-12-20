using MySqlConnector;
using System;
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

		public static void signup(string firstName, string lastName, int age, string gender, string email, string password, string phoneNumber) {
			// We need to insert A user into the users table
		}

	}
}