using Microsoft.AspNetCore.DataProtection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WritersLtd.API.Infrastructure.Data;
using WritersLtd.Core.Entities;

namespace WritersLtd.API.Services
{
    public class AddNovelService : IAddNovelService
    {
        private readonly IWritersLtdFillingSystem _writersLtdFillingSystem;

        public AddNovelService(IWritersLtdFillingSystem writersLtdFillingSystem)
        {
            _writersLtdFillingSystem = writersLtdFillingSystem;
        }

        public async Task ExecuteAsync(Novel novel)
        {

            await Task.Run(() => _writersLtdFillingSystem.AddNovel(novel));
        }
    }
}
