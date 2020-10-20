using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WritersLtd.API.Filters;
using WritersLtd.API.Services;
using WritersLtd.Core.Entities;

namespace WritersLtd.API.Controllers
{
    public class GetNovelsController : BaseController
    {
        private readonly IGetNovelsService _getNovelsService;

        public GetNovelsController(IGetNovelsService getNovelsService) => _getNovelsService = getNovelsService;

        [HttpGet("novels")]
        [ApiKeyAuthentication]
        public async Task<IEnumerable<Novel>> GetNovels([FromQuery] string apikey)
        {
            return await _getNovelsService.ExecuteAsync();
        }
    }
}
