using SM.Core.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SM.Infrastructure.Extensions
{
    public static class IQueryableExtensions
    {
        //public static IQueryable<T> ApplyOrdering<T>(this IQueryable<T> query, PageQuery queryObject, Dictionary<string, Expression<Func<T, object>>> columnsMap)
        //{
        //    if (String.IsNullOrWhiteSpace(queryObject.SortBy) || !columnsMap.ContainsKey(queryObject.SortBy))
        //        return query;

        //    if (queryObject.IsSortAscending)
        //        return query.OrderBy(columnsMap[queryObject.SortBy]);
        //    else
        //        return query.OrderByDescending(columnsMap[queryObject.SortBy]);
        //}

        //public static IQueryable<T> ApplyPaging<T>(this IQueryable<T> query, PageQuery queryObject)
        //{
        //    if(queryObject.PageIndex <= 0)
        //    {
        //        queryObject.PageIndex = 1;
        //    }

        //    if(queryObject.PageSize <= 0)
        //    {
        //        queryObject.PageSize = 10;
        //    }

        //    queryObject.TotalCount = query.Count();
        //    queryObject.TotalPages = queryObject.TotalCount / queryObject.PageSize;
        //    if (queryObject.TotalCount % queryObject.PageSize > 0)
        //    {
        //        queryObject.TotalPages++;
        //    }

        //    var result = query.Skip((queryObject.PageIndex - 1) * queryObject.PageSize).Take(queryObject.PageSize);
        //    return result;
        //}
    }
}
