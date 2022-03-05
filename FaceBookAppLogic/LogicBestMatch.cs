using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace FaceBookAppLogic
{
    public class LogicBestMatch
    {
        public IDictionary<string, ICollection<FacebookObject>> CommonGroupsDic { get; set; }

        public IDictionary<string, ICollection<FacebookObject>> CommonLikedPagesDic { get; set; }

        public IDictionary<string, ICollection<FacebookObject>> CommonFriendsDic { get; set; }

        public LogicBestMatch()
        {
            CommonGroupsDic = new Dictionary<string, ICollection<FacebookObject>>();
            CommonLikedPagesDic = new Dictionary<string, ICollection<FacebookObject>>();
            CommonFriendsDic = new Dictionary<string, ICollection<FacebookObject>>();
        }

        public IDictionary<User, int> FindBestMatch(FacebookObjectCollection<User> i_LoggedInUserFriends, User i_LoggedInUser, User.eGender i_ChosenGender, int i_StartAge, int i_EndAge)
        {
            IDictionary<User, int> commonDictionary = new Dictionary<User, int>();
            ICollection<FacebookObject> currentCommonGroups;
            ICollection<FacebookObject> currentCommonLikedPages;
            ICollection<FacebookObject> currentCommonFriends;
            int currentUserAge;

            resetDictionaries();

            foreach (User myFriend in i_LoggedInUserFriends)
            {
                currentUserAge = calcFriendAge(myFriend);

                if (myFriend.Gender == i_ChosenGender && i_StartAge <= currentUserAge && currentUserAge <= i_EndAge)
                {
                    currentCommonGroups = findCommonObjectsInCollection(myFriend.Groups.Cast<FacebookObject>().ToList(), i_LoggedInUser.Groups.Cast<FacebookObject>().ToList());

                    currentCommonLikedPages = findCommonObjectsInCollection(myFriend.LikedPages.Cast<FacebookObject>().ToList(), i_LoggedInUser.LikedPages.Cast<FacebookObject>().ToList());

                    currentCommonFriends = findCommonObjectsInCollection(
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

        //Change Name
        private int calcFriendAge(User i_Friend)
        {
            int currentUserAge = -1;

            if (i_Friend.Birthday.Length == 10)
            {
                currentUserAge = DateTime.Now.Year -
                                 int.Parse(i_Friend.Birthday.Substring(i_Friend.Birthday.Length - 4));
            }

            return currentUserAge;
        }

        //replace to private
        private ICollection<FacebookObject> findCommonObjectsInCollection(ICollection<FacebookObject> i_CollectionOfLoginUser, ICollection<FacebookObject> i_CollectionOfMyMatch)
        {
            ICollection<FacebookObject> commonObjectsList = new List<FacebookObject>();

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
    }
}
