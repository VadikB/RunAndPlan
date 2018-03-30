using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RunAndPlanFirst.Startup))]
namespace RunAndPlanFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
