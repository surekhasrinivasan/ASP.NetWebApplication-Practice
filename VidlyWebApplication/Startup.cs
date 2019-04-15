using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyWebApplication.Startup))]
namespace VidlyWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
