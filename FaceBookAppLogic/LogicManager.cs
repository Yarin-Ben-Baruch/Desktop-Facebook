﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FaceBookAppLogic
{
    public class LogicManager
    {
        private readonly BestMatchLogic r_BestMatchLogic;
        private readonly LogicBestFriend r_BestFriendLogic;

        public LogicManager()
        {
            r_BestFriendLogic = new LogicBestFriend();
            r_BestMatchLogic = new BestMatchLogic();
        }

        public List<Photo> FetchPhotos(FacebookObjectCollection<Album> i_Albums)
        {
            return r_BestFriendLogic.FetchPhotos(i_Albums);
        }

        public LinkedList<User> GetMostLikesOnPhotosByUsers(FacebookObjectCollection<Album> i_Albums, List<User> i_FriendsList)
        {
            Dictionary<string, int> mostLikesPhotosUserIdDic = r_BestFriendLogic.GetMostLikesOnPhotosByUsers(i_Albums);
            LinkedList<string> sortedListOfIds = orderUsersMaxToMin(mostLikesPhotosUserIdDic);

            return convertIdToUser(sortedListOfIds, i_FriendsList);
        }

        public LinkedList<User> GetMostLikesOnPostByUsers(FacebookObjectCollection<Post> i_Post)
        {
            return r_BestFriendLogic.GetMostLikesOnPostsByUsers(i_Post);
        }

        // All categories together
        public LinkedList<User> FindBestMatch(FacebookObjectCollection<User> i_LoggedInUserFriends, User i_LoggedInUser, User.eGender i_ChosenGender)
        {
            Dictionary<User, int> bestMatchDictionary = r_BestMatchLogic.FindBestMatch(i_LoggedInUserFriends, i_LoggedInUser, i_ChosenGender);

            return orderUsersMaxToMin(bestMatchDictionary);
        }

        private LinkedList<User> convertIdToUser(LinkedList<string> i_UserIdList, List<User> i_FriendsList)
        {
            LinkedList<User> sortedUsers = new LinkedList<User>();

            foreach (string userId in i_UserIdList)
            {
                foreach (User user in i_FriendsList)
                {
                    if (user.Id.Equals(userId))
                    {
                        sortedUsers.AddLast(user);
                    }
                }
            }

            return sortedUsers;
        }

        private LinkedList<T> orderUsersMaxToMin<T>(Dictionary<T, int> i_UsersToOrder)
        {
            LinkedList<T> sortedUsers = new LinkedList<T>();
            IOrderedEnumerable<KeyValuePair<T, int>> orderDic = i_UsersToOrder.OrderBy(key => -key.Value);

            foreach (KeyValuePair<T, int> user in orderDic)
            {
                sortedUsers.AddLast(user.Key);
            }

            return sortedUsers;
        }

        public List<FacebookObject> FindCommonBetweenOneCategory(FacebookObjectCollection<FacebookObject> i_CollectionOfLoginUser, FacebookObjectCollection<FacebookObject> i_CollctionOfMatchUser)
        {
            return r_BestMatchLogic.FindCommonObjectsInCollection(i_CollectionOfLoginUser.ToList(), i_CollctionOfMatchUser.ToList());
        }

    }
}
