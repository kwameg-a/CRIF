using System.Collections.Generic;
using System.Threading.Tasks;
using WritersLtd.Core.Entities;

namespace WritersLtd.API.Services
{
    public interface IGetNovelsService
    {
        Task<IEnumerable<Novel>> ExecuteAsync();
    }
}