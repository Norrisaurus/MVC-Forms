using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcForms.Startup))]
namespace MvcForms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
