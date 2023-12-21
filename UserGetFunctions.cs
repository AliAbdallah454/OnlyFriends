using System.Collections.Generic;

namespace OnlyFriends {
	internal interface UserGetFunctions {

		List<Friend> getFriends();
		List<Friend> getFriendRequests();
		List<Friend> getSuggestedFriends();

	}
}
