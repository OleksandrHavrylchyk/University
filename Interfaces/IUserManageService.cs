using System.Threading.Tasks;
using University.Models;

namespace University.Interfaces
{
    public interface IUserManageService
    {
        Task<PagingUsersModel> GetUsersAsync(PagingUsersParameters userParameters);
        Task<UserDtoModel> EditUserAsync(UserDtoModel userForChange);
    }
}
