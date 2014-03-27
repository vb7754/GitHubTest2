using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHubTest2.Web.Startup))]
namespace GitHubTest2.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
