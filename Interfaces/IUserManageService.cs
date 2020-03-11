using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using University.Models;

namespace University.Interfaces
{
    public interface IUserManageService
    {
        Task<PagingUsersModel> GetUsersAsync(PagingUsersParameters userParameters);
    }
}
