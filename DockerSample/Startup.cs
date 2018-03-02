using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DockerSample.Startup))]
namespace DockerSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
