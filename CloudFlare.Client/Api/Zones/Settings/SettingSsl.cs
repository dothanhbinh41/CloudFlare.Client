using System;
using CloudFlare.Client.Enumerators;
using Newtonsoft.Json;

namespace CloudFlare.Client.Api.Zones.Settings
{
    public class SettingSsl
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("value")]
        public SSlValue Value { get; set; }

        [JsonProperty("certificate_status")]
        public string CertificateStatus { get; set; }

        [JsonProperty("modified_on")]
        public DateTime? ModifiedOn { get; set; }

        [JsonProperty("validation_errors")]
        public object[] ValidationErrors { get; set; }

        [JsonProperty("editable")]
        public bool Editable { get; set; }
    }
}