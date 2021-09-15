using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_7409Summative.Startup))]
namespace _7409Summative
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
