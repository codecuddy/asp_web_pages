using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(web_pages.Startup))]
namespace web_pages
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
