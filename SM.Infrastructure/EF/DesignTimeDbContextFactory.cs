using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SM.Infrastructure.EF
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<SMContext>
    {
        public SMContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SMContext>();

            var connectionString = "Server=(localdb)\\MSSQLLocalDb;Database=SM;Trusted_Connection=true;MultipleActiveResultSets=true;";

            builder.UseSqlServer(connectionString);

            return new SMContext(builder.Options);
        }
    }
}
