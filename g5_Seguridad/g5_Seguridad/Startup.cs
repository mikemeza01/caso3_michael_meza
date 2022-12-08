using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(g5_Seguridad.Startup))]
namespace g5_Seguridad
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
