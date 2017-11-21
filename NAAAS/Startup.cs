using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NAAAS.Startup))]
namespace NAAAS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
