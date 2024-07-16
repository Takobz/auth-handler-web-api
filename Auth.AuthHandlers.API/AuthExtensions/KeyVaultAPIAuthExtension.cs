namespace Auth.AuthHandlers.API.AuthExtensions
{
    public static class KeyVaultAPIAuthExtension
    {
        public static AuthenticationBuilder AddKeyVaultAPIAuth(this AuthenticationBuilder builder, string authenticationScheme, Action<KeyVaultAuthHandlerOptions> configureOptions)
        {
            return builder.AddScheme<KeyVaultAuthHandlerOptions, KeyVaultAuthHandler>(authenticationScheme, configureOptions);
        }
    }
}