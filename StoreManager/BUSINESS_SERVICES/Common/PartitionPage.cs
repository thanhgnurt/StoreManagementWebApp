using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreManager.BUSINESS_SERVICES.Common
{
    public static class PartitionPage<T>
    {
        public static (T[] listPage, int pages, int page) PaginationCommon(HashSet<T> listItem, int page, int size)
        {
            int pages = (int)Math.Ceiling((double)listItem.Count / size);
            var listPage = listItem.Skip((page - 1) * size).Take(size).ToArray();
            return (listPage, pages, page);
        }
    }
}