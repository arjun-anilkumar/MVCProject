using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Action_Filters_WKSP.Startup))]
namespace Action_Filters_WKSP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
