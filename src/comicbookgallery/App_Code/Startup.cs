using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(comicbookgallery.Startup))]
namespace comicbookgallery
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
