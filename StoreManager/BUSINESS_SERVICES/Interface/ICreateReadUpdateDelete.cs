using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreManager.CONSTANT;

namespace StoreManager.BUSINESS_SERVICES.Interface
{
    public interface ICreateReadUpdateDelete<T>
    {

        public T Get(string id);
        public void Add(T goods);
        public (T[] listPage, int pages, int page) DivideData(HashSet<T> listItem, int page, int size)
        {
            int pages = (int)Math.Ceiling((double)listItem.Count / size);
            var listPage = listItem.Skip((page - 1) * size).Take(size).ToArray();
            return (listPage, pages, page);
        }
    }
}
