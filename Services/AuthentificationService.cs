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
using System.Security.Cryptography;

namespace University.Services
{
    public class AuthentificationService : IAuthentificationService
    {
        private static Logger logger;

        private readonly UserManager<ApplicationUserEntity> userManager;
        private readonly IConfiguration configuration;
        private ApplicationUserEntity user;

        public AuthentificationService(UserManager<ApplicationUserEntity> userManager, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.configuration = configuration;
            logger = LogManager.GetCurrentClassLogger();
        }

        public async Task<bool> ValidateUser(LoginModel userForAuth)
        {
            try
            {
                user = await userManager.FindByNameAsync(userForAuth.UserName);
                return (user != null && await userManager.CheckPasswordAsync(user, userForAuth.Password));
            }
            catch (Exception exception)
            {
                logger.Error(exception);
                throw;
            }
        }

        public async Task<string> GenerateToken(string email)
        {
            try
            {
                var user = await userManager.FindByEmailAsync(email);
                var signingCredentials = GetSigningCredentials();
                var claims = await GetClaims(user);
                var tokenOptions = GenerateTokenOptions(signingCredentials, claims);

                return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
            }
            catch (Exception exception)
            {
                logger.Error(exception);
                throw;
            }
        }
        public string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }

        public ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
        {
            var jwtSettings = configuration.GetSection("JwtSettings");
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                ValidIssuer = jwtSettings.GetSection("validIssuer").Value,
                ValidAudience = jwtSettings.GetSection("validAudience").Value,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(configuration["Jwt:Key"])),
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;
            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out securityToken);
            var jwtSecurityToken = securityToken as JwtSecurityToken;
            if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
                throw new SecurityTokenException("Invalid token");

            return principal;
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
