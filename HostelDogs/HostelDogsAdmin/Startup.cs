using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HostelDogsAdmin.Startup))]
namespace HostelDogsAdmin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
