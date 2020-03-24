using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace University.Models
{
    public abstract class PagingUserParametrsModel
    {
        const int maxPageSize = 15;
        public int PageNumber { get; set; } = 1;
        private int pageSize = 10;
        public int PageSize
        {
            get
            {
                return pageSize;
            }
            set
            {
                pageSize = (value > maxPageSize) ? maxPageSize : value;
            }
        }
    }
    public class PagingUsersParameters : PagingUserParametrsModel
    {
        public string SearchExpression { get; set; }
        public string OrderBy { get; set; }
    }
}
