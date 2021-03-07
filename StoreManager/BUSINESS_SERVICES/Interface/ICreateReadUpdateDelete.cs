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
        public (T[] listPage, int pages, int page) Pagination(int page, int size = Constant.MEMBER_PAGE);
    }
}
