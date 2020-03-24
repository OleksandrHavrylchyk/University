using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using University.Interfaces;
using University.Migrations;
using University.Models;

namespace University.Services
{
    public class FacebookAuthenticationService : IFacebookAuthenticationService
    {
        private readonly HttpClient httpClient;
        private readonly IMapper mapper;
        private readonly IAuthentificationService authentificationService;
        private readonly ApplicationDbContext entityContext;
        private readonly UserManager<ApplicationUserEntity> userManager;
        private readonly AuthorizedUserModel authorizedUserModel;
        public FacebookAuthenticationService(IMapper mapper, ApplicationDbContext entityContext, UserManager<ApplicationUserEntity> userManager,
            IAuthentificationService authentificationService)
        {
            this.authentificationService = authentificationService;
            this.userManager = userManager;
            this.entityContext = entityContext;
            this.mapper = mapper;
            httpClient = new HttpClient();
            authorizedUserModel = new AuthorizedUserModel();
        }
        public async Task RegisterFacebookUser(FacebookLoginModel facebookUser)
        {
            var userIdentity = mapper.Map<ApplicationUserEntity>(facebookUser);
            entityContext.Users.Add(userIdentity);
            var confirmationToken = await userManager.GenerateEmailConfirmationTokenAsync(userIdentity);
            await entityContext.SaveChangesAsync();
            await userManager.AddToRoleAsync(userIdentity, "User");
            await userManager.ConfirmEmailAsync(userIdentity, confirmationToken);
        }
        public async Task<bool> ValidateFacebookToken(FacebookLoginModel facebookUser)
        {
            var appAccessTokenResponse = await httpClient.GetStringAsync($"https://graph.facebook.com/oauth/access_token?client_id=2814753781954441&client_secret=837cc4ab983d8c9c4a51da9ed50e470b&grant_type=client_credentials");
            var appAccessToken = JsonConvert.DeserializeObject<FacebookAppAccessToken>(appAccessTokenResponse);
            var userAccessTokenValidationResponse = await httpClient.GetStringAsync($"https://graph.facebook.com/debug_token?input_token={facebookUser.Token}&access_token={appAccessToken.AccessToken}");
            var userAccessTokenValidation = JsonConvert.DeserializeObject<FacebookUserAccessTokenValidation>(userAccessTokenValidationResponse);

            return userAccessTokenValidation.Data.IsValid;
        }
        public async Task<AuthorizedUserModel> LoginFacebookUser(FacebookLoginModel facebookUser)
        {
            var user = await userManager.FindByEmailAsync(facebookUser.Email);
            var refreshToken = authentificationService.GenerateRefreshToken();

            authorizedUserModel.Token = await authentificationService.GenerateToken(user.Email);
            authorizedUserModel.RefreshToken = refreshToken;

            await userManager.RemoveAuthenticationTokenAsync(user, "UniversityApp", "RefreshToken");
            await userManager.SetAuthenticationTokenAsync(user, "UniversityApp", "RefreshToken", refreshToken);

            return authorizedUserModel;
        }
    }
}
