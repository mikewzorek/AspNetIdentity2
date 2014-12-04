using Owin;

namespace AspNetIdentity.GroupBasedPermissions
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
