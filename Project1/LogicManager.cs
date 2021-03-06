using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class LogicManager
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

            sortedPhotos = photos.OrderBy(photo => photo.LikedBy.Count).ToList();

            return sortedPhotos;
        }
    }
}
