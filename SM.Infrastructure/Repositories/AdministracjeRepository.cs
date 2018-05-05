using SM.Core.Repositories;
using SM.Infrastructure.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SM.Core.Domain;

namespace SM.Infrastructure.Repositories
{
    public class AdministracjeRepository : IAdministracjeRepository
    {
        private readonly SMContext _context;

        public AdministracjeRepository(SMContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AdrAdm>> GetAllAdmAsync()
            => await Task.FromResult(_context.AdrAdms.ToList());

        public async Task<IEnumerable<AdrBud>> GetAllBudAsync()
            => await Task.FromResult(_context.AdrBuds.ToList());

        public async Task<IEnumerable<AdrKla>> GetAllKlaAsync()
            => await Task.FromResult(_context.AdrKlas.ToList());

        public async Task<IEnumerable<AdrLok>> GetAllLokAsync()
            => await Task.FromResult(_context.AdrLoks.ToList());

        public async Task<IEnumerable<AdrOsi>> GetAllOsiAsync()
            => await Task.FromResult(_context.AdrOsis.ToList());

        public async Task<IEnumerable<AdrUli>> GetAllUliAsync()
            => await Task.FromResult(_context.AdrUlis.ToList());

        public async Task<IEnumerable<Branza>> GetAllBranzeAsync()
            => await Task.FromResult(_context.Branzas.ToList());

        public async Task<IEnumerable<Osoba>> GetAllPracownicyAsync()
            => await Task.FromResult(_context.Osobas.ToList());

        public async Task<IEnumerable<AdrKla>> GetKlatkiAsync(string budynekId)
            => await Task.FromResult(_context.AdrKlas.AsQueryable().Where(s => s.id_budy == budynekId).ToList());

        public async Task<IEnumerable<AdrLok>> GetLokaleAsync(string klatkaId, string budynekId)
            => await Task.FromResult(_context.AdrLoks.AsQueryable().Where(s => s.id_klat.Trim() == klatkaId && s.id_budy == budynekId).ToList());

        public async Task<AdrBud> GetBudynek(int budynekId)
            => await Task.FromResult(_context.AdrBuds.AsQueryable().FirstOrDefault(s => s.AdrBudId == budynekId));

        public async Task<AdrBud> GetBudynek(string budynekId)
            => await Task.FromResult(_context.AdrBuds.AsQueryable().FirstOrDefault(s => s.id_budy == budynekId));

    }
}
