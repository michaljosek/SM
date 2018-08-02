using SM.Infrastructure.DTO;
using SM.Infrastructure.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SM.Infrastructure.Services
{
    public interface IAdresService : IService
    {
        Task<IEnumerable<AdrAdmDTO>> GetAllAdmAsync();
        Task<IEnumerable<AdrBudDTO>> GetAllBudAsync();
        Task<IEnumerable<AdrKlaDTO>> GetAllKlaAsync();
        Task<IEnumerable<AdrLokDTO>> GetAllLokAsync();
        Task<IEnumerable<AdrOsiDTO>> GetAllOsiAsync();
        Task<IEnumerable<AdrUliDTO>> GetAllUliAsync();
        Task<IEnumerable<BranzaDTO>> GetAllBranzeAsync();
        Task<IEnumerable<OsobaDTO>> GetAllPracownicyAsync();
        Task<IEnumerable<AdrKlaDTO>> GetKlatkiAsync(string budynekId);
        Task<IEnumerable<AdrLokDTO>> GetLokaleAsync(string klatkaId, string budynekId);

        Task<PagedList<AdrAdmDTO>> BrowseAdmAsync(int pageIndex, int pageSize);

        Task<string> CreateStringAddress(string budynekId, string klatkaId, string lokalId);
        Task<string> FindAddressFromString(string adres);
    }
}
