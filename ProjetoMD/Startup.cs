using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoMD.Startup))]
namespace ProjetoMD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
