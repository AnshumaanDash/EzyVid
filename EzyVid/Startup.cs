using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EzyVid.Startup))]
namespace EzyVid
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
