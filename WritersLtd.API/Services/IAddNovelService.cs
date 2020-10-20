using System.Threading.Tasks;
using WritersLtd.Core.Entities;

namespace WritersLtd.API.Services
{
    public interface IAddNovelService
    {
        Task ExecuteAsync(Novel novel);
    }
}