using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Module_Calculator.Startup))]
namespace Module_Calculator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
