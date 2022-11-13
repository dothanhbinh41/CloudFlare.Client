using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using CloudFlare.Client.Api.Zones.Settings;
using CloudFlare.Client.Api.Result;

namespace CloudFlare.Client.Client.Zones
{
    public interface ISettings
    {
        Task<CloudFlareResult<SettingSsl>> GetSslAsync(string zoneId, CancellationToken cancellationToken = default);

        Task<CloudFlareResult<SettingSsl>> UpdateSslAsync(string zoneId, ModifiedSettingSsl ssl, CancellationToken cancellationToken = default);
    }
}
