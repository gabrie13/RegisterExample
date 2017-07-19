using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CalculationTest.Startup))]
namespace CalculationTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
