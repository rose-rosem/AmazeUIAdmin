using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewStaffWeb.Startup))]
namespace NewStaffWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
