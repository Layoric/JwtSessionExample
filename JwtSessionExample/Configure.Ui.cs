using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;

namespace JwtSessionExample
{
    public class ConfigureUi : IConfigureAppHost
    {
        public void Configure(IAppHost appHost)
        {
            // if wwwroot/ is empty, build Client App with 'npm run build'
            var svgDir = appHost.RootDirectory.GetDirectory("/svg") ?? appHost.ContentRootDirectory.GetDirectory("/public/svg");
            if (svgDir != null)
            {
                Svg.Load(svgDir);
            }
            Svg.CssFillColor["svg-icons"] = "#2f495e";
        }
    }
}

