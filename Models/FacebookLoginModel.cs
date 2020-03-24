using System;

namespace University.Models
{
    public class FacebookLoginModel
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public DateTime RegisteredDate { get; set; } = DateTime.Now;
    }
}
