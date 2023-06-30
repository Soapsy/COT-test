using TestCompany.Handlers;
using TestCompany.Web;
using System.Web.Configuration;

namespace TestCompany.Services
{
    public class AppFrameworkConfig
    {

        public virtual void Initialize()
        {
            ApplicationServices.FrameworkAppName = "Names";
            ApplicationServices.Version = "8.9.24.0";
            ApplicationServices.HostVersion = "1.2.5.0";
            var compilation = ((CompilationSection)(WebConfigurationManager.GetSection("system.web/compilation")));
            var releaseMode = !compilation.Debug;
            AquariumExtenderBase.EnableMinifiedScript = releaseMode;
            AquariumExtenderBase.EnableCombinedScript = releaseMode;
            ApplicationServices.EnableMinifiedCss = releaseMode;
            ApplicationServices.EnableCombinedCss = releaseMode;
            ApplicationServicesBase.AuthorizationIsSupported = false;
            BlobFactoryConfig.Initialize();
        }
    }
}
