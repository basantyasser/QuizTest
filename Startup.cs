using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuizTest.Startup))]
namespace QuizTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
