namespace University.Models
{
    public class AuthorizedUserModel
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public bool IsSubscribedOncourses { get; set; } = false;
    }
}
