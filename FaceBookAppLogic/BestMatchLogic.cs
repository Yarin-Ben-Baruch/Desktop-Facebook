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

        // public List<User> FindCommonFriends(FacebookObjectCollection<User> i_CollectionOfLoginUser, FacebookObjectCollection<User> i_CollctionOfMatchUser)
        // {
        //     List<User> commonGroupsList = new List<User>();
        //
        //     foreach (User matchObject in i_CollectionOfLoginUser)
        //     {
        //         foreach (User checkPage in i_CollctionOfMatchUser)
        //         {
        //             if (matchObject.Name.Equals(checkPage.Name))
        //             {
        //                 commonGroupsList.Add(matchObject);
        //             }
        //         }
        //     }
        //
        //     return commonGroupsList;
        // }
        //
        // public List<Group> FindCommonGroups(FacebookObjectCollection<Group> i_CollectionOfLoginUser, FacebookObjectCollection<Group> i_CollctionOfMatchUser)
        // {
        //     List<Group> commonGroupsList = new List<Group>();
        //
        //     foreach (Group matchObject in i_CollectionOfLoginUser)
        //     {
        //         foreach (Group checkPage in i_CollctionOfMatchUser)
        //         {
        //             if (matchObject.Name.Equals(checkPage.Name))
        //             {
        //                 commonGroupsList.Add(matchObject);
        //             }
        //         }
        //
        //     }
        //
        //     return commonGroupsList;
        // }
        //
        // public List<Page> FindCommonPages(FacebookObjectCollection<Page> i_CollectionOfLoginUser, FacebookObjectCollection<Page> i_CollctionOfMatchUser)
        // {
        //     List<Page> commonGroupsList = new List<Page>();
        //     
        //     foreach (Page matchObject in i_CollectionOfLoginUser)
        //     {
        //         foreach (Page checkPage in i_CollctionOfMatchUser)
        //         {
        //             if (matchObject.Name.Equals(checkPage.Name))
        //             {
        //                 commonGroupsList.Add(matchObject);
        //             }
        //         }
        //         
        //     }
        //
        //     return commonGroupsList;
        // }

        public List<User> FindBestMatch(FacebookObjectCollection<User> i_LoggedInUserFriends,User i_LoggedInUser)
        {
            Dictionary<User, int> commonDictionary = new Dictionary<User, int>();

            foreach (User myFriend in i_LoggedInUserFriends)
            {
                commonDictionary.Add(myFriend,
                    FindCommonObjectsInCollection
                    (myFriend.Groups.Cast<FacebookObject>().ToList(),
                    i_LoggedInUser.Groups.Cast<FacebookObject>().ToList()).Count);
            }

            foreach (User myFriend in i_LoggedInUserFriends)
            {
                if (commonDictionary.ContainsKey(myFriend))
                {
                    commonDictionary[myFriend] += FindCommonObjectsInCollection
                    (myFriend.LikedPages.Cast<FacebookObject>().ToList(),
                        i_LoggedInUser.LikedPages.Cast<FacebookObject>().ToList())
                        .Count;
                }
                else
                {
                    commonDictionary.Add(myFriend,
                        FindCommonObjectsInCollection
                        (myFriend.LikedPages.Cast<FacebookObject>().ToList(),
                            i_LoggedInUser.LikedPages.Cast<FacebookObject>().ToList())
                            .Count);
                }
            }

            foreach (User myFriend in i_LoggedInUserFriends)
            {
                if (commonDictionary.ContainsKey(myFriend))
                {
                    commonDictionary[myFriend] += FindCommonObjectsInCollection
                    (myFriend.Friends.Cast<FacebookObject>().ToList(),
                        i_LoggedInUser.Friends.Cast<FacebookObject>().ToList())
                        .Count;
                }
                else
                {
                    commonDictionary.Add(myFriend,
                        FindCommonObjectsInCollection
                        (myFriend.Friends.Cast<FacebookObject>().ToList(),
                            i_LoggedInUser.Friends.Cast<FacebookObject>().ToList())
                            .Count);
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
