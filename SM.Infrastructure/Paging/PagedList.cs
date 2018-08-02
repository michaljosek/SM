using Microsoft.EntityFrameworkCore;
using SM.Core.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SM.Infrastructure.Paging
{
    public class PagedList<T> : List<T>, IPagedList<T>
    {
        public List<T> ResultList { get; set; }

        public int PageIndex { get; private set; }
        public int PageSize { get; private set; }
        public int TotalCount { get; private set; }
        public int TotalPages { get; private set; }
        public string SortOrder { get; private set; }
        public bool OrderAsc { get; private set; }

        public bool HasPreviousPage
        {
            get { return (PageIndex > 1); }
        }
        public bool HasNextPage
        {
            get { return (PageIndex < TotalPages); }
        }

        public PagedList()
        {
        }

        public PagedList(List<T> items, int count, string sortOrder, bool orderAsc, int pageIndex, int pageSize)
        {
            if (pageIndex <= 0)
            {
                pageIndex = 1;
            }

            if (pageSize <= 0 && pageSize > 200)
            {
                pageSize = 10;
            }

            PageIndex = pageIndex;
            TotalPages = count / pageSize;
            if (count % pageSize > 0)
            {
                TotalPages++;
            }
            ResultList = new List<T>();
            ResultList = items;
            SortOrder = sortOrder;
            OrderAsc = orderAsc;
        }
    }
}