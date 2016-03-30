using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewsOnlineMM.Web.Startup))]
namespace NewsOnlineMM.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
