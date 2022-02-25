using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FaceBookAppLogic
{
    public class LogicBestFriend
    {
        public LinkedList<User> GetMostLikesByUsers(FacebookObjectCollection<Album> i_Albums)
        {
            List<Photo> photos = FetchPhotos(i_Albums);
            Dictionary<User, int> usersMostLikes = new Dictionary<User, int>();
            LinkedList<User> sortedUsers = new LinkedList<User>();

            foreach (Photo photo in photos)
            {
                foreach (User user in photo.LikedBy)
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
    }
}
