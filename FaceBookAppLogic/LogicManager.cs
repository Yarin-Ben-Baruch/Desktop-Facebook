using System.Collections.Generic;
using System.Linq;
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

        public List<Photo> FetchSortedPhotos(FacebookObjectCollection<Album> i_Albums)
        {
            List<Photo> allPhotos = r_BestFriendLogic.FetchPhotos(i_Albums);
            List<Photo> sortedPhotos = allPhotos.OrderBy(photo => -photo.LikedBy.Count).ToList();

            return sortedPhotos;
        }

        public LinkedList<User> GetMostLikesOnPhotosByUsers(FacebookObjectCollection<Album> i_Albums, List<User> i_FriendsList)
        {
            Dictionary<string, int> mostLikesPhotosUserIdDic = r_BestFriendLogic.GetMostLikesOnPhotosByUsers(i_Albums);
            LinkedList<string> sortedListOfIds = orderDictionaryByValueReverse(mostLikesPhotosUserIdDic);

            return convertIdToUser(sortedListOfIds, i_FriendsList);
        }

        public LinkedList<User> GetMostCommentsOnPhotosByUsers(FacebookObjectCollection<Album> i_Albums, List<User> i_FriendsList)
        {
            Dictionary<string, int> mostLikesPhotosUserIdDic = r_BestFriendLogic.GetMostCommentsOnPhotosByUsers(i_Albums);
            LinkedList<string> sortedListOfIds = orderDictionaryByValueReverse(mostLikesPhotosUserIdDic);

            return convertIdToUser(sortedListOfIds, i_FriendsList);
        }

        public LinkedList<User> GetMostLikesOnPostByUsers(FacebookObjectCollection<Post> i_Post)
        {
            return r_BestFriendLogic.GetMostLikesOnPostsByUsers(i_Post);
        }

        public LinkedList<User> FindBestMatch(FacebookObjectCollection<User> i_LoggedInUserFriends,
            User i_LoggedInUser, User.eGender i_ChosenGender, int i_StartAge, int i_EndAge)
        {
            Dictionary<User, int> bestMatchDictionary = r_BestMatchLogic.FindBestMatch(i_LoggedInUserFriends, i_LoggedInUser,
                i_ChosenGender, i_StartAge, i_EndAge);

            return orderDictionaryByValueReverse(bestMatchDictionary);
        }

        public List<Page> FindCommonLikedPages(string i_MyMatch)
        {
            List<FacebookObject> commonList = new List<FacebookObject>();

            commonList = r_BestMatchLogic.CommonLikedPagesDic[i_MyMatch];

            return commonList.Cast<Page>().ToList();
        }

        public List<Group> FindCommonGroups(string i_MyMatch)
        {
            List<FacebookObject> commonList = new List<FacebookObject>();

            commonList = r_BestMatchLogic.CommonGroupsDic[i_MyMatch];

            return commonList.Cast<Group>().ToList();
        }

        public List<User> FindCommonFriends(string i_MyMatch)
        {
            List<FacebookObject> commonList = new List<FacebookObject>();

            commonList = r_BestMatchLogic.CommonFriendsDic[i_MyMatch];

            return commonList.Cast<User>().ToList();
        }

        private LinkedList<T> orderDictionaryByValueReverse<T>(Dictionary<T, int> i_UsersToOrder)
        {
            LinkedList<T> sortedUsers = new LinkedList<T>();
            IOrderedEnumerable<KeyValuePair<T, int>> orderDic = i_UsersToOrder.OrderBy(key => -key.Value);

            foreach (KeyValuePair<T, int> user in orderDic)
            {
                sortedUsers.AddLast(user.Key);
            }

            return sortedUsers;
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
    }
}
