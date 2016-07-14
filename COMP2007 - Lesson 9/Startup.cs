using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(COMP2007___Lesson_9.Startup))]
namespace COMP2007___Lesson_9
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
