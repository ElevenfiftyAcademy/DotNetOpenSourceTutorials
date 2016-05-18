using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DotNetOpenSourceTutorials.Startup))]
namespace DotNetOpenSourceTutorials
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
