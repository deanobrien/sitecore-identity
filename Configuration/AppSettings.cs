using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.Plugin.Identity.WsFederation
{
    public class AppSettings
    {
        public static readonly string SectionName = "Sitecore:ExternalIdentityProviders:IdentityProviders:WsFederation";

        public WsFederationIdentityProvider WsFederationIdentityProvider { get; set; } = new WsFederationIdentityProvider();
    }
}
