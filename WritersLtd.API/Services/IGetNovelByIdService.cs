using System.Threading.Tasks;
using WritersLtd.Core.Entities;

namespace WritersLtd.API.Services
{
    public interface IGetNovelByIdService
    {
        Task<Novel> ExecuteAsync(int id);
    }
}