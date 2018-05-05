using SM.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SM.Infrastructure.EF;
using SM.Core.Paging;
using SM.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using SM.Core.Domain;

namespace SM.Infrastructure.Repositories
{
    public class B07_zgloRepository : IB07_zgloRepository
    {
        private readonly SMContext _context;

        public B07_zgloRepository(SMContext context)
        {
            _context = context;
        }

        public async Task<int> CountTotalAsync()
        {
            var counter = await _context.B07_zglos.CountAsync();

            return counter;
        }

        public async Task<IEnumerable<B07_zglo>> GetAllZgloAsync()
            => await Task.FromResult(_context.B07_zglos);

        public async Task<IEnumerable<B07_zglo>> GetPageAsync(int pageIndex = 1, int pageSize = 10)
        {
            var b07_zglo = await _context.B07_zglos.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();

            return b07_zglo;
        }

        public async Task<B07_zglo> GetZgloAsync(int id)
            => await _context.B07_zglos.AsQueryable().FirstOrDefaultAsync(x => x.B07_zgloId == id);

        public async Task AddAsync(B07_zglo zgloszenie)
        {
            if(zgloszenie != null)
            {
                _context.B07_zglos.Add(zgloszenie);
            }
            _context.B07_zglos.Add(zgloszenie);

            await Task.CompletedTask;
        }

        public async Task RemoveAsync(int id)
        {
            var zgloszenie = await GetZgloAsync(id);
            if(zgloszenie != null)
            {
                _context.B07_zglos.Remove(zgloszenie);
            }
            await Task.CompletedTask;
        }

        public async Task UpdateAsync(B07_zglo zgloszenie, int id)
        {
            var zgloszenieToUpdate = await GetZgloAsync(id);

            if(zgloszenieToUpdate != null)
            {
                try
                {
                    _context.Entry(zgloszenieToUpdate).CurrentValues.SetValues(zgloszenie);
                }
                catch(DbUpdateException ex)
                {
                    throw new Exception("Database update fail.", ex);
                }
            }

            await Task.CompletedTask;
        }
    }
}
