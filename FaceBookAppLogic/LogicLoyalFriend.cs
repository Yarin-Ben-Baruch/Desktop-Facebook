using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FaceBookAppLogic
{
    public class LogicLoyalFriend
    {
         public IDictionary<User, int> MostLikesOnPhotos { get; set; }

        public IDictionary<User, int> MostCommentsOnPhotos { get; set; }

        public LogicLoyalFriend()
        {
            MostLikesOnPhotos = new Dictionary<User, int>();
            MostCommentsOnPhotos = new Dictionary<User, int>();
        }

        public IDictionary<User, int> GetMyLoyalFriends(User i_LoggedInUser)
        {
            IDictionary<User, int> myLoyalFriends;

            initMostCommentsOnPhotosByUsers(i_LoggedInUser.Albums);
            initMostLikesOnPhotosByUsers(i_LoggedInUser.Albums);

            myLoyalFriends = mergingDictionary(MostCommentsOnPhotos, MostLikesOnPhotos);

            return myLoyalFriends;
        }

        internal ICollection<Photo> FetchPhotos(FacebookObjectCollection<Album> i_Albums)
        {
            ICollection<Photo> photos = new List<Photo>();

            foreach (Album album in i_Albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    photos.Add(photo);
                }
            }

            return photos;
        }

        private void initMostLikesOnPhotosByUsers(FacebookObjectCollection<Album> i_CollectionOfAlbumsToCheck)
        {
            ICollection<Photo> photosToCheck = FetchPhotos(i_CollectionOfAlbumsToCheck);

            foreach (Photo photo in photosToCheck)
            {
                foreach (User currentUser in photo.LikedBy)
                {
                    addingValueToDict(currentUser, MostLikesOnPhotos, 1);
                }
            }
        }

        private void initMostCommentsOnPhotosByUsers(FacebookObjectCollection<Album> i_Albums)
        {
            ICollection<Photo> photos = FetchPhotos(i_Albums);
            User currentUser;

            foreach (Photo photo in photos)
            {
                foreach (Comment comment in photo.Comments)
                {
                    currentUser = comment.From;

                    addingValueToDict(currentUser, MostCommentsOnPhotos, 1);
                }
            }
        }

        private IDictionary<User, int> mergingDictionary(IDictionary<User, int> i_FirstDictionary, IDictionary<User, int> i_SecondDictionary)
        {
            IDictionary<User, int> mergeDictionary = new Dictionary<User, int>(i_FirstDictionary);
            ICollection<User> dictionaryKeys = i_SecondDictionary.Keys;

            foreach (User currentUser in dictionaryKeys)
            {
                addingValueToDict(currentUser, mergeDictionary, i_SecondDictionary[currentUser]);
            }

            return mergeDictionary;
        }

        private void addingValueToDict(User i_User, IDictionary<User, int> i_Dictionary, int i_ValueToAdd)
        {
            ICollection<User> keys = new List<User>(i_Dictionary.Keys);
            bool isNotExists = true;

            foreach (User user in keys)
            {
                if (user.Id.Equals(i_User.Id))
                {
                    i_Dictionary[user] += i_ValueToAdd;
                    isNotExists = false;
                }
            }

            if (isNotExists)
            {
                i_Dictionary.Add(i_User, i_ValueToAdd);
            }
        }
    }
}
