using Microsoft.AspNetCore.Identity;
using System;

namespace University
{
    public class ApplicationUserEntity : IdentityUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime RegisteredDate { get; set; }
    }
}
