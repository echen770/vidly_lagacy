using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vidly_lagacy.Startup))]
namespace vidly_lagacy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
