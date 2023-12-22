using System;

namespace OnlyFriends {

	internal partial class User {

		public int UserId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public string Gender { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string PhoneNumber { get; set; }

		private static User instance = null;

		private DatabaseConnection connection = DatabaseConnection.Instance;

		private User(int userId, string firstName, string lastName, int age, string gender, string email, string password, string phoneNumber) {

			UserId = userId;
			FirstName = firstName;
			LastName = lastName;
			Age = age;
			Gender = gender;
			Email = email;
			Password = password;
			PhoneNumber = phoneNumber;

		}

		public User(int userId, string firstName, string lastName, int age, string gender, string email, string phoneNumber) {

			UserId = userId;
			FirstName = firstName;
			LastName = lastName;
			Age = age;
			Gender = gender;
			Email = email;
			PhoneNumber = phoneNumber;

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
		public string getFullName() {
			return $"{FirstName} {LastName}";
		}

	}

}