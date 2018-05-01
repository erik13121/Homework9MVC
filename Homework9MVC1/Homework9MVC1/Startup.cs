using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Homework9MVC1.Startup))]
namespace Homework9MVC1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
