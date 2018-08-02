using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SM.Core.Paging
{
    public interface IPagedList<T> : IList<T>
    {
        int PageSize { get; }
        int PageIndex { get; }
        int TotalCount { get;  }
        int TotalPages { get; }
        bool HasPreviousPage { get; }
        bool HasNextPage { get;  }
        string SortOrder { get; }
        bool OrderAsc { get; }
    }
}
