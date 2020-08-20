using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JSP.Startup))]
namespace JSP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
