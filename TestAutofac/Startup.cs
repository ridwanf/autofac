using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestAutofac.Startup))]
namespace TestAutofac
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
