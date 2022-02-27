using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FaceBookAppLogic
{
    public class LogicFriendsCities
    {
        public ICollection<City> GetAllCities(FacebookObjectCollection<User> i_LoggedInUserFriends)
        {
            ICollection<City> allCities = new HashSet<City>();

            foreach (User user in i_LoggedInUserFriends)
            {
                if (user.Location != null)
                {
                    allCities.Add(user.Location);
                }
            }

            return allCities;
        }

        public ICollection<User> GetAllUsersInCity(FacebookObjectCollection<User> i_LoggedInUserFriends, City i_SelectedCity)
        {
            ICollection<User> allUsersInSelectedCity = new List<User>();

            foreach (User user in i_LoggedInUserFriends)
            {
                if (user.Location == i_SelectedCity)
                {
                    allUsersInSelectedCity.Add(user);
                }
            }

            return allUsersInSelectedCity;
        }
    }
}
