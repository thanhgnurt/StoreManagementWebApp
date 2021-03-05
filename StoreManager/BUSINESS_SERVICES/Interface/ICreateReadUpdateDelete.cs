using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManager.BUSINESS_SERVICES.Interface
{
    public interface ICreateReadUpdateDelete<T>
    {

        public T Get(string id);
        public void Add(T goods);
    }
}
