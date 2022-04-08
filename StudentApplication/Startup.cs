using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentApplication.Startup))]
namespace StudentApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
