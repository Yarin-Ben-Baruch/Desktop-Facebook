using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace FaceBookAppLogic
{
    public class LogicBestFriend
    {
        public IDictionary<string, int> GetMostLikesOnPostsByUsers(FacebookObjectCollection<Post> i_CollectionOfPostsToCheck)
        {
            ICollection<Post> posts = new List<Post>();
            IDictionary<string, int> usersMostLikes = new Dictionary<string, int>();
            ICollection<User> sortedUsers = new LinkedList<User>();

            foreach (Post post in i_CollectionOfPostsToCheck)
            {
                foreach (User user in post.LikedBy)
                {
                    if (usersMostLikes.ContainsKey(user.Id))
                    {
                        usersMostLikes[user.Id] += 1;
                    }
                    else
                    {
                        usersMostLikes.Add(user.Id, 1);
                    }
                }
            }

            return usersMostLikes;
        }

        public IDictionary<string, int> GetMostLikesOnPhotosByUsers(FacebookObjectCollection<Album> i_CollectionOfAlbumsToCheck)
        {
            ICollection<Photo> photosToCheck = FetchPhotos(i_CollectionOfAlbumsToCheck);
            IDictionary<string, int> usersMostLikes = new Dictionary<string, int>();

            foreach (Photo photo in photosToCheck)
            {
                foreach (User user in photo.LikedBy)
                {
                    if (usersMostLikes.ContainsKey(user.Id))
                    {
                        usersMostLikes[user.Id] += 1;
                    }
                    else
                    {
                        usersMostLikes.Add(user.Id, 1);
                    }
                }
            }

            return usersMostLikes;
        }

        public IDictionary<string, int> GetMostCommentsOnPhotosByUsers(FacebookObjectCollection<Album> i_Albums)
        {
            ICollection<Photo> photos = FetchPhotos(i_Albums);
            IDictionary<string, int> usersMostLikes = new Dictionary<string, int>();
            User currentUser;

            foreach (Photo photo in photos)
            {
                foreach (Comment comment in photo.Comments)
                {
                    currentUser = comment.From;

                    if (usersMostLikes.ContainsKey(currentUser.Id))
                    {
                        usersMostLikes[currentUser.Id] += 1;
                    }
                    else
                    {
                        usersMostLikes.Add(currentUser.Id, 1);
                    }
                }
            }

            return usersMostLikes;
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
    }
}
