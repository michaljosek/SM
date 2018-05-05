using SM.Core.Domain;
using SM.Core.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SM.Core.Repositories
{
    public interface IB07_zgloRepository : IRepository
    {
        Task<int> CountTotalAsync();
        Task<IEnumerable<B07_zglo>> GetAllZgloAsync();
        Task<IEnumerable<B07_zglo>> GetPageAsync(int pageIndex, int pageSize);
        Task<B07_zglo> GetZgloAsync(int id);

        Task AddAsync(B07_zglo zgloszenie);
        Task RemoveAsync(int id);
        Task UpdateAsync(B07_zglo zgloszenie, int id);
    }
}
