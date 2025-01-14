﻿using Reveal.Sdk;

namespace RevealSdk.Server.Reveal
{
    public class AuthenticationProvider : IRVAuthenticationProvider
    {
        public Task<IRVDataSourceCredential> ResolveCredentialsAsync(IRVUserContext userContext, RVDashboardDataSource dataSource)
        {
            IRVDataSourceCredential userCredential = new RVUsernamePasswordDataSourceCredential();
            if (dataSource is RVS3DataSource)
            {
                userCredential = new RVAmazonWebServicesCredentials("key", "secret");
            }
            return Task.FromResult(userCredential);
        }
    }
}
