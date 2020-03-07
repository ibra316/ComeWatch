using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ComeWatch.Startup))]
namespace ComeWatch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
