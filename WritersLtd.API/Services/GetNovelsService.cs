using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WritersLtd.API.Infrastructure.Data;
using WritersLtd.Core.Entities;

namespace WritersLtd.API.Services
{
    public class GetNovelsService : IGetNovelsService
    {
        private readonly IWritersLtdFillingSystem _writersLtdFillingSystem;

        public GetNovelsService(IWritersLtdFillingSystem writersLtdFillingSystem)
        {
            _writersLtdFillingSystem = writersLtdFillingSystem;
        }

        public async Task<IEnumerable<Novel>> ExecuteAsync()
        {
            return await Task.Run(() => _writersLtdFillingSystem.GetNovels());
        }
    }
}
