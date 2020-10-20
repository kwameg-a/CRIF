using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WritersLtd.API.Filters;
using WritersLtd.API.Services;
using WritersLtd.Core.Entities;

namespace WritersLtd.API.Controllers
{
    public class GetNovelDetailsController : BaseController
    {
        private readonly IGetNovelByIdService _getNovelByIdService;

        public GetNovelDetailsController(IGetNovelByIdService getNovelByIdService) =>
            _getNovelByIdService = getNovelByIdService;

        [HttpGet("novels/{id}")]
        public async Task<Novel> GetNovelById(int id)
        {
            return await _getNovelByIdService.ExecuteAsync(id);
        }
    }
}
