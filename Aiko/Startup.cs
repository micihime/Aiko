using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aiko.Startup))]
namespace Aiko
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
