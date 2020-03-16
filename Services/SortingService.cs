using NLog;
using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Reflection;
using System.Text;

namespace University.Services
{
    public class SortingService
    {
        private StringBuilder orderQueryBuilder;
        private static Logger logger;
        public SortingService()
        {
            orderQueryBuilder = new StringBuilder();
            logger = LogManager.GetCurrentClassLogger();
        }
        public IQueryable<ApplicationUserEntity> Sort(IQueryable<ApplicationUserEntity> objectsForSort, string orderByQueryString)
        {
            try
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
            catch (Exception exception)
            {
                logger.Error(exception);
                throw;
            }
        }
    }
}
