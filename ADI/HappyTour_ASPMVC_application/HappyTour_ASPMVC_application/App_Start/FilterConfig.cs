using System.Web;
using System.Web.Mvc;

namespace HappyTour_ASPMVC_application
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
