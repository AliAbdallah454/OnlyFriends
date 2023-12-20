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

					int userId = int.Parse($"{infoReader["userId"]}");
					string firstName = (string)infoReader["firstName"];
					string lastName = (string)infoReader["lastName"];
					// email
					// password
					string phoneNumber = (string)infoReader["phoneNumber"];
					string gender = (string)infoReader["gender"];
					int age = int.Parse($"{infoReader["age"]}");

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
	}
}
