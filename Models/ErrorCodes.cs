namespace University.Models
{
    public enum ErrorCodes
    {
        Unauthorized = 401,
        InvalidEmail = 421,
        NoNewCourses = 422,
        NoCourses = 423,
        NotFoundCourses = 424,
        UserNotFound = 425,
        EmailConfirmError,
    }
}
