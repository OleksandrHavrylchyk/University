using System.Threading.Tasks;
using University.Models;

namespace University.Interfaces
{
    public interface IFacebookAuthenticationService
    {
            Task RegisterFacebookUser(FacebookLoginModel facebookUser);
            Task<bool> ValidateFacebookToken(FacebookLoginModel facebookUser);
            Task<AuthorizedUserModel> LoginFacebookUser(FacebookLoginModel facebookUser);
    }
}
