using Abp.AutoMapper;
using Dacnsoft.Admin.Authentication.External;

namespace Dacnsoft.Admin.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
