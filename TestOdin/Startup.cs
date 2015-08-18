using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestOdin.Startup))]
namespace TestOdin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

        }
    }
}
