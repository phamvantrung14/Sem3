using System.Web.Mvc;

namespace Code_First_Web_Application.Areas.AdminBostrap
{
    public class AdminBostrapAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "AdminBostrap";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "AdminBostrap_default",
                "AdminBostrap/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
               new[] { "Code_First_Web_Application.Areas.AdminBostrap.Controllers" }
            );
        }
    }
}