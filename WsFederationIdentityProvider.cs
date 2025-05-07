using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.Plugin.Identity.WsFederation
{
    public class WsFederationIdentityProvider : Sitecore.Plugin.IdentityProviders.IdentityProvider
    {
        public string Wtrealm { get; set; }

        public string MetadataAddress { get; set; }
    }
}
