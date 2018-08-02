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

        public async Task<IEnumerable<B07_zglo>> GetPageAsync(string sortOrder = "numer_zglo", bool orderAsc = true, int pageIndex = 1, int pageSize = 10)
        {
            List<B07_zglo> b07_zglo;

            if (orderAsc)
            {
                switch (sortOrder)
                {
                    case "numer_zglo":
                        b07_zglo = await _context.B07_zglos.OrderBy(x => x.numer_zglo).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
                        break;
                    case "data_zglos":
                        b07_zglo = await _context.B07_zglos.OrderBy(x => x.data_zglos).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
                        break;
                    case "nazwisko":
                        b07_zglo = await _context.B07_zglos.OrderBy(x => x.nazwisko).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
                        break;
                    case "id_adres":
                        b07_zglo = await _context.B07_zglos.OrderBy(x => x.id_adres).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
                        break;
                    case "rodzaj_ust":
                        b07_zglo = await _context.B07_zglos.OrderBy(x => x.rodzaj_ust).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
                        break;
                    case "uwagi_wyko":
                        b07_zglo = await _context.B07_zglos.OrderBy(x => x.uwagi_wyko).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
                        break;
                    case "data_tere":
                        b07_zglo = await _context.B07_zglos.OrderBy(x => x.data_tere).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
                        break;
                    default:  //by id
                        b07_zglo = await _context.B07_zglos.OrderBy(x => x.B07_zgloId).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
                        break;
                }
            }
            else
            {
                switch (sortOrder)
                {
                    case "numer_zglo":
                        b07_zglo = await _context.B07_zglos.OrderByDescending(x => x.numer_zglo).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
                        break;
                    case "data_zglos":
                        b07_zglo = await _context.B07_zglos.OrderByDescending(x => x.data_zglos).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
                        break;
                    case "nazwisko":
                        b07_zglo = await _context.B07_zglos.OrderByDescending(x => x.nazwisko).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
                        break;
                    case "id_adres":
                        b07_zglo = await _context.B07_zglos.OrderByDescending(x => x.id_adres).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
                        break;
                    case "rodzaj_ust":
                        b07_zglo = await _context.B07_zglos.OrderByDescending(x => x.rodzaj_ust).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
                        break;
                    case "uwagi_wyko":
                        b07_zglo = await _context.B07_zglos.OrderByDescending(x => x.uwagi_wyko).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
                        break;
                    case "data_tere":
                        b07_zglo = await _context.B07_zglos.OrderByDescending(x => x.data_tere).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
                        break;
                    default:  //by id
                        b07_zglo = await _context.B07_zglos.OrderByDescending(x => x.B07_zgloId).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
                        break;
                }
            }

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
