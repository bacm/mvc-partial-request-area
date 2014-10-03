using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc_partial_areas.Startup))]
namespace mvc_partial_areas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
