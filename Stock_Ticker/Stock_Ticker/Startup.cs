using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Stock_Ticker.Startup))]
namespace Stock_Ticker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
