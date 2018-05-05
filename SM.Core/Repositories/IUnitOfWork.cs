using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SM.Core.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteSMContextAsync();
    }
}
