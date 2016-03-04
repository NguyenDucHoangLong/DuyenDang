using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(duyendang.Startup))]
namespace duyendang
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
