using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MapGallery.Web.Startup))]
namespace MapGallery.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
