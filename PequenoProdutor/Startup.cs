using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PequenoProdutor.Startup))]
namespace PequenoProdutor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
