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
					MessageBox.Show("Password is correct");
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
