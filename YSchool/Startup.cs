using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YSchool.Startup))]
namespace YSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
