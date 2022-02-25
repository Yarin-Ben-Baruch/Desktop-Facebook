using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FaceBookAppLogic
{
    class BestMatchLogic
    {
        public List<T> FindCommonBetweenTwoLists<T>(List<T> i_CollectionOfLoginUser, List<T> i_CollctionOfMatchUser)
        {
            List<T> commonGroupsList = new List<T>();

            foreach (T matchGroup in i_CollctionOfMatchUser)
            {
                if (i_CollectionOfLoginUser.Contains(matchGroup))
                {
                    commonGroupsList.Add(matchGroup);
                }
            }

            return commonGroupsList;
        }

        public LinkedList<User> FindBestMatch(List<User> i_LoggedInUserFriends,User i_LoggedInUser)
        {
            Dictionary<User, int> commonDictionary = new Dictionary<User, int>();

            foreach (User myFriend in i_LoggedInUserFriends)
            {
                commonDictionary.Add(myFriend,
                FindCommonBetweenTwoLists
                    (myFriend.Groups.ToList(),
                    i_LoggedInUser.Groups.ToList()).Count);
            }

            foreach (User myFriend in i_LoggedInUserFriends)
            {
                if (commonDictionary.ContainsKey(myFriend))
                {
                    commonDictionary[myFriend] += FindCommonBetweenTwoLists
                    (myFriend.LikedPages.ToList(),
                        i_LoggedInUser.LikedPages.ToList()).Count;
                }
                else
                {
                    commonDictionary.Add(myFriend,
                        FindCommonBetweenTwoLists
                        (myFriend.Groups.ToList(),
                            i_LoggedInUser.Groups.ToList()).Count);
                }
            }

            foreach (User myFriend in i_LoggedInUserFriends)
            {
                if (commonDictionary.ContainsKey(myFriend))
                {
                    commonDictionary[myFriend] += FindCommonBetweenTwoLists
                    (myFriend.Friends.ToList(),
                        i_LoggedInUser.Friends.ToList()).Count;
                }
                else
                {
                    commonDictionary.Add(myFriend,
                        FindCommonBetweenTwoLists
                        (myFriend.Friends.ToList(),
                            i_LoggedInUser.Friends.ToList()).Count);
                }
            }

            LinkedList<User> bestMatchFriends = new LinkedList<User>(); 

            foreach (KeyValuePair<User, int> user in commonDictionary.OrderBy(key => key.Value))
            {
                bestMatchFriends.Append(user.Key);
            }

            return bestMatchFriends;
        }

    }
}
