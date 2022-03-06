using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace FaceBookAppLogic
{
    public class LogicManager
    {
        private readonly LogicBestMatch r_BestMatchLogic;
        private readonly LogicBestFriend r_BestFriendLogic;
        private readonly LogicFriendsCities r_FriendsCities;
        private readonly LogicUtilities r_LogicUtilities;

        public LogicManager()
        {
            r_BestFriendLogic = new LogicBestFriend();
            r_BestMatchLogic = new LogicBestMatch();
            r_FriendsCities = new LogicFriendsCities();
            r_LogicUtilities = new LogicUtilities();
        }

        public ICollection<City> GetAllCities(FacebookObjectCollection<User> i_LoggedInUserFriends)
        {
            return r_FriendsCities.GetAllCities(i_LoggedInUserFriends);
        }

        public ICollection<User> GetAllUserInCity(FacebookObjectCollection<User> i_LoggedInUserFriends, City i_SelectedCity)
        {
            return r_FriendsCities.GetAllUsersInCity(i_LoggedInUserFriends, i_SelectedCity);
        }
        
        public ICollection<Photo> FetchSortedPhotos(FacebookObjectCollection<Album> i_Albums)
        {
            ICollection<Photo> allPhotos = r_BestFriendLogic.FetchPhotos(i_Albums);
            ICollection<Photo> sortedPhotos = allPhotos.OrderBy(photo => -photo.LikedBy.Count).ToList();

            return sortedPhotos;
        }

        public ICollection<User> GetMostLikesOnPhotosByUsers(FacebookObjectCollection<Album> i_Albums, ICollection<User> i_FriendsList)
        {
            IDictionary<string, int> mostLikesPhotosUserIdDic = r_BestFriendLogic.GetMostLikesOnPhotosByUsers(i_Albums);
            ICollection<string> sortedListOfIds = r_LogicUtilities.OrderDictionaryByValueReverse(mostLikesPhotosUserIdDic);

            return r_LogicUtilities.ConvertIdToUser(sortedListOfIds, i_FriendsList);
        }

        public ICollection<User> GetMostCommentsOnPhotosByUsers(FacebookObjectCollection<Album> i_Albums, ICollection<User> i_FriendsList)
        {
            IDictionary<string, int> mostLikesPhotosUserIdDic = r_BestFriendLogic.GetMostCommentsOnPhotosByUsers(i_Albums);
            ICollection<string> sortedListOfIds = r_LogicUtilities.OrderDictionaryByValueReverse(mostLikesPhotosUserIdDic);

            return r_LogicUtilities.ConvertIdToUser(sortedListOfIds, i_FriendsList);
        }

        public ICollection<User> GetMostLikesOnPostByUsers(FacebookObjectCollection<Post> i_Post, ICollection<User> i_FriendsList)
        {
            IDictionary<string, int> mostLikesPostUserIdDic = r_BestFriendLogic.GetMostLikesOnPostsByUsers(i_Post);
            ICollection<string> sortedListOfIds = r_LogicUtilities.OrderDictionaryByValueReverse(mostLikesPostUserIdDic);

            return r_LogicUtilities.ConvertIdToUser(sortedListOfIds, i_FriendsList);
        }

        public ICollection<User> FindBestMatch(FacebookObjectCollection<User> i_LoggedInUserFriends, User i_LoggedInUser, User.eGender i_ChosenGender, int i_StartAge, int i_EndAge)
        {
            IDictionary<User, int> bestMatchDictionary = r_BestMatchLogic.FindBestMatch(i_LoggedInUserFriends, i_LoggedInUser, i_ChosenGender, i_StartAge, i_EndAge);

            return r_LogicUtilities.OrderDictionaryByValueReverse(bestMatchDictionary);
        }

        public ICollection<Page> FindCommonLikedPages(string i_MyMatch)
        {
            ICollection<FacebookObject> commonList = new List<FacebookObject>();

            commonList = r_BestMatchLogic.CommonLikedPagesDic[i_MyMatch];

            return commonList.Cast<Page>().ToList();
        }

        public ICollection<Group> FindCommonGroups(string i_MyMatch)
        {
            ICollection<FacebookObject> commonList = new List<FacebookObject>();

            commonList = r_BestMatchLogic.CommonGroupsDic[i_MyMatch];

            return commonList.Cast<Group>().ToList();
        }

        public ICollection<User> FindCommonFriends(string i_MyMatch)
        {
            ICollection<FacebookObject> commonList = new List<FacebookObject>();

            commonList = r_BestMatchLogic.CommonFriendsDic[i_MyMatch];

            return commonList.Cast<User>().ToList();
        }
    }
}
