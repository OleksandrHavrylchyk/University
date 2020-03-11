using System.Collections.Generic;


namespace University.Models
{
    public class PagingUsersModel
    {
        public IEnumerable<ApplicationUserEntity> Users { get; set; }
        public PagingModel PagesModel { get; set; }
    }
}
