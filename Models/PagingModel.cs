using System;


namespace University.Models
{
    public class PagingModel
    {
        public int PageNumber { get; private set; }
        public int TotalUsers { get; private set; }

        public PagingModel(int userCount, int pageNumber)
        {
            PageNumber = pageNumber;
            TotalUsers = userCount;
        }
    }
}
