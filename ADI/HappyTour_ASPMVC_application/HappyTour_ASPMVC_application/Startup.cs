using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HappyTour_ASPMVC_application.Startup))]
namespace HappyTour_ASPMVC_application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
