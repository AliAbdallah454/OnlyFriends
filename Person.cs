namespace OnlyFriends {
	internal class Person {

		private int userId;
		private string firstName;
		private string lastName;
		private int age;
		private string gender;
		private string email;
		private string phoneNumber;

		public int UserId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public string Gender { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }

		public Person() { }

		public Person(int userId, string firstName, string lastName, int age, string gender, string email, string phoneNumber) {
			this.UserId = userId;
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Age = age;
			this.Gender = gender;
			this.Email = email;
			this.PhoneNumber = phoneNumber;
		}
		public string getFullName() {
			return $"{firstName} {lastName}";
		}

	}
}
