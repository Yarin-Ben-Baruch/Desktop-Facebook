using System;
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

        public LinkedList<User> GetMostLikesOnPhotosByUsers(FacebookObjectCollection<Album> i_Albums)
        {
            return r_BestFriendLogic.GetMostLikesOnPhotosByUsers(i_Albums);
        }

        public LinkedList<User> GetMostLikesOnPostByUsers(FacebookObjectCollection<Post> i_Post)
        {
            return r_BestFriendLogic.GetMostLikesOnPostsByUsers(i_Post);
        }

        // All categories together
        public List<User> FindBestMatch(FacebookObjectCollection<User> i_LoggedInUserFriends, User i_LoggedInUser)
        {
            return r_BestMatchLogic.FindBestMatch(i_LoggedInUserFriends, i_LoggedInUser);
        }

        // Pages || Groups || Friends
        // public List<T> FindCommonBetweenOneCategory<T>(FacebookObjectCollection<T> i_CollectionOfLoginUser, FacebookObjectCollection<T> i_CollctionOfMatchUser)
        // {
        //     //return r_BestMatchLogic.FindCommonBetweenTwoLists(i_CollectionOfLoginUser, i_CollctionOfMatchUser);
        // }

    }
}
