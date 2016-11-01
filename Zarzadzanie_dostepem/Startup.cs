using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zarzadzanie_dostepem.Startup))]
namespace Zarzadzanie_dostepem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
