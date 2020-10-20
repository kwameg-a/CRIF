using System.Collections.Generic;
using WritersLtd.Core.Entities;

namespace WritersLtd.API.Infrastructure.Data
{
    public interface IWritersLtdFillingSystem
    {
        void AddNovel(Novel novel);
        IEnumerable<Novel> GetNovels();
    }
}