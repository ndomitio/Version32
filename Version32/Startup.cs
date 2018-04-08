using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Version32.Startup))]
namespace Version32
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
