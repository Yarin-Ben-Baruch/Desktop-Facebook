using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FaceBookAppLogic
{
    class BestMatchLogic
    {

        public List<FacebookObject> FindCommonObjectsInCollection(List<FacebookObject> i_CollectionOfLoginUser, List<FacebookObject> i_CollctionOfMatchUser)
        {
            List<FacebookObject> commonObjectsList = new List<FacebookObject>();
            
            foreach (FacebookObject matchObject in i_CollectionOfLoginUser)
            {
                foreach (FacebookObject checkObject in i_CollctionOfMatchUser)
                {
                    if (matchObject.Id.Equals(checkObject.Id))
                    {
                        commonObjectsList.Add(matchObject);
                    }
                }
            }

            return commonObjectsList;
        }

        public List<User> FindBestMatch(FacebookObjectCollection<User> i_LoggedInUserFriends,User i_LoggedInUser, User.eGender i_ChosenGender)
        {
            Dictionary<User, int> commonDictionary = new Dictionary<User, int>();

            foreach (User myFriend in i_LoggedInUserFriends)
            {
                if (myFriend.Gender == i_ChosenGender)
                {
                    commonDictionary.Add(myFriend,
                        FindCommonObjectsInCollection(myFriend.Groups.Cast<FacebookObject>().ToList(),
                            i_LoggedInUser.Groups.Cast<FacebookObject>().ToList())
                            .Count);

                    commonDictionary[myFriend] += FindCommonObjectsInCollection(myFriend.LikedPages.Cast<FacebookObject>().ToList(),
                            i_LoggedInUser.LikedPages.Cast<FacebookObject>().ToList())
                        .Count;

                    commonDictionary[myFriend] += FindCommonObjectsInCollection(myFriend.Friends.Cast<FacebookObject>().ToList(),
                            i_LoggedInUser.Friends.Cast<FacebookObject>().ToList())
                        .Count;
                }
            }

            List<User> bestMatchFriends = new List<User>(); 

            foreach (KeyValuePair<User, int> user in commonDictionary.OrderBy(key => -key.Value))
            {
                bestMatchFriends.Add(user.Key);
            }

            return bestMatchFriends;
        }

    }
}
