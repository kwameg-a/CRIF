using System.Linq;
using System.Threading.Tasks;
using WritersLtd.API.Infrastructure.Data;
using WritersLtd.Core.Entities;

namespace WritersLtd.API.Services
{
    public class GetNovelByIdService : IGetNovelByIdService
    {
        private readonly IWritersLtdFillingSystem _writersLtdFillingSystem;

        public GetNovelByIdService(IWritersLtdFillingSystem writersLtdFillingSystem)
        {
            _writersLtdFillingSystem = writersLtdFillingSystem;
        }

        public async Task<Novel> ExecuteAsync(int id)
        {
            var novel = _writersLtdFillingSystem.GetNovels().Where(x => x.Id == id).FirstOrDefault();
            return await Task.Run(() => novel);
        }
    }
}
