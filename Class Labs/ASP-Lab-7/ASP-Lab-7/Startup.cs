using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP_Lab_7.Startup))]
namespace ASP_Lab_7
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
