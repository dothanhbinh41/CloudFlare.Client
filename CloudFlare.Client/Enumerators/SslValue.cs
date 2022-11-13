using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json.Converters; 
using Newtonsoft.Json;

namespace CloudFlare.Client.Enumerators
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SSlValue
    {
        [EnumMember(Value = "off")]
        Off, 

        [EnumMember(Value = "flexible")]
        Flexible,

        [EnumMember(Value = "full")]
        Full,

        [EnumMember(Value = "strict")]
        FullStrict
    }
}
