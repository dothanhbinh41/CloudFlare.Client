using System;
using System.Collections.Generic;
using System.Text;
using CloudFlare.Client.Enumerators;
using Newtonsoft.Json;

namespace CloudFlare.Client.Api.Zones.Settings
{
    public class ModifiedSettingSsl
    {
        [JsonProperty("value")]
        public SSlValue Value { get; set; }
    }
}
