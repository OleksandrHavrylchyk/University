namespace University.Models
{
    public class AuthorizedUserModel
    {
        public string Token { get; set; }
        public bool IsSubscribedOncourses { get; set; } = false;
    }
}
