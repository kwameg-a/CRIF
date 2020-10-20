using Microsoft.AspNetCore.DataProtection;

namespace WritersLtd.API.Security
{
    public interface ICustomDataProtection
    {
        IDataProtector GetProtector { get; }
    }
}