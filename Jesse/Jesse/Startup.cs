using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jesse.Startup))]
namespace Jesse
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
