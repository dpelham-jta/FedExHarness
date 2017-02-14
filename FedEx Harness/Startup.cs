using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FedEx_Harness.Startup))]
namespace FedEx_Harness
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
