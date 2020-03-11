using System.Threading.Tasks;
using University.Models;

namespace University.Interfaces
{
    public interface IAuthentificationService
    {
        //Task<bool> RegisterUser(RegistrationModel registerUserData);
        Task<bool> ValidateUser(LoginModel userForLogin);
        Task<string> GenerateToken(LoginModel userForLogin);
    }
}
