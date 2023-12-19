using MySqlConnector;
using System;
using System.Diagnostics;

namespace OnlyFriends {
	internal sealed class DatabaseConnection {

		private DatabaseConnection() { }
		private static DatabaseConnection instance = null;
		public static DatabaseConnection Instance {
			get {
				if (instance == null) {
					instance = new DatabaseConnection();
				}
				return instance;
			}
		}

		private static string connectionString = "server=localhost;uid=root;pwd=gr3ty;database=app_db;password=" + SharedData.password;
		private static MySqlConnection connection = new MySqlConnection(connectionString);

		public MySqlDataReader query(string sql) {
			MySqlCommand cmd = new MySqlCommand(sql, connection);
			MySqlDataReader reader = cmd.ExecuteReader();
			return reader;
		}

		public void InitializeConnection() {

			try {
				connection.Open();
			}
			catch (Exception ex) {
				Debug.WriteLine(ex.ToString());
			}

		}
	}
}
