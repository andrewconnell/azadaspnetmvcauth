using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SampleMvcAzAuth.Startup))]

namespace SampleMvcAzAuth {
  public partial class Startup {
    public void Configuration(IAppBuilder app)
    {
      ConfigureAuth(app);
    }
  }
}