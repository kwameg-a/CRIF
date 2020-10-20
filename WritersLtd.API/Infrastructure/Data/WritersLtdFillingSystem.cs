using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WritersLtd.API.Security;
using WritersLtd.Core.Entities;

namespace WritersLtd.API.Infrastructure.Data
{
    public class WritersLtdFillingSystem : IWritersLtdFillingSystem
    {
        private readonly IDictionary<int, Novel> _novelsStore = new Dictionary<int, Novel>();

        private readonly ICustomDataProtection _customDataProtection;

        public WritersLtdFillingSystem(ICustomDataProtection customDataProtection)
        {
            _customDataProtection = customDataProtection;
        }

        public IEnumerable<Novel> GetNovels()
        {
            return _novelsStore?.Select(x => new Novel
            {
                Id = x.Value.Id,
                Name = x.Value.Name
            });
        }

        public void AddNovel(Novel novel)
        {
            var id = _novelsStore.Keys.Any() ? _novelsStore.Keys.LastOrDefault() + 1 : 1;
            var name = Convert.ToBase64String(
                _customDataProtection.GetProtector.Protect(Encoding.ASCII.GetBytes(novel.Name)));

            _novelsStore[id] = new Novel { Id = id, Name = name };
        }
    }
}
