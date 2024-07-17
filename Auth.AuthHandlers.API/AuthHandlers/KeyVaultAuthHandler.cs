using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using System.Text.Encodings.Web;

namespace Auth.AuthHandlers.API.Handlers
{
    public class KeyVaultAuthHandler : AuthenticationHandler<KeyVaultAuthHandlerOptions>
    {
        public KeyVaultAuthHandler(
            IOptionsMonitor<KeyVaultAuthHandlerOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder) : base(options, logger, encoder)
        {
            
        }
        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            throw new NotImplementedException();
        
        }
    }

    public class KeyVaultAuthHandlerOptions : AuthenticationSchemeOptions
    {
        public string APIKey { get; set; } = string.Empty;
    }

    public class KeyVaultAuthDefaults
    {
        public const string APIAuthScheme = "KeyVaultAuthScheme";
    }
}