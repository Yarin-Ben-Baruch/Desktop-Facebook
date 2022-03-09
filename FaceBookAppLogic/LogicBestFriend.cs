using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace FaceBookAppLogic
{
    public class LogicBestFriend
    {
        //add to diagram aggrigation
        public IDictionary<string, int> MostLikesOnPhotos { get; set; }

        public IDictionary<string, int> MostLikesOnPosts { get; set; }

        public IDictionary<string, int> MostCommentsOnPhotos { get; set; }

        public LogicBestFriend()
        {
            MostLikesOnPhotos = new Dictionary<string, int>();
            MostLikesOnPosts = new Dictionary<string, int>();
            MostCommentsOnPhotos = new Dictionary<string, int>();
        }

        public IDictionary<string, int> GetMyLoyalFriends(User i_LoggedInUser)
        {
            IDictionary<string, int> myLoyalFriends;

            initMostCommentsOnPhotosByUsers(i_LoggedInUser.Albums);
            initMostLikesOnPhotosByUsers(i_LoggedInUser.Albums);
            //MostLikesOnPosts = getMostLikesOnPostsByUsers(i_LoggedInUser.Posts);

            myLoyalFriends = mergingDictionary(MostCommentsOnPhotos, MostLikesOnPhotos);
            //myLoyalFriends = mergingDictionary(myLoyalFriends, MostLikesOnPosts);

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

        //remvoce
        private void getMostLikesOnPostsByUsers(FacebookObjectCollection<Post> i_CollectionOfPostsToCheck)
        {
            ICollection<Post> posts = new List<Post>();

            foreach (Post post in i_CollectionOfPostsToCheck)
            {
                foreach (User user in post.LikedBy)
                {
                    if (MostLikesOnPosts.ContainsKey(user.Id))
                    {
                        MostLikesOnPosts[user.Id] += 1;
                    }
                    else
                    {
                        MostLikesOnPosts.Add(user.Id, 1);
                    }
                }
            }
        }

        private void initMostLikesOnPhotosByUsers(FacebookObjectCollection<Album> i_CollectionOfAlbumsToCheck)
        {
            ICollection<Photo> photosToCheck = FetchPhotos(i_CollectionOfAlbumsToCheck);

            foreach (Photo photo in photosToCheck)
            {
                foreach (User user in photo.LikedBy)
                {
                    if (MostLikesOnPhotos.ContainsKey(user.Id))
                    {
                        MostLikesOnPhotos[user.Id] += 1;
                    }
                    else
                    {
                        MostLikesOnPhotos.Add(user.Id, 1);
                    }
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

                    if (MostCommentsOnPhotos.ContainsKey(currentUser.Id))
                    {
                        MostCommentsOnPhotos[currentUser.Id] += 1;
                    }
                    else
                    {
                        MostCommentsOnPhotos.Add(currentUser.Id, 1);
                    }
                }
            }
        }

        private IDictionary<string, int> mergingDictionary(IDictionary<string, int> i_FirstDictionary, IDictionary<string, int> i_SecondDictionary)
        {
            IDictionary<string, int> mergeDictionary = new Dictionary<string, int>(i_FirstDictionary);
            ICollection<string> dictionaryKeys = i_SecondDictionary.Keys;

            foreach (string currentKey in dictionaryKeys)
            {
                if (i_FirstDictionary.ContainsKey(currentKey))
                {
                    mergeDictionary[currentKey] += i_SecondDictionary[currentKey];
                }
                else
                {
                    mergeDictionary.Add(currentKey, i_SecondDictionary[currentKey]);
                }
            }

            return mergeDictionary;
        }
    }
}
