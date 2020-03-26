using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Reflection;
using System.Text;
using University.Models;

namespace University.Services
{
    public class UserSortingService
    {
        private StringBuilder orderQueryBuilder;
        public UserSortingService()
        {
            orderQueryBuilder = new StringBuilder();
        }
        public IQueryable<UserDtoModel> Sort(IQueryable<UserDtoModel> objectsForSort, string orderByQueryString)
        {
            var orderParam = orderByQueryString.Trim().Split(',')[1];
            var orderName = orderByQueryString.Trim().Split(',')[0];
            var propertyInfos = typeof(ApplicationUserEntity).GetProperties(BindingFlags.Public |
                BindingFlags.Instance);
            var objectProperty = propertyInfos.FirstOrDefault(pi =>
                pi.Name.Equals(orderName, StringComparison.InvariantCultureIgnoreCase));
            var direction = orderParam.EndsWith("descend") ? "descending" : "ascending";

            orderQueryBuilder.Append($"{objectProperty.Name.ToString()} {direction},");
            var orderQuery = orderQueryBuilder.ToString().TrimEnd(',', ' ');

            return objectsForSort.OrderBy(orderQuery);
        }
    }
}
