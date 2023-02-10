using System.Web;
using System.Web.Mvc;

namespace MVC_Application_Eleven___Part_Assignment
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
