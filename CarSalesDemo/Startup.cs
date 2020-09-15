using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarSalesDemo.Startup))]
namespace CarSalesDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
