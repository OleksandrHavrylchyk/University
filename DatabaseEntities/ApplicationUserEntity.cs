using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace University
{
    public class ApplicationUserEntity : IdentityUser
    {
        [EmailAddress]
        public override string Email { get; set; }
    }
}
