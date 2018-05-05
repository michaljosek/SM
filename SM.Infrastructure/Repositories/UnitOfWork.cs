using SM.Core.Repositories;
using SM.Infrastructure.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SM.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SMContext _context;

        public UnitOfWork(SMContext context)
        {
            _context = context;
        }

        public async Task CompleteSMContextAsync()
            => await _context.SaveChangesAsync();

    }
}
