using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Dacnsoft.Admin.Configuration;

namespace Dacnsoft.Admin.Web.Host.Startup
{
    [DependsOn(
       typeof(AdminWebCoreModule))]
    public class AdminWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AdminWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AdminWebHostModule).GetAssembly());
        }
    }
}
