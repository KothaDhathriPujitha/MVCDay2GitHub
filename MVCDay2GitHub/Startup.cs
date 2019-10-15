using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCDay2GitHub.Startup))]
namespace MVCDay2GitHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
