using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using University.Models;
using University.Interfaces;
using NLog;

namespace University.Services
{
    public class AuthentificationService : IAuthentificationService
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        private readonly UserManager<ApplicationUserEntity> userManager;
        private readonly IConfiguration configuration;
        private ApplicationUserEntity user;

        public AuthentificationService(UserManager<ApplicationUserEntity> userManager, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.configuration = configuration;
        }

        public async Task<bool> ValidateUser(LoginModel userForAuth)
        {
            //logger.Info($"The user with id {user.Id} and name {user.UserName} is authorized");
            user = await userManager.FindByNameAsync(userForAuth.UserName);

            return (user != null && await userManager.CheckPasswordAsync(user, userForAuth.Password));
        }

        public async Task<string> GenerateToken(LoginModel userForAuth)
        {
            var user = await userManager.FindByNameAsync(userForAuth.UserName); 
            var signingCredentials = GetSigningCredentials();
            var claims = await GetClaims(user);
            var tokenOptions = GenerateTokenOptions(signingCredentials, claims);

            return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        }

        private SigningCredentials GetSigningCredentials()
        {
            var key = Encoding.UTF8.GetBytes(configuration["Jwt:Key"]);
            var secret = new SymmetricSecurityKey(key);

            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }

        private async Task<List<Claim>> GetClaims(ApplicationUserEntity user)
        {
            var claims = new List<Claim>{
                new Claim(ClaimTypes.Name, user.UserName)};
            var roles = await userManager.GetRolesAsync(user);

            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            return claims;
        }

        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            var jwtSettings = configuration.GetSection("JwtSettings");
            var tokenOptions = new JwtSecurityToken
            (
            issuer: jwtSettings.GetSection("validIssuer").Value,
            audience: jwtSettings.GetSection("validAudience").Value,
            claims: claims.ToArray(),
            expires: DateTime.UtcNow.AddMinutes(Convert.ToDouble(jwtSettings.GetSection("expires").Value)),
            signingCredentials: signingCredentials
            );

            return tokenOptions;
        }
    }
}
