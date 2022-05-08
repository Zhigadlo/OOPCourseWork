namespace RouteSystem.Users
{
    /// <summary>
    /// static class that contains some validation regular expressions
    /// </summary>
    public static class Validation
    {
        public static string RegexForLogin = @"^[a-zA-Z][a-zA-Z0-9]{5,12}$";
        public static string RegexForPassword = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,20}$";
    }
}
