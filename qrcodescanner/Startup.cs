using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(qrcodescanner.Startup))]
namespace qrcodescanner
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
