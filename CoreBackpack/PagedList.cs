using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBackpack
{
    public class PagedList<T> : List<T>
    {
        public PagedList() : base() { }

        public PagedList(IEnumerable<T> collection) : base(collection) { }

        public PagedList(IEnumerable<T> filteredCollection, int pageNumber, int pageSize, int totalRecords) : base(filteredCollection)
        {
            TotalRecords = totalRecords;
            CurrentPage = pageNumber;
            PageSize = pageSize;
        }

        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalRecords { get; set; }

        public JsonResult ToJson(Func<T, object> selectItems = null)
        {
            var data = new
            {
                Success = true,
                TotalRecords,
                Data = selectItems != null ? this.Select(selectItems).ToList() : this.Select(x => (object)x).ToList()
            };

            return new JsonResult(data);
        }

        public PagedList<U> Transform<U>(Func<T, U> transform)
        {
            return new PagedList<U>(this.Select(transform), CurrentPage, PageSize, TotalRecords);
        }
    }

    public static class PagedListExtensions
    {
        public static PagedList<T> ToPagedResult<T>(this IQueryable<T> query, int pageNumber, int pageSize) where T : class
        {
            var pagedResult = query.Skip(pageSize * pageNumber).Take(pageSize);

            return new PagedList<T>(pagedResult.ToList())
            {
                TotalRecords = query.Count(),
                CurrentPage = pageNumber,
                PageSize = pageSize
            };
        }
        public static PagedList<T> ToPagedResult<T>(this IEnumerable<T> query, int pageNumber, int pageSize) where T : class
        {
            var pagedResult = query.Skip(pageSize * pageNumber).Take(pageSize);

            return new PagedList<T>(pagedResult.ToList())
            {
                TotalRecords = query.Count(),
                CurrentPage = pageNumber,
                PageSize = pageSize
            };
        }

        public static async Task<PagedList<T>> ToPagedResultAsync<T>(this IQueryable<T> query, int pageNumber, int pageSize) where T : class
        {
            var results = await query.Skip(pageSize * pageNumber).Take(pageSize).ToListAsync();

            return new PagedList<T>(results)
            {
                TotalRecords = query.Count(),
                CurrentPage = pageNumber,
                PageSize = pageSize
            };
        }
    }
}