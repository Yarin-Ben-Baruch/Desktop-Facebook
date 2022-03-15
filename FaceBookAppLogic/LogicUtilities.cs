using System.Collections.Generic;
using System.Linq;

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
    }
}
