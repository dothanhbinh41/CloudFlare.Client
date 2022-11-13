using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CloudFlare.Client.Api.Parameters.Endpoints;
using CloudFlare.Client.Api.Result;
using CloudFlare.Client.Api.Zones.Settings;
using CloudFlare.Client.Contexts;

namespace CloudFlare.Client.Client.Zones
{
    public class Settings : ApiContextBase<IConnection>, ISettings
    {
        public const string Base = "settings";
        public Settings(IConnection connection) : base(connection)
        {
        }

        public async Task<CloudFlareResult<SettingSsl>> GetSslAsync(string zoneId, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{ZoneEndpoints.Base}/{zoneId}/{Settings.Base}/ssl";
            return await Connection.GetAsync<SettingSsl>(requestUri, cancellationToken).ConfigureAwait(false);
        }

        public async Task<CloudFlareResult<SettingSsl>> UpdateSslAsync(string zoneId, ModifiedSettingSsl ssl, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{ZoneEndpoints.Base}/{zoneId}/{Settings.Base}/ssl";
            return await Connection.PatchAsync<SettingSsl, ModifiedSettingSsl>(requestUri, ssl, cancellationToken).ConfigureAwait(false);
        }
    }
}
