using Microsoft.AspNetCore.Authentication;
using Auth.AuthHandlers.API.Handlers;

namespace Auth.AuthHandlers.API.AuthExtensions
{
    public static class KeyVaultAPIAuthExtension
    {
        public static AuthenticationBuilder AddKeyVaultAPIAuth(this AuthenticationBuilder builder, Action<KeyVaultAuthHandlerOptions> configureOptions)
        {
            return builder.AddScheme<KeyVaultAuthHandlerOptions, KeyVaultAuthHandler>(KeyVaultAuthDefaults.APIAuthScheme, configureOptions);
        }
    }
}