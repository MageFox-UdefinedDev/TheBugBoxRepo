namespace BugBox.Core
{
    internal static class Endpoints
    {
        private static string BASE_URI = @"http://localhost/BugServer/api/";
        public static string GET_PEOPLE = BASE_URI + "People";
        public static string FIND_PERSON = BASE_URI + "People/{0}";
        public static string ADD_PERSON = BASE_URI + "People";
        public static string GET_TRAPS = BASE_URI + "TRAPs";
        public static string ADD_TRAP = BASE_URI + "TRAPs";
        public static string FIND_TRAP = BASE_URI + "TRAPs/{0}";
    }
}