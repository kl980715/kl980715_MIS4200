using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(kl980715_MIS4200.Startup))]
namespace kl980715_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
