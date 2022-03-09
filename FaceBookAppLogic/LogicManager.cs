using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace FaceBookAppLogic
{
    public class LogicManager
    {
        private readonly LogicBestMatch r_BestMatchLogic;
        private readonly LogicLoyalFriend r_BestFriendLogic;
        private readonly LogicFriendsCities r_FriendsCities;
        private readonly LogicUtilities r_LogicUtilities;

        public LogicManager()
        {
            r_BestFriendLogic = new LogicLoyalFriend();
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

            return allPhotos.OrderBy(photo => -photo.LikedBy.Count).ToList();
        }

        public ICollection<User> GetMyLoyalFriends(User i_LoggedInUser)
        {
            IDictionary<User, int> myLoyalFriendsIdDic = r_BestFriendLogic.GetMyLoyalFriends(i_LoggedInUser);

            return r_LogicUtilities.OrderDictionaryByValueReverse(myLoyalFriendsIdDic);
        }

        public ICollection<User> GetMostLikesOnPhotosByUsers()
        {
            IDictionary<User, int> mostLikesPhotosUserIdDic = r_BestFriendLogic.MostLikesOnPhotos;

            return r_LogicUtilities.OrderDictionaryByValueReverse(mostLikesPhotosUserIdDic);
        }

        public ICollection<User> GetMostCommentsOnPhotosByUsers()
        {
            IDictionary<User, int> mostLikesPhotosUserIdDic = r_BestFriendLogic.MostCommentsOnPhotos;

            return r_LogicUtilities.OrderDictionaryByValueReverse(mostLikesPhotosUserIdDic);
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
