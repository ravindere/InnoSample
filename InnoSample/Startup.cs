using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InnoSample.Startup))]
namespace InnoSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
