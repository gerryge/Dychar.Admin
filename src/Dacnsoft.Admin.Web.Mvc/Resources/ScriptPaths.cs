using Abp.Dependency;
using Abp.Extensions;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Dacnsoft.Admin.Web.Resources
{
    public class ScriptPaths : ISingletonDependency
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        private readonly ConcurrentDictionary<string, string> _scriptPaths;

        public ScriptPaths(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            _scriptPaths = new ConcurrentDictionary<string, string>();
        }

        #region jQuery Validation

        public string JQuery_Validation_Localization
        {
            get
            {
                return _scriptPaths.GetOrAdd("jquery-validation#" + CultureInfo.CurrentUICulture.Name, k =>
                {
                    var path = GetLocalizationFileForjQueryValidationOrNull(CultureInfo.CurrentUICulture.Name.ToLower().Replace("-", "_"))
                           ?? GetLocalizationFileForjQueryValidationOrNull(CultureInfo.CurrentUICulture.Name.Left(2).ToLower())
                           ?? @"lib/jquery-validation/src/localization/messages_zh.js";

                    return "/" + path;
                });
            }
        }

        private string GetLocalizationFileForjQueryValidationOrNull(string cultureCode)
        {
            try
            {
                var relativeFilePath = @"lib/jquery-validation/src/localization/messages_" + cultureCode + ".js";
                var physicalFilePath = GetPhysicalPath(relativeFilePath);
                if (File.Exists(physicalFilePath))
                {
                    return relativeFilePath;
                }
            }
            catch { }

            return null;
        }

        #endregion

        #region Helper methods

        private string GetPhysicalPath(string relativePath)
        {
            return Path.Combine(_hostingEnvironment.WebRootPath, relativePath);
        }

        #endregion
    }
}
