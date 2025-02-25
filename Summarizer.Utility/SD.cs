namespace Summarizer.Utility
{
    public static class SD
    {
        public const string Role_User = "User";
        public const string Role_Admin = "Admin";
        public const string Role_Director = "Director";
        public const string Role_Legal = "Legal";


        public static readonly List<string> contractType = new()
        {
            "Purchasing Good",
            "Service",
            "Leasing"
        };

        public static readonly List<string> currency = new()
        {
            "GEL",
            "USD",
            "EURO",
            "TL"
        };

        public static readonly List<string> department = new()
        {
            "IDS",
            "Finance",
            "HR",
            "Logistic",
            "Sales"
        };
    }
}
