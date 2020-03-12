using System;

namespace University.Models
{
    public class RegistrationModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public DateTime RegisteredDate { get; set; } = DateTime.Now;
    }
}
