using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.Configuration;

namespace WritersLtd.API.Security
{
    public class CustomDataProtection : ICustomDataProtection
    {
        private readonly IDataProtector _protector;

        public CustomDataProtection(IDataProtectionProvider dataProtectionProvider, IConfiguration configuration)
        {
            _protector = dataProtectionProvider.CreateProtector(configuration.GetValue<string>("EncryptionKey"));
        }

        public IDataProtector GetProtector => _protector;
    }
}
