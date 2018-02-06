using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApi.MVC.Startup))]
namespace WebApi.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
