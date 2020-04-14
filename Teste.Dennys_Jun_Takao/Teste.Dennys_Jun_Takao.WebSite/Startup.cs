using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Teste.Dennys_Jun_Takao.WebSite.Startup))]
namespace Teste.Dennys_Jun_Takao.WebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
