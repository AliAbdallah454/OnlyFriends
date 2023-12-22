using System;

namespace OnlyFriends {

	internal partial class User : Person {

		private string password;

		public string Password { get; set; }

		private static User instance = null;

		private DatabaseConnection connection = DatabaseConnection.Instance;

		private User(int userId, string firstName, string lastName, int age, string gender, string email, string password, string phoneNumber)
			: base(userId, firstName, lastName, age, gender, email, phoneNumber) {
			this.Password = password;
		}

		private User(int userId, string firstName, string lastName, int age, string gender, string email, string phoneNumber)
			: base(userId, firstName, lastName, age, gender, email, phoneNumber) {
		}

		public static void CreateInstance(int userId, string firstName, string lastName, int age, string gender, string email, string password, string phoneNumber) {

			if (instance == null) {

				instance = new User(userId, firstName, lastName, age, gender, email, password, phoneNumber);

			}
		}

		public static void DestroyInstance() {
			if (instance != null) {
				instance = null;
			}
			else {
				throw new Exception("User Not Logged In");
			}
		}

		public static User Instance {
			get {
				if (instance == null) {
					throw new Exception("No user found");
				}

				return instance;
			}
		}

	}

}