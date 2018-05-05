
using SM.Core.Domain;
using SM.Infrastructure.Paging;
using SM.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SM.Infrastructure.Services
{
    public interface IB07_zgloService : IService
    {
        Task<PagedList<B07_zgloDTO>> BrowseAsync(int pageIndex, int pageSize);
        Task<B07_zgloDTO> GetZgloAsync(int id);

        Task<int> AddAsync();
        Task RemoveAsync(int id);
        Task UpdateAsync(B07_zgloDTO zgloszenie, int id);
    }
}
