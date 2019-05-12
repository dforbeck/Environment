using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Environment.WebMVC.Startup))]
namespace Environment.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
