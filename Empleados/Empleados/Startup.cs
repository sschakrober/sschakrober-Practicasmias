using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Empleados.Startup))]
namespace Empleados
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
