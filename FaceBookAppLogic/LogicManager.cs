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
        public List<Photo> FetchPhotos(FacebookObjectCollection<Album> i_Albums)
        {
            List<Photo> photos = new List<Photo>();
            List<Photo> sortedPhotos;
            List<int> numberoflike = new List<int>();
            foreach (Album album in i_Albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    photos.Add(photo);
                    numberoflike.Add(photo.LikedBy.Count);
                }
            }

            
            sortedPhotos = photos.OrderBy(photo => -photo.LikedBy.Count).ToList();

            return sortedPhotos;
        }
    }
}
