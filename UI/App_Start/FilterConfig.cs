using System.Web.Mvc;

namespace UI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new AuthorizeAttribute()); // Globally require authorization
            //filters.Add(new HandleErrorAttribute()); // Removed because elmah takes charge 
        }
    }
}