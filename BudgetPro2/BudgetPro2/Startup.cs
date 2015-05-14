using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BudgetPro2.Startup))]
namespace BudgetPro2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
