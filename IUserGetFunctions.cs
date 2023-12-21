using System.Collections.Generic;

namespace OnlyFriends {
	internal interface IUserGetFunctions {

		HashSet<User> getFriends();
		HashSet<User> getFriendRequests();
		HashSet<User> getSuggestedFriends();

	}
}
