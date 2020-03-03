using System.Text.RegularExpressions;

namespace University.Services
{
    public class EmailValidatorService
    {
        public static string emailRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        readonly Regex regualarExpressionEmailValidator;
        public EmailValidatorService()
        {
            this.regualarExpressionEmailValidator = new Regex(emailRegex);
        }
        public bool ValidateEmail(string emailForValidation)
        {
            if (regualarExpressionEmailValidator.IsMatch(emailForValidation))
                return true;
            return false;
        }
    }
}