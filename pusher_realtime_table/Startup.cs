using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pusher_realtime_table.Startup))]
namespace pusher_realtime_table
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
