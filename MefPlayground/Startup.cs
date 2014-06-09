using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MefPlayground.Startup))]
namespace MefPlayground
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
