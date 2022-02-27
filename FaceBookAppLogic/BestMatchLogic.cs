using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FaceBookAppLogic
{
    class BestMatchLogic
    {
        public Dictionary<string, List<FacebookObject>> CommonGroupsDic { get; set; }
        public Dictionary<string, List<FacebookObject>> CommonLikedPagesDic { get; set; }
        public Dictionary<string, List<FacebookObject>> CommonFriendsDic { get; set; }

        public BestMatchLogic()
        {
            CommonGroupsDic = new Dictionary<string, List<FacebookObject>>();
            CommonLikedPagesDic = new Dictionary<string, List<FacebookObject>>();
            CommonFriendsDic = new Dictionary<string, List<FacebookObject>>();
        }

        public List<FacebookObject> FindCommonObjectsInCollection(List<FacebookObject> i_CollectionOfLoginUser, List<FacebookObject> i_CollectionOfMyMatch)
        {
            List<FacebookObject> commonObjectsList = new List<FacebookObject>();

            foreach (FacebookObject matchObject in i_CollectionOfLoginUser)
            {
                foreach (FacebookObject checkObject in i_CollectionOfMyMatch)
                {
                    if (matchObject.Id.Equals(checkObject.Id))
                    {
                        commonObjectsList.Add(matchObject);
                    }
                }
            }

            return commonObjectsList;
        }

        public Dictionary<User, int> FindBestMatch(FacebookObjectCollection<User> i_LoggedInUserFriends,
            User i_LoggedInUser, User.eGender i_ChosenGender, int i_StartAge, int i_EndAge)
        {
            Dictionary<User, int> commonDictionary = new Dictionary<User, int>();
            List<FacebookObject> currentCommonGroups;
            List<FacebookObject> currentCommonLikedPages;
            List<FacebookObject> currentCommonFriends;
            int currentUserAge;

            resetDictionaries();

            foreach (User myFriend in i_LoggedInUserFriends)
            {
                currentUserAge = getFriendAge(myFriend);

                if (myFriend.Gender == i_ChosenGender && i_StartAge <= currentUserAge && currentUserAge <= i_EndAge)
                {
                    currentCommonGroups = FindCommonObjectsInCollection(myFriend.Groups.Cast<FacebookObject>().ToList(),
                        i_LoggedInUser.Groups.Cast<FacebookObject>().ToList());

                    currentCommonLikedPages = FindCommonObjectsInCollection(
                        myFriend.LikedPages.Cast<FacebookObject>().ToList(),
                        i_LoggedInUser.LikedPages.Cast<FacebookObject>().ToList());

                    currentCommonFriends = FindCommonObjectsInCollection(
                        myFriend.Friends.Cast<FacebookObject>().ToList(),
                        i_LoggedInUser.Friends.Cast<FacebookObject>().ToList());

                    commonDictionary.Add(myFriend, currentCommonGroups.Count);
                    commonDictionary[myFriend] += currentCommonLikedPages.Count;
                    commonDictionary[myFriend] += currentCommonFriends.Count;


                    CommonGroupsDic.Add(myFriend.Id, currentCommonGroups);
                    CommonLikedPagesDic.Add(myFriend.Id, currentCommonLikedPages);
                    CommonFriendsDic.Add(myFriend.Id, currentCommonFriends);
                }
            }

            return commonDictionary;
        }

        private void resetDictionaries()
        {
            CommonGroupsDic.Clear();
            CommonLikedPagesDic.Clear();
            CommonFriendsDic.Clear();
        }

        private int getFriendAge(User i_Friend)
        {
            int currentUserAge = -1;

            if (i_Friend.Birthday.Length == 10)
            {
                currentUserAge = DateTime.Now.Year -
                                 int.Parse(i_Friend.Birthday.Substring(i_Friend.Birthday.Length - 4));
            }

            return currentUserAge;
        }
    }
}
