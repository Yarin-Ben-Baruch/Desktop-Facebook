using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace FaceBookAppLogic
{
    public class LogicBestFriend
    {
        public List<Photo> FetchPhotos(FacebookObjectCollection<Album> i_Albums)
        {
            List<Photo> photos = new List<Photo>();
            List<Photo> sortedPhotos;

            foreach (Album album in i_Albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    photos.Add(photo);
                }
            }

            sortedPhotos = photos.OrderBy(photo => -photo.LikedBy.Count).ToList();

            return sortedPhotos;
        }

        public LinkedList<User> GetMostLikesOnPostsByUsers(FacebookObjectCollection<Post> i_Post)
        {
            List<Post> posts = new List<Post>();
            Dictionary<User, int> usersMostLikes = new Dictionary<User, int>();
            LinkedList<User> sortedUsers = new LinkedList<User>();

            foreach (Post post in i_Post)
            {
                foreach (User user in post.LikedBy)
                {
                    if (usersMostLikes.ContainsKey(user))
                    {
                        usersMostLikes[user] += 1;
                    }
                    else
                    {
                        usersMostLikes.Add(user, 1);
                    }
                }
            }

            IOrderedEnumerable<KeyValuePair<User, int>> orderDic = usersMostLikes.OrderBy(key => key.Value);

            foreach (KeyValuePair<User, int> user in orderDic)
            {
                sortedUsers.Append(user.Key);
            }

            return sortedUsers;
        }

        public LinkedList<string> GetMostLikesOnPhotosByUsers(FacebookObjectCollection<Album> i_Albums)
        {
            List<Photo> photos = FetchPhotos(i_Albums);
            Dictionary<string, int> usersMostLikes = new Dictionary<string, int>();

            foreach (Photo photo in photos)
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

            return orderUserById(usersMostLikes);
        }

        private LinkedList<T> orderUserById<T>(Dictionary<T, int> i_UsersToOrder)
        {
            LinkedList<T> sortedUsers = new LinkedList<T>();
            IOrderedEnumerable<KeyValuePair<T, int>> orderDic = i_UsersToOrder.OrderBy(key => -key.Value);

            foreach (KeyValuePair<T, int> user in orderDic)
            {
                sortedUsers.AddLast(user.Key);
            }

            return sortedUsers;
        }
    }
}
