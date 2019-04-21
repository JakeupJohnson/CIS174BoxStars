using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BoxStars.Web.Startup))]
namespace BoxStars.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
