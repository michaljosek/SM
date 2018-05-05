using SM.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SM.Core.Repositories
{
    public interface IAdministracjeRepository : IRepository
    {
        Task<IEnumerable<AdrAdm>> GetAllAdmAsync();
        Task<IEnumerable<AdrBud>> GetAllBudAsync();
        Task<IEnumerable<AdrKla>> GetAllKlaAsync();
        Task<IEnumerable<AdrLok>> GetAllLokAsync();
        Task<IEnumerable<AdrOsi>> GetAllOsiAsync();
        Task<IEnumerable<AdrUli>> GetAllUliAsync();
        Task<IEnumerable<Branza>> GetAllBranzeAsync();
        Task<IEnumerable<Osoba>> GetAllPracownicyAsync();
        Task<IEnumerable<AdrKla>> GetKlatkiAsync(string budynekId);
        Task<IEnumerable<AdrLok>> GetLokaleAsync(string klatkaId, string budynekId);

        Task<AdrBud> GetBudynek(int budynekId);
        Task<AdrBud> GetBudynek(string budynekId);
    }
}
