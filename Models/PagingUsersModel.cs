using System.Collections.Generic;


namespace University.Models
{
    public class PagingUsersModel
    {
        public IEnumerable<UserDtoModel> Users { get; set; }
        public PagingModel PagesModel { get; set; }
    }
}
