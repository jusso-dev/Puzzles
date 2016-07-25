using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Puzzles.Startup))]
namespace Puzzles
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
