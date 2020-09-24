using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SchoolInfoManager.Startup))]
namespace SchoolInfoManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
