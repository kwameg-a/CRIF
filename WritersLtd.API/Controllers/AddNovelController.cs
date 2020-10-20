using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WritersLtd.API.Services;
using WritersLtd.Core.Entities;

namespace WritersLtd.API.Controllers
{
    public class AddNovelController : BaseController
    {
        private readonly IAddNovelService _addNovelService;

        public AddNovelController(IAddNovelService addNovelService) => _addNovelService = addNovelService;      

        [HttpPost("novels")]
        public async Task<string> PostNovel(Novel novel)
        {
            await _addNovelService.ExecuteAsync(novel);
            return "A new novel has been added";
        }
    }
}
