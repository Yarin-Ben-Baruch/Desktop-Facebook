using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FaceBookAppLogic
{
    public class FindLocation
    {
        public ISet<City> GetAllCities(FacebookObjectCollection<User> i_LoggedInUserFriends)
        {
            ISet<City> allCities = new HashSet<City>();

            foreach (User user in i_LoggedInUserFriends)
            {
                if (user.Location != null)
                {
                    allCities.Add(user.Location);
                }
            }

            return allCities;
        }

        public IList<User> GetAllUserInCity(FacebookObjectCollection<User> i_LoggedInUserFriends, City i_City)
        {
            IList<User> allUserInTheCity = new List<User>();

            foreach (User user in i_LoggedInUserFriends)
            {
                if (user.Location == i_City)
                {
                    allUserInTheCity.Add(user);
                }
            }

            return allUserInTheCity;
        }
    }
}
