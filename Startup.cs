using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcNorthwind.Startup))]
namespace MvcNorthwind
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
