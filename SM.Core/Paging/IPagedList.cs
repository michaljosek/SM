using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SM.Core.Paging
{
    public interface IPagedList<T> : IList<T>
    {
        //string SortBy { get;}
        //bool IsSortAscending { get;}

        int PageSize { get; }
        int PageIndex { get; }
        int TotalCount { get; set; }
        int TotalPages { get; set; }
        bool HasPreviousPage { get; }
        bool HasNextPage { get;  }
    }
}
