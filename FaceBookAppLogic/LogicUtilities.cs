using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace FaceBookAppLogic
{
    public class LogicUtilities
    {
        internal ICollection<T> OrderDictionaryByValueReverse<T>(IDictionary<T, int> i_UsersToOrder)
        {
            ICollection<T> sortedUsers = new LinkedList<T>();
            IOrderedEnumerable<KeyValuePair<T, int>> orderDic = i_UsersToOrder.OrderBy(key => -key.Value);

            foreach (KeyValuePair<T, int> user in orderDic)
            {
                sortedUsers.Add(user.Key);
            }

            return sortedUsers;
        }

        internal ICollection<User> ConvertIdToUser(ICollection<string> i_UserIdList, ICollection<User> i_FriendsList)
        {
            ICollection<User> sortedUsers = new LinkedList<User>();

            foreach (string userId in i_UserIdList)
            {
                foreach (User user in i_FriendsList)
                {
                    if (user.Id.Equals(userId))
                    {
                        sortedUsers.Add(user);
                    }
                }
            }

            return sortedUsers;
        }
    }
}
