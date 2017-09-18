using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Viktor_Salnichenko_Lab1.Startup))]
namespace Viktor_Salnichenko_Lab1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
