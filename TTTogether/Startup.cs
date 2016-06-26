using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TTTogether.Startup))]
namespace TTTogether
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
