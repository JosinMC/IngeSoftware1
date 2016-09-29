using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab_ASPNET.Startup))]
namespace Lab_ASPNET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
