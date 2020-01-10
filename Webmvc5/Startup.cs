using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Webmvc5.Startup))]
namespace Webmvc5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
