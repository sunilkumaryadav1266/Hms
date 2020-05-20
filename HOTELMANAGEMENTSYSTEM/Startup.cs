using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HOTELMANAGEMENTSYSTEM.Startup))]
namespace HOTELMANAGEMENTSYSTEM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
