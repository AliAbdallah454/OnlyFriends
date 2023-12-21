namespace OnlyFriends {
	internal class Friend {

		public int userId;
		public string firstName;
		public string lastName;
		public int age;
		public string gender;
		public string email;
		public string phoneNumber;

		public Friend(int userId, string firstName, string lastName, int age, string gender, string email, string phoneNumber) {
			this.userId = userId;
			this.firstName = firstName;
			this.lastName = lastName;
			this.age = age;
			this.gender = gender;
			this.email = email;
			this.phoneNumber = phoneNumber;
		}

		public string getFullName() {
			return $"{firstName} {lastName}";
		}

	}
}
